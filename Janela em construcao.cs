/*
    Algoritmo : 003
    Objetivo  : Montar uma janela
    Data      : 18/09/2022

*/
using System;

class Proram
{
    static void Main(string[] args)
    {
        Console.Title = "Monta Janelas";

        Console.Clear();

        Console.WriteLine();

        janela(6, 0, 70, 20);



        static void janela(int c1, int l1, int c2, int l2)
        {
            Random cor = new Random();
            int cont1, cont2, cont3;
            string vResp;

            do {

                Console.ForegroundColor = (ConsoleColor)cor.Next(1, 16);

                for (cont1 = c1; cont1 <= c2; cont1++)
                {
                    var linha_sup = 196;
                    var linha_inf = 185;

                    Console.SetCursorPosition(cont1, l1);
                    Console.Write("{0}",(char)linha_sup);

                    Console.SetCursorPosition(cont1, l2);
                    Console.Write("{0}",(char)linha_inf);


                }

               
                for (cont2 = l1; cont2 <= l2; cont2++)
                {
                    var coluna_dir = 253;
                    var coluna_esq = 201;

                    Console.SetCursorPosition(c1, cont2);
                    Console.WriteLine("{0}",(char)coluna_dir);

                    Console.SetCursorPosition(c2, cont2);
                    Console.WriteLine("{0}",(char)coluna_esq);

                }

                for (cont3 = l1; cont3 <= l2; cont3++)
                {
                    var canto_sup_dir = 187;
                    var canto_inf_dir = 198;
                    var canto_sup_esq = 166;
                    var canto_inf_esq = 169;


                    Console.SetCursorPosition(c1, l1);
                    Console.WriteLine("{0}",(char)canto_sup_dir);

                    Console.SetCursorPosition(c1, l2);
                    Console.WriteLine("{0}", (char)canto_inf_dir);

                    Console.SetCursorPosition(c2, l1);
                    Console.WriteLine("{0}", (char)canto_sup_esq);

                    Console.SetCursorPosition(c2, l2);
                    Console.WriteLine("{0}", (char)canto_inf_esq); ;

                }

                Console.Write("\n\nDeseja continuar a ver janelas [S/N]: ");
                vResp = Console.ReadLine();

            } while (vResp == "S" || vResp == "s");


        }
    }
}
