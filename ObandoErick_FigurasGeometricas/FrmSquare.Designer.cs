namespace ObandoErick_FigurasGeometricas
{
    partial class FrmSquare
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtReset = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.txtCalculate = new System.Windows.Forms.Button();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGraphic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(327, 57);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(394, 336);
            this.picCanvas.TabIndex = 23;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(90, 31);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(75, 23);
            this.txtReset.TabIndex = 22;
            this.txtReset.Text = "Reset";
            this.txtReset.UseVisualStyleBackColor = true;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(171, 31);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(75, 23);
            this.txtExit.TabIndex = 21;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // txtCalculate
            // 
            this.txtCalculate.Location = new System.Drawing.Point(9, 31);
            this.txtCalculate.Name = "txtCalculate";
            this.txtCalculate.Size = new System.Drawing.Size(75, 23);
            this.txtCalculate.TabIndex = 20;
            this.txtCalculate.Text = "Calculate";
            this.txtCalculate.UseVisualStyleBackColor = true;
            this.txtCalculate.Click += new System.EventHandler(this.txtCalculate_Click);
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(98, 66);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 22);
            this.txtPerimeter.TabIndex = 19;
            this.txtPerimeter.TextChanged += new System.EventHandler(this.txtPerimeter_TextChanged);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(98, 31);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 22);
            this.txtArea.TabIndex = 17;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(96, 35);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(100, 22);
            this.txtSide.TabIndex = 16;
            this.txtSide.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(21, 34);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(36, 16);
            this.Area.TabIndex = 15;
            this.Area.Text = "Area";
            this.Area.Click += new System.EventHandler(this.Area_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Perimeter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(19, 35);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(35, 16);
            this.lblSide.TabIndex = 12;
            this.lblSide.Text = "Side";
            this.lblSide.Click += new System.EventHandler(this.width_Click);
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
            this.textBox1.TabIndex = 67;
            this.textBox1.Text = "Square";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Area);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtArea);
            this.groupBox3.Controls.Add(this.txtPerimeter);
            this.groupBox3.Location = new System.Drawing.Point(41, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 120);
            this.groupBox3.TabIndex = 66;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCalculate);
            this.groupBox2.Controls.Add(this.txtExit);
            this.groupBox2.Controls.Add(this.txtReset);
            this.groupBox2.Location = new System.Drawing.Point(41, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 76);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtSide);
            this.groupBox1.Controls.Add(this.lblSide);
            this.groupBox1.Location = new System.Drawing.Point(41, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 79);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // lblGraphic
            // 
            this.lblGraphic.AutoSize = true;
            this.lblGraphic.Location = new System.Drawing.Point(324, 38);
            this.lblGraphic.Name = "lblGraphic";
            this.lblGraphic.Size = new System.Drawing.Size(54, 16);
            this.lblGraphic.TabIndex = 63;
            this.lblGraphic.Text = "Graphic";
            // 
            // FrmSquare
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
            this.Name = "FrmSquare";
            this.Text = "FrmSquare";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button txtReset;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Button txtCalculate;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGraphic;
    }
}