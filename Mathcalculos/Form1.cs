using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathcalculos
{
    public partial class Form1 : Form
    {

        public string resultadoTemp { get; set; }

        int qtdItens = 0;
        public int QtdItens { get => qtdItens; set => qtdItens = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private string  RetornaSinalComboSinais(string valor)
        {
            switch (valor)
            {
                case "Soma": return "+";
                case "Subtração": return "-";
                case "Multiplicação": return "*";
                case "Divisão": return "/";
                default:
                    break;
            }
            return "";
        }

        private void cboSinais_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFormula.Text = string.Concat(lblFormula.Text, " ", RetornaSinalComboSinais(cboSinais.SelectedItem.ToString()));
        }

        private void txtValorImput_HideSelectionChanged(object sender, EventArgs e)
        {
            QtdItens++;

            if (string.IsNullOrEmpty(txtValorImput.Text))
                return;
            if (string.IsNullOrEmpty(lblFormula.Text))
            {
                lblFormula.Text = sender.ToString().Split(',')[1].Split(':')[1].Trim().ToString();
            } else
            {
                lblFormula.Text = string.Concat(lblFormula.Text, " ", sender.ToString().Split(',')[1].Split(':')[1].Trim().ToString());
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal resultadoDivisao = 0;
            decimal resultadoMultiplicação = 0;
            decimal resultadoSoma = 0;
            decimal resultadoSubtracao = 0;

            // todo: CALCULO DIVISAO
            if (lblFormula.Text.Contains("/"))
            {
                resultadoDivisao = retornaCalculoDeUmaDivisao(lblFormula.Text);
            }
            // todo: CALCULO MULTIPLICACAO
            if (lblFormula.Text.Contains("*"))
            {
                if (resultadoDivisao > 0)
                    resultadoMultiplicação = retornaCalculoDeUmaMultiplicacao(resultadoDivisao, lblFormula.Text);
                else
                    resultadoMultiplicação = retornaCalculoDeUmaMultiplicacao(0, lblFormula.Text);
            }
            // todo: CALCULO Soma
            if (lblFormula.Text.Contains("+"))
            {
                if (resultadoMultiplicação > 0)
                    resultadoSoma = retornaCalculoDeUmaSoma(resultadoMultiplicação, lblFormula.Text);
                else
                    resultadoSoma = retornaCalculoDeUmaSoma(0, lblFormula.Text);

            }
            // todo: CALCULO SUBTRACAO
            if (lblFormula.Text.Contains("-"))
            {
                if (resultadoSoma > 0)
                    resultadoSubtracao = retornaCalculoDeUmaSubitracao(resultadoSoma, lblFormula.Text);
                else
                    resultadoSubtracao = retornaCalculoDeUmaSubitracao(0, lblFormula.Text);
            }

            if (resultadoDivisao > 0 && resultadoMultiplicação > 0 && resultadoSoma > 0 && resultadoSubtracao > 0)
                txtResultado.Text = resultadoSubtracao.ToString();

        }

        private decimal retornaCalculoDeUmaDivisao(string valor)
        {
            //TODO: Fazer calculo
            /*
             * Achar onde esta a /
             * Pegar valor antes
             * Pegar Valor depois
             * Calcular
             */
            string[] posicalBarra = valor.Split(' ');
            for (int i = 0; i < posicalBarra.Length; i++)
            {
                if (posicalBarra[i].Contains("/"))
                {
                    return decimal.Parse(posicalBarra[i - 1]) / decimal.Parse(posicalBarra[i + 1]);
                }
            }

            return 0;
        }
        private decimal retornaCalculoDeUmaMultiplicacao(decimal valorEsquerda, string valor)
        {
            //TODO: Fazer calculo
            /*
             * Achar onde esta a /
             * Pegar valor antes
             * Pegar Valor depois
             * Calcular
             */
            string[] posicalBarra = valor.Split(' ');
            for (int i = 0; i < posicalBarra.Length; i++)
            {
                if (posicalBarra[i].Contains("*"))
                {
                    return valorEsquerda > 0 ? valorEsquerda * decimal.Parse(posicalBarra[i + 1]) : decimal.Parse(posicalBarra[i - 1]) * decimal.Parse(posicalBarra[i + 1]);
                }
            }

            return 0;
        }
        private decimal retornaCalculoDeUmaSoma(decimal valorEsquerda, string valor)
        {
            //TODO: Fazer calculo
            /*
             * Achar onde esta a /
             * Pegar valor antes
             * Pegar Valor depois
             * Calcular
             */
            string[] posicalBarra = valor.Split(' ');
            for (int i = 0; i < posicalBarra.Length; i++)
            {
                if (posicalBarra[i].Contains("+"))
                {
                    return valorEsquerda > 0 ? valorEsquerda + decimal.Parse(posicalBarra[i + 1]) : decimal.Parse(posicalBarra[i - 1]) + decimal.Parse(posicalBarra[i + 1]);
                }
            }

            return 0;
        }
        private decimal retornaCalculoDeUmaSubitracao(decimal valorEsquerda, string valor)
        {
            //TODO: Fazer calculo
            /*
             * Achar onde esta a /
             * Pegar valor antes
             * Pegar Valor depois
             * Calcular
             */
            string[] posicalBarra = valor.Split(' ');
            for (int i = 0; i < posicalBarra.Length; i++)
            {
                if (posicalBarra[i].Contains("-"))
                {
                    return valorEsquerda > 0 ? valorEsquerda - decimal.Parse(posicalBarra[i + 1]) : decimal.Parse(posicalBarra[i - 1]) - decimal.Parse(posicalBarra[i + 1]);
                }
            }

            return 0;
        }
    }
}
