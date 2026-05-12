using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entites
{
    public class ActionOwned
    {
        public virtual int ActionID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Company { get; set; }
        public virtual string Corrunce { get; set; }
        public virtual int Quantity { get; set; }


    }
}
