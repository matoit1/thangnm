using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using HaMy.EntityObject;
using System.Data;

namespace HaMy.DataAccessObject
{
    public class tblNhomDAO
    {
        #region "CheckExists"
        
        #endregion

        #region "Insert, Update, Delete"
        /// <summary> 2. Nhom_Insert </summary>
        /// <param name="_tblNhomEO"></param>
        /// <returns></returns>
        public static bool Nhom_Insert(tblNhomEO _tblNhomEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNhom_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTenNhom", _tblNhomEO.sTenNhom));
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

        /// <summary> 3. Nhom_Update </summary>
        /// <param name="_tblNhomEO"></param>
        /// <returns></returns>
        public static bool Nhom_Update(tblNhomEO _tblNhomEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNhom_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iNhom", _tblNhomEO.PK_iNhom));
                    cmd.Parameters.Add(new SqlParameter("@sTenNhom", _tblNhomEO.sTenNhom));
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

        /// <summary> 4. Nhom_Delete </summary>
        /// <param name="_tblNhomEO"></param>
        /// <returns></returns>
        public static bool Nhom_Delete(tblNhomEO _tblNhomEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNhom_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iNhom", _tblNhomEO.PK_iNhom));
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

        /// <summary> 5. Nhom_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool Nhom_DeleteList(String _ListPK_iNhom)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblNhom_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_iNhom", _ListPK_iNhom));
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
        /// <summary> 6. Nhom_SelectItem </summary>
        /// <param name="_tblNhomEO"></param>
        /// <returns></returns>
        public static tblNhomEO Nhom_SelectItem(tblNhomEO _tblNhomEO)
        {
            tblNhomEO oOutput = new tblNhomEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNhom_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iNhom", _tblNhomEO.PK_iNhom));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.NhomDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        /// <summary> 6. Nhom_SelectItemByPK_iNhomID </summary>
        /// <param name="_tblNhomEO"></param>
        /// <returns></returns>
        public static tblNhomEO Nhom_SelectItemByPK_iNhom(Int16 _PK_iNhom)
        {
            tblNhomEO oOutput = new tblNhomEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNhom_SelectItemByPK_iNhom", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iNhom", _PK_iNhom));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.NhomDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. Nhom_SelectList </summary>
        /// <param name="_tblNhomEO"></param>
        /// <returns></returns>
        public static DataSet Nhom_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNhom_SelectList", conn);
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

        /// <summary> 9. Nhom_Search </summary>
        /// <param name="_tblNhomEO"></param>
        /// <returns></returns>
        public static DataSet Nhom_Search(tblNhomEO _tblNhomEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblNhom_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iNhom", _tblNhomEO.PK_iNhom));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenNhom", _tblNhomEO.sTenNhom));
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