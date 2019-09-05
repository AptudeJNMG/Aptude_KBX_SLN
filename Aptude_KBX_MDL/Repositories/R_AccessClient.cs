using Aptude_KBX_MDL.Models;
using Aptude_KBX_MDL.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptude_KBX_MDL.Repositories
{
    class R_AccessClient : IRepository<M_Client>, ISecurity<M_Login,M_Client>
    {
        private string con;
        private ConnectionType _tipoConexion;
        public string Connection { get => con; set => con = value; }
        public R_AccessClient(ConnectionType tipoConexion)
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
            _tipoConexion = tipoConexion;
        }

        public List<M_Client> Get<R>(R cons)
        {
            throw new NotImplementedException();
        }

        public List<M_Client> Get()
        {
            throw new NotImplementedException();
        }

        public M_Client Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Create(M_Client reg)
        {
            throw new NotImplementedException();
        }

        public bool Update(M_Client reg)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public M_Client Login(M_Login reg)
        {
            throw new NotImplementedException();
        }
    }
}
