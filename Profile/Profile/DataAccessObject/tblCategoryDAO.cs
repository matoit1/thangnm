using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using EntityObject;

namespace DataAccessObject
{
    public class tblCategoryDAO : SqlDataProvider
    {
        static SqlCommand cmd;

        public static Boolean Insert(tblCategoryEO _tblCategoryEO)
        {
            try
            {
                cmd = new SqlCommand("tblCategory_Insert", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iCategoryID", _tblCategoryEO.PK_iCategoryID));
                cmd.Parameters.Add(new SqlParameter("@iParent", _tblCategoryEO.iParent));
                cmd.Parameters.Add(new SqlParameter("@sName", _tblCategoryEO.sName));
                cmd.Parameters.Add(new SqlParameter("@iStatus", _tblCategoryEO.iStatus));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Update(tblCategoryEO _tblCategoryEO)
        {
            try
            {
                cmd = new SqlCommand("tblCategory_Update", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iCategoryID", _tblCategoryEO.PK_iCategoryID));
                cmd.Parameters.Add(new SqlParameter("@iParent", _tblCategoryEO.iParent));
                cmd.Parameters.Add(new SqlParameter("@sName", _tblCategoryEO.sName));
                cmd.Parameters.Add(new SqlParameter("@iStatus", _tblCategoryEO.iStatus));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Delete(tblCategoryEO _tblCategoryEO)
        {

            try
            {
                cmd = new SqlCommand("tblCategory_Delete", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iCategoryID", _tblCategoryEO.PK_iCategoryID));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static tblCategoryEO SelectItem(tblCategoryEO _tblCategoryEO)
        {
            tblCategoryEO output = new tblCategoryEO();
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblCategory_SelectItem", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iCategoryID", _tblCategoryEO.PK_iCategoryID));
                return tblCategoryDO(GetData(cmd));
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
                cmd = new SqlCommand("tblCategory_SelectList", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static DataTable SelectBy_PK_iCategoryID(tblCategoryEO _tblCategoryEO)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblCategory_SelectByPK_iCategoryID", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iCategoryID", _tblCategoryEO.PK_iCategoryID));
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static tblCategoryEO tblCategoryDO(DataTable input)
        {
            tblCategoryEO output = new tblCategoryEO();
            try
            {
                foreach (DataRow dr in input.Rows)
                {
                    output.PK_iCategoryID = (dr["PK_iCategoryID"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["PK_iCategoryID"]);
                    output.iParent = (dr["iParent"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iParent"]);
                    output.sName = (dr["sName"] == DBNull.Value) ? "" : Convert.ToString(dr["sName"]);
                    output.iStatus = (dr["iStatus"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iStatus"]);
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