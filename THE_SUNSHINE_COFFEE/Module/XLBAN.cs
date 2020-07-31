using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace THE_SUNSHINE_COFFEE.Modules
{
    class XLBAN: XLBANG
    {
        public XLBAN() : base("Ban") { }
        public XLBAN(string pQuery) : base("Ban", pQuery) { }
       
    }

}
