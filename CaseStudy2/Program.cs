using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaseStudy2.Migrations;

namespace CaseStudy2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("There are 2 types of users 1.Admin and 2.Customer");
            int userType = int.Parse(Console.ReadLine());
            //Boolean parameter = true;
            if(userType==1)
            {
                while(true)
                {
                    Console.WriteLine("Enter your choice 1.View 2.Add 3.Edit menuItems");
                    int choice = int.Parse(Console.ReadLine());
                    if(choice==1)
                    {
                        Console.WriteLine("View");
                        ViewMenuItemListAdmin v = new ViewMenuItemListAdmin();
                        v.ViewMenuItemAdmin();
                    }
                    else if(choice==2)
                    {
                        Console.WriteLine("Add");
                        AddMenuItemListAdmin a = new AddMenuItemListAdmin();
                        Console.WriteLine("Name to be added?");
                        string name = Console.ReadLine();
                        Console.WriteLine("Price to be added?");
                        double price = double.Parse(Console.ReadLine());
                        Console.WriteLine("category to be added?");
                        string category = Console.ReadLine();
                        Console.WriteLine("Date of Launch to be added?");
                        DateTime dol = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("is active?");
                        Boolean active = Boolean.Parse(Console.ReadLine());
                        Console.WriteLine("FreeDelivery?");
                        Boolean freeDelivery = Boolean.Parse(Console.ReadLine());

                        a.AddMenuItem(name, category, price, active, dol, freeDelivery);
                    }
                    else if(choice==3)
                    {
                        Console.WriteLine("Edit");
                        Console.WriteLine("Enter any menuitem Name");
                        string name = Console.ReadLine();
                        EditMenuItemList e = new EditMenuItemList();
                        e.EditMenuItem(name);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                while(true)
                {
                    Console.WriteLine("1.View cart item");
                    Console.WriteLine("2.add menu item");
                    Console.WriteLine("3.remove menu item");
                    Console.WriteLine("4.view menu item list");
                    int choice = int.Parse(Console.ReadLine());
                    if(choice==1)
                    {
                        Console.WriteLine("View Cart");
                        ViewCart v = new ViewCart();
                        v.ViewCartItems();
                    }
                    else if(choice==2)
                    {
                        Console.WriteLine("Add menuItem");
                        AddMenuItemToCart a = new AddMenuItemToCart();
                        Console.WriteLine("menuitem name ?");
                        string name = Console.ReadLine();
                        a.AddToCart(name);
                    }
                    else if(choice==3)
                    {
                        Console.WriteLine("Remove item");
                        Console.WriteLine("item name?");
                        string name = Console.ReadLine();
                        RemoveItemFromCart r = new RemoveItemFromCart();
                        r.RemoveFromCart(name);

                    }
                    else if(choice==4)
                    {
                        Console.WriteLine("view menu items");
                        ViewMenuItemListCustomer v = new ViewMenuItemListCustomer();
                        v.ViewMenuItemCustomer();
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
}
