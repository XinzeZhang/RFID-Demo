﻿namespace FinalInsert
{
    partial class FinalInsert
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
            if(disposing && (components != null))
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
            this.menuStrip_panel = new System.Windows.Forms.MenuStrip();
            this.InsertAthlete_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Configuration_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Connect_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Disconnect_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备端口号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commport_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.设备频率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boundrate_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.数据设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据区域ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataregion_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.起始地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataaddress_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.pf_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.power_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.使用地区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freqtype_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.pfset_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pfconfig_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ant_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subant_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ant1_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ant2_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ant3_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ant4_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antset_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antconfig_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.read_button = new System.Windows.Forms.Button();
            this.write_textBox = new System.Windows.Forms.TextBox();
            this.write_button = new System.Windows.Forms.Button();
            this.panel_InsertAthlete = new System.Windows.Forms.Panel();
            this.groupBox_checkinfo = new System.Windows.Forms.GroupBox();
            this.dataGridView_checkinfo = new System.Windows.Forms.DataGridView();
            this.AtheleteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContestantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AthleteOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AthleteStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_project = new System.Windows.Forms.GroupBox();
            this.dataGridView_projectinfo = new System.Windows.Forms.DataGridView();
            this.ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AthletesNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_checkin = new System.Windows.Forms.GroupBox();
            this.sex_comboBox = new System.Windows.Forms.ComboBox();
            this.sex_label = new System.Windows.Forms.Label();
            this.AthleteID_label = new System.Windows.Forms.Label();
            this.contestant_comboBox = new System.Windows.Forms.ComboBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label_contestant = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.project_textBox = new System.Windows.Forms.TextBox();
            this.label_project = new System.Windows.Forms.Label();
            this.label_playingfield = new System.Windows.Forms.Label();
            this.playingfield_comboBox = new System.Windows.Forms.ComboBox();
            this.Read_timer = new System.Windows.Forms.Timer(this.components);
            this.datalength_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.数据单元ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_panel.SuspendLayout();
            this.panel_InsertAthlete.SuspendLayout();
            this.groupBox_checkinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_checkinfo)).BeginInit();
            this.groupBox_project.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projectinfo)).BeginInit();
            this.groupBox_checkin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_panel
            // 
            this.menuStrip_panel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertAthlete_ToolStripMenuItem,
            this.Configuration_ToolStripMenuItem});
            this.menuStrip_panel.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_panel.Name = "menuStrip_panel";
            this.menuStrip_panel.Size = new System.Drawing.Size(1350, 33);
            this.menuStrip_panel.TabIndex = 0;
            this.menuStrip_panel.Text = "menuStrip1";
            // 
            // InsertAthlete_ToolStripMenuItem
            // 
            this.InsertAthlete_ToolStripMenuItem.Name = "InsertAthlete_ToolStripMenuItem";
            this.InsertAthlete_ToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.InsertAthlete_ToolStripMenuItem.Text = "运动员注册";
            // 
            // Configuration_ToolStripMenuItem
            // 
            this.Configuration_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接设置ToolStripMenuItem,
            this.pf_ToolStripMenuItem,
            this.ant_ToolStripMenuItem,
            this.数据设置ToolStripMenuItem});
            this.Configuration_ToolStripMenuItem.Name = "Configuration_ToolStripMenuItem";
            this.Configuration_ToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.Configuration_ToolStripMenuItem.Text = "设备配置";
            // 
            // 连接设置ToolStripMenuItem
            // 
            this.连接设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connect_ToolStripMenuItem,
            this.Disconnect_ToolStripMenuItem,
            this.设备端口号ToolStripMenuItem,
            this.设备频率ToolStripMenuItem});
            this.连接设置ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.连接设置ToolStripMenuItem.Name = "连接设置ToolStripMenuItem";
            this.连接设置ToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.连接设置ToolStripMenuItem.Text = "连接设置";
            // 
            // Connect_ToolStripMenuItem
            // 
            this.Connect_ToolStripMenuItem.Name = "Connect_ToolStripMenuItem";
            this.Connect_ToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.Connect_ToolStripMenuItem.Text = "连接设备";
            this.Connect_ToolStripMenuItem.Click += new System.EventHandler(this.Connect_ToolStripMenuItem_Click);
            // 
            // Disconnect_ToolStripMenuItem
            // 
            this.Disconnect_ToolStripMenuItem.Name = "Disconnect_ToolStripMenuItem";
            this.Disconnect_ToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.Disconnect_ToolStripMenuItem.Text = "断开连接";
            this.Disconnect_ToolStripMenuItem.Click += new System.EventHandler(this.Disconnect_ToolStripMenuItem_Click);
            // 
            // 设备端口号ToolStripMenuItem
            // 
            this.设备端口号ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commport_toolStripComboBox});
            this.设备端口号ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.设备端口号ToolStripMenuItem.Name = "设备端口号ToolStripMenuItem";
            this.设备端口号ToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.设备端口号ToolStripMenuItem.Text = "设备端口号";
            // 
            // commport_toolStripComboBox
            // 
            this.commport_toolStripComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commport_toolStripComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.commport_toolStripComboBox.Name = "commport_toolStripComboBox";
            this.commport_toolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // 设备频率ToolStripMenuItem
            // 
            this.设备频率ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boundrate_toolStripComboBox});
            this.设备频率ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.设备频率ToolStripMenuItem.Name = "设备频率ToolStripMenuItem";
            this.设备频率ToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.设备频率ToolStripMenuItem.Text = "设备频率";
            // 
            // boundrate_toolStripComboBox
            // 
            this.boundrate_toolStripComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.boundrate_toolStripComboBox.Name = "boundrate_toolStripComboBox";
            this.boundrate_toolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // 数据设置ToolStripMenuItem
            // 
            this.数据设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据区域ToolStripMenuItem,
            this.起始地址ToolStripMenuItem,
            this.数据单元ToolStripMenuItem});
            this.数据设置ToolStripMenuItem.Name = "数据设置ToolStripMenuItem";
            this.数据设置ToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.数据设置ToolStripMenuItem.Text = "数据设置";
            // 
            // 数据区域ToolStripMenuItem
            // 
            this.数据区域ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataregion_toolStripComboBox});
            this.数据区域ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数据区域ToolStripMenuItem.Name = "数据区域ToolStripMenuItem";
            this.数据区域ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.数据区域ToolStripMenuItem.Text = "数据区域";
            // 
            // dataregion_toolStripComboBox
            // 
            this.dataregion_toolStripComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataregion_toolStripComboBox.Items.AddRange(new object[] {
            "RESERVE",
            "EPC",
            "TID",
            "USER"});
            this.dataregion_toolStripComboBox.Name = "dataregion_toolStripComboBox";
            this.dataregion_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // 起始地址ToolStripMenuItem
            // 
            this.起始地址ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataaddress_toolStripComboBox});
            this.起始地址ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.起始地址ToolStripMenuItem.Name = "起始地址ToolStripMenuItem";
            this.起始地址ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.起始地址ToolStripMenuItem.Text = "起始单元";
            this.起始地址ToolStripMenuItem.Visible = false;
            // 
            // dataaddress_toolStripComboBox
            // 
            this.dataaddress_toolStripComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataaddress_toolStripComboBox.Name = "dataaddress_toolStripComboBox";
            this.dataaddress_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.dataaddress_toolStripComboBox.Visible = false;
            // 
            // pf_ToolStripMenuItem
            // 
            this.pf_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功率ToolStripMenuItem,
            this.使用地区ToolStripMenuItem,
            this.pfset_ToolStripMenuItem,
            this.pfconfig_ToolStripMenuItem});
            this.pf_ToolStripMenuItem.Name = "pf_ToolStripMenuItem";
            this.pf_ToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.pf_ToolStripMenuItem.Text = "功率与地区";
            // 
            // 功率ToolStripMenuItem
            // 
            this.功率ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.power_toolStripComboBox});
            this.功率ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.功率ToolStripMenuItem.Name = "功率ToolStripMenuItem";
            this.功率ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.功率ToolStripMenuItem.Text = "功率";
            // 
            // power_toolStripComboBox
            // 
            this.power_toolStripComboBox.Name = "power_toolStripComboBox";
            this.power_toolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // 使用地区ToolStripMenuItem
            // 
            this.使用地区ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freqtype_toolStripComboBox});
            this.使用地区ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.使用地区ToolStripMenuItem.Name = "使用地区ToolStripMenuItem";
            this.使用地区ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.使用地区ToolStripMenuItem.Text = "使用地区";
            // 
            // freqtype_toolStripComboBox
            // 
            this.freqtype_toolStripComboBox.Items.AddRange(new object[] {
            "CHINA",
            "AMERICA",
            "EUROUP",
            "OTHER"});
            this.freqtype_toolStripComboBox.Name = "freqtype_toolStripComboBox";
            this.freqtype_toolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // pfset_ToolStripMenuItem
            // 
            this.pfset_ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pfset_ToolStripMenuItem.Name = "pfset_ToolStripMenuItem";
            this.pfset_ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.pfset_ToolStripMenuItem.Text = "保存修改";
            this.pfset_ToolStripMenuItem.Click += new System.EventHandler(this.pfset_ToolStripMenuItem_Click);
            // 
            // pfconfig_ToolStripMenuItem
            // 
            this.pfconfig_ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pfconfig_ToolStripMenuItem.Name = "pfconfig_ToolStripMenuItem";
            this.pfconfig_ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.pfconfig_ToolStripMenuItem.Text = "刷新参数";
            this.pfconfig_ToolStripMenuItem.Click += new System.EventHandler(this.pfconfig_ToolStripMenuItem_Click);
            // 
            // ant_ToolStripMenuItem
            // 
            this.ant_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subant_ToolStripMenuItem,
            this.antset_ToolStripMenuItem,
            this.antconfig_ToolStripMenuItem});
            this.ant_ToolStripMenuItem.Name = "ant_ToolStripMenuItem";
            this.ant_ToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.ant_ToolStripMenuItem.Text = "天线";
            // 
            // subant_ToolStripMenuItem
            // 
            this.subant_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ant1_ToolStripMenuItem,
            this.ant2_ToolStripMenuItem,
            this.ant3_ToolStripMenuItem,
            this.ant4_ToolStripMenuItem});
            this.subant_ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.subant_ToolStripMenuItem.Name = "subant_ToolStripMenuItem";
            this.subant_ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.subant_ToolStripMenuItem.Text = "子天线";
            // 
            // ant1_ToolStripMenuItem
            // 
            this.ant1_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ant1_ToolStripMenuItem.Name = "ant1_ToolStripMenuItem";
            this.ant1_ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.ant1_ToolStripMenuItem.Text = "天线1";
            this.ant1_ToolStripMenuItem.Click += new System.EventHandler(this.ant1_ToolStripMenuItem_Click);
            // 
            // ant2_ToolStripMenuItem
            // 
            this.ant2_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ant2_ToolStripMenuItem.Name = "ant2_ToolStripMenuItem";
            this.ant2_ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.ant2_ToolStripMenuItem.Text = "天线2";
            this.ant2_ToolStripMenuItem.Click += new System.EventHandler(this.ant2_ToolStripMenuItem_Click);
            // 
            // ant3_ToolStripMenuItem
            // 
            this.ant3_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ant3_ToolStripMenuItem.Name = "ant3_ToolStripMenuItem";
            this.ant3_ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.ant3_ToolStripMenuItem.Text = "天线3";
            this.ant3_ToolStripMenuItem.Click += new System.EventHandler(this.ant3_ToolStripMenuItem_Click);
            // 
            // ant4_ToolStripMenuItem
            // 
            this.ant4_ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ant4_ToolStripMenuItem.Name = "ant4_ToolStripMenuItem";
            this.ant4_ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.ant4_ToolStripMenuItem.Text = "天线4";
            this.ant4_ToolStripMenuItem.Click += new System.EventHandler(this.ant4_ToolStripMenuItem_Click);
            // 
            // antset_ToolStripMenuItem
            // 
            this.antset_ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.antset_ToolStripMenuItem.Name = "antset_ToolStripMenuItem";
            this.antset_ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.antset_ToolStripMenuItem.Text = "保存修改";
            this.antset_ToolStripMenuItem.Click += new System.EventHandler(this.antset_ToolStripMenuItem_Click);
            // 
            // antconfig_ToolStripMenuItem
            // 
            this.antconfig_ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.antconfig_ToolStripMenuItem.Name = "antconfig_ToolStripMenuItem";
            this.antconfig_ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.antconfig_ToolStripMenuItem.Text = "刷新参数";
            this.antconfig_ToolStripMenuItem.Click += new System.EventHandler(this.antconfig_ToolStripMenuItem_Click);
            // 
            // read_button
            // 
            this.read_button.Location = new System.Drawing.Point(1075, 45);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(95, 53);
            this.read_button.TabIndex = 13;
            this.read_button.Text = "读取";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // write_textBox
            // 
            this.write_textBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.write_textBox.Location = new System.Drawing.Point(836, 95);
            this.write_textBox.Name = "write_textBox";
            this.write_textBox.Size = new System.Drawing.Size(76, 29);
            this.write_textBox.TabIndex = 10;
            this.write_textBox.Click += new System.EventHandler(this.write_textBox_Click);
            // 
            // write_button
            // 
            this.write_button.Location = new System.Drawing.Point(1200, 45);
            this.write_button.Name = "write_button";
            this.write_button.Size = new System.Drawing.Size(95, 53);
            this.write_button.TabIndex = 12;
            this.write_button.Text = "写入";
            this.write_button.UseVisualStyleBackColor = true;
            this.write_button.Click += new System.EventHandler(this.write_button_Click);
            // 
            // panel_InsertAthlete
            // 
            this.panel_InsertAthlete.AutoSize = true;
            this.panel_InsertAthlete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_InsertAthlete.Controls.Add(this.groupBox_checkinfo);
            this.panel_InsertAthlete.Controls.Add(this.groupBox_project);
            this.panel_InsertAthlete.Controls.Add(this.groupBox_checkin);
            this.panel_InsertAthlete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_InsertAthlete.Location = new System.Drawing.Point(0, 33);
            this.panel_InsertAthlete.Name = "panel_InsertAthlete";
            this.panel_InsertAthlete.Size = new System.Drawing.Size(1350, 696);
            this.panel_InsertAthlete.TabIndex = 17;
            // 
            // groupBox_checkinfo
            // 
            this.groupBox_checkinfo.Controls.Add(this.dataGridView_checkinfo);
            this.groupBox_checkinfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_checkinfo.Location = new System.Drawing.Point(728, 173);
            this.groupBox_checkinfo.Name = "groupBox_checkinfo";
            this.groupBox_checkinfo.Size = new System.Drawing.Size(604, 498);
            this.groupBox_checkinfo.TabIndex = 5;
            this.groupBox_checkinfo.TabStop = false;
            this.groupBox_checkinfo.Text = "检录信息";
            // 
            // dataGridView_checkinfo
            // 
            this.dataGridView_checkinfo.AllowUserToAddRows = false;
            this.dataGridView_checkinfo.AllowUserToDeleteRows = false;
            this.dataGridView_checkinfo.AllowUserToOrderColumns = true;
            this.dataGridView_checkinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_checkinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AtheleteName,
            this.ContestantName,
            this.AthleteOrder,
            this.AthleteStatus});
            this.dataGridView_checkinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_checkinfo.Location = new System.Drawing.Point(3, 25);
            this.dataGridView_checkinfo.Name = "dataGridView_checkinfo";
            this.dataGridView_checkinfo.Size = new System.Drawing.Size(598, 470);
            this.dataGridView_checkinfo.TabIndex = 0;
            this.dataGridView_checkinfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_checkinfo_CellFormatting);
            // 
            // AtheleteName
            // 
            this.AtheleteName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AtheleteName.DataPropertyName = "Name";
            this.AtheleteName.HeaderText = "姓名";
            this.AtheleteName.Name = "AtheleteName";
            this.AtheleteName.Width = 67;
            // 
            // ContestantName
            // 
            this.ContestantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContestantName.DataPropertyName = "ContestantName";
            this.ContestantName.HeaderText = "参赛单位";
            this.ContestantName.Name = "ContestantName";
            // 
            // AthleteOrder
            // 
            this.AthleteOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AthleteOrder.DataPropertyName = "AthleteOrder";
            this.AthleteOrder.HeaderText = "顺序";
            this.AthleteOrder.Name = "AthleteOrder";
            this.AthleteOrder.Width = 67;
            // 
            // AthleteStatus
            // 
            this.AthleteStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AthleteStatus.DataPropertyName = "AthleteStatu";
            this.AthleteStatus.HeaderText = "状态";
            this.AthleteStatus.Name = "AthleteStatus";
            this.AthleteStatus.Width = 67;
            // 
            // groupBox_project
            // 
            this.groupBox_project.Controls.Add(this.dataGridView_projectinfo);
            this.groupBox_project.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_project.Location = new System.Drawing.Point(12, 170);
            this.groupBox_project.Name = "groupBox_project";
            this.groupBox_project.Size = new System.Drawing.Size(648, 501);
            this.groupBox_project.TabIndex = 4;
            this.groupBox_project.TabStop = false;
            this.groupBox_project.Text = "竞赛项目信息";
            // 
            // dataGridView_projectinfo
            // 
            this.dataGridView_projectinfo.AllowUserToAddRows = false;
            this.dataGridView_projectinfo.AllowUserToDeleteRows = false;
            this.dataGridView_projectinfo.AllowUserToOrderColumns = true;
            this.dataGridView_projectinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_projectinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectId,
            this.ProjectName,
            this.AthletesNum,
            this.ProjectOrder,
            this.FieldId,
            this.Status});
            this.dataGridView_projectinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_projectinfo.Location = new System.Drawing.Point(3, 25);
            this.dataGridView_projectinfo.Name = "dataGridView_projectinfo";
            this.dataGridView_projectinfo.ReadOnly = true;
            this.dataGridView_projectinfo.Size = new System.Drawing.Size(642, 473);
            this.dataGridView_projectinfo.TabIndex = 0;
            this.dataGridView_projectinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_projectinfo_CellClick);
            this.dataGridView_projectinfo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_projectinfo_CellEnter);
            this.dataGridView_projectinfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_projectinfo_CellFormatting);
            // 
            // ProjectId
            // 
            this.ProjectId.DataPropertyName = "Id";
            this.ProjectId.HeaderText = "ID";
            this.ProjectId.Name = "ProjectId";
            this.ProjectId.ReadOnly = true;
            this.ProjectId.Visible = false;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectName.DataPropertyName = "CompetitionProjectName";
            this.ProjectName.HeaderText = "竞赛项目";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Width = 99;
            // 
            // AthletesNum
            // 
            this.AthletesNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AthletesNum.DataPropertyName = "AthletesNum";
            this.AthletesNum.HeaderText = "人数";
            this.AthletesNum.Name = "AthletesNum";
            this.AthletesNum.ReadOnly = true;
            // 
            // ProjectOrder
            // 
            this.ProjectOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectOrder.DataPropertyName = "CompetitionProjectOrder";
            this.ProjectOrder.HeaderText = "顺序";
            this.ProjectOrder.Name = "ProjectOrder";
            this.ProjectOrder.ReadOnly = true;
            // 
            // FieldId
            // 
            this.FieldId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldId.DataPropertyName = "PlayingFiledId";
            this.FieldId.HeaderText = "场地";
            this.FieldId.Name = "FieldId";
            this.FieldId.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Status.DataPropertyName = "Statu";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 67;
            // 
            // groupBox_checkin
            // 
            this.groupBox_checkin.Controls.Add(this.sex_comboBox);
            this.groupBox_checkin.Controls.Add(this.sex_label);
            this.groupBox_checkin.Controls.Add(this.AthleteID_label);
            this.groupBox_checkin.Controls.Add(this.contestant_comboBox);
            this.groupBox_checkin.Controls.Add(this.write_textBox);
            this.groupBox_checkin.Controls.Add(this.read_button);
            this.groupBox_checkin.Controls.Add(this.write_button);
            this.groupBox_checkin.Controls.Add(this.name_textBox);
            this.groupBox_checkin.Controls.Add(this.label_contestant);
            this.groupBox_checkin.Controls.Add(this.label_name);
            this.groupBox_checkin.Controls.Add(this.project_textBox);
            this.groupBox_checkin.Controls.Add(this.label_project);
            this.groupBox_checkin.Controls.Add(this.label_playingfield);
            this.groupBox_checkin.Controls.Add(this.playingfield_comboBox);
            this.groupBox_checkin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_checkin.Location = new System.Drawing.Point(12, 17);
            this.groupBox_checkin.Name = "groupBox_checkin";
            this.groupBox_checkin.Size = new System.Drawing.Size(1317, 146);
            this.groupBox_checkin.TabIndex = 3;
            this.groupBox_checkin.TabStop = false;
            // 
            // sex_comboBox
            // 
            this.sex_comboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "男",
            "女"});
            this.sex_comboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sex_comboBox.FormattingEnabled = true;
            this.sex_comboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex_comboBox.Location = new System.Drawing.Point(993, 95);
            this.sex_comboBox.Name = "sex_comboBox";
            this.sex_comboBox.Size = new System.Drawing.Size(50, 29);
            this.sex_comboBox.TabIndex = 11;
            // 
            // sex_label
            // 
            this.sex_label.AutoSize = true;
            this.sex_label.Location = new System.Drawing.Point(933, 95);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(54, 28);
            this.sex_label.TabIndex = 19;
            this.sex_label.Text = "性别";
            // 
            // AthleteID_label
            // 
            this.AthleteID_label.AutoSize = true;
            this.AthleteID_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AthleteID_label.Location = new System.Drawing.Point(725, 95);
            this.AthleteID_label.Name = "AthleteID_label";
            this.AthleteID_label.Size = new System.Drawing.Size(97, 28);
            this.AthleteID_label.TabIndex = 18;
            this.AthleteID_label.Text = "运动员ID";
            // 
            // contestant_comboBox
            // 
            this.contestant_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.contestant_comboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contestant_comboBox.FormattingEnabled = true;
            this.contestant_comboBox.Location = new System.Drawing.Point(836, 55);
            this.contestant_comboBox.Name = "contestant_comboBox";
            this.contestant_comboBox.Size = new System.Drawing.Size(207, 29);
            this.contestant_comboBox.TabIndex = 9;
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_textBox.Location = new System.Drawing.Point(836, 19);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(207, 29);
            this.name_textBox.TabIndex = 8;
            // 
            // label_contestant
            // 
            this.label_contestant.AutoSize = true;
            this.label_contestant.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_contestant.Location = new System.Drawing.Point(725, 55);
            this.label_contestant.Name = "label_contestant";
            this.label_contestant.Size = new System.Drawing.Size(96, 28);
            this.label_contestant.TabIndex = 7;
            this.label_contestant.Text = "参赛单位";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.Location = new System.Drawing.Point(705, 19);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(117, 28);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "运动员姓名";
            // 
            // project_textBox
            // 
            this.project_textBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.project_textBox.Location = new System.Drawing.Point(125, 90);
            this.project_textBox.Name = "project_textBox";
            this.project_textBox.Size = new System.Drawing.Size(418, 29);
            this.project_textBox.TabIndex = 3;
            this.project_textBox.TextChanged += new System.EventHandler(this.project_textBox_TextChanged);
            // 
            // label_project
            // 
            this.label_project.AutoSize = true;
            this.label_project.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_project.Location = new System.Drawing.Point(22, 90);
            this.label_project.Name = "label_project";
            this.label_project.Size = new System.Drawing.Size(96, 28);
            this.label_project.TabIndex = 2;
            this.label_project.Text = "竞赛项目";
            // 
            // label_playingfield
            // 
            this.label_playingfield.AutoSize = true;
            this.label_playingfield.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_playingfield.Location = new System.Drawing.Point(22, 40);
            this.label_playingfield.Name = "label_playingfield";
            this.label_playingfield.Size = new System.Drawing.Size(96, 28);
            this.label_playingfield.TabIndex = 1;
            this.label_playingfield.Text = "竞赛场地";
            // 
            // playingfield_comboBox
            // 
            this.playingfield_comboBox.DisplayMember = "PlayingFiledId";
            this.playingfield_comboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playingfield_comboBox.FormattingEnabled = true;
            this.playingfield_comboBox.Location = new System.Drawing.Point(125, 40);
            this.playingfield_comboBox.Name = "playingfield_comboBox";
            this.playingfield_comboBox.Size = new System.Drawing.Size(54, 29);
            this.playingfield_comboBox.TabIndex = 0;
            this.playingfield_comboBox.ValueMember = "PlayingFiledId";
            this.playingfield_comboBox.SelectedIndexChanged += new System.EventHandler(this.playingfield_comboBox_SelectedIndexChanged);
            // 
            // Read_timer
            // 
            this.Read_timer.Tick += new System.EventHandler(this.Read_timer_Tick);
            // 
            // datalength_toolStripComboBox
            // 
            this.datalength_toolStripComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalength_toolStripComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.datalength_toolStripComboBox.Name = "datalength_toolStripComboBox";
            this.datalength_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // 数据单元ToolStripMenuItem
            // 
            this.数据单元ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datalength_toolStripComboBox});
            this.数据单元ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数据单元ToolStripMenuItem.Name = "数据单元ToolStripMenuItem";
            this.数据单元ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.数据单元ToolStripMenuItem.Text = "读写单元";
            // 
            // FinalInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel_InsertAthlete);
            this.Controls.Add(this.menuStrip_panel);
            this.MainMenuStrip = this.menuStrip_panel;
            this.Name = "FinalInsert";
            this.Text = "竞赛管理系统-运动员管理";
            this.Load += new System.EventHandler(this.FinalInsert_Load);
            this.menuStrip_panel.ResumeLayout(false);
            this.menuStrip_panel.PerformLayout();
            this.panel_InsertAthlete.ResumeLayout(false);
            this.groupBox_checkinfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_checkinfo)).EndInit();
            this.groupBox_project.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projectinfo)).EndInit();
            this.groupBox_checkin.ResumeLayout(false);
            this.groupBox_checkin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_panel;
        private System.Windows.Forms.ToolStripMenuItem InsertAthlete_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Configuration_ToolStripMenuItem;
        private System.Windows.Forms.Button read_button;
        private System.Windows.Forms.TextBox write_textBox;
        private System.Windows.Forms.Button write_button;
        private System.Windows.Forms.ToolStripMenuItem 连接设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Connect_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Disconnect_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备端口号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox commport_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem 设备频率ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox boundrate_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem pf_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功率ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox power_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem 使用地区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox freqtype_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem pfset_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pfconfig_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ant_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subant_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ant1_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ant2_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ant3_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ant4_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antset_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antconfig_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据区域ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox dataregion_toolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem 起始地址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox dataaddress_toolStripComboBox;
        private System.Windows.Forms.Panel panel_InsertAthlete;
        private System.Windows.Forms.GroupBox groupBox_checkinfo;
        private System.Windows.Forms.DataGridView dataGridView_checkinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtheleteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContestantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AthleteOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn AthleteStatus;
        private System.Windows.Forms.GroupBox groupBox_project;
        private System.Windows.Forms.DataGridView dataGridView_projectinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AthletesNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.GroupBox groupBox_checkin;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label_contestant;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox project_textBox;
        private System.Windows.Forms.Label label_project;
        private System.Windows.Forms.Label label_playingfield;
        private System.Windows.Forms.ComboBox playingfield_comboBox;
        private System.Windows.Forms.ComboBox contestant_comboBox;
        private System.Windows.Forms.ComboBox sex_comboBox;
        private System.Windows.Forms.Label sex_label;
        private System.Windows.Forms.Label AthleteID_label;
        private System.Windows.Forms.Timer Read_timer;
        private System.Windows.Forms.ToolStripMenuItem 数据单元ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox datalength_toolStripComboBox;
    }
}

