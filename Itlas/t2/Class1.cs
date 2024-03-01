using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Animal // El tipo de animal
    {
        public string? Name;
        public DateTime Born;
        public byte Legs;
    }
    class Cat : Animal // El subtipo de animal
    {
        public bool IsDomestic;
        public bool vaccinated;
    }
    class Spider : Animal // El subtipo de animal
    {
        public bool IsPoisonous;
    }
}  
