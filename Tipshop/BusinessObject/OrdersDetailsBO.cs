using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityObject;
using System.Data;
using DataAccessObject;
namespace BusinessObject
{
    public class OrdersDetailsBO
    {
        //1. set Insert Orders Details
        public static bool setInsertOrdersDetails(Int64 Orders_ID, Int64 Pro_ID, Int64 OrdersDetails_UnitPrice, int OrdersDetails_Quantity)
        {
            OrdersDetailsEO _OrdersDetailsEO = new OrdersDetailsEO();
            _OrdersDetailsEO.Orders_ID = Orders_ID;
            _OrdersDetailsEO.Pro_ID = Pro_ID;
            _OrdersDetailsEO.OrdersDetails_UnitPrice = OrdersDetails_UnitPrice;
            _OrdersDetailsEO.OrdersDetails_Quantity = OrdersDetails_Quantity;
            if (OrdersDetailsDAO.InsertOrdersDetails(_OrdersDetailsEO))
                return true;
            else
                return false;
        }
    }
}
