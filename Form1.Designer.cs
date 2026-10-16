namespace ControleEscolar
{
    partial class FrmMedia
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedia));
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.N1 = new System.Windows.Forms.Label();
            this.N2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Bim1 = new System.Windows.Forms.TextBox();
            this.Bim2 = new System.Windows.Forms.TextBox();
            this.N3 = new System.Windows.Forms.Label();
            this.N4 = new System.Windows.Forms.Label();
            this.M1 = new System.Windows.Forms.Label();
            this.M2 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.M3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(130, 38);
            this.txtN1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtN1.Name = "txtN1";
            this.txtN1.ReadOnly = true;
            this.txtN1.Size = new System.Drawing.Size(100, 26);
            this.txtN1.TabIndex = 0;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtN1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(242, 38);
            this.txtN2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtN2.Name = "txtN2";
            this.txtN2.ReadOnly = true;
            this.txtN2.Size = new System.Drawing.Size(100, 26);
            this.txtN2.TabIndex = 1;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtN2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(134, 38);
            this.txtN3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtN3.Name = "txtN3";
            this.txtN3.ReadOnly = true;
            this.txtN3.Size = new System.Drawing.Size(100, 26);
            this.txtN3.TabIndex = 2;
            this.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(245, 38);
            this.txtN4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtN4.Name = "txtN4";
            this.txtN4.ReadOnly = true;
            this.txtN4.Size = new System.Drawing.Size(100, 26);
            this.txtN4.TabIndex = 3;
            this.txtN4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "primeiro bimestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "segundo bimestre";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(83, 6);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(96, 21);
            this.textBox5.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(5, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(77, 18);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "ID do aluno";
            this.txtID.Click += new System.EventHandler(this.txtID_Click);
            // 
            // N1
            // 
            this.N1.AutoSize = true;
            this.N1.Location = new System.Drawing.Point(129, 10);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(49, 18);
            this.N1.TabIndex = 8;
            this.N1.Text = "Nota 1";
            // 
            // N2
            // 
            this.N2.AutoSize = true;
            this.N2.Location = new System.Drawing.Point(242, 11);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(49, 18);
            this.N2.TabIndex = 9;
            this.N2.Text = "Nota 2";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-1, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(995, 57);
            this.label6.TabIndex = 10;
            this.label6.Text = "*a nota 1 tem peso 4 e nota 2 tem 6*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Bim1
            // 
            this.Bim1.BackColor = System.Drawing.Color.Bisque;
            this.Bim1.Location = new System.Drawing.Point(354, 38);
            this.Bim1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bim1.Name = "Bim1";
            this.Bim1.ReadOnly = true;
            this.Bim1.Size = new System.Drawing.Size(100, 26);
            this.Bim1.TabIndex = 11;
            this.Bim1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Bim2
            // 
            this.Bim2.BackColor = System.Drawing.Color.Bisque;
            this.Bim2.Location = new System.Drawing.Point(356, 38);
            this.Bim2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bim2.Name = "Bim2";
            this.Bim2.ReadOnly = true;
            this.Bim2.Size = new System.Drawing.Size(100, 26);
            this.Bim2.TabIndex = 12;
            this.Bim2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // N3
            // 
            this.N3.AutoSize = true;
            this.N3.Location = new System.Drawing.Point(134, 13);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(49, 18);
            this.N3.TabIndex = 13;
            this.N3.Text = "Nota 1";
            // 
            // N4
            // 
            this.N4.AutoSize = true;
            this.N4.Location = new System.Drawing.Point(248, 11);
            this.N4.Name = "N4";
            this.N4.Size = new System.Drawing.Size(49, 18);
            this.N4.TabIndex = 14;
            this.N4.Text = "Nota 2";
            this.N4.Click += new System.EventHandler(this.label8_Click);
            // 
            // M1
            // 
            this.M1.AutoSize = true;
            this.M1.Location = new System.Drawing.Point(354, 9);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(105, 18);
            this.M1.TabIndex = 15;
            this.M1.Text = "Média bimestre ";
            this.M1.Click += new System.EventHandler(this.label9_Click);
            // 
            // M2
            // 
            this.M2.AutoSize = true;
            this.M2.Location = new System.Drawing.Point(354, 11);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(102, 18);
            this.M2.TabIndex = 16;
            this.M2.Text = "Média bimestre";
            // 
            // txtMedia
            // 
            this.txtMedia.BackColor = System.Drawing.Color.Bisque;
            this.txtMedia.Location = new System.Drawing.Point(12, 81);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(100, 26);
            this.txtMedia.TabIndex = 17;
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // M3
            // 
            this.M3.AutoSize = true;
            this.M3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.M3.Location = new System.Drawing.Point(20, 52);
            this.M3.Name = "M3";
            this.M3.Size = new System.Drawing.Size(75, 18);
            this.M3.TabIndex = 18;
            this.M3.Text = "Média final";
            this.M3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalcular.FlatAppearance.BorderSize = 2;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Image = global::ControleEscolar.Properties.Resources.calculadora;
            this.btnCalcular.Location = new System.Drawing.Point(17, 19);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 30);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DodgerBlue;
            this.label12.CausesValidation = false;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.GhostWhite;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(993, 58);
            this.label12.TabIndex = 20;
            this.label12.Text = "Calculo de Média Escolar";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.txtMedia);
            this.panel1.Controls.Add(this.M3);
            this.panel1.Location = new System.Drawing.Point(699, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 139);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.M2);
            this.panel2.Controls.Add(this.txtN3);
            this.panel2.Controls.Add(this.txtN4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.N4);
            this.panel2.Controls.Add(this.Bim2);
            this.panel2.Controls.Add(this.N3);
            this.panel2.Location = new System.Drawing.Point(182, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 79);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.N1);
            this.panel3.Controls.Add(this.txtN1);
            this.panel3.Controls.Add(this.txtN2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.M1);
            this.panel3.Controls.Add(this.N2);
            this.panel3.Controls.Add(this.Bim1);
            this.panel3.Location = new System.Drawing.Point(183, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 75);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Location = new System.Drawing.Point(195, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 32);
            this.panel4.TabIndex = 24;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // FrmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 486);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cormulário de Calculo de média Escolar";
            this.Load += new System.EventHandler(this.FrmMedia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label N1;
        private System.Windows.Forms.Label N2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Bim1;
        private System.Windows.Forms.TextBox Bim2;
        private System.Windows.Forms.Label N3;
        private System.Windows.Forms.Label N4;
        private System.Windows.Forms.Label M1;
        private System.Windows.Forms.Label M2;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label M3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

