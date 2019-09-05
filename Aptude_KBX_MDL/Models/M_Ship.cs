using Aptude_KBX_MDL.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptude_KBX_MDL.Models
{
    public class M_Ship
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public string AddressFrom { get; set; }
        public string AddressTo { get; set; }
        public DateTime DateDeparted { get; set; }
        public DateTime DateRecivedExpects { get; set; }
        public StatusShip IdStatusShip { get; set; }
        public Nullable<DateTime> DateRecivedReal { get; set; }
        public Guid Guid { get; set; }
    }
}
