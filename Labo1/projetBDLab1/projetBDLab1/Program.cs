using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace projetBDLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // creation de connexion et utilisation
            SqlConnection connectionBD = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DB_Premier_Labo; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            connectionBD.Open();

            //commandes
            SqlCommand command = new SqlCommand("INSERT INTO Student (FullName ) VALUES ('Libert Manon')", connectionBD);

            SqlDataReader reader = command.ExecuteReader();
            reader.Close();

            command = new SqlCommand("SELECT * FROM Student", connectionBD);
            reader = command.ExecuteReader();
            reader.Close();

            while (reader.Read())
                {
                    Console.Write("{0} - {2}",reader[0], reader[1], reader[2]);
                }
            
                connectionBD.Close();
            Console.ReadKey();

        }
    }
}
