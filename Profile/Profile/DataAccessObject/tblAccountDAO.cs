using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using EntityObject;

namespace DataAccessObject
{
    public class tblAccountDAO : SqlDataProvider
    {
        static SqlCommand cmd;

        public static Boolean Insert(tblAccountEO _tblAccountEO)
        {
            try
            {
                cmd = new SqlCommand("tblAccount_Insert", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@sUsername", _tblAccountEO.sUsername));
                cmd.Parameters.Add(new SqlParameter("@sPassword", _tblAccountEO.sPassword));
                cmd.Parameters.Add(new SqlParameter("@sEmail", _tblAccountEO.sEmail));
                cmd.Parameters.Add(new SqlParameter("@sFullName", _tblAccountEO.sFullName));
                cmd.Parameters.Add(new SqlParameter("@sAddress", _tblAccountEO.sAddress));
                cmd.Parameters.Add(new SqlParameter("@tDateOfBirth", _tblAccountEO.tDateOfBirth));
                cmd.Parameters.Add(new SqlParameter("@sPhoneNumber", _tblAccountEO.sPhoneNumber));
                cmd.Parameters.Add(new SqlParameter("@iPermission", _tblAccountEO.iPermission));
                cmd.Parameters.Add(new SqlParameter("@sLinkAvatar", _tblAccountEO.sLinkAvatar));
                cmd.Parameters.Add(new SqlParameter("@sSignature", _tblAccountEO.sSignature));
                cmd.Parameters.Add(new SqlParameter("@iAlias", _tblAccountEO.iAlias));
                cmd.Parameters.Add(new SqlParameter("@bNotification", _tblAccountEO.bNotification));
                cmd.Parameters.Add(new SqlParameter("@iStatus", _tblAccountEO.iStatus));
                cmd.Parameters.Add(new SqlParameter("@tRegisterDate", _tblAccountEO.tRegisterDate));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Update(tblAccountEO _tblAccountEO)
        {
            try
            {
                cmd = new SqlCommand("tblAccount_Update", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iAccountsID", _tblAccountEO.PK_iAccountsID));
                cmd.Parameters.Add(new SqlParameter("@sUsername", _tblAccountEO.sUsername));
                cmd.Parameters.Add(new SqlParameter("@sPassword", _tblAccountEO.sPassword));
                cmd.Parameters.Add(new SqlParameter("@sEmail", _tblAccountEO.sEmail));
                cmd.Parameters.Add(new SqlParameter("@sFullName", _tblAccountEO.sFullName));
                cmd.Parameters.Add(new SqlParameter("@sAddress", _tblAccountEO.sAddress));
                cmd.Parameters.Add(new SqlParameter("@tDateOfBirth", _tblAccountEO.tDateOfBirth));
                cmd.Parameters.Add(new SqlParameter("@sPhoneNumber", _tblAccountEO.sPhoneNumber));
                cmd.Parameters.Add(new SqlParameter("@iPermission", _tblAccountEO.iPermission));
                cmd.Parameters.Add(new SqlParameter("@sLinkAvatar", _tblAccountEO.sLinkAvatar));
                cmd.Parameters.Add(new SqlParameter("@sSignature", _tblAccountEO.sSignature));
                cmd.Parameters.Add(new SqlParameter("@iAlias", _tblAccountEO.iAlias));
                cmd.Parameters.Add(new SqlParameter("@bNotification", _tblAccountEO.bNotification));
                cmd.Parameters.Add(new SqlParameter("@iStatus", _tblAccountEO.iStatus));
                cmd.Parameters.Add(new SqlParameter("@tRegisterDate", _tblAccountEO.tRegisterDate));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Boolean Delete(tblAccountEO _tblAccountEO)
        {

            try
            {
                cmd = new SqlCommand("tblAccount_Delete", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iAccountsID", _tblAccountEO.PK_iAccountsID));
                ExecuteNonQuery(cmd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static tblAccountEO SelectItem(tblAccountEO _tblAccountEO)
        {
            tblAccountEO output = new tblAccountEO();
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblAccount_SelectItem", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iAccountsID", _tblAccountEO.PK_iAccountsID));
                return tblAccountDO(GetData(cmd));
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
                cmd = new SqlCommand("tblAccount_SelectList", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static DataTable SelectBy_PK_iAccountsID(tblAccountEO _tblAccountEO)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("tblAccount_SelectBy_PK_iAccountsID", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PK_iAccountsID", _tblAccountEO.PK_iAccountsID));
                return GetData(cmd);
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public static tblAccountEO tblAccountDO(DataTable input)
        {
            tblAccountEO output = new tblAccountEO();
            try
            {
                foreach (DataRow dr in input.Rows)
                {
                    output.PK_iAccountsID = (dr["PK_iAccountsID"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["PK_iAccountsID"]);
                    output.sUsername = (dr["sUsername"] == DBNull.Value) ? "" : Convert.ToString(dr["sUsername"]);
                    output.sPassword = (dr["sPassword"] == DBNull.Value) ? "" : Convert.ToString(dr["sPassword"]);
                    output.sEmail = (dr["sEmail"] == DBNull.Value) ? "" : Convert.ToString(dr["sEmail"]);
                    output.sFullName = (dr["sFullName"] == DBNull.Value) ? "" : Convert.ToString(dr["sFullName"]);
                    output.sAddress = (dr["sAddress"] == DBNull.Value) ? "" : Convert.ToString(dr["sAddress"]);
                    output.tDateOfBirth = (dr["tDateOfBirth"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dr["tDateOfBirth"]);
                    output.sPhoneNumber = (dr["sPhoneNumber"] == DBNull.Value) ? "" : Convert.ToString(dr["sPhoneNumber"]);
                    output.iPermission = (dr["iPermission"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iPermission"]);
                    output.sLinkAvatar = (dr["sLinkAvatar"] == DBNull.Value) ? "" : Convert.ToString(dr["sLinkAvatar"]);
                    output.sSignature = (dr["sSignature"] == DBNull.Value) ? "" : Convert.ToString(dr["sSignature"]);
                    output.iAlias = (dr["iAlias"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iAlias"]);
                    output.bNotification = (dr["bNotification"] == DBNull.Value) ? false : Convert.ToBoolean(dr["bNotification"]);
                    output.iStatus = (dr["iStatus"] == DBNull.Value) ? Convert.ToInt16(0) : Convert.ToInt16(dr["iStatus"]);
                    output.tRegisterDate = (dr["tRegisterDate"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dr["tRegisterDate"]);
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