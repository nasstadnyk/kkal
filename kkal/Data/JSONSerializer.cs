using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization.Json;

namespace kkal
{
    class JSONSerializer : ISerializer
    {
        DataContractJsonSerializer jsonSerializer;
        public JSONSerializer(Type type)
        {
            jsonSerializer = new DataContractJsonSerializer(type);

        }

        public object Deserialize(string path)
        {
            using (FileStream str = new FileStream(path, FileMode.OpenOrCreate))
            {
                return jsonSerializer.ReadObject(str);
            }
        }

        public void Serialize(object obj, string path)
        {
            using (FileStream str = new FileStream(path, FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(str, obj);
            }
        }
    }
}
