using System.Linq;
using System.Collections.Generic;
using System;
namespace NumbersToWords.Models
{
    public class NumToWord
    {
         public static Dictionary<int,string> ones = new Dictionary<int, string>{{0,""},{1,"one"},{2,"two"},{3,"three"},{4,"four"},{5,"five"},{6,"six"},{7,"seven"},{8,"eight"},{9,"nine"}};
        public static Dictionary<int,string> tens = new Dictionary<int,string>{{0,""},{1,"ten"},{2,"twenty"},{3,"thirty"},{4,"fourty"},{5,"fifty"},{6,"sixty"},{7,"seventy"},{8,"eighty"},{9,"ninety"}};

        public static Dictionary<int,string> t = new Dictionary<int, string>{{11,"eleven"},{12,"twelve"},{13,"thirteen"},{14,"fourteen"},{15,"fifteen"},{16,"sixteen"},{17,"seventeen"},{18,"eighteen"},{19,"nineteen"}};
        public static string[] p = new string[]{"","thousand","million","billion","trillion"};

        public List<int[]> MakeListOfThreeElementArrays(List<int> list){
            List<int[]> newList = new List<int[]>();
            while(true)
            {
                int[] item = list.Take(3).ToArray();
                newList.Add(item);
                if(list.Count < 3) break;
                list.RemoveRange(0,3);
                if(list.Count == 0) break;
            } 
            return newList;
        }

        public string ConvertArrayToWords(int[] arr){
            string rs = "";
            rs = ones[arr[0]];
            if(arr.Length > 1){
                //ternary expression in case a number place value is zero
                rs = tens[arr[1]] + ((arr[0]!=0) ? " " : "") + rs;
                if(arr[1] == 1 && arr[0] != 0){
                    string teens = arr[1].ToString() + arr[0].ToString();
                    rs = t[int.Parse(teens)];
                }
            }
            if(arr.Length > 2){
                 //ternary expression in case a number place value is zero
                rs = (ones[arr[2]] + " hundred") + ((arr[1]!=0) ? " " : "") + rs;
            }
            return rs;
        }

        public string ConvertListOfArraysToString(List<int[]> list){
            string ns = "";
            for(int i = 0; i < list.Count; i++){
                string temp =  ConvertArrayToWords(list[i]) + " " + p[i];
                ns = temp + " " + ns;
            }
            Console.WriteLine(ns);
            return ns.Trim();
        }

        public string Convert(int num){
            string iS = num.ToString();
            char[] ca = iS.ToCharArray().Reverse().ToArray();
            List<int> ia = ca.Select(p=>int.Parse(p.ToString())).ToList();
            List<int[]> la = MakeListOfThreeElementArrays(ia);  
            string str = ConvertListOfArraysToString(la);
            return str;
        }
    }
}