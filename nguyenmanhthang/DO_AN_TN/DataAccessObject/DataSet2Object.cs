using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityObject;
using System.Data;

namespace DataAccessObject
{
    public class DataSet2Object
    {
        public static BaiVietEO BaiViet(DataSet input)
        {
            try
            {
                BaiVietEO output = new BaiVietEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.FK_sMaGV = Convert.ToString(dr["FK_sMaGV"]);
                    output.PK_lMaBaiViet = Convert.ToInt64(dr["PK_lMaBaiViet"]);
                    output.sTieuDe = Convert.ToString(dr["sTieuDe"]);
                    output.sLinkAnh = Convert.ToString(dr["sLinkAnh"]);
                    output.sTag = Convert.ToString(dr["sTag"]);
                    output.sNoiDung = Convert.ToString(dr["sNoiDung"]);
                    output.iLuotXem = Convert.ToInt16(dr["iLuotXem"]);
                    output.tNgayViet = Convert.ToDateTime(dr["tNgayViet"]);
                    output.tNgayCapNhat = Convert.ToDateTime(dr["tNgayCapNhat"]);
                    output.sMoTa = Convert.ToString(dr["sMoTa"]);
                    output.iTrangThai = Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static CauHoiEO CauHoi(DataSet input)
        {
            try
            {
                CauHoiEO output = new CauHoiEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.FK_sMaGV = Convert.ToString(dr["FK_sMaGV"]);
                    output.PK_lCauhoi_ID = Convert.ToInt64(dr["PK_lCauhoi_ID"]);
                    output.sCauhoi_Cauhoi = Convert.ToString(dr["sCauhoi_Cauhoi"]);
                    output.sCauhoi_A = Convert.ToString(dr["sCauhoi_A"]);
                    output.sCauhoi_B = Convert.ToString(dr["sCauhoi_B"]);
                    output.sCauhoi_C = Convert.ToString(dr["sCauhoi_C"]);
                    output.sCauhoi_D = Convert.ToString(dr["sCauhoi_D"]);
                    output.iCauhoi_Dung = Convert.ToInt16(dr["iCauhoi_Dung"]);
                    output.sBoCauHoi = Convert.ToString(dr["sBoCauHoi"]);
                    output.tNgayTao = Convert.ToDateTime(dr["tNgayTao"]);
                    output.tNgayCapNhat = Convert.ToDateTime(dr["tNgayCapNhat"]);
                    output.iTrangThai = Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static ConfigEO Config(DataSet input)
        {
            try
            {
                ConfigEO output = new ConfigEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_sMaMonhoc = Convert.ToString(dr["PK_sMaMonhoc"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DiemThiEO DiemThi(DataSet input)
        {
            try
            {
                DiemThiEO output = new DiemThiEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.FK_sMaSV = Convert.ToString(dr["FK_sMaSV"]);
                    output.FK_sMaMonhoc = Convert.ToString(dr["FK_sMaMonhoc"]);
                    output.PK_iSolanhoc = Convert.ToInt16(dr["PK_iSolanhoc"]);
                    output.fDiemchuyencan = Convert.ToSingle(dr["fDiemchuyencan"]);
                    output.fDiemgiuaky = Convert.ToSingle(dr["fDiemgiuaky"]);
                    output.fDiemthilan1 = Convert.ToSingle(dr["fDiemthilan1"]);
                    output.fDiemthilan2 = Convert.ToSingle(dr["fDiemthilan2"]);
                    output.iTrangThai = Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static ErrorEO Error(DataSet input)
        {
            try
            {
                ErrorEO output = new ErrorEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_lErrorID = Convert.ToInt64(dr["PK_lErrorID"]);
                    output.sLink = Convert.ToString(dr["sLink"]);
                    output.sIP = Convert.ToString(dr["sIP"]);
                    output.sBrowser = Convert.ToString(dr["sBrowser"]);
                    output.iCodes = Convert.ToInt16(dr["iCodes"]);
                    output.tTime = Convert.ToDateTime(dr["tTime"]);
                    output.tTimeCheck = Convert.ToDateTime(dr["tTimeCheck"]);
                    output.iStatus = Convert.ToInt16(dr["iStatus"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static GiangVienEO GiangVien(DataSet input)
        {
            try
            {
                GiangVienEO output = new GiangVienEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_sMaGV = Convert.ToString(dr["PK_sMaGV"]);
                    output.sHotenGV = Convert.ToString(dr["sHotenGV"]);
                    output.sTendangnhapGV = Convert.ToString(dr["sTendangnhapGV"]);
                    output.sMatkhauGV = Convert.ToString(dr["sMatkhauGV"]);
                    output.sEmailGV = Convert.ToString(dr["sEmailGV"]);
                    output.sDiachiGV = Convert.ToString(dr["sDiachiGV"]);
                    output.sSdtGV = Convert.ToString(dr["sSdtGV"]);
                    output.tNgaysinhGV = Convert.ToDateTime(dr["tNgaysinhGV"]);
                    output.bGioitinhGV = Convert.ToBoolean(dr["bGioitinhGV"]);
                    output.sCMNDGV = Convert.ToString(dr["sCMNDGV"]);
                    output.tNgayCapCMNDGV = Convert.ToDateTime(dr["tNgayCapCMNDGV"]);
                    output.sNoiCapCMNDGV = Convert.ToString(dr["sNoiCapCMNDGV"]);
                    output.bHonNhanGV = Convert.ToBoolean(dr["bHonNhanGV"]);
                    output.tNgayNhanCongTacGV = Convert.ToDateTime(dr["tNgayNhanCongTacGV"]);
                    output.iChucVuGV = Convert.ToInt16(dr["iChucVuGV"]);
                    output.iHocViGV = Convert.ToInt16(dr["iHocViGV"]);
                    output.bCongChucGV = Convert.ToBoolean(dr["bCongChucGV"]);
                    output.sLinkChannelsGV = Convert.ToString(dr["sLinkChannelsGV"]);
                    output.sLinkChatRoomsGV = Convert.ToString(dr["sLinkChatRoomsGV"]);
                    output.sLinkAvatarGV = Convert.ToString(dr["sLinkAvatarGV"]);
                    output.iTrangThaiGV = Convert.ToInt16(dr["iTrangThaiGV"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static LichDayVaHocEO LichDayVaHoc(DataSet input)
        {
            try
            {
                LichDayVaHocEO output = new LichDayVaHocEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.FK_sMaPCCT = Convert.ToString(dr["FK_sMaPCCT"]);
                    output.FK_sMalop = Convert.ToString(dr["FK_sMalop"]);
                    output.iCaHoc = Convert.ToInt16(dr["iCaHoc"]);
                    output.tNgayDay = Convert.ToDateTime(dr["tNgayDay"]);
                    output.iSoTietDay = Convert.ToInt16(dr["iSoTietDay"]);
                    output.sSinhVienNghi = Convert.ToString(dr["sSinhVienNghi"]);
                    output.sLinkVideo = Convert.ToString(dr["sLinkVideo"]);
                    output.iTrangThai = Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static LopHocEO LopHoc(DataSet input)
        {
            try
            {
                LopHocEO output = new LopHocEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_sMalop = Convert.ToString(dr["PK_sMalop"]);
                    output.sTenlop = Convert.ToString(dr["sTenlop"]);
                    output.iNamvaotruong = Convert.ToInt16(dr["iNamvaotruong"]);
                    output.iSiso = Convert.ToInt16(dr["iSiso"]);
                    output.iSoNamDaoTao = Convert.ToInt16(dr["iSoNamDaoTao"]);
                    output.iTrangThai = Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static MonHocEO MonHoc(DataSet input)
        {
            try
            {
                MonHocEO output = new MonHocEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_sMaMonhoc = Convert.ToString(dr["PK_sMaMonhoc"]);
                    output.sTenMonhoc = Convert.ToString(dr["sTenMonhoc"]);
                    output.iSotrinh = Convert.ToInt16(dr["iSotrinh"]);
                    output.iSotietday = Convert.ToInt16(dr["iSotietday"]);
                    output.iTrangThai = Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static PhanCongCongTacEO PhanCongCongTac(DataSet input)
        {
            try
            {
                PhanCongCongTacEO output = new PhanCongCongTacEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_sMaPCCT = Convert.ToString(dr["PK_sMaPCCT"]);
                    output.FK_sMaGV = Convert.ToString(dr["FK_sMaGV"]);
                    output.FK_sMaMonhoc = Convert.ToString(dr["FK_sMaMonhoc"]);
                    output.tNgayBatDau = Convert.ToDateTime(dr["tNgayBatDau"]);
                    output.tNgayKetThuc = Convert.ToDateTime(dr["tNgayKetThuc"]);
                    output.iTrangThai = Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static SinhVienEO SinhVien(DataSet input)
        {
            try
            {
                SinhVienEO output = new SinhVienEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.FK_sMaLop = Convert.ToString(dr["FK_sMaLop"]);
                    output.PK_sMaSV = Convert.ToString(dr["PK_sMaSV"]);
                    output.sHotenSV = Convert.ToString(dr["sHotenSV"]);
                    output.sTendangnhapSV = Convert.ToString(dr["sTendangnhapSV"]);
                    output.sMatkhauSV = Convert.ToString(dr["sMatkhauSV"]);
                    output.sEmailSV = Convert.ToString(dr["sEmailSV"]);
                    output.sDiachiSV = Convert.ToString(dr["sDiachiSV"]);
                    output.sSdtSV = Convert.ToString(dr["sSdtSV"]);
                    output.tNgaysinhSV = Convert.ToDateTime(dr["tNgaysinhSV"]);
                    output.bGioitinhSV = Convert.ToBoolean(dr["bGioitinhSV"]);
                    output.sCMNDSV = Convert.ToString(dr["sCMNDSV"]);
                    output.tNgayCapCMNDSV = Convert.ToDateTime(dr["tNgayCapCMNDSV"]);
                    output.sNoiCapCMNDSV = Convert.ToString(dr["sNoiCapCMNDSV"]);
                    output.bHonNhanSV = Convert.ToBoolean(dr["bHonNhanSV"]);
                    output.sNguoiLienHeSV = Convert.ToString(dr["sNguoiLienHeSV"]);
                    output.sDiaChiNguoiLienHeSV = Convert.ToString(dr["sDiaChiNguoiLienHeSV"]);
                    output.sSdtNguoiLienHeSV = Convert.ToString(dr["sSdtNguoiLienHeSV"]);
                    output.iQuanHeVoiNguoiLienHeSV = Convert.ToInt16(dr["iQuanHeVoiNguoiLienHeSV"]);
                    output.bKetnapDoanSV = Convert.ToBoolean(dr["bKetnapDoanSV"]);
                    output.iNamketnapDoanSV = Convert.ToInt16(dr["iNamketnapDoanSV"]);
                    output.sNoiketnapDoanSV = Convert.ToString(dr["sNoiketnapDoanSV"]);
                    output.iNamtotnghiepTHPTSV = Convert.ToInt16(dr["iNamtotnghiepTHPTSV"]);
                    output.tNgayNhapHocSV = Convert.ToDateTime(dr["tNgayNhapHocSV"]);
                    output.tNgayRaTruongSV = Convert.ToDateTime(dr["tNgayRaTruongSV"]);
                    output.tNgayCapTheSV = Convert.ToDateTime(dr["tNgayCapTheSV"]);
                    output.sLinkAvatarSV = Convert.ToString(dr["sLinkAvatarSV"]);
                    output.iTrangThaiSV = Convert.ToInt16(dr["iTrangThaiSV"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static TinNhanEO TinNhan(DataSet input)
        {
            try
            {
                TinNhanEO output = new TinNhanEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_lTinNhan = Convert.ToInt64(dr["PK_lTinNhan"]);
                    output.FK_sPhongChat = Convert.ToString(dr["FK_sPhongChat"]);
                    output.FK_sNguoiGui = Convert.ToString(dr["FK_sNguoiGui"]);
                    output.sNoidung = Convert.ToString(dr["sNoidung"]);
                    output.iTrangThai = Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}