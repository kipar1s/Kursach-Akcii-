using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entites
{
    public class ActionInSale
    {
        public virtual int ActionID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Company { get; set; }
        public virtual string Currency { get; set; }
        public virtual decimal PriceOne { get; set; }
        public virtual decimal PriceTwo { get; set; }
        public virtual decimal PriceThree { get; set; }
        public virtual decimal PriceThreeUSD { get; set; }
        public virtual decimal Forecast { get; set; }
        public virtual decimal ForecastUSD { get; set; }
        public virtual decimal Dynamic { get; set; }

    }
}
