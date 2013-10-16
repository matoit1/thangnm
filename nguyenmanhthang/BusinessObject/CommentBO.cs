using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessObject;
using EntityObject;

namespace BusinessObject
{
    public class CommentBO
    {
        // 1. Comment_Insert
        public static bool Comment_Insert(Int64 Topic_ID, string Comment_Name, string Comment_Email, string Comment_Website, string Comment_Content, bool Comment_Status)
        {
            CommentEO _CommentEO = new CommentEO();
            _CommentEO.Topic_ID = Topic_ID;
            _CommentEO.Comment_Name = Comment_Name;
            _CommentEO.Comment_Email = Comment_Email;
            _CommentEO.Comment_Website = Comment_Website;
            _CommentEO.Comment_Content = Comment_Content;
            _CommentEO.Comment_Status = Comment_Status;
            if (CommentDAO.Comment_Insert(_CommentEO))
                return true;
            else
                return false;
        }

        // 2. Comment_Update
        public static bool Comment_Update(Int64 Comment_ID, Int64 Topic_ID, string Comment_Name, string Comment_Email, string Comment_Website, string Comment_Content, bool Comment_Status)
        {
            CommentEO _CommentEO = new CommentEO();
            _CommentEO.Comment_ID = Comment_ID;
            _CommentEO.Topic_ID = Topic_ID;
            _CommentEO.Comment_Name = Comment_Name;
            _CommentEO.Comment_Email = Comment_Email;
            _CommentEO.Comment_Website = Comment_Website;
            _CommentEO.Comment_Content = Comment_Content;
            _CommentEO.Comment_Status = Comment_Status;
            if (CommentDAO.Comment_Update(_CommentEO))
                return true;
            else
                return false;
        }

        // 3. Comment_Delete
        public static bool Comment_Delete(Int64 Comment_ID)
        {
            CommentEO _CommentEO = new CommentEO();
            _CommentEO.Comment_ID = Comment_ID;
            if (CommentDAO.Comment_Delete(_CommentEO))
                return true;
            else
                return false;
        }

        // 4. Comment_Block
        public static bool Comment_Block(Int64 Comment_ID, bool Comment_Status)
        {
            CommentEO _CommentEO = new CommentEO();
            _CommentEO.Comment_ID = Comment_ID;
            _CommentEO.Comment_Status = Comment_Status;
            if (CommentDAO.Comment_Block(_CommentEO))
                return true;
            else
                return false;
        }

        // 5. Comment_SelectListbyTopic_ID
        public static DataSet Comment_SelectListbyTopic_ID(Int64 Topic_ID)
        {
            CommentEO _CommentEO = new CommentEO();
            _CommentEO.Topic_ID = Topic_ID;
            DataSet ds = CommentDAO.Comment_SelectListbyTopic_ID(_CommentEO);
            return ds;
        }
    }
}
