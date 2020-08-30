using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class CalculatePrice
    {
        ActivePromotion _activePromotion;
        public CalculatePrice()
        {
            _activePromotion = new ActivePromotion();
        }
        public decimal GetShoppingCartPriceList(List<SKUQuntity> cartItems)
        {
            decimal totalPrice = 0.0M;
            List<Promotion> activePromotions = _activePromotion.GetActivePromotion();
            foreach (var item in cartItems)
            {
                if (item.ItemProcessed == false)
                {
                    Promotion itemPromotion = activePromotions.Where(x => x.Unit.ToString().Equals(item.SKU.Unit.ToString())).FirstOrDefault();
                    if (itemPromotion != null)//Promotion Found for Product
                    {
                        int rem = (item.Quntity) % (itemPromotion.NumSKURequired);
                        int remainingQuntity = (item.Quntity) / (itemPromotion.NumSKURequired);

                        if (itemPromotion.IsDiscountInPercentage == false)//flat discount
                        {
                            if (itemPromotion.IsOtherSKURequired == false)//promotion is not depend of other SKU
                            {
                                if (remainingQuntity > 0)
                                {
                                    decimal price = (item.Quntity * item.SKU.Price);
                                    totalPrice = totalPrice + price - (remainingQuntity * itemPromotion.FlatDiscount);
                                }
                                else
                                {
                                    totalPrice = totalPrice + (item.Quntity * item.SKU.Price);
                                }
                            }
                            else
                            {
                                //Depend on other so consider pricing with same item
                                SKUQuntity secondSKU = cartItems.Where(x => x.SKU.Unit.Equals(itemPromotion.OtherSKULookUp)).FirstOrDefault();
                                if (secondSKU != null)
                                {
                                    decimal firstProductPrice = (item.Quntity * item.SKU.Price);
                                    decimal secondProductPrice = (secondSKU.Quntity * secondSKU.SKU.Price);
                                    totalPrice = totalPrice + firstProductPrice + secondProductPrice - itemPromotion.FlatDiscount;
                                    secondSKU.ItemProcessed = true;

                                }
                                else
                                {
                                    totalPrice = totalPrice + (item.Quntity * item.SKU.Price);
                                }
                            }
                        }
                        else
                        {
                            //Same logic can be apply to implement full logic like no of Quntity is required to get percentange discount
                            decimal price = (item.Quntity * item.SKU.Price);
                            totalPrice = totalPrice + price - ((price * itemPromotion.DiscountPercentage) / 100);
                        }
                    }
                    else
                    {
                        totalPrice = totalPrice + (item.Quntity * item.SKU.Price);
                    }
                }
            }
            return totalPrice;
        }
    }
}
