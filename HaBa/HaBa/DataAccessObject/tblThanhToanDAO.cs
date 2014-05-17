using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HaBa.EntityObject;
using System.Data;

namespace HaBa.DataAccessObject
{
    public class tblThanhToanDAO
    {
        #region "CheckExists"
        
        #endregion

        #region "Insert, Update, Delete"
        /// <summary> 2. ThanhToan_Insert </summary>
        /// <param name="_tblThanhToanEO"></param>
        /// <returns></returns>
        public static bool ThanhToan_Insert(tblThanhToanEO _tblThanhToanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblThanhToan_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTenThanhToan", _tblThanhToanEO.sTenThanhToan));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblThanhToanEO.iTrangThai));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }

        /// <summary> 3. ThanhToan_Update </summary>
        /// <param name="_tblThanhToanEO"></param>
        /// <returns></returns>
        public static bool ThanhToan_Update(tblThanhToanEO _tblThanhToanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblThanhToan_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iThanhToanID", _tblThanhToanEO.PK_iThanhToanID));
                    cmd.Parameters.Add(new SqlParameter("@sTenThanhToan", _tblThanhToanEO.sTenThanhToan));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _tblThanhToanEO.iTrangThai));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }

        /// <summary> 4. ThanhToan_Delete </summary>
        /// <param name="_tblThanhToanEO"></param>
        /// <returns></returns>
        public static bool ThanhToan_Delete(tblThanhToanEO _tblThanhToanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblThanhToan_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iThanhToanID", _tblThanhToanEO.PK_iThanhToanID));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }

        /// <summary> 5. ThanhToan_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool ThanhToan_DeleteList(String _ListPK_iThanhToanID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblThanhToan_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_iThanhToanID", _ListPK_iThanhToanID));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception)
                {
                    conn.Close();
                    return false;
                }
            }
        }
        #endregion

        #region "Select"
        /// <summary> 6. ThanhToan_SelectItem </summary>
        /// <param name="_tblThanhToanEO"></param>
        /// <returns></returns>
        public static tblThanhToanEO ThanhToan_SelectItem(tblThanhToanEO _tblThanhToanEO)
        {
            tblThanhToanEO oOutput = new tblThanhToanEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblThanhToan_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iThanhToanID", _tblThanhToanEO.PK_iThanhToanID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.ThanhToanDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        /// <summary> 6. ThanhToan_SelectItemByPK_iThanhToanID </summary>
        /// <param name="_tblThanhToanEO"></param>
        /// <returns></returns>
        public static tblThanhToanEO ThanhToan_SelectItemByPK_iThanhToanID(Int16 _PK_iThanhToanID)
        {
            tblThanhToanEO oOutput = new tblThanhToanEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblThanhToan_SelectItemByPK_iThanhToanID", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iThanhToanID", _PK_iThanhToanID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.ThanhToanDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. ThanhToan_SelectList </summary>
        /// <param name="_tblThanhToanEO"></param>
        /// <returns></returns>
        public static DataSet ThanhToan_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblThanhToan_SelectList", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dsOutput = new DataSet();
                    da.Fill(dsOutput);
                    conn.Close();
                    return dsOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return dsOutput;
                }
            }
        }

        /// <summary> 9. ThanhToan_Search </summary>
        /// <param name="_tblThanhToanEO"></param>
        /// <returns></returns>
        public static DataSet ThanhToan_Search(tblThanhToanEO _tblThanhToanEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblThanhToan_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iThanhToanID", _tblThanhToanEO.PK_iThanhToanID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenThanhToan", _tblThanhToanEO.sTenThanhToan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _tblThanhToanEO.iTrangThai));
                    dsOutput = new DataSet();
                    da.Fill(dsOutput);
                    conn.Close();
                    return dsOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return dsOutput;
                }
            }
        }
        #endregion
    }
}