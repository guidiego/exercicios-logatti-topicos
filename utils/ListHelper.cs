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

        public static List<int> GetIntListByProp(List<Dictionary<String, String>> listData, String prop) {
            List<int> list = new List<int>();
            foreach(Dictionary<String, String> data in listData) {
                list.Add(Convert.ToInt32(data[prop]));
            }

            return list;
        }

        public static List<int> Desc(List<int> values) {
            values.Sort((a, b) => -1* a.CompareTo(b));
            return values;
        }
    }
}
