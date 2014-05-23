using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using CongKy.EntityObject;

namespace CongKy.DataAccessObject
{
    public class tblGiaoTrinhDAO
    {

        #region "Insert, Update, Delete"
        /// <summary> 2. GiaoTrinh_Insert </summary>
        /// <param name="_tblGiaoTrinhEO"></param>
        /// <returns></returns>
        public static bool GiaoTrinh_Insert(tblGiaoTrinhEO _tblGiaoTrinhEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiaoTrinh_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_iMonHocID", _tblGiaoTrinhEO.FK_iMonHocID));
                    cmd.Parameters.Add(new SqlParameter("@FK_iGiaoTrinhID", _tblGiaoTrinhEO.FK_iGiaoTrinhID));
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

        /// <summary> 3. GiaoTrinh_Update </summary>
        /// <param name="_tblGiaoTrinhEO"></param>
        /// <returns></returns>
        public static bool GiaoTrinh_Update(tblGiaoTrinhEO _tblGiaoTrinhEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiaoTrinh_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_iMonHocID", _tblGiaoTrinhEO.FK_iMonHocID));
                    cmd.Parameters.Add(new SqlParameter("@FK_iGiaoTrinhID", _tblGiaoTrinhEO.FK_iGiaoTrinhID));
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


        /// <summary> 5. GiaoTrinh_Delete </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool GiaoTrinh_Delete(tblGiaoTrinhEO _tblGiaoTrinhEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiaoTrinh_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_iMonHocID", _tblGiaoTrinhEO.FK_iMonHocID));
                    cmd.Parameters.Add(new SqlParameter("@FK_iGiaoTrinhID", _tblGiaoTrinhEO.FK_iGiaoTrinhID));
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
        /// <summary> 6. GiaoTrinh_SelectItem </summary>
        /// <param name="_tblGiaoTrinhEO"></param>
        /// <returns></returns>
        public static tblDangKyDayHocEO GiaoTrinh_SelectItem(tblDangKyDayHocEO _tblGiaoTrinhEO)
        {
            tblDangKyDayHocEO oOutput = new tblDangKyDayHocEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblGiaoTrinh_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iMonHocID", _tblGiaoTrinhEO.FK_iMonHocID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iGiaoTrinhID", _tblGiaoTrinhEO.FK_iGiaoTrinhID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.GiaoTrinhDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        /// <summary> 6. GiaoTrinh_SelectItem_By_PK_iGiaoTrinhID </summary>
        /// <param name="_tblGiaoTrinhEO"></param>
        /// <returns></returns>
        public static tblDangKyDayHocEO GiaoTrinh_SelectItem_By_PK_iGiaoTrinhID(Int16 _PK_iGiaoTrinhID)
        {
            tblDangKyDayHocEO oOutput = new tblDangKyDayHocEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblGiaoTrinh_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iMonHocID", _FK_iMonHocID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iGiaoTrinhID", _FK_iGiaoTrinhID));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.GiaoTrinhDO(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        

        /// <summary> 8. GiaoTrinh_SelectList </summary>
        /// <param name="_tblGiaoTrinhEO"></param>
        /// <returns></returns>
        public static DataSet GiaoTrinh_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblGiaoTrinh_SelectList", conn);
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


   
        /// <summary> 9. GiaoTrinh_Search </summary>
        /// <param name="_tblGiaoTrinhEO"></param>
        /// <returns></returns>
        public static DataSet GiaoTrinh_Search(tblDangKyDayHocEO _tblGiaoTrinhEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblGiaoTrinh_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iMonHocID", _tblGiaoTrinhEO.FK_iMonHocID));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_iGiaoTrinhID", _tblGiaoTrinhEO.FK_iGiaoTrinhID));
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