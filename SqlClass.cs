using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace KeyKeeper
{
    public class SqlClass
    {
        //string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KeyKeeper\Database1.mdf;Integrated Security=True";
        string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() + @"\Database1.mdf;Integrated Security=True";
        string command = "";
        public LoginClass login = new LoginClass();

        public SqlClass() { }
        
        public bool goodUsernameAndPassword(string username, string password)
        {
            int record = 0;

            string command = "SELECT COUNT (*) FROM USERS WHERE Username='"+username+"' AND Password = '"+password+"'";

            using var con = new SqlConnection(source);
            con.Open();

            using var cmd = new SqlCommand(command, con);
            record = int.Parse(cmd.ExecuteScalar().ToString());

            if (record == 1)
            {
                login = new LoginClass(getIdUser(username, password), username, password);
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public int getIdUser(string user, string password)
        {
            int result = 0;

            command = "SELECT Id FROM USERS WHERE Username='" + user + "' AND Password = '" + password + "'";

            using var con = new SqlConnection(source);
            con.Open();
            using var cmd = new SqlCommand(command, con);
            result = int.Parse(cmd.ExecuteScalar().ToString());
            return result;
        }

        public int isThatUser(string username)
        {
            int record;
            string command = "SELECT COUNT (*) FROM USERS WHERE Username='" + username + "'";

            using var con = new SqlConnection(source);
            con.Open();

            using var cmd = new SqlCommand(command, con);
            record = int.Parse(cmd.ExecuteScalar().ToString());
            return record;
        }

        public void addNewUser(string username, string password)
        {
            command = "INSERT INTO Users (Username, Password) VALUES ('" + username + "', '" + password + "');";

            using var con = new SqlConnection(source);
            con.Open();
            using var cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();

        }

        public bool changeUserPassword(string oldPassword, string newPassword, string confirmPassword)
        {
            if(login._password == oldPassword && newPassword==confirmPassword)
            {
                command = "UPDATE Users SET Password ='"+newPassword+"' WHERE Id="+login._id.ToString() + ";";

                using var con = new SqlConnection(source);
                con.Open();

                using var cmd = new SqlCommand(command, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<StoredPasswordClass> loadPassword(int userId)
        {
            command = "SELECT * FROM StoredPassword WHERE IdUser ='"+userId+"';";
            List<StoredPasswordClass> spcList = new List<StoredPasswordClass>();
            StoredPasswordClass spc = new StoredPasswordClass();
            List<string> listOfItem = new List<string>();
            using var con = new SqlConnection(source);
            con.Open();
            using var cmd = new SqlCommand(command, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string L_email;
            string L_Url;
            while (dr.Read())
            {
                if (dr["Email"] != null)
                    L_email = dr["Email"].ToString();
                else
                    L_email = "-";
                
                if (dr["Url"] != null)
                    L_Url = dr["Url"].ToString();
                else
                    L_Url = "-";

                var L_id = int.Parse(dr["Id"].ToString());
                var L_service = dr["Service"].ToString();
                var L_password = dr["Password"].ToString();
                var L_username = dr["Username"].ToString();

                spcList.Add(new StoredPasswordClass(L_id, L_service, L_Url, L_password, L_username, L_email));
            }
            return spcList;
        }

        public void changeInDataBase(string whatToChange, string valueOfChange)
        {
            command = "UPDATE Users SET "+ whatToChange+ " ='" + valueOfChange + "' WHERE Id=" + login._id.ToString() + ";";

            using var con = new SqlConnection(source);
            con.Open();

            using var cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();
        }
        public void addNewPasswordToDb(string whatToAdd, string whereToAdd)
        {
            command = "INSERT INTO StoredPassword (" + whereToAdd + ") VALUES (" + whatToAdd + ");";

            using var con = new SqlConnection(source);
            con.Open();

            using var cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();
        }

        public void deletePasswordFromDb(int idToDelete)
        {
            command = "DELETE FROM StoredPassword WHERE Id = '"+idToDelete+"';";

            using var con = new SqlConnection(source);
            con.Open();
            using var cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();

        }

        public void editPasswordInDb(string commandEditt, int idToEdit)
        {
            command = "UPDATE StoredPassword SET " +commandEditt + " WHERE Id="+idToEdit+";";

            using var con = new SqlConnection(source);
            con.Open();
            using var cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();
        }

        public List<StoredPasswordClass> loadingSearchingFromDb(string whatToSearch)
        {
            if(whatToSearch == string.Empty)
                command = "SELECT * FROM StoredPassword WHERE IdUser ='" + login._id + "';";
            else
                command = "SELECT * FROM StoredPassword WHERE IdUser ='" + login._id + "' AND Service LIKE '%"+whatToSearch+"%';";
            
            List<StoredPasswordClass> spcList = new List<StoredPasswordClass>();
            StoredPasswordClass spc = new StoredPasswordClass();
            List<string> listOfItem = new List<string>();
            using var con = new SqlConnection(source);
            con.Open();
            using var cmd = new SqlCommand(command, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string L_email;
            string L_Url;
            while (dr.Read())
            {
                if (dr["Email"] != null)
                    L_email = dr["Email"].ToString();
                else
                    L_email = "-";

                if (dr["Url"] != null)
                    L_Url = dr["Url"].ToString();
                else
                    L_Url = "-";

                var L_id = int.Parse(dr["Id"].ToString());
                var L_service = dr["Service"].ToString();
                var L_password = dr["Password"].ToString();
                var L_username = dr["Username"].ToString();

                spcList.Add(new StoredPasswordClass(L_id, L_service, L_Url, L_password, L_username, L_email));
            }
            return spcList;
        }
    }
}
