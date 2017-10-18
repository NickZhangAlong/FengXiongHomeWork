using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengXiongHomeWork.Model
{
    public class Car
    {
        #region Properties

        public string RegistrationNumber { set; get; }
        public int YearMade { set; get; }
        public CommonEnum.CarColor Color { set; get; }
        public string CarMake { set; get; }
        public string CarModel { set; get; }
        public decimal Price { set; get; }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return string.Format("Registration#: '{0}', Year Made: '{1}', Color: '{2}', Car Make: '{3}', Car Model: '{4}', Price: '{5}'",
                RegistrationNumber, YearMade, Color, CarMake, CarModel, Price);
        }

        #endregion
    }
}
