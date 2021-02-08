using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Salario_Familia
{
    public partial class Form1 : Form
    {
        //Declaração das variáveis utilizadas
        int qtd_filhos;
        int horas_trab;
        double valor_Hora;
        double bruto;
        double sal_fam;
        double salario_Total;
        //Valor mínimo da hora trabalhada, é atualizado anualmente.
        double hora_min = 5; 
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculadora";
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {            
            //Tratamento de erro para valores inválidos.
            try
            {
                valor_Hora = Convert.ToDouble(txtSal_Hor.Text);
                qtd_filhos = Convert.ToInt32(txtFilhos.Text);
                horas_trab = Convert.ToInt32(txtHoras.Text);                
            }
            catch (Exception)
            {
                MessageBox.Show("Valores inseridos são inválidos ou um ou mais campos estão vazios!", "Erro de entrada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }            
            bruto = horas_trab * valor_Hora;
            
            if (horas_trab >220)
            {
                MessageBox.Show("Jornada mensal não pode ultrapassar 220 horas!");
            }
            else if (valor_Hora < hora_min)
            {
                MessageBox.Show("Valor da Hora não pode ser menor do que R$"+ hora_min +"!");
            }
            else if (qtd_filhos<0 || valor_Hora<0 || horas_trab<0)
            {
                MessageBox.Show("Por favor não insira valores negativos!");
            }
            else if (bruto<=788)
            {
                sal_fam = qtd_filhos * 30.50;
            }
            else if (bruto <= 1100)
            {
                sal_fam = qtd_filhos * 18.50;
            }
            else
            {
                sal_fam = qtd_filhos * 11.90;
            }
            salario_Total = bruto + sal_fam;
            lblBruto.Text = "R$" + Convert.ToString(bruto);
            lblSal_Fam.Text = "R$" + Convert.ToString(sal_fam);
            lblVal_Fin.Text = "R$" + Convert.ToString(salario_Total);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblBruto_Click(object sender, EventArgs e)
        {

        }
    }
}
