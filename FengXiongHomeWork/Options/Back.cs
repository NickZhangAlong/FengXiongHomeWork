using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengXiongHomeWork.Options
{
    class Back : Option
    {
        public Action StartAction { set; get; }

        public override string OptionName
        {
            get { return "Back to Main Menu"; }
        }

        public override void Start()
        {
            StartAction.Invoke();
        }
    }
}
