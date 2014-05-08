using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessObject
{
    public class TinNhanDAO
    {
        #region "CheckExists"
        /// <summary> 1. TinNhan_CheckExists </summary>
        /// <param name="_TinNhanEO"></param>
        /// <returns></returns>
        public static bool TinNhan_CheckExists(TinNhanEO _TinNhanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTinNhan_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lMaTinNhan", _TinNhanEO.PK_lTinNhan));
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
        /// <summary> 2. TinNhan_Insert </summary>
        /// <param name="_TinNhanEO"></param>
        /// <returns></returns>
        public static bool TinNhan_Insert(TinNhanEO _TinNhanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTinNhan_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sPhongChat", _TinNhanEO.FK_sPhongChat));
                    cmd.Parameters.Add(new SqlParameter("@FK_sNguoiGui", _TinNhanEO.FK_sNguoiGui));
                    cmd.Parameters.Add(new SqlParameter("@sNoidung", _TinNhanEO.sNoidung));
                    //cmd.Parameters.Add(new SqlParameter("@tNgayGui", _TinNhanEO.tNgayGui));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _TinNhanEO.iTrangThai));
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

        /// <summary> 3. TinNhan_Update </summary>
        /// <param name="_TinNhanEO"></param>
        /// <returns></returns>
        public static bool TinNhan_Update(TinNhanEO _TinNhanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTinNhan_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lTinNhan", _TinNhanEO.PK_lTinNhan));
                    cmd.Parameters.Add(new SqlParameter("@FK_sPhongChat", _TinNhanEO.FK_sPhongChat));
                    cmd.Parameters.Add(new SqlParameter("@FK_sNguoiGui", _TinNhanEO.FK_sNguoiGui));
                    cmd.Parameters.Add(new SqlParameter("@sNoidung", _TinNhanEO.sNoidung));
                    //cmd.Parameters.Add(new SqlParameter("@tNgayGui", _TinNhanEO.tNgayGui));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _TinNhanEO.iTrangThai));
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

        /// <summary> 4. TinNhan_Delete </summary>
        /// <param name="_TinNhanEO"></param>
        /// <returns></returns>
        public static bool TinNhan_Delete(TinNhanEO _TinNhanEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTinNhan_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lTinNhan", _TinNhanEO.PK_lTinNhan));
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

        /// <summary> 5. TinNhan_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool TinNhan_DeleteList(String _ListPK_lTinNhan)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblTinNhan_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_lTinNhan", _ListPK_lTinNhan));
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
        /// <summary> 6. TinNhan_SelectItem </summary>
        /// <param name="_TinNhanEO"></param>
        /// <returns></returns>
        public static TinNhanEO TinNhan_SelectItem(TinNhanEO _TinNhanEO)
        {
            TinNhanEO oOutput = new TinNhanEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTinNhan_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lTinNhan", _TinNhanEO.PK_lTinNhan));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.TinNhan(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. TinNhan_SelectList </summary>
        /// <param name="_TinNhanEO"></param>
        /// <returns></returns>
        public static DataSet TinNhan_SelectList(TinNhanEO _TinNhanEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTinNhan_SelectList", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sPhongChat", _TinNhanEO.FK_sPhongChat));
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

        /// <summary> 8. TinNhan_Search </summary>
        /// <param name="_TinNhanEO"></param>
        /// <returns></returns>
        public static DataSet TinNhan_Search(TinNhanEO _TinNhanEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblTinNhan_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lTinNhan", _TinNhanEO.PK_lTinNhan));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sPhongChat", _TinNhanEO.FK_sPhongChat));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sNguoiGui", _TinNhanEO.FK_sNguoiGui));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sNoidung", _TinNhanEO.sNoidung));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayGui", _TinNhanEO.tNgayGui));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _TinNhanEO.iTrangThai));
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