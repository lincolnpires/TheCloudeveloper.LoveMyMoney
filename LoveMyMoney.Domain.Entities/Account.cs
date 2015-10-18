using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveMyMoney.Domain.Entities
{
    public class Account
    {
        public Account()
        {

        }

        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
