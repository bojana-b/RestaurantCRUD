using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dan_XXXI_Milos_Bojana
{
    static class Utility
    {
        public static void Create(Restaurant restaurant)
        {
            RestaurantService rs = new RestaurantService();
            tblOrder order = new tblOrder();
            order.MenuItem = restaurant.MenuItem;
            order.Date = restaurant.Date;
            rs.AddOrder(order);
        }

        public static void Delete(int id)
        {
            RestaurantService rs = new RestaurantService();
            rs.DeleteOrder(id);
        }

        public static List<tblOrder> Load()
        {
            List<tblOrder> orderList = new List<tblOrder>();
            RestaurantService rs = new RestaurantService();
            orderList = rs.GetAllOrders().ToList();
            return orderList;
        }

        public static void Update(int id, Restaurant restaurant)
        {
            RestaurantService rs = new RestaurantService();
            tblOrder order = new tblOrder();
            order.OrderID = id;
            order.MenuItem = restaurant.MenuItem;
            order.Date = restaurant.Date;
            rs.EditOrder(order);
        }
    }
}
