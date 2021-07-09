using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace UniversityApp.Impl {
    public class JsonHandler {

        private JavaScriptSerializer javaScriptSerializer { get; set; }
        private string JsonFile {get; set;}
        public JsonHandler(string jsonFile) {
            javaScriptSerializer = new JavaScriptSerializer();
            JsonFile = jsonFile;
        }
        public void SerializeToJson(University university) {
            File.WriteAllText(JsonFile, javaScriptSerializer.Serialize(university));
        }

        public University DeserializeFromJson() {
            return javaScriptSerializer.Deserialize<University>(File.ReadAllText(JsonFile));
        }
    }
}
