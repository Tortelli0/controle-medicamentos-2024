﻿using Controle_de_Medicamentos.Compartilhado;

namespace Controle_de_Medicamentos
{
    internal class Medicamento : EntidadeBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string Lote { get; set; }
        public DateTime DataValidade { get; set; }

        public Medicamento(string nome, string descricao, string lote, DateTime dataValidade)
        {
            Nome = nome;
            Descricao = descricao;
            Lote = lote;
            DataValidade = dataValidade;
        }
        public override string[] Validar()
        {
            string[] erros = new string[4];
            int contadorErros = 0;

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros[contadorErros++] = ("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Descricao.Trim()))
                erros[contadorErros++] = ("O campo \"descrição\" é obrigatório");

            if (string.IsNullOrEmpty(Lote.Trim()))
                erros[contadorErros++] = ("O campo \"lote\" é obrigatório");

            DateTime hoje = DateTime.Now.Date;

            if (DataValidade < hoje)
                erros[contadorErros++] = ("O campo \"data de validade\" não pode ser menor que a data atual");

            string[] errosFiltrados = new string[contadorErros];

            Array.Copy(erros, errosFiltrados, contadorErros);

            return errosFiltrados;
        }
    }
}
