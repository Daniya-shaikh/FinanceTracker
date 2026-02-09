using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace FinanceTracker
{
    class DataHistory
    {
        public List<HistoryItem> GetHistory(
            string type,
            string amountFilter,
            DateTime fromDate,
            DateTime toDate)
        {
            List<HistoryItem> list = new List<HistoryItem>();

            SqlConnection con = Database.GetConnection();
            if (con == null) return list;

            try
            {
                con.Open();

                string query = @"
                SELECT * FROM (
                    SELECT 
                        IncomeDate AS Date,
                        'Income' AS Type,
                        Category,
                        Amount,
                        'Completed' AS Status,
                        Description
                    FROM Income
                    WHERE Date_Delete IS NULL

                    UNION ALL

                    SELECT
                        ExpenseDate AS Date,
                        'Expense' AS Type,
                        Category,
                        Amount,
                        Status,
                        Description
                    FROM Expense
                    WHERE Date_Delete IS NULL
                ) AS H
                WHERE Date BETWEEN @FromDate AND @ToDate
                ";

                if (type != "All")
                    query += " AND Type = @Type";

                if (amountFilter == "Below 500")
                    query += " AND Amount < 500";
                else if (amountFilter == "500 - 2000")
                    query += " AND Amount BETWEEN 500 AND 2000";
                else if (amountFilter == "Above 2000")
                    query += " AND Amount > 2000";

                query += " ORDER BY Date DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate.Date);
                    cmd.Parameters.AddWithValue("@ToDate", toDate.Date);

                    if (type != "All")
                        cmd.Parameters.AddWithValue("@Type", type);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new HistoryItem
                            {
                                Date = Convert.ToDateTime(reader["Date"]),
                                Type = reader["Type"].ToString(),
                                Category = reader["Category"].ToString(),
                                Amount = Convert.ToDecimal(reader["Amount"]),
                                Status = reader["Status"].ToString(),
                                Description = reader["Description"].ToString()
                            });
                        }
                    }
                }
            }
            finally
            {
                con.Close();
            }

            return list;
        }

    }
}
