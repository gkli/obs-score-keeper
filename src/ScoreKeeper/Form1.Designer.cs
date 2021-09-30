
namespace ScoreKeeper
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPeriods = new ScoreKeeper.Controls.RefreshingComboBox();
            this.txtClockFormat = new System.Windows.Forms.TextBox();
            this.txtClockValue = new System.Windows.Forms.TextBox();
            this.gameScore1 = new ScoreKeeper.Controls.GameScore();
            this.chkSkipGoalImage = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseScoreFile = new System.Windows.Forms.Button();
            this.btnBrowseClockFile = new System.Windows.Forms.Button();
            this.txtScoreFile = new System.Windows.Forms.TextBox();
            this.txtClockFile = new System.Windows.Forms.TextBox();
            this.txtGoalImageSrcFileName = new System.Windows.Forms.TextBox();
            this.btnBrowseGoalImageSrc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGoalImageDstFileName = new System.Windows.Forms.TextBox();
            this.btnBrowseGoalImageDst = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddPeriod = new System.Windows.Forms.Button();
            this.btnRemovePeriod = new System.Windows.Forms.Button();
            this.lbPeriods = new ScoreKeeper.Controls.RefreshingListBox();
            this.btnPeriodUp = new System.Windows.Forms.Button();
            this.btnPeriodDown = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.goalImageTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 1132);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(979, 1078);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Run";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnStartStop, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnReset, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.cbPeriods, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtClockFormat, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtClockValue, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.gameScore1, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.chkSkipGoalImage, 1, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(973, 1070);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(25, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 64);
            this.label4.TabIndex = 0;
            this.label4.Text = "Format";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(25, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 64);
            this.label5.TabIndex = 1;
            this.label5.Text = "Period";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartStop.Location = new System.Drawing.Point(792, 30);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(156, 56);
            this.btnStartStop.TabIndex = 2;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(792, 94);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 56);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(25, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 64);
            this.label6.TabIndex = 4;
            this.label6.Text = "Clock";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPeriods
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.cbPeriods, 2);
            this.cbPeriods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPeriods.FormattingEnabled = true;
            this.cbPeriods.Location = new System.Drawing.Point(242, 158);
            this.cbPeriods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPeriods.Name = "cbPeriods";
            this.cbPeriods.Size = new System.Drawing.Size(706, 40);
            this.cbPeriods.TabIndex = 5;
            this.cbPeriods.SelectedIndexChanged += new System.EventHandler(this.cbPeriods_SelectedIndexChanged);
            // 
            // txtClockFormat
            // 
            this.txtClockFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClockFormat.Location = new System.Drawing.Point(242, 30);
            this.txtClockFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClockFormat.Name = "txtClockFormat";
            this.txtClockFormat.ReadOnly = true;
            this.txtClockFormat.Size = new System.Drawing.Size(544, 39);
            this.txtClockFormat.TabIndex = 6;
            this.txtClockFormat.Text = "MM:SS";
            // 
            // txtClockValue
            // 
            this.txtClockValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClockValue.Location = new System.Drawing.Point(242, 94);
            this.txtClockValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClockValue.Name = "txtClockValue";
            this.txtClockValue.Size = new System.Drawing.Size(544, 39);
            this.txtClockValue.TabIndex = 7;
            this.txtClockValue.Text = "00:00";
            // 
            // gameScore1
            // 
            this.gameScore1.AwayScore = 0;
            this.tableLayoutPanel4.SetColumnSpan(this.gameScore1, 3);
            this.gameScore1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameScore1.HomeScore = 0;
            this.gameScore1.Location = new System.Drawing.Point(25, 223);
            this.gameScore1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gameScore1.Name = "gameScore1";
            this.gameScore1.Size = new System.Drawing.Size(923, 770);
            this.gameScore1.TabIndex = 8;
            this.gameScore1.ScoreChanged += new System.EventHandler<ScoreKeeper.Controls.GameScore.ScoreChangedEventArgs>(this.gameScore1_ScoreChanged);
            // 
            // chkSkipGoalImage
            // 
            this.chkSkipGoalImage.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.chkSkipGoalImage, 3);
            this.chkSkipGoalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSkipGoalImage.Location = new System.Drawing.Point(25, 1002);
            this.chkSkipGoalImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSkipGoalImage.Name = "chkSkipGoalImage";
            this.chkSkipGoalImage.Size = new System.Drawing.Size(923, 38);
            this.chkSkipGoalImage.TabIndex = 9;
            this.chkSkipGoalImage.Text = "Supress Goal Image";
            this.chkSkipGoalImage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(979, 1078);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 1070);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(25, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(923, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paths";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnBrowseScoreFile, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBrowseClockFile, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtScoreFile, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtClockFile, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtGoalImageSrcFileName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnBrowseGoalImageSrc, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtGoalImageDstFileName, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnBrowseGoalImageDst, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(917, 409);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 102);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clock File";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 102);
            this.label3.TabIndex = 2;
            this.label3.Text = "Goal Image Src";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowseScoreFile
            // 
            this.btnBrowseScoreFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseScoreFile.Location = new System.Drawing.Point(855, 4);
            this.btnBrowseScoreFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowseScoreFile.Name = "btnBrowseScoreFile";
            this.btnBrowseScoreFile.Size = new System.Drawing.Size(59, 94);
            this.btnBrowseScoreFile.TabIndex = 3;
            this.btnBrowseScoreFile.Text = "...";
            this.btnBrowseScoreFile.UseVisualStyleBackColor = true;
            this.btnBrowseScoreFile.Click += new System.EventHandler(this.btnBrowseScoreFile_Click);
            // 
            // btnBrowseClockFile
            // 
            this.btnBrowseClockFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseClockFile.Location = new System.Drawing.Point(855, 106);
            this.btnBrowseClockFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowseClockFile.Name = "btnBrowseClockFile";
            this.btnBrowseClockFile.Size = new System.Drawing.Size(59, 94);
            this.btnBrowseClockFile.TabIndex = 4;
            this.btnBrowseClockFile.Text = "...";
            this.btnBrowseClockFile.UseVisualStyleBackColor = true;
            this.btnBrowseClockFile.Click += new System.EventHandler(this.btnBrowseClockFile_Click);
            // 
            // txtScoreFile
            // 
            this.txtScoreFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScoreFile.Location = new System.Drawing.Point(220, 4);
            this.txtScoreFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScoreFile.Multiline = true;
            this.txtScoreFile.Name = "txtScoreFile";
            this.txtScoreFile.Size = new System.Drawing.Size(629, 94);
            this.txtScoreFile.TabIndex = 5;
            // 
            // txtClockFile
            // 
            this.txtClockFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClockFile.Location = new System.Drawing.Point(220, 106);
            this.txtClockFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClockFile.Multiline = true;
            this.txtClockFile.Name = "txtClockFile";
            this.txtClockFile.Size = new System.Drawing.Size(629, 94);
            this.txtClockFile.TabIndex = 6;
            // 
            // txtGoalImageSrcFileName
            // 
            this.txtGoalImageSrcFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGoalImageSrcFileName.Location = new System.Drawing.Point(220, 208);
            this.txtGoalImageSrcFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGoalImageSrcFileName.Multiline = true;
            this.txtGoalImageSrcFileName.Name = "txtGoalImageSrcFileName";
            this.txtGoalImageSrcFileName.Size = new System.Drawing.Size(629, 94);
            this.txtGoalImageSrcFileName.TabIndex = 7;
            // 
            // btnBrowseGoalImageSrc
            // 
            this.btnBrowseGoalImageSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseGoalImageSrc.Location = new System.Drawing.Point(855, 208);
            this.btnBrowseGoalImageSrc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowseGoalImageSrc.Name = "btnBrowseGoalImageSrc";
            this.btnBrowseGoalImageSrc.Size = new System.Drawing.Size(59, 94);
            this.btnBrowseGoalImageSrc.TabIndex = 8;
            this.btnBrowseGoalImageSrc.Text = "...";
            this.btnBrowseGoalImageSrc.UseVisualStyleBackColor = true;
            this.btnBrowseGoalImageSrc.Click += new System.EventHandler(this.btnBrowseGoalImageSrc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 103);
            this.label7.TabIndex = 9;
            this.label7.Text = "Goal Image Dst";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGoalImageDstFileName
            // 
            this.txtGoalImageDstFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGoalImageDstFileName.Location = new System.Drawing.Point(220, 310);
            this.txtGoalImageDstFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGoalImageDstFileName.Multiline = true;
            this.txtGoalImageDstFileName.Name = "txtGoalImageDstFileName";
            this.txtGoalImageDstFileName.Size = new System.Drawing.Size(629, 95);
            this.txtGoalImageDstFileName.TabIndex = 10;
            // 
            // btnBrowseGoalImageDst
            // 
            this.btnBrowseGoalImageDst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseGoalImageDst.Location = new System.Drawing.Point(855, 310);
            this.btnBrowseGoalImageDst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowseGoalImageDst.Name = "btnBrowseGoalImageDst";
            this.btnBrowseGoalImageDst.Size = new System.Drawing.Size(59, 95);
            this.btnBrowseGoalImageDst.TabIndex = 11;
            this.btnBrowseGoalImageDst.Text = "...";
            this.btnBrowseGoalImageDst.UseVisualStyleBackColor = true;
            this.btnBrowseGoalImageDst.Click += new System.EventHandler(this.btnBrowseGoalImageDst_Click);
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(25, 513);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(923, 449);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Periods";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddPeriod, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnRemovePeriod, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbPeriods, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPeriodUp, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPeriodDown, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(917, 409);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAddPeriod
            // 
            this.btnAddPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPeriod.Location = new System.Drawing.Point(3, 348);
            this.btnAddPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPeriod.Name = "btnAddPeriod";
            this.btnAddPeriod.Size = new System.Drawing.Size(124, 57);
            this.btnAddPeriod.TabIndex = 0;
            this.btnAddPeriod.Text = "Add";
            this.btnAddPeriod.UseVisualStyleBackColor = true;
            this.btnAddPeriod.Click += new System.EventHandler(this.btnAddPeriod_Click);
            // 
            // btnRemovePeriod
            // 
            this.btnRemovePeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemovePeriod.Location = new System.Drawing.Point(133, 348);
            this.btnRemovePeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemovePeriod.Name = "btnRemovePeriod";
            this.btnRemovePeriod.Size = new System.Drawing.Size(124, 57);
            this.btnRemovePeriod.TabIndex = 1;
            this.btnRemovePeriod.Text = "Remove";
            this.btnRemovePeriod.UseVisualStyleBackColor = true;
            this.btnRemovePeriod.Click += new System.EventHandler(this.btnRemovePeriod_Click);
            // 
            // lbPeriods
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.lbPeriods, 3);
            this.lbPeriods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPeriods.FormattingEnabled = true;
            this.lbPeriods.ItemHeight = 32;
            this.lbPeriods.Location = new System.Drawing.Point(3, 4);
            this.lbPeriods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbPeriods.Name = "lbPeriods";
            this.tableLayoutPanel3.SetRowSpan(this.lbPeriods, 2);
            this.lbPeriods.Size = new System.Drawing.Size(857, 336);
            this.lbPeriods.TabIndex = 2;
            this.lbPeriods.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbPeriods_MouseDoubleClick);
            // 
            // btnPeriodUp
            // 
            this.btnPeriodUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPeriodUp.Location = new System.Drawing.Point(866, 4);
            this.btnPeriodUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPeriodUp.Name = "btnPeriodUp";
            this.btnPeriodUp.Size = new System.Drawing.Size(48, 164);
            this.btnPeriodUp.TabIndex = 3;
            this.btnPeriodUp.Text = "^";
            this.btnPeriodUp.UseVisualStyleBackColor = true;
            // 
            // btnPeriodDown
            // 
            this.btnPeriodDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPeriodDown.Location = new System.Drawing.Point(866, 176);
            this.btnPeriodDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPeriodDown.Name = "btnPeriodDown";
            this.btnPeriodDown.Size = new System.Drawing.Size(48, 164);
            this.btnPeriodDown.TabIndex = 4;
            this.btnPeriodDown.Text = "v";
            this.btnPeriodDown.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(737, 970);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(211, 69);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // goalImageTimer
            // 
            this.goalImageTimer.Interval = 7500;
            this.goalImageTimer.Tick += new System.EventHandler(this.goalImageTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 1132);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseScoreFile;
        private System.Windows.Forms.Button btnBrowseClockFile;
        private System.Windows.Forms.TextBox txtScoreFile;
        private System.Windows.Forms.TextBox txtClockFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAddPeriod;
        private System.Windows.Forms.Button btnRemovePeriod;
        private Controls.RefreshingListBox lbPeriods;
        private System.Windows.Forms.Button btnPeriodUp;
        private System.Windows.Forms.Button btnPeriodDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private Controls.RefreshingComboBox cbPeriods;
        private System.Windows.Forms.TextBox txtClockFormat;
        private System.Windows.Forms.TextBox txtClockValue;
        private Controls.GameScore gameScore1;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.TextBox txtGoalImageSrcFileName;
        private System.Windows.Forms.Button btnBrowseGoalImageSrc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGoalImageDstFileName;
        private System.Windows.Forms.Button btnBrowseGoalImageDst;
        private System.Windows.Forms.Timer goalImageTimer;
        private System.Windows.Forms.CheckBox chkSkipGoalImage;
    }
}

