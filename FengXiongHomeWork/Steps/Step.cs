using FengXiongHomeWork.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengXiongHomeWork.Steps
{
    public abstract class Step
    {
        protected List<Option> options;

        public override string ToString()
        {
            StringBuilder commandBuilder = new StringBuilder();
            foreach (var option in options)
            {
                commandBuilder.AppendLine(string.Format("({0}) {1}", option.OptionNumber, option.OptionName));
            }

            return commandBuilder.ToString();
        }

        public void Start()
        {
            Console.WriteLine(this.ToString());

            while (true)
            {
                string key = Console.ReadLine();
                Console.WriteLine();
                int number;
                if (Int32.TryParse(key, out number))
                {
                    if (number > 0 && number < (this.options.Count + 1))
                    {
                        Option option = this.options[number - 1];
                        option.Start();
                    }
                }
                else
                {
                    Console.WriteLine(string.Format("Please enter {0} to {1}", 1, this.options.Count + 1));
                }
            }
        }
    }
}
