using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengXiongHomeWork.Options
{
    public class Exit : Option
    {
        public Exit()
        {
        }

        public override void Start()
        {
            System.Environment.Exit(0);
        }

        public override string OptionName
        {
            get { return "Exit System"; }
        }
    }
}
