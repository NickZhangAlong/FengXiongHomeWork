using FengXiongHomeWork.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengXiongHomeWork.Options
{
    public class Search : Option
    {
        public Search()
        {
        }

        public override void Start()
        {
            SearchStep searchStep = new SearchStep();
            searchStep.Start();
        }

        public override string OptionName
        {
            get
            {
                return "Search Cars";
            }
        }
    }
}
