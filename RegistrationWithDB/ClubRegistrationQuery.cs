using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistrationWithDB
{
    public class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSource;

        private string connectionString;

        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;

        public ClubRegistrationQuery()
        {
            // Initialize the connection string and SQL connection (ANNEX-PC00)
            connectionString = @"Data Source=ANNEX-PC00;Initial Catalog=ClubDB2;
            User ID=caparros.428518;Password=123456;TrustServerCertificate=True;";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayList()
        {
            string ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, " +
                                     "LastName, Age, Gender, Program FROM ClubMembers";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            return true;
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, 
                                    string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES " +
                "(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }

        public void PopulateStudentIDs(ComboBox cbStudentId)
        {
            cbStudentId.Items.Clear();
            sqlCommand = new SqlCommand("SELECT StudentId FROM ClubMembers", sqlConnect);
            sqlConnect.Open();
            sqlReader = sqlCommand.ExecuteReader();
            while (sqlReader.Read())
            {
                cbStudentId.Items.Add(sqlReader["StudentId"].ToString());
            }
            sqlReader.Close();
            sqlConnect.Close();
        }

        public void SearchStudent(long studentId)
        {
            sqlCommand = new SqlCommand("SELECT FirstName, MiddleName, LastName, Age, Gender, Program " +
                                        "FROM ClubMembers WHERE StudentId = @StudentId", sqlConnect);
            sqlCommand.Parameters.Add("@StudentId", SqlDbType.BigInt).Value = studentId;
            sqlConnect.Open();
            sqlReader = sqlCommand.ExecuteReader();
            if (sqlReader.Read())
            {
                _FirstName = sqlReader["FirstName"].ToString();
                _MiddleName = sqlReader["MiddleName"].ToString();
                _LastName = sqlReader["LastName"].ToString();
                _Age = Convert.ToInt32(sqlReader["Age"]);
                _Gender = sqlReader["Gender"].ToString();
                _Program = sqlReader["Program"].ToString();
            }
            sqlReader.Close();
            sqlConnect.Close();
        }

        public bool UpdateStudent(long StudentID, string FirstName, string MiddleName, 
                                  string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = " +
                "@LastName, Age = @Age, Gender = @Gender, Program = @Program WHERE StudentId = @StudentID", sqlConnect);
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }
    }
}