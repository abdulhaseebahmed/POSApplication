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
    public partial class DateCriteriaForm : Form
    {

        public event EventHandler onSuccessfulDateSelect;
        private void SuccessfulDateSelect()
        {
            if (onSuccessfulDateSelect != null)
            {
                Model.AppConfig.ReportCriteria_FromDate = FromDate.SelectionRange.Start;
                Model.AppConfig.ReportCriteria_ToDate = ToDate.SelectionRange.Start;
                onSuccessfulDateSelect(Model.AppConfig.ReportCriteria_FromDate, null);
            }
        }

        public DateCriteriaForm()
        {
            InitializeComponent();
        }

        private void DateCriteriaForm_Load(object sender, EventArgs e)
        {

        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            SuccessfulDateSelect();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
