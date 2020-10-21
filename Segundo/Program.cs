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
                + "\n11 - Saque em Banco \n12 - Vet \n13 - Media de produto usando vetor \n14 - Quarto Hotel \n15 - Listas\n16 - Funcionario usando List\n17 - Condição Ternaria\n18 - String Functions");
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
                case 17:
                    CondicaoTernaria();
                    break;
                case 18:
                    FuncoesString();
                    break;

                default:
                    Console.WriteLine("Você escolheu uma opção que não existe ainda");
                    break;
            }

        }

        private static void CondicaoTernaria()
        {
            double preco = double.Parse(Console.ReadLine()) ;
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);
        }

        private static void FuncoesString()
        {
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }

        private static void TempoHora()
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.UtcNow;
            DateTime d3 = DateTime.Today;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Parse("2000-08-15");
            DateTime d5 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d6 = DateTime.Parse("15/08/2000");
            DateTime d7 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            DateTime d8 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
            CultureInfo.InvariantCulture);
            DateTime d9 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(d8);
            Console.WriteLine(d9);

            DateTime d10 = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d10.Date);
            Console.WriteLine("2) Day: " + d10.Day);
            Console.WriteLine("3) DayOfWeek: " + d10.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d10.DayOfYear);
            Console.WriteLine("5) Hour: " + d10.Hour);
            Console.WriteLine("6) Kind: " + d10.Kind);
            Console.WriteLine("7) Millisecond: " + d10.Millisecond);
            Console.WriteLine("8) Minute: " + d10.Minute);
            Console.WriteLine("9) Month: " + d10.Month);
            Console.WriteLine("10) Second: " + d10.Second);
            Console.WriteLine("11) Ticks: " + d10.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d10.TimeOfDay);
            Console.WriteLine("13) Year: " + d10.Year);

            DateTime d11 = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = d11.ToLongDateString();
            string s2 = d11.ToLongTimeString();
            string s3 = d11.ToShortDateString();
            string s4 = d11.ToShortTimeString();
            string s5 = d11.ToString();
            string s6 = d11.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d11.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            DateTime d12 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d13 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + d12);
            Console.WriteLine("d1 Kind: " + d12.Kind);
            Console.WriteLine("d1 to Local: " + d12.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d12.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d13);
            Console.WriteLine("d2 Kind: " + d13.Kind);
            Console.WriteLine("d2 to Local: " + d13.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d13.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d13.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d13.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }

        private static void DuracaoTempo()
        {
            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
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
