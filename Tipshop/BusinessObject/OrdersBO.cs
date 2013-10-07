using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityObject;
using System.Data;
using DataAccessObject;

namespace BusinessObject
{
    public class OrdersBO
    {
        //1. get NewID by Insert Orders
        public OrdersEO getNewIDbyInsertOrders(int _Client_ID, int _Pay_ID, string _Pay_Email, string _Pay_FullName, string _Pay_Address, string _Pay_PhoneNumber, string _Pay_Note, DateTime _Pay_DateOfStart, DateTime _Pay_DateOfFinish)
        {
            OrdersEO _OrdersEO = new OrdersEO();
            _OrdersEO = OrdersDAO.InsertOrders(_Client_ID, _Pay_ID, _Pay_Email, _Pay_FullName, _Pay_Address, _Pay_PhoneNumber, _Pay_Note, _Pay_DateOfStart, _Pay_DateOfFinish);
            return _OrdersEO;
        }

        //Update Orders
        public static bool setUpdateOrders(string Orders_ID, bool Pay_Status)
        {
            if (OrdersDAO.UpdateOrders(Orders_ID, Pay_Status))
                return true;
            else
                return false;
        }

        //Delete Orders
        public static bool setDeleteOrders(string Orders_ID)
        {
            if (OrdersDAO.DeleteOrders(Orders_ID))
                return true;
            else
                return false;
        }

        //Begin get DataSet Orders
        public static DataSet getDataSetOrders(bool Pay_Status)
        {
            return OrdersDAO.DataSetOrders(Pay_Status);
        }

        //Begin get DataSet Orders byClient_ID
        public static DataSet getDataSetOrdersbyClient_ID(bool Pay_Status, string Accounts_Username)
        {
            return OrdersDAO.DataSetOrdersbyClient_ID(Pay_Status, Accounts_Username);
        }

        //Begin get DataSet Orders byClient_ID
        public static DataSet getDataSetOrdersbyOrders_ID(Int64 Orders_ID)
        {
            return OrdersDAO.DataSetOrdersbyOrders_ID(Orders_ID);
        }

        //1. get ThangNMjsc_getSumQuantitybyOrders_ID
        public OrdersEO getSumQuantitybyOrders_ID(Int64 Orders_ID)
        {
            OrdersEO _OrdersEO1 = new OrdersEO();
            _OrdersEO1 = OrdersDAO.SumQuantitybyOrders_ID(Orders_ID);
            return _OrdersEO1;
        }
    }
}
