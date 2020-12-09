using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    public class EditMenuItemList
    {
        public void EditMenuItem(string menuItemName)
        {
            TruYumContext context = new TruYumContext();
            var query = from menuItem in context.MenuItems
                        where menuItem.Name == menuItemName
                        select menuItem;
            if(query==null)
            {
                Console.WriteLine("Incorrect menu item.Please check");
                return;
            }
            else
            {
                foreach(var item in query.ToList())
                {
                    Console.WriteLine("{0} {1} {2}", item.Name, item.Price.ToString(), item.Category.Name.ToString());
                    Boolean editparameter = true;
                    while (editparameter)
                    {
                        if(item.Name==null || item.Name==" ")
                        {
                            Console.WriteLine("Incorrect name.Please provide valid name");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Enter a price to check");
                            double price = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter a Category to check");
                            string category = Console.ReadLine();
                            if(item.Price==price && item.Category.Name==category)
                            {
                                Console.WriteLine("All Data is Correct");
                                Console.WriteLine("Enter the Price To change");
                                double price2 = double.Parse(Console.ReadLine());
                                item.Price = price2;
                                editparameter = false;
                                Console.WriteLine("Data is saved .Here is the Updated data");
                                context.SaveChanges();
                                ViewMenuItemListAdmin v = new ViewMenuItemListAdmin();
                                v.ViewMenuItemAdmin();
                            }
                            else
                            {
                                Console.WriteLine("Incorrect category. Please reenter data");
                            }
                        }
                    }
                }
                
            }
        }
    }
}
