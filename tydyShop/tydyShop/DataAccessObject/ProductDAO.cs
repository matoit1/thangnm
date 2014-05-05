using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class ProductDAO
    {
        #region "CheckExists"
        /// <summary> 1. Product_CheckExists_PK_lProductID </summary>
        /// <param name="_ProductEO"></param>
        /// <returns></returns>
        public static bool Product_CheckExists_PK_lProductID(ProductEO _ProductEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblProduct_CheckExists_PK_lProductID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lProductID", _ProductEO.PK_lProductID));
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
        /// <param name="_ProductEO"></param>
        /// <returns></returns>
        public static bool Product_Insert(ProductEO _ProductEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblProduct_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lProductID", _ProductEO.PK_lProductID));
                    cmd.Parameters.Add(new SqlParameter("@lGroup", _ProductEO.lGroup));
                    cmd.Parameters.Add(new SqlParameter("@lParent", _ProductEO.lParent));
                    cmd.Parameters.Add(new SqlParameter("@sName", _ProductEO.sName));
                    cmd.Parameters.Add(new SqlParameter("@lPrice", _ProductEO.lPrice));
                    cmd.Parameters.Add(new SqlParameter("@lSale", _ProductEO.lSale));
                    cmd.Parameters.Add(new SqlParameter("@bVAT", _ProductEO.bVAT));
                    cmd.Parameters.Add(new SqlParameter("@sDescription", _ProductEO.sDescription));
                    cmd.Parameters.Add(new SqlParameter("@sInfomation", _ProductEO.sInfomation));
                    cmd.Parameters.Add(new SqlParameter("@sOrigin", _ProductEO.sOrigin));
                    cmd.Parameters.Add(new SqlParameter("@iQuantity", _ProductEO.iQuantity));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImage", _ProductEO.sLinkImage));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImageThumbnail", _ProductEO.sLinkImageThumbnail));
                    cmd.Parameters.Add(new SqlParameter("@tLastUpdate", _ProductEO.tLastUpdate));
                    cmd.Parameters.Add(new SqlParameter("@bStatus", _ProductEO.bStatus));
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
        /// <param name="_ProductEO"></param>
        /// <returns></returns>
        public static bool Product_Update(ProductEO _ProductEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblProduct_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lProductID", _ProductEO.PK_lProductID));
                    cmd.Parameters.Add(new SqlParameter("@lGroup", _ProductEO.lGroup));
                    cmd.Parameters.Add(new SqlParameter("@lParent", _ProductEO.lParent));
                    cmd.Parameters.Add(new SqlParameter("@sName", _ProductEO.sName));
                    cmd.Parameters.Add(new SqlParameter("@lPrice", _ProductEO.lPrice));
                    cmd.Parameters.Add(new SqlParameter("@lSale", _ProductEO.lSale));
                    cmd.Parameters.Add(new SqlParameter("@bVAT", _ProductEO.bVAT));
                    cmd.Parameters.Add(new SqlParameter("@sDescription", _ProductEO.sDescription));
                    cmd.Parameters.Add(new SqlParameter("@sInfomation", _ProductEO.sInfomation));
                    cmd.Parameters.Add(new SqlParameter("@sOrigin", _ProductEO.sOrigin));
                    cmd.Parameters.Add(new SqlParameter("@iQuantity", _ProductEO.iQuantity));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImage", _ProductEO.sLinkImage));
                    cmd.Parameters.Add(new SqlParameter("@sLinkImage1", _ProductEO.sLinkImageThumbnail));
                    cmd.Parameters.Add(new SqlParameter("@tLastUpdate", _ProductEO.tLastUpdate));
                    cmd.Parameters.Add(new SqlParameter("@bStatus", _ProductEO.bStatus));
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
        /// <param name="_ProductEO"></param>
        /// <returns></returns>
        public static bool Product_Delete(ProductEO _ProductEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblProduct_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lProductID", _ProductEO.PK_lProductID));
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
        /// <param name="_ProductEO"></param>
        /// <returns></returns>
        public static ProductEO Product_SelectItem(ProductEO _ProductEO)
        {
            ProductEO oOutput = new ProductEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lProductID", _ProductEO.PK_lProductID));
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
        /// <param name="_ProductEO"></param>
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
        /// <param name="_ProductEO"></param>
        /// <returns></returns>
        public static DataSet Product_SelectList_All_Group(ProductEO _ProductEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_SelectList_All_Group", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@lGroup", _ProductEO.lGroup));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _ProductEO.bStatus));
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
        /// <param name="_ProductEO"></param>
        /// <returns></returns>
        public static DataSet Product_SelectList_All_Parent_In_Group(ProductEO _ProductEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_SelectList_All_Parent_In_Group", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@lGroup", _ProductEO.lGroup));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _ProductEO.bStatus));
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
        /// <param name="_ProductEO"></param>
        /// <returns></returns>
        public static DataSet Product_SelectList_All_Product(ProductEO _ProductEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_SelectList_All_Product", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _ProductEO.bStatus));
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
        /// <param name="_ProductEO"></param>
        /// <returns></returns>
        public static DataSet Product_SelectList_All_Product_In_Group(ProductEO _ProductEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblProduct_SelectList_All_Product_In_Group", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@lGroup", _ProductEO.lGroup));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _ProductEO.bStatus));
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
        /// <param name="_ProductEO"></param>
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

                    //da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lProductID", _ProductEO.PK_lProductID));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lGroup", _ProductEO.lGroup));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lParent", _ProductEO.lParent));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sName", _ProductEO.sName));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lPrice", _ProductEO.lPrice));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@lSale", _ProductEO.lSale));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@bVAT", _ProductEO.bVAT));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sDescription", _ProductEO.sDescription));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sInfomation", _ProductEO.sInfomation));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sOrigin", _ProductEO.sOrigin));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@iQuantity", _ProductEO.iQuantity));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkImage", _ProductEO.sLinkImage));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkImage1", _ProductEO.sLinkImage1));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkImage2", _ProductEO.sLinkImage2));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@tLastUpdate", _ProductEO.tLastUpdate));
                    //da.SelectCommand.Parameters.Add(new SqlParameter("@bStatus", _ProductEO.bStatus));
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