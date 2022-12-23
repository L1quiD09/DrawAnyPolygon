namespace Figuras
{
    partial class frmCirculo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDrawAxis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nRadio = new System.Windows.Forms.NumericUpDown();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPerimetroC = new System.Windows.Forms.TextBox();
            this.txtAreaC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownP = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(16, 19);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(667, 615);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCanvas);
            this.groupBox1.Location = new System.Drawing.Point(403, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(691, 654);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graficos";
            // 
            // btnDrawAxis
            // 
            this.btnDrawAxis.Location = new System.Drawing.Point(41, 46);
            this.btnDrawAxis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDrawAxis.Name = "btnDrawAxis";
            this.btnDrawAxis.Size = new System.Drawing.Size(143, 28);
            this.btnDrawAxis.TabIndex = 11;
            this.btnDrawAxis.Text = "Dibujar ejes";
            this.btnDrawAxis.UseVisualStyleBackColor = true;
            this.btnDrawAxis.Click += new System.EventHandler(this.btnDrawAxis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Radio";
            // 
            // nRadio
            // 
            this.nRadio.Location = new System.Drawing.Point(41, 130);
            this.nRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nRadio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRadio.Name = "nRadio";
            this.nRadio.Size = new System.Drawing.Size(160, 22);
            this.nRadio.TabIndex = 13;
            this.nRadio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.Location = new System.Drawing.Point(41, 180);
            this.btnDrawCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(143, 28);
            this.btnDrawCircle.TabIndex = 14;
            this.btnDrawCircle.Text = "Dibujar";
            this.btnDrawCircle.UseVisualStyleBackColor = true;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(41, 335);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(143, 28);
            this.btnClean.TabIndex = 15;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(41, 383);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 28);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPerimetroC
            // 
            this.txtPerimetroC.Enabled = false;
            this.txtPerimetroC.Location = new System.Drawing.Point(169, 279);
            this.txtPerimetroC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPerimetroC.Name = "txtPerimetroC";
            this.txtPerimetroC.Size = new System.Drawing.Size(129, 22);
            this.txtPerimetroC.TabIndex = 23;
            // 
            // txtAreaC
            // 
            this.txtAreaC.Enabled = false;
            this.txtAreaC.Location = new System.Drawing.Point(169, 245);
            this.txtAreaC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAreaC.Name = "txtAreaC";
            this.txtAreaC.Size = new System.Drawing.Size(129, 22);
            this.txtAreaC.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Perimetro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "N Puntos";
            // 
            // numericUpDownP
            // 
            this.numericUpDownP.Location = new System.Drawing.Point(287, 130);
            this.numericUpDownP.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownP.Name = "numericUpDownP";
            this.numericUpDownP.Size = new System.Drawing.Size(91, 22);
            this.numericUpDownP.TabIndex = 27;
            this.numericUpDownP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 708);
            this.Controls.Add(this.numericUpDownP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPerimetroC);
            this.Controls.Add(this.txtAreaC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDrawCircle);
            this.Controls.Add(this.nRadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDrawAxis);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCirculo";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmCirculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDrawAxis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nRadio;
        private System.Windows.Forms.Button btnDrawCircle;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPerimetroC;
        private System.Windows.Forms.TextBox txtAreaC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownP;
    }
}