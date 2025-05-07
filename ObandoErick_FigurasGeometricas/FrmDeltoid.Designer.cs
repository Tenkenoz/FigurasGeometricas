namespace ObandoErick_FigurasGeometricas
{
    partial class FrmDeltoid
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalculate = new System.Windows.Forms.Button();
            this.txtReset = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMajorDiagonal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinorDiagonal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGraphic = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Area);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtArea);
            this.groupBox3.Controls.Add(this.txtPerimeter);
            this.groupBox3.Location = new System.Drawing.Point(23, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 93);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outputs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 38;
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(37, 34);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(36, 16);
            this.Area.TabIndex = 40;
            this.Area.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Perimeter";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(120, 34);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 42;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(120, 58);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 22);
            this.txtPerimeter.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCalculate);
            this.groupBox2.Controls.Add(this.txtReset);
            this.groupBox2.Controls.Add(this.txtExit);
            this.groupBox2.Location = new System.Drawing.Point(23, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 67);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 38;
            // 
            // txtCalculate
            // 
            this.txtCalculate.BackColor = System.Drawing.SystemColors.Info;
            this.txtCalculate.Location = new System.Drawing.Point(12, 34);
            this.txtCalculate.Name = "txtCalculate";
            this.txtCalculate.Size = new System.Drawing.Size(75, 23);
            this.txtCalculate.TabIndex = 44;
            this.txtCalculate.Text = "Calculate";
            this.txtCalculate.UseVisualStyleBackColor = false;
            this.txtCalculate.Click += new System.EventHandler(this.txtCalculate_Click);
            // 
            // txtReset
            // 
            this.txtReset.BackColor = System.Drawing.SystemColors.Info;
            this.txtReset.Location = new System.Drawing.Point(93, 34);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(75, 23);
            this.txtReset.TabIndex = 46;
            this.txtReset.Text = "Reset";
            this.txtReset.UseVisualStyleBackColor = false;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // txtExit
            // 
            this.txtExit.BackColor = System.Drawing.SystemColors.Info;
            this.txtExit.Location = new System.Drawing.Point(174, 34);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(75, 23);
            this.txtExit.TabIndex = 45;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = false;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtMajorDiagonal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMinorDiagonal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(23, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 91);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // txtMajorDiagonal
            // 
            this.txtMajorDiagonal.Location = new System.Drawing.Point(118, 22);
            this.txtMajorDiagonal.Name = "txtMajorDiagonal";
            this.txtMajorDiagonal.Size = new System.Drawing.Size(100, 22);
            this.txtMajorDiagonal.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.CausesValidation = false;
            this.label6.Location = new System.Drawing.Point(13, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "MinorDiagonal";
            // 
            // txtMinorDiagonal
            // 
            this.txtMinorDiagonal.Location = new System.Drawing.Point(114, 58);
            this.txtMinorDiagonal.Name = "txtMinorDiagonal";
            this.txtMinorDiagonal.Size = new System.Drawing.Size(100, 22);
            this.txtMinorDiagonal.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.CausesValidation = false;
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Major Diagonal";
            // 
            // lblGraphic
            // 
            this.lblGraphic.AutoSize = true;
            this.lblGraphic.Location = new System.Drawing.Point(360, 34);
            this.lblGraphic.Name = "lblGraphic";
            this.lblGraphic.Size = new System.Drawing.Size(54, 16);
            this.lblGraphic.TabIndex = 74;
            this.lblGraphic.Text = "Graphic";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picCanvas.Location = new System.Drawing.Point(360, 67);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(418, 350);
            this.picCanvas.TabIndex = 73;
            this.picCanvas.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 28);
            this.textBox1.TabIndex = 78;
            this.textBox1.Text = "Deltoid";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmDeltoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGraphic);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmDeltoid";
            this.Text = "FrmDeltoid";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtCalculate;
        private System.Windows.Forms.Button txtReset;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGraphic;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinorDiagonal;
        private System.Windows.Forms.TextBox txtMajorDiagonal;
        private System.Windows.Forms.TextBox textBox1;
    }
}