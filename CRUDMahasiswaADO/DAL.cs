using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public class DAL
    {
        // Fungsi untuk mengambil IP Lokal saat Deployment nanti
        public static string GetLocalIPAddress()
        {
            string localIP = string.Empty;
            try
            {
                var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting local IP address: " + ex.Message);
            }
            return localIP;
        }

        public string GetConnectionString()
        {
            return "Data Source=DESKTOP-BQJ792T\\AFDAN;Initial Catalog=DBAkademikADO;Integrated Security=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        public int CountMhs()
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_CountMahasiswa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter outputParam = new SqlParameter("@Total", SqlDbType.Int);
                outputParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(outputParam.Value);
            }
        }

        public DataTable GetMhs()
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetMahasiswa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void InsertMhs(string nim, string nama, string alamat, string jeniskelamin, DateTime tanggallahir, string kodeProdi, byte[] foto)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("sp_InsertMahasiswa", conn, trans);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("pNIM", nim);
                    command.Parameters.AddWithValue("pNama", nama);
                    command.Parameters.AddWithValue("pAlamat", alamat);
                    command.Parameters.AddWithValue("pJenisKelamin", jeniskelamin);
                    command.Parameters.AddWithValue("pTanggalLahir", tanggallahir);
                    command.Parameters.AddWithValue("pKodeProdi", kodeProdi);
                    // Handle foto null
                    command.Parameters.Add("pFoto", SqlDbType.VarBinary, -1).Value = (object)foto ?? DBNull.Value;
                    command.ExecuteNonQuery();
                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public void UpdateMhs(string nim, string nama, string alamat, string jeniskelamin, DateTime tanggallahir, string kodeProdi, byte[] foto)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("sp_UpdateMahasiswa", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("pNIM", nim);
                command.Parameters.AddWithValue("pNama", nama);
                command.Parameters.AddWithValue("pAlamat", alamat);
                command.Parameters.AddWithValue("pJenisKelamin", jeniskelamin);
                command.Parameters.AddWithValue("pTanggalLahir", tanggallahir);
                command.Parameters.AddWithValue("pKodeProdi", kodeProdi);
                command.Parameters.Add("pFoto", SqlDbType.VarBinary, -1).Value = (object)foto ?? DBNull.Value;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteMhs(string nim)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_DeleteMahasiswa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NIM", nim);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable getDataRekap(string prodi, DateTime tanggalMasuk)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_Report", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@inProdi", prodi);
                cmd.Parameters.AddWithValue("@inTglMsuk", tanggalMasuk.Year.ToString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable getAllDataChart()
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_DashBoard", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable getDataChartByTahun(DateTime thMasuk)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_DashBoardByTahun", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@inTglMsuk", thMasuk.Year.ToString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void InsertLog(string message)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LogMessage", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("psn", message);
                cmd.ExecuteNonQuery();
            }
        }

        public void resetData()
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string deleteQuery = "DELETE FROM mahasiswa;";
                SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn);
                cmdDelete.ExecuteNonQuery();
                string insertQuery = @"INSERT INTO mahasiswa SELECT * FROM mahasiswa_backup;";
                SqlCommand cmdInsert = new SqlCommand(insertQuery, conn);
                cmdInsert.ExecuteNonQuery();
            }
        }

        public void testInject(string nim)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                // Query rentan SQL Injection untuk keperluan simulasi praktikum
                string query = "UPDATE mahasiswa SET nama='HACKED' WHERE NIM ='" + nim + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }


    }
}