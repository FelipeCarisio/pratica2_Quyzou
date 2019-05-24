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
                return contexto.Usuario.FirstOrDefault(u => u.Nome == login && u.Senha == senha);
            }
        }

        public static usuario BuscaEmail(string email)
        {
            using (var contexto = new SiteContext())
            {
                return contexto.Usuario.FirstOrDefault(u => u.Email == email);
            }
        }

        public static IList<usuario> Lista()
        {
            using (var contexto = new SiteContext())
            {
                return contexto.Usuario.ToList();
            }
        }
        public static usuario returnUsuario(string s)
        {
            using (var contexto = new SiteContext())
            {
                return contexto.Usuario.FirstOrDefault(u => u.Nome == s);
            }
        }

        public static usuario returnUsuario(int id)
        {
            using (var contexto = new SiteContext())
            {
                return contexto.Usuario.FirstOrDefault(u => u.Id == id);
            }
        }

        public static void Adicionar(usuario u)
        {
            using (var contexto = new SiteContext())
            {
                contexto.Usuario.Add(u);
                contexto.SaveChanges();
                
            }
        }

        public static void Alterar(usuario u)
        {
            using (var contexto = new SiteContext())
            {
                contexto.Usuario.Update(u);
                contexto.SaveChanges();
            }
        }
    }
}