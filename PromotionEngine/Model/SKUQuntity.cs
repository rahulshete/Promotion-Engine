using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class SKUQuntity
    {
        public SKU SKU { get; set; }
        public int Quntity { get; set; }
        public bool ItemProcessed { get; set; }
    }
}
