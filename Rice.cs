using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Rice
    {
        public List<TypeOfRice> typesOfRice;
        public List<TypeOfPulse> typesOfPulses;
        public List<TypeOfWheats> typesOfWheats;

    }
    public class TypeOfRice
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypeOfPulse
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypeOfWheats
    {
        public string name;
        public int weight;
        public int price;
    }
}
