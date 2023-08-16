using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SlnCorrentista
{
    public class Correntista
    {
        private string name;
        private string cpf;
        private double rendaMensal;
        private DateTime dataNascimento;

        public int Id { get; set; }
        public string Nome
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null || value.Trim() == String.Empty || value.Length < 3)
                {
                    throw new Exception("Nome não pode ser vazio e deve ter ao menos 3 caracteres");
                }
                else
                {
                    name = value;
                }
            }

        }
        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                if (value == null || value == String.Empty)
                {
                    throw new Exception("O cpf não pode ser vazio.");
                }
                else if (!Regex.IsMatch(value, "^[0-9]+$"))
                {
                    throw new Exception("O cpf deve conter apenas números");
                }
                else if (value.Length != 11)
                {
                    throw new Exception("O cpf deve conter 11 dígitos");
                }
                else
                {
                    cpf = value;
                }
            }
        }
        public DateTime DataNascimento
        {

            get
            {
                return dataNascimento;
            }
            set
            {
                if (value.Date >= DateTime.Now)
                {
                    throw new Exception("A data de nascimento não pode ser maior ou igual a data atual");
                }
                else if (!Correntista.VerificarSeMaiorDeIdade(value))
                {
                    throw new Exception("Correntista deve ser maior de 18 anos");
                }
                else
                {
                    dataNascimento = value;
                }
            }

        }
        public double RendaMensal
        {
            get
            {
                return rendaMensal;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("A renda mensal deve ser um número maior que 0.");
                }
                else
                {
                    rendaMensal = value;
                }
            }

        }
        public static int ContadorCorrentista { get; set; } = 1;


        //public Correntista (int id, string nome, string cpf, DateTime dataNascimento, double rendaMensal)
        public Correntista(string nome, string cpf, DateTime dataNascimento, double rendaMensal)
        {
            this.Id = ContadorCorrentista;
            this.Nome = nome;
            this.Cpf = cpf;
            this.RendaMensal = rendaMensal;
            this.DataNascimento = dataNascimento;
            ContadorCorrentista++;
        }

        public Correntista()
        {
            this.Id = ContadorCorrentista;
            ContadorCorrentista++;
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

        public static bool VerificarSeMaiorDeIdade(DateTime dataVerificar)
        {
            DateTime dataAtual = DateTime.Now;

            //calculando a idade
            int idade = dataAtual.Year - dataVerificar.Year;

            if (dataAtual.Month < dataVerificar.Month ||
                (dataAtual.Month == dataVerificar.Month && dataAtual.Day < dataVerificar.Day))
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
    }
}


