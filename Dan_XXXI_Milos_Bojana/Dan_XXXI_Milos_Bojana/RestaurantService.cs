using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_XXXI_Milos_Bojana
{
    class RestaurantService
    {
        public List<tblOrder> GetAllOrders()
        {
            
        }


        public tblOrder AddOrder(tblOrder order)
        {
            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    tblOrder newTblOrder = new tblOrder();
                    newTblOrder.Date = order.Date;
                    newTblOrder.MenuItem = order.MenuItem;
                    context.tblOrders.Add(newTblOrder);
                    context.SaveChanges();

                    return order;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }


        public tblOrder EditOrder(tblOrder order)
        {
            
        }

        public void DeleteOrder(int orderId)
        {
            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    tblOrder orderToDelete = (from o in context.tblOrders where o.OrderID == orderId select o).First();
                    context.tblOrders.Remove(orderToDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
            }
        }
    }
}
