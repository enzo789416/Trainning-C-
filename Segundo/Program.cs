using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção para executar um programa sendo:\n1 - Cacular Area Triangulo\n2 - Mostrar Pessoa mais velha\n" +
                "3 - Caculo Produto\n4 - Calculo Retangulo\n5 - Calcular Salario de Funcionario\n6 - Calculadora Circulo\n7 - Calculo de produto usando construtor" +
                "\n8 - Calcular Produto usando sobrecarga\n9 - Calcular produto usando encapsulamento (get/set) padrao\n10 - Calcular Produto usando properties"
                + "\n11 - Saque em Banco \n12 - Vet \n13 - Media de produto usando vetor \n14 - Quarto Hotel \n15 - Listas\n16 - Funcionario usando List");
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
                case 6:
                    Calc();
                    break;
                case 7:
                    Produto2();
                    break;
                case 8:
                    Produto3();
                    break;
                case 9:
                    Produto4();
                    break;
                case 10:
                    Produto5();
                    break;
                case 11:
                    Banco();
                    break;
                case 12:
                    Vet();
                    break;
                case 13:
                    Prod6();
                    break;
                case 14:
                    Hotel();
                    break;
                case 15:
                    List();
                    break;
                case 16:
                    Funcionario();
                    break;
                default:
                    Console.WriteLine("Você escolheu uma opção que não existe ainda");
                    break;
            }

        }

        private static void Funcionario()
        {
            Console.WriteLine("Quantos Funcionarios você deseja registrar?");
            int n = int.Parse(Console.ReadLine());
            Funcionario fun;
            List<Funcionario> f = new List<Funcionario>();

            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine("Funcionario #"+i+":");
                Console.Write("id: "); 
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                f.Add(fun = new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Informe o ID do funcionario: ");

            
        }

        private static void List()
        {
            List<string> list = new List<string>();

            list.Add("amor");
            list.Add("barba");
            list.Add("cavalo");
            list.Add("dado");
            list.Insert(0, "velho");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");

            Console.WriteLine("List Count " + list.Count);
            string s = list.Find(x => x[0] == 'd');
            Console.WriteLine("Last 'd': " + s);
            
            int posi = list.FindIndex(x => x[0] == 'a');
            Console.WriteLine("First position 'A': " + posi);
            
            int posi2 = list.FindLastIndex(x => x[0] == 'a');
            Console.WriteLine("Last position 'A': " + posi);

            Console.WriteLine("----------------------------");

            List<string> list2 = list.FindAll(x => x.Length > 5);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            list.Remove("barba");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            list.RemoveAll(x=>x[0] == 'c');
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void Hotel()
        {
            Hotel[] h = new Hotel[9];
            Console.Write("Quanto quartos vao ser alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine("Quarto #"+i+":");
                Console.Write("Nome do Hospede: ");
                string nome = Console.ReadLine();
                Console.Write("Email do Hospede: ");
                string email = Console.ReadLine();
                Console.Write("Qual quarto quer? ");
                int quarto = int.Parse(Console.ReadLine());
                h[quarto] = new Hotel { NomeHospede = nome, EmailHospede = email, QuartoHotel = quarto };
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < 9; i++)
            {
                if (h[i] != null)
                {
                    Console.WriteLine(h[i].QuartoHotel+": "+h[i].NomeHospede+", "+h[i].EmailHospede);
                }
            }
        }
        private static void Prod6()
        {
            int n = int.Parse(Console.ReadLine());

            Produto6[] vet = new Produto6[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
                vet[i] = new Produto6 { Nome = nome, Preco = preco };
            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma+=vet[i].Preco;
            }
            Console.WriteLine("Preço é: " + soma/n);
        }

       private static void Vet()
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                vet[i] = i;
                soma += vet[i];
            }

            Console.WriteLine(soma);


        }
        private static void Banco()
        {
            Banco b;
            Console.Write("Entre com o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Havera deposito inicial? (s=1/n=0)");
            int resp = int.Parse(Console.ReadLine());
            double saldoInicial;
            if (resp == 1)
            {
                Console.Write("Entre com valor de deposito Inicial:");
                saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                b = new Banco(numConta, nomeTitular, saldoInicial);
            }
            else
            {
                b = new Banco(numConta, nomeTitular);
            }
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta: \n{0}",b);
            Console.WriteLine();
            Console.Write("Entre com valor para deposito: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Deposito(x);
            Console.WriteLine("Dados da conta atualizados: \n{0}",b);
            Console.WriteLine();
            Console.Write("Entre com valor para saque: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Saque(y);
            Console.WriteLine("Dados da conta atualizados: \n{0}",b);

        }
        private static void Calc()
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("A circunferencia é: {0}\n",circ);
            Console.WriteLine("O volume é: {0}\n", vol);
        }

        private static void CalculaTriangulo()
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
        private static void PessoaMaisVelha()
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

        private static void Produto2()
        {
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto2 p2 = new Produto2(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: {0}", p2);
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser adicionados ao estoque: ");
            int x = int.Parse(Console.ReadLine());
            p2.AdicionarProduto(x);
            Console.WriteLine("Dados Atualizados: {0}", p2);
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser removidos do estoque: ");
            int y = int.Parse(Console.ReadLine());
            p2.RemoverProduto(y);
            Console.WriteLine("Dados Atualizados: {0}", p2);
        }

        private static void Produto3()
        {
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            Produto3 p3 = new Produto3(nome, preco);

            Console.WriteLine("Dados do produto: {0}", p3);
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser adicionados ao estoque: ");
            int x = int.Parse(Console.ReadLine());
            p3.AdicionarProduto(x);
            Console.WriteLine("Dados Atualizados: {0}", p3);
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser removidos do estoque: ");
            int y = int.Parse(Console.ReadLine());
            p3.RemoverProduto(y);
            Console.WriteLine("Dados Atualizados: {0}", p3);
        }

        private static void Produto4()
        {
            Produto4 p4 = new Produto4();
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            p4.SetNome(nome);
            Console.WriteLine(p4.GetNome()); 
        }

        private static void Produto5()
        {
            Produto5 p5 = new Produto5();
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            p5.Nome = nome;
            Console.WriteLine("Preço: ");
            p5.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine(p5.Nome + p5.Preco);
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
