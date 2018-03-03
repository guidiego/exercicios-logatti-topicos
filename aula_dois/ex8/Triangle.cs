using System;
using System.Collections.Generic;

using utils;

namespace ex8 {
    class Triangle {
        private List<int> data;

        public Triangle(Dictionary<String, String> data) {
            this.data = ListHelper.ToIntList(data);
        }

        public bool isOkey() {
            bool isOkey = false;

            for (var i = 0; i < data.Count; i++) {
                var val = data[i];
                var otherVals = data;

                otherVals.RemoveAt(i);
                isOkey = val > ListHelper.Sum(otherVals);
            }

            return isOkey;
        }
    }
}
