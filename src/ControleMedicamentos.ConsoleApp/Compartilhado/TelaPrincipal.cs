﻿namespace Controle_de_Medicamentos.Compartilhado
{
    internal static class TelaPrincipal
    {
        public static char ApresentarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|       Controle de Medicamentos       |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("1 - Cadastro de Pacientes");
            Console.WriteLine("2 - Cadastro de Medicamentos");
            Console.WriteLine("3 - Cadastro de Funcionários");
            Console.WriteLine("4 - Cadastro de Requisição");

            Console.WriteLine("S - Sair");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");

            char opcaoEscolhida = Console.ReadLine()[0];

            return opcaoEscolhida;
        }
    }
}
