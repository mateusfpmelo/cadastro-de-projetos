using System;


namespace Dio.Projetos
{
    public class Projeto : EntidadeBase
    {
        //Atributos
        private Categoria Categoria { get; set; }
        private string NomeCliente { get; set; }
        private string StatusProjeto { get; set; }
        private int AnoConclusao { get; set; }

    private bool Excluido{get; set;}

    //Métodos
        public Projeto(int id, Categoria categoria, string NomeCliente, string StatusProjeto, int AnoConclusao)
        { 
            this.Id = id;
            this.Categoria = categoria;
            this.NomeCliente = NomeCliente;
            this.StatusProjeto = StatusProjeto;
            this.AnoConclusao = AnoConclusao; 
        this.Excluido = false; //Sempre criar com a informacao de excluido

        }
        public override string ToString()
        // Quando vamos tentar dar um write line -> ele executar a ação abaixo retornando o noem do cliente status do projeto e ano de conclusão.
        // Environment como o sistema operacional interpreta uma nova linha 
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
        public void excluir() { // Método
            this.Excluido = true;
        }
    }
}