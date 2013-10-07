using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityObject;
using System.Data;
using DataAccessObject;

namespace BusinessObject
{
    public class AnswersBO
    {

        //Insert Answers
        public static bool setInsertAnswers(int Customer_ID, Int64 Product_ID, string Supports_Type, string Answers_Content)
        {
            SupportsEO _SupportsEO = new SupportsEO();
            _SupportsEO.Customer_ID = Customer_ID;
            _SupportsEO.Product_ID = Product_ID;
            _SupportsEO.Supports_Type = Supports_Type;
            AnswersEO _AnswersEO = new AnswersEO();
            _AnswersEO.Answers_Content = Answers_Content;
            if (AnswersDAO.InsertAnswers(_SupportsEO, _AnswersEO))
                return true;
            else
                return false;
        }

        //Update Answers
        public static bool setReplySupports(Int64 Answers_ID, Int64 Support_ID, int Staff_ID, string Answers_Question)
        {
            AnswersEO _AnswersEO = new AnswersEO();
            _AnswersEO.Answers_ID = Answers_ID;
            _AnswersEO.Support_ID = Support_ID;
            _AnswersEO.Staff_ID = Staff_ID;
            _AnswersEO.Answers_Question = Answers_Question;
            if (AnswersDAO.ReplySupports(_AnswersEO))
                return true;
            else
                return false;
        }



        //Forward Answers
        public static bool setForwardSupports(Int64 Support_ID, string Answers_Content)
        {
            AnswersEO _AnswersEO = new AnswersEO();
            _AnswersEO.Support_ID = Support_ID;
            _AnswersEO.Answers_Content = Answers_Content;
            if (AnswersDAO.ForwardSupports(_AnswersEO))
                return true;
            else
                return false;
        }



        //Delete Table Answers by Answers_ID
        public static bool setdeleteAnswersbyAnswers_ID(String SupportID)
        {
            if (AnswersDAO.deleteSupportbySupports_ID(SupportID))
                return true;
            else
                return false;
        }


        //Get DataSet New Supports
        public static DataSet getDataSetNewSupports(bool Supports_Status)
        {
            DataSet ds = AnswersDAO.DataSetNewSupports(Supports_Status);
            return ds;
        }


        //Begin Get DataSet Supports by Supports_ID And Answers_ID
        public static DataSet getDataSetSupportsbySupports_ID(Int64 Supports_ID)
        {
            return AnswersDAO.DataSetSupportsbySupports_ID(Supports_ID);
        }


        //Begin Get DataSet Supports by Customer_ID And Supports_Status
        public static DataSet getDataSetSupportsbyCustomer_IDandSupports_Status(int Customer_ID, bool Supports_Status)
        {
            return AnswersDAO.DataSetSupportsbyCustomer_IDandSupports_Status(Customer_ID, Supports_Status);
        }



        //Get DataSet Search Supports by Supports_Type
        public static DataSet getDataSetSearchAccountsbySupports_TypeAndDateTime(string Supports_Type, DateTime Answers_DateTimeBegin, DateTime Answers_DateTimeEnd)
        {
            DataSet ds = AnswersDAO.DataSetSearchAccountsbySupports_TypeAndDateTime(Supports_Type, Answers_DateTimeBegin, Answers_DateTimeEnd);
            return ds;
        }


        //Get DataSet Search Supports by Supports_Type And DateTime
        public static DataSet getDataSetSearchAccountsbySupports_Type(bool Supports_Status, string Supports_Type, string Accounts_Username, string Products_Name, DateTime Answers_DateTimeA1, DateTime Answers_DateTimeA2)
        {
            DataSet ds = AnswersDAO.DataSetSearchAccountsbySupports_Type(Supports_Status, Supports_Type, Accounts_Username, Products_Name, Answers_DateTimeA1, Answers_DateTimeA2);
            return ds;
        }

        ////Begin Get DataSet Supports by Customer_IDAll
        //public static DataSet getDataSetSupportsbyCustomer_IDandSupports_Status(int Customer_ID, bool Supports_Status)
        //{
        //    return AnswersDAO.DataSetSupportsbyCustomer_IDandSupports_Status(Customer_ID, Supports_Status);
        //}


        ////Begin Get DataSet Supports by Customer_ID
        //public static DataSet getDataSetSupportsbyCustomer_ID(int Customer_ID, bool Answers_Status)
        //{
        //    return AnswersDAO.DataSetSupportsbyCustomer_ID(Customer_ID, Answers_Status);
        //}
    }
}
