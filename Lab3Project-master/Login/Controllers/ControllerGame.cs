using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    public class ControllerGame
    {
        public ControllerGame()
        {
            Program.V_SelectGameMode.GameModeSelected += V_SelectGameMode_GameModeSelected;
            Program.V_Game.MovementRequest += V_Game_MovementRequest;
            Program.V_Game.GiveUp += V_Game_GiveUp;
            Program.V_Game.RequestSaveGame += V_Game_RequestSaveGame;
            Program.V_SelectGameMode.RequestLoadGame += V_SelectGameMode_RequestLoadGame;
            Program.V_SelectGameMode.SetUpNewGame += V_SelectGameMode_SetUpNewGame;
           
        }

        private void V_SelectGameMode_SetUpNewGame()
        {
            Program.M_Game.SetUpGame();
        }

        private void V_SelectGameMode_RequestLoadGame(string str)
        {
            Program.M_Game.TestLoadGame(str);
        }

        private void V_Game_RequestSaveGame(string str)
        {
            Program.M_Game.PauseGame(str);
        }

        

        private void V_Game_GiveUp()
        {
            Program.M_Game.GiveUp();
        }

        private void V_Game_MovementRequest(System.Drawing.Point p1, System.Drawing.Point p2, string str)
        {
            Program.M_Game.Movement_Validation(p1, p2, str);
        }

       

        private void V_SelectGameMode_GameModeSelected(string str)
        {
            Program.M_Game.DefineGameMode(str);
        }
    }
}
