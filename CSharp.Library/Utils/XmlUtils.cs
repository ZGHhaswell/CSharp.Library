/*----------------------------------------------------------------
// Copyright (C) 2013 ZGH
// 版权所有。
//
// 文件名：XmlUtils.cs
// 功能描述：
// 
// 创建时间： 11/21/2015 9:34:28 PM
//
//----------------------------------------------------------------*/

using System;
using System.IO;
using System.Xml.Serialization;

namespace CSharp.Library.Utils
{
    public static class XmlUtils<T>
        where T:class 
    {
        public static bool ExportToXml(T t, string path)
        {
            bool isSuccess = false;
            try
            {
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    var xmlSerialize = new XmlSerializer(typeof(T));
                    xmlSerialize.Serialize(fileStream, t);
                }
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }
            return isSuccess;
        }

        public static T ImportFromXml(string path)
        {
            T t = default (T);
            if (File.Exists(path))
            {
                try
                {
                    using (var fileStream = new FileStream(path, FileMode.Open))
                    {
                        var xmlSerializer = new XmlSerializer(typeof (T));
                        t = xmlSerializer.Deserialize(fileStream) as T;
                    }
                }
                catch (Exception)
                {
                    t = null;
                }
            }
            return t;
        }
    }
}
