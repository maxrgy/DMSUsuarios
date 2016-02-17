using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UsuariosDMS.Dominio;

namespace UsuariosDMS
{
    [ServiceContract]
    public interface IUsuarios
    {
        [OperationContract]
        Usuario CrearUsuario(string codigo, string correo, string nombre, int tipo, string password);
        [OperationContract]
        Usuario ObtenerUsuario(string codigo);
        [OperationContract]
        Usuario ModificarUsuario(string codigo, string correo, string nombre, int tipo, string password);
        [OperationContract]
        void EliminarUsuario(string codigo);
        [OperationContract]
        List<Usuario> ListarUsuario();
    }
}
