using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace MaterialDocument.Classes
{
    public class Unit : DataItem
    {
        #region Поля и свойства

        private string name;
        [DataField("name")]
        public string Name
        {
            get { return name; }
            set { SetField("name", value, 50); }
        }

        private string code;
        [DataField("code")]
        public string Code
        {
            get { return code; }
            set { SetField("code", value, 10); }
        }

        public static Unit Empty { get { return new Unit(0, "не указано"); } }
       
        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return MaterialDocument.Resources.Ref.Unit.GeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return MaterialDocument.Resources.Ref.Unit.Insert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return MaterialDocument.Resources.Ref.Unit.Update;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return MaterialDocument.Resources.Ref.Unit.Delete;
            }
        }

        public static string LoadQuery
        {
            get
            {
                return MaterialDocument.Resources.Ref.Unit.Load;
            }
        }

        public static string LoadListQuery
        {
            get
            {
                return MaterialDocument.Resources.Ref.Unit.LoadList;
            }
        }

        #endregion

        #endregion

        #region Конструкторы

        public Unit() : base() { }

        public Unit(int id, string descr) : base(id, descr) { }

        public Unit(DbDataReader reader) : base(reader) { }

        #endregion

        #region Методы

        #region Переопределенные

        protected override void InitializeProperties()
        {
            Id = 0;
            name = "Новое подразделение";
            code = "";
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            Id = (int)reader["id"];
            name = (string)reader["name"];
            code = (string)reader["code"];
        }

        protected override string StringDescription()
        {
            return Name;
        }

        #endregion

        public static Unit Load(Database database, int id)
        {
            Unit unit = null;

            QueryParameters parameters = new QueryParameters("id", id);
            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    unit = new Unit(reader);
                reader.Close();
            }

            if (unit == null)
                throw new ArgumentException(MaterialDocument.Resources.Error.WrongIdentifier);

            return unit;
        }

        public Unit LoadCopy(Database database)
        {
            return Load(database, Id);
        }

        public static List<Unit> LoadList(Database database)
        {
            List<Unit> unitList = new List<Unit>();

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery))
            {
                while (reader.Read())
                    unitList.Add(new Unit(reader));
                reader.Close();
            }

            return unitList;
        }

        public static List<Unit> LoadList(Database database, User user)
        {
            List<Unit> unitList = new List<Unit>();
            string query = MaterialDocument.Resources.Ref.Unit.ListForUser;
            QueryParameters parameters = new QueryParameters("userId", user.Id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    unitList.Add(new Unit(reader));

                reader.Close();
            }

            return unitList;
        }

        public int GetRole(MaterialDocumentDatabase database)
        {
            string query = MaterialDocument.Resources.Sec.User.UserRole;
            QueryParameters parameters = new QueryParameters("userId", database.ConnectedUser.Id);
            parameters.Add("unitId", Id);

            object result = database.ExecuteScalar(query, parameters);

            if (result == null)
                return 0;

            return (int)result;
        }

        #endregion
    }
}
