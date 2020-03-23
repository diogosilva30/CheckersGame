using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    public class ModelLogin
    {
       
        #region PublicEvents
        public event Methods1String Error_SignUp;
        public event MethodsNoParamaters SignUp_Successful;
        public event Methods2Strings Login_Successful;
        public event Methods1String Error_Login;
        #endregion


       
        
        public void SignUp_Request(string str1, string str2, string str3, string str4, 
            string str5, string str6, string str7, string str8, string str9)
        {
            // str1 --> Username
            // str2 --> First Name
            // str3 --> Last Name
            // str4 --> Profile Pic Path
            // str5 --> Password
            // str6 --> Password Re-Enter
            // str7 --> Email
            // str8 --> Email Re-Enter
            // str9 --> Country

            if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2) || string.IsNullOrWhiteSpace(str3) ||
                string.IsNullOrWhiteSpace(str4) || string.IsNullOrWhiteSpace(str5) || string.IsNullOrWhiteSpace(str6) ||
                string.IsNullOrWhiteSpace(str7) || string.IsNullOrWhiteSpace(str8) || string.IsNullOrWhiteSpace(str9))
            {
                Error_SignUp?.Invoke("Error: Missing information!");
                return;
            }
            if (!str5.Equals(str6))
            {
                Error_SignUp?.Invoke("Error: Passwords do not match!");
                return;
            }
            if (!AuxFunctions.IsValidEmail(str7))
            {
                Error_SignUp?.Invoke("Error: Email format not valid!");
                return;
            }
            if (!str7.Equals(str8))
            {
                Error_SignUp?.Invoke("Error: Emails do not match!");
                return;
            }
            
            if(AddUserDB(str1, str2, str3, str4, str5, str7, str9))
            {
                SignUp_Successful?.Invoke();
                return;
            }
        }

        public bool AddUserDB(string str1, string str2, string str3, string str4,
            string str5,string str7, string str9)
        {
            // str1 --> Username
            // str2 --> First Name
            // str3 --> Last Name
            // str4 --> Profile Pic Path
            // str5 --> Password
            // str7 --> Email
            // str9 --> Country

            var hashed_password = SecurePasswordHasher.Hash(str5);

            //Obtem o caminho fisico para a pasta do código da aplicação
            //para poder reutilizar a base de dados, caso contrário, ele está sempre a substituir
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            //construir a ligação ao servidor SQL Server local com o caminho do ficheiro
            string sqlConnection = "Server=(localdb)\\MSSQLLocalDB;AttachDbFilename=" + folder + "UsersDB.mdf" +
                                     ";Trusted_Connection=True;";

            //inicializar a ligação ao servidor
            SqlConnection server = new SqlConnection(sqlConnection);

            //abrir a ligação
            server.Open();

            //obter o nome do ficheiro
            string filename = System.IO.Path.GetFileName(str4);

            //construir a string SQL de insert nas tabelas
            // para aplicações reais devem usar SQL parameters e não string directas 
            string comando = String.Format("INSERT INTO Users" +
                                            "(Username, Name, Surname,Password, Photo, Email, Country) values " +
                                            "( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                            str1, str2, str3, hashed_password, filename,str7,str9);

            //construir o comando SQL com a ligação ao servidor
            SqlCommand command = new SqlCommand(comando, server);

            //executar o comando sem expectativa de receber resultados (usar para INSERTS, UPDATES, DELETE)
            //o metodo devolve o numero de linhas modificadas pela query enviada
            int resultado=0;
            try
            {
                resultado = command.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                Error_SignUp?.Invoke("Error: This username already exists!");
            }
           
            //fechar sempre a ligação quando deixa de ser necessária
            server.Close();

            if (resultado==1)  // se o resultado for 1, significa que adicionou correctamente o utilizador
            {
                //guardar copia do ficheiro na pasta fotos
                System.IO.File.Copy(str4,
                    "Fotos\\" + filename, true);
                return true;
            }
            return false;    
        }

        public void Login_Request(string username, string password)
        {

            //para poder reutilizar a base de dados, caso contrário, ele está sempre a substituir
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            //construir a ligação ao servidor SQL Server local com o caminho do ficheiro
            string sqlConnection = "Server=(localdb)\\MSSQLLocalDB;AttachDbFilename=" + folder + "UsersDB.mdf" +
                                     ";Trusted_Connection=True;";

            //inicializar a ligação ao servidor
            SqlConnection server = new SqlConnection(sqlConnection);

            //abrir a ligação
            server.Open();
            //construir a string SQL de insert nas tabelas
            // para aplicações reais devem usar SQL parameters e não string directas 
            string cmdText = string.Format("SELECT * FROM Users WHERE " +
                                            "username = '{0}'",
                                            username);

            //construir o comando SQL com a ligação ao servidor
            SqlCommand command = new SqlCommand(cmdText, server);

            //executar o comando e receber os dados resultantes dessa query 
            SqlDataReader Data = command.ExecuteReader();

            if (Data.HasRows) //vereficar se tem resultados, o que significa que há algum registo com aquele username e password
            {//o login é valido

                Data.Read(); //lê uma linha dos resultados, este metodo retorna um bool para informar se conseguiu ler ou não

                if (SecurePasswordHasher.Verify(password, Data["Password"].ToString()))
                {
                    // Adds player to the game
                    Program.M_Game.Game.AddPlayer(new RealPlayer(Data["Username"].ToString(), Data["Email"].ToString(), password,
                       Data["Name"].ToString(), Data["Surname"].ToString(), Data["Country"].ToString(), Data["Photo"].ToString(), 
                       Convert.ToInt32(Data["NumGames"]),Convert.ToInt32(Data["NumWins"]), Convert.ToInt32(Data["NumLeave"]), 
                       Convert.ToInt32(Data["NumDefeats"])));

                    Login_Successful?.Invoke(Data["Name"].ToString(), Data["Surname"].ToString());
                    server.Close();
                    return;
                }
            }
            // Close SQL connection
            server.Close();
            Error_Login?.Invoke("The username or password is incorrect!");
        }


    }
 }


