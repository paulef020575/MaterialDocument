using System;
using System.Collections.Generic;
using System.Text;
using EPV.DataItem;
using System.Data.Common;
using EPV.Database;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace MaterialDocument.Classes
{
    public class MaterialPermit : DataItem
    {
        #region Поля и свойства

        public bool IsReaded { get { return !IsModified; } }
        [DataField("unitId", "Id")]
        public Unit Unit { get; private set; }

        private string docNumber;
        [DataField("docNumber")]
        public string DocNumber
        {
            get { return docNumber; }
            set { SetField("docNumber", value, 50); }
        }

        private DateTime docDate;
        [DataField("docDate")]
        public DateTime DocDate
        {
            get { return docDate; }
            set { SetField("docDate", value); }
        }

        private string person;
        [DataField("person")]
        public string Person
        {
            get { return person; }
            set { SetField("person", value, 300); }
        }

        private string vehicleMark;
        [DataField("vehicleMark")]
        public string VehicleMark
        {
            get { return vehicleMark; }
            set { SetField("vehicleMark", value, 100); }
        }

        private string licensePlate;
        [DataField("licensePlate")]
        public string LicensePlate
        {
            get { return licensePlate; }
            set { SetField("licensePlate", value, 50); }
        }

        #region CreateFlag

        private short createFlag;
        [DataField("createFlag")]
        public short CreateFlag
        {
            get { return createFlag; }
            set 
            {
                if (value != 0 && createFlag == 0)
                    CreateDate = DateTime.Now;
                SetField("createFlag", value); 
            }
        }

        public Image CreateFlagImage
        {
            get
            {
                switch (CreateFlag)
                {
                    case -1:
                        return MaterialDocument.Resources.Image.Fail;

                    case 1:
                        return MaterialDocument.Resources.Image.Check;

                    default:
                        return MaterialDocument.Resources.Image.Quest;
                }
            }
        }
        
        private User creator;
        [DataField("creator", "Id")]
        public User Creator
        {
            get { return creator; }
            set { SetField("creator", value); }
        }

        private DateTime createDate;
        [DataField("createDate")]
        public DateTime CreateDate
        {
            get { return createDate; }
            set { SetField("createDate", value); }
        }

        public string CreationInfo
        {
            get
            {
                if (creator.Equals(User.Empty)) return "";

                return creator.ToString() + Environment.NewLine + createDate.ToString("dd.MM.yyyy HH:mm");
            }
        }

        #endregion

        #region SignedFlag
        
        private short signedFlag;
        [DataField("signedFlag")]
        public short SignedFlag
        {
            get { return signedFlag; }
            set
            {
                if (signedFlag == 0 && value != 0)
                    SignDate = DateTime.Now;
                SetField("signedFlag", value);
            }
        }

        public Image SignedFlagImage
        {
            get
            {
                switch (SignedFlag)
                {
                    case -1:
                        return MaterialDocument.Resources.Image.Fail;

                    case 1:
                        return MaterialDocument.Resources.Image.Check;

                    default:
                        return MaterialDocument.Resources.Image.Quest;
                }
            }
        }

        private User signer;
        [DataField("signer", "Id")]
        public User Signer
        {
            get { return signer; }
            set { SetField("signer", value); }
        }

        private DateTime signDate;
        [DataField("signDate")]
        public DateTime SignDate
        {
            get { return signDate; }
            set { SetField("signDate", value); }
        }

        public string SignInfo
        {
            get
            {
                if (Signer.Equals(User.Empty)) return "";
                return Signer.ToString() + Environment.NewLine + SignDate.ToString("dd.MM.yyyy HH:mm");
            }
        }

        #endregion

        #region EntryFlag

        private short entryFlag;
        [DataField("entryFlag")]
        public short EntryFlag
        {
            get { return entryFlag; }
            set { SetField("entryFlag", value); }
        }

        public Image EntryFlagImage
        {
            get
            {
                switch (EntryFlag)
                {
                    case -1:
                        return MaterialDocument.Resources.Image.Fail;

                    case 1:
                        return MaterialDocument.Resources.Image.Check;

                    default:
                        return MaterialDocument.Resources.Image.Quest;
                }
            }
        }

        private EntryPoint entryPoint;
        [DataField("entryPoint", "Id")]
        public EntryPoint EntryPoint
        {
            get { return entryPoint; }
            set { SetField("entryPoint", value); }
        }

        private DateTime entryDate;
        [DataField("entryDate")]
        public DateTime EntryDate
        {
            get { return entryDate; }
            set { SetField("entryDate", value); }
        }

        public string EntryInfo
        {
            get
            {
                if (EntryPoint.Equals(EntryPoint.Empty)) return "";

                return EntryPoint.ToString() + Environment.NewLine + EntryDate.ToString("dd.MM.yyyy HH:mm");
            }
        }

        #endregion

        private string comment;
        [DataField("comment")]
        public string Comment
        {
            get { return comment; }
            set { SetField("comment", value); }
        }

        [DataField("modifier", "Id")]
        public User Modifier { get; private set; }

        private int autoPermitId;
        [DataField("autoPermit")]
        public int AutoPermitId 
        {
            get { return autoPermitId; } 
            set { SetField("autoPermitId", value); } 
        }

        private string baseDocument;
        [DataField("baseDocument")]
        public string BaseDocument
        {
            get { return baseDocument; }
            set { SetField("baseDocument", value, 100); }
        }

        private string baseDocNumber;
        [DataField("baseDocNumber")]
        public string BaseDocNumber
        {
            get { return baseDocNumber; }
            set { SetField("baseDocNumber", value, 100); }
        }

        private DateTime baseDocDate;
        [DataField("baseDocDate")]
        public DateTime BaseDocDate
        {
            get { return baseDocDate; }
            set { SetField("baseDocDate", value); }
        }


        private AutoPermit autoPermit;

        private BindingList<MaterialPermitItem> itemList;

        private ArrayList deletedItems;

        public bool IsNew { get; set; }

        #region Запросы

        protected override string GeneratorName
        {
            get
            {
                return MaterialDocument.Resources.Doc.MaterialPermit.GeneratorName;
            }
        }

        protected override string InsertQuery
        {
            get
            {
                return MaterialDocument.Resources.Doc.MaterialPermit.Insert;
            }
        }

        protected override string UpdateQuery
        {
            get
            {
                return MaterialDocument.Resources.Doc.MaterialPermit.Update;
            }
        }

        protected override string DeleteQuery
        {
            get
            {
                return MaterialDocument.Resources.Doc.MaterialPermit.Delete;
            }
        }

        private static string LoadQuery
        {
            get
            {
                return MaterialDocument.Resources.Doc.MaterialPermit.Load;
            }
        }

        private static string LoadListQuery
        {
            get
            {
                return MaterialDocument.Resources.Doc.MaterialPermit.LoadList;
            }
        }
    
        #endregion

        #endregion

        #region Конструкторы

        private MaterialPermit() : base() { }

        public MaterialPermit(Unit initUnit)
            : base()
        {
            Unit = initUnit;
        }

        public MaterialPermit(DbDataReader reader) : base(reader) { }

        #endregion

        #region Методы

        #region Переопределенные

        protected override void InitializeProperties()
        {
            Unit = Unit.Empty;
            docNumber = "";
            docDate = DateTime.Today;

            person = "";
            vehicleMark = "";
            licensePlate = "";

            createFlag = 0;
            creator = User.Empty;
            createDate = DateTime.MinValue;

            signedFlag = 0;
            signer = User.Empty;
            signDate = DateTime.MinValue;

            entryFlag = 0;
            entryPoint = EntryPoint.Empty;
            entryDate = DateTime.MinValue;

            comment = "";

            autoPermitId = 0;

            IsNew = false;

            baseDocument = "доверенность";
            baseDocNumber = "";
            baseDocDate = DateTime.Today;
        }

        protected override void ReadProperties(DbDataReader reader)
        {
            Unit = new Unit((int)reader["unitId"], (string)reader["unitName"]);
            docNumber = (string)reader["docNumber"];
            docDate = (DateTime)reader["docDate"];

            person = (string)reader["person"];
            vehicleMark = (string)reader["vehicleMark"];
            licensePlate = (string)reader["licensePlate"];

            createFlag = (short)reader["createFlag"];
            if (!DBNull.Value.Equals(reader["creator"]))
            {
                creator = new User((int)reader["creator"], (string)reader["creatorName"]);
                createDate = (DateTime)reader["createDate"];
            }
            else
            {
                creator = User.Empty;
                createDate = DateTime.MinValue;
            }

            signedFlag = (short)reader["signedFlag"];
            if (!DBNull.Value.Equals(reader["signer"]))
            {
                signer = new User((int)reader["signer"], (string)reader["signerName"]);
                signDate = (DateTime)reader["signDate"];
            }
            else
            {
                signer = User.Empty;
                signDate = DateTime.MinValue;
            }

            entryFlag = (short)reader["entryFlag"];
            if (!DBNull.Value.Equals(reader["entryPoint"]))
            {
                entryPoint = new EntryPoint((int)reader["entryPoint"], (string)reader["entryPointName"]);
            }
            else
            {
                entryPoint = EntryPoint.Empty;
            }

            entryDate = (DateTime)(DBNull.Value.Equals(reader["entryDate"]) ? DateTime.MinValue : reader["entryDate"]);

            comment = (string)reader["comment"];

            autoPermitId = (DBNull.Value.Equals(reader["autoPermit"]) ? 0 : (int)reader["autoPermit"]);

            IsNew = ((short)reader["isNew"] > 0);

            baseDocument = (DBNull.Value.Equals(reader["baseDocument"]) ? "" : (string)reader["baseDocument"]);
            baseDocNumber = (DBNull.Value.Equals(reader["baseDocNumber"]) ? "" : (string)reader["baseDocNumber"]);
            baseDocDate = (DBNull.Value.Equals(reader["baseDocDate"]) ? DateTime.Today : (DateTime)reader["baseDocDate"]);
        }

        protected override QueryParameters CreateParameters()
        {
            QueryParameters parameters = base.CreateParameters();
            if (Creator.Equals(User.Empty))
                parameters["creator"] = DBNull.Value;

            if (Signer.Equals(User.Empty))
                parameters["signer"] = DBNull.Value;

            if (autoPermitId == 0)
                parameters["autoPermit"] = DBNull.Value;

            if (baseDocDate == DateTime.MinValue)
                parameters["baseDocDate"] = DBNull.Value;

            return parameters;
        }

        protected override string StringDescription()
        {
            return DocNumber + " от " + DocDate.ToShortDateString();
        }

        public override void Save(Database database)
        {
            MaterialDocumentDatabase mdDatabase = (MaterialDocumentDatabase)database;
            Modifier = mdDatabase.ConnectedUser;
            base.Save(database);
        }


        #endregion

        public static MaterialPermit Load(Database database, int id)
        {
            MaterialPermit materialPermit = null;

            QueryParameters parameters = new QueryParameters("id", id);
            using (DbDataReader reader = database.ExecuteReader(LoadQuery, parameters))
            {
                if (reader.Read())
                    materialPermit = new MaterialPermit(reader);
                else
                    throw new ArgumentException(MaterialDocument.Resources.Error.WrongIdentifier);

                reader.Close();
            }

            return materialPermit;
        }

        public MaterialPermit LoadCopy(Database database)
        {
            return Load(database, Id);
        }

        public static List<MaterialPermit> LoadList(MaterialDocumentDatabase database, Unit unit, DateTime dateFrom, DateTime dateTo)
        {
            List<MaterialPermit> permitList = new List<MaterialPermit>();
            QueryParameters parameters = new QueryParameters("unitId", unit.Id);
            parameters.Add("dateFrom", dateFrom);
            parameters.Add("dateTo", dateTo);
            parameters.Add("userId", database.ConnectedUser.Id);

            using (DbDataReader reader = database.ExecuteReader(LoadListQuery, parameters))
            {
                while (reader.Read())
                    permitList.Add(new MaterialPermit(reader));
                reader.Close();
            }

            return permitList;
        }

        protected override void SaveChildren(Connection connection)
        {
            if (itemList != null)
                SaveItemList(connection);

            if (deletedItems != null)
                SaveDeletedItems(connection);
        }

        private void SaveDeletedItems(Connection connection)
        {
            foreach (MaterialPermitItem item in deletedItems)
            {
                item.Delete();
                item.Save(connection);
            }

        }

        private void SaveItemList(Connection connection)
        {
            foreach (MaterialPermitItem item in itemList)
                item.Save(connection);
        }

        public BindingList<MaterialPermitItem> GetItemList(Database database)
        {
            if (itemList == null)
                itemList = new BindingList<MaterialPermitItem>(MaterialPermitItem.LoadList(database, this));

            foreach (MaterialPermitItem item in itemList)
                item.PropertyChanged += item_PropertyChanged;

            return itemList;
        }

        public void DeleteItem(MaterialPermitItem item)
        {
            if (itemList != null)
                itemList.Remove(item);

            if (deletedItems == null)
                deletedItems = new ArrayList();

            item.PropertyChanged -= item_PropertyChanged;
            deletedItems.Add(item);
        }

        public MaterialPermitItem AddItem()
        {
            int id = -1;
            if (itemList != null)
                foreach (MaterialPermitItem item1 in itemList)
                    if (item1.Id <= id)
                        id = item1.Id - 1;

            MaterialPermitItem item = new MaterialPermitItem(this);
            item.Id = id;
            item.PropertyChanged += item_PropertyChanged;

            if (itemList == null)
                itemList = new BindingList<MaterialPermitItem>();

            itemList.Add(item);
            MarkAsModified();

            return item;
        }

        void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MarkAsModified();
        }

        public bool CanEdit(int userRole)
        {
            return (CreateFlag != 1
                    && (userRole == MaterialDocumentDatabase.CreatorRole
                        || userRole == MaterialDocumentDatabase.SignerRole));
        }

        public bool CanCreate(int userRole)
        {
            return (rowState == RowState.Readed && CanEdit(userRole));
        }

        public bool CanFailCreate(int userRole)
        {
            return (SignedFlag != 1
                    && (userRole == MaterialDocumentDatabase.CreatorRole
                        || userRole == MaterialDocumentDatabase.SignerRole));
        }

        public bool CanSign(int userRole)
        {
            return (CreateFlag == 1 && SignedFlag != 1
                    && userRole == MaterialDocumentDatabase.SignerRole);
        }

        public bool CanFailSign(int userRole)
        {
            return (EntryFlag != 1
                    && userRole == MaterialDocumentDatabase.SignerRole);
        }


        public override void Delete(Database database)
        {
            Modifier = ((MaterialDocumentDatabase)database).ConnectedUser;
            base.Delete(database);
        }

        #endregion


        public void MarkCreated(MaterialDocumentDatabase Database, int flag)
        {
            string query = MaterialDocument.Resources.Doc.MaterialPermit.MarkAsCreated;
            QueryParameters parameters = new QueryParameters("createFlag", flag);
            parameters.Add("creator", Database.ConnectedUser.Id);
            parameters.Add("createDate", DateTime.Now);
            parameters.Add("modifier", Database.ConnectedUser.Id);
            parameters.Add("modifyDate", DateTime.Now);
            parameters.Add("id", Id);

            Database.ExecuteQuery(query, parameters);
        }

        public void MarkSigned(MaterialDocumentDatabase database, int flag)
        {
            string query = MaterialDocument.Resources.Doc.MaterialPermit.MarkAsSigned;
            QueryParameters parameters = new QueryParameters("signedFlag", flag);
            parameters.Add("signer", database.ConnectedUser.Id);
            parameters.Add("signDate", DateTime.Now);
            parameters.Add("modifier", database.ConnectedUser.Id);
            parameters.Add("modifyDate", DateTime.Now);
            parameters.Add("id", Id);

            database.ExecuteQuery(query, parameters);
        }

        public string GetComment(Database database)
        {
            string query = MaterialDocument.Resources.Doc.MaterialPermit.GetComment;
            QueryParameters parameters = new QueryParameters("id", Id);

            return (string)database.ExecuteScalar(query, parameters);
        }

        public void SetComment(MaterialDocumentDatabase database, string cmnt)
        {
            string query = MaterialDocument.Resources.Doc.MaterialPermit.SetComment;
            QueryParameters parameters = new QueryParameters("comment", cmnt);
            parameters.Add("modifier", database.ConnectedUser.Id);
            parameters.Add("modifyDate", DateTime.Now);
            parameters.Add("id", Id);

            database.ExecuteQuery(query, parameters);
        }

        public void LinkAutoPermit(AutoPermit document)
        {
            if (autoPermitId != document.Id)
                AutoPermitId = document.Id;

            autoPermit = document;
            if (string.IsNullOrEmpty(Person))
                Person = autoPermit.DriverName;
            if (string.IsNullOrEmpty(VehicleMark))
                VehicleMark = autoPermit.VehicleMark;
            if (string.IsNullOrEmpty(LicensePlate))
                LicensePlate = autoPermit.LicensePlate;

            Comment = Comment + Environment.NewLine + "К пропуску " + document.ToString();
        }

        public AutoPermit LoadAutoPermit(Database database)
        {
            autoPermit = AutoPermit.Load(database, autoPermitId);
            return autoPermit;
        }

        public void ClearAutoPermit()
        {
            autoPermit = null;
            AutoPermitId = 0;
        }

        public bool CheckAutoPermitProperties(AutoPermit autoPermit)
        {
            string[] words = Person.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string[] words2 = autoPermit.DriverName.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            return (string.IsNullOrEmpty(Person)
                    || string.Equals(words[0], words2[0], StringComparison.CurrentCultureIgnoreCase));
        }

        public void SetAsSeen(MaterialDocumentDatabase database)
        {
            string query = MaterialDocument.Resources.Query.SetDocumentAsSeen;
            QueryParameters parameters = new QueryParameters("documentType", "materialPermit");
            parameters.Add("documentId", Id);
            parameters.Add("userId", database.ConnectedUser.Id);
            parameters.Add("dateSeen", DateTime.Now);

            database.ExecuteQuery(query, parameters);

            IsNew = false;
        }

       
    }
}
