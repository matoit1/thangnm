using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using HaMy.EntityObject;

namespace HaMy.DataAccessObject
{
    public class tblMoiQuanHeDAO
    {
        #region "CheckExists"
        /// <summary> 1. MoiQuanHe_CheckExists </summary>
        /// <param name="_tblMoiQuanHeEO"></param>
        /// <returns></returns>
        public static bool MoiQuanHe_CheckExists(tblMoiQuanHeEO _tblMoiQuanHeEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMoiQuanHe_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iMoiQuanHe", _tblMoiQuanHeEO.PK_iMoiQuanHe));
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        bOutput = Convert.ToBoolean(dr["return_value"]);
                    }
                    conn.Close();
                    return bOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return bOutput;
                }
            }
        }
        #endregion

        #region "Insert, Update, Delete"
        /// <summary> 2. MoiQuanHe_Insert </summary>
        /// <param name="_tblMoiQuanHeEO"></param>
        /// <returns></returns>
        public static bool MoiQuanHe_Insert(tblMoiQuanHeEO _tblMoiQuanHeEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMoiQuanHe_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTen", _tblMoiQuanHeEO.sTen));
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

        /// <summary> 3. MoiQuanHe_Update </summary>
        /// <param name="_tblMoiQuanHeEO"></param>
        /// <returns></returns>
        public static bool MoiQuanHe_Update(tblMoiQuanHeEO _tblMoiQuanHeEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMoiQuanHe_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iMoiQuanHe", _tblMoiQuanHeEO.PK_iMoiQuanHe));
                    cmd.Parameters.Add(new SqlParameter("@sTen", _tblMoiQuanHeEO.sTen));
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


        /// <summary> 5. MoiQuanHe_Delete </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool MoiQuanHe_Delete(tblMoiQuanHeEO _tblMoiQuanHeEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMoiQuanHe_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_iMoiQuanHe", _tblMoiQuanHeEO.PK_iMoiQuanHe));
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

        
        /// <summary> 5. MoiQuanHe_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool MoiQuanHe_DeleteList(String _ListPK_iMoiQuanHe)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMoiQuanHe_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_iMoiQuanHe", _ListPK_iMoiQuanHe));
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
        /// <summary> 6. MoiQuanHe_SelectItem </summary>
        /// <param name="_tblMoiQuanHeEO"></param>
        /// <returns></returns>
        public static tblMoiQuanHeEO MoiQuanHe_SelectItem(tblMoiQuanHeEO _tblMoiQuanHeEO)
        {
            tblMoiQuanHeEO oOutput = new tblMoiQuanHeEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMoiQuanHe_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iMoiQuanHe", _tblMoiQuanHeEO.PK_iMoiQuanHe));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.MoiQuanHeDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        /// <summary> 6. MoiQuanHe_SelectItem_By_PK_iMoiQuanHeID </summary>
        /// <param name="_tblMoiQuanHeEO"></param>
        /// <returns></returns>
        public static tblMoiQuanHeEO MoiQuanHe_SelectItem_By_PK_iMoiQuanHe(Int32 _PK_iMoiQuanHe)
        {
            tblMoiQuanHeEO oOutput = new tblMoiQuanHeEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMoiQuanHe_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iMoiQuanHe", _PK_iMoiQuanHe));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.MoiQuanHeDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        

        /// <summary> 7. MoiQuanHe_SelectList </summary>
        /// <param name="_tblMoiQuanHeEO"></param>
        /// <returns></returns>
        public static DataSet MoiQuanHe_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMoiQuanHe_SelectList", conn);
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

        /// <summary> 8. MoiQuanHe_SelectListByPK_iMoiQuanHe </summary>
        /// <param name="_tblMoiQuanHeEO"></param>
        /// <returns></returns>
        public static DataSet MoiQuanHe_SelectListBysTen(tblMoiQuanHeEO _tblMoiQuanHeEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMoiQuanHe_SelectListByPK_iMoiQuanHe", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iMoiQuanHe", _tblMoiQuanHeEO.PK_iMoiQuanHe));
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

        


        /// <summary> 10. MoiQuanHe_Search </summary>
        /// <param name="_tblMoiQuanHeEO"></param>
        /// <returns></returns>
        public static DataSet MoiQuanHe_Search(tblMoiQuanHeEO _tblMoiQuanHeEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMoiQuanHe_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_iMoiQuanHe", _tblMoiQuanHeEO.PK_iMoiQuanHe));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTen", _tblMoiQuanHeEO.sTen));
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