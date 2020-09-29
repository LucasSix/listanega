using System;
using System.Collections.Generic;


namespace backend.Utils
{
    public class ListaNegraConversor
    {
        public Models.TbListinhaNegra ParaTabela(Models.Request.ListaNegraRequest request)
        {
            Models.TbListinhaNegra ln = new Models.TbListinhaNegra();
            ln.NmIndividuo = request.Individuo;
            ln.DsMotivo = request.Motivo;
            ln.DtInclusao = request.Inclusao;
            ln.DsLocal = request.Local;

            return ln;
        }

        public Models.Response.ListaNegraResponse ParaResponse(Models.TbListinhaNegra ln)
        {
            Models.Response.ListaNegraResponse resp =new Models.Response.ListaNegraResponse();
            resp.Id = ln.IdListaNegra;
            resp.Nome = ln.NmIndividuo;
            resp.Motivo = ln.DsMotivo;
            resp.Inclusao = ln.DtInclusao;
            resp.Local = ln.DsLocal;
            resp.Foto = ln.DsFoto;
            return resp;
        }

        public List<Models.Response.ListaNegraResponse> ParaResponse(List<Models.TbListinhaNegra> lns)
        {
            List<Models.Response.ListaNegraResponse> resp = new List<Models.Response.ListaNegraResponse>();
            foreach (Models.TbListinhaNegra item in lns)
            {
                resp.Add(
                    this.ParaResponse(item));
            }
            return resp;
        }
    }
}