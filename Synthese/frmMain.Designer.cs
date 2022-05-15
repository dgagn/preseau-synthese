using Synthese.Models;

namespace Synthese;

partial class FrmMain
{
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  ///  Clean up any resources being used.
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
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dgvPortScanner = new System.Windows.Forms.DataGridView();
      this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.successDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.portScanBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.btnPortScan = new Synthese.Controls.LoadingButton();
      this.label1 = new System.Windows.Forms.Label();
      this.tclDashboard = new Synthese.Controls.TabNoBorders();
      this.tpInterfaces = new System.Windows.Forms.TabPage();
      this.pgInterfaces = new System.Windows.Forms.PropertyGrid();
      this.label17 = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.dgvInterfaces = new System.Windows.Forms.DataGridView();
      this.iPv4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Maker = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cmsShortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsmPortScan = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmDiffusion = new System.Windows.Forms.ToolStripMenuItem();
      this.networkCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tpBroadcaster = new System.Windows.Forms.TabPage();
      this.lblInterfaceDiffusion = new System.Windows.Forms.Label();
      this.lblInvalidPort = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.btnBroadcast = new Synthese.Controls.LoadingButton();
      this.label3 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.rtbMessage = new System.Windows.Forms.RichTextBox();
      this.tpICMP = new System.Windows.Forms.TabPage();
      this.label18 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.rtbICMP = new System.Windows.Forms.RichTextBox();
      this.btnTraceroute = new Synthese.Controls.LoadingButton();
      this.label15 = new System.Windows.Forms.Label();
      this.txtTimeout = new System.Windows.Forms.TextBox();
      this.btnPing = new Synthese.Controls.LoadingButton();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.txtPingIpDns = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.tpEmails = new System.Windows.Forms.TabPage();
      this.label11 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.txtMailPort = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.txtServer = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.btnMail = new Synthese.Controls.LoadingButton();
      this.dgvMails = new System.Windows.Forms.DataGridView();
      this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.emailBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tpPortScanner = new System.Windows.Forms.TabPage();
      this.lblInvalidAddress = new System.Windows.Forms.Label();
      this.lblAddress = new System.Windows.Forms.Label();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.networkCardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.emailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.richTextBoxLogControl2 = new Serilog.Sinks.WinForms.Core.RichTextBoxLogControl();
      this.label2 = new System.Windows.Forms.Label();
      this.emailBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.networkCardBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.dgvPortScanner)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.portScanBindingSource)).BeginInit();
      this.tclDashboard.SuspendLayout();
      this.tpInterfaces.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvInterfaces)).BeginInit();
      this.cmsShortcuts.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.networkCardBindingSource)).BeginInit();
      this.tpBroadcaster.SuspendLayout();
      this.panel2.SuspendLayout();
      this.tpICMP.SuspendLayout();
      this.panel3.SuspendLayout();
      this.tpEmails.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource)).BeginInit();
      this.tpPortScanner.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.networkCardBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource1)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.networkCardBindingSource2)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvPortScanner
      // 
      this.dgvPortScanner.AllowUserToAddRows = false;
      this.dgvPortScanner.AllowUserToDeleteRows = false;
      this.dgvPortScanner.AllowUserToResizeRows = false;
      this.dgvPortScanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvPortScanner.AutoGenerateColumns = false;
      this.dgvPortScanner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvPortScanner.BackgroundColor = System.Drawing.Color.White;
      this.dgvPortScanner.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvPortScanner.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.dgvPortScanner.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvPortScanner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvPortScanner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPortScanner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.portDataGridViewTextBoxColumn,
            this.successDataGridViewTextBoxColumn});
      this.dgvPortScanner.DataSource = this.portScanBindingSource;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(207)))), ((int)(((byte)(232)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvPortScanner.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgvPortScanner.EnableHeadersVisualStyles = false;
      this.dgvPortScanner.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
      this.dgvPortScanner.Location = new System.Drawing.Point(7, 77);
      this.dgvPortScanner.Margin = new System.Windows.Forms.Padding(4);
      this.dgvPortScanner.Name = "dgvPortScanner";
      this.dgvPortScanner.ReadOnly = true;
      this.dgvPortScanner.RowHeadersVisible = false;
      this.dgvPortScanner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvPortScanner.RowTemplate.Height = 25;
      this.dgvPortScanner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvPortScanner.Size = new System.Drawing.Size(793, 237);
      this.dgvPortScanner.TabIndex = 1;
      // 
      // portDataGridViewTextBoxColumn
      // 
      this.portDataGridViewTextBoxColumn.DataPropertyName = "Port";
      this.portDataGridViewTextBoxColumn.HeaderText = "Port";
      this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
      this.portDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // successDataGridViewTextBoxColumn
      // 
      this.successDataGridViewTextBoxColumn.DataPropertyName = "Status";
      this.successDataGridViewTextBoxColumn.HeaderText = "Status";
      this.successDataGridViewTextBoxColumn.Name = "successDataGridViewTextBoxColumn";
      this.successDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // portScanBindingSource
      // 
      this.portScanBindingSource.DataSource = typeof(Synthese.Models.PortScan);
      // 
      // btnPortScan
      // 
      this.btnPortScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnPortScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
      this.btnPortScan.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPortScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPortScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
      this.btnPortScan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnPortScan.Location = new System.Drawing.Point(690, 37);
      this.btnPortScan.Name = "btnPortScan";
      this.btnPortScan.Size = new System.Drawing.Size(111, 34);
      this.btnPortScan.TabIndex = 2;
      this.btnPortScan.Text = "Scan ports";
      this.btnPortScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnPortScan.UseVisualStyleBackColor = true;
      this.btnPortScan.Click += new System.EventHandler(this.btnPortScan_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.label1.Location = new System.Drawing.Point(3, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(121, 25);
      this.label1.TabIndex = 5;
      this.label1.Text = "Port Scanner";
      // 
      // tclDashboard
      // 
      this.tclDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tclDashboard.Controls.Add(this.tpInterfaces);
      this.tclDashboard.Controls.Add(this.tpBroadcaster);
      this.tclDashboard.Controls.Add(this.tpICMP);
      this.tclDashboard.Controls.Add(this.tpEmails);
      this.tclDashboard.Controls.Add(this.tpPortScanner);
      this.tclDashboard.Location = new System.Drawing.Point(5, 5);
      this.tclDashboard.Name = "tclDashboard";
      this.tclDashboard.SelectedIndex = 0;
      this.tclDashboard.Size = new System.Drawing.Size(815, 361);
      this.tclDashboard.TabIndex = 6;
      this.tclDashboard.SelectedIndexChanged += new System.EventHandler(this.tclDashboard_SelectedIndexChanged);
      // 
      // tpInterfaces
      // 
      this.tpInterfaces.Controls.Add(this.pgInterfaces);
      this.tpInterfaces.Controls.Add(this.label17);
      this.tpInterfaces.Controls.Add(this.label20);
      this.tpInterfaces.Controls.Add(this.dgvInterfaces);
      this.tpInterfaces.Location = new System.Drawing.Point(4, 30);
      this.tpInterfaces.Name = "tpInterfaces";
      this.tpInterfaces.Padding = new System.Windows.Forms.Padding(3);
      this.tpInterfaces.Size = new System.Drawing.Size(807, 327);
      this.tpInterfaces.TabIndex = 4;
      this.tpInterfaces.Text = "Interfaces";
      this.tpInterfaces.UseVisualStyleBackColor = true;
      // 
      // pgInterfaces
      // 
      this.pgInterfaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pgInterfaces.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.pgInterfaces.Location = new System.Drawing.Point(457, 45);
      this.pgInterfaces.Name = "pgInterfaces";
      this.pgInterfaces.Size = new System.Drawing.Size(344, 266);
      this.pgInterfaces.TabIndex = 15;
      this.pgInterfaces.ViewBackColor = System.Drawing.Color.White;
      this.pgInterfaces.ViewBorderColor = System.Drawing.Color.Gainsboro;
      this.pgInterfaces.ViewForeColor = System.Drawing.Color.Gray;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
      this.label17.Location = new System.Drawing.Point(255, 45);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(0, 21);
      this.label17.TabIndex = 14;
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.label20.Location = new System.Drawing.Point(3, 9);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(97, 25);
      this.label20.TabIndex = 11;
      this.label20.Text = "Interfaces";
      // 
      // dgvInterfaces
      // 
      this.dgvInterfaces.AllowUserToAddRows = false;
      this.dgvInterfaces.AllowUserToDeleteRows = false;
      this.dgvInterfaces.AllowUserToResizeRows = false;
      this.dgvInterfaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.dgvInterfaces.AutoGenerateColumns = false;
      this.dgvInterfaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvInterfaces.BackgroundColor = System.Drawing.Color.White;
      this.dgvInterfaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvInterfaces.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.dgvInterfaces.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvInterfaces.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dgvInterfaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvInterfaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iPv4DataGridViewTextBoxColumn,
            this.CardName,
            this.Maker});
      this.dgvInterfaces.ContextMenuStrip = this.cmsShortcuts;
      this.dgvInterfaces.DataSource = this.networkCardBindingSource;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(207)))), ((int)(((byte)(232)))));
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvInterfaces.DefaultCellStyle = dataGridViewCellStyle4;
      this.dgvInterfaces.EnableHeadersVisualStyles = false;
      this.dgvInterfaces.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
      this.dgvInterfaces.Location = new System.Drawing.Point(8, 45);
      this.dgvInterfaces.Margin = new System.Windows.Forms.Padding(4);
      this.dgvInterfaces.MultiSelect = false;
      this.dgvInterfaces.Name = "dgvInterfaces";
      this.dgvInterfaces.ReadOnly = true;
      this.dgvInterfaces.RowHeadersVisible = false;
      this.dgvInterfaces.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvInterfaces.RowTemplate.Height = 25;
      this.dgvInterfaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvInterfaces.Size = new System.Drawing.Size(442, 266);
      this.dgvInterfaces.TabIndex = 10;
      this.dgvInterfaces.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvInterfaces_DataError);
      this.dgvInterfaces.SelectionChanged += new System.EventHandler(this.dgvInterfaces_SelectionChanged);
      // 
      // iPv4DataGridViewTextBoxColumn
      // 
      this.iPv4DataGridViewTextBoxColumn.DataPropertyName = "IPv4";
      this.iPv4DataGridViewTextBoxColumn.HeaderText = "IPv4";
      this.iPv4DataGridViewTextBoxColumn.Name = "iPv4DataGridViewTextBoxColumn";
      this.iPv4DataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // CardName
      // 
      this.CardName.DataPropertyName = "CardName";
      this.CardName.HeaderText = "Nom";
      this.CardName.Name = "CardName";
      this.CardName.ReadOnly = true;
      // 
      // Maker
      // 
      this.Maker.DataPropertyName = "Maker";
      this.Maker.HeaderText = "Fabriquant";
      this.Maker.Name = "Maker";
      this.Maker.ReadOnly = true;
      // 
      // cmsShortcuts
      // 
      this.cmsShortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPortScan,
            this.tsmDiffusion});
      this.cmsShortcuts.Name = "cmsShortcuts";
      this.cmsShortcuts.Size = new System.Drawing.Size(124, 48);
      // 
      // tsmPortScan
      // 
      this.tsmPortScan.Name = "tsmPortScan";
      this.tsmPortScan.Size = new System.Drawing.Size(123, 22);
      this.tsmPortScan.Text = "Port scan";
      this.tsmPortScan.Click += new System.EventHandler(this.tsmPortScan_Click);
      // 
      // tsmDiffusion
      // 
      this.tsmDiffusion.Name = "tsmDiffusion";
      this.tsmDiffusion.Size = new System.Drawing.Size(123, 22);
      this.tsmDiffusion.Text = "Diffusion";
      this.tsmDiffusion.Click += new System.EventHandler(this.tsmDiffusion_Click);
      // 
      // networkCardBindingSource
      // 
      this.networkCardBindingSource.DataSource = typeof(Synthese.Models.NetworkCard);
      // 
      // tpBroadcaster
      // 
      this.tpBroadcaster.Controls.Add(this.lblInterfaceDiffusion);
      this.tpBroadcaster.Controls.Add(this.lblInvalidPort);
      this.tpBroadcaster.Controls.Add(this.label5);
      this.tpBroadcaster.Controls.Add(this.label4);
      this.tpBroadcaster.Controls.Add(this.txtPort);
      this.tpBroadcaster.Controls.Add(this.btnBroadcast);
      this.tpBroadcaster.Controls.Add(this.label3);
      this.tpBroadcaster.Controls.Add(this.panel2);
      this.tpBroadcaster.Location = new System.Drawing.Point(4, 30);
      this.tpBroadcaster.Name = "tpBroadcaster";
      this.tpBroadcaster.Padding = new System.Windows.Forms.Padding(3);
      this.tpBroadcaster.Size = new System.Drawing.Size(807, 327);
      this.tpBroadcaster.TabIndex = 1;
      this.tpBroadcaster.Text = "Diffuseur";
      this.tpBroadcaster.UseVisualStyleBackColor = true;
      // 
      // lblInterfaceDiffusion
      // 
      this.lblInterfaceDiffusion.AutoSize = true;
      this.lblInterfaceDiffusion.Location = new System.Drawing.Point(256, 44);
      this.lblInterfaceDiffusion.Name = "lblInterfaceDiffusion";
      this.lblInterfaceDiffusion.Size = new System.Drawing.Size(0, 21);
      this.lblInterfaceDiffusion.TabIndex = 14;
      // 
      // lblInvalidPort
      // 
      this.lblInvalidPort.AutoSize = true;
      this.lblInvalidPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
      this.lblInvalidPort.Location = new System.Drawing.Point(250, 44);
      this.lblInvalidPort.Name = "lblInvalidPort";
      this.lblInvalidPort.Size = new System.Drawing.Size(0, 21);
      this.lblInvalidPort.TabIndex = 13;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 106);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(140, 21);
      this.label5.TabIndex = 11;
      this.label5.Text = "Message à diffuser";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(7, 44);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(80, 21);
      this.label4.TabIndex = 9;
      this.label4.Text = "Port UDP :";
      // 
      // txtPort
      // 
      this.txtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.txtPort.Location = new System.Drawing.Point(102, 41);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(118, 29);
      this.txtPort.TabIndex = 8;
      this.txtPort.Text = "1234";
      // 
      // btnBroadcast
      // 
      this.btnBroadcast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBroadcast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
      this.btnBroadcast.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnBroadcast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(114)))), ((int)(((byte)(182)))));
      this.btnBroadcast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBroadcast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
      this.btnBroadcast.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnBroadcast.Location = new System.Drawing.Point(687, 38);
      this.btnBroadcast.Name = "btnBroadcast";
      this.btnBroadcast.Size = new System.Drawing.Size(111, 33);
      this.btnBroadcast.TabIndex = 7;
      this.btnBroadcast.Text = "Broadcast";
      this.btnBroadcast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnBroadcast.UseVisualStyleBackColor = false;
      this.btnBroadcast.Click += new System.EventHandler(this.btnBroadcast_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.label3.Location = new System.Drawing.Point(3, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(113, 25);
      this.label3.TabIndex = 6;
      this.label3.Text = "Broadcaster";
      // 
      // panel2
      // 
      this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
      this.panel2.Controls.Add(this.rtbMessage);
      this.panel2.Location = new System.Drawing.Point(7, 130);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(794, 155);
      this.panel2.TabIndex = 12;
      // 
      // rtbMessage
      // 
      this.rtbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.rtbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
      this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.rtbMessage.Location = new System.Drawing.Point(3, 3);
      this.rtbMessage.Name = "rtbMessage";
      this.rtbMessage.Size = new System.Drawing.Size(788, 149);
      this.rtbMessage.TabIndex = 10;
      this.rtbMessage.Text = "Allo le monde";
      // 
      // tpICMP
      // 
      this.tpICMP.Controls.Add(this.label18);
      this.tpICMP.Controls.Add(this.panel3);
      this.tpICMP.Controls.Add(this.btnTraceroute);
      this.tpICMP.Controls.Add(this.label15);
      this.tpICMP.Controls.Add(this.txtTimeout);
      this.tpICMP.Controls.Add(this.btnPing);
      this.tpICMP.Controls.Add(this.label12);
      this.tpICMP.Controls.Add(this.label13);
      this.tpICMP.Controls.Add(this.txtPingIpDns);
      this.tpICMP.Controls.Add(this.label14);
      this.tpICMP.Controls.Add(this.label16);
      this.tpICMP.Location = new System.Drawing.Point(4, 24);
      this.tpICMP.Name = "tpICMP";
      this.tpICMP.Padding = new System.Windows.Forms.Padding(3);
      this.tpICMP.Size = new System.Drawing.Size(807, 333);
      this.tpICMP.TabIndex = 3;
      this.tpICMP.Text = "ICMP";
      this.tpICMP.UseVisualStyleBackColor = true;
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(6, -26);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(140, 21);
      this.label18.TabIndex = 25;
      this.label18.Text = "Message à diffuser";
      // 
      // panel3
      // 
      this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
      this.panel3.Controls.Add(this.rtbICMP);
      this.panel3.Location = new System.Drawing.Point(7, 121);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(794, 200);
      this.panel3.TabIndex = 26;
      // 
      // rtbICMP
      // 
      this.rtbICMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.rtbICMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.rtbICMP.Location = new System.Drawing.Point(3, 3);
      this.rtbICMP.Name = "rtbICMP";
      this.rtbICMP.ReadOnly = true;
      this.rtbICMP.Size = new System.Drawing.Size(788, 194);
      this.rtbICMP.TabIndex = 27;
      this.rtbICMP.Text = "";
      // 
      // btnTraceroute
      // 
      this.btnTraceroute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnTraceroute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
      this.btnTraceroute.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnTraceroute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTraceroute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
      this.btnTraceroute.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnTraceroute.Location = new System.Drawing.Point(687, 81);
      this.btnTraceroute.Name = "btnTraceroute";
      this.btnTraceroute.Size = new System.Drawing.Size(111, 34);
      this.btnTraceroute.TabIndex = 22;
      this.btnTraceroute.Text = "Traceroute";
      this.btnTraceroute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnTraceroute.UseVisualStyleBackColor = true;
      this.btnTraceroute.Click += new System.EventHandler(this.btnTraceroute_Click);
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(230, 44);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(74, 21);
      this.label15.TabIndex = 16;
      this.label15.Text = "Timeout :";
      // 
      // txtTimeout
      // 
      this.txtTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.txtTimeout.Location = new System.Drawing.Point(308, 41);
      this.txtTimeout.Name = "txtTimeout";
      this.txtTimeout.Size = new System.Drawing.Size(65, 29);
      this.txtTimeout.TabIndex = 15;
      this.txtTimeout.Text = "1000";
      // 
      // btnPing
      // 
      this.btnPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
      this.btnPing.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
      this.btnPing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnPing.Location = new System.Drawing.Point(687, 37);
      this.btnPing.Name = "btnPing";
      this.btnPing.Size = new System.Drawing.Size(111, 34);
      this.btnPing.TabIndex = 14;
      this.btnPing.Text = "Ping";
      this.btnPing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnPing.UseVisualStyleBackColor = true;
      this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
      this.label12.Location = new System.Drawing.Point(250, 44);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(0, 21);
      this.label12.TabIndex = 13;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(7, 44);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(88, 21);
      this.label13.TabIndex = 12;
      this.label13.Text = "IP ou DNS :";
      // 
      // txtPingIpDns
      // 
      this.txtPingIpDns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.txtPingIpDns.Location = new System.Drawing.Point(102, 41);
      this.txtPingIpDns.Name = "txtPingIpDns";
      this.txtPingIpDns.Size = new System.Drawing.Size(118, 29);
      this.txtPingIpDns.TabIndex = 11;
      this.txtPingIpDns.Text = "www.google.ca";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.label14.Location = new System.Drawing.Point(3, 9);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(59, 25);
      this.label14.TabIndex = 10;
      this.label14.Text = "ICMP";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(374, 44);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(31, 21);
      this.label16.TabIndex = 17;
      this.label16.Text = "ms";
      // 
      // tpEmails
      // 
      this.tpEmails.Controls.Add(this.label11);
      this.tpEmails.Controls.Add(this.txtPassword);
      this.tpEmails.Controls.Add(this.label10);
      this.tpEmails.Controls.Add(this.txtUsername);
      this.tpEmails.Controls.Add(this.label9);
      this.tpEmails.Controls.Add(this.txtMailPort);
      this.tpEmails.Controls.Add(this.label6);
      this.tpEmails.Controls.Add(this.label7);
      this.tpEmails.Controls.Add(this.txtServer);
      this.tpEmails.Controls.Add(this.label8);
      this.tpEmails.Controls.Add(this.btnMail);
      this.tpEmails.Controls.Add(this.dgvMails);
      this.tpEmails.Location = new System.Drawing.Point(4, 24);
      this.tpEmails.Name = "tpEmails";
      this.tpEmails.Size = new System.Drawing.Size(807, 333);
      this.tpEmails.TabIndex = 2;
      this.tpEmails.Text = "Courriels";
      this.tpEmails.UseVisualStyleBackColor = true;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(304, 88);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(83, 21);
      this.label11.TabIndex = 20;
      this.label11.Text = "Password :";
      // 
      // txtPassword
      // 
      this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.txtPassword.Location = new System.Drawing.Point(393, 85);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(161, 29);
      this.txtPassword.TabIndex = 19;
      this.txtPassword.Text = "TEMP4now";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(7, 88);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(88, 21);
      this.label10.TabIndex = 18;
      this.label10.Text = "Utilisateur :";
      // 
      // txtUsername
      // 
      this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.txtUsername.Location = new System.Drawing.Point(101, 85);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(188, 29);
      this.txtUsername.TabIndex = 17;
      this.txtUsername.Text = "ddanygagnon@gmail.com";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(234, 44);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(45, 21);
      this.label9.TabIndex = 16;
      this.label9.Text = "Port :";
      // 
      // txtMailPort
      // 
      this.txtMailPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.txtMailPort.Location = new System.Drawing.Point(285, 41);
      this.txtMailPort.Name = "txtMailPort";
      this.txtMailPort.Size = new System.Drawing.Size(65, 29);
      this.txtMailPort.TabIndex = 15;
      this.txtMailPort.Text = "995";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
      this.label6.Location = new System.Drawing.Point(254, 44);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(0, 21);
      this.label6.TabIndex = 14;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(7, 44);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(71, 21);
      this.label7.TabIndex = 13;
      this.label7.Text = "Serveur :";
      // 
      // txtServer
      // 
      this.txtServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.txtServer.Location = new System.Drawing.Point(84, 41);
      this.txtServer.Name = "txtServer";
      this.txtServer.Size = new System.Drawing.Size(135, 29);
      this.txtServer.TabIndex = 12;
      this.txtServer.Text = "pop.gmail.com";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.label8.Location = new System.Drawing.Point(3, 9);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(88, 25);
      this.label8.TabIndex = 11;
      this.label8.Text = "Courriels";
      // 
      // btnMail
      // 
      this.btnMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
      this.btnMail.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
      this.btnMail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnMail.Location = new System.Drawing.Point(689, 37);
      this.btnMail.Name = "btnMail";
      this.btnMail.Size = new System.Drawing.Size(111, 34);
      this.btnMail.TabIndex = 10;
      this.btnMail.Text = "Récupérer";
      this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnMail.UseVisualStyleBackColor = true;
      this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
      // 
      // dgvMails
      // 
      this.dgvMails.AllowUserToAddRows = false;
      this.dgvMails.AllowUserToDeleteRows = false;
      this.dgvMails.AllowUserToResizeRows = false;
      this.dgvMails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvMails.AutoGenerateColumns = false;
      this.dgvMails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvMails.BackgroundColor = System.Drawing.Color.White;
      this.dgvMails.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvMails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.dgvMails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvMails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
      this.dgvMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvMails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromDataGridViewTextBoxColumn,
            this.To,
            this.subjectDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
      this.dgvMails.DataSource = this.emailBindingSource;
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(207)))), ((int)(((byte)(232)))));
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(24)))), ((int)(((byte)(67)))));
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvMails.DefaultCellStyle = dataGridViewCellStyle6;
      this.dgvMails.EnableHeadersVisualStyles = false;
      this.dgvMails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
      this.dgvMails.Location = new System.Drawing.Point(9, 137);
      this.dgvMails.Margin = new System.Windows.Forms.Padding(4);
      this.dgvMails.Name = "dgvMails";
      this.dgvMails.ReadOnly = true;
      this.dgvMails.RowHeadersVisible = false;
      this.dgvMails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvMails.RowTemplate.Height = 25;
      this.dgvMails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvMails.Size = new System.Drawing.Size(791, 186);
      this.dgvMails.TabIndex = 9;
      // 
      // fromDataGridViewTextBoxColumn
      // 
      this.fromDataGridViewTextBoxColumn.DataPropertyName = "From";
      this.fromDataGridViewTextBoxColumn.HeaderText = "From";
      this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
      this.fromDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // To
      // 
      this.To.DataPropertyName = "To";
      this.To.HeaderText = "To";
      this.To.Name = "To";
      this.To.ReadOnly = true;
      // 
      // subjectDataGridViewTextBoxColumn
      // 
      this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
      this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
      this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
      this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // dateDataGridViewTextBoxColumn
      // 
      this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
      this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
      this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
      this.dateDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // emailBindingSource
      // 
      this.emailBindingSource.DataSource = typeof(Synthese.Models.Email);
      // 
      // tpPortScanner
      // 
      this.tpPortScanner.Controls.Add(this.lblInvalidAddress);
      this.tpPortScanner.Controls.Add(this.lblAddress);
      this.tpPortScanner.Controls.Add(this.txtAddress);
      this.tpPortScanner.Controls.Add(this.label1);
      this.tpPortScanner.Controls.Add(this.btnPortScan);
      this.tpPortScanner.Controls.Add(this.dgvPortScanner);
      this.tpPortScanner.Location = new System.Drawing.Point(4, 24);
      this.tpPortScanner.Name = "tpPortScanner";
      this.tpPortScanner.Padding = new System.Windows.Forms.Padding(3);
      this.tpPortScanner.Size = new System.Drawing.Size(807, 333);
      this.tpPortScanner.TabIndex = 0;
      this.tpPortScanner.Text = "Port Scanner";
      this.tpPortScanner.UseVisualStyleBackColor = true;
      // 
      // lblInvalidAddress
      // 
      this.lblInvalidAddress.AutoSize = true;
      this.lblInvalidAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
      this.lblInvalidAddress.Location = new System.Drawing.Point(250, 44);
      this.lblInvalidAddress.Name = "lblInvalidAddress";
      this.lblInvalidAddress.Size = new System.Drawing.Size(0, 21);
      this.lblInvalidAddress.TabIndex = 8;
      // 
      // lblAddress
      // 
      this.lblAddress.AutoSize = true;
      this.lblAddress.Location = new System.Drawing.Point(7, 44);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new System.Drawing.Size(89, 21);
      this.lblAddress.TabIndex = 7;
      this.lblAddress.Text = "Adresse IP :";
      // 
      // txtAddress
      // 
      this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.txtAddress.Location = new System.Drawing.Point(102, 41);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(118, 29);
      this.txtAddress.TabIndex = 6;
      this.txtAddress.Text = "127.0.0.1";
      // 
      // networkCardBindingSource1
      // 
      this.networkCardBindingSource1.DataSource = typeof(Synthese.Models.NetworkCard);
      // 
      // emailBindingSource1
      // 
      this.emailBindingSource1.DataSource = typeof(Synthese.Models.Email);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Controls.Add(this.richTextBoxLogControl2);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Location = new System.Drawing.Point(5, 372);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(811, 199);
      this.panel1.TabIndex = 7;
      // 
      // richTextBoxLogControl2
      // 
      this.richTextBoxLogControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.richTextBoxLogControl2.BackColor = System.Drawing.Color.White;
      this.richTextBoxLogControl2.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBoxLogControl2.ForContext = "";
      this.richTextBoxLogControl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.richTextBoxLogControl2.Location = new System.Drawing.Point(7, 41);
      this.richTextBoxLogControl2.Name = "richTextBoxLogControl2";
      this.richTextBoxLogControl2.ReadOnly = true;
      this.richTextBoxLogControl2.Size = new System.Drawing.Size(814, 134);
      this.richTextBoxLogControl2.TabIndex = 1;
      this.richTextBoxLogControl2.Text = "";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(6, 6);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(71, 21);
      this.label2.TabIndex = 0;
      this.label2.Text = "Logging";
      // 
      // emailBindingSource2
      // 
      this.emailBindingSource2.DataSource = typeof(Synthese.Models.Email);
      // 
      // networkCardBindingSource2
      // 
      this.networkCardBindingSource2.DataSource = typeof(Synthese.Models.NetworkCard);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(822, 573);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.tclDashboard);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MinimumSize = new System.Drawing.Size(600, 600);
      this.Name = "FrmMain";
      this.Text = "FrmMain";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvPortScanner)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.portScanBindingSource)).EndInit();
      this.tclDashboard.ResumeLayout(false);
      this.tpInterfaces.ResumeLayout(false);
      this.tpInterfaces.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvInterfaces)).EndInit();
      this.cmsShortcuts.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.networkCardBindingSource)).EndInit();
      this.tpBroadcaster.ResumeLayout(false);
      this.tpBroadcaster.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.tpICMP.ResumeLayout(false);
      this.tpICMP.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.tpEmails.ResumeLayout(false);
      this.tpEmails.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource)).EndInit();
      this.tpPortScanner.ResumeLayout(false);
      this.tpPortScanner.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.networkCardBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.networkCardBindingSource2)).EndInit();
      this.ResumeLayout(false);

  }

  #endregion
  private DataGridView dgvPortScanner;
  private Controls.LoadingButton btnPortScan;
  private Serilog.Sinks.WinForms.Core.GridLog gridLog1;
  private Serilog.Sinks.WinForms.Core.RichTextBoxLogControl richTextBoxLogControl1;
  private DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
  private DataGridViewTextBoxColumn successDataGridViewTextBoxColumn;
  private BindingSource portScanBindingSource;
  private Label label1;
  private Controls.TabNoBorders tclDashboard;
  private TabPage tpBroadcaster;
  private TabPage tpPortScanner;
  private Panel panel1;
  private Label label2;
  private Serilog.Sinks.WinForms.Core.RichTextBoxLogControl richTextBoxLogControl2;
  private Label lblAddress;
  private TextBox txtAddress;
  private Label lblInvalidAddress;
  private Label label3;
  private Controls.LoadingButton btnBroadcast;
  private Label label4;
  private TextBox txtPort;
  private Label label5;
  private RichTextBox rtbMessage;
  private Panel panel2;
  private Label lblInvalidPort;
  private TabPage tpEmails;
  private Label label6;
  private Label label7;
  private TextBox txtServer;
  private Label label8;
  private Controls.LoadingButton btnMail;
  private DataGridView dgvInterfaces;
  private Label label9;
  private TextBox txtMailPort;
  private Label label11;
  private TextBox txtPassword;
  private Label label10;
  private TextBox txtUsername;
  private BindingSource emailBindingSource;
  private DataGridView dgvMails;
  private BindingSource emailBindingSource1;
  private TabPage tpICMP;
  private TabPage tpInterfaces;
  private Label label12;
  private Label label13;
  private TextBox txtPingIpDns;
  private Label label14;
  private Controls.LoadingButton btnPing;
  private Label label16;
  private Label label15;
  private TextBox txtTimeout;
  private DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
  private DataGridViewTextBoxColumn To;
  private DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
  private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
  private Controls.LoadingButton btnTraceroute;
  private Label label18;
  private Panel panel3;
  private RichTextBox rtbICMP;
  private Label label17;
  private Label label20;
  private BindingSource networkCardBindingSource;
  private PropertyGrid pgInterfaces;
  private BindingSource networkCardBindingSource1;
  private BindingSource emailBindingSource2;
  private BindingSource networkCardBindingSource2;
  private DataGridViewTextBoxColumn nomCarteDataGridViewTextBoxColumn;
  private DataGridViewTextBoxColumn iPv4DataGridViewTextBoxColumn;
  private DataGridViewTextBoxColumn CardName;
  private DataGridViewTextBoxColumn Maker;
  private ContextMenuStrip cmsShortcuts;
  private ToolStripMenuItem tsmPortScan;
  private ToolStripMenuItem tsmDiffusion;
  private Label lblInterfaceDiffusion;
}