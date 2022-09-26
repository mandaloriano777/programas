/*
    Algoritmo : 003
    Objetivo  : Montar uma janela aleatoria
    Data      : 25/09/2022

*/
using System;

class Proram
{
    static void Main(string[] args)
    {
        Console.Title = "Monta Janelas Aleatória";

        Console.Clear();

        Console.WriteLine();

        //Esse objeto (janAleatória só será utilizado na primeira janela quando abrir o programa)
        Random janAleatoria = new Random();

        //Essas cordenadas serão utilizadas na primeira janela criada quando o programa for aberto
        int col_sup_dir = janAleatoria.Next(5, 60);
        int lin_sup_dir = janAleatoria.Next(3, 20);


        //chamada da primeira janela
        janela(col_sup_dir, lin_sup_dir, 70, 20);



        static void janela(int c1, int l1, int c2, int l2)
        {
            Random cor = new Random();

            //Esse objeto (numAleatório) será responsável por gerar todos os números aleatórios
            Random numAleatorio = new Random();

            //variável (vResp) que será utilizada para controlar a continuação da visualização de novas janelas
            string vResp = "s";

            //variáveis utilizadas nos contadores que controlam as janelas
            int cont1, cont2, cont3;
            
            //loop principal responsável pela continuidade da exibição das janelas
            do {

                Console.ForegroundColor = (ConsoleColor)cor.Next(1, 16);


                    //numeros aleatorios que vao escolher como serão as linha (superior e inferior) da janela
                    int linha_sup =  numAleatorio.Next(1,254);
                    int linha_inf =  numAleatorio.Next(1,254);

                //Desenha a linha superior e inferior da janela com os numeros aleatorios sorteados anteriormente
                for (cont1 = c1; cont1 <= c2; cont1++)
                {
                    
                    Console.SetCursorPosition(cont1, l1);
                    Console.Write("{0}",(char)linha_sup);

                    Console.SetCursorPosition(cont1, l2);
                    Console.Write("{0}",(char)linha_inf);

                }

                //números aleatório que serão utilizados para escolher o que sera desenhado nas colunas (esquerda e direita)
                int coluna_esq = numAleatorio.Next(1, 254);
                int coluna_dir = numAleatorio.Next(1,254);

                //desenhar as duas colunas (esquerda e direita)
                for (cont2 = l1; cont2 <= l2; cont2++)
                {
                    
                    Console.SetCursorPosition(c1, cont2);
                    Console.WriteLine("{0}",(char)coluna_esq);

                    Console.SetCursorPosition(c2, cont2);
                    Console.WriteLine("{0}",(char)coluna_dir);

                }

                //escolha aleatoria do quatro cantos da janela
                int canto_sup_esq = numAleatorio.Next(1,254);
                int canto_inf_esq = numAleatorio.Next(1,254);
                int canto_sup_dir = numAleatorio.Next(1,254);
                int canto_inf_dir = numAleatorio.Next(1,254);

                //colocar os quatro cantos na janela
                for (cont3 = l1; cont3 <= l2; cont3++)
                {

                    Console.SetCursorPosition(c1, l1);
                    Console.WriteLine("{0}",(char)canto_sup_esq);

                    Console.SetCursorPosition(c1, l2);
                    Console.WriteLine("{0}", (char)canto_inf_esq);

                    Console.SetCursorPosition(c2, l1);
                    Console.WriteLine("{0}", (char)canto_sup_dir);

                    Console.SetCursorPosition(c2, l2);
                    Console.WriteLine("{0}", (char)canto_inf_dir); 

                }

                //Depois que montar a janela volta a cor original
                Console.ForegroundColor = ConsoleColor.White;

                //loop secundario responsável pela resposta do usuario só vai continuar se ele digitar (S ou s) 
                //ou (N ou n) se ele quiser sair, do contrário vai dar mensagem de erro
                do
                {
                   

                    Console.Write("\n\nDeseja continuar a ver janelas [S/N]: ");
                    vResp = Console.ReadLine();


                    //não importa o que ele digitou converte mara maiusculo e compara se igual a S
                    if(vResp.ToUpper() == "S")
                    {   //se ele digitou S --> limpa tela , gera uma nova coordenada para janela e sai desse loop voltando para o loop principal
                        Console.Clear();
                        c1 = numAleatorio.Next(5, 60);
                        l1 = numAleatorio.Next(3, 20); 
                        break;
                    }else if(vResp.ToUpper() == "N")  //se ele digita N --> limpa tela e sai do loop secundario
                    {   Console.Clear();
                        break;
                    }
                    else //se ele chegar aqu significa que ele nao digitou ( S nem N) pode ser qualquer  coisa
                    {
                        Console.WriteLine("\n\nResposta inválida !!! Favor digitar [S] Sim ou [N] Não");
                        Console.ReadLine();

                        Console.Clear();
                        //este comando é so para posicionar a pergunta se ele quer sair no mesmo lugar
                        Console.SetCursorPosition(5,21);
                    }

                }while (true);//o único jeito de sair desse loop é digitando (S ou N) qualquer coisa diferente vai dar : "Resposta invalida !!!"

            } while (vResp.ToUpper() == "S");//só vai continuar se ele digitar S

            //só para avisar que o program terminou
            Console.WriteLine("\n\n*** Programa Finalizado ***\n\n");


        }
    }
}
