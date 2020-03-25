using System;
using System.Data.SqlClient;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Services;Integrated Security=True";
            using (SqlConnection  connection = new SqlConnection(connectionString))
            {
                string sqlExpression = "SELECT * FROM Customer";
                connection.Open();
                CheckData(sqlExpression, connection, 1);
                sqlExpression = "SELECT * FROM Service";
                Console.WriteLine();
                CheckData(sqlExpression, connection, 2);
                Console.WriteLine();
                sqlExpression = "SELECT * FROM DATBASELOG";
                CheckData(sqlExpression, connection, 3);
                Console.WriteLine();
                sqlExpression = "SELECT * from Service where ServiceDate between '2019-01-01' and '2020-01-01'";
                CheckData(sqlExpression, connection, 2);
            }
        }
        public static void  CheckData(string sqlExpression, SqlConnection connection, int numb)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                if (numb == 1)
                {
                    Console.WriteLine("{0}\t\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));
                    while (reader.Read())
                    {
                        if (numb == 1)
                        {
                            Customer customer = new Customer(reader.GetValue(0).ToString(), Convert.ToInt32(reader.GetValue(1)),
                                reader.GetValue(2).ToString(), reader.GetValue(3).ToString());
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", customer.Name, customer.Age, customer.Gender, customer.PhoneNumber);
                        }
                    }
                }
                else if(numb == 2)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));
                    while (reader.Read())
                    {
                        Service service = new Service(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(),
                                Convert.ToInt32(reader.GetValue(2)), Convert.ToDateTime(reader.GetValue(3).ToString()));
                        Console.WriteLine("{0}\t{1}\t{2}\t\t{3}", service.ServiceName, service.ServiceCustomer, service.ServiceCost, service.Data);
                    }
                }
                else if (numb == 3)
                {
                    Console.WriteLine("{0}\t\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
                    while (reader.Read())
                    {
                        DatBaseLog datBaseLog = new DatBaseLog(Convert.ToDateTime(reader.GetValue(0)), reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
                        Console.WriteLine("{0}\t{1}\t\t{2}", datBaseLog.ModifyTime, datBaseLog.Operation, datBaseLog.TableName);
                    }
                }
            }
            reader.Close();
        }
    }
}
