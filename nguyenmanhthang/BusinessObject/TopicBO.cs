using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityObject;
using DataAccessObject;
using System.Data;

namespace BusinessObject
{
    public class TopicBO
    {
        // 1. Topic_Insert
        public static bool Topic_Insert(int Topic_Author, string Topic_Title, string Topic_LinkImage, string Topic_Category, string Topic_Tag, string Topic_Content, int Topic_Visit, bool Topic_Status)
        {
            TopicEO _TopicEO = new TopicEO();
            _TopicEO.Topic_Author = Topic_Author;
            _TopicEO.Topic_Title = Topic_Title;
            _TopicEO.Topic_LinkImage = Topic_LinkImage;
            _TopicEO.Topic_Category = Topic_Category;
            _TopicEO.Topic_Tag = Topic_Tag;
            _TopicEO.Topic_Content = Topic_Content;
            _TopicEO.Topic_Visit = Topic_Visit;
            _TopicEO.Topic_Status = Topic_Status;
            if (TopicDAO.Topic_Insert(_TopicEO))
                return true;
            else
                return false;
        }

        // 2. Topic_Update
        public static bool Topic_Update(Int64 Topic_ID, int Topic_Author, string Topic_Title, string Topic_Category, string Topic_Tag, string Topic_Content, int Topic_Visit, bool Topic_Status)
        {
            TopicEO _TopicEO = new TopicEO();
            _TopicEO.Topic_ID = Topic_ID;
            _TopicEO.Topic_Author = Topic_Author;
            _TopicEO.Topic_Title = Topic_Title;
            _TopicEO.Topic_Category = Topic_Category;
            _TopicEO.Topic_Tag = Topic_Tag;
            _TopicEO.Topic_Content = Topic_Content;
            _TopicEO.Topic_Visit = Topic_Visit;
            _TopicEO.Topic_Status = Topic_Status;
            if (TopicDAO.Topic_Update(_TopicEO))
                return true;
            else
                return false;
        }

        // 3. Topic_Delete
        public static bool Topic_Delete(Int64 Topic_ID)
        {
            TopicEO _TopicEO = new TopicEO();
            _TopicEO.Topic_ID = Topic_ID;
            if (TopicDAO.Topic_Delete(_TopicEO))
                return true;
            else
                return false;
        }

        // 4. Topic_Block
        public static bool Topic_Block(Int64 Topic_ID, bool Topic_Status)
        {
            TopicEO _TopicEO = new TopicEO();
            _TopicEO.Topic_ID = Topic_ID;
            _TopicEO.Topic_Status = Topic_Status;
            if (TopicDAO.Topic_Block(_TopicEO))
                return true;
            else
                return false;
        }

        // 5. Topic_SelectListbyTopic_Status
        public static DataSet Topic_SelectListbyTopic_Status(bool Topic_Status)
        {
            TopicEO _TopicEO = new TopicEO();
            _TopicEO.Topic_Status = Topic_Status;
            DataSet ds = TopicDAO.Topic_SelectListbyTopic_Status(_TopicEO);
            return ds;
        }

        // 6. Topic_getTopicbyTopic_ID
        public static DataSet Topic_getTopicbyTopic_ID(Int64 Topic_ID)
        {
            TopicEO _TopicEO = new TopicEO();
            _TopicEO.Topic_ID = Topic_ID;
            DataSet ds = TopicDAO.Topic_getTopicbyTopic_ID(_TopicEO);
            return ds;
        }

        // 7. Topic_SelectListToShow
        public static DataSet Topic_SelectListToShow(bool Topic_Status, int Quantity)
        {
            TopicEO _TopicEO = new TopicEO();
            _TopicEO.Topic_Status = Topic_Status;
            DataSet ds = TopicDAO.Topic_SelectListToShow(_TopicEO, Quantity);
            return ds;
        }

        // 8. Topic_ASC_Visit
        public static bool Topic_ASC_Visit(Int64 Topic_ID)
        {
            TopicEO _TopicEO = new TopicEO();
            _TopicEO.Topic_ID = Topic_ID;
            if (TopicDAO.Topic_ASC_Visit(_TopicEO))
                return true;
            else
                return false;
        }
    }
}
