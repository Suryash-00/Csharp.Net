using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration.Services
{
    public class TotalUsers
    {
        public long TUsers()
        {
            Random rnd= new Random();
            return rnd.Next(100, int.MaxValue);
        }
    }
}
