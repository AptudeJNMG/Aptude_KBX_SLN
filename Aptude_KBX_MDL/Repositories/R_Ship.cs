using Aptude_KBX_MDL.Models;
using Aptude_KBX_MDL.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptude_KBX_MDL.Repositories
{
    public class R_Ship : IRepository<M_Ship>
    {
        private string con;
        public string Connection { get => con; set => con = value; }
        public R_Ship(ConnectionType tipoConexion)
        {
            switch (tipoConexion)
            {
                case ConnectionType.CLIENT:
                    Connection = Config.CON_CLIENT;
                    break;
                case ConnectionType.USER:
                    Connection = Config.CON_USER;
                    break;
            }
        }
        public bool Create(M_Ship reg)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public M_Ship Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<M_Ship> Get<R>(R cons)
        {
            throw new NotImplementedException();
        }

        public List<M_Ship> Get()
        {
            throw new NotImplementedException();
        }

        public bool Update(M_Ship reg)
        {
            throw new NotImplementedException();
        }
    }
}
