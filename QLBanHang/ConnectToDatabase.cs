using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.LinQToSQL;

namespace QLBanHang
{
    class ConnectToDatabase
    {
        DBQLBanHangDataContext data;
        public ConnectToDatabase()
        {
            data = new DBQLBanHangDataContext();
        }
        public DBQLBanHangDataContext Database()
        {
            return data;
        }
    }
}
