using System;
using System.Collections.Generic;
using Dio.TechSystem.Interfaces; //Chama a interface

namespace Dio.TechSystem
{
    //Reaproveita a interface - ServRepositorio implementa um IRepositorio de Serviços
    public class ServRepositorio : IRepositorio<Servicos>
    {
        private List<Servicos> listaServicos = new List<Servicos>();
        public void Atualiza(int id, Servicos objeto)
        {
            listaServicos[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaServicos[id].Excluir();
        }

        public void Insere(Servicos objeto)
        {
            listaServicos.Add(objeto);
        }

        public List<Servicos> Lista()
        {
            return listaServicos;
        }

        public int ProximoId()
        {
            return listaServicos.Count;
        }

        public Servicos RetornaPorId(int id)
        {
            return listaServicos[id];
        }
    }
}