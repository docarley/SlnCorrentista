using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnCorrentista
{
    public class Correntista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public double RendaMensal { get; set; }
        public static int ContadorCorrentista { get; set; } = 0;


        //public Correntista (int id, string nome, string cpf, DateTime dataNascimento, double rendaMensal)
        public Correntista(string nome, string cpf, DateTime dataNascimento, double rendaMensal)
        {
            this.Id = ContadorCorrentista++;
            this.Nome = nome;
            this.Cpf = cpf;
            this.RendaMensal = rendaMensal;
            this.DataNascimento = dataNascimento;
        }

        public Correntista()
        {
            this.Id = ContadorCorrentista++;
        }
        public bool VerificarSeCorrentistaMaior()
        {
            DateTime dataAtual = DateTime.Now;

            //calculando a idade
            int idade = dataAtual.Year - this.DataNascimento.Year;

            if (dataAtual.Month < this.DataNascimento.Month ||
                (dataAtual.Month == this.DataNascimento.Month && dataAtual.Day < this.DataNascimento.Day))
            {
                idade = idade - 1;
            }

            //verificando se a idade é maior que 18
            if (idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RetornarPerfilCliente()
        {
            if (this.RendaMensal <= 3000)
            {
                return "Silver";
            }
            else if (this.RendaMensal <= 5000)
            {
                return "Gold";
            }
            else if (this.RendaMensal <= 10000)
            {
                return "Diamond";
            }
            else
            {
                return "Black";
            }
        }

        public string MontarMensagemBoasVindas()
        {
            return $"Olá{this.Nome},\nSeja bem vindo ao Sifrão!\nCliente:{this.RetornarPerfilCliente()}";
        }

        public string MontarMensagemDadosCorrentista()
        {
            return $"ID: {this.Id}\nNome: {this.Nome}\nCPF: {this.Cpf}\nData de Nascimento: {this.DataNascimento}\nRenda Mensal: {this.RendaMensal}";
        }

    }
}


