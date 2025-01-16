using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IInterface
    {
        void DisplayMenu();
    }

    public class GraphicInterface : IInterface
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Graphic Interface: Displaying installed programs");
        }
    }

    // Implementacja interfejsu tekstowego
    public class TextInterface : IInterface
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Text Interface: Displaying installed programs");
        }
    }
}
