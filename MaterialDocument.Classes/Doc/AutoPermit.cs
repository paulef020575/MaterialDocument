using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using EPV.Database;

namespace MaterialDocument.Classes
{
    public class AutoPermit
    {
        #region Свойства

        public int Id { get; private set; }

        public int DocNumber { get; private set; }

        public DateTime DocDate { get; private set; }

        public string DriverName { get; private set; }

        public int VehicleId { get; private set; }

        public string VehicleMark { get; private set; }

        public string LicensePlate { get; private set; }

        public EntryPoint EntryPoint { get; private set; }

        #endregion

        #region Конструкторы

        public AutoPermit(DbDataReader reader)
        {
            Id = (int)reader["id"];
            DocNumber = (int)reader["docNumber"];
            DocDate = (DateTime)reader["createDate"];
            DriverName = (string)reader["driverName"];
            VehicleId = (int)reader["vehicle"];
            VehicleMark = (string)reader["vehicleName"];
            EntryPoint = new EntryPoint((int)reader["entryPoint"], (string)reader["entryPointName"]);
        }
        
        #endregion

        #region Методы

        public override bool Equals(object obj)
        {
            AutoPermit permit = obj as AutoPermit;

            if (obj != null)
                return permit.Id.Equals(Id);

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return DocNumber.ToString() + " от " + DocDate.ToShortDateString();
        }

        public static AutoPermit Load(Database database, int id)
        {
            AutoPermit permit = null;

            string query = MaterialDocument.Resources.Doc.MaterialPermit.LoadAutoPermit;
            QueryParameters parameters = new QueryParameters("permitId", id);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                    permit = new AutoPermit(reader);
                reader.Close();
            }

            if (permit == null)
                throw new ArgumentException(MaterialDocument.Resources.Error.WrongIdentifier);

            return permit;
        }

        public static List<AutoPermit> LoadList(Database database, int docNumber)
        {
            List<AutoPermit> permitList = new List<AutoPermit>();
            string query = MaterialDocument.Resources.Doc.MaterialPermit.FindAutoPermit;
            QueryParameters parameters = new QueryParameters("number", docNumber);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                    permitList.Add(new AutoPermit(reader));

                reader.Close();
            }

            return permitList;
        }

        public void GetVehicle(Database database)
        {
            string query = MaterialDocument.Resources.Doc.MaterialPermit.GetVehicle;
            QueryParameters parameters = new QueryParameters("id", VehicleId);

            using (DbDataReader reader = database.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    VehicleMark = (string)reader["vehicleMark"];
                    LicensePlate = (string)reader["licensePlate"];
                }

                reader.Close();
            }
        }

        #endregion
    }
}
