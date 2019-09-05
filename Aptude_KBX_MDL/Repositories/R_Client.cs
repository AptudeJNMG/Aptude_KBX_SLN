using Aptude_KBX_MDL.Exceptions;
using Aptude_KBX_MDL.Models;
using Aptude_KBX_MDL.Statics;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptude_KBX_MDL.Repositories
{
    public class R_Client : IRepository<M_Client>
    {
        private string con;
        public string Connection { get => con; set => con = value; }
        public R_Client(ConnectionType tipoConexion)
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
        public bool Create(M_Client reg)
        {
            try
            {
                using (SqlCommand com = new SqlCommand("[dbo].[SP_C_Cuentas]", new SqlConnection(this.Connection))
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                })
                {
                    com.Parameters.AddWithValue("BirthDate", reg.BirthDate);
                    com.Parameters.AddWithValue("FirstName", reg.FirstName);
                    com.Parameters.AddWithValue("LastName", reg.LastName);
                    com.Parameters.AddWithValue("Mail", reg.Mail);
                    com.Connection.Open();
                    com.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new EX_Datos(Messages.ERROR_INSERT, ex);
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public M_Client Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<M_Client> Get<R>(R cons)
        {
            throw new NotImplementedException();
        }

        public List<M_Client> Get()
        {
            throw new NotImplementedException();
        }

        public bool Update(M_Client reg)
        {
            throw new NotImplementedException();
        }
    }
}
