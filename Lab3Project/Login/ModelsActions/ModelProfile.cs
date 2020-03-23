using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    public class ModelProfile
    {
        #region PublicEvents
        public event Methods1String Error_Change;
        public event MethodsNoParamaters SuccessChanges;
        #endregion

        

        public void ChangeProfile(string Username, string Name, string Surname, string Password, string Email, string Country)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Surname) || string.IsNullOrWhiteSpace(Password) ||
               string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Country))
            {
                {
                    Error_Change?.Invoke("Error: Missing information!");
                    return;
                }

            }
            if (!AuxFunctions.IsValidEmail(Email))
            {
                Error_Change?.Invoke("Error: Email format not valid!");
                return;
            }
            if(ChangeDB(Username, Name,Surname,Password,Email,Country))
            {
                if(SuccessChanges!=null)
                {
                    SuccessChanges();
                    (Program.M_Game.Game.Players[0] as RealPlayer).Name = Name;
                    (Program.M_Game.Game.Players[0] as RealPlayer).Surname = Surname;
                    (Program.M_Game.Game.Players[0] as RealPlayer).Password = Password;
                    (Program.M_Game.Game.Players[0] as RealPlayer).Email = Email;
                    (Program.M_Game.Game.Players[0] as RealPlayer).Country = Country;
               
                    return;
                }
                
            }
        }

        public void ChangeProfileFoto(string Username, string Path)
        {
            if (string.IsNullOrWhiteSpace(Path))
            {
                return;
            }
            if (ChangeDBFoto(Username, Path))
            {
                string filename = System.IO.Path.GetFileName(Path);
                (Program.M_Game.Game.Players[0] as RealPlayer).Foto = Image.FromFile("Fotos\\" + filename);
                return;
            }
        }

        public bool ChangeDB(string Username, string Name, string Surname, string Password, string Email, string Country)
        {
            var hashed_password = SecurePasswordHasher.Hash(Password);

            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            string sqlConnectionString = "Server=(localdb)\\MSSQLLocalDB;AttachDbFilename=" + folder + "UsersDB.mdf" +
                                    ";Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Update Users Set Name=@name, Surname = @surname, Password = @pw,  Email = @mail, Country = @country where Username = @user";
                command.Parameters.AddWithValue("@name", Name);
                command.Parameters.AddWithValue("@surname", Surname);
                command.Parameters.AddWithValue("@pw", hashed_password);
                command.Parameters.AddWithValue("@mail", Email);
                command.Parameters.AddWithValue("@country", Country);
                command.Parameters.AddWithValue("@user", Username);


                connection.Open();

                int resultado = 0;
                try
                {
                    resultado = command.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    Error_Change?.Invoke("Error: Error changing profile!");

                    connection.Close();
                }

                connection.Close();

                if (resultado == 1)  // se o resultado for 1, significa que adicionou correctamente o utilizador
                {
                   

                    return true;
                }
                return false;

            }
        }

            public bool ChangeDBFoto(string Username, string Path)
            {
                string filename = System.IO.Path.GetFileName(Path);
                var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

                string sqlConnectionString = "Server=(localdb)\\MSSQLLocalDB;AttachDbFilename=" + folder + "UsersDB.mdf" +
                                        ";Trusted_Connection=True;";

                using (SqlConnection connection = new SqlConnection(sqlConnectionString))
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Update Users Set Photo=@ft where Username = @user";
                    command.Parameters.AddWithValue("@ft", filename );
                    command.Parameters.AddWithValue("@user", Username);
                    

                    connection.Open();

                    int resultado = 0;
                    try
                    {
                        resultado = command.ExecuteNonQuery();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        Error_Change?.Invoke("Error: Error changing profile!");

                        connection.Close();
                    }

                    connection.Close();

                    if (resultado == 1)  // se o resultado for 1, significa que adicionou correctamente o utilizador
                    {
                        //guardar copia do ficheiro na pasta fotos
                        System.IO.File.Copy(Path,
                            "Fotos\\" + filename, true);

                        return true;
                    }
                    return false;
                }

            }
        }
}
