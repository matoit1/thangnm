using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class GiangVienDAO
    {
        #region "CheckExists"
        /// <summary> 1. GiangVien_CheckExists_PK_sMaGV </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static bool GiangVien_CheckExists_PK_sMaGV(GiangVienEO _GiangVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiangVien_CheckExists_PK_sMaGV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaGV", _GiangVienEO.PK_sMaGV));
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

        /// <summary> 2. GiangVien_CheckExists_sTendangnhapGV </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static bool GiangVien_CheckExists_sTendangnhapGV(GiangVienEO _GiangVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiangVien_CheckExists_sTendangnhapGV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTendangnhapGV", _GiangVienEO.sTendangnhapGV));
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

        /// <summary> 3. GiangVien_CheckExists_sEmailGV </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static bool GiangVien_CheckExists_sEmailGV(GiangVienEO _GiangVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiangVien_CheckExists_sEmailGV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sEmailGV", _GiangVienEO.sEmailGV));
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

        /// <summary> 4. GiangVien_CheckExists_sCMNDGV </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static bool GiangVien_CheckExists_sCMNDGV(GiangVienEO _GiangVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiangVien_CheckExists_sCMNDGV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sCMNDGV", _GiangVienEO.sCMNDGV));
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
        /// <summary> 2. GiangVien_Insert </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static bool GiangVien_Insert(GiangVienEO _GiangVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiangVien_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaGV", _GiangVienEO.PK_sMaGV));
                    cmd.Parameters.Add(new SqlParameter("@sHotenGV", _GiangVienEO.sHotenGV));
                    cmd.Parameters.Add(new SqlParameter("@sTendangnhapGV", _GiangVienEO.sTendangnhapGV));
                    cmd.Parameters.Add(new SqlParameter("@sMatkhauGV", _GiangVienEO.sMatkhauGV));
                    cmd.Parameters.Add(new SqlParameter("@sEmailGV", _GiangVienEO.sEmailGV));
                    cmd.Parameters.Add(new SqlParameter("@sDiachiGV", _GiangVienEO.sDiachiGV));
                    cmd.Parameters.Add(new SqlParameter("@sSdtGV", _GiangVienEO.sSdtGV));
                    cmd.Parameters.Add(new SqlParameter("@tNgaysinhGV", _GiangVienEO.tNgaysinhGV));
                    cmd.Parameters.Add(new SqlParameter("@bGioitinhGV", _GiangVienEO.bGioitinhGV));
                    cmd.Parameters.Add(new SqlParameter("@sCMNDGV", _GiangVienEO.sCMNDGV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayCapCMNDGV", _GiangVienEO.tNgayCapCMNDGV));
                    cmd.Parameters.Add(new SqlParameter("@sNoiCapCMNDGV", _GiangVienEO.sNoiCapCMNDGV));
                    cmd.Parameters.Add(new SqlParameter("@bHonNhanGV", _GiangVienEO.bHonNhanGV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayNhanCongTacGV", _GiangVienEO.tNgayNhanCongTacGV));
                    cmd.Parameters.Add(new SqlParameter("@iChucVuGV", _GiangVienEO.iChucVuGV));
                    cmd.Parameters.Add(new SqlParameter("@iHocViGV", _GiangVienEO.iHocViGV));
                    cmd.Parameters.Add(new SqlParameter("@bCongChucGV", _GiangVienEO.bCongChucGV));
                    cmd.Parameters.Add(new SqlParameter("@sLinkChannelsGV", _GiangVienEO.sLinkChannelsGV));
                    cmd.Parameters.Add(new SqlParameter("@sLinkChatRoomsGV", _GiangVienEO.sLinkChatRoomsGV));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAvatarGV", _GiangVienEO.sLinkAvatarGV));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThaiGV", _GiangVienEO.iTrangThaiGV));
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

        /// <summary> 3. GiangVien_Update </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static bool GiangVien_Update(GiangVienEO _GiangVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiangVien_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaGV", _GiangVienEO.PK_sMaGV));
                    cmd.Parameters.Add(new SqlParameter("@sHotenGV", _GiangVienEO.sHotenGV));
                    cmd.Parameters.Add(new SqlParameter("@sTendangnhapGV", _GiangVienEO.sTendangnhapGV));
                    cmd.Parameters.Add(new SqlParameter("@sMatkhauGV", _GiangVienEO.sMatkhauGV));
                    cmd.Parameters.Add(new SqlParameter("@sEmailGV", _GiangVienEO.sEmailGV));
                    cmd.Parameters.Add(new SqlParameter("@sDiachiGV", _GiangVienEO.sDiachiGV));
                    cmd.Parameters.Add(new SqlParameter("@sSdtGV", _GiangVienEO.sSdtGV));
                    cmd.Parameters.Add(new SqlParameter("@tNgaysinhGV", _GiangVienEO.tNgaysinhGV));
                    cmd.Parameters.Add(new SqlParameter("@bGioitinhGV", _GiangVienEO.bGioitinhGV));
                    cmd.Parameters.Add(new SqlParameter("@sCMNDGV", _GiangVienEO.sCMNDGV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayCapCMNDGV", _GiangVienEO.tNgayCapCMNDGV));
                    cmd.Parameters.Add(new SqlParameter("@sNoiCapCMNDGV", _GiangVienEO.sNoiCapCMNDGV));
                    cmd.Parameters.Add(new SqlParameter("@bHonNhanGV", _GiangVienEO.bHonNhanGV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayNhanCongTacGV", _GiangVienEO.tNgayNhanCongTacGV));
                    cmd.Parameters.Add(new SqlParameter("@iChucVuGV", _GiangVienEO.iChucVuGV));
                    cmd.Parameters.Add(new SqlParameter("@iHocViGV", _GiangVienEO.iHocViGV));
                    cmd.Parameters.Add(new SqlParameter("@bCongChucGV", _GiangVienEO.bCongChucGV));
                    cmd.Parameters.Add(new SqlParameter("@sLinkChannelsGV", _GiangVienEO.sLinkChannelsGV));
                    cmd.Parameters.Add(new SqlParameter("@sLinkChatRoomsGV", _GiangVienEO.sLinkChatRoomsGV));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAvatarGV", _GiangVienEO.sLinkAvatarGV));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThaiGV", _GiangVienEO.iTrangThaiGV));
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

        /// <summary> 3. GiangVien_ResetPassword </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static bool GiangVien_ResetPassword(GiangVienEO _GiangVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiangVien_ResetPassword", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTendangnhapGV", _GiangVienEO.sTendangnhapGV));
                    cmd.Parameters.Add(new SqlParameter("@sMatkhauGV", _GiangVienEO.sMatkhauGV));
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

        /// <summary> 4. GiangVien_Delete </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static bool GiangVien_Delete(GiangVienEO _GiangVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiangVien_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaGV", _GiangVienEO.PK_sMaGV));
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

        /// <summary> 5. GiangVien_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool GiangVien_DeleteList(String _ListPK_sMaGV)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblGiangVien_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_sMaGV", _ListPK_sMaGV));
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
        /// <summary> 6. GiangVien_SelectItem </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static GiangVienEO GiangVien_SelectItem(GiangVienEO _GiangVienEO)
        {
            GiangVienEO oOutput = new GiangVienEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblGiangVien_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaGV", _GiangVienEO.PK_sMaGV));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.GiangVien(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. GiangVien_SelectBysTendangnhapGV </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static GiangVienEO GiangVien_SelectBysTendangnhapGV(GiangVienEO _GiangVienEO)
        {
            GiangVienEO oOutput = new GiangVienEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblGiangVien_SelectBysTendangnhapGV", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTendangnhapGV", _GiangVienEO.sTendangnhapGV));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.GiangVien(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. GiangVien_SelectList </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static DataSet GiangVien_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblGiangVien_SelectList", conn);
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

        /// <summary> 8. GiangVien_Search </summary>
        /// <param name="_GiangVienEO"></param>
        /// <returns></returns>
        public static DataSet GiangVien_Search(GiangVienEO _GiangVienEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblGiangVien_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaGV", _GiangVienEO.PK_sMaGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sHotenGV", _GiangVienEO.sHotenGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTendangnhapGV", _GiangVienEO.sTendangnhapGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sMatkhauGV", _GiangVienEO.sMatkhauGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmailGV", _GiangVienEO.sEmailGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sDiachiGV", _GiangVienEO.sDiachiGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sSdtGV", _GiangVienEO.sSdtGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgaysinhGV", _GiangVienEO.tNgaysinhGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bGioitinhGV", _GiangVienEO.bGioitinhGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sCMNDGV", _GiangVienEO.sCMNDGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayCapCMNDGV", _GiangVienEO.tNgayCapCMNDGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sNoiCapCMNDGV", _GiangVienEO.sNoiCapCMNDGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bHonNhanGV", _GiangVienEO.bHonNhanGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayNhanCongTacGV", _GiangVienEO.tNgayNhanCongTacGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iChucVuGV", _GiangVienEO.iChucVuGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iHocViGV", _GiangVienEO.iHocViGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bCongChucGV", _GiangVienEO.bCongChucGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkChannelsGV", _GiangVienEO.sLinkChannelsGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkChatRoomsGV", _GiangVienEO.sLinkChatRoomsGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkAvatarGV", _GiangVienEO.sLinkAvatarGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThaiGV", _GiangVienEO.iTrangThaiGV));
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

        /// <summary> 10. GiangVien_Login </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static DataSet GiangVien_Login(GiangVienEO _GiangVienEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblGiangVien_Login", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTendangnhapGV", _GiangVienEO.sTendangnhapGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sMatkhauGV", _GiangVienEO.sMatkhauGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iChucVuGV", (_GiangVienEO.iChucVuGV == 0) ? (object)DBNull.Value : _GiangVienEO.iChucVuGV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThaiGV", _GiangVienEO.iTrangThaiGV));
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