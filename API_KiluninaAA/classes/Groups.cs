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

        public static List<Groups> AllGroups()
        {
            List<Groups> allGroups = new List<Groups>();

            string Data = Common.HttpQuery("http://localhost/api/index.php?groups");
            string[] DataGroups = Data.Split(';');
            foreach (string DataGroup in DataGroups)
            {
                allGroups.Add(new Groups(
                    Convert.ToInt32(DataGroup.Split(':')[0]),
                    DataGroup.Split(':')[1]
                    ));
            }

            return allGroups;
        }
    }
}
