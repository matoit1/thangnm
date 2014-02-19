using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace TracNghiemTrucTuyen
{
    public class Shared_Libraries
    {
        /// <summary> Random_Array_Not_Duplicate </summary>
        /// <param name="sum">giá trị random max</param>
        /// <param name="num">số lượng giá trị trả về list</param>
        /// <returns>Danh sách num số random nằm trong khoảng 0 -> sum không bị trùng lặp </returns>
        public static List<int> Random_Array_Not_Duplicate(int sum, int num)
        {
            int tmp;
            List<int> lst = new List<int>();
            do
            {
                tmp = Random_Number(0, sum);
                if (lst.Contains(tmp) == false)
                {
                    lst.Add(tmp);
                }
            }
            while (lst.Count < num);
            return lst;
        }


        /// <summary> Random_Number </summary>
        /// <param name="min">giá trị random min</param>
        /// <param name="max">giá trị random max</param>
        /// <returns>1 số trong khoảng min - max</returns>
        public static int Random_Number(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        /// <summary> Get_List_ID_by_List_Index </summary>
        /// <param name="lstIndex"> Danh sách index</param>
        /// <param name="ListID"> Lưu danh sách ID câu hỏi</param>
        /// <returns></returns>
        public static List<int> Get_List_ID_by_List_Index(List<int> lstIndex, DataSet ListID)
        {
            List<int> lst = new List<int>();
            int tmp;
            for (int i = 0; i < lstIndex.Count; i++)
            {
                tmp = Convert.ToInt32(ListID.Tables[0].Rows[lstIndex[i]]["Cauhoi_ID"].ToString());
                lst.Add(tmp);
            }
            return lst;
        }
    }
}