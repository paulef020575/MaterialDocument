using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;

namespace MaterialDocument.Classes
{
    public class MaterialPermitItem : DataItem
    {
        #region Поля и свойства

        [DataField("document", "Id")]
        public MaterialPermit Document { get; private set; }

        private string material;
        [DataField("material")]
        public string Material
        {
            get { return material; }
            set { SetField("material", value, 300); }
        }

        private string materialUnit;
        [DataField("materialUnit")]
        public string MaterialUnit
        {
            get { return materialUnit; }
            set { SetField("materialUnit", value, 25); }
        }

        private decimal quantity;
        [DataField("quantity")]
        public decimal Quantity
        {
            get { return quantity; }
            set { SetField("quantity", value); }
        }

        private decimal tonnage;
        [DataField("tonnage")]
        public decimal Tonnage
        {
            get { return tonnage; }
            set { SetField("tonnage", value); }
        }

        #region Запросы

        protected override string GeneratorName
        {
            get
            {

                return MaterialDocument.Resources.Doc.MaterialPermit.ItemGeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return MaterialDocument.Resources.Doc.MaterialPermit.ItemInsert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return MaterialDocument.Resources.Doc.MaterialPermit.ItemUpdate;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return MaterialDocument.Resources.Doc.MaterialPermit.ItemDelete;
            }
        }

        private static string LoadListQuery
        {
            get
            {
                return MaterialDocument.Resources.Doc.MaterialPermit.ItemLoadList;
            }
        }

        #endregion

        #endregion

        #region Конструкторы

        private MaterialPermitItem() : base() { }

        public MaterialPermitItem(MaterialPermit document) 
            : this() 
        { 
            Document = document;
        }

        private MaterialPermitItem(DbDataReader reader) : base(reader) { }

        public MaterialPermitItem(DbDataReader reader, MaterialPermit document)
            : this(reader)
        {
            Document = document;
        }

        #endregion

        #region Методы

        #region Переопределенные

        protected override void InitializeProperties()
        {
            material = "";
            materialUnit = "шт.";
            quantity = 1;
            tonnage = 0;
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            material = (string)reader["material"];
            materialUnit = (string)reader["materialUnit"];
            quantity = (decimal)reader["quantity"];
            tonnage = (decimal)reader["tonnage"];
        }

        protected override string StringDescription()
        {
            return Material + " " + quantity.ToString();
        }

        #endregion

        public static List<MaterialPermitItem> LoadList(Database database, MaterialPermit permit)
        {
            List<MaterialPermitItem> itemList = new List<MaterialPermitItem>();

            QueryParameters parameters = new QueryParameters("document", permit.Id);
            using (DbDataReader reader = database.ExecuteReader(LoadListQuery, parameters))
            {
                while (reader.Read())
                    itemList.Add(new MaterialPermitItem(reader, permit));

                reader.Close();
            }

            return itemList;
        }


        #endregion
    }
}
