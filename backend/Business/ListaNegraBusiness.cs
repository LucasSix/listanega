using System;
using System.Collections.Generic;
using System.Linq;


namespace backend.Business
{
    public class ListaNegraBusiness
    {
        Database.ListaNegraDatabase db =new Database.ListaNegraDatabase();

        public Models.TbListinhaNegra Salvar(Models.TbListinhaNegra ln)
        {
            if (string.IsNullOrEmpty(ln.NmIndividuo))
                throw new Exception("Nome é obrigatório");
            if (string.IsNullOrEmpty(ln.DsMotivo))
                throw new Exception("Motivo é obrigatório");
          //  if (string.IsNullOrEmpty(ln.DsLocal))
            //    throw new Exception("Local é obrigatório");

            return db.Salvar(ln);
        }

        public List<Models.TbListinhaNegra> Listar()
        {
            return db.Listar();
        }

        public Models.TbListinhaNegra Deletar(int id)
        {
            return db.Deletar(id);
        }

        public Models.TbListinhaNegra Alterar(int id, Models.TbListinhaNegra novo)
        {
            if (novo.NmIndividuo == string.Empty)
                throw new Exception("Nome é obrigatório");
            if (novo.DsMotivo == string.Empty)
                throw new Exception("Motivo é obrigatório");
            if (novo.DsLocal == string.Empty)
               throw new Exception("Local é obrigatório");


            return db.Alterar(id, novo);
        }
    }
}