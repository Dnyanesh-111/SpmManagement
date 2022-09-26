
namespace SpmManagement.Views
{
    partial class MainView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnRequirements = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.btnTasks);
            this.panel2.Controls.Add(this.btnProjects);
            this.panel2.Controls.Add(this.btnRequirements);
            this.panel2.Controls.Add(this.btnClients);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 566);
            this.panel2.TabIndex = 0;
            // 
            // btnProjects
            // 
            this.btnProjects.Location = new System.Drawing.Point(0, 203);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(197, 50);
            this.btnProjects.TabIndex = 2;
            this.btnProjects.Text = "Projects";
            this.btnProjects.UseVisualStyleBackColor = true;
            // 
            // btnRequirements
            // 
            this.btnRequirements.Location = new System.Drawing.Point(0, 147);
            this.btnRequirements.Name = "btnRequirements";
            this.btnRequirements.Size = new System.Drawing.Size(197, 50);
            this.btnRequirements.TabIndex = 1;
            this.btnRequirements.Text = "Requirements";
            this.btnRequirements.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(3, 91);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(197, 50);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(3, 259);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(197, 50);
            this.btnTasks.TabIndex = 3;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(977, 566);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnRequirements;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnTasks;
    }
}