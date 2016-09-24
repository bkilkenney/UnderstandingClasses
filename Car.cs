using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingClasses
{
    class Car
    {
        //Properties - All cars have these properties

        public string Make { get; set; }   
        public string Model { get; set; }
        public int Year { get; set; }       //You can type "Prop-tab-tab" and it sets up the property for you
        public string Color { get; set; } 

        public decimal DetermineMarketValue()
        {
            decimal carValue;  //This method must return a decimal above, so we declare: decimal carValue here, that's what it will return

            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;          //Returning carValue, as stated above
        }
        


    }
}
