using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityObject;
using System.Data;
using DataAccessObject;

namespace BusinessObject
{
    public class WebsiteBO
    {
        // 1. Insert Website
        public static bool setInsertWebsite(string Website_Title, string Website_Content)
        {
            WebsiteEO _WebsiteEO = new WebsiteEO();
            _WebsiteEO.Website_Title = Website_Title;
            _WebsiteEO.Website_Content = Website_Content;
            if (WebsiteDAO.InsertWebsite(_WebsiteEO))
                return true;
            else
                return false;
        }

        // 2. Update Website
        public static bool setUpdateWebsite(int Website_ID, string Website_Title, string Website_Content)
        {
            WebsiteEO _WebsiteEO = new WebsiteEO();
            _WebsiteEO.Website_ID = Website_ID;
            _WebsiteEO.Website_Title = Website_Title;
            _WebsiteEO.Website_Content = Website_Content;
            if (WebsiteDAO.UpdateWebsite(_WebsiteEO))
                return true;
            else
                return false;
        }

        // 3. DeleteWebsite
        public static bool setDeleteWebsite(int Website_ID)
        {
            if (WebsiteDAO.DeleteWebsite(Website_ID))
                return true;
            else
                return false;
        }

        // 4. getDataSetWebsitebyWebsite_ID
        public static DataSet getDataSetWebsite()
        {
            DataSet ds = WebsiteDAO.DataSetWebsite();
            return ds;
        }

        // 5. getDataSetWebsitebyWebsite_ID
        public static DataSet getDataSetWebsitebyWebsite_ID(int Website_ID)
        {
            DataSet ds = WebsiteDAO.DataSetWebsitebyWebsite_ID(Website_ID);
            return ds;
        }
    }
}
