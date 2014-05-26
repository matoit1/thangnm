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
        public static tblPartEO Part(DataSet input)
        {
            try
            {
                tblPartEO output = new tblPartEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_iPart = Convert.ToInt64(dr["PK_iPart"]);
                    output.FK_sSubject = Convert.ToString(dr["FK_sSubject"]);
                    output.sTitle = Convert.ToString(dr["sTitle"]);
                    output.sLinkVideo = Convert.ToString(dr["sLinkVideo"]);
                    output.sBlackList = Convert.ToString(dr["sBlackList"]);
                    output.tDateTimeStart = dr["tDateTimeStart"]==DBNull.Value? DateTime.MinValue : Convert.ToDateTime(dr["tDateTimeStart"]);
                    output.tDateTimeEnd = dr["tDateTimeEnd"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["tDateTimeEnd"]);
                    output.iStatus = Convert.ToInt16(dr["iStatus"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tblAccountEO Account(DataSet input)
        {
            try
            {
                tblAccountEO output = new tblAccountEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_sUsername = Convert.ToString(dr["PK_sUsername"]);
                    output.sPassword = Convert.ToString(dr["sPassword"]);
                    output.sName = Convert.ToString(dr["sName"]);
                    output.sEmail = Convert.ToString(dr["sEmail"]);
                    output.iType = Convert.ToInt16(dr["iType"]);
                    output.iStatus = Convert.ToInt16(dr["iStatus"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tblSubject_StudentEO Subject_Student(DataSet input)
        {
            try
            {
                tblSubject_StudentEO output = new tblSubject_StudentEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.FK_sSubject = Convert.ToString(dr["FK_sSubject"]);
                    output.FK_sStudent = Convert.ToString(dr["FK_sStudent"]);
                    output.iStatus = Convert.ToInt16(dr["iStatus"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tblMessageEO Message(DataSet input)
        {
            try
            {
                tblMessageEO output = new tblMessageEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_lMessage = Convert.ToInt64(dr["PK_lMessage"]);
                    output.FK_sRoom = Convert.ToString(dr["FK_sRoom"]);
                    output.FK_sUsername = Convert.ToString(dr["FK_sUsername"]);
                    output.sContent = Convert.ToString(dr["sContent"]);
                    output.tDateSent = Convert.ToDateTime(dr["tDateSent"]);
                    output.iStatus = Convert.ToInt16(dr["iStatus"]);
                }
                return output;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static tblSubjectEO Subject(DataSet input)
        {
            try
            {
                tblSubjectEO output = new tblSubjectEO();
                foreach (DataRow dr in input.Tables[0].Rows)
                {
                    output.PK_sSubject = Convert.ToString(dr["PK_sSubject"]);
                    output.FK_sTeacher = Convert.ToString(dr["FK_sTeacher"]);
                    output.sName = Convert.ToString(dr["sName"]);
                    output.iStatus = Convert.ToInt16(dr["iStatus"]);
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