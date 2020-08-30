using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    /// <summary>
    /// Interface which can be used to apply multiple type Active Promotion
    /// </summary>
    interface IActivePromotion
    {
        List<Promotion> GetActivePromotion();
    }
}
