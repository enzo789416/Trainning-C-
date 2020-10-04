using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção para executar um programa sendo:\n1 - Cacular Area Triangulo\n2 - Mostrar Pessoa mais velha\n3 - Caculo Produto\n4 - Calculo Retangulo\n5 - Calcular Salario de Funcionario");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    CalculaTriangulo();
                    break;
                case 2:
                    PessoaMaisVelha();
                    break;
                case 3:
                    Produto();
                    break;
                case 4:
                    CalculaRetangulo();
                    break;
                case 5:
                    SalarioFuncionario();
                    break;
                default:
                    Console.WriteLine("Você escolheu uma opção que não existe ainda");
                    break;
            }

        }

        

        static void CalculaTriangulo()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("Triangulo A");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Triangulo B");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalcArea();

            double areaY = y.CalcArea();

            Console.WriteLine(areaX);
            Console.WriteLine(areaY);
        }
        static void PessoaMaisVelha()
        {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine(pessoa1.nome);
            }
            else
            {
                Console.WriteLine(pessoa2.nome);
            }
        }



        private static void Produto()
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            p.nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: {0}", p);
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser adicionados ao estoque: ");
            int x = int.Parse(Console.ReadLine());
            p.AdicionarProduto(x);
            Console.WriteLine("Dados Atualizados: {0}", p);
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser removidos do estoque: ");
            int y = int.Parse(Console.ReadLine());
            p.RemoverProduto(y);
            Console.WriteLine("Dados Atualizados: {0}", p);
        }

        private static void CalculaRetangulo()
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre com largura e altura do retangulo: ");
            r.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(r);
        }

        private static void SalarioFuncionario()
        {
            SalFun sf = new SalFun();
            Console.Write("Nome: ");
            sf.Nome = Console.ReadLine();
            Console.Write("Sálario Bruto: ");
            sf.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            sf.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionario: {0}", sf);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar do o salario: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sf.AumentarSalario(x);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: {0}",sf);
        }
    }
}
