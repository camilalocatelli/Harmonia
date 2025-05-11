using SQLite;
using System;

namespace Harmonia.Models
{
    public class Pessoa
    {
        [PrimaryKey, AutoIncrement]
        public int codigoPessoa { get; set; }
        public string nome { get; set; }
        public DateTime? dataNascimento { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string rg { get; set; }
        public string celularNumero { get; set; }
        public string cpf { get; set; }
    }

    public class Administrador
    {
        [PrimaryKey, AutoIncrement]
        public int codigoAdmin { get; set; }
        public int codigoPessoa { get; set; }
        public string matricula { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public decimal salario { get; set; }
    }

    public class Professor
    {
        [PrimaryKey, AutoIncrement]
        public int codigoProfessor { get; set; }
        public int codigoPessoa { get; set; }
        public int? codigoCurso { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public decimal salario { get; set; }
        public int numeroAulas { get; set; }
    }

    public class Aluno
    {
        [PrimaryKey, AutoIncrement]
        public int codigoAluno { get; set; }
        public int codigoPessoa { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public decimal nota { get; set; }
        public int numeroFaltas { get; set; }
        public int? codigoCurso { get; set; }
        public string matricula { get; set; }
        public int? codigoResponsavel { get; set; }
    }

    public class Instrumento
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }
        public string nome { get; set; }
        public DateTime? dataAquisicao { get; set; }
        public DateTime? dataManutencao { get; set; }
        public DateTime? dataDevolucao { get; set; }
        public int quantidade { get; set; }
    }

    public class Caixa
    {
        [PrimaryKey, AutoIncrement]
        public int idCaixa { get; set; }
        public decimal valor { get; set; }
        public DateTime? dataLancamento { get; set; }
        public DateTime? dataVencimento { get; set; }
        public string descricao { get; set; }
    }

    public class Aula
    {
        [PrimaryKey, AutoIncrement]
        public int idAula { get; set; }
        public int codigoProfessor { get; set; }
        public int codigoAluno { get; set; }
        public DateTime? dataAula { get; set; }
        public TimeSpan? horaInicio { get; set; }
        public TimeSpan? horaFim { get; set; }
        public string observacoes { get; set; }
    }

    public class ReservaInstrumento
    {
        [PrimaryKey, AutoIncrement]
        public int idReserva { get; set; }
        public int codigoInstrumento { get; set; }
        public int codigoAluno { get; set; }
        public DateTime? dataReserva { get; set; }
        public DateTime? dataDevolucao { get; set; }
    }
}
