using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class Garnizon
    {
        public static Wojownik TrainWarrior(string profession, string name) 
        {
            switch (profession) 
            {
                case "peichur":
                    return new Piechur(name);
                case "strzelec":
                    return new Strzelec(name);
                case "konny":
                    return new Konny(name);
                default:
                    throw new ArgumentException("Cannot train warrior");
            }
        }
    }
}
