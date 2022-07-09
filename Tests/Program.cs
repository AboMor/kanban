using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using IntroSE.Kanban.Backend.ServiceLayer;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //UnitTests ut = new UnitTests();
            List<int> c = new List<int>();
            c.Add(1);
            c.Add(2);
            c.Add(3);
            c.RemoveAt(1);
            c.Add(4);
            c.Insert(1, 2);
            foreach(int a in c)
            {
                Console.WriteLine(a);
            }
            int x = 6;
            Console.WriteLine(x++);
            Console.WriteLine(x);
        }
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Service service = new Service();
            //new TestRegistration(service).RunTests();

            Console.WriteLine(DateTime.Now.ToString());

            string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "kanban.db"));
            Console.WriteLine(path);
            string connectionString = $"Data Source={path}; Version=3;";
            const string UsersTableName = "users";

            Console.WriteLine(Insert("lior@gmail.com", "789"));
            DisplayTable(UsersTableName);


        }

        public static void DisplayTable(string Tname)
        {
            string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "kanban.db"));
            Console.WriteLine(path);
            string connectionString = $"Data Source={path}; Version=3;";


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(null, connection);
                try
                {
                    connection.Open();
                    command.CommandText = $"SELECT * FROM {Tname}";

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string email = reader.GetString(0);
                        string pass = reader.GetString(1);

                        Console.WriteLine("Email: " + email + " - " + "Password: " + pass);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(command.CommandText);
                    Console.WriteLine(e.ToString());
                    //log error
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }

            }
        }

        public static bool Insert(string email, string pass)
        {
            string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "kanban.db"));
            Console.WriteLine(path);
            string connectionString = $"Data Source={path}; Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                const string UsersTableName = "users";
                int res = -1;
                SQLiteCommand command = new SQLiteCommand(null, connection);
                try
                {
                    connection.Open();
                    command.CommandText = $"INSERT INTO {UsersTableName} ({"email"} ,{"password"}) " +
                        $"VALUES (@emailVal,@passVal);";

                    SQLiteParameter emailParam = new SQLiteParameter(@"emailVal", email);
                    SQLiteParameter passParam = new SQLiteParameter(@"passVal", pass);

                    command.Parameters.Add(emailParam);
                    command.Parameters.Add(passParam);
                    command.Prepare();

                    res = command.ExecuteNonQuery();
                }
                catch
                {
                    //log error
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return res > 0;
            }
        }
        */
    }
}
