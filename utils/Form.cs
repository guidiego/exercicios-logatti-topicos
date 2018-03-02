using System;
using System.Collections.Generic;

namespace utils {
    public class Form {
        private Dictionary<String, String> questions;

        public Form() {
            this.questions = new Dictionary<String, String>();
        }

        public void add(String question, String field) {
            this.questions[field] = question;
        }

        public Dictionary<String, String> ask() {
            Dictionary<String, String> response = new Dictionary<String, String>();

            foreach(String field in this.questions.Keys) {
                Console.WriteLine(this.questions[field]);
                var val = Console.ReadLine();
                response[field] = val;
            }

            return response;
        }
    }
}
