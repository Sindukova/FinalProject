using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Materials
    {
        public Materials()
        {

        }
        public int id_materials { get; set; }
        public string name { get; set; }
        public string residential_pickup { get; set; }
        public string drop_off { get; set; }
        public string instructions { get; set; }


    }
}
