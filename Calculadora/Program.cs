using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ProjetoCalculadora
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                Console.Title = "Calculadora"; // Adciona um titulo para quando o codigo for iniciado
                Console.WriteLine("--------------------Calculadora--------------------"); // o que será escrito na tela do promt

                double valor1 = 0, valor2 = 0, resultado, numero; // Aqui é utilizado um double para que achar uma maior precisao/acuaricia dos numeros (64 bits), atribuindo 0 aos valores
                string operador, valorDigitado; // Aqui nos temos uma varivel string para o operador digitado e pelo valor digitado
                bool numero_inteiro; // Aqui temos uma varivel bool para o numero inteiro

                 Console.WriteLine("Digite o primeiro valor e aperte enter para confirmar seu valor: "); // Aqui nos temos uma linha de codigo para o usúario digitar o primeiro valor
                valorDigitado = Console.ReadLine(); // Aqui nos temos uma linha de codigo para ler o valor digitado pelo usúario

                
                numero_inteiro = double.TryParse(valorDigitado, out numero); // Aqui nos temos uma linha de codigo para verificar se o numero realmente é inteiro e tabem há

                //Começamos nossa condicional para fazer a validação, 
                if (numero_inteiro)
                {
                    valor1 = Math.Round(double.Parse(valorDigitado), 3);//Apos obtermos a confirmarção vamos precisar armazenar o valor1 apenas se for true
                    
                }
                else
                {
                    Console.WriteLine("Digite um número válido."); // caso sera colocado algo alem de numeros essa mensagem será exibida
                }

                Console.WriteLine("Digite a operação matemática desejada: ( /= divisão , * = multiplicação, + = soma, - = subtração e % = MOD resto ): "); // aqui estamos pedido para o úsurio digitar nosso operador e mostramos os operadores disponiveis
                operador = Console.ReadLine();

                Console.WriteLine("Digite o segundo valor e aperte enter para confirmar seu valor: "); // pedimos o segundo valor
                valorDigitado = Console.ReadLine();
                numero_inteiro = double.TryParse(valorDigitado, out numero); // convertemos o segundo valor para um numero inteiro
                if (numero_inteiro)
                {
                    valor2 = Math.Round(double.Parse(valorDigitado), 3); // arredondamos o segundo número 
                }
                else
                {
                    Console.WriteLine("Digite um número válido"); // caso sera colocado algo alem de numeros essa mensagem será exibida
                }

                switch (operador)
                {
                    case "+":
                        resultado = Math.Round(valor1 + valor2, 3);
                        Console.WriteLine($"{valor1} {'+'} {valor2} = {resultado}"); // Aqui nos estamos atribuido ao caractere + a função de operção de adição
                        break;
                    case "-":
                        resultado = Math.Round(valor1 - valor2, 3);
                        Console.WriteLine($"{valor1} {'-'} {valor2} = {resultado}"); // Aqui estamos atribuindo ao caractere - a função de operação de subtração
                        break;
                    case "*":
                        resultado = Math.Round(valor1 * valor2, 3);
                        Console.WriteLine($"{valor1} {'*'} {valor2} = {resultado}"); // Aqui estamos atribuindo ao caractere * a função de operação de mutiplicação
                        break;
                    case "/":
                        resultado = Math.Round(valor1 / valor2, 3);
                        Console.WriteLine($"{valor1} {'/'} {valor2} = {resultado}"); // Aqui estamos atribuindo ao caractere / a função de operação de divisão
                        break;
                    case "%":
                        resultado = Math.Round(valor1 % valor2, 3);
                        Console.WriteLine($"{valor1} {'%'} {valor2} = {resultado}"); // Aqui estamos atribuindo ao caractere % a função de operação de porcentagem
                        break;
                    default:
                        Console.WriteLine("Digite uma operação válida"); // Caso seja colocado algo mais alem da operação essa mensagem sera exibida.
                        break;
                }

                Console.ReadKey();
            }
        }
    }

                 
               
                

                

                


    