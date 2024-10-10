using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class WarriorBuilder
    {
        protected IWarrior warrior;

        public IWarrior GetWarrior()
        {
            return warrior;
        }

        public abstract void ZapiszDoArmii();
        public abstract void PobierzBron();
        public abstract void TrenujWalka();
    }
}
