using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using EPV.Database;

namespace MaterialDocument.Classes
{
    public class EntryPoint
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Phone { get; private set; }

        private static string LoadQuery { get { return MaterialDocument.Resources.Ref.EntryPoint.Load; } }

        private static string LoadListQuery { get { return MaterialDocument.Resources.Ref.EntryPoint.LoadList; } }

        public static EntryPoint Empty { get { return new EntryPoint(0, "не указан"); } }

        public EntryPoint(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public EntryPoint(int id, string name) : this(id, name, "") { }

        public EntryPoint(DbDataReader reader) : this((int)reader["id"], (string)reader["name"], (string)reader["phone"]) { }

        public override bool Equals(object obj)
        {
            EntryPoint entryPoint = obj as EntryPoint;

            if (entryPoint != null)
                return entryPoint.Id.Equals(Id);

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }

        public static EntryPoint Load(Database database, int id)
        {
            EntryPoint entryPoint = EntryPoint.Empty;

            QueryParameters parameters = new QueryParameters("id", id);
            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    entryPoint = new EntryPoint(reader);
                reader.Close();
            }

            if (entryPoint.Equals(EntryPoint.Empty))
                throw new ArgumentException(MaterialDocument.Resources.Error.WrongIdentifier);

            return entryPoint;
        }

        public EntryPoint LoadCopy(Database database)
        {
            return Load(database, Id);
        }

        public static List<EntryPoint> LoadList(Database database)
        {
            List<EntryPoint> pointList = new List<EntryPoint>();

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery))
            {
                while (reader.Read())
                    pointList.Add(new EntryPoint(reader));

                reader.Close();
            }

            return pointList;
        }


    }
}
