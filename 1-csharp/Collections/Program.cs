using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays();
        }

        static void Arrays()
        {
            int[] intArr = new int[4];

            intArr[0] = 3;
            intArr[1] = 5;

            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i]);
            }
            /*
                OR

                int[] intArr = {3, 5, 0, 0};
             */

             int[] intArr2 = {3,5,0,0};
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i]);
            }
        }

        static void Lists()
        {

        }

        static void OtherCollections()
        {
            /* Sets */

            // sets have no defined order or concept of duplicates
            var set = new HashSet<string> {"a","b","a"}; // set size = 2

            // find(), insert, and remove in sets are faster than list

            /* Maps */

            // dictionary
            var dict = new Dictionary<int, int>
            {
                [1] = 1,
                [3] = 9,
                [2] = 4

            };

            var dict2 = new Dictionary<string,string>
            {
                ["abc"] = "def",
                ["def"] = "qwe"
            };

            var equals_qwe = dict2["def"];
        }
    }
}
