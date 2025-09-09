namespace _5Sqlite;

using Microsoft.Data.Sqlite;

public class PetsDB
{
    private string _connectionString = "Data Source = Petsdb.db";

    public PetsDB()
    {
        // Tietokantaan yhteys
        var connection = new SqliteConnection(_connectionString);
        connection.Open();
        // Luodaan taulu, jos sitä ei ole
        var commandForCreateTable = connection.CreateCommand();
        commandForCreateTable.CommandText = "CREATE TABLE IF NOT EXISTS Owners (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, phonenumber TEXT);";
        commandForCreateTable.CommandText = "CREATE TABLE IF NOT EXISTS Pets (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, onwersid INTEGER, FOREIGN KEY(ownerid) REFERENCES Owners(id));";
        commandForCreateTable.ExecuteNonQuery();
        connection.Close();
    }
}