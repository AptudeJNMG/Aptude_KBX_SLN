using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptude_KBX_MDL.Repositories
{
    public interface IRepository<T> where T : class
    {
        string Connection { get; set; }
        List<T> Get<R>(R cons);
        List<T> Get();
        T Find(int id);
        bool Create(T reg);
        bool Update(T reg);
        bool Delete(int id);
    }
}
