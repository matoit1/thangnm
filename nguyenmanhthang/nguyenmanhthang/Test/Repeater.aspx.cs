using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyenmanhthang.Test
{
    public partial class Repeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        public int PageSize
        {
            get
            {
                try
                {
                    return Request.QueryString["pagesize"] != null ? int.Parse(Request.QueryString["pagesize"]) : 10;
                }
                catch
                {
                    return 10;
                }
            }
        }

        public int PageIndex
        {
            get
            {
                return Request.QueryString["trang"] != null ? int.Parse(Request.QueryString["trang"]) : 1;
            }
        }

        public string BindPaging(int total)
        {
            var url = UrlRoot + "/Repeater.aspx" + (PageSize == 30 ? "?" : "?pagesize=" + PageSize + "&");

            var html = "";
            var nSumOfPage = (total - 1) / PageSize + 1;
            var nPageShow = nSumOfPage > 7 ? 7 : nSumOfPage;
            if (nSumOfPage > 1 || total > PageSize)
            {
                if (PageIndex > 1)
                {
                    html += "<li class=\"first\"><a href=\"" + url + "trang=1" + "\" ><< Đầu tiên</a></li>";
                    html += "<li class=\"previous\"><a href=\"" + url + "trang=" + (PageIndex - 1) + "\">< Trước</a></li>";
                }
                var delta = 0;
                for (var i = 0; i < nPageShow; i++)
                {
                    var number = PageIndex - 3 + i;
                    if (number <= 0)
                    {
                        delta = 3 + 1 - PageIndex;
                    }
                    if (number > nSumOfPage)
                    {
                        break;
                    }
                    number += delta;
                    if (number == PageIndex)
                    {
                        html += "<li class=\"pages selected\"><a>" + number + "</a></li>";
                    }
                    else
                    {
                        html += "<li class=\"pages\"><a href=\"" + url + "trang=" + number + "\" >" + number + "</a></li>";
                    }
                }
                if (PageIndex < nSumOfPage)
                {
                    html += "<li class=\"next\"><a href=\"" + url + "trang=" + (PageIndex + 1) + "\">Tiếp theo ></a></li>";
                    html += "<li class=\"last\"><a href=\"" + url + "trang=" + (nSumOfPage) + "\">Cuối >></a></li>";
                }
            }
            return html;
        }

        private void LoadData()
        {
            //var _userBll = new UserBLL(getCurrentConnection());
            //var dt = _userBll.GetAllUserForGridView(PageIndex, PageSize, -1);
            //rpData.DataSource = dt;
            //rpData.DataBind();
            //if (dt != null && dt.Count > 0)
            //{
            //    var total = _userBll.GetAllUserRowCount(-1);
            //    Paging.InnerHtml = BindPaging(total);
            //}

        }

        public string UrlRoot { get; set; }
    }
}