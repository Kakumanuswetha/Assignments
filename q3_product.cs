using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int product_id, quantity;
            double unit_price, total_amount, discount_amount, final_amount;
            string product_name;
            Console.WriteLine("Enter Product Id:");
            product_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name:");
            product_name = Console.ReadLine();
            Console.WriteLine("Enter Per Unit Price:");
            unit_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());
            total_amount = unit_price * quantity;
            if (quantity > 50)
            {
                discount_amount = total_amount * 0.5;
            }
            else if (quantity > 30)
            {
                discount_amount = total_amount * 0.2;
            }
            else if (quantity > 10)
            {
                discount_amount = total_amount * 0.1;
            }
            else
            {
                discount_amount = 0;
            }
            final_amount = total_amount - discount_amount;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Product Id : {0}\nProduct Name : {1}\nUnit Price : {2}\nQuantity : {3}\nTotal Amount : {4}\nDiscount Amount : {5}\nFinal Amount : {6}", product_id, product_name, unit_price, quantity, total_amount, discount_amount, final_amount);
            Console.ReadLine();



        }
    }
}
