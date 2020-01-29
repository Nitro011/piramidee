using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {



            Random randon = new Random();

            Console.WriteLine("Escriba la cantidad de numeros");
            int cantidad = int.Parse(System.Console.ReadLine());
            string nombre = "Laura&George";
           
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            //Declaracion de variables
            int canti = nombre.Length;
            int contadorArr = 0;
            int Contador = cantidad + 1;
            int contador2 = 1;
            bool Indicador = true;
            bool Indicador2 = true;
            //
            for (int i = 0; i < cantidad; i++)
            {

                if (contador2 == i + 1 && Indicador2)
                {
                    for (int d = 0; d < Contador; d++)
                    {
                        Console.Write(" ");
                    }

                    Indicador2 = false;
                    Contador--;

                }
                else
                {
                    for (int d = 0; d < Contador; d++)
                    {
                        Console.Write(" ");
                    }
                }

                if (Indicador)
                {


                    var m = nombre.ToCharArray();
                    System.Console.WriteLine(m[contadorArr]);
                    contadorArr++;
                    Indicador = false;
                }

                else
                {

                    Contador--;

                    if (contador2 % 2 != 0)
                    {
                        contador2 += 1;
                    }
                    for (int a = 1; a <= contador2; a++)
                    {

                        if (contadorArr<canti)
                        {
                            var d = nombre.ToCharArray();
                            System.Console.Write(d[contadorArr]);
                            contadorArr++;
                        }
                        else
                        {
                            contadorArr = 0;
                        }
                       
                    }
                    contador2++;
                    if (contadorArr < canti)
                    {
                        var p = nombre.ToCharArray();
                        System.Console.WriteLine(p[contadorArr]);
                        contadorArr++;
                    }
                    else
                    {
                        contadorArr = 0;
                    }
                 
                }



            }


            Console.ReadKey();
        }
    }
}
