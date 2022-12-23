namespace Figuras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDrawRec = new System.Windows.Forms.Button();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYf = new System.Windows.Forms.TextBox();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.txtYi = new System.Windows.Forms.TextBox();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.btnDrawAxis = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDrawTri = new System.Windows.Forms.Button();
            this.txtPerimetroT = new System.Windows.Forms.TextBox();
            this.txtAreaT = new System.Windows.Forms.TextBox();
            this.btnPerimetroT = new System.Windows.Forms.Button();
            this.btnAreaT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTYf = new System.Windows.Forms.TextBox();
            this.txtTXf = new System.Windows.Forms.TextBox();
            this.txtTYi = new System.Windows.Forms.TextBox();
            this.txtTXi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCanvas);
            this.groupBox1.Location = new System.Drawing.Point(452, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 531);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graficos";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(8, 17);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(500, 500);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDrawRec);
            this.groupBox2.Controls.Add(this.txtPerimetro);
            this.groupBox2.Controls.Add(this.txtArea);
            this.groupBox2.Controls.Add(this.btnPerimetro);
            this.groupBox2.Controls.Add(this.btnArea);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtYf);
            this.groupBox2.Controls.Add(this.txtXf);
            this.groupBox2.Controls.Add(this.txtYi);
            this.groupBox2.Controls.Add(this.txtXi);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 201);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuadrado";
            // 
            // btnDrawRec
            // 
            this.btnDrawRec.Location = new System.Drawing.Point(14, 81);
            this.btnDrawRec.Name = "btnDrawRec";
            this.btnDrawRec.Size = new System.Drawing.Size(84, 25);
            this.btnDrawRec.TabIndex = 20;
            this.btnDrawRec.Text = "Dibujar";
            this.btnDrawRec.UseVisualStyleBackColor = true;
            this.btnDrawRec.Click += new System.EventHandler(this.btnDrawRec_Click);
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Enabled = false;
            this.txtPerimetro.Location = new System.Drawing.Point(108, 151);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(98, 20);
            this.txtPerimetro.TabIndex = 19;
            this.txtPerimetro.TextChanged += new System.EventHandler(this.txtPerimetro_TextChanged);
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(108, 123);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(98, 20);
            this.txtArea.TabIndex = 18;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(12, 149);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(75, 23);
            this.btnPerimetro.TabIndex = 17;
            this.btnPerimetro.Text = "Perimetro";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(12, 120);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 16;
            this.btnArea.Text = "Área";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Yf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Xf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Xi";
            // 
            // txtYf
            // 
            this.txtYf.Location = new System.Drawing.Point(310, 47);
            this.txtYf.Name = "txtYf";
            this.txtYf.Size = new System.Drawing.Size(74, 20);
            this.txtYf.TabIndex = 11;
            // 
            // txtXf
            // 
            this.txtXf.Location = new System.Drawing.Point(214, 47);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(74, 20);
            this.txtXf.TabIndex = 10;
            // 
            // txtYi
            // 
            this.txtYi.Location = new System.Drawing.Point(98, 47);
            this.txtYi.Name = "txtYi";
            this.txtYi.Size = new System.Drawing.Size(74, 20);
            this.txtYi.TabIndex = 9;
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(9, 47);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(74, 20);
            this.txtXi.TabIndex = 8;
            // 
            // btnDrawAxis
            // 
            this.btnDrawAxis.Location = new System.Drawing.Point(12, 21);
            this.btnDrawAxis.Name = "btnDrawAxis";
            this.btnDrawAxis.Size = new System.Drawing.Size(107, 23);
            this.btnDrawAxis.TabIndex = 10;
            this.btnDrawAxis.Text = "Dibujar ejes";
            this.btnDrawAxis.UseVisualStyleBackColor = true;
            this.btnDrawAxis.Click += new System.EventHandler(this.btnDrawAxis_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDrawTri);
            this.groupBox3.Controls.Add(this.txtPerimetroT);
            this.groupBox3.Controls.Add(this.txtAreaT);
            this.groupBox3.Controls.Add(this.btnPerimetroT);
            this.groupBox3.Controls.Add(this.btnAreaT);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTYf);
            this.groupBox3.Controls.Add(this.txtTXf);
            this.groupBox3.Controls.Add(this.txtTYi);
            this.groupBox3.Controls.Add(this.txtTXi);
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 234);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Triangulo";
            // 
            // btnDrawTri
            // 
            this.btnDrawTri.Location = new System.Drawing.Point(14, 81);
            this.btnDrawTri.Name = "btnDrawTri";
            this.btnDrawTri.Size = new System.Drawing.Size(84, 25);
            this.btnDrawTri.TabIndex = 20;
            this.btnDrawTri.Text = "Dibujar";
            this.btnDrawTri.UseVisualStyleBackColor = true;
            this.btnDrawTri.Click += new System.EventHandler(this.btnDrawTri_Click);
            // 
            // txtPerimetroT
            // 
            this.txtPerimetroT.Enabled = false;
            this.txtPerimetroT.Location = new System.Drawing.Point(108, 151);
            this.txtPerimetroT.Name = "txtPerimetroT";
            this.txtPerimetroT.Size = new System.Drawing.Size(98, 20);
            this.txtPerimetroT.TabIndex = 19;
            // 
            // txtAreaT
            // 
            this.txtAreaT.Enabled = false;
            this.txtAreaT.Location = new System.Drawing.Point(108, 123);
            this.txtAreaT.Name = "txtAreaT";
            this.txtAreaT.Size = new System.Drawing.Size(98, 20);
            this.txtAreaT.TabIndex = 18;
            // 
            // btnPerimetroT
            // 
            this.btnPerimetroT.Location = new System.Drawing.Point(12, 149);
            this.btnPerimetroT.Name = "btnPerimetroT";
            this.btnPerimetroT.Size = new System.Drawing.Size(75, 23);
            this.btnPerimetroT.TabIndex = 17;
            this.btnPerimetroT.Text = "Perimetro";
            this.btnPerimetroT.UseVisualStyleBackColor = true;
            // 
            // btnAreaT
            // 
            this.btnAreaT.Location = new System.Drawing.Point(12, 120);
            this.btnAreaT.Name = "btnAreaT";
            this.btnAreaT.Size = new System.Drawing.Size(75, 23);
            this.btnAreaT.TabIndex = 16;
            this.btnAreaT.Text = "Área";
            this.btnAreaT.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Yf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Xf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Yi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Xi";
            // 
            // txtTYf
            // 
            this.txtTYf.Location = new System.Drawing.Point(310, 47);
            this.txtTYf.Name = "txtTYf";
            this.txtTYf.Size = new System.Drawing.Size(74, 20);
            this.txtTYf.TabIndex = 11;
            // 
            // txtTXf
            // 
            this.txtTXf.Location = new System.Drawing.Point(214, 47);
            this.txtTXf.Name = "txtTXf";
            this.txtTXf.Size = new System.Drawing.Size(74, 20);
            this.txtTXf.TabIndex = 10;
            // 
            // txtTYi
            // 
            this.txtTYi.Location = new System.Drawing.Point(98, 47);
            this.txtTYi.Name = "txtTYi";
            this.txtTYi.Size = new System.Drawing.Size(74, 20);
            this.txtTYi.TabIndex = 9;
            // 
            // txtTXi
            // 
            this.txtTXi.Location = new System.Drawing.Point(9, 47);
            this.txtTXi.Name = "txtTXi";
            this.txtTXi.Size = new System.Drawing.Size(74, 20);
            this.txtTXi.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 603);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDrawAxis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYf;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.TextBox txtYi;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.Button btnDrawRec;
        private System.Windows.Forms.Button btnDrawAxis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDrawTri;
        private System.Windows.Forms.TextBox txtPerimetroT;
        private System.Windows.Forms.TextBox txtAreaT;
        private System.Windows.Forms.Button btnPerimetroT;
        private System.Windows.Forms.Button btnAreaT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTYf;
        private System.Windows.Forms.TextBox txtTXf;
        private System.Windows.Forms.TextBox txtTYi;
        private System.Windows.Forms.TextBox txtTXi;
    }
}

