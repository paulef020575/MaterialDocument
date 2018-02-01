using System;
using System.Collections.Generic;
using System.Text;
using EPV.Database;

namespace MaterialDocument.Classes
{
    public class MaterialDocumentDatabase : FbDatabase
    {
        public User ConnectedUser { get; private set; }

        private MaterialDocumentDatabase() : base() { }

        public MaterialDocumentDatabase(string connectionString, User user)
            : base(connectionString)
        {
            ConnectedUser = user;

            LoadStaticProperties();
        }

        public MaterialDocumentDatabase(string connectionString, int userId)
            : base(connectionString)
        {
            ConnectedUser = User.Load(this, userId);

            LoadStaticProperties();
        }

        public string GetVariable(string name)
        {
            using (Connection connection = OpenConnection())
            {
                return GetVariable(connection, name);
            }
        }

        public string GetVariable(Connection connection, string name)
        {
            try
            {
                string query = MaterialDocument.Resources.Query.GetVariable;
                QueryParameters parameters = new QueryParameters("name", name);

                return (string)connection.ExecuteScalar(query, parameters);
            }
            catch (Exception)
            {
                throw new ArgumentException(MaterialDocument.Resources.Error.VariableNotFound.Replace("@name", name));
            }
        }

        private void LoadStaticProperties()
        {
            using (Connection connection = OpenConnection())
            {
                CreatorRole = int.Parse(GetVariable(connection, "materialCreatorGroup"));
                SignerRole = int.Parse(GetVariable(connection, "materialSignerGroup"));
            }
        }

        public static int CreatorRole { get; private set; }

        public static int SignerRole { get; private set; }

    }
}
