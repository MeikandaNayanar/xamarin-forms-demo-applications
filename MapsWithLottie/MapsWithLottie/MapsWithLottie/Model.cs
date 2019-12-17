using System;
using System.Collections.Generic;
using System.Text;

namespace MapsWithLottie
{
    public class Model
    {
        public Model(string country, string con)
        {
            this.Country = country;
            this.Continent = con;
        }
        public string Continent
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }

    }
}
