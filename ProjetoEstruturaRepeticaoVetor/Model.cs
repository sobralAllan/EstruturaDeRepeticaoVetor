using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticaoVetor
{
    class Model
    {
        public double[] notas;//Declaração de um vetor
        public int[] vetor;
        public int i;
        private double soma;

        public Model()
        {
            notas = new double[10];
            vetor = new int[5];//Instanciar = Existir 
            i = 0;
            ConsultarSoma = 0;
        }//fim do construtor

        public double ConsultarSoma
        {
            get { return soma; }
            set { this.soma = value; }
        }//fim do get set

        //Guardar 10 notas de 10 alunos diferentes
        public double MediaNotas()
        {
            for(i=0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + "ª Nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    if ((notas[i] < 0) || (notas[i] > 10))
                    {
                        Console.WriteLine("Digite uma nota entre 0 e 10");
                    }//fim da validação
                } while ((notas[i] < 0) || (notas[i] > 10));
                ConsultarSoma += notas[i];
            }//fim do for
            return ConsultarSoma / i;
        }//fim método

        //Ler um vetor de 5 posições e mostrar em ordem inversa
        public void PreencherVetor()
        {
            for(i=0;i < 5; i++)
            {
                Console.Write((i+1) + "ª Posição: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());//Preenchendo o vetor
            }//fim do for
        }//fim do método

        public void MostrarVetor()
        {
            Console.WriteLine("Entrei na mostrar");
            for(i=4; i >= 0; i--)
            {
                Console.WriteLine(i+1 + "ª Posição: " + vetor[i]);
            }//fim do for
        }//fim do mostrar











    }//fim da classe
}//fim do projeto
