using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    public class ViewMenuItemListCustomer
    {
        public void ViewMenuItemCustomer()
        {
            TruYumContext context = new TruYumContext();
            var query = from menuitem in context.MenuItems
                        where menuitem.dateOfLaunch < DateTime.Now
                        select new
                        {
                            menuitem.Name,
                            menuitem.Price,
                            menuitem.Category,
                            menuitem.Active,
                            menuitem.dateOfLaunch,
                            menuitem.freeDelivery

                        };

            foreach(var item in query.ToList())
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", item.Name, item.Price.ToString() , item.Active.ToString(), item.dateOfLaunch.ToString(), item.freeDelivery.ToString());
            }
        }
    }
}
