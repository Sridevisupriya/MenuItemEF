using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CaseStudy2
{
    public class RemoveItemFromCart
    {
        public void RemoveFromCart(string menuItemName)
        {
            TruYumContext context = new TruYumContext();
            var query = from cart in context.Carts.Include(m => m.MenuItem)
                        where cart.MenuItem.Name == menuItemName
                        select cart;
            if(query==null)
            {
                Console.WriteLine("No item in cart for the user");
                return;
            }
            else
            {
                foreach(var item in query.ToList())
                {
                    Boolean removeparameter = true;
                    while(removeparameter)
                    {
                        if(item.MenuItem.Name==menuItemName)
                        {
                            context.Carts.Remove(item);
                            context.SaveChanges();
                            Console.WriteLine("Menu item removed from cart successfully");
                            removeparameter = false;
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
