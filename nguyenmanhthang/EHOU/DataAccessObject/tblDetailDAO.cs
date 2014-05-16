using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;
using DataAccessObject;

namespace DataAccessObject
{
    public class tblDetailDAO
    {
        #region "CheckExists"
        /// <summary> 1. Detail_CheckExists </summary>
        /// <param name="_tblDetailEO"></param>
        /// <returns></returns>
        public static bool Detail_CheckExists(tblDetailEO _tblDetailEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDetail_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lCaHoc", _tblDetailEO.PK_lCaHoc));
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblDetailEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sStudent", _tblDetailEO.FK_sStudent));
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
        /// <summary> 2. Detail_Insert </summary>
        /// <param name="_tblDetailEO"></param>
        /// <returns></returns>
        public static bool Detail_Insert(tblDetailEO _tblDetailEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDetail_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblDetailEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sStudent", _tblDetailEO.FK_sStudent));
                    cmd.Parameters.Add(new SqlParameter("@sTitle", _tblDetailEO.sTitle));
                    cmd.Parameters.Add(new SqlParameter("@tDateStart", _tblDetailEO.tDateStart));
                    cmd.Parameters.Add(new SqlParameter("@tDateEnd", _tblDetailEO.tDateEnd));
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

        /// <summary> 3. Detail_Update </summary>
        /// <param name="_tblDetailEO"></param>
        /// <returns></returns>
        public static bool Detail_Update(tblDetailEO _tblDetailEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDetail_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lCaHoc", _tblDetailEO.PK_lCaHoc));
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblDetailEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sStudent", _tblDetailEO.FK_sStudent));
                    cmd.Parameters.Add(new SqlParameter("@sTitle", _tblDetailEO.sTitle));
                    cmd.Parameters.Add(new SqlParameter("@tDateStart", _tblDetailEO.tDateStart));
                    cmd.Parameters.Add(new SqlParameter("@tDateEnd", _tblDetailEO.tDateEnd));
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

        /// <summary> 4. Detail_Delete </summary>
        /// <param name="_tblDetailEO"></param>
        /// <returns></returns>
        public static bool Detail_Delete(tblDetailEO _tblDetailEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDetail_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lCaHoc", _tblDetailEO.PK_lCaHoc));
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblDetailEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sStudent", _tblDetailEO.FK_sStudent));
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

        /// <summary> 5. Detail_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool Detail_DeleteList(String _ListPK_lDetail)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblDetail_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_lDetail", _ListPK_lDetail));
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
        /// <summary> 6. Detail_SelectItem </summary>
        /// <param name="_tblDetailEO"></param>
        /// <returns></returns>
        public static tblDetailEO Detail_SelectItem(tblDetailEO _tblDetailEO)
        {
            tblDetailEO oOutput = new tblDetailEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDetail_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lCaHoc", _tblDetailEO.PK_lCaHoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblDetailEO.FK_sSubject));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sStudent", _tblDetailEO.FK_sStudent));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTitle", _tblDetailEO.sTitle));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tDateStart", _tblDetailEO.tDateStart));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tDateEnd", _tblDetailEO.tDateEnd));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Detail(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. SelectByFK_sSubject </summary>
        /// <param name="_tblDetailEO"></param>
        /// <returns></returns>
        public static DataSet SelectByFK_sSubject_FK_sStudent(tblDetailEO _tblDetailEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDetail_SelectByFK_sSubject_FK_sStudent", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblDetailEO.FK_sSubject));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sStudent", _tblDetailEO.FK_sStudent));
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

        /// <summary> 7. SelectByFK_sStudent </summary>
        /// <param name="_tblDetailEO"></param>
        /// <returns></returns>
        public static DataSet SelectByFK_sStudent(tblDetailEO _tblDetailEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDetail_SelectByFK_sStudent", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sStudent", _tblDetailEO.FK_sStudent));
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

        /// <summary> 8. Detail_Search </summary>
        /// <param name="_tblDetailEO"></param>
        /// <returns></returns>
        public static DataSet Detail_Search(tblDetailEO _tblDetailEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblDetail_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lCaHoc", _tblDetailEO.PK_lCaHoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblDetailEO.FK_sSubject));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sStudent", _tblDetailEO.FK_sStudent));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTitle", _tblDetailEO.sTitle));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tDateStart", _tblDetailEO.tDateStart));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@tDateEnd", _tblDetailEO.tDateEnd));
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