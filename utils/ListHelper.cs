using System;
using System.Collections.Generic;

namespace utils {
    public class ListHelper {
        public static List<int> ToIntList(Dictionary<String, String> data) {
            var list = new List<int>();
            foreach(KeyValuePair<string, string> entry in data) {
                list.Add(Convert.ToInt32(entry.Value));
            }

            return list;
        }

        public static int Sum(List<int> values) {
            int total = 0;
            foreach(int v in values) {
                total += v;
            }

            return total;
        }
    }
}
