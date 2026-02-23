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
			this.B_Test_OnGoldSplit = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.B_Test_OnGold = new System.Windows.Forms.Button();
			this.B_Test_OnStart = new System.Windows.Forms.Button();
			this.B_Test_OnSkipSplit = new System.Windows.Forms.Button();
			this.B_Test_OnGreenSplit = new System.Windows.Forms.Button();
			this.B_Test_OnPause = new System.Windows.Forms.Button();
			this.B_Test_OnRedSplit = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.B_Test_OnReset = new System.Windows.Forms.Button();
			this.B_Test_OnResume = new System.Windows.Forms.Button();
			this.B_Test_OnUndoSplit = new System.Windows.Forms.Button();
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.gbLog = new System.Windows.Forms.GroupBox();
			this.RB_LogText = new System.Windows.Forms.RichTextBox();
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
			this.gbStartSplits.Size = new System.Drawing.Size(470, 288);
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 264);
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
			this.groupBox1.Size = new System.Drawing.Size(458, 183);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Test actions";
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel6.ColumnCount = 3;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnGoldSplit, 2, 3);
			this.tableLayoutPanel6.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnGold, 2, 2);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnStart, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnSkipSplit, 2, 1);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnGreenSplit, 1, 3);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnPause, 2, 0);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnRedSplit, 1, 2);
			this.tableLayoutPanel6.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnReset, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnResume, 0, 1);
			this.tableLayoutPanel6.Controls.Add(this.B_Test_OnUndoSplit, 1, 1);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 4;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(452, 164);
			this.tableLayoutPanel6.TabIndex = 13;
			// 
			// B_Test_OnGoldSplit
			// 
			this.B_Test_OnGoldSplit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnGoldSplit.Location = new System.Drawing.Point(332, 130);
			this.B_Test_OnGoldSplit.Name = "B_Test_OnGoldSplit";
			this.B_Test_OnGoldSplit.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnGoldSplit.TabIndex = 10;
			this.B_Test_OnGoldSplit.Text = "OnGoldSplit";
			this.B_Test_OnGoldSplit.UseVisualStyleBackColor = true;
			this.B_Test_OnGoldSplit.Click += new System.EventHandler(this.B_Test_OnGoldSplit_Click);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Run ahead of PB:";
			// 
			// B_Test_OnGold
			// 
			this.B_Test_OnGold.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnGold.Location = new System.Drawing.Point(332, 88);
			this.B_Test_OnGold.Name = "B_Test_OnGold";
			this.B_Test_OnGold.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnGold.TabIndex = 11;
			this.B_Test_OnGold.Text = "OnGold";
			this.B_Test_OnGold.UseVisualStyleBackColor = true;
			this.B_Test_OnGold.Click += new System.EventHandler(this.B_Test_OnGold_Click);
			// 
			// B_Test_OnStart
			// 
			this.B_Test_OnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnStart.Location = new System.Drawing.Point(31, 8);
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
			this.B_Test_OnSkipSplit.Location = new System.Drawing.Point(332, 48);
			this.B_Test_OnSkipSplit.Name = "B_Test_OnSkipSplit";
			this.B_Test_OnSkipSplit.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnSkipSplit.TabIndex = 6;
			this.B_Test_OnSkipSplit.Text = "OnSkipSplit";
			this.B_Test_OnSkipSplit.UseVisualStyleBackColor = true;
			this.B_Test_OnSkipSplit.Click += new System.EventHandler(this.B_Test_OnSkipSplit_Click);
			// 
			// B_Test_OnGreenSplit
			// 
			this.B_Test_OnGreenSplit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnGreenSplit.Location = new System.Drawing.Point(181, 130);
			this.B_Test_OnGreenSplit.Name = "B_Test_OnGreenSplit";
			this.B_Test_OnGreenSplit.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnGreenSplit.TabIndex = 9;
			this.B_Test_OnGreenSplit.Text = "OnGreenSplit";
			this.B_Test_OnGreenSplit.UseVisualStyleBackColor = true;
			this.B_Test_OnGreenSplit.Click += new System.EventHandler(this.B_Test_OnGreenSplit_Click);
			// 
			// B_Test_OnPause
			// 
			this.B_Test_OnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnPause.Location = new System.Drawing.Point(332, 8);
			this.B_Test_OnPause.Name = "B_Test_OnPause";
			this.B_Test_OnPause.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnPause.TabIndex = 1;
			this.B_Test_OnPause.Text = "OnPause";
			this.B_Test_OnPause.UseVisualStyleBackColor = true;
			this.B_Test_OnPause.Click += new System.EventHandler(this.B_Test_OnPause_Click);
			// 
			// B_Test_OnRedSplit
			// 
			this.B_Test_OnRedSplit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnRedSplit.Location = new System.Drawing.Point(181, 88);
			this.B_Test_OnRedSplit.Name = "B_Test_OnRedSplit";
			this.B_Test_OnRedSplit.Size = new System.Drawing.Size(88, 24);
			this.B_Test_OnRedSplit.TabIndex = 8;
			this.B_Test_OnRedSplit.Text = "OnRedSplit";
			this.B_Test_OnRedSplit.UseVisualStyleBackColor = true;
			this.B_Test_OnRedSplit.Click += new System.EventHandler(this.B_Test_OnRedSplit_Click);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Run behind PB:";
			// 
			// B_Test_OnReset
			// 
			this.B_Test_OnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Test_OnReset.Location = new System.Drawing.Point(181, 8);
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
			this.B_Test_OnResume.Location = new System.Drawing.Point(31, 48);
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
			this.B_Test_OnUndoSplit.Location = new System.Drawing.Point(181, 48);
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
			this.gbLog.Location = new System.Drawing.Point(3, 297);
			this.gbLog.Name = "gbLog";
			this.gbLog.Size = new System.Drawing.Size(470, 239);
			this.gbLog.TabIndex = 6;
			this.gbLog.TabStop = false;
			this.gbLog.Text = "Log";
			// 
			// RB_LogText
			// 
			this.RB_LogText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RB_LogText.Location = new System.Drawing.Point(3, 16);
			this.RB_LogText.Name = "RB_LogText";
			this.RB_LogText.Size = new System.Drawing.Size(464, 220);
			this.RB_LogText.TabIndex = 0;
			this.RB_LogText.Text = "";
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
			this.tableLayoutPanel6.PerformLayout();
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
		private System.Windows.Forms.Button B_Test_OnGold;
		private System.Windows.Forms.Button B_Test_OnGoldSplit;
		private System.Windows.Forms.Button B_Test_OnGreenSplit;
		private System.Windows.Forms.Button B_Test_OnRedSplit;
		private System.Windows.Forms.Button B_Test_OnSkipSplit;
		private System.Windows.Forms.Button B_Test_OnUndoSplit;
		private System.Windows.Forms.Button B_Test_OnResume;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
	}
}
