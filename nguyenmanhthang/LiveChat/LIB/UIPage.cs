using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
namespace LiveChat
{
    /// <summary>
    /// Summary description for UIPage
    /// </summary>
    public static class UIPage
    {
        #region BindAdminGrid
        /// <summary>
        /// binds grid view. adds new row and assumes that you're allowing deletions
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="gv"></param>
        public static void BindAdminGrid<T>(List<T> list, GridView gv)
        {
            BindAdminGrid<T>(list, gv, Activator.CreateInstance<T>(), true, true);
        }
        /// <summary>
        /// Binds grid view. lets you specify is there is a "new" row. assumes it has delete column
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="gv"></param>
        /// <param name="addNewRow"></param>
        public static void BindAdminGrid<T>(List<T> list, GridView gv, bool addNewRow)
        {
            BindAdminGrid<T>(list, gv, Activator.CreateInstance<T>(), addNewRow, true);
        }
        /// <summary>
        /// Binds grid view. lets you specify is there is a "new" row. allows you to specify if it has delete column
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="gv"></param>
        /// <param name="addNewRow"></param>
        /// <param name="hasDelete"></param>
        public static void BindAdminGrid<T>(List<T> list, GridView gv, bool addNewRow, bool hasDelete)
        {
            BindAdminGrid<T>(list, gv, Activator.CreateInstance<T>(), addNewRow, hasDelete);
        }
        /// <summary>
        /// binds grid view. uses new item that you pass in. adds new row and assumes that you're allowing deletions.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="gv"></param>
        /// <param name="newItem"></param>
        public static void BindAdminGrid<T>(List<T> list, GridView gv, T newItem)
        {
            BindAdminGrid<T>(list, gv, newItem, true, true);
        }
        /// <summary>
        /// binds grid view. uses new item that you pass in. lets you specify is there is a "new" row. allows you 
        /// to specify if it has delete column.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="gv"></param>
        /// <param name="newItem"></param>
        /// <param name="addNewRow"></param>
        /// <param name="hasDelete"></param>
        public static void BindAdminGrid<T>(List<T> list, GridView gv, T newItem, bool addNewRow, bool hasDelete)
        {
            if (addNewRow)
            {
                list.Add(newItem);
            }

            gv.DataSource = list;
            gv.DataBind();

            if (addNewRow)
            {
                gv.Rows[gv.Rows.Count - 1].CssClass = "new";
                LinkButton lb = (LinkButton)gv.Rows[gv.Rows.Count - 1].Cells[0].Controls[0];
                if (gv.EditIndex != gv.Rows.Count - 1)
                {
                    lb.Text = "Add";
                    if (hasDelete)
                    {
                        gv.Rows[gv.Rows.Count - 1].Cells[gv.Columns.Count - 1].Controls[0].Visible = false;
                    }
                }
                else
                {
                    lb.Text = "Save";
                }
            }
        }
        #endregion

        #region BindList
        /// <summary>
        /// Binds list control with given datasource
        /// </summary>
        /// <param name="list"></param>
        /// <param name="datasource"></param>
        /// <param name="rowKey"></param>
        /// <param name="rowText"></param>
        /// <returns></returns>
        public static ListControl BindList(ListControl list, object datasource, string rowKey, string rowText)
        {
            doBindList(list, datasource, rowKey, rowText);
            return list;
        }
        /// <summary>
        /// Binds list control with given datasource. Inserts the text you set as the first item with value = "0"
        /// </summary>
        /// <param name="list"></param>
        /// <param name="datasource"></param>
        /// <param name="rowKey"></param>
        /// <param name="rowText"></param>
        /// <param name="initialText"></param>
        /// <returns></returns>
        public static ListControl BindList(ListControl list, object datasource, string rowKey, string rowText, string initialText)
        {
            BindList(list, datasource, rowKey, rowText, initialText, "0");
            return list;
        }
        /// <summary>
        /// Binds list control with given datasource. Inserts the text/value you set as the first item.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="datasource"></param>
        /// <param name="rowKey"></param>
        /// <param name="rowText"></param>
        /// <param name="initialText"></param>
        /// <param name="initialValue"></param>
        /// <returns></returns>
        public static ListControl BindList(ListControl list, object datasource, string rowKey, string rowText, string initialText, string initialValue)
        {
            doBindList(list, datasource, rowKey, rowText);
            list.Items.Insert(0, new ListItem(initialText, initialValue));
            return list;
        }
        /// <summary>
        /// this is the private function that does the binding.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="datasource"></param>
        /// <param name="rowKey"></param>
        /// <param name="rowText"></param>
        private static void doBindList(ListControl list, object datasource, string rowKey, string rowText)
        {
            if (datasource == null)
            {
                list.Items.Clear();
            }
            else
            {
                list.DataSource = datasource;
                list.DataValueField = rowKey;
                list.DataTextField = rowText;
            }
            list.DataBind();
        }
        #endregion
        #region BindListSimple
        /// <summary>
        /// Binds list control with given datasource
        /// </summary>
        /// <param name="list"></param>
        /// <param name="datasource"></param>
        /// <param name="rowKey"></param>
        /// <param name="rowText"></param>
        /// <returns></returns>
        public static ListControl BindListSimple(ListControl list, object datasource)
        {
            doBindListSimple(list, datasource);
            return list;
        }
        /// <summary>
        /// Binds list control with given datasource. Inserts the text you set as the first item with value = "0"
        /// </summary>
        /// <param name="list"></param>
        /// <param name="datasource"></param>
        /// <param name="rowKey"></param>
        /// <param name="rowText"></param>
        /// <param name="initialText"></param>
        /// <returns></returns>
        public static ListControl BindListSimple(ListControl list, object datasource, string initialText)
        {
            BindListSimple(list, datasource, initialText, "0");
            return list;
        }
        /// <summary>
        /// Binds list control with given datasource. Inserts the text/value you set as the first item.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="datasource"></param>
        /// <param name="rowKey"></param>
        /// <param name="rowText"></param>
        /// <param name="initialText"></param>
        /// <param name="initialValue"></param>
        /// <returns></returns>
        public static ListControl BindListSimple(ListControl list, object datasource, string initialText, string initialValue)
        {
            doBindListSimple(list, datasource);
            list.Items.Insert(0, new ListItem(initialText, initialValue));
            return list;
        }
        /// <summary>
        /// this is the private function that does the binding.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="datasource"></param>
        /// <param name="rowKey"></param>
        /// <param name="rowText"></param>
        private static void doBindListSimple(ListControl list, object datasource)
        {
            if (datasource == null)
            {
                list.Items.Clear();
            }
            else
            {
                list.DataSource = datasource;
                list.DataBind();
            }
        }
        #endregion

        #region AppPath
        /// <summary>
        /// Returns the virtual app-path without trailing slash.
        /// </summary>
        public static string appPath = null;
        public static string AppPath
        {
            get
            {
                if (appPath == null)
                    appPath = HttpContext.Current.Request.ApplicationPath.TrimEnd("/".ToCharArray());
                return appPath;
            }
        }
        #endregion

        #region columnList

        static Dictionary<string, Dictionary<string, int>> columnLists = new Dictionary<string, Dictionary<string, int>>();
        static Dictionary<string, DateTime> columnListsCacheTime = new Dictionary<string, DateTime>();

        static object lockObject = new object();
        const double CACHE_TIME = 4;
        /// <summary>
        /// caches a copy of the column list. 
        /// </summary>
        /// <param name="gvMain"></param>
        /// <returns>
        /// Key--> column is BoundField ? DataField : HeaderText;
        /// Value--> index of column
        /// </returns>
        public static Dictionary<string, int> GetColumnList(GridView gvMain)
        {
            string page = HttpContext.Current.Request.Path;
            if (!columnLists.ContainsKey(page) || columnListsCacheTime[page] < DateTime.Now.AddHours(-CACHE_TIME))
            {
                lock (lockObject)
                {
                    if (!columnLists.ContainsKey(page))
                    {
                        AddColumnList(gvMain, page);
                    }
                    else if (columnListsCacheTime[page] < DateTime.Now.AddHours(-CACHE_TIME))
                    {
                        columnLists.Remove(page);
                        columnListsCacheTime.Remove(page);
                        AddColumnList(gvMain, page);
                    }
                }
            }
            return columnLists[page];
        }

        private static void AddColumnList(GridView gvMain, string page)
        {
            Dictionary<string, int> columnList = new Dictionary<string, int>(gvMain.Columns.Count);
            Dictionary<string, int> columnListSort = new Dictionary<string, int>();
            for (int i = 0; i < gvMain.Columns.Count; i++)
            {
                string name;
                if (gvMain.Columns[i] is BoundField)
                {
                    name = ((BoundField)gvMain.Columns[i]).DataField;

                }
                else
                {
                    name = gvMain.Columns[i].HeaderText.ToLower();
                }
                columnList.Add(name, i);
                string sort = gvMain.Columns[i].SortExpression.ToLower();
                if (sort.Length > 0 && name != sort)
                    columnListSort.Add(sort, i);
            }

            foreach (KeyValuePair<string, int> item in columnListSort)
            {
                if (!columnList.ContainsKey(item.Key))
                    columnList.Add(item.Key, item.Value);
            }
            columnLists.Add(page, columnList);
            columnListsCacheTime.Add(page, DateTime.Now);
        }
        #endregion

        #region Export To Excel
        public static void ExportToExcel(GridView gv)
        {
            HttpResponse Response = HttpContext.Current.Response;

            Response.ClearHeaders();
            Response.ClearContent();
            Response.Buffer = true;//make sure that the entire output is rendered simultaneously
            Response.AddHeader("content-disposition", "attachment;filename=report" + ".xls");
            Response.ContentType = "application/vnd.ms-excel";
            Response.Charset = "";

            StringWriter gvStringWriter = new StringWriter();
            HtmlTextWriter gvHtmlTextWriter = new HtmlTextWriter(gvStringWriter);

            ClearControls(gv);
            gv.RenderControl(gvHtmlTextWriter);

            string style = @"<style> .text { mso-number-format:\@; } </style> ";
            Response.Write(style);
            Response.Write(gvStringWriter.ToString());
            Response.End();
        }
        private static void ClearControls(Control control)
        {
            if (!control.Visible)
                return;

            string replaceWithLiteral = null;
            //replace the checkbox with a literal so that the datagrid content can be rendered
            if (control is Image)
            {
                replaceWithLiteral = ((Image)control).AlternateText;
            }
            else if (control is LinkButton)
            {
                replaceWithLiteral = ((LinkButton)control).Text.Trim();
            }
            else if (control is HtmlAnchor)
            {
                replaceWithLiteral = ((HtmlAnchor)control).InnerText;
            }
            else if (control is HyperLink)
            {
                HyperLink link = (HyperLink)control;
                replaceWithLiteral = (link.Text.Trim().Length > 0) ? link.Text.Trim() : link.ToolTip;
            }

            if (replaceWithLiteral != null)
            {
                if (replaceWithLiteral == "")
                    replaceWithLiteral = "*";

                LiteralControl literal = new LiteralControl();

                control.Parent.Controls.AddAt(control.Parent.Controls.IndexOf(control), literal);
                literal.Text = replaceWithLiteral;

                control.Parent.Controls.Remove(control);
            }
            else
            {
                //otherwise test children.
                for (int i = control.Controls.Count - 1; i >= 0; i--)
                {
                    ClearControls(control.Controls[i]);
                }
            }
            return;
        }
        #endregion

        #region ParseEmpty
        public static float? GetFloat(string s)
        {
            float f;
            if (string.IsNullOrEmpty(s) || !float.TryParse(s, out f))
                return null;
            else
                return f;
        }
        public static int? GetInt(string s)
        {
            int f;
            if (string.IsNullOrEmpty(s) || !int.TryParse(s, out f))
                return null;
            else
                return f;
        }
        public static DateTime? GetDateTime(string s)
        {
            DateTime dt;
            if (string.IsNullOrEmpty(s) || !DateTime.TryParse(s, out dt))
                return null;
            else
                return dt;
        }
        #endregion

        #region set sort image
        /// <summary>
        /// Call whenever you bind your grid...
        /// </summary>
        /// <param name="gv"></param>
        /// <param name="sort"></param>
        private static void SetSortImage(GridView gv, string sort)
        {
            if (gv.Rows.Count > 0)
            {
                int index = 0;
                string[] sortSplit = sort.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (DataControlField col in gv.Columns)
                {
                    if (col.SortExpression == sortSplit[0])
                    {
                        break;
                    }
                    index++;
                }
                if (index < gv.Columns.Count)
                {
                    string url, text;
                    if (sortSplit.Length != 2 || sortSplit[1].ToLower() == "asc")
                    {
                        url = "images/asc.gif";
                        text = "Ascending";
                    }
                    else
                    {
                        url = "images/desc.gif";
                        text = "Descending";
                    }

                    LinkButton lnk = ((LinkButton)gv.HeaderRow.Cells[index].Controls[0]);
                    lnk.Text += "<img src='" + url + "' class='IMG' alt='" + text + "' style='border:0;vertical-align:middle;' />";
                }
            }
        }
        #endregion
    }
}