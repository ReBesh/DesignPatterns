using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace PrototypePattern
{
    public static class Extension1
    {
        public static T DeepCopy<T>(this T self)
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            object copy = formatter.Deserialize(stream);
            stream.Close();
            return (T)copy;
        }

        public static T DeepCopyXml<T>(this T self)
        {
            using (var ms = new MemoryStream())
            {
                var s = new XmlSerializer(typeof(T));
                s.Serialize(ms, self);
                ms.Position = 0;
                return (T)s.Deserialize(ms);
            }
        }
    }

    [Serializable]
    public class Identification
    {
        public string[] Name;
        public Identity Surname;
        public Identification(string[] name, Identity surname)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            if (surname == null)
            {
                throw new ArgumentNullException(paramName: nameof(surname));
            }
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {string.Join(" ", Name)}, {nameof(Surname)}: {Surname}";
        }



    }

    [Serializable]
    public class Identity
    {
        private string Username;
        public int Password;

        public Identity(string username, int password)
        {
            if (username == null)
            {
                throw new ArgumentNullException(paramName: nameof(username));
            }
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return $"{nameof(Username)}: {Username}, {nameof(Password)}: {Password}";
        }
    }
}
