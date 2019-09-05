using Aptude_KBX_MDL.Models;
using Aptude_KBX_MDL.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptude_KBX_MDL.Repositories
{
    class R_ShipItem : IRepository<M_ShipItem>
    {
        private string con;
        public string Connection { get => con; set => con = value; }
        public R_ShipItem(ConnectionType tipoConexion)
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
        public bool Create(M_ShipItem reg)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public M_ShipItem Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<M_ShipItem> Get<R>(R cons)
        {
            throw new NotImplementedException();
        }

        public List<M_ShipItem> Get()
        {
            throw new NotImplementedException();
        }

        public bool Update(M_ShipItem reg)
        {
            throw new NotImplementedException();
        }
    }
}
