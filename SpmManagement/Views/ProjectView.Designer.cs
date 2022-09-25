﻿
namespace SpmManagement.Views
{
    partial class ProjectView
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.txtTeamRole = new System.Windows.Forms.ComboBox();
            this.txtTeamMember = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAssignTeam = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.Button();
            this.dateCompletion = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.txtCname = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
          
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
           
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1040, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 34);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 53);
            this.panel1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.btnCancel2);
            this.tabPage3.Controls.Add(this.btnSave2);
            this.tabPage3.Controls.Add(this.txtTeamRole);
            this.tabPage3.Controls.Add(this.txtTeamMember);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtTeam);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1080, 605);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Assign Team";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(38, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(877, 377);
            this.dataGridView2.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(954, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 34);
            this.button4.TabIndex = 14;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.Location = new System.Drawing.Point(954, 410);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(103, 34);
            this.btnCancel2.TabIndex = 13;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            // 
            // btnSave2
            // 
            this.btnSave2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.Location = new System.Drawing.Point(954, 368);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(103, 36);
            this.btnSave2.TabIndex = 12;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            // 
            // txtTeamRole
            // 
            this.txtTeamRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamRole.FormattingEnabled = true;
            this.txtTeamRole.Items.AddRange(new object[] {
            "Leader",
            "UI/UX Designer",
            "Front-End Developer",
            "Back-End Developer"});
            this.txtTeamRole.Location = new System.Drawing.Point(465, 129);
            this.txtTeamRole.Name = "txtTeamRole";
            this.txtTeamRole.Size = new System.Drawing.Size(360, 31);
            this.txtTeamRole.TabIndex = 11;
            // 
            // txtTeamMember
            // 
            this.txtTeamMember.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamMember.FormattingEnabled = true;
            this.txtTeamMember.Items.AddRange(new object[] {
            "employee1",
            "employee2",
            "employee3",
            "employee4"});
            this.txtTeamMember.Location = new System.Drawing.Point(35, 129);
            this.txtTeamMember.Name = "txtTeamMember";
            this.txtTeamMember.Size = new System.Drawing.Size(360, 31);
            this.txtTeamMember.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(460, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 28);
            this.label12.TabIndex = 8;
            this.label12.Text = "Select Role";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "Select Employee";
            // 
            // txtTeam
            // 
            this.txtTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam.Location = new System.Drawing.Point(35, 49);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(157, 30);
            this.txtTeam.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "Team ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtStatus);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnAssignTeam);
            this.tabPage2.Controls.Add(this.txtFile);
            this.tabPage2.Controls.Add(this.dateCompletion);
            this.tabPage2.Controls.Add(this.dateStart);
            this.tabPage2.Controls.Add(this.txtCname);
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtCost);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Project";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Created",
            "Ongoing",
            "On Hold",
            "Completed"});
            this.txtStatus.Location = new System.Drawing.Point(36, 440);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(331, 31);
            this.txtStatus.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 28);
            this.label13.TabIndex = 23;
            this.label13.Text = "Status";
            // 
            // btnAssignTeam
            // 
            this.btnAssignTeam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTeam.Location = new System.Drawing.Point(437, 498);
            this.btnAssignTeam.Name = "btnAssignTeam";
            this.btnAssignTeam.Size = new System.Drawing.Size(118, 34);
            this.btnAssignTeam.TabIndex = 22;
            this.btnAssignTeam.Text = "Assign Team";
            this.btnAssignTeam.UseVisualStyleBackColor = true;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(36, 241);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(331, 35);
            this.txtFile.TabIndex = 21;
            this.txtFile.Text = "Select File ";
            this.txtFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFile.UseVisualStyleBackColor = true;
            // 
            // dateCompletion
            // 
            this.dateCompletion.Location = new System.Drawing.Point(476, 343);
            this.dateCompletion.Name = "dateCompletion";
            this.dateCompletion.Size = new System.Drawing.Size(331, 30);
            this.dateCompletion.TabIndex = 20;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(36, 343);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(331, 30);
            this.dateStart.TabIndex = 19;
            // 
            // txtCname
            // 
            this.txtCname.DataSource = this.clientsBindingSource;
            this.txtCname.DisplayMember = "cname";
            this.txtCname.FormattingEnabled = true;
            this.txtCname.Location = new System.Drawing.Point(476, 145);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(331, 31);
            this.txtCname.TabIndex = 18;
            this.txtCname.ValueMember = "cname";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(706, 498);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 34);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(572, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 34);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(471, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "Completion Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Start Date";
            // 
            // txtCost
            // 
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(476, 241);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(331, 30);
            this.txtCost.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(36, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(331, 30);
            this.txtName.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(36, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(157, 30);
            this.txtId.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Requirement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project ID:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnAddNew);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Project List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(742, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(742, 134);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 34);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(742, 94);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(118, 34);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 378);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(724, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(696, 34);
            this.txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Project:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 634);
            this.tabControl1.TabIndex = 4;
            // 
           
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            // 
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 687);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectView";
            this.Text = "ProjectView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.ComboBox txtTeamRole;
        private System.Windows.Forms.ComboBox txtTeamMember;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAssignTeam;
        private System.Windows.Forms.Button txtFile;
        private System.Windows.Forms.DateTimePicker dateCompletion;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.ComboBox txtCname;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
     
    }
}