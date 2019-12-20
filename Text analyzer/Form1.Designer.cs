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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlpVertical = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTfIdf = new System.Windows.Forms.Button();
            this.btnIdf = new System.Windows.Forms.Button();
            this.btnTf = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.tlpKnownTextPeeledTFIDF = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbBig = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbWords = new System.Windows.Forms.Label();
            this.tbNews = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHorisontalButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLoadTextFromFile = new System.Windows.Forms.Button();
            this.tlpUnknownTextGridDE = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.myGrid = new System.Windows.Forms.DataGridView();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfMatches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentOfMatches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDEresult = new System.Windows.Forms.Label();
            this.richTBtoAnalyze = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDE = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlpVertical.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tlpKnownTextPeeledTFIDF.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpHorisontalButtons.SuspendLayout();
            this.tlpUnknownTextGridDE.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.tlpVertical);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlpVertical
            // 
            this.tlpVertical.ColumnCount = 1;
            this.tlpVertical.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVertical.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tlpVertical.Controls.Add(this.tlpKnownTextPeeledTFIDF, 0, 1);
            this.tlpVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVertical.Location = new System.Drawing.Point(3, 3);
            this.tlpVertical.Name = "tlpVertical";
            this.tlpVertical.RowCount = 4;
            this.tlpVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpVertical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVertical.Size = new System.Drawing.Size(770, 522);
            this.tlpVertical.TabIndex = 19;
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
            this.tableLayoutPanel9.Size = new System.Drawing.Size(764, 59);
            this.tableLayoutPanel9.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(616, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 53);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save JSON";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnTfIdf
            // 
            this.btnTfIdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTfIdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTfIdf.Location = new System.Drawing.Point(465, 3);
            this.btnTfIdf.Name = "btnTfIdf";
            this.btnTfIdf.Size = new System.Drawing.Size(145, 53);
            this.btnTfIdf.TabIndex = 18;
            this.btnTfIdf.Text = "TFIDF";
            this.btnTfIdf.UseVisualStyleBackColor = true;
            // 
            // btnIdf
            // 
            this.btnIdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIdf.Location = new System.Drawing.Point(314, 3);
            this.btnIdf.Name = "btnIdf";
            this.btnIdf.Size = new System.Drawing.Size(145, 53);
            this.btnIdf.TabIndex = 17;
            this.btnIdf.Text = "IDF";
            this.btnIdf.UseVisualStyleBackColor = true;
            // 
            // btnTf
            // 
            this.btnTf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTf.Location = new System.Drawing.Point(163, 3);
            this.btnTf.Name = "btnTf";
            this.btnTf.Size = new System.Drawing.Size(145, 53);
            this.btnTf.TabIndex = 16;
            this.btnTf.Text = "TF";
            this.btnTf.UseVisualStyleBackColor = true;
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
            // cbCategories
            // 
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(3, 29);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(147, 23);
            this.cbCategories.TabIndex = 14;
            // 
            // tlpKnownTextPeeledTFIDF
            // 
            this.tlpKnownTextPeeledTFIDF.ColumnCount = 3;
            this.tlpKnownTextPeeledTFIDF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKnownTextPeeledTFIDF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpKnownTextPeeledTFIDF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpKnownTextPeeledTFIDF.Controls.Add(this.panel3, 0, 0);
            this.tlpKnownTextPeeledTFIDF.Controls.Add(this.panel2, 0, 0);
            this.tlpKnownTextPeeledTFIDF.Controls.Add(this.tbNews, 0, 0);
            this.tlpKnownTextPeeledTFIDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKnownTextPeeledTFIDF.Location = new System.Drawing.Point(3, 68);
            this.tlpKnownTextPeeledTFIDF.Name = "tlpKnownTextPeeledTFIDF";
            this.tlpKnownTextPeeledTFIDF.RowCount = 1;
            this.tlpKnownTextPeeledTFIDF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKnownTextPeeledTFIDF.Size = new System.Drawing.Size(764, 381);
            this.tlpKnownTextPeeledTFIDF.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lbBig);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(617, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 375);
            this.panel3.TabIndex = 9;
            // 
            // lbBig
            // 
            this.lbBig.AutoSize = true;
            this.lbBig.Location = new System.Drawing.Point(3, 0);
            this.lbBig.Name = "lbBig";
            this.lbBig.Size = new System.Drawing.Size(0, 20);
            this.lbBig.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lbWords);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel2.Location = new System.Drawing.Point(467, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 375);
            this.panel2.TabIndex = 8;
            // 
            // lbWords
            // 
            this.lbWords.AutoSize = true;
            this.lbWords.Location = new System.Drawing.Point(3, 0);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(0, 20);
            this.lbWords.TabIndex = 4;
            // 
            // tbNews
            // 
            this.tbNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNews.Location = new System.Drawing.Point(3, 3);
            this.tbNews.MaxLength = 100000;
            this.tbNews.Multiline = true;
            this.tbNews.Name = "tbNews";
            this.tbNews.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNews.Size = new System.Drawing.Size(458, 375);
            this.tbNews.TabIndex = 3;
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
            this.tableLayoutPanel2.Controls.Add(this.tlpUnknownTextGridDE, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 522);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // tlpHorisontalButtons
            // 
            this.tlpHorisontalButtons.ColumnCount = 2;
            this.tlpHorisontalButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHorisontalButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHorisontalButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHorisontalButtons.Controls.Add(this.btnLoad, 0, 0);
            this.tlpHorisontalButtons.Controls.Add(this.btnLoadTextFromFile, 0, 0);
            this.tlpHorisontalButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHorisontalButtons.Location = new System.Drawing.Point(3, 3);
            this.tlpHorisontalButtons.Name = "tlpHorisontalButtons";
            this.tlpHorisontalButtons.RowCount = 1;
            this.tlpHorisontalButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHorisontalButtons.Size = new System.Drawing.Size(764, 54);
            this.tlpHorisontalButtons.TabIndex = 33;
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLoad.Location = new System.Drawing.Point(385, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(376, 48);
            this.btnLoad.TabIndex = 36;
            this.btnLoad.Text = "Load JSON";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnLoadTextFromFile
            // 
            this.btnLoadTextFromFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadTextFromFile.Location = new System.Drawing.Point(3, 3);
            this.btnLoadTextFromFile.Name = "btnLoadTextFromFile";
            this.btnLoadTextFromFile.Size = new System.Drawing.Size(376, 48);
            this.btnLoadTextFromFile.TabIndex = 35;
            this.btnLoadTextFromFile.Text = "Load Text from File";
            this.btnLoadTextFromFile.UseVisualStyleBackColor = true;
            // 
            // tlpUnknownTextGridDE
            // 
            this.tlpUnknownTextGridDE.ColumnCount = 2;
            this.tlpUnknownTextGridDE.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUnknownTextGridDE.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUnknownTextGridDE.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tlpUnknownTextGridDE.Controls.Add(this.richTBtoAnalyze, 0, 0);
            this.tlpUnknownTextGridDE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUnknownTextGridDE.Location = new System.Drawing.Point(3, 63);
            this.tlpUnknownTextGridDE.Name = "tlpUnknownTextGridDE";
            this.tlpUnknownTextGridDE.RowCount = 1;
            this.tlpUnknownTextGridDE.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUnknownTextGridDE.Size = new System.Drawing.Size(764, 396);
            this.tlpUnknownTextGridDE.TabIndex = 34;
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(376, 390);
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
            this.myGrid.Size = new System.Drawing.Size(262, 384);
            this.myGrid.TabIndex = 16;
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbDEresult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(271, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 384);
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
            // richTBtoAnalyze
            // 
            this.richTBtoAnalyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTBtoAnalyze.Location = new System.Drawing.Point(3, 3);
            this.richTBtoAnalyze.Name = "richTBtoAnalyze";
            this.richTBtoAnalyze.Size = new System.Drawing.Size(376, 390);
            this.richTBtoAnalyze.TabIndex = 37;
            this.richTBtoAnalyze.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnDE, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAnalysis, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 465);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 54);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // btnDE
            // 
            this.btnDE.AutoSize = true;
            this.btnDE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnDE.Location = new System.Drawing.Point(385, 3);
            this.btnDE.Name = "btnDE";
            this.btnDE.Size = new System.Drawing.Size(376, 48);
            this.btnDE.TabIndex = 43;
            this.btnDE.Text = "Analyze Disperse Estimation";
            this.btnDE.UseVisualStyleBackColor = true;
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.AutoSize = true;
            this.btnAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAnalysis.Location = new System.Drawing.Point(3, 3);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(376, 48);
            this.btnAnalysis.TabIndex = 42;
            this.btnAnalysis.Text = "Analyze Category";
            this.btnAnalysis.UseVisualStyleBackColor = true;
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
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tlpVertical.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tlpKnownTextPeeledTFIDF.ResumeLayout(false);
            this.tlpKnownTextPeeledTFIDF.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlpHorisontalButtons.ResumeLayout(false);
            this.tlpHorisontalButtons.PerformLayout();
            this.tlpUnknownTextGridDE.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView myGrid;
        private System.Windows.Forms.TableLayoutPanel tlpHorisontalButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tlpUnknownTextGridDE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDEresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentOfMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnLoadTextFromFile;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDE;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.RichTextBox richTBtoAnalyze;
        private System.Windows.Forms.TableLayoutPanel tlpVertical;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTfIdf;
        private System.Windows.Forms.Button btnIdf;
        private System.Windows.Forms.Button btnTf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.TableLayoutPanel tlpKnownTextPeeledTFIDF;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbBig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbWords;
        private System.Windows.Forms.TextBox tbNews;
    }
}

