using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class Promotion
    {
        public char Unit { get; set; }
        public int NumSKURequired { get; set; }
        public Boolean IsDiscountInPercentage { get; set; }
        public decimal FlatDiscount { get; set; }

        public decimal DiscountPercentage { get; set; }

        public bool IsOtherSKURequired { get; set; }
        public char? OtherSKULookUp { get; set; }

    }
}
