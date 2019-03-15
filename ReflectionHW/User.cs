using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHW
{
    public class User
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }

        public User(string name, string lastname,int phone,string address)
        {
            Name = name;
            Lastname = lastname;
            Phone = phone;
            Address = address;
        }


    }
}
