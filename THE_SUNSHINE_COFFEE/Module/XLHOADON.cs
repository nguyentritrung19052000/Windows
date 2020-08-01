using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace THE_SUNSHINE_COFFEE.Modules
{
    class XLHOADON: XLBANG
    {
        public XLHOADON() : base("HoaDonBan") { }
        public XLHOADON(string pQuery) : base("HoaDonBan", pQuery) { }
       
    }

}
