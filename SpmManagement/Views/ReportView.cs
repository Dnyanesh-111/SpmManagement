using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpmManagement.Views
{
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void btnClientReport_Click(object sender, EventArgs e)
        {

            crystalReportViewer1.ReportSource = "C:\\Users\\care\\source\\repos\\SpmManagement\\SpmManagement\\Reports\\ClientReport.rpt";
        }

        private void btnProjectReport_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = "C:\\Users\\care\\source\\repos\\SpmManagement\\SpmManagement\\Reports\\ProjectReport.rpt";
        }

        private void btnTaskReport_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = "C:\\Users\\care\\source\\repos\\SpmManagement\\SpmManagement\\Reports\\TaskReport.rpt";
        }

    }
}
