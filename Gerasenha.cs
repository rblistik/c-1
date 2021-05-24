using System;

namespace uc3_ativ2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int dia, mes, ano, gerasenha;
            Console.WriteLine("Digite seu nome");
            nome= Console.ReadLine();
            Console.WriteLine("Digite o seu dia de nascimento :");
            dia = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o seu mes de nascimento :");
            mes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o seu ano de nascimento :");
            ano = Convert.ToInt16(Console.ReadLine());

            gerasenha = 2021 - ano;
            
            if (gerasenha >= 18)
            {
                Console.WriteLine(nome +gerasenha);
                Console.WriteLine("Sua sugestão de senha:"+ nome+gerasenha);
            }
            else
            {
                Console.WriteLine(gerasenha+nome);
                Console.WriteLine("Sua sugestão de senha:" + gerasenha+nome);
            }

        }
    }
}
