namespace Connect_Four.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCountMoves = new System.Windows.Forms.Label();
            this.buttonCol0 = new System.Windows.Forms.Button();
            this.buttonCol1 = new System.Windows.Forms.Button();
            this.buttonCol2 = new System.Windows.Forms.Button();
            this.buttonCol5 = new System.Windows.Forms.Button();
            this.buttonCol4 = new System.Windows.Forms.Button();
            this.buttonCol3 = new System.Windows.Forms.Button();
            this.buttonCol6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Computer -> 2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(170, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(310, 244);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Human -> 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Moves:";
            // 
            // labelCountMoves
            // 
            this.labelCountMoves.AutoSize = true;
            this.labelCountMoves.Location = new System.Drawing.Point(57, 243);
            this.labelCountMoves.Name = "labelCountMoves";
            this.labelCountMoves.Size = new System.Drawing.Size(13, 13);
            this.labelCountMoves.TabIndex = 9;
            this.labelCountMoves.Text = "0";
            // 
            // buttonCol0
            // 
            this.buttonCol0.Location = new System.Drawing.Point(170, 262);
            this.buttonCol0.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.buttonCol0.Name = "buttonCol0";
            this.buttonCol0.Size = new System.Drawing.Size(40, 23);
            this.buttonCol0.TabIndex = 11;
            this.buttonCol0.Text = "1";
            this.buttonCol0.UseVisualStyleBackColor = true;
            this.buttonCol0.Click += new System.EventHandler(this.buttonCol_Click);
            // 
            // buttonCol1
            // 
            this.buttonCol1.Location = new System.Drawing.Point(215, 262);
            this.buttonCol1.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.buttonCol1.Name = "buttonCol1";
            this.buttonCol1.Size = new System.Drawing.Size(40, 23);
            this.buttonCol1.TabIndex = 12;
            this.buttonCol1.Text = "2";
            this.buttonCol1.UseVisualStyleBackColor = true;
            this.buttonCol1.MouseCaptureChanged += new System.EventHandler(this.buttonCol_Click);
            // 
            // buttonCol2
            // 
            this.buttonCol2.Location = new System.Drawing.Point(260, 262);
            this.buttonCol2.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.buttonCol2.Name = "buttonCol2";
            this.buttonCol2.Size = new System.Drawing.Size(40, 23);
            this.buttonCol2.TabIndex = 13;
            this.buttonCol2.Text = "3";
            this.buttonCol2.UseVisualStyleBackColor = true;
            this.buttonCol2.Click += new System.EventHandler(this.buttonCol_Click);
            // 
            // buttonCol5
            // 
            this.buttonCol5.Location = new System.Drawing.Point(395, 262);
            this.buttonCol5.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.buttonCol5.Name = "buttonCol5";
            this.buttonCol5.Size = new System.Drawing.Size(40, 23);
            this.buttonCol5.TabIndex = 14;
            this.buttonCol5.Text = "6";
            this.buttonCol5.UseVisualStyleBackColor = true;
            this.buttonCol5.Click += new System.EventHandler(this.buttonCol_Click);
            // 
            // buttonCol4
            // 
            this.buttonCol4.Location = new System.Drawing.Point(350, 262);
            this.buttonCol4.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.buttonCol4.Name = "buttonCol4";
            this.buttonCol4.Size = new System.Drawing.Size(40, 23);
            this.buttonCol4.TabIndex = 15;
            this.buttonCol4.Text = "5";
            this.buttonCol4.UseVisualStyleBackColor = true;
            this.buttonCol4.Click += new System.EventHandler(this.buttonCol_Click);
            // 
            // buttonCol3
            // 
            this.buttonCol3.Location = new System.Drawing.Point(305, 262);
            this.buttonCol3.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.buttonCol3.Name = "buttonCol3";
            this.buttonCol3.Size = new System.Drawing.Size(40, 23);
            this.buttonCol3.TabIndex = 16;
            this.buttonCol3.Text = "4";
            this.buttonCol3.UseVisualStyleBackColor = true;
            this.buttonCol3.Click += new System.EventHandler(this.buttonCol_Click);
            // 
            // buttonCol6
            // 
            this.buttonCol6.Location = new System.Drawing.Point(440, 262);
            this.buttonCol6.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.buttonCol6.Name = "buttonCol6";
            this.buttonCol6.Size = new System.Drawing.Size(40, 23);
            this.buttonCol6.TabIndex = 17;
            this.buttonCol6.Text = "7";
            this.buttonCol6.UseVisualStyleBackColor = true;
            this.buttonCol6.Click += new System.EventHandler(this.buttonCol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Depth: ";
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Location = new System.Drawing.Point(49, 126);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(56, 20);
            this.textBoxDepth.TabIndex = 19;
            this.textBoxDepth.Text = "7";
            this.textBoxDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Score: ";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(58, 262);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(13, 13);
            this.labelScore.TabIndex = 22;
            this.labelScore.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 302);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxDepth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCol6);
            this.Controls.Add(this.buttonCol3);
            this.Controls.Add(this.buttonCol4);
            this.Controls.Add(this.buttonCol5);
            this.Controls.Add(this.buttonCol2);
            this.Controls.Add(this.buttonCol1);
            this.Controls.Add(this.buttonCol0);
            this.Controls.Add(this.labelCountMoves);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Connect Four INE5430";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCountMoves;
        private System.Windows.Forms.Button buttonCol0;
        private System.Windows.Forms.Button buttonCol1;
        private System.Windows.Forms.Button buttonCol2;
        private System.Windows.Forms.Button buttonCol5;
        private System.Windows.Forms.Button buttonCol4;
        private System.Windows.Forms.Button buttonCol3;
        private System.Windows.Forms.Button buttonCol6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelScore;

    }
}