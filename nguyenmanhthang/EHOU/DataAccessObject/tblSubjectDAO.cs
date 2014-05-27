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
    public class tblSubjectDAO
    {
        #region "CheckExists"
        /// <summary> 1. Subject_CheckExists </summary>
        /// <param name="_tblSubjectEO"></param>
        /// <returns></returns>
        public static bool Subject_CheckExists(tblSubjectEO _tblSubjectEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSubject_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sSubject", _tblSubjectEO.PK_sSubject));
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
        /// <summary> 2. Subject_Insert </summary>
        /// <param name="_tblSubjectEO"></param>
        /// <returns></returns>
        public static bool Subject_Insert(tblSubjectEO _tblSubjectEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSubject_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sSubject", _tblSubjectEO.PK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sTeacher", _tblSubjectEO.FK_sTeacher));
                    cmd.Parameters.Add(new SqlParameter("@sName", _tblSubjectEO.sName));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _tblSubjectEO.iStatus));
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

        /// <summary> 3. Subject_Update </summary>
        /// <param name="_tblSubjectEO"></param>
        /// <returns></returns>
        public static bool Subject_Update(tblSubjectEO _tblSubjectEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSubject_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sSubject", _tblSubjectEO.PK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sTeacher", _tblSubjectEO.FK_sTeacher));
                    cmd.Parameters.Add(new SqlParameter("@sName", _tblSubjectEO.sName));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _tblSubjectEO.iStatus));
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

        /// <summary> 4. Subject_Delete </summary>
        /// <param name="_tblSubjectEO"></param>
        /// <returns></returns>
        public static bool Subject_Delete(tblSubjectEO _tblSubjectEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSubject_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sSubject", _tblSubjectEO.PK_sSubject));
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

        /// <summary> 5. Subject_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool Subject_DeleteList(String _ListPK_sSubject)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSubject_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_sSubject", _ListPK_sSubject));
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
        /// <summary> 6. Subject_SelectItem </summary>
        /// <param name="_tblSubjectEO"></param>
        /// <returns></returns>
        public static tblSubjectEO Subject_SelectItem(tblSubjectEO _tblSubjectEO)
        {
            tblSubjectEO oOutput = new tblSubjectEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSubject_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sSubject", _tblSubjectEO.PK_sSubject));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Subject(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 6. Subject_SelectItem_By_PK_sSubject </summary>
        /// <param name="_tblSubjectEO"></param>
        /// <returns></returns>
        public static tblSubjectEO Subject_SelectItem_By_PK_sSubject(string PK_sSubject)
        {
            tblSubjectEO oOutput = new tblSubjectEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSubject_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sSubject", PK_sSubject));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Subject(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. Subject_SelectList </summary>
        /// <param name="_tblSubjectEO"></param>
        /// <returns></returns>
        public static DataSet Subject_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSubject_SelectList", conn);
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

        /// <summary> 7. Subject_SelectByFK_sTeacher </summary>
        /// <param name="_tblSubjectEO"></param>
        /// <returns></returns>
        public static DataSet Subject_SelectByFK_sTeacher(tblSubjectEO _tblSubjectEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSubject_SelectByFK_sTeacher", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sTeacher", _tblSubjectEO.FK_sTeacher));
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

        /// <summary> 8. Subject_Search </summary>
        /// <param name="_tblSubjectEO"></param>
        /// <returns></returns>
        public static DataSet Subject_Search(tblSubjectEO _tblSubjectEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSubject_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sSubject", _tblSubjectEO.PK_sSubject));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sTeacher", _tblSubjectEO.FK_sTeacher));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sName", _tblSubjectEO.sName));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iStatus", _tblSubjectEO.iStatus));
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