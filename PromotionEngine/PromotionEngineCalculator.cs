using PromotionEngine;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PromotionEngineCalculator
    {
        public decimal CalculateTotalPrice(List<char> shoppingCart)
        {
            decimal finalPrice = 0.0M;
            try
            {
                List<SKU> masterSKUList = GetMasterPriceList();
                List<SKUQuntity> skuQuntities = new List<SKUQuntity>();
                CalculatePrice calculatePrice = new CalculatePrice();

                foreach (var item in shoppingCart)
                {
                    SKU tempSKU = masterSKUList.Where(x => x.Unit.ToString().Equals(item.ToString())).FirstOrDefault();
                    if (tempSKU != null)
                    {
                        SKUQuntity tempSKUQuntity = skuQuntities.Where(x => x.SKU.Unit.ToString().Equals(item.ToString())).FirstOrDefault();
                        if (tempSKUQuntity != null)
                        {
                            tempSKUQuntity.Quntity++;
                        }
                        else
                        {
                            tempSKUQuntity = new SKUQuntity();
                            tempSKUQuntity.SKU = tempSKU;
                            tempSKUQuntity.Quntity = 1;
                            skuQuntities.Add(tempSKUQuntity);
                        }
                    }
                }
                finalPrice= calculatePrice.GetShoppingCartPriceList(skuQuntities);
            }
            catch (Exception)
            {
                //Add logging tool
                throw;
            }

            return finalPrice;
        }

        private List<SKU> GetMasterPriceList()
        {
            List<SKU> masterSKUList = new List<SKU>();
            masterSKUList.Add(new SKU() { Unit = 'A', Price = 50 });
            masterSKUList.Add(new SKU() { Unit = 'B', Price = 30 });
            masterSKUList.Add(new SKU() { Unit = 'C', Price = 20 });
            masterSKUList.Add(new SKU() { Unit = 'D', Price = 15 });
            return masterSKUList;
        }
    }
}
