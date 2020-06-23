namespace PupilIsNotStudent
{
    partial class UnitTestFormGuess
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlpMainParent = new System.Windows.Forms.TableLayoutPanel();
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
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tlpMainParent.SuspendLayout();
            this.tlpMainInputOutVisual.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpRTB_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 561);
            this.tabControl.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tlpMainParent);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Analyzer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tlpMainParent
            // 
            this.tlpMainParent.ColumnCount = 1;
            this.tlpMainParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainParent.Controls.Add(this.tlpMainInputOutVisual, 0, 1);
            this.tlpMainParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainParent.Location = new System.Drawing.Point(3, 3);
            this.tlpMainParent.Name = "tlpMainParent";
            this.tlpMainParent.RowCount = 3;
            this.tlpMainParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpMainParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpMainParent.Size = new System.Drawing.Size(770, 522);
            this.tlpMainParent.TabIndex = 35;
            // 
            // tlpMainInputOutVisual
            // 
            this.tlpMainInputOutVisual.ColumnCount = 2;
            this.tlpMainInputOutVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainInputOutVisual.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMainInputOutVisual.Controls.Add(this.panel1, 0, 0);
            this.tlpMainInputOutVisual.Controls.Add(this.tlpRTB_DGV, 0, 0);
            this.tlpMainInputOutVisual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainInputOutVisual.Location = new System.Drawing.Point(3, 75);
            this.tlpMainInputOutVisual.Name = "tlpMainInputOutVisual";
            this.tlpMainInputOutVisual.RowCount = 1;
            this.tlpMainInputOutVisual.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainInputOutVisual.Size = new System.Drawing.Size(764, 372);
            this.tlpMainInputOutVisual.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbDEresult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(567, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 366);
            this.panel1.TabIndex = 38;
            // 
            // lbDEresult
            // 
            this.lbDEresult.AutoSize = true;
            this.lbDEresult.Location = new System.Drawing.Point(3, 3);
            this.lbDEresult.Name = "lbDEresult";
            this.lbDEresult.Size = new System.Drawing.Size(0, 24);
            this.lbDEresult.TabIndex = 21;
            // 
            // tlpRTB_DGV
            // 
            this.tlpRTB_DGV.ColumnCount = 1;
            this.tlpRTB_DGV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRTB_DGV.Controls.Add(this.myGrid, 0, 1);
            this.tlpRTB_DGV.Controls.Add(this.richTBtoAnalyze, 0, 0);
            this.tlpRTB_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRTB_DGV.Location = new System.Drawing.Point(3, 3);
            this.tlpRTB_DGV.Name = "tlpRTB_DGV";
            this.tlpRTB_DGV.RowCount = 2;
            this.tlpRTB_DGV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRTB_DGV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tlpRTB_DGV.Size = new System.Drawing.Size(558, 366);
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
            this.myGrid.Location = new System.Drawing.Point(3, 174);
            this.myGrid.Name = "myGrid";
            this.myGrid.ReadOnly = true;
            this.myGrid.Size = new System.Drawing.Size(552, 189);
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
            this.richTBtoAnalyze.Location = new System.Drawing.Point(3, 3);
            this.richTBtoAnalyze.Name = "richTBtoAnalyze";
            this.richTBtoAnalyze.Size = new System.Drawing.Size(552, 165);
            this.richTBtoAnalyze.TabIndex = 38;
            this.richTBtoAnalyze.Text = "";
            // 
            // UnitTestFormGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(800, 298);
            this.Name = "UnitTestFormGuess";
            this.Text = "Wake Up, Neo...";
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tlpMainParent.ResumeLayout(false);
            this.tlpMainInputOutVisual.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlpRTB_DGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tlpMainParent;
        private System.Windows.Forms.TableLayoutPanel tlpMainInputOutVisual;
        private System.Windows.Forms.TableLayoutPanel tlpRTB_DGV;
        private System.Windows.Forms.RichTextBox richTBtoAnalyze;
        private System.Windows.Forms.DataGridView myGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentOfMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDEresult;
    }
}

