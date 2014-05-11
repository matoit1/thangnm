using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using HaBa.EntityObject;

namespace HaBa.DataAccessObject
{
    public class tblSanPhamDAO
    {
        #region "CheckExists"
        /// <summary> 1. Product_CheckExists_PK_lProductID </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static bool Product_CheckExists_PK_lProductID(tblSanPhamEO _tblSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblProduct_CheckExists_PK_lProductID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lProductID", _tblSanPhamEO.PK_lProductID));
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
        /// <summary> 2. Product_Insert </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static bool Product_Insert(tblSanPhamEO _tblSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblProduct_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lProductID", _tblSanPhamEO.PK_lProductID));
                    cmd.Parameters.Add(new SqlParameter("@lGroup", _tblSanPhamEO.lGroup));
                    cmd.Parameters.Add(new SqlParameter("@lParent", _tblSanPhamEO.lParent));
                    cmd.Parameters.Add(new SqlParameter("@sName", _tblSanPhamEO.sName));
                    cmd.Parameters.Add(new SqlParameter("@lPrice", _tblSanPhamEO.lPrice));
                    cmd.Parameters.Add(new SqlParameter("@lSale", _tblSanPhamEO.lSale));
                    cmd.Parameters.Add(new SqlParameter("@bVAT", _tblSanPhamEO.bVAT));
                    cmd.Parameters.Add(new SqlParameter("@sDescription", _tblSanPhamEO.sDescription));
                    cmd.Parameters.Add(new SqlParameter("@sInfomation", _tblSanPhamEO.sInfomation));
                    cmd.Parameters.Add(new SqlParameter("@sOrigin", _tblSanPhamEO.sOrigin));
                    cmd.Parameters.Add(new SqlParameter("@iQuantity", _tblSanPhamEO.iQuantity));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImage", _tblSanPhamEO.sLinkImage));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImageThumbnail", _tblSanPhamEO.sLinkImageThumbnail));
                    cmd.Parameters.Add(new SqlParameter("@tLastUpdate", _tblSanPhamEO.tLastUpdate));
                    cmd.Parameters.Add(new SqlParameter("@bStatus", _tblSanPhamEO.bStatus));
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

        /// <summary> 3. Product_Update </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static bool Product_Update(tblSanPhamEO _tblSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblProduct_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lProductID", _tblSanPhamEO.PK_lProductID));
                    cmd.Parameters.Add(new SqlParameter("@lGroup", _tblSanPhamEO.lGroup));
                    cmd.Parameters.Add(new SqlParameter("@lParent", _tblSanPhamEO.lParent));
                    cmd.Parameters.Add(new SqlParameter("@sName", _tblSanPhamEO.sName));
                    cmd.Parameters.Add(new SqlParameter("@lPrice", _tblSanPhamEO.lPrice));
                    cmd.Parameters.Add(new SqlParameter("@lSale", _tblSanPhamEO.lSale));
                    cmd.Parameters.Add(new SqlParameter("@bVAT", _tblSanPhamEO.bVAT));
                    cmd.Parameters.Add(new SqlParameter("@sDescription", _tblSanPhamEO.sDescription));
                    cmd.Parameters.Add(new SqlParameter("@sInfomation", _tblSanPhamEO.sInfomation));
                    cmd.Parameters.Add(new SqlParameter("@sOrigin", _tblSanPhamEO.sOrigin));
                    cmd.Parameters.Add(new SqlParameter("@iQuantity", _tblSanPhamEO.iQuantity));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImage", _tblSanPhamEO.sLinkImage));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImage1", _tblSanPhamEO.sLinkImageThumbnail));
                    cmd.Parameters.Add(new SqlParameter("@tLastUpdate", _tblSanPhamEO.tLastUpdate));
                    cmd.Parameters.Add(new SqlParameter("@bStatus", _tblSanPhamEO.bStatus));
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

        /// <summary> 4. Product_Delete </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static bool Product_Delete(tblSanPhamEO _tblSanPhamEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblProduct_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lProductID", _tblSanPhamEO.PK_lProductID));
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

        /// <summary> 5. Product_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool Product_DeleteList(String _ListPK_lProductID)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblProduct_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_lProductID", _ListPK_lProductID));
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
        /// <summary> 6. Product_SelectItem </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static tblSanPhamEO Product_SelectItem(tblSanPhamEO _tblSanPhamEO)
        {
            tblSanPhamEO oOutput = new tblSanPhamEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lProductID", _tblSanPhamEO.PK_lProductID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Product(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. Product_SelectList </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet Product_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_SelectList", conn);
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

        /// <summary> 9. Product_SelectList_All_Group </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet Product_SelectList_All_Group(tblSanPhamEO _tblSanPhamEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_SelectList_All_Group", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@lGroup", _tblSanPhamEO.lGroup));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _tblSanPhamEO.bStatus));
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

        /// <summary> 10. Product_SelectList_All_Parent_In_Group </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet Product_SelectList_All_Parent_In_Group(tblSanPhamEO _tblSanPhamEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_SelectList_All_Parent_In_Group", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@lGroup", _tblSanPhamEO.lGroup));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _tblSanPhamEO.bStatus));
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

        /// <summary> 11. Product_SelectList_All_Product </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet Product_SelectList_All_Product(tblSanPhamEO _tblSanPhamEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_SelectList_All_Product", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _tblSanPhamEO.bStatus));
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

        /// <summary> 12. Product_SelectList_All_Product_In_Group </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet Product_SelectList_All_Product_In_Group(tblSanPhamEO _tblSanPhamEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_SelectList_All_Product_In_Group", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@lGroup", _tblSanPhamEO.lGroup));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _tblSanPhamEO.bStatus));
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

        /// <summary> 13. Product_Search </summary>
        /// <param name="_tblSanPhamEO"></param>
        /// <returns></returns>
        public static DataSet Product_Search(string keyword)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@keyword", keyword));

                    //da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lProductID", _tblSanPhamEO.PK_lProductID));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lGroup", _tblSanPhamEO.lGroup));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lParent", _tblSanPhamEO.lParent));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sName", _tblSanPhamEO.sName));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lPrice", _tblSanPhamEO.lPrice));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lSale", _tblSanPhamEO.lSale));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@bVAT", _tblSanPhamEO.bVAT));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sDescription", _tblSanPhamEO.sDescription));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sInfomation", _tblSanPhamEO.sInfomation));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sOrigin", _tblSanPhamEO.sOrigin));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@iQuantity", _tblSanPhamEO.iQuantity));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkImage", _tblSanPhamEO.sLinkImage));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkImage1", _tblSanPhamEO.sLinkImage1));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkImage2", _tblSanPhamEO.sLinkImage2));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@tLastUpdate", _tblSanPhamEO.tLastUpdate));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _tblSanPhamEO.bStatus));
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