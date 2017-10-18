using FengXiongHomeWork.Options;
using FengXiongHomeWork.Options.SearchOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengXiongHomeWork.Steps
{
    public class SearchStep : Step
    {
        public SearchStep()
        {
            options = new List<Option>() { new SearchByRegistrationNumber(), new SearchByCarMakeAndCarModel(), 
                new SearchByAge(), new SearchByPrice() };
            options.ForEach(option => option.OptionNumber = options.IndexOf(option) + 1);
        }
    }
}
