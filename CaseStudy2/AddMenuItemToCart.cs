using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CaseStudy2
{
    public class AddMenuItemToCart
    {
        public void AddToCart(string menuItemName)
        {
            TruYumContext context = new TruYumContext();
            var query = from menuitem in context.MenuItems.Include(m => m.Category)
                        where menuitem.Name == menuItemName
                        select menuitem;
            if (query == null)
            {
                Console.WriteLine("No Records are fetched");
                return;
            }
            else
            {
                foreach (var item in query.ToList())
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", item.Name, item.Price.ToString(), item.dateOfLaunch.ToString(), item.Active.ToString(), item.freeDelivery.ToString());

                    Boolean addparmeter = true;
                    while (addparmeter)
                    {
                        if (item.Name==" " || item.Name==null)
                        {
                            Console.WriteLine("Incorrect menuItem .Please Check");
                            return ;
                        }
                        else
                        {
                            Console.WriteLine("Enter a price to add");
                            double price = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter a categoryName to Check");
                            string categoryName = Console.ReadLine();
                            if((item.Price==price) && (item.Category.Name==categoryName))
                            {
                                int userId = 1;
                                Cart c = new Cart();
                                c.userId = userId;
                                c.menuItemId = item.Id;
                                c.MenuItem = item;
                                context.Carts.Add(c);
                                addparmeter = false;
                                context.SaveChanges();
                                Console.WriteLine("Menu item added to cart successfully");
                                
                            }
                            else
                            {
                                Console.WriteLine("Incorrect menu item name.Please reenter");
                                return;
                            }
                        }
                    }

                }
            }
        }
    }
}
