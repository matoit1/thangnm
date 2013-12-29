using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using nguyenmanhthang.Library.DataBase;
using System.Data;

namespace nguyenmanhthang
{
    public partial class AnimatedPictures : System.Web.UI.Page
    {
        #region "Khai Báo Biến, Thuộc tính"
        public DataSet _List;
        public DataSet  ListIdImage
        {
            get { return (DataSet)ViewState["ListIdImage"]; }
            set { ViewState["ListIdImage"] = value; }
        }
        #endregion


        public Int32 idImage
        {
            get { return Convert.ToInt32(ViewState["idImage"]); }
            set { ViewState["idImage"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                idImage = 0;
                DataSet slImages = new DataSet();
                slImages = loadLinkImage();
                imgAnimatedPictures.ImageUrl = slImages.Tables[0].Rows[idImage]["Topic_LinkImage"].ToString();
            }
        }

        public DataSet loadLinkImage()
        {
            DataSet slImages = new DataSet();
            slImages = LoadAnimationDAO.Topic_SelectListbyTopic_Category(100, 57);

            //string Key = "0";
            //string Value = "Ảnh 0";
            //slImages.Add(Key, Value);
            //Key = "1";
            //Value = "Ảnh 1";
            //slImages.Add(Key, Value);
            //Key = "2";
            //Value = "Ảnh 2";
            //slImages.Add(Key, Value);
            //ddlSileShow.DataSource = slImages;
            //ddlSileShow.DataTextField = "Value";
            //ddlSileShow.DataValueField = "Key";
            //ddlSileShow.DataBind();
            return slImages;
        }

        //public SortedList loadLinkImage()
        //{
        //    SortedList slImages = new SortedList();
        //    //slImages = LoadAnimationDAO.Topic_SelectListbyTopic_Status(true);

        //    string Key = "0";
        //    string Value = "Ảnh 0";
        //    slImages.Add(Key, Value);
        //    Key = "1";
        //    Value = "Ảnh 1";
        //    slImages.Add(Key, Value);
        //    Key = "2";
        //    Value = "Ảnh 2";
        //    slImages.Add(Key, Value);
        //    ddlSileShow.DataSource = slImages;
        //    ddlSileShow.DataTextField = "Value";
        //    ddlSileShow.DataValueField = "Key";
        //    ddlSileShow.DataBind();
        //    return slImages;
        //    //imgAnimatedPictures.ImageUrl = slImages.GetKey(0).ToString();
        //}

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            DataSet slImages = new DataSet();
            try
            {
                idImage = idImage + 1;
                slImages = loadLinkImage();
                imgAnimatedPictures.ImageUrl = slImages.Tables[0].Rows[idImage]["Topic_LinkImage"].ToString();
            }
            catch (Exception ex) { lblMsg.Text = ex.Message;
            idImage = 0;
            imgAnimatedPictures.ImageUrl = slImages.Tables[0].Rows[idImage]["Topic_LinkImage"].ToString();
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            DataSet slImages = new DataSet();
            try
            {
                idImage = idImage - 1;
                slImages = loadLinkImage();
                imgAnimatedPictures.ImageUrl = slImages.Tables[0].Rows[idImage]["Topic_LinkImage"].ToString();
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                idImage = slImages.Tables[0].Rows.Count-1;
                imgAnimatedPictures.ImageUrl = slImages.Tables[0].Rows[idImage]["Topic_LinkImage"].ToString();
            }
        }

    }
}