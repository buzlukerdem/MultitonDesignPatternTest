var db1 = Database.GetDatabaseInstance("MsSQL");
db1.ConnectionString("/connection...");
var db4 = Database.GetDatabaseInstance("MsSQL");

var db2 = Database.GetDatabaseInstance("Oracle");
var db3 = Database.GetDatabaseInstance("MySQL");

class Database
{
    static string _key = "";
    private Database()
    {
        Console.WriteLine($"{_key} nesnesi üretildi...");
    }
    static Dictionary<string, Database> _databases = new();

    public static Database GetDatabaseInstance(string key)
    {
        _key = key;
        // Key e karşılık instance kontrolü.
        if (!_databases.ContainsKey(key))
            _databases[key] = new Database();
        return _databases[key];

    }

    public void ConnectionString(string connectionString)
    {
    }

}
