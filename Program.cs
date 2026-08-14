using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using static System.Console;

namespace Projeto_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int opcao;

            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.DarkBlue;
            Clear();
            SetCursorPosition(50, 0);
            WriteLine("Bom dia !!!");
            SetCursorPosition(47, 2);
            Write("Qual é o seu nome? ");
            nome = ReadLine();
            SetCursorPosition(45, 4);
            WriteLine($"Bem vindo(a) {nome} a nossa aula");
            Thread.Sleep(2000);

            do
            {
                Clear();

                SetCursorPosition(23, 0);
                Write(new string('=', 80));
                SetCursorPosition(50, 1);
                Write("****** Menu Principal ******");
                SetCursorPosition(23, 2);
                Write(new string('=', 80));
                SetCursorPosition(50, 5); Write("[1]Menu Vetores");
                SetCursorPosition(50, 5); Write("[1]Menu Vetores");
                SetCursorPosition(50, 6); Write("[2]Tabuada");
                SetCursorPosition(50, 7); Write("[3]Compara Números");
                SetCursorPosition(50, 8); Write("[4]Média");
                SetCursorPosition(50, 9); Write("[5]Jogo adivinha");
                SetCursorPosition(50, 10); Write("[6]Sair");
                SetCursorPosition(23, 11);
                Write(new string('=', 80));
                SetCursorPosition(23, 13);
                Write(new string('=', 80));
                SetCursorPosition(23, 12);
                Write($"Usuario: {nome}");
                SetCursorPosition(50, 12);
                Write("Digite sua opção: ");
                opcao = int.Parse(ReadLine());
                switch (opcao)
                {

                    case 1:
                        Menu_Vetores();
                        break;
                    case 2:
                        Tabuada();
                        break;
                    case 3:
                           Compara_Numeros();
                        break;
                    case 4:
                        Media();
                        break;
                    case 5:
                        Jogo_Adivinha();
                        break;
                    default:
                        SetCursorPosition(30, 20);
                        Write("Opção Invalida");
                        break;

                }

            } while (opcao != 6);
        }
        static void Menu_Vetores()
        {

        }
        static void Tabuada()
        {

        }
        static void Compara_Numeros()
        {

        }
        static void Media()
        {

        }
        static void Jogo_Adivinha()
        {

        }

    }
}
