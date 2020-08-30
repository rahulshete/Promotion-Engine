using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class ActivePromotion : IActivePromotion
    {
        /// <summary>
        /// This Class can be fill dynamically from DB in real senario
        /// </summary>
        /// <returns></returns>
        public List<Promotion> GetActivePromotion()
        {
            List<Promotion> activePromotion = new List<Promotion>();
            Promotion _APromotion = new Promotion()
            {
                Unit = 'A',
                NumSKURequired = 3,
                IsDiscountInPercentage = false,
                FlatDiscount = 20,
                DiscountPercentage = 0,
                IsOtherSKURequired = false,
                OtherSKULookUp = null
            };
            activePromotion.Add(_APromotion);
            Promotion _BPromotion = new Promotion()
            {
                Unit = 'B',
                NumSKURequired = 2,
                IsDiscountInPercentage = false,
                FlatDiscount = 15,
                DiscountPercentage = 0,
                IsOtherSKURequired = false,
                OtherSKULookUp = null
            };
            activePromotion.Add(_BPromotion);
            Promotion _CPromotion = new Promotion()
            {
                Unit = 'C',
                NumSKURequired = 1,
                IsDiscountInPercentage = false,
                FlatDiscount = 5,
                DiscountPercentage = 0,
                IsOtherSKURequired = true,
                OtherSKULookUp = 'D'
            };
            activePromotion.Add(_CPromotion);
            Promotion _DPromotion = new Promotion()
            {
                Unit = 'D',
                NumSKURequired = 1,
                IsDiscountInPercentage = false,
                FlatDiscount = 5,
                DiscountPercentage = 0,
                IsOtherSKURequired = true,
                OtherSKULookUp = 'C'
            };
            activePromotion.Add(_DPromotion);
            return activePromotion;
        }
    }
}
