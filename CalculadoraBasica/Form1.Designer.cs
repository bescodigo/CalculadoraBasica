
namespace CalculadoraBasica
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnDivicion = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnPorciento = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Calculadora = new System.Windows.Forms.ListBox();
            this.btnPunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(-30, 88);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSuma.FlatAppearance.BorderSize = 0;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSuma.Location = new System.Drawing.Point(210, 138);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(31, 86);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.LightSalmon;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIgual.Location = new System.Drawing.Point(149, 230);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(92, 40);
            this.btnIgual.TabIndex = 2;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.Color.LightCoral;
            this.btnUno.FlatAppearance.BorderSize = 0;
            this.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUno.Location = new System.Drawing.Point(11, 184);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(40, 40);
            this.btnUno.TabIndex = 3;
            this.btnUno.Tag = "1";
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.Color.LightCoral;
            this.btnDos.FlatAppearance.BorderSize = 0;
            this.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDos.Location = new System.Drawing.Point(57, 184);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(40, 40);
            this.btnDos.TabIndex = 4;
            this.btnDos.Tag = "2";
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.LightCoral;
            this.btnTres.FlatAppearance.BorderSize = 0;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTres.Location = new System.Drawing.Point(103, 184);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(40, 40);
            this.btnTres.TabIndex = 5;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.Color.LightCoral;
            this.btnCuatro.FlatAppearance.BorderSize = 0;
            this.btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCuatro.Location = new System.Drawing.Point(11, 138);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(40, 40);
            this.btnCuatro.TabIndex = 6;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.LightCoral;
            this.btnCinco.FlatAppearance.BorderSize = 0;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCinco.Location = new System.Drawing.Point(57, 138);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(40, 40);
            this.btnCinco.TabIndex = 7;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.LightCoral;
            this.btnSeis.FlatAppearance.BorderSize = 0;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeis.Location = new System.Drawing.Point(103, 138);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(40, 40);
            this.btnSeis.TabIndex = 8;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.Color.LightCoral;
            this.btnSiete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSiete.FlatAppearance.BorderSize = 0;
            this.btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiete.Location = new System.Drawing.Point(11, 92);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(40, 40);
            this.btnSiete.TabIndex = 9;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.Color.LightCoral;
            this.btnOcho.FlatAppearance.BorderSize = 0;
            this.btnOcho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOcho.Location = new System.Drawing.Point(57, 92);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(40, 40);
            this.btnOcho.TabIndex = 10;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.Color.LightCoral;
            this.btnNueve.FlatAppearance.BorderSize = 0;
            this.btnNueve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNueve.Location = new System.Drawing.Point(103, 92);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(40, 40);
            this.btnNueve.TabIndex = 11;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.Color.LightCoral;
            this.btnCero.FlatAppearance.BorderSize = 0;
            this.btnCero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCero.Location = new System.Drawing.Point(57, 230);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(40, 40);
            this.btnCero.TabIndex = 12;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.LightSalmon;
            this.btnResta.FlatAppearance.BorderSize = 0;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.Color.Firebrick;
            this.btnResta.Location = new System.Drawing.Point(149, 184);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(55, 40);
            this.btnResta.TabIndex = 13;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnDivicion
            // 
            this.btnDivicion.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDivicion.BackgroundImage = global::CalculadoraBasica.Properties.Resources.dividido;
            this.btnDivicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivicion.FlatAppearance.BorderSize = 0;
            this.btnDivicion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivicion.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnDivicion.Location = new System.Drawing.Point(149, 138);
            this.btnDivicion.Name = "btnDivicion";
            this.btnDivicion.Size = new System.Drawing.Size(55, 40);
            this.btnDivicion.TabIndex = 14;
            this.btnDivicion.Text = "/";
            this.btnDivicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDivicion.UseVisualStyleBackColor = false;
            this.btnDivicion.Click += new System.EventHandler(this.btnDivicion_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnMultiplicar.BackgroundImage = global::CalculadoraBasica.Properties.Resources.multiplicar;
            this.btnMultiplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMultiplicar.FlatAppearance.BorderSize = 0;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.ForeColor = System.Drawing.Color.IndianRed;
            this.btnMultiplicar.Location = new System.Drawing.Point(149, 92);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(55, 40);
            this.btnMultiplicar.TabIndex = 15;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnPorciento
            // 
            this.btnPorciento.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPorciento.BackgroundImage = global::CalculadoraBasica.Properties.Resources._500_F_222701456_fCvnZdZ6qHeo08BjZQgx0WhmXrx45AGa;
            this.btnPorciento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPorciento.FlatAppearance.BorderSize = 0;
            this.btnPorciento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPorciento.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorciento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPorciento.Location = new System.Drawing.Point(210, 92);
            this.btnPorciento.Name = "btnPorciento";
            this.btnPorciento.Size = new System.Drawing.Size(31, 40);
            this.btnPorciento.TabIndex = 16;
            this.btnPorciento.Text = "%";
            this.btnPorciento.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPorciento.UseVisualStyleBackColor = false;
            this.btnPorciento.Click += new System.EventHandler(this.btnPorciento_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(103, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Calculadora
            // 
            this.Calculadora.BackColor = System.Drawing.SystemColors.Desktop;
            this.Calculadora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculadora.ForeColor = System.Drawing.Color.LightSalmon;
            this.Calculadora.FormattingEnabled = true;
            this.Calculadora.ItemHeight = 31;
            this.Calculadora.Location = new System.Drawing.Point(11, 21);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(230, 62);
            this.Calculadora.TabIndex = 18;
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.Tomato;
            this.btnPunto.FlatAppearance.BorderSize = 0;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.Color.Lavender;
            this.btnPunto.Location = new System.Drawing.Point(11, 230);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(40, 40);
            this.btnPunto.TabIndex = 19;
            this.btnPunto.Text = ",";
            this.btnPunto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculadoraBasica.Properties.Resources.fondoNegro;
            this.ClientSize = new System.Drawing.Size(252, 293);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.Calculadora);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPorciento);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDivicion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lblResult);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(260, 320);
            this.MinimumSize = new System.Drawing.Size(260, 320);
            this.Name = "Form1";
            this.Text = "Calculadora Basica";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDivicion;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnPorciento;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox Calculadora;
        private System.Windows.Forms.Button btnPunto;
    }
}

