namespace ImagePrintForm
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFindCoordinates = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtV2x = new System.Windows.Forms.TextBox();
            this.txtV2y = new System.Windows.Forms.TextBox();
            this.txtV1x = new System.Windows.Forms.TextBox();
            this.txtV1y = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtV3x = new System.Windows.Forms.TextBox();
            this.txtV3y = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(63, 338);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw Image";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 320);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(298, 338);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFindCoordinates
            // 
            this.btnFindCoordinates.Enabled = false;
            this.btnFindCoordinates.Location = new System.Drawing.Point(170, 104);
            this.btnFindCoordinates.Name = "btnFindCoordinates";
            this.btnFindCoordinates.Size = new System.Drawing.Size(109, 23);
            this.btnFindCoordinates.TabIndex = 3;
            this.btnFindCoordinates.Text = "Find Coordinates";
            this.btnFindCoordinates.UseVisualStyleBackColor = true;
            this.btnFindCoordinates.Click += new System.EventHandler(this.btnFindCoordinates_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtV3y);
            this.panel1.Controls.Add(this.txtV3x);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtV1y);
            this.panel1.Controls.Add(this.txtV1x);
            this.panel1.Controls.Add(this.txtV2y);
            this.panel1.Controls.Add(this.txtV2x);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFindCoordinates);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(63, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 183);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter X and Y coordiates to find the Triangle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "V1x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "V1y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(205, 146);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(74, 20);
            this.txtResult.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "V2x:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "V2y:";
            // 
            // txtV2x
            // 
            this.txtV2x.Location = new System.Drawing.Point(49, 104);
            this.txtV2x.Name = "txtV2x";
            this.txtV2x.Size = new System.Drawing.Size(57, 20);
            this.txtV2x.TabIndex = 13;
            // 
            // txtV2y
            // 
            this.txtV2y.Location = new System.Drawing.Point(49, 130);
            this.txtV2y.Name = "txtV2y";
            this.txtV2y.Size = new System.Drawing.Size(57, 20);
            this.txtV2y.TabIndex = 14;
            // 
            // txtV1x
            // 
            this.txtV1x.Location = new System.Drawing.Point(49, 42);
            this.txtV1x.Name = "txtV1x";
            this.txtV1x.Size = new System.Drawing.Size(60, 20);
            this.txtV1x.TabIndex = 15;
            // 
            // txtV1y
            // 
            this.txtV1y.Location = new System.Drawing.Point(49, 68);
            this.txtV1y.Name = "txtV1y";
            this.txtV1y.Size = new System.Drawing.Size(60, 20);
            this.txtV1y.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "V3y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "V3x:";
            // 
            // txtV3x
            // 
            this.txtV3x.Location = new System.Drawing.Point(205, 39);
            this.txtV3x.Name = "txtV3x";
            this.txtV3x.Size = new System.Drawing.Size(57, 20);
            this.txtV3x.TabIndex = 20;
            // 
            // txtV3y
            // 
            this.txtV3y.Location = new System.Drawing.Point(205, 67);
            this.txtV3y.Name = "txtV3y";
            this.txtV3y.Size = new System.Drawing.Size(57, 20);
            this.txtV3y.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(429, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "Image Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFindCoordinates;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtV1y;
        private System.Windows.Forms.TextBox txtV1x;
        private System.Windows.Forms.TextBox txtV2y;
        private System.Windows.Forms.TextBox txtV2x;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtV3y;
        private System.Windows.Forms.TextBox txtV3x;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

