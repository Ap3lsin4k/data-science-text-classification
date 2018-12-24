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
            this.categoryName = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.tbNews = new System.Windows.Forms.TextBox();
            this.lbRawNews = new System.Windows.Forms.Label();
            this.btnTf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbWords = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbBig = new System.Windows.Forms.Label();
            this.btnIdf = new System.Windows.Forms.Button();
            this.btnTfIdf = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryName
            // 
            this.categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryName.Location = new System.Drawing.Point(157, 28);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(137, 21);
            this.categoryName.TabIndex = 0;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCategory.Location = new System.Drawing.Point(12, 31);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(133, 15);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Enter name of category";
            // 
            // tbNews
            // 
            this.tbNews.Location = new System.Drawing.Point(15, 68);
            this.tbNews.MaxLength = 100000;
            this.tbNews.Multiline = true;
            this.tbNews.Name = "tbNews";
            this.tbNews.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNews.Size = new System.Drawing.Size(483, 540);
            this.tbNews.TabIndex = 2;
            // 
            // lbRawNews
            // 
            this.lbRawNews.AutoSize = true;
            this.lbRawNews.Location = new System.Drawing.Point(3, 0);
            this.lbRawNews.Name = "lbRawNews";
            this.lbRawNews.Size = new System.Drawing.Size(32, 13);
            this.lbRawNews.TabIndex = 3;
            this.lbRawNews.Text = "string";
            this.lbRawNews.Visible = false;
            // 
            // btnTf
            // 
            this.btnTf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTf.Location = new System.Drawing.Point(300, 12);
            this.btnTf.Name = "btnTf";
            this.btnTf.Size = new System.Drawing.Size(50, 50);
            this.btnTf.TabIndex = 4;
            this.btnTf.Text = "TF";
            this.btnTf.UseVisualStyleBackColor = true;
            this.btnTf.Click += new System.EventHandler(this.btnTf_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbRawNews);
            this.panel1.Location = new System.Drawing.Point(180, 558);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 50);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // lbWords
            // 
            this.lbWords.AutoSize = true;
            this.lbWords.Location = new System.Drawing.Point(3, 0);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(0, 13);
            this.lbWords.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lbWords);
            this.panel2.Location = new System.Drawing.Point(507, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 596);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lbBig);
            this.panel3.Location = new System.Drawing.Point(643, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 596);
            this.panel3.TabIndex = 8;
            // 
            // lbBig
            // 
            this.lbBig.AutoSize = true;
            this.lbBig.Location = new System.Drawing.Point(3, 0);
            this.lbBig.Name = "lbBig";
            this.lbBig.Size = new System.Drawing.Size(0, 13);
            this.lbBig.TabIndex = 0;
            // 
            // btnIdf
            // 
            this.btnIdf.Enabled = false;
            this.btnIdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIdf.Location = new System.Drawing.Point(375, 12);
            this.btnIdf.Name = "btnIdf";
            this.btnIdf.Size = new System.Drawing.Size(50, 50);
            this.btnIdf.TabIndex = 9;
            this.btnIdf.Text = "IDF";
            this.btnIdf.UseVisualStyleBackColor = true;
            this.btnIdf.Click += new System.EventHandler(this.btnIdf_Click);
            // 
            // btnTfIdf
            // 
            this.btnTfIdf.Enabled = false;
            this.btnTfIdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTfIdf.Location = new System.Drawing.Point(450, 12);
            this.btnTfIdf.Name = "btnTfIdf";
            this.btnTfIdf.Size = new System.Drawing.Size(50, 50);
            this.btnTfIdf.TabIndex = 10;
            this.btnTfIdf.Text = "TFIDF";
            this.btnTfIdf.UseVisualStyleBackColor = true;
            this.btnTfIdf.Click += new System.EventHandler(this.btnTfIdf_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(832, 12);
            this.textBox1.MaxLength = 100000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(250, 596);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1088, 12);
            this.textBox2.MaxLength = 100000;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(250, 596);
            this.textBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 623);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTfIdf);
            this.Controls.Add(this.btnIdf);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTf);
            this.Controls.Add(this.tbNews);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Text analyzer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox tbNews;
        private System.Windows.Forms.Label lbRawNews;
        private System.Windows.Forms.Button btnTf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbBig;
        private System.Windows.Forms.Button btnIdf;
        private System.Windows.Forms.Button btnTfIdf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

