
namespace SpmManagement.Views
{
    partial class ReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnProjectReport = new System.Windows.Forms.Button();
            this.btnClientReport = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnTaskReport = new System.Windows.Forms.Button();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnTaskReport);
            this.panelControls.Controls.Add(this.btnProjectReport);
            this.panelControls.Controls.Add(this.btnClientReport);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1049, 53);
            this.panelControls.TabIndex = 0;
            // 
            // btnProjectReport
            // 
            this.btnProjectReport.Location = new System.Drawing.Point(199, 13);
            this.btnProjectReport.Name = "btnProjectReport";
            this.btnProjectReport.Size = new System.Drawing.Size(130, 34);
            this.btnProjectReport.TabIndex = 1;
            this.btnProjectReport.Text = "Project Report";
            this.btnProjectReport.UseVisualStyleBackColor = true;
            // 
            // btnClientReport
            // 
            this.btnClientReport.Location = new System.Drawing.Point(47, 12);
            this.btnClientReport.Name = "btnClientReport";
            this.btnClientReport.Size = new System.Drawing.Size(130, 34);
            this.btnClientReport.TabIndex = 0;
            this.btnClientReport.Text = "Client Report";
            this.btnClientReport.UseVisualStyleBackColor = true;
            this.btnClientReport.Click += new System.EventHandler(this.btnClientReport_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(443, 189);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 53);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1049, 678);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // btnTaskReport
            // 
            this.btnTaskReport.Location = new System.Drawing.Point(352, 13);
            this.btnTaskReport.Name = "btnTaskReport";
            this.btnTaskReport.Size = new System.Drawing.Size(130, 34);
            this.btnTaskReport.TabIndex = 2;
            this.btnTaskReport.Text = "Task Report";
            this.btnTaskReport.UseVisualStyleBackColor = true;
            this.btnTaskReport.Click += new System.EventHandler(this.btnTaskReport_Click);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 731);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelControls);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnClientReport;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnProjectReport;
        private System.Windows.Forms.Button btnTaskReport;
    }
}