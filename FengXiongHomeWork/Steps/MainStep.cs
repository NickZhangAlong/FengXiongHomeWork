using FengXiongHomeWork.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FengXiongHomeWork.Steps
{
    public class MainStep : Step
    {
        public MainStep()
        {
            options = new List<Option>() { new Search(), new Add(), new Delete(), new Exit() };
            options.ForEach(option => option.OptionNumber = options.IndexOf(option) + 1);
        }
    }
}
