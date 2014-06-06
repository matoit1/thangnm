using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using EntityObject;

namespace DataAccessObject
{
    public class tblMaterialDAO
    {
        #region "CheckExists"
        /// <summary> 1. Material_CheckExists </summary>
        /// <param name="_tblMaterialEO"></param>
        /// <returns></returns>
        public static bool Material_CheckExists(tblMaterialEO _tblMaterialEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                bool bOutput = false;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMaterial_CheckExists", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lMaMaterial", _tblMaterialEO.PK_lMaterial));
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
        /// <summary> 2. Material_Insert </summary>
        /// <param name="_tblMaterialEO"></param>
        /// <returns></returns>
        public static bool Material_Insert(tblMaterialEO _tblMaterialEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMaterial_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblMaterialEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sUsername", _tblMaterialEO.FK_sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sDescription", _tblMaterialEO.sDescription));
                    cmd.Parameters.Add(new SqlParameter("@sLinkDownload", _tblMaterialEO.sLinkDownload));
                    cmd.Parameters.Add(new SqlParameter("@iSize", _tblMaterialEO.iSize));
                    cmd.Parameters.Add(new SqlParameter("@iType", _tblMaterialEO.iType));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _tblMaterialEO.iStatus));
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

        /// <summary> 3. Material_Update </summary>
        /// <param name="_tblMaterialEO"></param>
        /// <returns></returns>
        public static bool Material_Update(tblMaterialEO _tblMaterialEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMaterial_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lMaterial", _tblMaterialEO.PK_lMaterial));
                    cmd.Parameters.Add(new SqlParameter("@FK_sSubject", _tblMaterialEO.FK_sSubject));
                    cmd.Parameters.Add(new SqlParameter("@FK_sUsername", _tblMaterialEO.FK_sUsername));
                    cmd.Parameters.Add(new SqlParameter("@sDescription", _tblMaterialEO.sDescription));
                    cmd.Parameters.Add(new SqlParameter("@sLinkDownload", _tblMaterialEO.sLinkDownload));
                    cmd.Parameters.Add(new SqlParameter("@iSize", _tblMaterialEO.iSize));
                    cmd.Parameters.Add(new SqlParameter("@iType", _tblMaterialEO.iType));
                    cmd.Parameters.Add(new SqlParameter("@iStatus", _tblMaterialEO.iStatus));
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

        /// <summary> 4. Material_Delete </summary>
        /// <param name="_tblMaterialEO"></param>
        /// <returns></returns>
        public static bool Material_Delete(tblMaterialEO _tblMaterialEO)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMaterial_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PK_lMaterial", _tblMaterialEO.PK_lMaterial));
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

        /// <summary> 5. Material_DeleteList </summary>
        /// <param name="_ListPK_sMaMonhoc"></param>
        /// <returns></returns>
        public static bool Material_DeleteList(String _ListPK_lMaterial)
        {
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("tblMaterial_DeleteList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ListPK_lMaterial", _ListPK_lMaterial));
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
        /// <summary> 6. Material_SelectItem </summary>
        /// <param name="_tblMaterialEO"></param>
        /// <returns></returns>
        public static tblMaterialEO Material_SelectItem(tblMaterialEO _tblMaterialEO)
        {
            tblMaterialEO oOutput = new tblMaterialEO();
            DataSet ds = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMaterial_SelectItem", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lMaterial", _tblMaterialEO.PK_lMaterial));
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    oOutput = DataSet2Object.Material(ds);
                    return oOutput;
                }
                catch (Exception)
                {
                    conn.Close();
                    return oOutput;
                }
            }
        }

        /// <summary> 7. Material_SelectList </summary>
        /// <param name="_tblMaterialEO"></param>
        /// <returns></returns>
        public static DataSet Material_SelectList()
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMaterial_SelectList", conn);
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

        /// <summary> 7. Material_SelectByFK_sSubject </summary>
        /// <param name="_tblMaterialEO"></param>
        /// <returns></returns>
        public static DataSet Material_SelectByFK_sSubject(tblMaterialEO _tblMaterialEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMaterial_SelectByFK_sSubject", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblMaterialEO.FK_sSubject));
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

        /// <summary> 8. Material_Search </summary>
        /// <param name="_tblMaterialEO"></param>
        /// <returns></returns>
        public static DataSet Material_Search(tblMaterialEO _tblMaterialEO)
        {
            DataSet dsOutput = null;
            using (SqlConnection conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("tblMaterial_Search", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add(new SqlParameter("@PK_lMaterial", _tblMaterialEO.PK_lMaterial));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sSubject", _tblMaterialEO.FK_sSubject));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@FK_sUsername", _tblMaterialEO.FK_sUsername));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sDescription", _tblMaterialEO.sDescription));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@sLinkDownload", _tblMaterialEO.sLinkDownload));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iSize", _tblMaterialEO.iSize));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iType", _tblMaterialEO.iType));
                    da.SelectCommand.Parameters.Add(new SqlParameter("@iStatus", _tblMaterialEO.iStatus));
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