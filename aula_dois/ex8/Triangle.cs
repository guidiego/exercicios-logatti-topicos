using System;
using System.Collections.Generic;

namespace ex8 {
    class Triangle {
        private List<int> data;

        public Triangle(Dictionary<String, String> data) {
            this.data = new List<int>();
            foreach(KeyValuePair<string, string> entry in data) {
                this.data.Add(Convert.ToInt32(entry.Value));
            }
        }

        public bool isOkey() {
            bool isOkey = false;

            for (var i = 0; i < data.Count; i++) {
                var val = data[i];
                var otherVals = data;

                otherVals.RemoveAt(i);
                isOkey = val > this.sum(otherVals);
            }

            return isOkey;
        }

        private int sum(List<int> values) {
            int total = 0;
            foreach(int v in values) {
                total += v;
            }

            return total;
        }
    }
}
