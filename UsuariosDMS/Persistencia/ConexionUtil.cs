using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsuariosDMS.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=3b44ee44-70f0-4b2b-8b40-a5af00f2cb95.sqlserver.sequelizer.com;Initial Catalog=db3b44ee4470f04b2b8b40a5af00f2cb95;User ID=plofowrtvtbmbemb;Password=i4AvpYxefV88ZMkrBhW3s6HPhWVkWi5C6LqXwqAUdDfU3P4mJUb5uJSktToAdnq6;";
            //return "Data Source=LAPTOPTOSHIBA;Initial Catalog=BD_Prestamo;Integrated Security=SSPI;";
        }

        public static string Cadena
        {
            get
            {
                return "Data Source=3b44ee44-70f0-4b2b-8b40-a5af00f2cb95.sqlserver.sequelizer.com;Initial Catalog=db3b44ee4470f04b2b8b40a5af00f2cb95;User ID=plofowrtvtbmbemb;Password=i4AvpYxefV88ZMkrBhW3s6HPhWVkWi5C6LqXwqAUdDfU3P4mJUb5uJSktToAdnq6;";
            }
        }
    }
}