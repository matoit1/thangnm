using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using EntityObject;

namespace DataAccessObject
{
    public class tblErrorDAO : SqlDataProvider
    {
        static SqlCommand cmd;

        public static Boolean Insert(tblErrorEO _tblErrorEO)
        {
            try
            {
                cmd = new SqlCommand("tblError_Insert", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@sLink", _tblErrorEO.sLink));
                cmd.Parameters.Add(new SqlParameter("@sIP", _tblErrorEO.sIP));
                cmd.Parameters.Add(new SqlParameter("@sBrowser", _tblErrorEO.sBrowser));
                cmd.Parameters.Add(new SqlParameter("@iCode", _tblErrorEO.iCode));
                cmd.Parameters.Add(new SqlParameter("@iStatus", _tblErrorEO.iStatus));
                cmd.Parameters.Add(new SqlParameter("@tTime", _tblErrorEO.tTime));
                cmd.Parameters.Add(new SqlParameter("@tTimeCheck", _tblErrorEO.tTimeCheck));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Update(tblErrorEO _tblErrorEO)
        {
            try
            {
                cmd = new SqlCommand("tblError_Update", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lErrorID", _tblErrorEO.PK_lErrorID));
                cmd.Parameters.Add(new SqlParameter("@sLink", _tblErrorEO.sLink));
                cmd.Parameters.Add(new SqlParameter("@sIP", _tblErrorEO.sIP));
                cmd.Parameters.Add(new SqlParameter("@sBrowser", _tblErrorEO.sBrowser));
                cmd.Parameters.Add(new SqlParameter("@iCode", _tblErrorEO.iCode));
                cmd.Parameters.Add(new SqlParameter("@iStatus", _tblErrorEO.iStatus));
                cmd.Parameters.Add(new SqlParameter("@tTime", _tblErrorEO.tTime));
                cmd.Parameters.Add(new SqlParameter("@tTimeCheck", _tblErrorEO.tTimeCheck));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Delete(tblErrorEO _tblErrorEO)
        {

            try
            {
                cmd = new SqlCommand("tblError_Delete", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lErrorID", _tblErrorEO.PK_lErrorID));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static tblErrorEO SelectItem(tblErrorEO _tblErrorEO)
        {
            tblErrorEO output = new tblErrorEO();
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblError_SelectItem", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lErrorID", _tblErrorEO.PK_lErrorID));
                return tblErrorDO(GetData(cmd));
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
                cmd = new SqlCommand("tblError_SelectList", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static DataTable SelectBy_PK_lErrorID(tblErrorEO _tblErrorEO)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblError_SelectByPK_lErrorID", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_lErrorID", _tblErrorEO.PK_lErrorID));
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static tblErrorEO tblErrorDO(DataTable input)
        {
            tblErrorEO output = new tblErrorEO();
            try
            {
                foreach (DataRow dr in input.Rows)
                {
                    output.PK_lErrorID = (dr["PK_lErrorID"] == DBNull.Value) ? Convert.ToInt64(0) : Convert.ToInt64(dr["PK_lErrorID"]);
                    output.sLink = (dr["sLink"] == DBNull.Value) ? "" : Convert.ToString(dr["sLink"]);
                    output.sIP = (dr["sIP"] == DBNull.Value) ? "" : Convert.ToString(dr["sIP"]);
                    output.sBrowser = (dr["sBrowser"] == DBNull.Value) ? "" : Convert.ToString(dr["sBrowser"]);
                    output.iCode = (dr["iCode"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["iCode"]);
                    output.iStatus = (dr["iStatus"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iStatus"]);
                    output.tTime = (dr["tTime"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dr["tTime"]);
                    output.tTimeCheck = (dr["tTimeCheck"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dr["tTimeCheck"]);
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