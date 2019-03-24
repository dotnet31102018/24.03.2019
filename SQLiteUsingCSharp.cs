using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp14
{
    class Program
    {

        static void Main(string[] args)
        {

            // connect to the Data Base
            using (SQLiteConnection con =
                new SQLiteConnection("Data Source = e:\\sqlite\\sqlite-tools-win32-x86-3250300\\db1.db; Version = 3;"))
            {

                // open the connection
                con.Open();

                // create a query (suign the connection)
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From COMPANY ", con))
                {

                    // execut4e the query into the reader
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        // use the reader to read all of the results of the query
                        while (reader.Read())
                        {

                            // pull out the data result using GetValue for dield number
                            Console.WriteLine(
                                $"{reader.GetValue(0)} {reader.GetValue(1)} {reader.GetValue(2)} {reader.GetValue(3)} {reader.GetValue(4)}");
                        }
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
