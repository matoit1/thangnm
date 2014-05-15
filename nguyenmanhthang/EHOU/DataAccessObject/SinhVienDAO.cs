﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class SinhVienDAO
    {
        #region "CheckExists"
        /// <summary> 1. SinhVien_CheckExists_PK_sMaSV </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static bool SinhVien_CheckExists_PK_sMaSV(SinhVienEO _SinhVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSinhVien_CheckExists_PK_sMaSV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaSV", _SinhVienEO.PK_sMaSV));
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

        /// <summary> 2. SinhVien_CheckExists_sTendangnhapSV </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static bool SinhVien_CheckExists_sTendangnhapSV(SinhVienEO _SinhVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSinhVien_CheckExists_sTendangnhapSV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTendangnhapSV", _SinhVienEO.sTendangnhapSV));
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

        /// <summary> 3. SinhVien_CheckExists_sEmailSV </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static bool SinhVien_CheckExists_sEmailSV(SinhVienEO _SinhVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSinhVien_CheckExists_sEmailSV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sEmailSV", _SinhVienEO.sEmailSV));
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

        /// <summary> 4. SinhVien_CheckExists_sCMNDSV </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static bool SinhVien_CheckExists_sCMNDSV(SinhVienEO _SinhVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSinhVien_CheckExists_sCMNDSV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sCMNDSV", _SinhVienEO.sCMNDSV));
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
        /// <summary> 2. SinhVien_Insert </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static bool SinhVien_Insert(SinhVienEO _SinhVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSinhVien_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaLop", _SinhVienEO.FK_sMaLop));
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaSV", _SinhVienEO.PK_sMaSV));
                    cmd.Parameters.Add(new SqlParameter("@sHotenSV", _SinhVienEO.sHotenSV));
                    cmd.Parameters.Add(new SqlParameter("@sTendangnhapSV", _SinhVienEO.sTendangnhapSV));
                    cmd.Parameters.Add(new SqlParameter("@sMatkhauSV", _SinhVienEO.sMatkhauSV));
                    cmd.Parameters.Add(new SqlParameter("@sEmailSV", _SinhVienEO.sEmailSV));
                    cmd.Parameters.Add(new SqlParameter("@sDiachiSV", _SinhVienEO.sDiachiSV));
                    cmd.Parameters.Add(new SqlParameter("@sSdtSV", _SinhVienEO.sSdtSV));
                    cmd.Parameters.Add(new SqlParameter("@tNgaysinhSV", _SinhVienEO.tNgaysinhSV));
                    cmd.Parameters.Add(new SqlParameter("@bGioitinhSV", _SinhVienEO.bGioitinhSV));
                    cmd.Parameters.Add(new SqlParameter("@sCMNDSV", _SinhVienEO.sCMNDSV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayCapCMNDSV", _SinhVienEO.tNgayCapCMNDSV));
                    cmd.Parameters.Add(new SqlParameter("@sNoiCapCMNDSV", _SinhVienEO.sNoiCapCMNDSV));
                    cmd.Parameters.Add(new SqlParameter("@bHonNhanSV", _SinhVienEO.bHonNhanSV));
                    cmd.Parameters.Add(new SqlParameter("@sNguoiLienHeSV", _SinhVienEO.sNguoiLienHeSV));
                    cmd.Parameters.Add(new SqlParameter("@sDiaChiNguoiLienHeSV", _SinhVienEO.sDiaChiNguoiLienHeSV));
                    cmd.Parameters.Add(new SqlParameter("@sSdtNguoiLienHeSV", _SinhVienEO.sSdtNguoiLienHeSV));
                    cmd.Parameters.Add(new SqlParameter("@iQuanHeVoiNguoiLienHeSV", _SinhVienEO.iQuanHeVoiNguoiLienHeSV));
                    cmd.Parameters.Add(new SqlParameter("@bKetnapDoanSV", _SinhVienEO.bKetnapDoanSV));
                    cmd.Parameters.Add(new SqlParameter("@iNamketnapDoanSV", _SinhVienEO.iNamketnapDoanSV));
                    cmd.Parameters.Add(new SqlParameter("@sNoiketnapDoanSV", _SinhVienEO.sNoiketnapDoanSV));
                    cmd.Parameters.Add(new SqlParameter("@iNamtotnghiepTHPTSV", _SinhVienEO.iNamtotnghiepTHPTSV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayNhapHocSV", _SinhVienEO.tNgayNhapHocSV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayRaTruongSV", _SinhVienEO.tNgayRaTruongSV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayCapTheSV", _SinhVienEO.tNgayCapTheSV));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAvatarSV", _SinhVienEO.sLinkAvatarSV));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThaiSV", _SinhVienEO.iTrangThaiSV));
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

        /// <summary> 3. SinhVien_Update </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static bool SinhVien_Update(SinhVienEO _SinhVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSinhVien_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sMaLop", _SinhVienEO.FK_sMaLop));
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaSV", _SinhVienEO.PK_sMaSV));
                    cmd.Parameters.Add(new SqlParameter("@sHotenSV", _SinhVienEO.sHotenSV));
                    cmd.Parameters.Add(new SqlParameter("@sTendangnhapSV", _SinhVienEO.sTendangnhapSV));
                    cmd.Parameters.Add(new SqlParameter("@sMatkhauSV", _SinhVienEO.sMatkhauSV));
                    cmd.Parameters.Add(new SqlParameter("@sEmailSV", _SinhVienEO.sEmailSV));
                    cmd.Parameters.Add(new SqlParameter("@sDiachiSV", _SinhVienEO.sDiachiSV));
                    cmd.Parameters.Add(new SqlParameter("@sSdtSV", _SinhVienEO.sSdtSV));
                    cmd.Parameters.Add(new SqlParameter("@tNgaysinhSV", _SinhVienEO.tNgaysinhSV));
                    cmd.Parameters.Add(new SqlParameter("@bGioitinhSV", _SinhVienEO.bGioitinhSV));
                    cmd.Parameters.Add(new SqlParameter("@sCMNDSV", _SinhVienEO.sCMNDSV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayCapCMNDSV", _SinhVienEO.tNgayCapCMNDSV));
                    cmd.Parameters.Add(new SqlParameter("@sNoiCapCMNDSV", _SinhVienEO.sNoiCapCMNDSV));
                    cmd.Parameters.Add(new SqlParameter("@bHonNhanSV", _SinhVienEO.bHonNhanSV));
                    cmd.Parameters.Add(new SqlParameter("@sNguoiLienHeSV", _SinhVienEO.sNguoiLienHeSV));
                    cmd.Parameters.Add(new SqlParameter("@sDiaChiNguoiLienHeSV", _SinhVienEO.sDiaChiNguoiLienHeSV));
                    cmd.Parameters.Add(new SqlParameter("@sSdtNguoiLienHeSV", _SinhVienEO.sSdtNguoiLienHeSV));
                    cmd.Parameters.Add(new SqlParameter("@iQuanHeVoiNguoiLienHeSV", _SinhVienEO.iQuanHeVoiNguoiLienHeSV));
                    cmd.Parameters.Add(new SqlParameter("@bKetnapDoanSV", _SinhVienEO.bKetnapDoanSV));
                    cmd.Parameters.Add(new SqlParameter("@iNamketnapDoanSV", _SinhVienEO.iNamketnapDoanSV));
                    cmd.Parameters.Add(new SqlParameter("@sNoiketnapDoanSV", _SinhVienEO.sNoiketnapDoanSV));
                    cmd.Parameters.Add(new SqlParameter("@iNamtotnghiepTHPTSV", _SinhVienEO.iNamtotnghiepTHPTSV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayNhapHocSV", _SinhVienEO.tNgayNhapHocSV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayRaTruongSV", _SinhVienEO.tNgayRaTruongSV));
                    cmd.Parameters.Add(new SqlParameter("@tNgayCapTheSV", _SinhVienEO.tNgayCapTheSV));
                    cmd.Parameters.Add(new SqlParameter("@sLinkAvatarSV", _SinhVienEO.sLinkAvatarSV));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThaiSV", _SinhVienEO.iTrangThaiSV));
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

        /// <summary> 3. SinhVien_ResetPassword </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static bool SinhVien_ResetPassword(SinhVienEO _SinhVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSinhVien_ResetPassword", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTendangnhapSV", _SinhVienEO.sTendangnhapSV));
                    cmd.Parameters.Add(new SqlParameter("@sMatkhauSV", _SinhVienEO.sMatkhauSV));
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

        /// <summary> 4. SinhVien_Delete </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static bool SinhVien_Delete(SinhVienEO _SinhVienEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSinhVien_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaSV", _SinhVienEO.PK_sMaSV));
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

        /// <summary> 5. SinhVien_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool SinhVien_DeleteList(String _ListPK_sMaSV)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSinhVien_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_sMaSV", _ListPK_sMaSV));
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
        /// <summary> 6. SinhVien_SelectItem </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static SinhVienEO SinhVien_SelectItem(SinhVienEO _SinhVienEO)
        {
            SinhVienEO oOutput = new SinhVienEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSinhVien_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaSV", _SinhVienEO.PK_sMaSV));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.SinhVien(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. SinhVien_SelectBysTendangnhapSV </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static SinhVienEO SinhVien_SelectBysTendangnhapSV(SinhVienEO _SinhVienEO)
        {
            SinhVienEO oOutput = new SinhVienEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSinhVien_SelectBysTendangnhapSV", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTendangnhapSV", _SinhVienEO.sTendangnhapSV));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.SinhVien(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. SinhVien_SelectBysEmailSVvssSdtSV </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static SinhVienEO SinhVien_SelectBysEmailSVvssSdtSV(SinhVienEO _SinhVienEO)
        {
            SinhVienEO oOutput = new SinhVienEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSinhVien_SelectBysEmailSVvssSdtSV", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmailSV", _SinhVienEO.sEmailSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sSdtSV", _SinhVienEO.sSdtSV));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.SinhVien(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 8. SinhVien_SelectByFK_sMaLop </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static DataSet SinhVien_SelectByFK_sMaLop(SinhVienEO _SinhVienEO)
        {
            SinhVienEO oOutput = new SinhVienEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSinhVien_SelectByFK_sMaLop", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaLop", _SinhVienEO.FK_sMaLop));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    return ds;
                }
                catch (Exception)
                {
                    conn.Close();
                    return ds;
                }
            }
        }

        /// <summary> 8. SinhVien_SelectList </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static DataSet SinhVien_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSinhVien_SelectList", conn);
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

        /// <summary> 9. SinhVien_Search </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static DataSet SinhVien_Search(SinhVienEO _SinhVienEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSinhVien_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sMaLop", _SinhVienEO.FK_sMaLop));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaSV", _SinhVienEO.PK_sMaSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sHotenSV", _SinhVienEO.sHotenSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTendangnhapSV", _SinhVienEO.sTendangnhapSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sMatkhauSV", _SinhVienEO.sMatkhauSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sEmailSV", _SinhVienEO.sEmailSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sDiachiSV", _SinhVienEO.sDiachiSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sSdtSV", _SinhVienEO.sSdtSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgaysinhSV", _SinhVienEO.tNgaysinhSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bGioitinhSV", _SinhVienEO.bGioitinhSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sCMNDSV", _SinhVienEO.sCMNDSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayCapCMNDSV", _SinhVienEO.tNgayCapCMNDSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sNoiCapCMNDSV", _SinhVienEO.sNoiCapCMNDSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bHonNhanSV", _SinhVienEO.bHonNhanSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sNguoiLienHeSV", _SinhVienEO.sNguoiLienHeSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sDiaChiNguoiLienHeSV", _SinhVienEO.sDiaChiNguoiLienHeSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sSdtNguoiLienHeSV", _SinhVienEO.sSdtNguoiLienHeSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iQuanHeVoiNguoiLienHeSV", _SinhVienEO.iQuanHeVoiNguoiLienHeSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@bKetnapDoanSV", _SinhVienEO.bKetnapDoanSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iNamketnapDoanSV", _SinhVienEO.iNamketnapDoanSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sNoiketnapDoanSV", _SinhVienEO.sNoiketnapDoanSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iNamtotnghiepTHPTSV", _SinhVienEO.iNamtotnghiepTHPTSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayNhapHocSV", _SinhVienEO.tNgayNhapHocSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayRaTruongSV", _SinhVienEO.tNgayRaTruongSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tNgayCapTheSV", _SinhVienEO.tNgayCapTheSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkAvatarSV", _SinhVienEO.sLinkAvatarSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThaiSV", _SinhVienEO.iTrangThaiSV));
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

        /// <summary> 10. SinhVien_Login </summary>
        /// <param name="_SinhVienEO"></param>
        /// <returns></returns>
        public static DataSet SinhVien_Login(SinhVienEO _SinhVienEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSinhVien_Login", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTendangnhapSV", _SinhVienEO.sTendangnhapSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sMatkhauSV", _SinhVienEO.sMatkhauSV));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThaiSV", _SinhVienEO.iTrangThaiSV));
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