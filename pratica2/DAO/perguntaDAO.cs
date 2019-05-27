using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pratica2.Models;

namespace pratica2.DAO
{
    public class perguntaDAO
    {
        public static IList<pergunta> Lista()
        {
            using (var contexto = new SiteContext())
            {
                return contexto.Perguntas.ToList();
            }
        }
    }
}