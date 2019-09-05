using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptude_KBX_MDL.Models
{
    public class M_ShipItem
    {
        public int Id { get; set; }
        public int IdShip { get; set; }
        public int IdClient { get; set; }
        public string Item { get; set; }
        public string Dimensions { get; set; }
        public char[] Units { get; set; }
        public Guid Guid { get; set; }
    }
}
