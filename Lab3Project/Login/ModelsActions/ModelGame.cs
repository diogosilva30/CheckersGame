using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

namespace LabProject
{
    public class ModelGame
    {
        #region PublicProperties
        public Game Game { get; private set; }
        public bool Flag { get; set; } = false;
        #endregion

        #region PublicEvents
        public event MethodsNoParamaters TurnDecided;
        public event Methods1Point ValidMovement;
        public event Methods1Bool GameOver;
        public event MethodsNoParamaters GameSaved;
        public event MethodsNoParamaters ErrorLoadingGame;
        public event MethodsNoParamaters SucessLoadingGame;
        public event MethodsNoParamaters BoardUpdated;

        #endregion

        #region PrivateVariables
        private string aux;
        #endregion

        
        public ModelGame()
        {
            Game = new Game();
            Game.GameIsOver += Game_GameIsOver;

        }

        private void Game_GameIsOver()
        {
            foreach (Player player in Game.Players)
            {
                player.N_Games++;
                if (Game.Winner == player)
                {
                    player.N_Wins++;
                }
                else
                {
                    player.N_Losts++;
                }
                if (player is RealPlayer)
                {
                    UpdateStatsBDAfterGame((player as RealPlayer).Username, player.N_Games, player.N_Wins, player.N_Losts, player.N_Left);
                }
                if (player is VirtualPlayer)
                {
                    SavePCInfo(player as VirtualPlayer);
                }
            }
            GameOver?.Invoke(false);


        }

        public void DefineGameMode(string Mode)
        {
            try
            {
                Game.Players.RemoveAt(1);
            }
            catch { }
            
            switch (Mode)
            {
                case "PC":
                    Game.GameMode = Game.GAMEMODE.PC;
                    Game.AddPlayer(new VirtualPlayer());
                    break;
                case "PVP":
                    Game.GameMode = Game.GAMEMODE.PVP;
                    Game.AddPlayer(new GuestPlayer("Player 2 - GUEST"));
                    break;
                case "NETWORK":
                    Game.GameMode = Game.GAMEMODE.NETWORK;
                    
                    break;
            }
        }
        public Player GetPlayerPlaying()
        {

            return Game.GetPlayerPlaying();
        }
        public Player GetWhitePlayer()
        {
            foreach (Player player in Game.Players)
            {
                if (player.Pieces[0].Color == Color.White)
                {
                    return player;
                }
            }
            return new RealPlayer();
        }
        public Player GetBluePlayer()
        {
            foreach (Player player in Game.Players)
            {
                if (player.Pieces[0].Color == Color.Blue)
                {
                    return player;
                }
            }
            return new RealPlayer();
        }





        public void SetUpPieces()
        {

            // 0 -> Player 1 gets white
            // 1 -> Player 2 gets white


            if (AuxFunctions.GetRandomNumber(0, 1) == 0)
            {
                Game.Players[0].IsTurn = true;
                Game.Players[0].Pieces.Add(new Piece(new Point(1, 5), Color.White));
                Game.Players[0].Pieces.Add(new Piece(new Point(3, 5), Color.White));
                Game.Players[0].Pieces.Add(new Piece(new Point(5, 5), Color.White));
                Game.Players[0].Pieces.Add(new Piece(new Point(7, 5), Color.White));
                Game.Players[0].Pieces.Add(new Piece(new Point(0, 6), Color.White));
                Game.Players[0].Pieces.Add(new Piece(new Point(2, 6), Color.White));
                Game.Players[0].Pieces.Add(new Piece(new Point(4, 6), Color.White));
                Game.Players[0].Pieces.Add(new Piece(new Point(6, 6), Color.White));
                Game.Players[0].Pieces.Add(new Piece(new Point(1, 7), Color.White));
                Game.Players[0].Pieces.Add(new Piece(new Point(3, 7), Color.White));
                Game.Players[0].Pieces.Add(new Piece(new Point(5, 7), Color.White));
                Game.Players[0].Pieces.Add(new Piece(new Point(7, 7), Color.White));

                Game.Players[1].Pieces.Add(new Piece(new Point(0, 0), Color.Blue));
                Game.Players[1].Pieces.Add(new Piece(new Point(2, 0), Color.Blue));
                Game.Players[1].Pieces.Add(new Piece(new Point(4, 0), Color.Blue));
                Game.Players[1].Pieces.Add(new Piece(new Point(6, 0), Color.Blue));
                Game.Players[1].Pieces.Add(new Piece(new Point(1, 1), Color.Blue));
                Game.Players[1].Pieces.Add(new Piece(new Point(3, 1), Color.Blue));
                Game.Players[1].Pieces.Add(new Piece(new Point(5, 1), Color.Blue));
                Game.Players[1].Pieces.Add(new Piece(new Point(7, 1), Color.Blue));
                Game.Players[1].Pieces.Add(new Piece(new Point(0, 2), Color.Blue));
                Game.Players[1].Pieces.Add(new Piece(new Point(2, 2), Color.Blue));
                Game.Players[1].Pieces.Add(new Piece(new Point(4, 2), Color.Blue));
                Game.Players[1].Pieces.Add(new Piece(new Point(6, 2), Color.Blue));



            }
            else
            {
                Game.Players[1].IsTurn = true;

                Game.Players[1].Pieces.Add(new Piece(new Point(1, 5), Color.White));
                Game.Players[1].Pieces.Add(new Piece(new Point(3, 5), Color.White));
                Game.Players[1].Pieces.Add(new Piece(new Point(5, 5), Color.White));
                Game.Players[1].Pieces.Add(new Piece(new Point(7, 5), Color.White));
                Game.Players[1].Pieces.Add(new Piece(new Point(0, 6), Color.White));
                Game.Players[1].Pieces.Add(new Piece(new Point(2, 6), Color.White));
                Game.Players[1].Pieces.Add(new Piece(new Point(4, 6), Color.White));
                Game.Players[1].Pieces.Add(new Piece(new Point(6, 6), Color.White));
                Game.Players[1].Pieces.Add(new Piece(new Point(1, 7), Color.White));
                Game.Players[1].Pieces.Add(new Piece(new Point(3, 7), Color.White));
                Game.Players[1].Pieces.Add(new Piece(new Point(5, 7), Color.White));
                Game.Players[1].Pieces.Add(new Piece(new Point(7, 7), Color.White));

                Game.Players[0].Pieces.Add(new Piece(new Point(0, 0), Color.Blue));
                Game.Players[0].Pieces.Add(new Piece(new Point(2, 0), Color.Blue));
                Game.Players[0].Pieces.Add(new Piece(new Point(4, 0), Color.Blue));
                Game.Players[0].Pieces.Add(new Piece(new Point(6, 0), Color.Blue));
                Game.Players[0].Pieces.Add(new Piece(new Point(1, 1), Color.Blue));
                Game.Players[0].Pieces.Add(new Piece(new Point(3, 1), Color.Blue));
                Game.Players[0].Pieces.Add(new Piece(new Point(5, 1), Color.Blue));
                Game.Players[0].Pieces.Add(new Piece(new Point(7, 1), Color.Blue));
                Game.Players[0].Pieces.Add(new Piece(new Point(0, 2), Color.Blue));
                Game.Players[0].Pieces.Add(new Piece(new Point(2, 2), Color.Blue));
                Game.Players[0].Pieces.Add(new Piece(new Point(4, 2), Color.Blue));
                Game.Players[0].Pieces.Add(new Piece(new Point(6, 2), Color.Blue));

            }
            TurnDecided?.Invoke();

        }
      
        public void Movement_Validation(Point origin, Point destination, string colour)
        {

            bool extra_movement = false;
            Game.HasEaten = false;
            if (Game.IsPlayPossible(origin, destination, colour))
            {

                if (Game.HasEaten)
                {
                    if (Game.ExtraMov(destination, colour))
                    {
                        extra_movement = true;
                    }
                }


                Game.CheckWinner();
                if (Game.Winner != null)
                {
                    Game.IsGameOver = true;
                }
                ValidMovement?.Invoke(destination);
                Game.CheckQueen(colour, destination);

                if (!extra_movement && !Game.IsGameOver)
                {
                    Game.SwitchTurn();
                    TurnDecided?.Invoke();
                }
                if (Game.GameMode == Game.GAMEMODE.PC)
                {
                    PC_Move();
                }
            }
        }
        public void PC_Move()
        {
            bool extra_movement = false;
            if (GetPlayerPlaying() is VirtualPlayer)
            {
                AuxFunctions.WaitNSeconds(3);
                if (Game.MakeAIMove(ref extra_movement))
                {
                    if (!extra_movement)
                    {
                        Game.SwitchTurn();
                        TurnDecided?.Invoke();
                    }
                    else
                    {
                        PC_Move();
                    }
                }

            }
        }
        public void GiveUp()
        {
            Game.GiveUp();

            Player p = GetPlayerPlaying();

            UpdateStatsBDAfterGame(p.Username, p.N_Games, p.N_Wins, p.N_Losts, p.N_Left);
        }

        public bool UpdateStatsBDAfterGame(string Username, int N_games, int N_wins, int N_losts, int N_left)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            string sqlConnectionString = "Server=(localdb)\\MSSQLLocalDB;AttachDbFilename=" + folder + "UsersDB.mdf" +
                                    ";Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "Update Users Set NumGames=@n_games, NumWins=@n_wins, NumDefeats=@n_losts, NumLeave=@n_left where Username = @user";
                command.Parameters.AddWithValue("@n_games", N_games);
                command.Parameters.AddWithValue("@n_wins", N_wins);
                command.Parameters.AddWithValue("@n_losts", N_losts);
                command.Parameters.AddWithValue("@n_left", N_left);
                command.Parameters.AddWithValue("@user", Username);

                connection.Open();

                int resultado = 0;
                try
                {
                    resultado = command.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException)
                {

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

        public void SavePCInfo(VirtualPlayer PC)
        {
            StreamWriter sw = new StreamWriter("PC.txt");
            sw.WriteLine(PC.N_Games + ";" + PC.N_Left + ";" + PC.N_Losts + ";" + PC.N_Wins);
            sw.Close();
        }


      
        public void PauseGame(string file)
        {
            XDocument doc = new XDocument(new XDeclaration("1.0", Encoding.UTF8.ToString(), "yes"),
                  new XComment("Game Saved"),
                  new XElement("Game",
                     new XElement("Player1"),
                     new XElement("Player2"),
                     new XElement("PiecesPlayer1"),
                     new XElement("PiecesPlayer2")));
            XElement Username1 = new XElement("Username", Game.Players[0].Username);
            XElement Username2 = new XElement("Username", Game.Players[1].Username);
            doc.Element("Game").Element("Player1").Add(Username1);
            doc.Element("Game").Element("Player2").Add(Username2);

            XElement turn1 = new XElement("Turn", Game.Players[0].IsTurn);
            XElement turn2 = new XElement("Turn", Game.Players[1].IsTurn);
            doc.Element("Game").Element("Player1").Add(turn1);
            doc.Element("Game").Element("Player2").Add(turn2);

            foreach (Piece p in Game.Players[0].Pieces)
            {
                XElement p1 = new XElement("Piece", new XAttribute("X", p.Position.X), new XAttribute("Y", p.Position.Y), new XAttribute("Queen", p.IsQueen),new XAttribute("Color",p.Color.Name));
                doc.Element("Game").Element("PiecesPlayer1").Add(p1);
            }
           
            foreach (Piece p in Game.Players[1].Pieces)
            {
                XElement p2 = new XElement("Piece", new XAttribute("X", p.Position.X), new XAttribute("Y", p.Position.Y), new XAttribute("Queen", p.IsQueen), new XAttribute("Color", p.Color.Name));
                doc.Element("Game").Element("PiecesPlayer2").Add(p2);
            }

            doc.Save(file);

            GameSaved?.Invoke();

        }


        public void TestLoadGame(string file)
        {
            XDocument doc = XDocument.Load(file);

            var player = from p in doc.Element("Game").Descendants("Player1") select p;

            foreach (var user in player)
            {
                aux = user.Element("Username").Value;
            }
            if (Game.Players[0].Username == aux)
            {
                LoadGame(file);
            }
            else
            {
                ErrorLoadingGame?.Invoke();
            }
            
        }

        

        public void LoadGame(string file)
        {
           DefineGameMode("PC");

            XDocument doc = XDocument.Load(file);
           

            var player1 = from p1 in doc.Element("Game").Descendants("Player1") select p1;
            foreach(var fields in player1)
            {
                Game.Players[0].Username = fields.Element("Username").Value;
                Game.Players[0].IsTurn = Convert.ToBoolean(fields.Element("Turn").Value);
            }

            var player2 = from p2 in doc.Element("Game").Descendants("Player2") select p2;
            foreach (var fields in player2)
            {
                Game.Players[1].Username = fields.Element("Username").Value;
                Game.Players[1].IsTurn = Convert.ToBoolean(fields.Element("Turn").Value);
            }
            Game.Players[0].Pieces.Clear();
            var pieces1 = from pi1 in doc.Element("Game").Element("PiecesPlayer1").Descendants("Piece") select pi1;

            foreach(var fields in pieces1)
            {
                Piece p = new Piece();
                Point point = new Point();
                point.X = Convert.ToInt32(fields.Attribute("X").Value);
                point.Y = Convert.ToInt32(fields.Attribute("Y").Value);
                p.Position = point;
                p.IsQueen = Convert.ToBoolean(fields.Attribute("Queen").Value);
                p.Color = Color.FromName(fields.Attribute("Color").Value);
                Game.Players[0].Pieces.Add(p);
            }

            Game.Players[1].Pieces.Clear();
            var pieces2 = from pi2 in doc.Element("Game").Element("PiecesPlayer2").Descendants("Piece") select pi2;

            foreach (var fields in pieces2)
            {
                Piece p = new Piece();
                Point point = new Point();
                point.X = Convert.ToInt32(fields.Attribute("X").Value);
                point.Y = Convert.ToInt32(fields.Attribute("Y").Value);
                p.Position = point;
                p.IsQueen = Convert.ToBoolean(fields.Attribute("Queen").Value);
                p.Color = Color.FromName(fields.Attribute("Color").Value);
                Game.Players[1].Pieces.Add(p);
            }

            UpdateBoard();
            
            SucessLoadingGame?.Invoke();
        }
        public void SetUpGame()
        {
            SetUpPieces();
            Game.SetDefaultState();
            BoardUpdated?.Invoke();
        }

        public void UpdateBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Game.Board.BoardMatrix[i, j] = Board.EMPTY;
                }
            }

            Game.Board.DefaultState();

            foreach (Player player in Game.Players)
            {
                foreach (Piece piece in player.Pieces)
                {
                    if (piece.Color == Color.White)
                    {
                        if (piece.IsQueen)
                        {
                            Game.Board.BoardMatrix[piece.Position.X, piece.Position.Y] = Board.WHITE_QUEEN;
                        }
                        else
                        {
                            Game.Board.BoardMatrix[piece.Position.X, piece.Position.Y] = Board.WHITE_PIECE;
                        }
                    }
                    if (piece.Color == Color.Blue)
                    {
                        if (piece.IsQueen)
                        {
                            Game.Board.BoardMatrix[piece.Position.X, piece.Position.Y] = Board.BLUE_QUEEN;
                        }
                        else
                        {
                            Game.Board.BoardMatrix[piece.Position.X, piece.Position.Y] = Board.BLUE_PIECE;
                        }
                    }
                }
            }
            BoardUpdated?.Invoke();
        }
      
    }
  
}

