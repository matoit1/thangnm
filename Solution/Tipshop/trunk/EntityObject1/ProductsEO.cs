using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityObject
{
    public class ProductsEO
    {
        private Int64 _Products_ID;
        private Int64 _Products_Group;
        private Int64 _Products_Parent;
        private string _Products_Name;
        private float _Products_Price;
        private float _Products_Sale;
        private bool _Products_VAT;
        private string _Products_Description;
        private string _Products_Info;
        private string _Products_Origin;
        private string _Products_Image1;
        private string _Products_Image2;
        private string _Products_Image3;
        private string _Products_Image4;
        private string _Products_Image5;
        private string _Products_Video;
        private DateTime _Products_LastUpdate;
        private bool _Products_Visible;

        // 1. Xay dung cac phuong thuc set, get cho Products_ID
        public Int64 Products_ID
        {
            get { return this._Products_ID; }
            set { this._Products_ID = value; }
        }

        // 2. Xay dung cac phuong thuc set, get cho Products_Group
        public Int64 Products_Group
        {
            get { return this._Products_Group; }
            set { this._Products_Group = value; }
        }

        // 3. Xay dung cac phuong thuc set, get cho Products_Parent
        public Int64 Products_Parent
        {
            get { return this._Products_Parent; }
            set { this._Products_Parent = value; }
        }

        // 4. Xay dung cac phuong thuc set, get cho Products_Name
        public string Products_Name
        {
            get { return this._Products_Name; }
            set { this._Products_Name = value; }
        }

        // 5. Xay dung cac phuong thuc set, get cho Products_Price
        public float Products_Price
        {
            get { return this._Products_Price; }
            set { this._Products_Price = value; }
        }

        // 6. Xay dung cac phuong thuc set, get cho Products_Sale
        public float Products_Sale
        {
            get { return this._Products_Sale; }
            set { this._Products_Sale = value; }
        }

        // 7. Xay dung cac phuong thuc set, get cho Products_VAT
        public bool Products_VAT
        {
            get { return this._Products_VAT; }
            set { this._Products_VAT = value; }
        }

        // 8. Xay dung cac phuong thuc set, get cho Products_Description
        public string Products_Description
        {
            get { return this._Products_Description; }
            set { this._Products_Description = value; }
        }

        // 9. Xay dung cac phuong thuc set, get cho Products_Info
        public string Products_Info
        {
            get { return this._Products_Info; }
            set { this._Products_Info = value; }
        }

        // 10. Xay dung cac phuong thuc set, get cho Products_Origin
        public string Products_Origin
        {
            get { return this._Products_Origin; }
            set { this._Products_Origin = value; }
        }

        // 11. Xay dung cac phuong thuc set, get cho ProductImage1
        public string Products_Image1
        {
            get { return this._Products_Image1; }
            set { this._Products_Image1 = value; }
        }

        // 12. Xay dung cac phuong thuc set, get cho ProductImage2
        public string Products_Image2
        {
            get { return this._Products_Image2; }
            set { this._Products_Image2 = value; }
        }

        // 13. Xay dung cac phuong thuc set, get cho Products_Image3
        public string Products_Image3
        {
            get { return this._Products_Image3; }
            set { this._Products_Image3 = value; }
        }

        // 14. Xay dung cac phuong thuc set, get cho Products_Image4
        public string Products_Image4
        {
            get { return this._Products_Image4; }
            set { this._Products_Image4 = value; }
        }

        // 15. Xay dung cac phuong thuc set, get cho Products_Image5
        public string Products_Image5
        {
            get { return this._Products_Image5; }
            set { this._Products_Image5 = value; }
        }

        // 16. Xay dung cac phuong thuc set, get cho Products_Video
        public string Products_Video
        {
            get { return this._Products_Video; }
            set { this._Products_Video = value; }
        }

        // 17. Xay dung cac phuong thuc set, get cho Products_LastUpdate
        public DateTime Products_LastUpdate
        {
            get { return this._Products_LastUpdate; }
            set { this._Products_LastUpdate = value; }
        }

        // 18. Xay dung cac phuong thuc set, get cho Products_Visible
        public bool Products_Visible
        {
            get { return this._Products_Visible; }
            set { this._Products_Visible = value; }
        }
    }
}
