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
    public class tblSubject_StudentDAO
    {
        #region "CheckExists"
        /// <summary> 1. Subject_Student_CheckExists </summary>
        /// <param name="_tblSubject_StudentEO"></param>
        /// <returns></returns>
        public static bool Subject_Student_CheckExists(tblSubject_StudentEO _tblSubject_StudentEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSubject_Student_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblSubject_StudentEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sStudent", _tblSubject_StudentEO.FK_sStudent));
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
        /// <summary> 2. Subject_Student_Insert </summary>
        /// <param name="_tblSubject_StudentEO"></param>
        /// <returns></returns>
        public static bool Subject_Student_Insert(tblSubject_StudentEO _tblSubject_StudentEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSubject_Student_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblSubject_StudentEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sStudent", _tblSubject_StudentEO.FK_sStudent));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _tblSubject_StudentEO.iStatus));
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

        /// <summary> 3. Subject_Student_Update </summary>
        /// <param name="_tblSubject_StudentEO"></param>
        /// <returns></returns>
        public static bool Subject_Student_Update(tblSubject_StudentEO _tblSubject_StudentEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSubject_Student_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblSubject_StudentEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sStudent", _tblSubject_StudentEO.FK_sStudent));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _tblSubject_StudentEO.iStatus));
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

        /// <summary> 4. Subject_Student_Delete </summary>
        /// <param name="_tblSubject_StudentEO"></param>
        /// <returns></returns>
        public static bool Subject_Student_Delete(tblSubject_StudentEO _tblSubject_StudentEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSubject_Student_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblSubject_StudentEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sStudent", _tblSubject_StudentEO.FK_sStudent));
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

        /// <summary> 5. Subject_Student_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool Subject_Student_DeleteList(String _ListPK_lSubject_Student)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblSubject_Student_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_lSubject_Student", _ListPK_lSubject_Student));
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
        /// <summary> 6. Subject_Student_SelectItem </summary>
        /// <param name="_tblSubject_StudentEO"></param>
        /// <returns></returns>
        public static tblSubject_StudentEO Subject_Student_SelectItem(tblSubject_StudentEO _tblSubject_StudentEO)
        {
            tblSubject_StudentEO oOutput = new tblSubject_StudentEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSubject_Student_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblSubject_StudentEO.FK_sSubject));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sStudent", _tblSubject_StudentEO.FK_sStudent));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Subject_Student(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }
        /// <summary> 6. Subject_Student_SelectList </summary>
        /// <param name="_tblSubject_StudentEO"></param>
        /// <returns></returns>
        public static DataSet Subject_Student_SelectList()
        {
            tblSubject_StudentEO oOutput = new tblSubject_StudentEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSubject_Student_SelectList", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
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

        /// <summary> 7. Subject_Student_SelectByFK_sSubject </summary>
        /// <param name="_tblSubject_StudentEO"></param>
        /// <returns></returns>
        public static DataSet Subject_Student_SelectByFK_sSubject(tblSubject_StudentEO _tblSubject_StudentEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSubject_Student_SelectByFK_sSubject", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblSubject_StudentEO.FK_sSubject));
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
        /// <param name="_tblSubject_StudentEO"></param>
        /// <returns></returns>
        public static DataSet SelectByFK_sStudent(tblSubject_StudentEO _tblSubject_StudentEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSubject_Student_SelectByFK_sStudent", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sStudent", _tblSubject_StudentEO.FK_sStudent));
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

        /// <summary> 8. Subject_Student_Search </summary>
        /// <param name="_tblSubject_StudentEO"></param>
        /// <returns></returns>
        public static DataSet Subject_Student_Search(tblSubject_StudentEO _tblSubject_StudentEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblSubject_Student_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblSubject_StudentEO.FK_sSubject));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sStudent", _tblSubject_StudentEO.FK_sStudent));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iStatus", _tblSubject_StudentEO.iStatus));
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