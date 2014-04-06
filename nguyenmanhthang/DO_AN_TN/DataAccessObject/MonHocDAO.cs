using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class MonHocDAO
    {
        #region "CheckExists"
        /// <summary> 1. MonHoc_CheckExists_PK_sMaMonhoc </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_CheckExists_PK_sMaMonhoc(MonHocEO _MonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_CheckExists_PK_sMaMonhoc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
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

        /// <summary> 2. MonHoc_CheckExists_sTenMonhoc </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_CheckExists_sTenMonhoc(MonHocEO _MonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_CheckExists_sTenMonhoc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sTenMonhoc", _MonHocEO.sTenMonhoc));
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
        /// <summary> 2. MonHoc_Insert </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_Insert(MonHocEO _MonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@sTenMonhoc", _MonHocEO.sTenMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@iSotrinh", _MonHocEO.iSotrinh));
                    cmd.Parameters.Add(new SqlParameter("@iSotietday", _MonHocEO.iSotietday));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _MonHocEO.iTrangThai));
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

        /// <summary> 3. MonHoc_Update </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_Update(MonHocEO _MonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@sTenMonhoc", _MonHocEO.sTenMonhoc));
                    cmd.Parameters.Add(new SqlParameter("@iSotrinh", _MonHocEO.iSotrinh));
                    cmd.Parameters.Add(new SqlParameter("@iSotietday", _MonHocEO.iSotietday));
                    cmd.Parameters.Add(new SqlParameter("@iTrangThai", _MonHocEO.iTrangThai));
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

        /// <summary> 4. MonHoc_Delete </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static bool MonHoc_Delete(MonHocEO _MonHocEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
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

        /// <summary> 5. MonHoc_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool MonHoc_DeleteList(String _ListPK_sMaMonhoc)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMonHoc_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_sMaMonhoc", _ListPK_sMaMonhoc));
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
        /// <summary> 6. MonHoc_SelectItem </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static MonHocEO MonHoc_SelectItem(MonHocEO _MonHocEO)
        {
            MonHocEO oOutput = new MonHocEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.MonHoc(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. MonHoc_SelectList </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static DataSet MonHoc_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_SelectList", conn);
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

        /// <summary> 8. MonHoc_Search </summary>
        /// <param name="_MonHocEO"></param>
        /// <returns></returns>
        public static DataSet MonHoc_Search(MonHocEO _MonHocEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMonHoc_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_sMaMonhoc", _MonHocEO.PK_sMaMonhoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sTenMonhoc", _MonHocEO.sTenMonhoc));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iSotrinh", _MonHocEO.iSotrinh));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iSotietday", _MonHocEO.iSotietday));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iTrangThai", _MonHocEO.iTrangThai));
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