using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengXiongHomeWork.Options
{
    public abstract class Option
    {
        protected int optionNumber;
        public abstract string OptionName { get; }

        public int OptionNumber 
        {
            get { return optionNumber; }
            set { optionNumber = value; }
        }

        public abstract void Start();
    }
}
