using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividade
{
    class Tree
    {
        public int QtdeNumeros;
        public int QtdeNiveis;
        public int[] Numeros;
        public int Nivel;

        public Tree()
        {
            Console.WriteLine("Digite a quantidade de Niveis");
            QtdeNiveis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de numeros");
            QtdeNumeros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------");

            Numeros = new int[QtdeNiveis];
            Nivel = 0;

            for (int i = 0; i < QtdeNumeros; i++)
            {
                Numeros[Nivel] = i;
                Imprimir();

                if (QtdeNiveis > Nivel + 1)
                    Add();

               
            }
        }

        public void Add()

        {
            for (int i = 1; i <= QtdeNumeros; i++)
            {
                Numeros[Nivel] = i;
                Imprimir();

                if (QtdeNiveis > Nivel + 1)
                    Add();
            }
            Numeros[Nivel] = 0;
            Nivel--;
        }
        public void Imprimir()
        {
            string imprimir = "";
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (i == 0)
                    imprimir += Numeros[i].ToString();
                else
                    if (Numeros[i] !=0)
                    imprimir += $".{ Numeros[i]}";
            }

            Console.WriteLine(imprimir);
        }
    }
}
