using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using EPV.Database;
using System.Security.Cryptography;

namespace MaterialDocument.Classes
{
    public class User
    {
        #region Свойства

        public int Id { get; private set; }

        public string Lastname { get; private set; }

        public string Firstname { get; private set; }

        public string Secondname { get; private set; }

        public string Fullname
        {
            get
            {
                string fullname = Lastname;

                if (!string.IsNullOrEmpty(Firstname))
                {
                    fullname += " " + Firstname;

                    if (!string.IsNullOrEmpty(Secondname))
                    {
                        fullname += " " + Secondname;
                    }
                }

                return fullname;
            }
        }

        public string Shortname
        {
            get
            {
                string shortname = Lastname;

                if (!string.IsNullOrEmpty(Firstname))
                {
                    shortname += " " + Firstname.Trim()[0];

                    if (!string.IsNullOrEmpty(Secondname))
                    {
                        shortname += " " + Secondname.Trim()[0];
                    }
                }

                return shortname;
            }
        }

        public static User Empty { get { return new User(0); } }

        #endregion

        #region Конструкторы

        public User(DbDataReader reader)
        {
            Id = (int)reader["id"];
            Lastname = (string)reader["lastname"];
            Firstname = (string)reader["firstname"];
            Secondname = (string)reader["secondname"];
        }

        public User(int id)
        {
            Id = id;
            Lastname = "";
            Firstname = "";
            Secondname = "";
        }

        public User(int id, string name)
        {
            Id = id;
            Lastname = name;
            Firstname = "";
            Secondname = "";
        }

        #endregion

        #region Методы

        #region Переопределенные

        public override string ToString()
        {
            return Shortname;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is User)
            {
                return ((User)obj).Id.Equals(Id);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        #endregion

        public static List<User> LoadList(Database database)
        {
            List<User> userList = new List<User>();

            string query = MaterialDocument.Resources.Sec.User.LoadList;

            using (DbDataReader reader = database.ExecuteReader(query))
            {
                while (reader.Read())
                    userList.Add(new User(reader));

                reader.Close();
            }

            return userList;
        }

        public static User Load(Database database, int id)
        {
            string query = MaterialDocument.Resources.Sec.User.Load;
            QueryParameters parameters = new QueryParameters("id", id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    User user = new User(reader);
                    reader.Close();
                    return user;
                }

                reader.Close();
                throw new ArgumentException(MaterialDocument.Resources.Error.WrongIdentifier);
            }
        }

        public string Logon(Database database, string password)
        {
            string query = MaterialDocument.Resources.Sec.User.Logon;
            QueryParameters parameters = new QueryParameters("userId", Id);
            parameters.Add("password", MD5Hash(password));

            return (string)database.ExecuteScalar(query, parameters);
        }

        public static MaterialDocumentDatabase LogonByDomain(Database database, string domainName, string userName)
        {
            string query = MaterialDocument.Resources.Sec.User.LogonByDomain;
            QueryParameters parameters = new QueryParameters("domainName", domainName);
            parameters.Add("userName", userName);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    MaterialDocumentDatabase dbase = new Classes.MaterialDocumentDatabase((string)reader["connectionString"], (int)reader["userId"]);
                    reader.Close();
                    return dbase;
                }

                reader.Close();
                return null;

            }
        }

        static string MD5Hash(string instr)
        {
            string strHash = string.Empty;

            foreach (byte b in new MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(instr)))
            {
                strHash += b.ToString("X2");
            }
            return strHash;
        }

        #endregion
    }
}
