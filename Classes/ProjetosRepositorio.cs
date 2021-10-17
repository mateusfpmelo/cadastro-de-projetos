using System;
using System.Collections.Generic;
using Dio.Projetos.Interfaces;

namespace Dio.Projetos
{
    public class ProjetoRepositorio : IRepositorio<Projeto> //Implementar uma interface, repositorio de projetos - reaproveitando interfaces
    {
        private List<Projeto> listaprojetos = new List<Projeto>();
        //Criar variavel dos meus projetos
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
        public List<Projeto> Lista() //Método lista irá retornar uma lista de projetos
        { 
            return listaprojetos;
        }
        public int ProximoID()
        { 
            return listaprojetos.Count; // Irei retornar sempre o próximo ID +1 do vetor.
        }
        public Projeto RetornaPorId(int id)
        { 
            return listaprojetos[id];
        }
    }
}