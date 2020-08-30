using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin");
            

            //List<char> shoppingCart = new List<char>() { 'A', 'B' ,'C'};
            //List<char> shoppingCart = new List<char>() { 'C', 'D' };
            //List<char> shoppingCart = new List<char>() { 'D', 'C' };
            //List<char> shoppingCart = new List<char>() { 'A', 'B', 'C','A' };
            //List<char> shoppingCart = new List<char>() { 'A', 'B', 'A', 'A','A' };
            //List<char> shoppingCart = new List<char>() { 'A', 'A', 'A', 'B', 'B','B','B','B','C','D' };

            //List<char> shoppingCart = new List<char>() { 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'D', 'C' };
            List<char> shoppingCart = new List<char>() { 'A', 'A', 'A','A', 'A', 'B', 'B','B','B','B','C' };
            PromotionEngineCalculator _PromotionEngineCalculator = new PromotionEngineCalculator();
            decimal totalPrice = _PromotionEngineCalculator.CalculateTotalPrice(shoppingCart);
            Console.WriteLine("Final Bill: " + totalPrice.ToString());
            Console.ReadLine();

        }

        
    }
}
