namespace Text_analyzer
{
    partial class MainWindow
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
            this.tlpVertical_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tlpH_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTfIdf = new System.Windows.Forms.Button();
            this.btnIdf = new System.Windows.Forms.Button();
            this.btnTf = new System.Windows.Forms.Button();
            this.tlpChoseCategory_ComboBox = new System.Windows.Forms.TableLayoutPanel();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.tlpKnownTextProperties = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlpMainParent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHorisontalButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLoadTextFromFile = new System.Windows.Forms.Button();
            this.tlpMainInputOutVisual = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDEresult = new System.Windows.Forms.Label();
            this.tlpRTB_DGV = new System.Windows.Forms.TableLayoutPanel();
            this.myGrid = new System.Windows.Forms.DataGridView();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfMatches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentOfMatches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTBtoAnalyze = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDE = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.lbBig = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbKnownText = new System.Windows.Forms.RichTextBox();
            this.btnLoadTextFromFileToFirstModule = new System.Windows.Forms.Button();
            this.tlpV_KnownTextAndLoadBtn = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlpVertical_Main.SuspendLayout();
            this.tlpH_Buttons.SuspendLayout();
            this.tlpChoseCategory_ComboBox.SuspendLayout();
            this.tlpKnownTextProperties.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tlpMainParent.SuspendLayout();
            this.tlpHorisontalButtons.SuspendLayout();
            this.tlpMainInputOutVisual.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpRTB_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tlpV_KnownTextAndLoadBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1045, 690);
            this.tabControl.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlpVertical_Main);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1037, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlpVertical_Main
            // 
            this.tlpVertical_Main.ColumnCount = 1;
            this.tlpVertical_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVertical_Main.Controls.Add(this.tlpH_Buttons, 0, 0);
            this.tlpVertical_Main.Controls.Add(this.tlpKnownTextProperties, 0, 1);
            this.tlpVertical_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVertical_Main.Location = new System.Drawing.Point(4, 4);
            this.tlpVertical_Main.Margin = new System.Windows.Forms.Padding(4);
            this.tlpVertical_Main.Name = "tlpVertical_Main";
            this.tlpVertical_Main.RowCount = 2;
            this.tlpVertical_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tlpVertical_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVertical_Main.Size = new System.Drawing.Size(1029, 644);
            this.tlpVertical_Main.TabIndex = 19;
            // 
            // tlpH_Buttons
            // 
            this.tlpH_Buttons.ColumnCount = 5;
            this.tlpH_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tlpH_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpH_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpH_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpH_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpH_Buttons.Controls.Add(this.btnSave, 4, 0);
            this.tlpH_Buttons.Controls.Add(this.btnTfIdf, 3, 0);
            this.tlpH_Buttons.Controls.Add(this.btnIdf, 2, 0);
            this.tlpH_Buttons.Controls.Add(this.btnTf, 1, 0);
            this.tlpH_Buttons.Controls.Add(this.tlpChoseCategory_ComboBox, 0, 0);
            this.tlpH_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpH_Buttons.Location = new System.Drawing.Point(4, 4);
            this.tlpH_Buttons.Margin = new System.Windows.Forms.Padding(4);
            this.tlpH_Buttons.Name = "tlpH_Buttons";
            this.tlpH_Buttons.RowCount = 1;
            this.tlpH_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpH_Buttons.Size = new System.Drawing.Size(1021, 81);
            this.tlpH_Buttons.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(823, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 73);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save JSON";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTfIdf
            // 
            this.btnTfIdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTfIdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTfIdf.Location = new System.Drawing.Point(621, 4);
            this.btnTfIdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnTfIdf.Name = "btnTfIdf";
            this.btnTfIdf.Size = new System.Drawing.Size(194, 73);
            this.btnTfIdf.TabIndex = 18;
            this.btnTfIdf.Text = "TFIDF";
            this.btnTfIdf.UseVisualStyleBackColor = true;
            this.btnTfIdf.Click += new System.EventHandler(this.btnTfIdf_Click);
            // 
            // btnIdf
            // 
            this.btnIdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIdf.Location = new System.Drawing.Point(419, 4);
            this.btnIdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnIdf.Name = "btnIdf";
            this.btnIdf.Size = new System.Drawing.Size(194, 73);
            this.btnIdf.TabIndex = 17;
            this.btnIdf.Text = "IDF";
            this.btnIdf.UseVisualStyleBackColor = true;
            this.btnIdf.Click += new System.EventHandler(this.btnIdf_Click);
            // 
            // btnTf
            // 
            this.btnTf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTf.Location = new System.Drawing.Point(217, 4);
            this.btnTf.Margin = new System.Windows.Forms.Padding(4);
            this.btnTf.Name = "btnTf";
            this.btnTf.Size = new System.Drawing.Size(194, 73);
            this.btnTf.TabIndex = 16;
            this.btnTf.Text = "TF";
            this.btnTf.UseVisualStyleBackColor = true;
            this.btnTf.Click += new System.EventHandler(this.btnTf_Click);
            // 
            // tlpChoseCategory_ComboBox
            // 
            this.tlpChoseCategory_ComboBox.ColumnCount = 1;
            this.tlpChoseCategory_ComboBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChoseCategory_ComboBox.Controls.Add(this.lbCategory, 0, 0);
            this.tlpChoseCategory_ComboBox.Controls.Add(this.cbCategories, 0, 1);
            this.tlpChoseCategory_ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChoseCategory_ComboBox.Location = new System.Drawing.Point(4, 4);
            this.tlpChoseCategory_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tlpChoseCategory_ComboBox.Name = "tlpChoseCategory_ComboBox";
            this.tlpChoseCategory_ComboBox.RowCount = 2;
            this.tlpChoseCategory_ComboBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpChoseCategory_ComboBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpChoseCategory_ComboBox.Size = new System.Drawing.Size(205, 73);
            this.tlpChoseCategory_ComboBox.TabIndex = 15;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbCategory.Location = new System.Drawing.Point(4, 0);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(197, 29);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Chose category:";
            // 
            // cbCategories
            // 
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(4, 33);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(196, 37);
            this.cbCategories.TabIndex = 14;
            // 
            // tlpKnownTextProperties
            // 
            this.tlpKnownTextProperties.ColumnCount = 2;
            this.tlpKnownTextProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKnownTextProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tlpKnownTextProperties.Controls.Add(this.panel3, 0, 0);
            this.tlpKnownTextProperties.Controls.Add(this.panel2, 0, 0);
            this.tlpKnownTextProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKnownTextProperties.Location = new System.Drawing.Point(4, 93);
            this.tlpKnownTextProperties.Margin = new System.Windows.Forms.Padding(4);
            this.tlpKnownTextProperties.Name = "tlpKnownTextProperties";
            this.tlpKnownTextProperties.RowCount = 1;
            this.tlpKnownTextProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKnownTextProperties.Size = new System.Drawing.Size(1021, 547);
            this.tlpKnownTextProperties.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tlpMainParent);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1037, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Analyzer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tlpMainParent
            // 
            this.tlpMainParent.ColumnCount = 1;
            this.tlpMainParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainParent.Controls.Add(this.tlpHorisontalButtons, 0, 0);
            this.tlpMainParent.Controls.Add(this.tlpMainInputOutVisual, 0, 1);
            this.tlpMainParent.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpMainParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainParent.Location = new System.Drawing.Point(4, 4);
            this.tlpMainParent.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMainParent.Name = "tlpMainParent";
            this.tlpMainParent.RowCount = 3;
            this.tlpMainParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tlpMainParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tlpMainParent.Size = new System.Drawing.Size(1029, 644);
            this.tlpMainParent.TabIndex = 35;
            // 
            // tlpHorisontalButtons
            // 
            this.tlpHorisontalButtons.ColumnCount = 2;
            this.tlpHorisontalButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHorisontalButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHorisontalButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpHorisontalButtons.Controls.Add(this.btnLoad, 0, 0);
            this.tlpHorisontalButtons.Controls.Add(this.btnLoadTextFromFile, 0, 0);
            this.tlpHorisontalButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHorisontalButtons.Location = new System.Drawing.Point(4, 4);
            this.tlpHorisontalButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tlpHorisontalButtons.Name = "tlpHorisontalButtons";
            this.tlpHorisontalButtons.RowCount = 1;
            this.tlpHorisontalButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHorisontalButtons.Size = new System.Drawing.Size(1021, 81);
            this.tlpHorisontalButtons.TabIndex = 33;
            // 
            // btnLoad
            // 
            this.btnLoad.AutoSize = true;
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLoad.Location = new System.Drawing.Point(514, 4);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(503, 73);
            this.btnLoad.TabIndex = 36;
            this.btnLoad.Text = "Load JSON";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnLoadTextFromFile
            // 
            this.btnLoadTextFromFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadTextFromFile.Location = new System.Drawing.Point(4, 4);
            this.btnLoadTextFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadTextFromFile.Name = "btnLoadTextFromFile";
            this.btnLoadTextFromFile.Size = new System.Drawing.Size(502, 73);
            this.btnLoadTextFromFile.TabIndex = 35;
            this.btnLoadTextFromFile.Text = "Load Text from File";
            this.btnLoadTextFromFile.UseVisualStyleBackColor = true;
            this.btnLoadTextFromFile.Click += new System.EventHandler(this.btnLoadTextFromFile_Click);
            // 
            // tlpMainInputOutVisual
            // 
            this.tlpMainInputOutVisual.ColumnCount = 2;
            this.tlpMainInputOutVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainInputOutVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tlpMainInputOutVisual.Controls.Add(this.panel1, 0, 0);
            this.tlpMainInputOutVisual.Controls.Add(this.tlpRTB_DGV, 0, 0);
            this.tlpMainInputOutVisual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainInputOutVisual.Location = new System.Drawing.Point(4, 93);
            this.tlpMainInputOutVisual.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMainInputOutVisual.Name = "tlpMainInputOutVisual";
            this.tlpMainInputOutVisual.RowCount = 1;
            this.tlpMainInputOutVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainInputOutVisual.Size = new System.Drawing.Size(1021, 458);
            this.tlpMainInputOutVisual.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbDEresult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(758, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 450);
            this.panel1.TabIndex = 38;
            // 
            // lbDEresult
            // 
            this.lbDEresult.AutoSize = true;
            this.lbDEresult.Location = new System.Drawing.Point(4, 4);
            this.lbDEresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDEresult.Name = "lbDEresult";
            this.lbDEresult.Size = new System.Drawing.Size(0, 29);
            this.lbDEresult.TabIndex = 21;
            // 
            // tlpRTB_DGV
            // 
            this.tlpRTB_DGV.ColumnCount = 1;
            this.tlpRTB_DGV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRTB_DGV.Controls.Add(this.myGrid, 0, 1);
            this.tlpRTB_DGV.Controls.Add(this.richTBtoAnalyze, 0, 0);
            this.tlpRTB_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRTB_DGV.Location = new System.Drawing.Point(4, 4);
            this.tlpRTB_DGV.Margin = new System.Windows.Forms.Padding(4);
            this.tlpRTB_DGV.Name = "tlpRTB_DGV";
            this.tlpRTB_DGV.RowCount = 2;
            this.tlpRTB_DGV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRTB_DGV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tlpRTB_DGV.Size = new System.Drawing.Size(746, 450);
            this.tlpRTB_DGV.TabIndex = 37;
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
            this.myGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.myGrid.Location = new System.Drawing.Point(4, 214);
            this.myGrid.Margin = new System.Windows.Forms.Padding(4);
            this.myGrid.Name = "myGrid";
            this.myGrid.ReadOnly = true;
            this.myGrid.Size = new System.Drawing.Size(738, 232);
            this.myGrid.TabIndex = 39;
            // 
            // Topic
            // 
            this.Topic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Topic.FillWeight = 32F;
            this.Topic.HeaderText = "Category";
            this.Topic.MinimumWidth = 80;
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            // 
            // numberOfMatches
            // 
            this.numberOfMatches.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberOfMatches.FillWeight = 25F;
            this.numberOfMatches.HeaderText = "TF IDF";
            this.numberOfMatches.MinimumWidth = 40;
            this.numberOfMatches.Name = "numberOfMatches";
            this.numberOfMatches.ReadOnly = true;
            // 
            // percentOfMatches
            // 
            this.percentOfMatches.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.percentOfMatches.FillWeight = 25F;
            this.percentOfMatches.HeaderText = "Disperce Etimation";
            this.percentOfMatches.MinimumWidth = 60;
            this.percentOfMatches.Name = "percentOfMatches";
            this.percentOfMatches.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 25F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Result (TFIDF*DE)";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // richTBtoAnalyze
            // 
            this.richTBtoAnalyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTBtoAnalyze.Location = new System.Drawing.Point(4, 4);
            this.richTBtoAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.richTBtoAnalyze.Name = "richTBtoAnalyze";
            this.richTBtoAnalyze.Size = new System.Drawing.Size(738, 202);
            this.richTBtoAnalyze.TabIndex = 38;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 559);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1021, 81);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // btnDE
            // 
            this.btnDE.AutoSize = true;
            this.btnDE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnDE.Location = new System.Drawing.Point(514, 4);
            this.btnDE.Margin = new System.Windows.Forms.Padding(4);
            this.btnDE.Name = "btnDE";
            this.btnDE.Size = new System.Drawing.Size(503, 73);
            this.btnDE.TabIndex = 43;
            this.btnDE.Text = "Compute Disperse Estimation";
            this.btnDE.UseVisualStyleBackColor = true;
            this.btnDE.Click += new System.EventHandler(this.btnDE_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.AutoSize = true;
            this.btnAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAnalysis.Location = new System.Drawing.Point(4, 4);
            this.btnAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(502, 73);
            this.btnAnalysis.TabIndex = 42;
            this.btnAnalysis.Text = "Guess Category";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // lbBig
            // 
            this.lbBig.AutoSize = true;
            this.lbBig.Location = new System.Drawing.Point(4, 0);
            this.lbBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBig.Name = "lbBig";
            this.lbBig.Size = new System.Drawing.Size(0, 25);
            this.lbBig.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lbBig);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(758, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 539);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tlpV_KnownTextAndLoadBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 539);
            this.panel2.TabIndex = 8;
            // 
            // rtbKnownText
            // 
            this.rtbKnownText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbKnownText.Location = new System.Drawing.Point(4, 4);
            this.rtbKnownText.Margin = new System.Windows.Forms.Padding(4);
            this.rtbKnownText.Name = "rtbKnownText";
            this.rtbKnownText.Size = new System.Drawing.Size(738, 457);
            this.rtbKnownText.TabIndex = 6;
            this.rtbKnownText.Text = "";
            // 
            // btnLoadTextFromFileToFirstModule
            // 
            this.btnLoadTextFromFileToFirstModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadTextFromFileToFirstModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLoadTextFromFileToFirstModule.Location = new System.Drawing.Point(4, 469);
            this.btnLoadTextFromFileToFirstModule.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadTextFromFileToFirstModule.Name = "btnLoadTextFromFileToFirstModule";
            this.btnLoadTextFromFileToFirstModule.Size = new System.Drawing.Size(738, 66);
            this.btnLoadTextFromFileToFirstModule.TabIndex = 5;
            this.btnLoadTextFromFileToFirstModule.Text = "Load Text from File";
            this.btnLoadTextFromFileToFirstModule.UseVisualStyleBackColor = true;
            this.btnLoadTextFromFileToFirstModule.Click += new System.EventHandler(this.btnCategories_LoadTextFromFile_Click);
            // 
            // tlpV_KnownTextAndLoadBtn
            // 
            this.tlpV_KnownTextAndLoadBtn.ColumnCount = 1;
            this.tlpV_KnownTextAndLoadBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpV_KnownTextAndLoadBtn.Controls.Add(this.btnLoadTextFromFileToFirstModule, 0, 1);
            this.tlpV_KnownTextAndLoadBtn.Controls.Add(this.rtbKnownText, 0, 0);
            this.tlpV_KnownTextAndLoadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpV_KnownTextAndLoadBtn.Location = new System.Drawing.Point(0, 0);
            this.tlpV_KnownTextAndLoadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.tlpV_KnownTextAndLoadBtn.Name = "tlpV_KnownTextAndLoadBtn";
            this.tlpV_KnownTextAndLoadBtn.RowCount = 2;
            this.tlpV_KnownTextAndLoadBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpV_KnownTextAndLoadBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpV_KnownTextAndLoadBtn.Size = new System.Drawing.Size(746, 539);
            this.tlpV_KnownTextAndLoadBtn.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 358);
            this.Name = "MainWindow";
            this.Text = "But The Good News Is";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tlpVertical_Main.ResumeLayout(false);
            this.tlpH_Buttons.ResumeLayout(false);
            this.tlpChoseCategory_ComboBox.ResumeLayout(false);
            this.tlpChoseCategory_ComboBox.PerformLayout();
            this.tlpKnownTextProperties.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tlpMainParent.ResumeLayout(false);
            this.tlpHorisontalButtons.ResumeLayout(false);
            this.tlpHorisontalButtons.PerformLayout();
            this.tlpMainInputOutVisual.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlpRTB_DGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tlpV_KnownTextAndLoadBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tlpHorisontalButtons;
        private System.Windows.Forms.TableLayoutPanel tlpMainParent;
        private System.Windows.Forms.TableLayoutPanel tlpMainInputOutVisual;
        private System.Windows.Forms.Button btnLoadTextFromFile;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDE;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.TableLayoutPanel tlpVertical_Main;
        private System.Windows.Forms.TableLayoutPanel tlpH_Buttons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTfIdf;
        private System.Windows.Forms.Button btnIdf;
        private System.Windows.Forms.Button btnTf;
        private System.Windows.Forms.TableLayoutPanel tlpChoseCategory_ComboBox;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.TableLayoutPanel tlpKnownTextProperties;
        private System.Windows.Forms.TableLayoutPanel tlpRTB_DGV;
        private System.Windows.Forms.RichTextBox richTBtoAnalyze;
        private System.Windows.Forms.DataGridView myGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentOfMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDEresult;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbBig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tlpV_KnownTextAndLoadBtn;
        private System.Windows.Forms.Button btnLoadTextFromFileToFirstModule;
        private System.Windows.Forms.RichTextBox rtbKnownText;
    }
}

