using Calculadora.Control;
using System;
using System.Windows.Forms;
namespace Projecto_POObjetos
{
    public partial class FrmCalculadora : Form
    {
        static void Main() { }

        private CCalculadora oControl;
        public FrmCalculadora()
        {
            oControl = new CCalculadora();
            InitializeComponent();
        }
        private bool VerificaControles()
        {
            if (TxtValor1.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo valor 1");
                TxtValor1.Focus();
                return false;
            }
            else if (TxtValor2.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo valor 2");
                TxtValor2.Focus();
                return false;
            }
            Decimal Valor;
            if (Decimal.TryParse(TxtValor1.Text.Trim(), out Valor) == false)
            {
                MessageBox.Show("Preencha o campo valor 1, com um conteúdo numérico");
                TxtValor1.Focus();
                return false;
            }
            else if (Decimal.TryParse(TxtValor2.Text.Trim(), out Valor) == false)
            {
                MessageBox.Show("Preencha o campo valor 2, com um conteúdo numérico");
                TxtValor2.Focus();
                return false;
            }
            return true;
        }
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }
        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                //Decimal Valor1, Valor2;
                //Valor1 = Decimal.Parse(TxtValor1.Text.Trim());
                //Valor1 = Decimal.Parse(TxtValor1.Text.Trim());
                //LblResultado.Text = (Valor1 + Valor2).ToString();

                LblResultado.Text = oControl.Soma(Decimal.Parse(TxtValor1.Text.Trim()), Decimal.Parse(TxtValor2.Text.Trim())).ToString();
            }
        }
        private void BtnSubtrai_Click(object sender, EventArgs e)
        {
            LblResultado.Text = oControl.Subtrai(Decimal.Parse(TxtValor1.Text.Trim()), Decimal.Parse(TxtValor2.Text.Trim())).ToString();
        }
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                LblResultado.Text = oControl.Divide(Decimal.Parse(TxtValor1.Text.Trim()), Decimal.Parse(TxtValor2.Text.Trim())).ToString();
            }
            catch (Exception ex)
            {
                LblResultado.Text = "Não é possível dividir por zero.";
            }
        }
        private void BtnMultiplica_Click(object sender, EventArgs e)
        {
            LblResultado.Text = oControl.Mulitiplica(Decimal.Parse(TxtValor1.Text.Trim()), Decimal.Parse(TxtValor2.Text.Trim())).ToString();
        }
    }
}
