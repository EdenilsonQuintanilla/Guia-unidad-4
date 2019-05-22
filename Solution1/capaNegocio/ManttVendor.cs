using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace capaNegocio
{
    public class ManttVendor
    {
        bdConex test= new bdConex();
        public String prueba()
        {
            String mensaje;
            if (test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }
            else {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }
    }
}
