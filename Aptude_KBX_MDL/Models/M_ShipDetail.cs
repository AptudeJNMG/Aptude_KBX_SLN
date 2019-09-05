using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptude_KBX_MDL.Models
{
    public class M_ShipDetail
    {
        public int IdShip { get; set; }
        public int IdClient { get; set; }
        public int IdWareHouseFrom { get; set; }
        public int IdWareHouseTo { get; set; }
        public DateTime DateDepart { get; set; }
        public Nullable<DateTime> DateArrived { get; set; }
    }
}
