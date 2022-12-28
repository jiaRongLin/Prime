using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    public class Prime
    {/// <summary>
    /// 判斷是否為質數
    /// </summary>
    /// <param name="Values">輸入大於2的數字</param>
    /// <returns>回傳輸入值是否為質數</returns>
        public static string Prime_Num(int Values)
        {
            if (Values < 2) { return "請輸入大於2的值!!"; }
            if (Values == 2) { return Values + "是質數!!"; }
            if (Values %2 == 0){ return Values + "不是質數!!"; }
            for (int i = 3; i <= Math.Sqrt(Values); i+=2)
            {
                if (Values % i == 0)
                {
                    return Values+ "不是質數!!";
                }
            }
            return Values + "是質數!!";
        }
        //計算區間內的數字是否為質數
        public static string Prime_Range(int x, int y)
        {
            string result = string.Empty;
            for (int num=x; num <= y; num++)
            {
              result +=Prime_Num(num)+"\n";   
            }return result;
        }
    }
}
