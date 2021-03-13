﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace PointOfSalesV2.Common
{
  public static class StringUtility
    {
        public static string ConvertToBase64(string original)
        {
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(original);

            // convert the byte array to a Base64 string

            return Convert.ToBase64String(byt);
        }

        public static Dictionary<int, string> WhenToTake = new Dictionary<int, string>()
        {
            {1,"1-0-0" },
            {2,"0-1-0" },
            {3,"0-0-1" },
            {4,"1-1-0" },
            {5,"1-0-1" },
            {6,"1-1-1" },
            {7,"0-1-1" },
        };

        public static string Serialize<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, value);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }
    }

  
}
