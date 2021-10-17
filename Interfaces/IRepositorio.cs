using System.Collections.Generic;


namespace Dio.Projetos.Interfaces
{
    public interface IRepositorio<T> 
    {
        List<T> Lista(); // Método que se chama list de <T>
        T RetornaPorId(int id); // Passo um Id pro parametro ele retorna um T
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoID(); //Retorna um proximo ID
    }
}