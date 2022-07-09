using System;

namespace csharp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sexo = 0, idade = 0;
            int soma_age = 0, soma_age_homem = 0, soma_age_mulher = 0, soma_age_outros = 0;
            int quant_homem = 0, quant_mulher = 0, quant_outros = 0;
            double somaAlt_mulher = 0, somaAlt_homem = 0, somaAlt_outros = 0;
            double idade_bet18e32 = 0, percentual = 0, altura = 0;

            Console.WriteLine("---- Início do programa ----");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----- Bem vindo ao Sistema de Coleta de Dados -----");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Digite o número que representa o seu sexo: ");
                Console.WriteLine("[0]- Feminino || [1]- Masculino || [2]- Outros Gêneros");
                sexo = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Digite a sua altura (sem pontos ou vírgulas): ");
                altura = double.Parse(Console.ReadLine());
                Console.WriteLine();

                soma_age = soma_age + idade;

                if (sexo == 2)
                {
                    quant_outros++;

                    soma_age_outros = soma_age_outros + idade;
                    somaAlt_outros = somaAlt_outros + altura;
                }


                if (sexo == 1)
                {
                    quant_homem++;

                    soma_age_homem = soma_age_homem + idade;
                    somaAlt_homem = somaAlt_homem + altura;
                }

                if (sexo == 0)
                {
                    quant_mulher++;

                    soma_age_mulher = soma_age_mulher + idade;
                    somaAlt_mulher = somaAlt_mulher + altura;
                }

                if (idade >= 18 && idade <= 35)
                {
                    idade_bet18e32++;
                }

                percentual = idade_bet18e32 / 10;

            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("---------- Compilação dos dados obitidos ----------");
            Console.WriteLine();
            Console.WriteLine("==> A média da idade da população é de: {0} anos", soma_age / 10);
            Console.WriteLine("==> A média de altura das mulheres é de: {0} centímetros", somaAlt_mulher /
            quant_mulher);
            Console.WriteLine("==> A média de altura dos homens é de: {0} centímetros", somaAlt_homem /
            quant_homem);
            Console.WriteLine("==> A média de altura dos outros gêneros é de: {0} centímetros", somaAlt_outros /
            quant_outros);
            Console.WriteLine("==> A média da idade dos homens é de: " + soma_age_homem /
            quant_homem);
            Console.WriteLine("==> A média da idade das mulheres é de: " + soma_age_mulher /
            quant_mulher);
            Console.WriteLine("==> A média da idade dos outros gêneros é de: " + soma_age_outros /
            quant_outros);
            Console.WriteLine("==> O percentual de pessoas com idade entre 18 e 32 anos é de: {0} %",
            percentual * 100);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("---- Fim do programa ----");
            Console.ReadKey();

        }
    }
}
