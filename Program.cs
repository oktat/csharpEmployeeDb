using MySqlConnector;

string host = "localhost";
string name = "zoldzrt";
string user = "zoldzrt";
string pass = "titok";

string connstr = $"Server={host};Database={name};User ID={user};Password={pass};";
using MySqlConnection conn = new(connstr);
try {
    conn.Open();
    string sql = "select * from employees";
    using MySqlCommand cmd = new(sql, conn);
    using MySqlDataReader reader = cmd.ExecuteReader();
    while(reader.Read()) {
        Console.WriteLine($"{reader["name"]}\t{reader["city"]}");
    }
}catch(MySqlException e) {
    Console.Error.WriteLine("Hiba! A lekérdezés sikeretelen!");
    Console.Error.WriteLine(e.Message);
}

