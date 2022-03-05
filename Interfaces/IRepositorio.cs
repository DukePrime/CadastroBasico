using System.Collections.Generic;
namespace Dio.TechSystem.Interfaces
{
    //Na implementaçao será passado um tipo generico representaod por <T>
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
         
    
}