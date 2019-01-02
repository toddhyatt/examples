using System;
using System.Linq;
using System.Collections.Generic;
namespace LinqExample
{
    public class LinqConsole
    {
        public LinqConsole()
        {
        }
        public string RunTop(List<string> stringList)
        {
            string result = string.Empty;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //foreach (string s in stringList)
            //{
            //    sb.AppendLine(s);
            //}
            var x = from y in stringList
                    where y.Contains('-')
                    orderby y.Split('-')[0] ,  SortX(y.Split('-')[1]) descending  
                    group y by (y.Split('-')[0]) into z
                    select  z.First();
            foreach (string s in x)
            {
                sb.AppendLine(s);
            }
            result = sb.ToString();



            return result;
        }
        public int SortX(string invalue)
        {
            int result = 0;
            switch (invalue)
            {
                case "one":
                    result = 1;
                    break;
                case "two":
                    result = 2;
                    break;
                case "three":
                    result = 3;
                    break;
                default:
                    result = 99;
                    break;

            }
            return result;

        }
    }



}