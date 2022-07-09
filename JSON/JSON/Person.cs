using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"Id:  {PersonId}\tName:  {Name}\tAddress:  {Address}";
            //return JsonConvert.SerializeObject(this);
        }
    }
}