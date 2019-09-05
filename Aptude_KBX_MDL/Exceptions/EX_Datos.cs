using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptude_KBX_MDL.Exceptions
{

    [Serializable]
    public class EX_Datos : Exception
    {
        public EX_Datos() { }
        public EX_Datos(string message) : base(message) { }
        public EX_Datos(string message, Exception inner) : base(message, inner) { }
        protected EX_Datos(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
