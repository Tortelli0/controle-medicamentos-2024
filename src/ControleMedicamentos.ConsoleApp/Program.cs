using Controle_de_Medicamentos.Compartilhado;
using Controle_de_Medicamentos.ModuloFuncionario;
using Controle_de_Medicamentos.ModuloMedicamento;
using Controle_de_Medicamentos.ModuloPaciente;
using Controle_de_Medicamentos.ModuloRequisicao;

namespace Controle_de_Medicamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioPaciente repositorioPaciente = new RepositorioPaciente();
            TelaPaciente telaPaciente = new TelaPaciente();
            telaPaciente.repositorio = repositorioPaciente;
            telaPaciente.tipoEntidade = "Paciente";

            RepositorioMedicamento repositorioMedicamento = new RepositorioMedicamento();
            TelaMedicamento telaMedicamento = new TelaMedicamento();
            telaMedicamento.repositorio = repositorioMedicamento;
            telaMedicamento.tipoEntidade = "Medicamento";

            RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();
            TelaFuncionario telaFuncionario = new TelaFuncionario();
            telaFuncionario.repositorio = repositorioFuncionario;
            telaFuncionario.tipoEntidade = "Funcionario";

            RepositorioRequisicao repositorioRequisicao = new RepositorioRequisicao();
            TelaRequisicao telaRequisicao = new TelaRequisicao();
            telaRequisicao.repositorio = repositorioRequisicao;
            telaRequisicao.tipoEntidade = "Requisição";

            while (true)
            {
                char opcaoPrincipalEscolhida = TelaPrincipal.ApresentarMenuPrincipal();

                if (opcaoPrincipalEscolhida == 'S' || opcaoPrincipalEscolhida == 's')
                    break;

                TelaBase tela = null;

                if (opcaoPrincipalEscolhida == '1')
                    tela = telaPaciente;

                if (opcaoPrincipalEscolhida == '2')
                    tela = telaMedicamento;

                if (opcaoPrincipalEscolhida == '3')
                    tela = telaFuncionario;

                if (opcaoPrincipalEscolhida == '4')
                    tela = telaRequisicao;

                char operacaoEscolhida = tela.ApresentarMenu();

                if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                    continue;

                if (operacaoEscolhida == '1')
                    tela.Registrar();

                else if (operacaoEscolhida == '2')
                    tela.Editar();

                else if (operacaoEscolhida == '3')
                    tela.Excluir();

                else if (operacaoEscolhida == '4')
                    tela.VisualizarRegistros(true);
            }
            Console.ReadLine();
        }
    }
}

