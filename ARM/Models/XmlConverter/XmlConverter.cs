﻿using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ARM.Models.XmlConverter
{
    public class XmlConverter
    {
        private static string Utf8ByteArrayToString(byte[] characters)
        {
            return new UTF8Encoding().GetString(characters);
        }

        public byte[] ToXml(object value)
        {
            var stringwriter = new Utf8StringWriter();
            var serializer = new XmlSerializer(value.GetType());
            serializer.Serialize(stringwriter, value);
            return Encoding.UTF8.GetBytes(stringwriter.ToString());
        }
    }

    public class Utf8StringWriter : StringWriter
    {
        public override System.Text.Encoding Encoding { get {return  Encoding.UTF8;}}
    }
}