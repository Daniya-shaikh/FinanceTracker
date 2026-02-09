using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinanceTracker
{
    class DataAddExpense
    {
        SqlConnection con;

        public int Id { get; set; }
        public string Amount { get; set; }
        public string Category { get; set; }
        public string ExpenseDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public List<DataAddExpense> addExpenseData()
        {
            
            if (System.ComponentModel.LicenseManager.UsageMode
                == System.ComponentModel.LicenseUsageMode.Designtime)
            {
                return new List<DataAddExpense>();
            }

            List<DataAddExpense> listData = new List<DataAddExpense>();
            con = Database.GetConnection();
            if (con == null) return listData;

            try
            {
                con.Open();

                string query =
                    "SELECT * FROM Expense " +
                    "WHERE Date_Delete IS NULL";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataAddExpense dae = new DataAddExpense()
                        {
                            Id = (int)reader["Id"],
                            Amount = reader["Amount"].ToString(),
                            Category = reader["Category"].ToString(),
                            ExpenseDate = reader["ExpenseDate"].ToString(),
                            Description = reader["Description"].ToString(),
                            Status = reader["Status"].ToString()
                        };

                        listData.Add(dae);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting Database: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return listData;
        }

    }
}
