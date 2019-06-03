using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pratica2.Models;

namespace pratica2.DAO
{
    public class respostaDAO
    {
        public static IList<resposta> Lista()
        {
            using (var contexto = new SiteContext())
            {
                return contexto.Respostas.ToList();
            }
        }

        public static resposta returnReposta(int id)
        {
            using (var contexto = new SiteContext())
            {
                return contexto.Respostas.FirstOrDefault(r => r.Id == id);
            }
        } 
    }
}