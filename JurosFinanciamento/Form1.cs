using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurosFinanciamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            // Verifica se todos os espaços estão preenchidos, evitando que o programa feche caso não haja algum espaço preenchido.
            if(string.IsNullOrWhiteSpace(txtLoanValue.Text) || string.IsNullOrWhiteSpace(txtAnnualInterestRate.Text) || string.IsNullOrWhiteSpace(txtNumberOfInstallments.Text))
            {
                MessageBox.Show("Por favor, insira valores em todas as caixas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double taxaDeJurosMensal = (Convert.ToDouble(txtAnnualInterestRate.Text) / 100) / 12;

            double valorDaParcela = Convert.ToDouble(txtLoanValue.Text) * (taxaDeJurosMensal/ (1 - Math.Pow(1 +
                taxaDeJurosMensal, -Convert.ToDouble(txtNumberOfInstallments.Text))));

            double totalPago = valorDaParcela * Convert.ToDouble(txtNumberOfInstallments.Text);

            double totalDeJuros = totalPago - Convert.ToDouble(txtLoanValue.Text);

            lblInstallmentlValue.Text = "Valor da parcela: " + valorDaParcela.ToString("N2") + " R$";
            lblTotalnterestValue.Text = "Total em juros: " + totalDeJuros.ToString("N2") + " R$";
            lblTotalValue.Text = "Total pago: " + totalPago.ToString("N2") + " R$";

            txtLoanValue.Clear();
            txtAnnualInterestRate.Clear();
            txtNumberOfInstallments.Clear();

        }
    }
}