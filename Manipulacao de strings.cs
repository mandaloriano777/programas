namespace _018___Manipulacao_de_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Manipulação de Strings";

            string nome = " Reinaldo ", sobrenome = " Souza ", idade = " 46 ", nome_completo = " Reinaldo B. de Souza ";
            string telefone = "(00) 999999-0000", email = "alunoreinaldo1975@gmail.com";
            string frase = "Aprendendo a PROGRAMAR código em CSharp";

            //Concatenação ( + )
            Console.Write("Nome: " + nome + sobrenome + "\nIdade: " + idade);

            //String.Format
            string boasVindas = string.Format("\n\nOla {0}, seja bem vindo ao curso {1} \nVoce realizou o login em : {2} \nO seu saldo é de {3:C2}", nome_completo, frase,DateTime.Now,1250.35);
            Console.WriteLine(boasVindas);

            string dados1 = string.Format("\n\nDADOS 1 - Nome: {0} | Telefone: {1} | Email: {2}", nome,telefone,email);
            Console.WriteLine(dados1);

            //Interpolação $ antes da string
            string dados2 = ($"\n\nDADOS 2 - Nome: {nome} | Telefone: {telefone} | Email: {email}");
            Console.WriteLine(dados2);

            //@ antes da string - preservar caracteres especiais
            string codProd = "\n\nCriando o  \"codigo\" 2007 para o produto\n\n";
            string caminho = @"C:\Windows\System32\WindowsPowerShell";

            Console.WriteLine(codProd);
            Console.WriteLine(caminho);

            //Combinando o $ e o @
            string subdiretorio = "Aplicativo";
            string enderecoCompleto = "\n\n"+$@"C:\Arquivos de Programas\Criando codigo\{subdiretorio}"+"\n\n";

            Console.WriteLine(enderecoCompleto);

            //substring - pega uma parte da string
            Console.Write(frase.Substring(11));

            Console.WriteLine("\n");

            Console.WriteLine(frase.Substring(0, 20));


            int posicaoPrimeiroEspaco = frase.IndexOf(' ');
            Console.WriteLine(posicaoPrimeiroEspaco);


            int posicaoUltimoEspaco = frase.LastIndexOf(' ');
            Console.WriteLine(posicaoUltimoEspaco);

            Console.WriteLine(frase.Substring(0,posicaoPrimeiroEspaco));

            Console.WriteLine(frase.Substring(posicaoPrimeiroEspaco+1, posicaoUltimoEspaco - posicaoPrimeiroEspaco));

            Console.WriteLine(frase.Substring(posicaoUltimoEspaco+1));

            //Replace - substitui parte da string
            Console.WriteLine(frase.Replace(' ', '_'));

            Console.WriteLine(frase.Replace("Aprendendo", "Estudando"));

            Console.WriteLine(frase.Replace("PROGRAMAR em CSharp","como construir lógica de programas em CSharp"));

            //toUper - deixa as letras em maiusculas
            Console.WriteLine(frase.ToUpper());

            //toLower - deixa as letras em minusculas
            Console.WriteLine(frase.ToLower());

            //StartWhith e EndsWhith - inicia com e termina com
            Console.WriteLine($"Frase original: {frase}");

            Console.Write("Digite uma palavra para verificar se ela existe no inicio ou no final da frase : ");
            string palavraDigitada = Console.ReadLine();

            if (frase.ToLower().StartsWith(palavraDigitada.ToLower()))
            {

                Console.WriteLine($"A frase começa com {palavraDigitada}");
            }
            else
            {
                Console.WriteLine($"A frase NÃO começa com a palavra {palavraDigitada}");

            }

            if (frase.ToLower().EndsWith(palavraDigitada.ToLower()))
            {

                Console.WriteLine($"A frase termina com {palavraDigitada}");
            }
            else
            {
                Console.WriteLine($"A frase NÃO termina com a {palavraDigitada}");
            }

            //Contains - verifica se a string contém
            if (frase.ToLower().Contains(palavraDigitada.ToLower()))
            {

                Console.WriteLine($"A frase contém a palavra {palavraDigitada}");
            }
            else
            {
                Console.WriteLine($"A frase NÃO contém a palavra {palavraDigitada}");

            }

            //Trim, TrimStart e TrimEnd
            string frase_marvel = "    Vingadores Guerra Infinita    ";

            Console.WriteLine($"inicio{frase_marvel.TrimStart()}fim");

            Console.WriteLine($"inicio{frase_marvel.TrimEnd()}fim");

            Console.WriteLine($"inicio{frase_marvel.Trim()}fim");

            //Padleft e PadRight
            string numeros = "1250";

            Console.WriteLine("\n\n" + $"|{numeros.PadLeft(10)}|");

            Console.WriteLine("\n\n" + $"|{numeros.PadRight(10)}|");

            Console.WriteLine("\n\n" + $"|{numeros.PadLeft(5,'0')}|");

            Console.WriteLine("\n\n" + $"|{numeros.PadRight(5, '0')}|");


            //String.Join e String.Split
            string emails1 = "email1@criandocodigo.com.br;email2@criandocodigo.com.br;email3@criandocodigo.com.br;email4@criandocodigo.com.br";

            string[] arrayEmails = emails1.Split(';');

            Console.WriteLine($"Posição 1 do array : {arrayEmails[1]}");

            string emails2 = string.Join(" - ", arrayEmails);
            Console.WriteLine($"Emails 1: {emails1}");
            Console.WriteLine($"Emails 2: {emails2}");

            //int contA = 0, contE = 0, contI = 0, contO = 0, contU = 0, contCost = 0;
            //string palavra;

            //Console.Write("Informe a palavra desejada: ");
            //palavra = Convert.ToString(Console.ReadLine()).ToLower();

            //var caracteres = palavra.ToCharArray();

            //for (int i = 0; i < caracteres.Length; i++)
            //{
            //    if (caracteres[i] != ' ')
            //    {

            //        if (caracteres[i] == 'a' || caracteres[i] == 'á' || caracteres[i] == 'ã' || caracteres[i] == 'â' || 
            //             caracteres[i] == 'à')
            //        {

            //            contA++;
            //        }
            //        else if (caracteres[i] == 'e' || caracteres[i] == 'é' || caracteres[i] == 'è' 
            //            || caracteres[i] == 'ê' )
            //        {
            //            contE++;
            //        }

            //        else if (caracteres[i] == 'i' || caracteres[i] == 'í' || caracteres[i] == 'ì' 
            //                || caracteres[i] == 'î')
            //        {

            //            contI++;
            //        }

            //        else if (caracteres[i] == 'o' || caracteres[i] == 'ó' || caracteres[i] == 'ò' 
            //            || caracteres[i] == 'õ' || caracteres[i] == 'ô')
            //        {

            //            contO++;
            //        }

            //        else if (caracteres[i] == 'u' || caracteres[i] == 'ú' || caracteres[i] == 'ù' 
            //            || caracteres[i] == 'û')
            //        {

            //            contU++;
            //        }

            //        else
            //        {
            //            contCost++;
            //        }
            //    }
            //}

            //Console.Write("\n\nO numero de letras a = " + contA);
            //Console.Write("\n\nO numero de letras e = " + contE);
            //Console.Write("\n\nO numero de letras i = " + contI);
            //Console.Write("\n\nO numero de letras o = " + contO);
            //Console.Write("\n\nO numero de letras u = " + contU);
            //Console.Write("\n\nO número de consoantes foi = " + contCost);

            //Console.ReadLine();
        }
    }
}