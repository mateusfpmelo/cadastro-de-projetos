using System;


namespace Dio.Projetos
{
    public class Projeto : EntidadeBase
    {
        
        private Categoria Categoria { get; set; }
        private string NomeCliente { get; set; }
        private string StatusProjeto { get; set; }
        private int AnoConclusao { get; set; }

    private bool Excluido{get; set;}

    
        public Projeto(int id, Categoria categoria, string NomeCliente, string StatusProjeto, int AnoConclusao)
        { 
            this.Id = id;
            this.Categoria = categoria;
            this.NomeCliente = NomeCliente;
            this.StatusProjeto = StatusProjeto;
            this.AnoConclusao = AnoConclusao; 
        this.Excluido = false;

        }
        public override string ToString()
        
         
        {
            string retorno = "";
            retorno += "Nome do cliente: " + this.NomeCliente + Environment.NewLine;
            retorno += "Status do projeto: " + this.StatusProjeto + Environment.NewLine;
            retorno += "Ano de conclusão: " + this.AnoConclusao + Environment.NewLine;
                return retorno;

        }

        public string retornaNomeCliente()
        { 
            return this.NomeCliente;
        }
        public int retornaID()
        { 
            return this.Id;
        }
        public bool retornaexcluido()
        {
            return this.Excluido;
        }
        public void excluir() { 
            this.Excluido = true;
        }
    }
}