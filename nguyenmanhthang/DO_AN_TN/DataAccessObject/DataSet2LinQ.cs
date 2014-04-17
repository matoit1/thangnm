using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;

namespace DO_AN_TN.DataAccessObject
{
    public class DataSet2LinQ
    {
        public static EnumerableRowCollection BaiViet(DataSet input)
        {
            try
            {
                var result =
                from topic in input.Tables[0].AsEnumerable()
                select new
                {
                    FK_sMaGV = topic.Field<string>("FK_sMaGV"),
                    PK_lMaBaiViet = topic.Field<Int64>("PK_lMaBaiViet"),
                    sTieuDe = topic.Field<string>("sTieuDe"),
                    sLinkAnh = topic.Field<string>("sLinkAnh"),
                    sTag = topic.Field<string>("sTag"),
                    sNoiDung = topic.Field<string>("sNoiDung"),
                    iLuotXem = topic.Field<Int32>("iLuotXem"),
                    tNgayViet = topic.Field<DateTime>("tNgayViet"),
                    tNgayCapNhat = topic.Field<DateTime>("tNgayCapNhat"),
                    sMoTa = topic.Field<string>("sMoTa"),
                    iTrangThai = topic.Field<Int16>("iTrangThai")
                };
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}