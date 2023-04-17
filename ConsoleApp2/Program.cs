using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EX1
            //Console.Write("Digite um número correspondente a um dia da semana 1 a 7: ");
            //int dia = int.Parse(Console.ReadLine());

            //switch (dia)
            //{
            //    case 1:
            //        Console.WriteLine("Domingo");
            //        break;
            //    case 2:
            //        Console.WriteLine("Segunda-feira");
            //        break;
            //    case 3:
            //        Console.WriteLine("Terça-feira");
            //        break;
            //    case 4:
            //        Console.WriteLine("Quarta-feira");
            //        break;
            //    case 5:
            //        Console.WriteLine("Quinta-feira");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sexta-feira");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sábado");
            //        break;
            //    default:
            //        Console.WriteLine("Número inválido! Digite um número de 1 a 7.");
            //        break;
            //}

            //EX2
            //int compra, desconto, total, forma;

            //Console.WriteLine("Digite o valor da compra");
            //compra = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um numero que corresponda a sua forma de pagamento. PIX = 1, Dinheiro 2, Debito 3, Credito 4");
            //forma = int.Parse(Console.ReadLine());

            //switch (forma)
            //{
            //    case 1:
            //        desconto = compra / 100 * 15;

            //        total = compra - desconto;

            //        Console.WriteLine("o total é:" + total);
            //        Console.ReadKey();  
            //        break;  

            //    case 2:

            //        desconto = compra / 100 * 10;

            //        total = compra - desconto;

            //        Console.WriteLine("o total é:" + total);
            //        Console.ReadKey();
            //        break;

            //    case 3:
            //        desconto = compra / 100 * 5;

            //        total = compra + desconto;

            //        Console.WriteLine("o total é:" + total);
            //        Console.ReadKey();
            //        break;

            //    case 4:

            //        desconto = compra / 100 * 10;

            //        total = compra - desconto;

            //        Console.WriteLine("o total é:" + total);
            //        Console.ReadKey();
            //        break;

            //  default:
            //        Console.WriteLine("Numero errado");
            //        break;

            //ex3
            //Console.Write("Digite o número do mês (1 a 12): ");
            //int mes = Convert.ToInt32(Console.ReadLine());
            //int dias = 0;
            //string nomeMes = "";

            //switch (mes)
            //{
            //    case 1:
            //        nomeMes = "Janeiro";
            //        dias = 31;
            //        break;
            //    case 2:
            //        nomeMes = "Fevereiro";
            //        Console.Write("Digite o ano: ");
            //        int ano = Convert.ToInt32(Console.ReadLine());
            //        if (DateTime.IsLeapYear(ano))
            //        {
            //            dias = 29;
            //        }
            //        else
            //        {
            //            dias = 28;
            //        }
            //        break;
            //    case 3:
            //        nomeMes = "Março";
            //        dias = 31;
            //        break;
            //    case 4:
            //        nomeMes = "Abril";
            //        dias = 30;
            //        break;
            //    case 5:
            //        nomeMes = "Maio";
            //        dias = 31;
            //        break;
            //    case 6:
            //        nomeMes = "Junho";
            //        dias = 30;
            //        break;
            //    case 7:
            //        nomeMes = "Julho";
            //        dias = 31;
            //        break;
            //    case 8:
            //        nomeMes = "Agosto";
            //        dias = 31;
            //        break;
            //    case 9:
            //        nomeMes = "Setembro";
            //        dias = 30;
            //        break;
            //    case 10:
            //        nomeMes = "Outubro";
            //        dias = 31;
            //        break;
            //    case 11:
            //        nomeMes = "Novembro";
            //        dias = 30;
            //        break;
            //    case 12:
            //        nomeMes = "Dezembro";
            //        dias = 31;
            //        break;
            //    default:
            //        Console.WriteLine("Mês inválido!");
            //        break;
            //}

            //Console.WriteLine("O mês de " + nomeMes + " tem " + dias + " dias.");
            //Console.ReadKey();


            //ex4

            //int num1, num2, resultado;
            //char operacao;

            //Console.Write("Digite o primeiro número: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo número: ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.Write("Digite a operação (+, -, *, / ou ^): ");
            //operacao = char.Parse(Console.ReadLine());

            //switch (operacao)
            //{
            //    case '+':
            //        resultado = num1 + num2;
            //        Console.WriteLine("O resultado é" + resultado);
            //        break;

            //    case '-':
            //        resultado = num1 - num2;
            //        Console.WriteLine("O resultado é" + resultado);
            //        break;

            //    case '*':
            //        resultado = num1 * num2;
            //        Console.WriteLine("O resultado é" + resultado);
            //        break;

            //    case '/':
            //        resultado = num1 / num2;
            //        Console.WriteLine("O resultado é" + resultado);
            //        break;

            //    case '^':
            //        resultado = num1 ^ num2;
            //        Console.WriteLine("O resultado é" + resultado);
            //        break;

            //    default:
            //        Console.WriteLine("Operação inválida.");
            //        break;
            //}

            //Console.ReadKey();
            //ex5

            //double salario,aumento, novoSalario;
            //int cargo;

            //Console.Write("Digite o salário do funcionário: ");
            //salario = double.Parse(Console.ReadLine());

            //Console.Write("Digite o código do cargo do funcionário: ");
            //cargo = int.Parse(Console.ReadLine());

            //switch (cargo)
            //{
            //    case 101:
            //        aumento = salario % 100 * 7.5;
            //        novoSalario = salario + aumento;
            //        break;
            //    case 102:
            //        aumento = salario % 100 * 9.7;
            //        novoSalario = salario + aumento;
            //        break;
            //    case 103:
            //        aumento = salario % 100 * 11.7;
            //        novoSalario = salario + aumento;
            //        break;
            //    case 204:
            //        aumento = salario % 100 * 8.9;
            //        novoSalario = salario + aumento;
            //        break;
            //    case 206:
            //        aumento = salario % 100 * 13.24;
            //        novoSalario = salario + aumento;
            //        break;
            //    case 301:
            //        aumento = salario % 100 * 10.4;
            //        novoSalario = salario + aumento; ;
            //        break;
            //    case 302:
            //        aumento = salario % 100 * 14.6;
            //        novoSalario = salario + aumento;
            //        break;
            //    default:
            //        novoSalario = salario * 1.435;
            //        break;
            //}

            //Console.WriteLine("Salário antigo: R$ " + salario);
            //Console.WriteLine("Novo salário: R$ " + novoSalario);
            //Console.WriteLine("Diferença: R$ " + (novoSalario - salario));
        }
    }
}
