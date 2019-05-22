using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pratica2.Models;

namespace pratica2.DAO
{
    public class usuarioDAO
    {
        public usuario Busca(string login, string senha)
        {
            using (var contexto = new SiteContext())
            {
                return contexto.Usuario2.FirstOrDefault(u => u.Nome == login && u.Senha == senha);
            }
        }

        public static void Adicionar(usuario u)
        {
            using (var contexto = new SiteContext())
            {
                contexto.Usuario2.Add(u);
                contexto.SaveChanges();
            }
        }
    }
}