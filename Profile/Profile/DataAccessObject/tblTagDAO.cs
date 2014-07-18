using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using EntityObject;

namespace DataAccessObject
{
    public class tblTagDAO : SqlDataProvider
    {
        static SqlCommand cmd;

        public static Boolean Insert(tblTagEO _tblTagEO)
        {
            try
            {
                cmd = new SqlCommand("tblTag_Insert", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_sTagID", _tblTagEO.PK_sTagID));
                cmd.Parameters.Add(new SqlParameter("@FK_lTopicID", _tblTagEO.FK_lTopicID));
                cmd.Parameters.Add(new SqlParameter("@sName", _tblTagEO.sName));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Update(tblTagEO _tblTagEO)
        {
            try
            {
                cmd = new SqlCommand("tblTag_Update", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_sTagID", _tblTagEO.PK_sTagID));
                cmd.Parameters.Add(new SqlParameter("@FK_lTopicID", _tblTagEO.FK_lTopicID));
                cmd.Parameters.Add(new SqlParameter("@sName", _tblTagEO.sName));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Delete(tblTagEO _tblTagEO)
        {

            try
            {
                cmd = new SqlCommand("tblTag_Delete", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_sTagID", _tblTagEO.PK_sTagID));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static tblTagEO SelectItem(tblTagEO _tblTagEO)
        {
            tblTagEO output = new tblTagEO();
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblTag_SelectItem", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_sTagID", _tblTagEO.PK_sTagID));
                return tblTagDO(GetData(cmd));
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
                cmd = new SqlCommand("tblTag_SelectList", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static DataTable SelectBy_PK_sTagID(tblTagEO _tblTagEO)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblTag_SelectBy_PK_sTagID", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_sTagID", _tblTagEO.PK_sTagID));
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static DataTable SelectBy_FK_lTopicID(tblTagEO _tblTagEO)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblTag_SelectBy_FK_lTopicID", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FK_lTopicID", _tblTagEO.FK_lTopicID));
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static tblTagEO tblTagDO(DataTable input)
        {
            tblTagEO output = new tblTagEO();
            try
            {
                foreach (DataRow dr in input.Rows)
                {
                    output.PK_sTagID = (dr["PK_sTagID"] == DBNull.Value) ? "" : Convert.ToString(dr["PK_sTagID"]);
                    output.FK_lTopicID = (dr["FK_lTopicID"] == DBNull.Value) ? Convert.ToInt64(0) : Convert.ToInt64(dr["FK_lTopicID"]);
                    output.sName = (dr["sName"] == DBNull.Value) ? "" : Convert.ToString(dr["sName"]);
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