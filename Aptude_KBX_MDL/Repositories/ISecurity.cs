using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptude_KBX_MDL.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Envias</typeparam>
    /// <typeparam name="R">Recibes</typeparam>
    public interface ISecurity<T, R> where T : class
    {
        R Login(T reg);
    }
}
