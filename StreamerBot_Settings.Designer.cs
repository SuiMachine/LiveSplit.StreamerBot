namespace LiveSplit.StreamerBot
{
    partial class StreamerBot_Settings
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.gbStartSplits = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.TB_Address = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.CB_Autoconnect = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.L_ConnectionStatus = new System.Windows.Forms.Label();
			this.CB_Log_DebugMessages = new System.Windows.Forms.CheckBox();
			this.B_Connect = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.B_Test_OnStart = new System.Windows.Forms.Button();
			this.B_Test_OnSkipSplit = new System.Windows.Forms.Button();
			this.B_Test_OnGreenBestSplit = new System.Windows.Forms.Button();
			this.B_Test_OnPause = new System.Windows.Forms.Button();
			this.B_Test_OnRedSplitGold = new System.Windows.Forms.Button();
			this.B_Test_OnReset = new System.Windows.Forms.Button();
			this.B_Test_OnResume = new System.Windows.Forms.Button();
			this.B_Test_OnUndoSplit = new System.Windows.Forms.Button();
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.gbLog = new System.Windows.Forms.GroupBox();
			this.RB_LogText = new System.Windows.Forms.RichTextBox();
			this.B_Test_OnRedSplitLostTime = new System.Windows.Forms.Button();
			this.B_Test_OnRedSplitSavedTime = new System.Windows.Forms.Button();
			this.B_Test_OnGreenSplitSaved = new System.Windows.Forms.Button();
			this.B_Test_OnGreenSplitLost = new System.Windows.Forms.Button();
			this.gbStartSplits.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.tlpMain.SuspendLayout();
			this.gbLog.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbStartSplits
			// 
			this.gbStartSplits.Controls.Add(this.tableLayoutPanel1);
			this.gbStartSplits.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbStartSplits.Location = new System.Drawing.Point(3, 3);
			this.gbStartSplits.Name = "gbStartSplits";
			this.gbStartSplits.Size = new System.Drawing.Size(470, 311);
			this.gbStartSplits.TabIndex = 5;
			this.gbStartSplits.TabStop = false;
			this.gbStartSplits.Text = "Config";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 291);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel2.Controls.Add(this.TB_Address, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.CB_Autoconnect, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(458, 30);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// TB_Address
			// 
			this.TB_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_Address.Location = new System.Drawing.Point(77, 5);
			this.TB_Address.Name = "TB_Address";
			this.TB_Address.Size = new System.Drawing.Size(278, 20);
			this.TB_Address.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "API address";
			// 
			// CB_Autoconnect
			// 
			this.CB_Autoconnect.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CB_Autoconnect.AutoSize = true;
			this.CB_Autoconnect.Location = new System.Drawing.Point(361, 6);
			this.CB_Autoconnect.Name = "CB_Autoconnect";
			this.CB_Autoconnect.Size = new System.Drawing.Size(87, 17);
			this.CB_Autoconnect.TabIndex = 1;
			this.CB_Autoconnect.Text = "Autoconnect";
			this.CB_Autoconnect.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.L_ConnectionStatus, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.CB_Log_DebugMessages, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.B_Connect, 3, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 39);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(458, 32);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Status:";
			// 
			// L_ConnectionStatus
			// 
			this.L_ConnectionStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.L_ConnectionStatus.AutoSize = true;
			this.L_ConnectionStatus.Location = new System.Drawing.Point(49, 9);
			this.L_ConnectionStatus.Name = "L_ConnectionStatus";
			this.L_ConnectionStatus.Size = new System.Drawing.Size(13, 13);
			this.L_ConnectionStatus.TabIndex = 3;
			this.L_ConnectionStatus.Text = "?";
			// 
			// CB_Log_DebugMessages
			// 
			this.CB_Log_DebugMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CB_Log_DebugMessages.AutoSize = true;
			this.CB_Log_DebugMessages.Location = new System.Drawing.Point(224, 7);
			this.CB_Log_DebugMessages.Name = "CB_Log_DebugMessages";
			this.CB_Log_DebugMessages.Size = new System.Drawing.Size(136, 17);
			this.CB_Log_DebugMessages.TabIndex = 4;
			this.CB_Log_DebugMessages.Text = "Log debug messages";
			this.CB_Log_DebugMessages.UseVisualStyleBackColor = true;
			// 
			// B_Connect
			// 
			this.B_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Connect.Location = new System.Drawing.Point(366, 4);
			this.B_Connect.Name = "B_Connect";
			this.B_Connect.Size = new System.Drawing.Size(89, 23);
			this.B_Connect.TabIndex = 1;
			this.B_Connect.Text = "Connect";
			this.B_Connect.UseVisualStyleBackColor = true;
			this.B_Connect.Click += new System.EventHandler(this.B_Connect_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel6);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 78);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(458, 210);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Test actions";
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel6.ColumnCount = 3;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnStart, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnSkipSplit, 2, 1);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnPause, 2, 0);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnReset, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnResume, 0, 1);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnUndoSplit, 1, 1);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnRedSplitGold, 0, 3);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnGreenBestSplit, 0, 2);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnRedSplitSavedTime, 1, 3);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnGreenSplitSaved, 1, 2);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnRedSplitLostTime, 2, 3);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnGreenSplitLost, 2, 2);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 4;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(452, 191);
			this.tableLayoutPanel6.TabIndex = 13;
			// 
			// B_Test_OnStart
			// 
			this.B_Test_OnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnStart.Location = new System.Drawing.Point(31, 5);
			this.B_Test_OnStart.Name = "B_Test_OnStart";
			this.B_Test_OnStart.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnStart.TabIndex = 0;
			this.B_Test_OnStart.Text = "OnStart";
			this.B_Test_OnStart.UseVisualStyleBackColor = true;
			this.B_Test_OnStart.Click += new System.EventHandler(this.B_Test_OnStart_Click);
			// 
			// B_Test_OnSkipSplit
			// 
			this.B_Test_OnSkipSplit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnSkipSplit.Location = new System.Drawing.Point(332, 38);
			this.B_Test_OnSkipSplit.Name = "B_Test_OnSkipSplit";
			this.B_Test_OnSkipSplit.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnSkipSplit.TabIndex = 6;
			this.B_Test_OnSkipSplit.Text = "OnSkipSplit";
			this.B_Test_OnSkipSplit.UseVisualStyleBackColor = true;
			this.B_Test_OnSkipSplit.Click += new System.EventHandler(this.B_Test_OnSkipSplit_Click);
			// 
			// B_Test_OnGreenBestSplit
			// 
			this.B_Test_OnGreenBestSplit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnGreenBestSplit.ForeColor = System.Drawing.Color.Green;
			this.B_Test_OnGreenBestSplit.Location = new System.Drawing.Point(31, 74);
			this.B_Test_OnGreenBestSplit.Name = "B_Test_OnGreenBestSplit";
			this.B_Test_OnGreenBestSplit.Size = new System.Drawing.Size(88, 42);
			this.B_Test_OnGreenBestSplit.TabIndex = 9;
			this.B_Test_OnGreenBestSplit.Text = "OnGreenSplit (Gold split)";
			this.B_Test_OnGreenBestSplit.UseVisualStyleBackColor = true;
			this.B_Test_OnGreenBestSplit.Click += new System.EventHandler(this.B_Test_OnGreenSplit_Click);
			// 
			// B_Test_OnPause
			// 
			this.B_Test_OnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnPause.Location = new System.Drawing.Point(332, 5);
			this.B_Test_OnPause.Name = "B_Test_OnPause";
			this.B_Test_OnPause.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnPause.TabIndex = 1;
			this.B_Test_OnPause.Text = "OnPause";
			this.B_Test_OnPause.UseVisualStyleBackColor = true;
			this.B_Test_OnPause.Click += new System.EventHandler(this.B_Test_OnPause_Click);
			// 
			// B_Test_OnRedSplitGold
			// 
			this.B_Test_OnRedSplitGold.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnRedSplitGold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.B_Test_OnRedSplitGold.Location = new System.Drawing.Point(31, 136);
			this.B_Test_OnRedSplitGold.Name = "B_Test_OnRedSplitGold";
			this.B_Test_OnRedSplitGold.Size = new System.Drawing.Size(88, 42);
			this.B_Test_OnRedSplitGold.TabIndex = 8;
			this.B_Test_OnRedSplitGold.Text = "OnRedSplit (Gold split)";
			this.B_Test_OnRedSplitGold.UseVisualStyleBackColor = true;
			this.B_Test_OnRedSplitGold.Click += new System.EventHandler(this.B_Test_OnRedSplit_Click);
			// 
			// B_Test_OnReset
			// 
			this.B_Test_OnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnReset.Location = new System.Drawing.Point(181, 5);
			this.B_Test_OnReset.Name = "B_Test_OnReset";
			this.B_Test_OnReset.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnReset.TabIndex = 2;
			this.B_Test_OnReset.Text = "OnReset";
			this.B_Test_OnReset.UseVisualStyleBackColor = true;
			this.B_Test_OnReset.Click += new System.EventHandler(this.B_Test_OnReset_Click);
			// 
			// B_Test_OnResume
			// 
			this.B_Test_OnResume.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnResume.Location = new System.Drawing.Point(31, 38);
			this.B_Test_OnResume.Name = "B_Test_OnResume";
			this.B_Test_OnResume.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnResume.TabIndex = 3;
			this.B_Test_OnResume.Text = "OnResume";
			this.B_Test_OnResume.UseVisualStyleBackColor = true;
			this.B_Test_OnResume.Click += new System.EventHandler(this.B_Test_OnResume_Click);
			// 
			// B_Test_OnUndoSplit
			// 
			this.B_Test_OnUndoSplit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnUndoSplit.Location = new System.Drawing.Point(181, 38);
			this.B_Test_OnUndoSplit.Name = "B_Test_OnUndoSplit";
			this.B_Test_OnUndoSplit.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnUndoSplit.TabIndex = 5;
			this.B_Test_OnUndoSplit.Text = "OnUndoSplit";
			this.B_Test_OnUndoSplit.UseVisualStyleBackColor = true;
			this.B_Test_OnUndoSplit.Click += new System.EventHandler(this.B_Test_OnUndoSplit_Click);
			// 
			// tlpMain
			// 
			this.tlpMain.ColumnCount = 1;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpMain.Controls.Add(this.gbLog, 0, 1);
			this.tlpMain.Controls.Add(this.gbStartSplits, 0, 0);
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 2;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpMain.Size = new System.Drawing.Size(476, 539);
			this.tlpMain.TabIndex = 0;
			// 
			// gbLog
			// 
			this.gbLog.Controls.Add(this.RB_LogText);
			this.gbLog.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbLog.Location = new System.Drawing.Point(3, 320);
			this.gbLog.Name = "gbLog";
			this.gbLog.Size = new System.Drawing.Size(470, 216);
			this.gbLog.TabIndex = 6;
			this.gbLog.TabStop = false;
			this.gbLog.Text = "Log";
			// 
			// RB_LogText
			// 
			this.RB_LogText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RB_LogText.Location = new System.Drawing.Point(3, 16);
			this.RB_LogText.Name = "RB_LogText";
			this.RB_LogText.Size = new System.Drawing.Size(464, 197);
			this.RB_LogText.TabIndex = 0;
			this.RB_LogText.Text = "";
			// 
			// B_Test_OnRedSplitLostTime
			// 
			this.B_Test_OnRedSplitLostTime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnRedSplitLostTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.B_Test_OnRedSplitLostTime.Location = new System.Drawing.Point(332, 136);
			this.B_Test_OnRedSplitLostTime.Name = "B_Test_OnRedSplitLostTime";
			this.B_Test_OnRedSplitLostTime.Size = new System.Drawing.Size(88, 42);
			this.B_Test_OnRedSplitLostTime.TabIndex = 11;
			this.B_Test_OnRedSplitLostTime.Text = "OnRedSplit (Lost time)";
			this.B_Test_OnRedSplitLostTime.UseVisualStyleBackColor = true;
			this.B_Test_OnRedSplitLostTime.Click += new System.EventHandler(this.B_Test_OnRedSplitLostTime_Click);
			// 
			// B_Test_OnRedSplitSavedTime
			// 
			this.B_Test_OnRedSplitSavedTime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnRedSplitSavedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.B_Test_OnRedSplitSavedTime.Location = new System.Drawing.Point(181, 136);
			this.B_Test_OnRedSplitSavedTime.Name = "B_Test_OnRedSplitSavedTime";
			this.B_Test_OnRedSplitSavedTime.Size = new System.Drawing.Size(88, 42);
			this.B_Test_OnRedSplitSavedTime.TabIndex = 12;
			this.B_Test_OnRedSplitSavedTime.Text = "OnRedSplit (Saved time)";
			this.B_Test_OnRedSplitSavedTime.UseVisualStyleBackColor = true;
			this.B_Test_OnRedSplitSavedTime.Click += new System.EventHandler(this.B_Test_OnRedSplitSavedTime_Click);
			// 
			// B_Test_OnGreenSplitSaved
			// 
			this.B_Test_OnGreenSplitSaved.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnGreenSplitSaved.ForeColor = System.Drawing.Color.Green;
			this.B_Test_OnGreenSplitSaved.Location = new System.Drawing.Point(181, 74);
			this.B_Test_OnGreenSplitSaved.Name = "B_Test_OnGreenSplitSaved";
			this.B_Test_OnGreenSplitSaved.Size = new System.Drawing.Size(88, 42);
			this.B_Test_OnGreenSplitSaved.TabIndex = 13;
			this.B_Test_OnGreenSplitSaved.Text = "OnGreenSplit (Saved time)";
			this.B_Test_OnGreenSplitSaved.UseVisualStyleBackColor = true;
			this.B_Test_OnGreenSplitSaved.Click += new System.EventHandler(this.B_Test_OnGreenSplitSaved_Click);
			// 
			// B_Test_OnGreenSplitLost
			// 
			this.B_Test_OnGreenSplitLost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnGreenSplitLost.ForeColor = System.Drawing.Color.Green;
			this.B_Test_OnGreenSplitLost.Location = new System.Drawing.Point(332, 74);
			this.B_Test_OnGreenSplitLost.Name = "B_Test_OnGreenSplitLost";
			this.B_Test_OnGreenSplitLost.Size = new System.Drawing.Size(88, 42);
			this.B_Test_OnGreenSplitLost.TabIndex = 14;
			this.B_Test_OnGreenSplitLost.Text = "OnGreenSplit (Lost time)";
			this.B_Test_OnGreenSplitLost.UseVisualStyleBackColor = true;
			this.B_Test_OnGreenSplitLost.Click += new System.EventHandler(this.B_Test_OnGreenSplitLost_Click);
			// 
			// StreamerBot_Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tlpMain);
			this.Name = "StreamerBot_Settings";
			this.Size = new System.Drawing.Size(476, 539);
			this.VisibleChanged += new System.EventHandler(this.StreamerBotSettings_VisibleChanged);
			this.gbStartSplits.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tlpMain.ResumeLayout(false);
			this.gbLog.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbStartSplits;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TextBox TB_Address;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button B_Connect;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label L_ConnectionStatus;
		private System.Windows.Forms.CheckBox CB_Autoconnect;
		private System.Windows.Forms.CheckBox CB_Log_DebugMessages;
		private System.Windows.Forms.GroupBox gbLog;
		private System.Windows.Forms.RichTextBox RB_LogText;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button B_Test_OnReset;
		private System.Windows.Forms.Button B_Test_OnPause;
		private System.Windows.Forms.Button B_Test_OnStart;
		private System.Windows.Forms.Button B_Test_OnGreenBestSplit;
		private System.Windows.Forms.Button B_Test_OnRedSplitGold;
		private System.Windows.Forms.Button B_Test_OnSkipSplit;
		private System.Windows.Forms.Button B_Test_OnUndoSplit;
		private System.Windows.Forms.Button B_Test_OnResume;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.Button B_Test_OnRedSplitSavedTime;
		private System.Windows.Forms.Button B_Test_OnRedSplitLostTime;
		private System.Windows.Forms.Button B_Test_OnGreenSplitSaved;
		private System.Windows.Forms.Button B_Test_OnGreenSplitLost;
	}
}
