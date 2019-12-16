namespace Text_analyzer
{
    partial class Form1
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
            this.lbCategory = new System.Windows.Forms.Label();
            this.tbNews = new System.Windows.Forms.TextBox();
            this.lbWords = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbBig = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTfIdf = new System.Windows.Forms.Button();
            this.btnIdf = new System.Windows.Forms.Button();
            this.btnTf = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHorisontalButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDE = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.myGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDEresult = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadTextFromFile = new System.Windows.Forms.Button();
            this.richTBtoAnalyze = new System.Windows.Forms.RichTextBox();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfMatches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentOfMatches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpHorisontalButtons.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbCategory.Location = new System.Drawing.Point(3, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(147, 24);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Chose category:";
            // 
            // tbNews
            // 
            this.tbNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNews.Location = new System.Drawing.Point(3, 68);
            this.tbNews.MaxLength = 100000;
            this.tbNews.Multiline = true;
            this.tbNews.Name = "tbNews";
            this.tbNews.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNews.Size = new System.Drawing.Size(408, 445);
            this.tbNews.TabIndex = 2;
            // 
            // lbWords
            // 
            this.lbWords.AutoSize = true;
            this.lbWords.Location = new System.Drawing.Point(3, 0);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(0, 20);
            this.lbWords.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lbWords);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel2.Location = new System.Drawing.Point(423, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 516);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lbBig);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(573, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 516);
            this.panel3.TabIndex = 8;
            // 
            // lbBig
            // 
            this.lbBig.AutoSize = true;
            this.lbBig.Location = new System.Drawing.Point(3, 0);
            this.lbBig.Name = "lbBig";
            this.lbBig.Size = new System.Drawing.Size(0, 20);
            this.lbBig.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 561);
            this.tabControl.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel10);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(770, 522);
            this.tableLayoutPanel10.TabIndex = 20;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tbNews, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(414, 516);
            this.tableLayoutPanel7.TabIndex = 18;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 5;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.Controls.Add(this.btnSave, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnTfIdf, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnIdf, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnTf, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(408, 59);
            this.tableLayoutPanel9.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(349, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 53);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTfIdf
            // 
            this.btnTfIdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTfIdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTfIdf.Location = new System.Drawing.Point(287, 3);
            this.btnTfIdf.Name = "btnTfIdf";
            this.btnTfIdf.Size = new System.Drawing.Size(56, 53);
            this.btnTfIdf.TabIndex = 18;
            this.btnTfIdf.Text = "TFIDF";
            this.btnTfIdf.UseVisualStyleBackColor = true;
            this.btnTfIdf.Click += new System.EventHandler(this.btnTfIdf_Click);
            // 
            // btnIdf
            // 
            this.btnIdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIdf.Location = new System.Drawing.Point(225, 3);
            this.btnIdf.Name = "btnIdf";
            this.btnIdf.Size = new System.Drawing.Size(56, 53);
            this.btnIdf.TabIndex = 17;
            this.btnIdf.Text = "IDF";
            this.btnIdf.UseVisualStyleBackColor = true;
            this.btnIdf.Click += new System.EventHandler(this.btnIdf_Click);
            // 
            // btnTf
            // 
            this.btnTf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTf.Location = new System.Drawing.Point(163, 3);
            this.btnTf.Name = "btnTf";
            this.btnTf.Size = new System.Drawing.Size(56, 53);
            this.btnTf.TabIndex = 16;
            this.btnTf.Text = "TF";
            this.btnTf.UseVisualStyleBackColor = true;
            this.btnTf.Click += new System.EventHandler(this.btnTf_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lbCategory, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.cbCategories, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(154, 53);
            this.tableLayoutPanel6.TabIndex = 15;
            // 
            // cbCategories
            // 
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(3, 29);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(147, 23);
            this.cbCategories.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Analyzer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tlpHorisontalButtons, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 522);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // tlpHorisontalButtons
            // 
            this.tlpHorisontalButtons.ColumnCount = 3;
            this.tlpHorisontalButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHorisontalButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHorisontalButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHorisontalButtons.Controls.Add(this.btnDE, 0, 0);
            this.tlpHorisontalButtons.Controls.Add(this.btnAnalysis, 0, 0);
            this.tlpHorisontalButtons.Controls.Add(this.btnLoad, 0, 0);
            this.tlpHorisontalButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHorisontalButtons.Location = new System.Drawing.Point(3, 3);
            this.tlpHorisontalButtons.Name = "tlpHorisontalButtons";
            this.tlpHorisontalButtons.RowCount = 1;
            this.tlpHorisontalButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHorisontalButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpHorisontalButtons.Size = new System.Drawing.Size(764, 54);
            this.tlpHorisontalButtons.TabIndex = 33;
            // 
            // btnDE
            // 
            this.btnDE.AutoSize = true;
            this.btnDE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnDE.Location = new System.Drawing.Point(511, 3);
            this.btnDE.Name = "btnDE";
            this.btnDE.Size = new System.Drawing.Size(250, 48);
            this.btnDE.TabIndex = 34;
            this.btnDE.Text = "Analyze by DE";
            this.btnDE.UseVisualStyleBackColor = true;
            this.btnDE.Click += new System.EventHandler(this.btnDE_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.AutoSize = true;
            this.btnAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAnalysis.Location = new System.Drawing.Point(257, 3);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(248, 48);
            this.btnAnalysis.TabIndex = 33;
            this.btnAnalysis.Text = "Analyze";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLoad.Location = new System.Drawing.Point(3, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(248, 48);
            this.btnLoad.TabIndex = 32;
            this.btnLoad.Text = "Load JSON";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(764, 456);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel5.Controls.Add(this.myGrid, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(385, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(376, 450);
            this.tableLayoutPanel5.TabIndex = 36;
            // 
            // myGrid
            // 
            this.myGrid.AllowUserToAddRows = false;
            this.myGrid.AllowUserToDeleteRows = false;
            this.myGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Topic,
            this.numberOfMatches,
            this.percentOfMatches,
            this.dataGridViewTextBoxColumn1});
            this.myGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGrid.Location = new System.Drawing.Point(3, 3);
            this.myGrid.Name = "myGrid";
            this.myGrid.Size = new System.Drawing.Size(262, 444);
            this.myGrid.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbDEresult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(271, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 444);
            this.panel1.TabIndex = 17;
            // 
            // lbDEresult
            // 
            this.lbDEresult.AutoSize = true;
            this.lbDEresult.Location = new System.Drawing.Point(3, 3);
            this.lbDEresult.Name = "lbDEresult";
            this.lbDEresult.Size = new System.Drawing.Size(0, 24);
            this.lbDEresult.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnLoadTextFromFile, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.richTBtoAnalyze, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(376, 450);
            this.tableLayoutPanel4.TabIndex = 36;
            // 
            // btnLoadTextFromFile
            // 
            this.btnLoadTextFromFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadTextFromFile.Location = new System.Drawing.Point(3, 403);
            this.btnLoadTextFromFile.Name = "btnLoadTextFromFile";
            this.btnLoadTextFromFile.Size = new System.Drawing.Size(370, 44);
            this.btnLoadTextFromFile.TabIndex = 20;
            this.btnLoadTextFromFile.Text = "Load Text from File";
            this.btnLoadTextFromFile.UseVisualStyleBackColor = true;
            this.btnLoadTextFromFile.Click += new System.EventHandler(this.btnLoadTextFromFile_Click);
            // 
            // richTBtoAnalyze
            // 
            this.richTBtoAnalyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTBtoAnalyze.Location = new System.Drawing.Point(3, 3);
            this.richTBtoAnalyze.Name = "richTBtoAnalyze";
            this.richTBtoAnalyze.Size = new System.Drawing.Size(370, 394);
            this.richTBtoAnalyze.TabIndex = 21;
            this.richTBtoAnalyze.Text = "";
            // 
            // Topic
            // 
            this.Topic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Topic.FillWeight = 32F;
            this.Topic.HeaderText = "Category";
            this.Topic.MinimumWidth = 80;
            this.Topic.Name = "Topic";
            // 
            // numberOfMatches
            // 
            this.numberOfMatches.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberOfMatches.FillWeight = 25F;
            this.numberOfMatches.HeaderText = "TF IDF";
            this.numberOfMatches.MinimumWidth = 40;
            this.numberOfMatches.Name = "numberOfMatches";
            // 
            // percentOfMatches
            // 
            this.percentOfMatches.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.percentOfMatches.FillWeight = 25F;
            this.percentOfMatches.HeaderText = "Disperce Etimation";
            this.percentOfMatches.MinimumWidth = 60;
            this.percentOfMatches.Name = "percentOfMatches";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 25F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Result (TFIDF*DE)";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "Form1";
            this.Text = "Text analyzer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlpHorisontalButtons.ResumeLayout(false);
            this.tlpHorisontalButtons.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox tbNews;
        private System.Windows.Forms.Label lbWords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbBig;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Button btnLoadTextFromFile;
        private System.Windows.Forms.DataGridView myGrid;
        private System.Windows.Forms.TableLayoutPanel tlpHorisontalButtons;
        private System.Windows.Forms.Button btnDE;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTfIdf;
        private System.Windows.Forms.Button btnIdf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnTf;
        private System.Windows.Forms.RichTextBox richTBtoAnalyze;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDEresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentOfMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

