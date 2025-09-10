namespace _5Sqlite;

using Microsoft.Data.Sqlite;

public class PetsDB
{
    private string _connectionString = "Data Source = Petsdb.db";

    public PetsDB()
    {
        // Tietokantaan yhteys
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            // Luodaan taulu, jos sitä ei ole
            var commandForCreateTable1 = connection.CreateCommand();
            commandForCreateTable1.CommandText = "CREATE TABLE IF NOT EXISTS Owners (id INTEGER PRIMARY KEY, name TEXT, phonenumber TEXT);";
            commandForCreateTable1.ExecuteNonQuery();
            var commandForCreateTable2 = connection.CreateCommand();
            commandForCreateTable2.CommandText = "CREATE TABLE IF NOT EXISTS Pets (id INTEGER PRIMARY KEY, name TEXT, ownerid INTEGER);";
            commandForCreateTable2.ExecuteNonQuery();
        }
    }
    public void AddOwner(string name, string phonenumber)
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var commandForInsert = connection.CreateCommand();
            commandForInsert.CommandText = "INSERT INTO Owners (name, phonenumber) VALUES (@name, @phonenumber);";
            commandForInsert.Parameters.AddWithValue("@name", name);
            commandForInsert.Parameters.AddWithValue("@phonenumber", phonenumber);
            commandForInsert.ExecuteNonQuery();
        }
    }
    public void AddPet(string name, int ownerid)
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var commandForInsert = connection.CreateCommand();
            commandForInsert.CommandText = "INSERT INTO Pets (name, ownerid) VALUES (@name, @ownerid);";
            commandForInsert.Parameters.AddWithValue("@name", name);
            commandForInsert.Parameters.AddWithValue("@ownerid", ownerid);
            commandForInsert.ExecuteNonQuery();
        }
    }
    public void UpdateOwnerPhoneNumber(int ownerid, string newphonenumber)
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var commandForUpdate = connection.CreateCommand();
            commandForUpdate.CommandText = "UPDATE Owners SET phonenumber = @newphonenumber WHERE id = @ownerid;";
            commandForUpdate.Parameters.AddWithValue("@newphonenumber", newphonenumber);
            commandForUpdate.Parameters.AddWithValue("@ownerid", ownerid);
            commandForUpdate.ExecuteNonQuery();
        }
    }
    public string? SearchOwnerPhoneNumberByPetName(string petname)
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var commandForSelect = connection.CreateCommand();
            commandForSelect.CommandText = "SELECT Owners.phonenumber FROM Owners JOIN Pets ON Owners.id = Pets.ownerid WHERE Pets.name = @petname;";
            commandForSelect.Parameters.AddWithValue("@petname", petname);
            using (var reader = commandForSelect.ExecuteReader())
            {
                //Siiryttään seuraavaan riviin, jos rivejä on palauttaa true ja lukee ensimmäisen rivin
                if (reader.Read())
                {
                    //Jos read onnistuu palauttaa ensimmäisen sarakkeen arvon eli puhelinnumeron
                    return reader.GetString(0);
                }
                else
                {
                    //palauttaa null jos ei löydä mitään
                    return null;
                }
            }
        }
    }
}