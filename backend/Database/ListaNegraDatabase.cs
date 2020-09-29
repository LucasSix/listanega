using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace backend.Database
{
    public class ListaNegraDatabase
    {
        Models.lndbContext db = new Models.lndbContext();
            

        public Models.TbListinhaNegra Salvar(Models.TbListinhaNegra ln)
        {
            db.Add(ln);
            db.SaveChanges();

            return ln;
        }

        public List<Models.TbListinhaNegra> Listar()
        {
             List<Models.TbListinhaNegra> lns = db.TbListinhaNegra.ToList();
             return lns;
        }


        public Models.TbListinhaNegra Deletar(int id)
        {
             Models.TbListinhaNegra ln = 
                db.TbListinhaNegra.FirstOrDefault(x => x.IdListaNegra == id);

             if (ln != null)
             {
                 db.TbListinhaNegra.Remove(ln);
                 db.SaveChanges();
             }

             return ln;
        }

        public Models.TbListinhaNegra Alterar(int id, Models.TbListinhaNegra novo)
        {
             Models.TbListinhaNegra ln = 
                db.TbListinhaNegra.FirstOrDefault(x => x.IdListaNegra == id);

             if (ln != null)
             {
                 ln.NmIndividuo = novo.NmIndividuo;
                 ln.DsMotivo = novo.DsMotivo;
                 ln.DsLocal = novo.DsLocal;
                 ln.DtInclusao = novo.DtInclusao;
                 
                 db.SaveChanges();
             }

             return ln;
        }
    }
}