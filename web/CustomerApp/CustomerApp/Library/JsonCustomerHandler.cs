using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerApp {
    public class JsonCustomerHandler {

        private string fileName = @".\Data\CustomerData.json";

        public void SerializeToJson(List<Customer> listToJson) {
            string jsonString = JsonSerializer.Serialize(listToJson);
            File.WriteAllText(fileName, jsonString);
        }
        public List<Customer> DeserializeFromJson() {
            if (!File.Exists(fileName)) {
                return new List<Customer>();
            }
            string jsonString = File.ReadAllText(fileName);
            List<Customer> listFromJson = JsonSerializer.Deserialize<List<Customer>>(jsonString);
            return listFromJson;
        }
    }
}
