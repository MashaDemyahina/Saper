using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Model.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Model.Data
{
    public class JsonSerializer : Serializer
    {
        public override void Save(Sizes siziki)
        {
            SetFilePath(FilePath);
            var json = JObject.FromObject(new SizeDTO(siziki));

            File.WriteAllText(FilePath, json.ToString());
        }
        public override void Load(Sizes siziki) 
        {
            var content = File.ReadAllText(FilePath);

            siziki.LoadW();
        }
    }
}

