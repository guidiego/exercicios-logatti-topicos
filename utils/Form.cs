using System;
using System.Collections.Generic;

namespace utils {
    public class Form {
        public static Dictionary<String, String> ask(Dictionary<String, String> formRequest) {
            Dictionary<String, String> response = new Dictionary<String, String>();

            foreach(String field in formRequest.Keys) {
                Console.WriteLine(formRequest[field]);
                var val = Console.ReadLine();
                response[field] = val;
            }

            return response;
        }
    }
}
