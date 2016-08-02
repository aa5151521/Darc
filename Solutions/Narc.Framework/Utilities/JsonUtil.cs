﻿namespace Narc.Framework.Utilities
{
    using System.IO;
    using System.Runtime.Serialization.Json;
    using System.Text;
    using System.Web.Script.Serialization;

    public class JsonDeserializeUtil
    {
        public static T JsonDeserialize<T>(string jsonString)
        {
            var ser = new DataContractJsonSerializer(typeof (T));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            var obj = (T) ser.ReadObject(ms);

            return obj;
        }

        public static string JsonSerialize<T>(T obj)
        {
            var ser = new JavaScriptSerializer();
            return ser.Serialize(obj);
        }
    }
}