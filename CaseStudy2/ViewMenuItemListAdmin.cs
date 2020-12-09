using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    public class ViewMenuItemListAdmin
    {
        public void ViewMenuItemAdmin()
        {
            TruYumContext context = new TruYumContext();
            var query = from menuitem in context.MenuItems
                        select new
                        {
                            menuitem.Name,
                            menuitem.Price,
                            menuitem.Category,
                            menuitem.dateOfLaunch,
                            menuitem.Active,
                            menuitem.freeDelivery
                        };
            foreach(var item in query.ToList())
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", item.Name, item.Price.ToString(), item.dateOfLaunch.ToString(), item.Active.ToString(), item.freeDelivery.ToString());
            }

        }
    }
}
