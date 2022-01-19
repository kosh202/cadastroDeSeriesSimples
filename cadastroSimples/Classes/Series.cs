using System;

namespace DIO.Series
{
    public class Series : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Nome { get; set; }
        private string Trabalho { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        //metodos

        public Series(int id, Genero genero, string nome, string Trabalho, int ano, string Nome)
        {
            this.Id = id;
            this.Genero = genero;
            this.Nome = nome;
            this.Trabalho = Trabalho;
            this.Ano = ano;
            this.Excluido = false;
        }

        public Series(int id, Genero genero, string Nome, string Trabalho, int ano)
        {
            Id = id;
            Genero = genero;
            this.Nome = Nome;
            this.Trabalho = Trabalho;
            Ano = ano;
        }

        public override string ToString()
        {
            //Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Trabalho: " + this.Trabalho + Environment.NewLine;
            retorno += "Data de nascimento: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaNome()
        {
            return this.Nome;
        }

        public int retornaId()
        {
            return this.Id; 
        }

        public bool retornaExcluido()
        {
            return this.Excluido; 
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}