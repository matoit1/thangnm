﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Shared_Libraries.ChatLIB;

namespace DO_AN_TN.UserControl
{
    public partial class ChatUC : System.Web.UI.UserControl
    {
        #region "Properties & Event"
        //public event EventHandler ViewDetail;
        
        public string sRoom
        {
            get { return (string)ViewState["sRoom"]; }
            set { ViewState["sRoom"] = value; }
        }
        public string sUser
        {
            get { return (string)ViewState["sUser"]; }
            set { ViewState["sUser"] = value; }
        }
        public int iType
        {
            get { return (int)ViewState["iType"]; }
            set { ViewState["iType"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UserName"] = sUser;
            //if (string.IsNullOrEmpty(sUser))
            //    Response.Redirect("~/Test/ChatRoomUC/Default.aspx");
            //if (string.IsNullOrEmpty(sRoom))
            //    Response.Redirect("~/Test/ChatRoomUC/Default.aspx");

            txtMsg.Attributes.Add("onkeypress", "return clickButton(event,'btn')");
            if (!IsPostBack)
            {
                //hdnRoomID.Value = sRoom;
                ChatRoom room = ChatEngine.GetRoom(sRoom);
                string prevMsgs = room.JoinRoom(sUser, sUser);
                txt.Text = prevMsgs;
                foreach (string s in room.GetRoomUsersNames())
                {
                    lstMembers.Items.Add(new ListItem(s, s));
                }

            }
        }

        #region Script Callback functions

        /// <summary>
        /// This function is called from the client script 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="roomID"></param>
        /// <returns></returns>
        [WebMethod]
        static public string SendMessage(string msg, string roomID)
        {
            try
            {
                ChatRoom room = ChatEngine.GetRoom(roomID);
                string res = "";
                if (room != null)
                {
                    res = room.SendMessage(msg, HttpContext.Current.Session["UserName"].ToString());
                }
                return res;
            }
            catch (Exception ex)
            {

            }
            return "";
        }


        /// <summary>
        /// This function is called peridically called from the user to update the messages
        /// </summary>
        /// <param name="otherUserID"></param>
        /// <returns></returns>
        [WebMethod]
        static public string UpdateUser(string roomID)
        {
            try
            {
                ChatRoom room = ChatEngine.GetRoom(roomID);
                if (room != null)
                {
                    string res = "";
                    if (room != null)
                    {
                        res = room.UpdateUser(HttpContext.Current.Session["UserName"].ToString());
                    }
                    return res;
                }
            }
            catch (Exception ex)
            {

            }
            return "";
        }


        /// <summary>
        /// This function is called from the client when the user is about to leave the room
        /// </summary>
        /// <param name="otherUser"></param>
        /// <returns></returns>
        [WebMethod]
        static public string LeaveRoom(string roomID)
        {
            try
            {
                ChatRoom room = ChatEngine.GetRoom(roomID);
                if (room != null)
                    room.LeaveRoom(HttpContext.Current.Session["UserName"].ToString());
            }
            catch (Exception ex)
            {

            }
            return "";
        }


        /// <summary>
        /// Returns a comma separated string containing the names of the users currently online
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns></returns>
        [WebMethod]
        static public string UpdateRoomMembers(string roomID)
        {
            try
            {
                ChatRoom room = ChatEngine.GetRoom(roomID);
                if (room != null)
                {
                    IEnumerable<string> users = room.GetRoomUsersNames();
                    string res = "";

                    foreach (string s in users)
                    {
                        res += s + ",";
                    }
                    return res;
                }
            }
            catch (Exception ex)
            {
            }
            return "";
        }
        #endregion
    }
}