using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassifiedAd
{
    class ClassifiedAd
    {
        public string Category { get; set; }
        public int Words { get; set; }

        public double Price {
            get
            {
                return Words * 0.09;
            }
        }
    }
}
