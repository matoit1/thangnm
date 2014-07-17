using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using EntityObject;

namespace DataAccessObject
{
    public class tblCommentDAO : SqlDataProvider
    {
        static SqlCommand cmd;

        public static Boolean Insert(tblCommentEO _tblCommentEO)
        {
            try
            {
                cmd = new SqlCommand("tblComment_Insert", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FK_lTopicID", _tblCommentEO.FK_lTopicID));
                cmd.Parameters.Add(new SqlParameter("@sName", _tblCommentEO.sName));
                cmd.Parameters.Add(new SqlParameter("@sEmail", _tblCommentEO.sEmail));
                cmd.Parameters.Add(new SqlParameter("@sWebsite", _tblCommentEO.sWebsite));
                cmd.Parameters.Add(new SqlParameter("@sContent", _tblCommentEO.sContent));
                cmd.Parameters.Add(new SqlParameter("@bStatus", _tblCommentEO.bStatus));
                cmd.Parameters.Add(new SqlParameter("@tLastUpdate", _tblCommentEO.tLastUpdate));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Update(tblCommentEO _tblCommentEO)
        {
            try
            {
                cmd = new SqlCommand("tblComment_Update", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lComment_ID", _tblCommentEO.PK_lComment_ID));
                cmd.Parameters.Add(new SqlParameter("@FK_lTopicID", _tblCommentEO.FK_lTopicID));
                cmd.Parameters.Add(new SqlParameter("@sName", _tblCommentEO.sName));
                cmd.Parameters.Add(new SqlParameter("@sEmail", _tblCommentEO.sEmail));
                cmd.Parameters.Add(new SqlParameter("@sWebsite", _tblCommentEO.sWebsite));
                cmd.Parameters.Add(new SqlParameter("@sContent", _tblCommentEO.sContent));
                cmd.Parameters.Add(new SqlParameter("@bStatus", _tblCommentEO.bStatus));
                cmd.Parameters.Add(new SqlParameter("@tLastUpdate", _tblCommentEO.tLastUpdate));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Delete(tblCommentEO _tblCommentEO)
        {

            try
            {
                cmd = new SqlCommand("tblComment_Delete", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lComment_ID", _tblCommentEO.PK_lComment_ID));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static tblCommentEO SelectItem(tblCommentEO _tblCommentEO)
        {
            tblCommentEO output = new tblCommentEO();
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblComment_SelectItem", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lComment_ID", _tblCommentEO.PK_lComment_ID));
                return tblCommentDO(GetData(cmd));
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
                cmd = new SqlCommand("tblComment_SelectList", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static DataTable SelectBy_PK_lComment_ID(tblCommentEO _tblCommentEO)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblComment_SelectByPK_lComment_ID", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lComment_ID", _tblCommentEO.PK_lComment_ID));
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static DataTable SelectBy_FK_lTopicID(tblCommentEO _tblCommentEO)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblComment_SelectByFK_lTopicID", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FK_lTopicID", _tblCommentEO.FK_lTopicID));
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static tblCommentEO tblCommentDO(DataTable input)
        {
            tblCommentEO output = new tblCommentEO();
            try
            {
                foreach (DataRow dr in input.Rows)
                {
                    output.PK_lComment_ID = (dr["PK_lComment_ID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["PK_lComment_ID"]);
                    output.FK_lTopicID = (dr["FK_lTopicID"] == DBNull.Value) ? 0 : Convert.ToInt64(dr["FK_lTopicID"]);
                    output.sName = (dr["sName"] == DBNull.Value) ? "" : Convert.ToString(dr["sName"]);
                    output.sEmail = (dr["sEmail"] == DBNull.Value) ? "" : Convert.ToString(dr["sEmail"]);
                    output.sWebsite = (dr["sWebsite"] == DBNull.Value) ? "" : Convert.ToString(dr["sWebsite"]);
                    output.sContent = (dr["sContent"] == DBNull.Value) ? "" : Convert.ToString(dr["sContent"]);
                    output.bStatus = (dr["bStatus"] == DBNull.Value) ? false  : Convert.ToBoolean(dr["bStatus"]);
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