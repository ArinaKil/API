using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_KiluninaAA.classes
{
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Groups(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
