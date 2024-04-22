using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Operacoes
        {
            Soma,
            Subtrai,
            Multiplica,
            Divide,
            Nenhuma
        }

        static Operacoes ultimaOperacao = Operacoes.Nenhuma;

        private void FazerCalculo(Operacoes ultimaOperacao)
        {
            // double é número real
            List<double> listaDeNumeros = new List<double>();
            switch (ultimaOperacao)
            {
                case Operacoes.Soma:
                    listaDeNumeros = textBoxdisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxdisplay.Text = (listaDeNumeros[0] + listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Subtrai:
                    listaDeNumeros = textBoxdisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxdisplay.Text = (listaDeNumeros[0] - listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Multiplica:
                    listaDeNumeros = textBoxdisplay.Text.Split('x').Select(double.Parse).ToList();
                    textBoxdisplay.Text = (listaDeNumeros[0] * listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Divide:
                    try
                    {
                        listaDeNumeros = textBoxdisplay.Text.Split('/').Select(double.Parse).ToList();
                        textBoxdisplay.Text = (listaDeNumeros[0] / listaDeNumeros[1]).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        textBoxdisplay.Text = "Divisão por zero";
                    }
                    break;
                case Operacoes.Nenhuma:
                    break;
                default:
                    break;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao != Operacoes.Nenhuma)
            {
                FazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = Operacoes.Nenhuma;
  
    }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Text += "0";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Clear();
        }



        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_registro_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxdisplay.Text);
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Subtrai;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxdisplay.Text += (sender as Button).Text;
        }

        private void sinal_Click(object sender, EventArgs e)
        {

        }

        private void virgula_Click(object sender, EventArgs e)
        {

        }

        private void apagar_Click(object sender, EventArgs e)
        {

        }

        private void porcentagem_Click(object sender, EventArgs e)
        {

        }

        private void fracao_Click(object sender, EventArgs e)
        {

        }

        private void elevado_Click(object sender, EventArgs e)
        {

        }

        private void raiz_Click(object sender, EventArgs e)
        {

        }

        private void divisao_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Divide;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxdisplay.Text += (sender as Button).Text;
        }

        private void n7_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Text += "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Text += "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Text += "9";
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {

            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Multiplica;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxdisplay.Text += (sender as Button).Text;
        }

        private void n4_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Text += "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Text += "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Text += "6";
        }

        private void n1_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Text += "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Text += "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            textBoxdisplay.Text += "3";
        }

        private void soma_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Soma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxdisplay.Text += (sender as Button).Text;
        }
    }
}
