using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityObject;
using System.Data;

namespace Shared_Libraries
{
    public class Convert_ToOject
    {
        public static LichDayVaHocEO LichDayVaHocEO(DataSet input)
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
                    output.iTrangThai = Convert.ToInt16(dr["iTrangThai"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static MonHocEO MonHocEO(DataSet input)
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

        public static LopHocEO LopHocEO(DataSet input)
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
    }
}