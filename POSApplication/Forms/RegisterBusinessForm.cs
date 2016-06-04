using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Globalization;

namespace POSApplication.Forms
{
    public partial class RegisterBusinessForm : Form
    {
        //Currency Codes
        //£
        //$
        //€
        //₹
        //﷼
        //₱
        //¥
        //Rp
        //kr
        //RS
        //RM

        public event EventHandler onSuccessfulPictureChange;
        private void SuccessfulPictureChange()
        {
            if (onSuccessfulPictureChange != null)
                onSuccessfulPictureChange(Model.AppConfig.loggedInUserName, null);
        }

        string filename = "";
        string filepath = "";
        string fileextension = "";
        bool ispicturechanged = false;
        public RegisterBusinessForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterBusinessForm_Load(object sender, EventArgs e)
        {
            //CurrencyNameList.Items.Add(System.Globalization.RegionInfo.CurrentRegion.ISOCurrencySymbol);
            //CurrencyNameList.Text = System.Globalization.RegionInfo.CurrentRegion.ISOCurrencySymbol;
            var culture = CultureInfo.CreateSpecificCulture("de-DE");    // german
            string currencySymbol = culture.NumberFormat.CurrencySymbol; // €
            CurrencyNameList.Items.Add(currencySymbol);
            culture = CultureInfo.CreateSpecificCulture("hi-IN");     // Hindi 
            currencySymbol = culture.NumberFormat.CurrencySymbol;     //  ₹
            CurrencyNameList.Items.Add(currencySymbol);

            culture = CultureInfo.CreateSpecificCulture("ur-PK");     // Hindi 
            currencySymbol = culture.NumberFormat.CurrencySymbol;     //  ₹
            CurrencyNameList.Items.Add(currencySymbol);

            culture = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.TextInfo.CultureName);     // US 
            currencySymbol = culture.NumberFormat.CurrencySymbol;     //  $
            CurrencyNameList.Items.Add(currencySymbol);


            showExistingBusinessInformation();
        }

        public void showExistingBusinessInformation()
        {
            try
            {
                using (var db = new Model.posdbEntities())
                {
                    var query = (from d in db.businesses
                                 select new
                                 {
                                     BusinessName = d.BusinessName,
                                     BusLogoFile = d.BusLogoFileName,
                                     City = d.City,
                                     Country = d.Country,
                                     CurrencyCode = d.CurrencyCode,
                                     State = d.State,
                                     Address = d.Address,
                                     CellNumber = d.CellNumber,
                                     EmailAddress = d.EmailAddress,
                                     OfficeNumber = d.OfficeNumber,
                                     Slogan = d.Slogan
                                 }).SingleOrDefault();
                    if (query != null)
                    {
                        var d = new Model.business();
                        BusinessNameField.Text = query.BusinessName;

                        string str = Application.ExecutablePath;
                        string applicationPath = Path.GetDirectoryName(Application.ExecutablePath);
                        var dir = new DirectoryInfo(applicationPath);
                        foreach (var file in dir.EnumerateFiles("companylogo.*"))
                        {
                            fileextension = file.Extension;
                        }
                        string destFile = System.IO.Path.Combine(applicationPath, "companylogo2" + fileextension);
                        filename = System.IO.Path.Combine(applicationPath, "companylogo" + fileextension);

                        //File.Delete(destFile);
                        //File.Copy(filename, destFile, true);


                        //File.Copy(System.IO.Path.Combine(applicationPath, "companylogo" + fileextension), System.IO.Path.Combine(applicationPath, "companylogo2" + fileextension), true);

                        FileStream fs = new FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        pictureBox1.Image = Image.FromStream(fs);
                        fs.Close();

                        CityNameField.Text = query.City;
                        CountryNameField.Text = query.Country;
                        CurrencyNameList.Text = query.CurrencyCode;
                        StateNameField.Text = query.State;
                        AddressField.Text = query.Address;
                        CellNumberField.Text = query.CellNumber;
                        EmailAddressField.Text = query.EmailAddress;
                        OfficeNumberField.Text = query.OfficeNumber;
                        BusinessSloganField.Text = query.Slogan;
                        //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }

            }
            catch (Exception e)
            {

            }
        }
        //public string convertSlashes(string str)
        //{
        //    //str = str.Replace("\\\\", "\\");
        //    //str = str.Replace(":", "|");
        //    str = StringCipher.Encrypt(str, "filepath");
        //    return str;
        //}

        //public string revertSlashes(String str)
        //{
        //    str = StringCipher.Decrypt(str, "filepath");
        //    return str;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            DialogResult result = opf.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                //CellNumberField.Text = opf.FileName;
                if (opf.FileName.Length > 0)
                {
                    ispicturechanged = true;
                    filename = opf.FileName;
                    fileextension = Path.GetExtension(filename);
                    filepath = Path.GetDirectoryName(filename);
                    FileStream fs = new FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    pictureBox1.Image = Image.FromStream(fs);
                    fs.Close();
                }
            }
            //Console.WriteLine(result); // <-- For debugging use.
        }

        public int saveBusinessInformation()
        {
            string applicationPath = Path.GetDirectoryName(Application.ExecutablePath);
            string destFile = System.IO.Path.Combine(applicationPath, "companylogo" + fileextension);

            string businessname = "";
            string addressfield = "";
            string citynamefield = "";
            string statenamefield = "";
            string countrynamefield = "";
            string currencycodefield = "";
            string cellnumber = "";
            string officenumber = "";
            string emailaddress = "";
            string businessslogan = "";

            if (filename.Length > 0 && ispicturechanged == true)
            {
                var dir = new DirectoryInfo(applicationPath);
                foreach (var file in dir.EnumerateFiles("companylogo.*"))
                {
                    file.Delete();
                }
                File.Copy(filename, destFile, true);
                Model.AppConfig.imagefile = destFile;

                if(BusinessSloganField.Text.Length>0)
                {
                    Model.AppConfig.businessSlogan = BusinessNameField.Text;
                }

                FileStream fs = new FileStream(Model.AppConfig.imagefile, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                pictureBox1.Image = Image.FromStream(fs);
                fs.Close();
            }

            try
            {
                if (BusinessNameField.Text.Length > 0)
                {
                    businessname = BusinessNameField.Text;
                }
                else
                {
                    MessageBox.Show("Enter business name");
                    return 0;
                }
                if (AddressField.Text.Length > 0)
                {
                    addressfield = AddressField.Text;
                }
                else
                {
                    MessageBox.Show("Enter business address");
                    return 0;
                }
                if (CityNameField.Text.Length > 0)
                {
                    citynamefield = CityNameField.Text;
                }
                if (StateNameField.Text.Length > 0)
                {
                    statenamefield = StateNameField.Text;
                }
                if (CountryNameField.Text.Length > 0)
                {
                    countrynamefield = CountryNameField.Text;
                }
                else
                {
                    MessageBox.Show("Enter Country name");
                    return 0;
                }
                if (CurrencyNameList.GetItemText(CurrencyNameList.SelectedItem).Length > 0)
                {
                    currencycodefield = CurrencyNameList.GetItemText(CurrencyNameList.SelectedItem).ToString();
                }
                else
                {
                    MessageBox.Show("Enter Currency Code");
                    return 0;
                }

                if (CellNumberField.Text.Length > 0)
                {
                    cellnumber = CellNumberField.Text;
                }

                if (OfficeNumberField.Text.Length > 0)
                {
                    officenumber = OfficeNumberField.Text;
                }

                if (EmailAddressField.Text.Length > 0)
                {
                    emailaddress = EmailAddressField.Text;
                }

                if (BusinessSloganField.Text.Length > 0)
                {
                    businessslogan = BusinessSloganField.Text;
                }

                using (var db = new Model.posdbEntities())
                {
                    var query = (from d in db.businesses
                                 select new { BusinessID = d.BusinessID }).SingleOrDefault();
                    if (query == null)
                    {
                        var d = new Model.business();
                        d.BusinessName = businessname;
                        d.Address = addressfield;
                        //string str = convertSlashes(filename);
                        //d.BusLogoFileName = str;
                        string str = "companylogo" + Path.GetExtension(filename);
                        d.BusLogoFileName = str;
                        d.City = citynamefield;
                        d.Country = countrynamefield;
                        d.CurrencyCode = currencycodefield;
                        d.State = statenamefield;
                        //pictureBox1.Image = null;
                        
                        System.Text.RegularExpressions.Regex regex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
                        Match match = regex.Match(emailaddress);
                        if (match.Success)
                        {
                            d.EmailAddress = emailaddress;
                            d.OfficeNumber = officenumber;
                            d.CellNumber = cellnumber;
                            d.Slogan = businessslogan;
                            db.businesses.Add(d);
                            db.SaveChanges();
                            MessageBox.Show("New Business has been registered.");
                            SuccessfulPictureChange();
                            return 1;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email Address.");
                        }

                        
                    }
                    else
                    {
                        var original = db.businesses.Find(query.BusinessID);
                        if (original != null)
                        {
                            original.BusinessID = query.BusinessID;
                            original.BusinessName = businessname;
                            original.Address = addressfield;
                            //string str = convertSlashes(filename);
                            //original.BusLogoFileName = str;
                            string str = "companylogo" + Path.GetExtension(filename);
                            original.BusLogoFileName = str;
                            original.City = citynamefield;
                            original.Country = countrynamefield;
                            original.CurrencyCode = currencycodefield;
                            original.State = statenamefield;

                            System.Text.RegularExpressions.Regex regex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
                            Match match = regex.Match(emailaddress);
                            if (match.Success)
                            {
                                original.EmailAddress = emailaddress;
                                original.OfficeNumber = officenumber;
                                original.CellNumber = cellnumber;
                                original.Slogan = businessslogan;
                                Model.AppConfig.businessSlogan = businessslogan;
                                //pictureBox1.Image = null;
                                db.SaveChanges();
                                MessageBox.Show("Business Information has been updated.");
                                SuccessfulPictureChange();
                                return 1;
                            }
                            else
                            {
                                MessageBox.Show("Invalid Email Address.");
                            }
                        }
                    }
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException e1)
            {
                MessageBox.Show(e1.Message);
            }
            return 0;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveBusinessInformation();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBusinessTypeButton_Click(object sender, EventArgs e)
        {
            //add code here to add new business types
            MessageBox.Show("Add new business types");
        }
    }
}
