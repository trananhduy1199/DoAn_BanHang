using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanHang.LinqToSQL;

namespace BanHang
{
    class ConnectToDatabase
    {
        dbQLBanHangDataContext data;
        public ConnectToDatabase()
        {
            data = new dbQLBanHangDataContext();
        }

        public dbQLBanHangDataContext Database()
        {
            return data;
        }
     
    }
}
