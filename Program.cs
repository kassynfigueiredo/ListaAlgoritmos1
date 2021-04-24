
using System;
using System.Threading;

namespace ListaAlgoritmos1
{
    class Program
    {
        static void Main(string[] args)
        {
            DivisaoPorZero();
        }

        public static void NumeroSucessor()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite um número: ");
                string numero = Console.ReadLine();
                int num = int.Parse(numero);
                num += 1;
                Console.WriteLine($"O número sucessor é: {num}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Valor digitado é nulo ou de formato inválido!");
                Thread.Sleep(1000);
                NumeroSucessor();
            }
            
        }

        public static void MediaFinal()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite a primeira nota: ");
                string nota1 = Console.ReadLine();
                Console.Write("Digite a segunda nota: ");
                string nota2 = Console.ReadLine();
                Console.Write("Digite a terceira nota: ");
                string nota3 = Console.ReadLine();

                double doubleNota1 = double.Parse(nota1);
                double doubleNota2 = double.Parse(nota2);
                double doubleNota3 = double.Parse(nota3);

                double media = (doubleNota1 + doubleNota2 + doubleNota3) / 3;

                string situacao = "";

                if (media < 5)
                {
                    situacao = "reprovado";
                }
                else if (media >= 5 && media < 7)
                {
                    situacao = "recuperação";
                }
                else if (media >= 7)
                {
                    situacao = "aprovado";
                }

                Console.WriteLine($"As notas são: {doubleNota1}, {doubleNota2} e {doubleNota3}");
                Console.WriteLine($"A média entre as notas é {media}");
                Console.WriteLine($"Situação acadêmica: {situacao}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                MediaFinal();
            }                                   
        }

        public static void DinheiroFumante()
        {
            try
            {
                Console.Clear();
                Console.Write("Número de anos fumando: ");
                string anos = Console.ReadLine();
                Console.Write("Nº de cigarros por dia: ");
                string cigarros = Console.ReadLine();
                Console.Write("Preço da carteira: ");
                string preco = Console.ReadLine();

                int anosFumando = int.Parse(anos);
                int cigarrosDia = int.Parse(cigarros);
                double precoCarteira = double.Parse(preco);

                int dias = anosFumando * 365;
                int cigarrosTotais = dias * cigarrosDia;
                double carteirasCompradas = cigarrosTotais / 20.0;
                double valorGasto = carteirasCompradas * precoCarteira;

                Console.WriteLine($"Você comprou {carteirasCompradas} carteiras e gastou R$ {valorGasto}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                DinheiroFumante();
            }
            
        }

        public static void NumerosInteiros()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite o primeiro número: ");
                string num1 = Console.ReadLine();
                Console.Write("Digite o segundo número: ");
                string num2 = Console.ReadLine();

                int numero1 = int.Parse(num1);
                int numero2 = int.Parse(num2);

                int quociente = numero1 / numero2;
                int resto = numero1 % numero2;

                Console.WriteLine($"Os números digitados foram {numero1} e {numero2}");
                Console.WriteLine($"O quociente entre eles é {quociente} e o resto é {resto}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                NumerosInteiros();
            }
            
        }
        public static void AreaEVolumeCilindro()
        {
            try
            {
                Console.Clear();
                const double PI = 3.1415926535897931;

                Console.Write("Informe o raio da base: ");
                string valorBase = Console.ReadLine();
                Console.Write("Informe a altura: ");
                string valorAltura = Console.ReadLine();

                double raio = double.Parse(valorBase);
                double altura = double.Parse(valorAltura);

                double areaTotal = 2 * (PI * raio * raio) + 2 * (PI * raio * altura);
                double volume = PI * raio * raio * altura;

                Console.WriteLine($"A área total de um cilindro é {areaTotal} e o volume é {volume}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                AreaEVolumeCilindro();
            }         
        }

        public static void NumerosInteirosV2()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite o primeiro número: ");
                string num1 = Console.ReadLine();
                Console.Write("Digite o segundo número: ");
                string num2 = Console.ReadLine();

                int numero1 = int.Parse(num1);
                int numero2 = int.Parse(num2);

                int quociente = numero1 / numero2;
                int soma = numero1 + numero2;
                int produto = numero1 * numero2;

                Console.WriteLine($"O números foram {numero1} e {numero2}");
                Console.WriteLine($"A soma entre eles foi {soma}");
                Console.WriteLine($"O produto entre eles foi {produto}");
                Console.WriteLine($"O quociente soma entre eles foi {quociente}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                NumerosInteirosV2();
            }
            
        }

        public static void PrimeiroMaior()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite o primeiro valor: ");
                string num1 = Console.ReadLine();
                Console.Write("Digite o segundo valor: ");
                string num2 = Console.ReadLine();
                Console.Write("Digite o terceiro valor: ");
                string num3 = Console.ReadLine();

                double numero1 = double.Parse(num1);
                double numero2 = double.Parse(num2);
                double numero3 = double.Parse(num3);

                double soma = numero2 + numero3;

                Console.WriteLine($"O valores digitados foram {numero1},{numero2} e {numero3}");
                if (numero1 > soma)
                    Console.WriteLine("É maior que os dois últimos");
                else
                    Console.WriteLine("É menor");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                PrimeiroMaior();
            }           
        }

        public static void ProgressaoAritmetica()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite o primeiro termo: ");
                string primeiroTermo = Console.ReadLine();
                Console.Write("Digite o último termo: ");
                string ultimoTermo = Console.ReadLine();
                Console.Write("Digite a razão: ");
                string razao = Console.ReadLine();

                double a1 = double.Parse(primeiroTermo);
                double an = double.Parse(ultimoTermo);
                double r = double.Parse(razao);

                double numeroDeTermos = ((an - a1) / r) + 1;

                double somaDosTermos = ((a1 + an) * numeroDeTermos) / 2;

                Console.WriteLine($"A progressão começa com o valor {a1} e termina com {an}");
                Console.WriteLine($"A progressão possui {numeroDeTermos} termos.");
                Console.WriteLine($"A soma dos termos da P.A é {somaDosTermos}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                ProgressaoAritmetica();
            }
            
        }

        public static void MaiorNumero()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite o primeiro número: ");
                string num1 = Console.ReadLine();
                Console.Write("Digite o segundo número: ");
                string num2 = Console.ReadLine();

                int numero1 = int.Parse(num1);
                int numero2 = int.Parse(num2);

                Console.WriteLine($"Os números digitados foram {numero1} e {numero2}");

                if (numero1 == numero2)
                    Console.WriteLine($"{numero1} = {numero2}");
                else
                {
                    if (numero2 > numero1)
                        Console.WriteLine($"O maior valor é {numero2}");
                    else if (numero1 > numero2)
                        Console.WriteLine($"O maior valor é {numero1}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                MaiorNumero();
            }
            
        }

        public static void PrecoCarro()
        {
            try
            {
                Console.Clear();
                Console.Write("Custo de produção do carro: ");
                string custo = Console.ReadLine();

                double custoCarro = double.Parse(custo);
                double imposto = custoCarro * 0.45;
                double lucro = custoCarro * 0.12;
                double valorFinal = custoCarro + imposto + lucro;

                Console.Write($"O preço do carro é {valorFinal}");
                Console.Write($", sendo {imposto} de imposto e {lucro} de lucro.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                PrecoCarro();
            }
            
        }

        public static void Multa()
        {
            try
            {
                Console.Clear();
                Console.Write("Velocidade máxima permitida(km/h): ");
                string vel = Console.ReadLine();
                Console.Write("Velocidade do motorista(km/h): ");
                string mot = Console.ReadLine();

                int velocidadeMaxima = int.Parse(vel);
                int velocidadeMotorista = int.Parse(mot);

                int multa = 0;
                int velocidadeUltrapassada = velocidadeMotorista - velocidadeMaxima;

                if (velocidadeUltrapassada <= 0)
                {
                    Console.WriteLine("Nenhuma multa aplicada.");
                }
                else
                {
                    if (velocidadeUltrapassada <= 10)
                        multa = 50;
                    else if (velocidadeUltrapassada >= 11 && velocidadeUltrapassada <= 30)
                        multa = 100;
                    else if (velocidadeUltrapassada > 30)
                        multa = 200;
                    Console.WriteLine($"Você recebeu uma multa de R$ {multa} reais.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                Multa();
            }
            
        }

        public static void Latao()
        {
            try
            {
                Console.Clear();
                Console.Write("Quantidade de latão(kg): ");
                string latao = Console.ReadLine();

                double quantLatao = double.Parse(latao);
                double quantCobre = quantLatao * 0.70;
                double quantZinco = quantLatao * 0.30;

                quantLatao = quantCobre + quantZinco;
                Console.Write($"Para obter {quantLatao} kgs de latão precisa de ");
                Console.Write($"{quantZinco} kgs de zinco e {quantCobre} kgs de cobre.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                Latao();
            }
            
        }

        public static void DivisaoPorZero()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite o primeiro valor: ");
                string num1 = Console.ReadLine();
                Console.Write("Digite o segundo valor: ");
                string num2 = Console.ReadLine();

                double valor1 = double.Parse(num1);
                double valor2 = double.Parse(num2);
                if (valor2 != 0)
                {
                    double quociente = valor1 / valor2;
                    Console.WriteLine(quociente);
                }
                else
                {
                    Console.WriteLine("Não é possível dividir um número por 0");
                    Thread.Sleep(1000);
                    DivisaoPorZero();
                }               
            }                       
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                DivisaoPorZero();
            }
        }

        public static void ValorMaior()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite o primeiro valor: ");
                string num1 = Console.ReadLine();
                Console.Write("Digite o segundo valor: ");
                string num2 = Console.ReadLine();
                Console.Write("Digite o terceiro valor: ");
                string num3 = Console.ReadLine();

                double valor1 = double.Parse(num1);
                double valor2 = double.Parse(num2);
                double valor3 = double.Parse(num3);
                double maior = 0;

                if (valor1 > valor2 && valor1 > valor3)
                    maior = valor1;
                if (valor2 > valor1 && valor2 > valor3)
                    maior = valor2;
                if (valor3 > valor1 && valor3 > valor2)
                    maior = valor3;
                Console.WriteLine($"O maior valor entre {valor1},{valor2} e {valor3} é {maior}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                ValorMaior();
            }         
        }

        public static void EquacaoSegundoGrau()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("ax² + bx + c = 0");
                Console.Write("Digite o valor a: ");
                string a = Console.ReadLine();
                Console.Write("Digite o valor b: ");
                string b = Console.ReadLine();
                Console.Write("Digite o valor c: ");
                string c = Console.ReadLine();

                double valorA = double.Parse(a);
                double valorB = double.Parse(b);
                double valorC = double.Parse(c);

                double delta = (Math.Pow(valorB, 2) - 4 * valorA * valorC);

                if (delta < 0)
                    Console.WriteLine("Não possui raizes reais");
                else
                {
                    if (delta == 0 || delta > 0)
                    {
                        double raiz1 = (-valorB + Math.Sqrt(delta)) / (2 * valorA);
                        double raiz2 = (-valorB - Math.Sqrt(delta)) / (2 * valorA);
                        Console.WriteLine($"As raizes da equação são {raiz1} e {raiz2}");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor digitado nulo ou inválido!");
                Thread.Sleep(1000);
                EquacaoSegundoGrau();
            }                                  
        }

        public static double[] InsertionSort(double[] arranjo)
        {
            int n = arranjo.Length - 1;
            int i, j, key;
            for (i = 1; i <= n; i++)
            {
                // index atual
                key = (int)arranjo[i];
                // parcela da lista ordenada
                j = i - 1;
                // enquanto o j for maior ou igual a zero e o elemento for maior que estiver na chave
                // vai avançando de uma posição até poder inserir
                while (j >= 0 && arranjo[j] > key)
                {
                    // para fazer a verificação
                    arranjo[j + 1] = arranjo[j];
                    // pra sair do loop
                    j -= 1;
                }
                arranjo[j + 1] = key;
            }
            return arranjo;
        }

        public static void PrintArrayNumerico(double[] arranjo)
        {
            Console.Write("Os valores digitados foram: ");
            foreach(int index in arranjo)
            {
                Console.Write(index + " ");
            }
        }

        public static void NovoArray()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite o primeiro valor: ");
                string num1 = Console.ReadLine();
                Console.Write("Digite o segundo valor: ");
                string num2 = Console.ReadLine();
                Console.Write("Digite o terceiro valor: ");
                string num3 = Console.ReadLine();

                double valor1 = double.Parse(num1);
                double valor2 = double.Parse(num2);
                double valor3 = double.Parse(num3);

                double[] arranjo = { valor1, valor2, valor3 };

                PrintArrayNumerico(arranjo);
                Console.WriteLine("De forma ordenada fica: ");
                PrintArrayNumerico(InsertionSort(arranjo));
            }
            catch(FormatException)
            {
                Console.WriteLine("Algum valor não digitado.");
                Thread.Sleep(1000);
                NovoArray();
            }
            
        }

        public static void Triangulo()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite o primeiro valor: ");
                string valor1 = Console.ReadLine();
                Console.Write("Digite o segundo valor: ");
                string valor2 = Console.ReadLine();
                Console.Write("Digite o terceiro valor: ");
                string valor3 = Console.ReadLine();

                double lado1 = double.Parse(valor1);
                double lado2 = double.Parse(valor2);
                double lado3 = double.Parse(valor3);

                if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado2 + lado1)
                {
                    string tipo = "";
                    if (lado1 != lado2 && lado1 != lado3)
                        tipo = "escaleno";
                    else if (lado1 == lado2 && lado2 == lado3)
                        tipo = "equilátero";
                    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                        tipo = "isóceles";
                    Console.WriteLine($"É um triângulo do tipo {tipo}");
                }
                else
                {
                    Console.WriteLine("não é um triângulo");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Você não digitou um valor");
                Thread.Sleep(1000);
                Triangulo();
            }
                   
        }

        public static void SomaDosPares()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite o primeiro valor: ");
                string num1 = Console.ReadLine();
                Console.Write("Digite o segundo valor: ");
                string num2 = Console.ReadLine();
                Console.Write("Digite o terceiro valor: ");
                string num3 = Console.ReadLine();
                Console.Write("Digite o quarto valor: ");
                string num4 = Console.ReadLine();

                double valor1 = double.Parse(num1);
                double valor2 = double.Parse(num2);
                double valor3 = double.Parse(num3);
                double valor4 = double.Parse(num4);

                double soma = 0;

                double[] arranjo = { valor1, valor2, valor3, valor4 };
                foreach(int numero in arranjo)
                {
                    if (numero % 2 == 0)
                        soma += numero;
                }
                Console.WriteLine($"A soma dos numeros pares foi {soma}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Valor nulo ou inválido.");
                SomaDosPares();
            }

        }

        public static void AnoBissexto()
        {
            try
            {
                Console.Clear();
                Console.Write("Digite um ano: ");
                string ano = Console.ReadLine();

                int anoParaCalcular = int.Parse(ano);

                if(anoParaCalcular % 400 == 0 || (anoParaCalcular % 4 == 0 && anoParaCalcular % 100 != 0))               
                    Console.WriteLine($"O ano {anoParaCalcular} é bissexto!");                
                else
                    Console.WriteLine($"O ano {anoParaCalcular} não é bissexto.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor nulo ou inválido!");
                Thread.Sleep(1000);
                AnoBissexto();
            }
            
        }
    }
}
