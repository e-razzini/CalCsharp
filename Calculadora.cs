using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_Com_Obj
{
    public partial class Calculadora : Form
    {
        double primeiro = 0;
        double segundo = 0;
        string operacao;
        double aux = 0;
        int contador = 0;
       
        public Calculadora()
        {
            InitializeComponent();
        }

        Classes.Operador Cal = new Classes.Operador();

        private void InitializeComponent()
        {
            this.tela = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.somarBtn = new System.Windows.Forms.Button();
            this.numzero = new System.Windows.Forms.Button();
            this.diminuirBtn = new System.Windows.Forms.Button();
            this.multiplicarBtn = new System.Windows.Forms.Button();
            this.dividirBtn = new System.Windows.Forms.Button();
            this.IgualBtn = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.salvo = new System.Windows.Forms.Label();
            this.pontobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tela
            // 
            this.tela.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tela.Location = new System.Drawing.Point(6, 5);
            this.tela.Multiline = true;
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(258, 83);
            this.tela.TabIndex = 0;
            this.tela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num1
            // 
            this.num1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num1.FlatAppearance.BorderSize = 10;
            this.num1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.num1.Location = new System.Drawing.Point(6, 94);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(82, 56);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // num2
            // 
            this.num2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num2.FlatAppearance.BorderSize = 10;
            this.num2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.num2.Location = new System.Drawing.Point(94, 94);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(82, 56);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // num3
            // 
            this.num3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num3.FlatAppearance.BorderSize = 10;
            this.num3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.num3.Location = new System.Drawing.Point(182, 94);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(82, 56);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // num4
            // 
            this.num4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num4.FlatAppearance.BorderSize = 10;
            this.num4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.num4.Location = new System.Drawing.Point(6, 153);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(82, 56);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // num5
            // 
            this.num5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num5.FlatAppearance.BorderSize = 10;
            this.num5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.num5.Location = new System.Drawing.Point(94, 153);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(82, 56);
            this.num5.TabIndex = 5;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // num6
            // 
            this.num6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num6.FlatAppearance.BorderSize = 10;
            this.num6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.num6.Location = new System.Drawing.Point(182, 153);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(82, 56);
            this.num6.TabIndex = 6;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // num7
            // 
            this.num7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num7.FlatAppearance.BorderSize = 10;
            this.num7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.num7.Location = new System.Drawing.Point(8, 215);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(82, 56);
            this.num7.TabIndex = 7;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // num8
            // 
            this.num8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num8.FlatAppearance.BorderSize = 10;
            this.num8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.num8.Location = new System.Drawing.Point(94, 215);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(82, 56);
            this.num8.TabIndex = 8;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // num9
            // 
            this.num9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.num9.FlatAppearance.BorderSize = 10;
            this.num9.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.num9.Location = new System.Drawing.Point(182, 215);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(82, 56);
            this.num9.TabIndex = 9;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // somarBtn
            // 
            this.somarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.somarBtn.FlatAppearance.BorderSize = 10;
            this.somarBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somarBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.somarBtn.Location = new System.Drawing.Point(6, 279);
            this.somarBtn.Name = "somarBtn";
            this.somarBtn.Size = new System.Drawing.Size(82, 56);
            this.somarBtn.TabIndex = 10;
            this.somarBtn.Text = "+";
            this.somarBtn.UseVisualStyleBackColor = true;
            this.somarBtn.Click += new System.EventHandler(this.Somar_Click);
            // 
            // numzero
            // 
            this.numzero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.numzero.FlatAppearance.BorderSize = 10;
            this.numzero.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numzero.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numzero.Location = new System.Drawing.Point(94, 279);
            this.numzero.Name = "numzero";
            this.numzero.Size = new System.Drawing.Size(82, 56);
            this.numzero.TabIndex = 11;
            this.numzero.Text = "0";
            this.numzero.UseVisualStyleBackColor = true;
            this.numzero.Click += new System.EventHandler(this.NumZero_Click);
            // 
            // diminuirBtn
            // 
            this.diminuirBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.diminuirBtn.FlatAppearance.BorderSize = 10;
            this.diminuirBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diminuirBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.diminuirBtn.Location = new System.Drawing.Point(182, 279);
            this.diminuirBtn.Name = "diminuirBtn";
            this.diminuirBtn.Size = new System.Drawing.Size(82, 56);
            this.diminuirBtn.TabIndex = 12;
            this.diminuirBtn.Text = "-";
            this.diminuirBtn.UseVisualStyleBackColor = true;
            this.diminuirBtn.Click += new System.EventHandler(this.Diminuir_Click);
            // 
            // multiplicarBtn
            // 
            this.multiplicarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.multiplicarBtn.FlatAppearance.BorderSize = 10;
            this.multiplicarBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicarBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.multiplicarBtn.Location = new System.Drawing.Point(6, 341);
            this.multiplicarBtn.Name = "multiplicarBtn";
            this.multiplicarBtn.Size = new System.Drawing.Size(82, 56);
            this.multiplicarBtn.TabIndex = 13;
            this.multiplicarBtn.Text = "*";
            this.multiplicarBtn.UseVisualStyleBackColor = true;
            this.multiplicarBtn.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // dividirBtn
            // 
            this.dividirBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dividirBtn.FlatAppearance.BorderSize = 10;
            this.dividirBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividirBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dividirBtn.Location = new System.Drawing.Point(94, 341);
            this.dividirBtn.Name = "dividirBtn";
            this.dividirBtn.Size = new System.Drawing.Size(82, 56);
            this.dividirBtn.TabIndex = 14;
            this.dividirBtn.Text = "/";
            this.dividirBtn.UseVisualStyleBackColor = true;
            this.dividirBtn.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // IgualBtn
            // 
            this.IgualBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.IgualBtn.FlatAppearance.BorderSize = 10;
            this.IgualBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IgualBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IgualBtn.Location = new System.Drawing.Point(182, 341);
            this.IgualBtn.Name = "IgualBtn";
            this.IgualBtn.Size = new System.Drawing.Size(82, 56);
            this.IgualBtn.TabIndex = 15;
            this.IgualBtn.Text = " =";
            this.IgualBtn.UseVisualStyleBackColor = true;
            this.IgualBtn.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_limpar.FlatAppearance.BorderSize = 10;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_limpar.Location = new System.Drawing.Point(6, 403);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(170, 54);
            this.btn_limpar.TabIndex = 16;
            this.btn_limpar.Text = "C";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // salvo
            // 
            this.salvo.AutoSize = true;
            this.salvo.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvo.Location = new System.Drawing.Point(18, 19);
            this.salvo.Name = "salvo";
            this.salvo.Size = new System.Drawing.Size(0, 34);
            this.salvo.TabIndex = 17;
            this.salvo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pontobtn
            // 
            this.pontobtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pontobtn.FlatAppearance.BorderSize = 10;
            this.pontobtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontobtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pontobtn.Location = new System.Drawing.Point(182, 401);
            this.pontobtn.Name = "pontobtn";
            this.pontobtn.Size = new System.Drawing.Size(82, 56);
            this.pontobtn.TabIndex = 18;
            this.pontobtn.Text = " .";
            this.pontobtn.UseVisualStyleBackColor = true;
            this.pontobtn.Click += new System.EventHandler(this.Pontobtn_Click);
            // 
            // Calculadora
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 467);
            this.Controls.Add(this.pontobtn);
            this.Controls.Add(this.salvo);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.IgualBtn);
            this.Controls.Add(this.dividirBtn);
            this.Controls.Add(this.multiplicarBtn);
            this.Controls.Add(this.diminuirBtn);
            this.Controls.Add(this.numzero);
            this.Controls.Add(this.somarBtn);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.tela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculadora";
            this.ShowIcon = false;
            this.Text = "Cal-ogj";
            this.Load += new System.EventHandler(this.Calculado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Num1_Click(object sender, EventArgs e)
        {
            
            tela.Text = tela.Text + "1";
            salvo.Text = salvo.Text + "1";

        }
        private void Num2_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "2";
            salvo.Text = salvo.Text + "2";

        }
        private void Num3_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "3";
            salvo.Text = salvo.Text + "3";

        }
        private void Num4_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "4";
            salvo.Text = salvo.Text + "4";

        }
        private void Num5_Click(object sender, EventArgs e)
        {

            tela.Text = tela.Text + "5";
            salvo.Text = salvo.Text + "5";

        }
        private void Num6_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "6";
            salvo.Text = salvo.Text + "6";

        }
        private void Num7_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "7";
            salvo.Text = salvo.Text + "7";

        }
        private void Num8_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "8";
            salvo.Text = salvo.Text + "8";

        }
        private void Num9_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "9";
            salvo.Text = salvo.Text + "9";

        }
        private void NumZero_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "0";
            salvo.Text = salvo.Text + "0";

        }
        private void Calculado_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        // CHAMADA DOS CALCULOS POO 
    
        private void Somar_Click(object sender, EventArgs e)
        {
            operacao = "+";
            primeiro = double.Parse(tela.Text);
            primeiro = aux;
            tela.Text = tela.Text + "+";
            salvo.Text = salvo.Text + "+";
            tela.Clear();
         }
        private void Dividir_Click(object sender, EventArgs e)
        {
            operacao = "/";
            primeiro = double.Parse(tela.Text);
            tela.Text = tela.Text + "/";
            salvo.Text = salvo.Text + "/";
            primeiro = aux;
            tela.Clear();            
        }
        private void Multiplicar_Click(object sender, EventArgs e)
        {
            operacao = "*";
            primeiro = double.Parse(tela.Text);
            tela.Text = tela.Text + "*";
            salvo.Text = salvo.Text + "*";
            tela.Clear();
        }
        private void Diminuir_Click(object sender, EventArgs e)
        {
            operacao = "-";
            primeiro = double.Parse(tela.Text);
            tela.Text = tela.Text + "-";
            salvo.Text = salvo.Text + "-";
            tela.Clear();
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            primeiro = 0;
            segundo = 0;
            aux = 0;
            tela.Text = tela.Text + "";
            salvo.Text = "";
            tela.Clear();
        }
        private void Pontobtn_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + ".";
            salvo.Text = salvo.Text + ".";
        }

        // CHAMADA DOS CALCULOS PARA GERAR RESULTADO
        public void Resultado_Click(object sender, EventArgs e)
        {

            segundo = double.Parse(tela.Text);            
            salvo.Text = salvo.Text + "=";
            double resul;           
            if (operacao == "+")
            {
                resul = Cal.Somar(primeiro, segundo);
                aux = resul;
                tela.Text = string.Format("{0:F1}", resul);
            }
            else if (operacao == "-")
            {                
                resul = Cal.Subtracao(primeiro, segundo);
                aux = resul;
                tela.Text = string.Format("{0:F1}", resul);
               
                }
            else if (operacao == "*")
            {

                resul = Cal.Multiplicar(primeiro, segundo);
                aux = resul;
                tela.Text = string.Format("{0:F1}", resul);
                
                }
            else if (operacao == "/")
            {
                resul = Cal.Divisao(primeiro, segundo);
                aux = resul;
                tela.Text = string.Format("{0:F1}", resul);
              }
             
            resul = 0;
            }

  }
}
