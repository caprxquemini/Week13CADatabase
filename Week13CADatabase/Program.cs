using System.Data.SQLite;


static SQLiteConnection CreateConnection ()
{
    SQLiteConnection connection = new SQLiteConnection("Data Source=mydb.db; Version=3; New=true; Compress = true");

    try
{
    connection.Open();
    Console.WriteLine("Connection established");
} catch
{
    Console.WriteLine("DB connection failed");
}

    try
    {
        connection.Open();
        Console.WriteLine("Connection established");
    }
    catch
    {
        Console.WriteLine("DB connection failed");
    }

    return connection;
}