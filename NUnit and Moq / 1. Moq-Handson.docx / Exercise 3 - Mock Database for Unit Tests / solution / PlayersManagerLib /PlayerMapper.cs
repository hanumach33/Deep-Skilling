using System.Data.SqlClient;

namespace PlayersManagerLib
{
    public class PlayerMapper : IPlayerMapper
    {
        private readonly string connectionString =
            "Data Source=(local);Initial Catalog=GameDB;Integrated Security=True";

        public bool IsPlayerNameExistsInDb(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText =
                    "SELECT COUNT(*) FROM Player WHERE Name=@name";
                command.Parameters.AddWithValue("@name", name);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public void AddNewPlayerIntoDb(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText =
                    "INSERT INTO Player(Name) VALUES(@name)";
                command.Parameters.AddWithValue("@name", name);

                command.ExecuteNonQuery();
            }
        }
    }
}
