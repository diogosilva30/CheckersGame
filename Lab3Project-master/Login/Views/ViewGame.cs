using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject
{
    public partial class ViewGame : Form
    {
        #region PublicEvents
        public event Methods2Points1String MovementRequest;
        public event MethodsNoParamaters GiveUp;
        public event Methods1String RequestSaveGame;
        #endregion

        #region PrivateVariables
        private PictureBox selection = null;
        private Point[,] PointLocationMatrix = new Point[8, 8];
        #endregion

        // WHEN ESC IS PRESSED OPEN THE MENU
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                ButtonMenu_Click(new object(), new EventArgs());
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        public ViewGame()
        {
            InitializeComponent();
            Program.M_Game.TurnDecided += M_Game_TurnDecided;
            Program.M_Game.ValidMovement += M_Game_ValidMovement;
            Program.M_Game.Game.Piece_Eaten += Game_Piece_Eaten;
            Program.M_Game.Game.PieceNowQueen += M_Game_PieceNowQueen;
            Program.M_Game.GameOver += M_Game_GameOver;
            Program.M_Game.Game.Board.JumpMustBeTaken += Board_JumpMustBeTaken;
            Program.M_Game.Game.AIMove += Game_AIMove;
            Program.M_Game.GameSaved += M_Game_GameSaved;
            Program.M_Game.SucessLoadingGame += M_Game_SucessLoadingGame;
            Program.M_Game.BoardUpdated += M_Game_BoardUpdated;
            
        }

        private void M_Game_BoardUpdated()
        {
            List<PictureBox> Blues = new List<PictureBox>();
            Blues.Add(Blue1);
            Blues.Add(Blue2);
            Blues.Add(Blue3);
            Blues.Add(Blue4);
            Blues.Add(Blue5);
            Blues.Add(Blue6);
            Blues.Add(Blue7);
            Blues.Add(Blue8);
            Blues.Add(Blue9);
            Blues.Add(Blue10);
            Blues.Add(Blue11);
            Blues.Add(Blue12);
            List<PictureBox> Whites = new List<PictureBox>();
            Whites.Add(White1);
            Whites.Add(White2);
            Whites.Add(White3);
            Whites.Add(White4);
            Whites.Add(White5);
            Whites.Add(White6);
            Whites.Add(White7);
            Whites.Add(White8);
            Whites.Add(White9);
            Whites.Add(White10);
            Whites.Add(White11);
            Whites.Add(White12);
            BuildPointLocationMatrix();
            foreach (PictureBox pictureBox in Whites)
            {
                pictureBox.Visible = true;
            }
            foreach (PictureBox pictureBox in Blues)
            {
                pictureBox.Visible = true;
            }

            Board currentBoard = Program.M_Game.Game.Board;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine("A TESTAR - " + i + " - " + j);
                    if (currentBoard.BoardMatrix[i, j] == Board.WHITE_PIECE)
                    {
                        Whites[0].Location = PointLocationMatrix[i, j];
                        Whites.RemoveAt(0);
                    }
                    if (currentBoard.BoardMatrix[i, j] == Board.WHITE_QUEEN)
                    {
                        Whites[0].Location = PointLocationMatrix[i, j];
                        M_Game_PieceNowQueen(new Point(i, j));
                        Whites.RemoveAt(0);
                    }
                    if (currentBoard.BoardMatrix[i, j] == Board.BLUE_PIECE)
                    {
                        Blues[0].Location = PointLocationMatrix[i, j];
                        Blues.RemoveAt(0);
                    }
                    if (currentBoard.BoardMatrix[i, j] == Board.BLUE_QUEEN)
                    {
                        Blues[0].Location = PointLocationMatrix[i, j];
                        M_Game_PieceNowQueen(new Point(i, j));
                        Blues.RemoveAt(0);
                    }
                }

            }
            foreach (Control item in Whites)
            {
                this.Controls.Remove(item);
                item.Dispose();
            }
            foreach (Control item in Blues)
            {
                this.Controls.Remove(item);
                item.Dispose();
            }
        }

        private void M_Game_SucessLoadingGame()
        {
            
            LabelTurn.ForeColor = Color.Black;
            if (Program.M_Game.Game.Players[0].IsTurn)
            {

                LabelTurn.Text = "Now Playing: " + Program.M_Game.Game.Players[0].Username;
            }

            if (Program.M_Game.Game.Players[1].IsTurn)
            {
                LabelTurn.Text = "Now Playing: " + Program.M_Game.Game.Players[1].Username;
            }
            if (Program.M_Game.Game.Players[0].IsTurn)
            {

                LabelTurn.Text = "Now Playing: " + Program.M_Game.Game.Players[0].Username;
            }

            if (Program.M_Game.Game.Players[1].IsTurn)
            {
                LabelTurn.Text = "Now Playing: " + Program.M_Game.Game.Players[1].Username;
            }

        }

        private void M_Game_GameSaved()
        {
            LabelTurn.ForeColor = Color.Green;
            LabelTurn.Text = "Game Saved!";
            AuxFunctions.WaitNSeconds(4);
            Program.V_SelectGameMode.Visible = true;
            Close();
        }

        private void Game_AIMove(Point p1, Point p2)
        {
            PictureBox PB_Origin = FindPictureBox(p1);
            PB_Origin.Location = PointLocationMatrix[p2.X, p2.Y];

        }

        private void Board_JumpMustBeTaken(Point p)
        {
            PlaceToPlayBox.Visible = true;
            PlaceToPlayBox.Location=PointLocationMatrix[p.X, p.Y];
            LabelTurn.ForeColor = Color.Red;
            LabelTurn.Text = "Jump must be taken!";
            AuxFunctions.WaitNSeconds(2);
            PlaceToPlayBox.Visible = false;
            M_Game_TurnDecided();
        }

        

        private void M_Game_GameOver(bool tie)
        {
            if (!Program.M_Game.Game.IsGameOver) return;

            if (tie)
            {
                LabelTurn.Text = "The game was tied!";
            }
            else
            {
                LabelTurn.Text = Program.M_Game.Game.Winner.Username + " has won the game!";
            }
                
                LabelTurn.ForeColor = Color.LightSkyBlue;
                LabelTurn.Font= new Font("Segoe UI",45);

            AuxFunctions.WaitNSeconds(5);
            Program.V_SelectGameMode.Visible = true;
            Close();
            
        }

        private void M_Game_PieceNowQueen(Point p)
        {
            PictureBox PB_toQueen = FindPictureBox(p);

            if (PB_toQueen.Name.Substring(0,1)=="W")
            {
                PB_toQueen.BackgroundImage = Properties.Resources.dama_branca_queen;
            }
            if (PB_toQueen.Name.Substring(0, 1) == "B")
            {
                PB_toQueen.BackgroundImage = Properties.Resources.dama_azul_queen;
            }

        }

        private PictureBox FindPictureBox(Point MatrixCoordinates)
        {
            Point x = PointLocationMatrix[MatrixCoordinates.X, MatrixCoordinates.Y];

            if (Blue1.Location==x)  return Blue1;

            if (Blue2.Location == x) return Blue2;

            if (Blue3.Location == x) return Blue3;

            if (Blue4.Location == x) return Blue4;

            if (Blue5.Location == x) return Blue5;

            if (Blue6.Location == x) return Blue6;

            if (Blue7.Location == x) return Blue7;

            if (Blue8.Location == x) return Blue8;

            if (Blue9.Location == x) return Blue9;

            if (Blue10.Location == x) return Blue10;

            if (Blue11.Location == x) return Blue11;

            if (Blue12.Location == x) return Blue12;

            if (White1.Location == x) return White1;

            if (White2.Location == x) return White2;

            if (White3.Location == x) return White3;

            if (White4.Location == x) return White4;

            if (White5.Location == x) return White5;

            if (White6.Location == x) return White6;

            if (White7.Location == x) return White7;

            if (White8.Location == x) return White8;

            if (White9.Location == x) return White9;

            if (White10.Location == x) return White10;

            if (White11.Location == x) return White11;

            if (White12.Location == x) return White12;

            return new PictureBox();


        }
        private void Game_Piece_Eaten(Point p)
        {
            PictureBox PB_to_Hide = FindPictureBox(p);
            PB_to_Hide.Hide();
            PB_to_Hide.Location = new Point(Board_Graphical.Location.X + Board_Graphical.Size.Width, Board_Graphical.Location.Y);
        }

        private void M_Game_ValidMovement(Point p)
        {
            selection.Location = PointLocationMatrix[p.X, p.Y];
            selection.BackColor = Color.Transparent;
            selection = null;
        }

       
        private void M_Game_TurnDecided()
        {

            LabelTurn.ForeColor = Color.Black;
            if (Program.M_Game.Game.Players[0].IsTurn)
            {
                
                LabelTurn.Text = "Now Playing: " + Program.M_Game.Game.Players[0].Username;
            }

            if (Program.M_Game.Game.Players[1].IsTurn)
            {
                LabelTurn.Text = "Now Playing: " + Program.M_Game.Game.Players[1].Username;
            }

        }

        private void LoadInfo()
        {
            if (Program.M_Game.Game.Players[0].IsTurn)
            {
                labelPlayer2.Text = Program.M_Game.Game.Players[0].Username;
                pictureBoxPlayer2.BackgroundImage = Program.M_Game.Game.Players[0].Foto;
                pictureBoxPlayer2.BackgroundImageLayout = ImageLayout.Zoom;

                labelPlayer1.Text = Program.M_Game.Game.Players[1].Username;
                pictureBoxPlayer1.BackgroundImage = Program.M_Game.Game.Players[1].Foto;
                pictureBoxPlayer1.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                labelPlayer2.Text = Program.M_Game.Game.Players[1].Username;
                pictureBoxPlayer2.BackgroundImage = Program.M_Game.Game.Players[1].Foto;
                pictureBoxPlayer2.BackgroundImageLayout = ImageLayout.Zoom;

                labelPlayer1.Text = Program.M_Game.Game.Players[0].Username;
                pictureBoxPlayer1.BackgroundImage = Program.M_Game.Game.Players[0].Foto;
                pictureBoxPlayer1.BackgroundImageLayout = ImageLayout.Zoom;
            }
            
        }

        private void ViewGame_Load(object sender, EventArgs e)
        {

            LoadInfo();
            if (!(Program.M_Game.Game.GameMode==Game.GAMEMODE.PC))
            {
                ButtonPauseGame.Hide();
            }
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            BuildPointLocationMatrix();
        }
        private void BuildPointLocationMatrix()
        {
            float res = Board_Graphical.Width / 8;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PointLocationMatrix[i, j] = new Point(Convert.ToInt32(res) * i, Convert.ToInt32(res) * j);
                }
            }
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 60)
            {
                ExpandMenu();
                return;
            }
            if (PanelMenu.Width == 256)
            {
                // MINIMIZE
                MinimizeMenu();
                return;
            }
        }

        private void ExpandMenu()
        {
            if (PanelMenu.Width==60)
            {
                PanelMenu.Visible = false;
                PanelMenu.Width = 256;
                Transition.ShowSync(PanelMenu);
                ButtonGiveUp.Enabled = true;
                ButtonAboutUs.Enabled = true;
                ButtonExit.Enabled = true;

                ButtonPauseGame.Enabled = true;
            }
            
        }
        private void MinimizeMenu()
        {
            if (PanelMenu.Width ==256)
            {
                PanelMenu.Visible = false;
                PanelMenu.Width = 60;
                Transition.ShowSync(PanelMenu);
                ButtonGiveUp.Enabled = false;
                ButtonAboutUs.Enabled = false;
                ButtonExit.Enabled = false;
                ButtonPauseGame.Enabled = false;
            }
            
        }
       

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (ButtonExit.Enabled)
            {
                Program.V_MainMenu.Visible = true;
                Close();
            }

        }

        private void pictureBoxPlayer1_MouseHover(object sender, EventArgs e)
        {
            if (Program.M_Game.Game.GameMode == Game.GAMEMODE.PVP && (Program.M_Game.GetBluePlayer() is GuestPlayer))
            {
                return;
            }
            Point Ponto = new Point(78,185);
            Program.V_Stats = new ViewStats(Program.M_Game.GetBluePlayer());
            Program.V_Stats.Show();
            Program.V_Stats.Location = Ponto;
        }

        private void pictureBoxPlayer1_MouseLeave(object sender, EventArgs e) 
        {
            Program.V_Stats.Visible=false;
        }
        
        private void pictureBoxPlayer2_MouseHover(object sender, EventArgs e) 
        {
            if (Program.M_Game.Game.GameMode == Game.GAMEMODE.PVP && (Program.M_Game.GetWhitePlayer() is GuestPlayer))
            {
                return;
            }
            if (Program.M_Game.GetPlayerPlaying() is GuestPlayer)
            {
                return;
            }
            Point Ponto2 = new Point(1665, 833);
            Program.V_Stats = new ViewStats(Program.M_Game.GetWhitePlayer());
            Program.V_Stats.Show();
            Program.V_Stats.Location = Ponto2;
        }

        private void pictureBoxPlayer2_MouseLeave(object sender, EventArgs e)
        {
            Program.V_Stats.Visible = false;
        }

        private void Selection(object sender, MouseEventArgs e)
        {
            if (Program.M_Game.GetPlayerPlaying() is VirtualPlayer)
            {
                return;
            }
            if (Program.M_Game.Game.IsGameOver) // GAME IS OVER!
            {
                return;
            }
            // If its not the same color as the color to play return!
            if (Program.M_Game.Game.GetTurnColor().Substring(0,1)!=(sender as PictureBox).Name.Substring(0,1))
            {
                return;
            }
            
            try
            {
                selection.BackColor = Color.Transparent;

            }
            catch { }
            selection = sender as PictureBox;
            selection.BackColor = Color.DimGray;
        }


        private Point FindMatrixCoordinates(Point P)
        {
            int NewX = 0, NewY = 0;
            bool stop = false;
            Point pointAux = new Point(), nextPointAux = new Point();
            for (int i = 0; i < 8; i++)
            {
                if (stop) break;

                for (int j = 0; j < 8; j++)
                {
                    pointAux = PointLocationMatrix[i, j];

                    try
                    {
                        nextPointAux = PointLocationMatrix[i + 1, j + 1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        nextPointAux = PointLocationMatrix[i, j];
                        nextPointAux.Y += 106;
                        nextPointAux.X += 106;
                    }
                    if (pointAux.X <=P.X && nextPointAux.X > P.X &&
                    pointAux.Y <= P.Y && nextPointAux.Y > P.Y)
                    {
                        NewX = i;
                        NewY = j;
                        stop = true;
                        break;
                    }

                }
            }
            return new Point(NewX, NewY);
        }


        private void TabClick(object sender, MouseEventArgs e)
        {
            if (selection==null)
            {
                return;
            }

            MovementRequest?.Invoke(FindMatrixCoordinates(selection.Location), FindMatrixCoordinates(e.Location), selection.Name.Substring(0,1));
          
        }

        private void ButtonAboutUs_Click(object sender, EventArgs e)
        {
            if (ButtonAboutUs.Enabled)
            {
                Program.V_About.ShowDialog();
            }
        }

        private void ButtonGiveUp_Click(object sender, EventArgs e)
        {
            GiveUp?.Invoke();
        }


        private void ButtonPauseGame_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter=("XML Files|*.xml");
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                RequestSaveGame?.Invoke(dlg.FileName);
            }
            
        }
    }
}
