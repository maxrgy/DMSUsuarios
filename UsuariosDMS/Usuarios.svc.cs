using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UsuariosDMS.Dominio;
using UsuariosDMS.Persistencia;

namespace UsuariosDMS
{
    public class Usuarios : IUsuarios
    {
        private UsuarioDAO usuarioDAO = null;
        private UsuarioDAO UsuarioDAO
        {
            get
            {
                if (usuarioDAO == null)
                    usuarioDAO = new UsuarioDAO();
                return usuarioDAO;
            }
        }

        public Usuario CrearUsuario(string codigo, string correo, string nombre, int tipo, string password)
        {
            Usuario usuarioACrear = new Usuario()
            {
                Codigo = codigo,
                Correo = correo,
                Nombre = nombre,
                Tipo = tipo,
                Password = password
            };
            return UsuarioDAO.Crear(usuarioACrear);
        }

        public void EliminarUsuario(string codigo)
        {
            Usuario usuarioExistente = UsuarioDAO.Obtener(codigo);
            UsuarioDAO.Eliminar(usuarioExistente);
        }

        public List<Usuario> ListarUsuario()
        {
            return UsuarioDAO.ListarTodos().ToList();
        }

        public Usuario ModificarUsuario(string codigo, string correo, string nombre, int tipo, string password)
        {
            Usuario usuarioAModificar = new Usuario()
            {
                Codigo = codigo,
                Correo = correo,
                Nombre = nombre,
                Tipo = tipo,
                Password = password
            };
            return UsuarioDAO.Modificar(usuarioAModificar);
        }

        public Usuario ObtenerUsuario(string codigo)
        {
            return UsuarioDAO.Obtener(codigo);
        }
    }
}
