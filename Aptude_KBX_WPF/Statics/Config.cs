using Aptude_KBX_MDL.Models;
using Aptude_KBX_MDL.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptude_KBX_WPF.Statics
{
    internal static class Config
    {
        internal static M_User usuario;
        internal static ConnectionType conexion = ConnectionType.USER;

        public static DateTime FECHAFINALCALENDAR = DateTime.Now;
        public static DateTime FECHAINICIALCALENDAR = DateTime.Now.AddYears(-65);
    }
}
