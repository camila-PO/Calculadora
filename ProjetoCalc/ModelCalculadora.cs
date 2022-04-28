using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalc
{
    class ModelCalculadora
    {
        public ModelCalculadora()
        {

           

        }//fim método construtor modelCalculadora

        public double somar(double num1, double num2)
        {
            return num1 + num2;
        } // fim do somar 


        public double subtracao (double num1, double num2)
        {
            return num1 - num2;

        }// fim do subtrair 


        public double multiplicacao (double num1, double num2)
        {
            return num1 * num2;

        } //fim do multilicar 


        public double divisao (double num1, double num2)
        {
            if (num2 <= 0)               

            {
                return -1;

            } 
            else
            { 

                return num1 / num2;

            }

        } // fim do divisao

        public double Potencia(double bas, double expoente)
        {
            if (expoente == 1)
            {
                return bas;
            }
            else if (expoente == 0)
            {
                return 1;
            }
            else
            {
                return Math.Pow(bas, expoente);
            }
        }//Fim Potência.
        public double Radiciacao(double n1)
        {
            if (n1 <= 0)
            {
                return -1;
            }
            else
            {
                return Math.Sqrt(n1);
            }
        }// Fim Raiz.






    }//fim da clase
}//fim do projeto
