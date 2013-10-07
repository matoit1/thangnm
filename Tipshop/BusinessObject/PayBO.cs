using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityObject;
using System.Data;
using DataAccessObject;

namespace BusinessObject
{
    public class PayBO
    {
        //Insert Pay
        public static bool setInsertPay(string Pay_Name, bool Pay_Visible)
        {
            PayEO _PayEO = new PayEO();
            _PayEO.Pay_Name = Pay_Name;
            _PayEO.Pay_Visible = Pay_Visible;
            if (PayDAO.InsertPay(_PayEO))
                return true;
            else
                return false;
        }

        //Update Pay
        public static bool setUpdatePay(int Pay_ID, string Pay_Name, bool Pay_Visible)
        {
            PayEO _PayEO = new PayEO();
            _PayEO.Pay_ID = Pay_ID;
            _PayEO.Pay_Name = Pay_Name;
            _PayEO.Pay_Visible = Pay_Visible;
            if (PayDAO.UpdatePay(_PayEO))
                return true;
            else
                return false;
        }

        //Delete Pay
        public static bool setDeletePay(string Pay_ID)
        {
            if (PayDAO.deletePay(Pay_ID))
                return true;
            else
                return false;
        }

        //Get DataSet Pay Method
        public static DataSet getDataSetPaybyPay_Visible(bool Pay_Visible)
        {
            DataSet ds = PayDAO.DataSetPaybyPay_Visible(Pay_Visible);
            return ds;
        }

        //getDataSetPaybyID
        public static DataSet getDataSetPaybyPay_ID(int Pay_ID)
        {
            DataSet ds = PayDAO.DataSetPaybyPay_ID(Pay_ID);
            return ds;
        }

        //Get DataSet Pay
        public static DataSet getDataSetPay()
        {
            DataSet ds = PayDAO.DataSetPay();
            return ds;
        }
    }
}
