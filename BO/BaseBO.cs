using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace hms.BO
{
    public class BaseBO
    {
        public DataTable GetIndexData(string menuName)
        {
            DataTable DataTable = new DataTable(menuName);
            using (SqlConnection conn = new SqlConnection(hmsConstants.ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GetIndexDataSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@menuName", menuName);
                    cmd.Parameters.AddWithValue("@hmsTenantAutoId", "0");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(DataTable);

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return DataTable;
        }

        public DataSet GetAddEditData(int AutoId, string menuName)
        {
            DataSet dataSet = null;
            if (AutoId > 0)
            {
                using (SqlConnection conn = new SqlConnection(hmsConstants.ConnectionString))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("GetViewDataSP", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@menuName", menuName);
                        cmd.Parameters.AddWithValue("@AutoId", AutoId);
                        cmd.Parameters.AddWithValue("@hmsTenantAutoId", "0");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        conn.Open();
                        adapter.Fill(dataSet);

                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
            return dataSet;
        }
    }
}