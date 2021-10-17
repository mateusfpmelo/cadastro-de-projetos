using System;
using System.Collections.Generic;
using Dio.Projetos.Interfaces;

namespace Dio.Projetos
{
    public class ProjetoRepositorio : IRepositorio<Projeto> 
    {
        private List<Projeto> listaprojetos = new List<Projeto>();
        
        public void Atualiza(int id, Projeto objeto)
        { 
            listaprojetos[id] = objeto; 
        }
        public void Exclui(int id)
        {
            listaprojetos[id].excluir();
        }
        public void Insere(Projeto objeto)
        { 
            listaprojetos.Add(objeto);
        }
        public List<Projeto> Lista() 
        { 
            return listaprojetos;
        }
        public int ProximoID()
        { 
            return listaprojetos.Count; 
        }
        public Projeto RetornaPorId(int id)
        { 
            return listaprojetos[id];
        }
    }
}