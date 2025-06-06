﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Model.Data;

namespace Model.Core
{
    public class SerializerXML : Serializer
    {
        public override void Save(Sizes siziki)
        {
            var serializer = new XmlSerializer(typeof(SizeDTO));
            using (var writer = new StreamWriter(FilePath))
            {
                serializer.Serialize(writer, new SizeDTO(siziki));
            }
        }

        public override void Load(Sizes siziki)
        {
            using (var writer = new StreamReader(FilePath))
            {
                var serializer = new XmlSerializer(typeof(SizeDTO));
                var dto = (SizeDTO)serializer.Deserialize(writer);
                
            }
        }

        }
    }
