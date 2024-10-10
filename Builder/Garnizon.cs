using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Garnizon
    {
        public void SzkolWojownika(WarriorBuilder builder)
        {
            builder.ZapiszDoArmii();
            builder.PobierzBron();
            builder.TrenujWalka();
        }
    }
}
