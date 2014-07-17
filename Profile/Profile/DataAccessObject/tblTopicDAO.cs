using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using EntityObject;

namespace DataAccessObject
{
    public class tblTopicDAO : SqlDataProvider
    {
        static SqlCommand cmd;

        public static Boolean Insert(tblTopicEO _tblTopicEO)
        {
            try
            {
                cmd = new SqlCommand("tblTopic_Insert", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FK_iCategoryID", _tblTopicEO.FK_iCategoryID));
                cmd.Parameters.Add(new SqlParameter("@FK_iAccountsID", _tblTopicEO.FK_iAccountsID));
                cmd.Parameters.Add(new SqlParameter("@sTitle", _tblTopicEO.sTitle));
                cmd.Parameters.Add(new SqlParameter("@sLinkImage", _tblTopicEO.sLinkImage));
                cmd.Parameters.Add(new SqlParameter("@sContent", _tblTopicEO.sContent));
                cmd.Parameters.Add(new SqlParameter("@sDescription", _tblTopicEO.sDescription));
                cmd.Parameters.Add(new SqlParameter("@iVisit", _tblTopicEO.iVisit));
                cmd.Parameters.Add(new SqlParameter("@iLike", _tblTopicEO.iLike));
                cmd.Parameters.Add(new SqlParameter("@iStatus", _tblTopicEO.iStatus));
                cmd.Parameters.Add(new SqlParameter("@tLastUpdate", _tblTopicEO.tLastUpdate));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Update(tblTopicEO _tblTopicEO)
        {
            try
            {
                cmd = new SqlCommand("tblTopic_Update", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lTopicID", _tblTopicEO.PK_lTopicID));
                cmd.Parameters.Add(new SqlParameter("@FK_iCategoryID", _tblTopicEO.FK_iCategoryID));
                cmd.Parameters.Add(new SqlParameter("@FK_iAccountsID", _tblTopicEO.FK_iAccountsID));
                cmd.Parameters.Add(new SqlParameter("@sTitle", _tblTopicEO.sTitle));
                cmd.Parameters.Add(new SqlParameter("@sLinkImage", _tblTopicEO.sLinkImage));
                cmd.Parameters.Add(new SqlParameter("@sContent", _tblTopicEO.sContent));
                cmd.Parameters.Add(new SqlParameter("@sDescription", _tblTopicEO.sDescription));
                cmd.Parameters.Add(new SqlParameter("@iVisit", _tblTopicEO.iVisit));
                cmd.Parameters.Add(new SqlParameter("@iLike", _tblTopicEO.iLike));
                cmd.Parameters.Add(new SqlParameter("@iStatus", _tblTopicEO.iStatus));
                cmd.Parameters.Add(new SqlParameter("@tLastUpdate", _tblTopicEO.tLastUpdate));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Update_iVisit_Or_iLike(tblTopicEO _tblTopicEO)
        {
            try
            {
                cmd = new SqlCommand("tblTopic_Update_iVisit_Or_iLike", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lTopicID", _tblTopicEO.PK_lTopicID));
                cmd.Parameters.Add(new SqlParameter("@iVisit", ((_tblTopicEO.iVisit == 0) ? (object)DBNull.Value : _tblTopicEO.iVisit)));
                cmd.Parameters.Add(new SqlParameter("@iLike", ((_tblTopicEO.iLike == 0) ? (object)DBNull.Value : _tblTopicEO.iLike)));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Delete(tblTopicEO _tblTopicEO)
        {

            try
            {
                cmd = new SqlCommand("tblTopic_Delete", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lTopicID", _tblTopicEO.PK_lTopicID));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static tblTopicEO SelectItem(tblTopicEO _tblTopicEO)
        {
            tblTopicEO output = new tblTopicEO();
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblTopic_SelectItem", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lTopicID", _tblTopicEO.PK_lTopicID));
                return tblTopicDO(GetData(cmd));
            }
            catch (Exception)
            {
                return output;
            }
        }

        public static DataTable SelectList()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblTopic_SelectList", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static DataTable SelectBy_PK_lTopicID(tblTopicEO _tblTopicEO)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblTopic_SelectByPK_lTopicID", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lTopicID", _tblTopicEO.PK_lTopicID));
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static DataTable SelectBy_FK_iCategoryID(tblTopicEO _tblTopicEO)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblTopic_SelectByFK_iCategoryID", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FK_iCategoryID", _tblTopicEO.FK_iCategoryID));
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static DataTable SelectBy_FK_iAccountsID(tblTopicEO _tblTopicEO)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblTopic_SelectByFK_iAccountsID", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FK_iAccountsID", _tblTopicEO.FK_iAccountsID));
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static tblTopicEO tblTopicDO(DataTable input)
        {
            tblTopicEO output = new tblTopicEO();
            try
            {
                foreach (DataRow dr in input.Rows)
                {
                    output.PK_lTopicID = (dr["PK_lTopicID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["PK_lTopicID"]);
                    output.FK_iCategoryID = (dr["FK_iCategoryID"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["FK_iCategoryID"]);
                    output.FK_iAccountsID = (dr["FK_iAccountsID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["FK_iAccountsID"]);
                    output.sTitle = (dr["sTitle"] == DBNull.Value) ? "" : Convert.ToString(dr["sTitle"]);
                    output.sLinkImage = (dr["sLinkImage"] == DBNull.Value) ? "" : Convert.ToString(dr["sLinkImage"]);
                    output.sContent = (dr["sContent"] == DBNull.Value) ? "" : Convert.ToString(dr["sContent"]);
                    output.sDescription = (dr["sDescription"] == DBNull.Value) ? "" : Convert.ToString(dr["sDescription"]);
                    output.iVisit = (dr["iVisit"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["iVisit"]);
                    output.iLike = (dr["iLike"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["iLike"]);
                    output.iStatus = (dr["iStatus"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iStatus"]);
                    output.tLastUpdate = (dr["tLastUpdate"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dr["tLastUpdate"]);
                }
                return output;
            }
            catch
            {
                return output;
            }
        }
    }
}