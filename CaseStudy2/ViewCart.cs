using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    public class ViewCart
    {
        public void ViewCartItems()
        {
            TruYumContext context = new TruYumContext();
            var Query = from cart in context.Carts.Include(m => m.MenuItem)
                        where cart.userId == 1
                        select cart;
            if(Query==null)
            {
                Console.WriteLine("No Items in Cart");
                return;
            }
            else
            {
                foreach(var item in Query.ToList())
                {
                    Console.WriteLine("{0} {1}", item.userId, item.MenuItem.Name);
                }
            }

        }
    }
}
