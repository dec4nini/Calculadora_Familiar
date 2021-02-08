
namespace Calc_Salario_Familia
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
            this.txtSal_Hor = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtFilhos = new System.Windows.Forms.TextBox();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblSal_Fam = new System.Windows.Forms.Label();
            this.lblVal_Fin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSal_Hor
            // 
            this.txtSal_Hor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSal_Hor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSal_Hor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal_Hor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSal_Hor.Location = new System.Drawing.Point(50, 67);
            this.txtSal_Hor.Name = "txtSal_Hor";
            this.txtSal_Hor.Size = new System.Drawing.Size(140, 26);
            this.txtSal_Hor.TabIndex = 0;
            // 
            // txtHoras
            // 
            this.txtHoras.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.Location = new System.Drawing.Point(50, 123);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(140, 26);
            this.txtHoras.TabIndex = 1;
            // 
            // txtFilhos
            // 
            this.txtFilhos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtFilhos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilhos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilhos.Location = new System.Drawing.Point(50, 179);
            this.txtFilhos.Name = "txtFilhos";
            this.txtFilhos.Size = new System.Drawing.Size(140, 26);
            this.txtFilhos.TabIndex = 2;
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSal.Location = new System.Drawing.Point(47, 48);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(122, 16);
            this.lblSal.TabIndex = 3;
            this.lblSal.Text = "Valor da Hora(Reais):";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoras.Location = new System.Drawing.Point(47, 104);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(136, 16);
            this.lblHoras.TabIndex = 4;
            this.lblHoras.Text = "Jornada Mensal(horas):";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilhos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFilhos.Location = new System.Drawing.Point(47, 160);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(145, 16);
            this.lblFilhos.TabIndex = 5;
            this.lblFilhos.Text = "Filhos (14 anos ou menos):";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.IndianRed;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(94, 224);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 46);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.Location = new System.Drawing.Point(326, 70);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(42, 21);
            this.lblBruto.TabIndex = 7;
            this.lblBruto.Text = "____";
            this.lblBruto.Click += new System.EventHandler(this.lblBruto_Click);
            // 
            // lblSal_Fam
            // 
            this.lblSal_Fam.AutoSize = true;
            this.lblSal_Fam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal_Fam.Location = new System.Drawing.Point(326, 126);
            this.lblSal_Fam.Name = "lblSal_Fam";
            this.lblSal_Fam.Size = new System.Drawing.Size(42, 21);
            this.lblSal_Fam.TabIndex = 8;
            this.lblSal_Fam.Text = "____";
            // 
            // lblVal_Fin
            // 
            this.lblVal_Fin.AutoSize = true;
            this.lblVal_Fin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal_Fin.Location = new System.Drawing.Point(326, 182);
            this.lblVal_Fin.Name = "lblVal_Fin";
            this.lblVal_Fin.Size = new System.Drawing.Size(42, 21);
            this.lblVal_Fin.TabIndex = 9;
            this.lblVal_Fin.Text = "____";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Valor final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Salário família:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salário Bruto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVal_Fin);
            this.Controls.Add(this.lblSal_Fam);
            this.Controls.Add(this.lblBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.txtFilhos);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtSal_Hor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSal_Hor;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtFilhos;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblSal_Fam;
        private System.Windows.Forms.Label lblVal_Fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

