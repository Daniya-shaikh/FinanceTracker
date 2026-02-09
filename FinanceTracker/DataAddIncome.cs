using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FinanceTracker
{
    class DataAddIncome
    {
        SqlConnection con;


        public int Id { set; get; }
        public string Amount { set; get; }
        public string Category { set; get; }
        public string IncomeDate { set; get; }
        public string Description { set; get; }
        public string Status { set; get; }


        public List<DataAddIncome> addIncomeData()
        {

            if (System.ComponentModel.LicenseManager.UsageMode
                == System.ComponentModel.LicenseUsageMode.Designtime)
            {
                return new List<DataAddIncome>();
            }


            List<DataAddIncome> ListData = new List<DataAddIncome>();

            con = Database.GetConnection();

            try
            {
                con.Open();

                string selectData = "SELECT * FROM Income WHERE Date_Delete IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        DataAddIncome dai = new DataAddIncome()
                        {
                            Id = (int)reader["Id"],
                            Amount = reader["Amount"].ToString(),
                            Category = reader["Category"].ToString(),
                            IncomeDate = reader["IncomeDate"].ToString(),
                            Description = reader["Description"].ToString()
                        };


                        ListData.Add(dai);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting Database:" + ex);
            }
            finally
            {
                con.Close();

            }
            return ListData;
        }
    }
}



