using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_XXXI_Milos_Bojana
{
    class Restaurant
    {
        public int Id { get; set; }
        public string MenuItem { get; set; }
        public DateTime Date { get; set; }

        public Restaurant()
        {

        }

        public Restaurant(string menuItem, DateTime date)
        {
            MenuItem = menuItem;
            Date = date;
        }
    }
}
