using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalc
{
    public partial class calculadora : Form


    {
        ModelCalculadora model;

        public calculadora()
        {
            InitializeComponent();               
            model = new ModelCalculadora ();
        }

        private void soma_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text); //Coletando num1.
                double num2 = Convert.ToDouble(textBox2.Text); //Coletando num2.
                double result = model.somar(num1, num2); //Gerando resultado.
                resultado.Text = "" + result; // Escrever resultado em tela.
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os numeros não foram digitados! /n/n" + erro);
            }

        }// fim do botão soma.

        private void subtracao_Click(object sender, EventArgs e)
        {
           try 
           { 
            double num1 = Convert.ToDouble(textBox1.Text); //Coletando num1.
            double num2 = Convert.ToDouble(textBox2.Text); //Coletando num2.
            double result = model.subtracao(num1, num2); //Gerando resultado.
            resultado.Text = "" + result; // Escrever resultado em tela.
           }
            catch (Exception erro)
           {
                MessageBox.Show("Os numeros não foram digitados! /n/n" + erro);
           }


}// fim do botão subtração

private void multiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
            double num1 = Convert.ToDouble(textBox1.Text); //Coletando num1.
            double num2 = Convert.ToDouble(textBox2.Text); //Coletando num2.
            double result = model.multiplicacao(num1, num2); //Gerando resultado.
            resultado.Text = "" + result; // Escrever resultado em tela.
             }
            catch (Exception erro)
            {
                MessageBox.Show("Os numeros não foram digitados! /n/n" + erro);
            }


}// fim do botão multiplicação

private void divisao_Click(object sender, EventArgs e)
        {
            try 
            { 
            double num1 = Convert.ToDouble(textBox1.Text); //Coletando num1.
            double num2 = Convert.ToDouble(textBox2.Text); //Coletando num2.
            double result = model.divisao(num1, num2); //Gerando resultado.
            if (result == -1)
            {
                resultado.Text = "impossivel dividir por 0";
            }
            else
            {
                resultado.Text = "" + result; // Escrever resultado em tela.
            }// fim do if else
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os numeros não foram digitados! /n/n" + erro);
            }


        }// fim do botão divisão

        private void potencia_Click(object sender, EventArgs e)
        {
            try
            { 
            double num1 = Convert.ToDouble(textBox1.Text); //Coletando num1.
            double num2 = Convert.ToDouble(textBox2.Text); //Coletando num2.
            double result = model.Potencia(num1, num2); //Gerando resultado.
            resultado.Text = "" + result; // Escrever resultado em tela.
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os numeros não foram digitados! /n/n" + erro);
            }

}// fim do botão potencia


        private void radiciacao_Click(object sender, EventArgs e)
        {
            try 
            {
            double num1 = Convert.ToDouble(textBox1.Text); //Coletando num1.          
            if (model.Radiciacao (num1)==-1)
            {
                resultado.Text = "Não é possivel encontrar raiz de numero negativo";
            }
            double result = model.Radiciacao(num1); //Gerando resultado.
            resultado.Text = "" + result; // Escrever resultado em tela.

            }
            catch (Exception erro)
            {
                MessageBox.Show("Os numeros não foram digitados! /n/n" + erro);
            }

        }// fim do botão radiciação

        private void NumeroUm_Click(object sender, EventArgs e)
        {

        }// fim do botão do numero um 

        private void NumeroDois_Click(object sender, EventArgs e)
        {

        } // fim do botão numero dois

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } // fim do texto do numero um

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do texto do numero dois

        private void resultado_Click(object sender, EventArgs e)
        {

        }// fim do texto resultado


        private void calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
