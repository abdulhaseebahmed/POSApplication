using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApplication.Forms
{
    public partial class RegionsForm : Form
    {
        public RegionsForm()
        {
            InitializeComponent();
        }

        private void RegionsForm_Load(object sender, EventArgs e)
        {
            LoadExistingRegions();
        }

        public void LoadExistingRegions()
        {
            RegionsList.Items.Clear();
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var query = from d in dbCtx.regions
                            select new { Region = d.RegionName };

                foreach (var r in query)
                {
                    RegionsList.Items.Add(r.Region);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                //Creating a new reqion variable
                Model.region r = new Model.region();
                r.RegionName = RegionNameField.Text;
                dbCtx.regions.Add(r);

                // call SaveChanges method to save student into database
                dbCtx.SaveChanges();
            }
            LoadExistingRegions();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (RegionsList.SelectedItem != null)
            {
                deleteRegion(RegionsList.GetItemText(RegionsList.SelectedItem));
                RegionsList.Items.Remove(RegionsList.SelectedItem);
            }
        }

        public void deleteRegion(string regionName)
        {
            using (var dbCtx = new POSApplication.Model.posdbEntities())
            {
                var itemToRemove = dbCtx.regions.SingleOrDefault(x => x.RegionName == regionName);
                if (itemToRemove != null)
                {
                    dbCtx.regions.Remove(itemToRemove);
                    dbCtx.SaveChanges();
                }
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
