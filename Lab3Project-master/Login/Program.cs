using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
       
        #region ViewsDeclaration
        public static ViewLogin V_Login { get; private set; }
        public static ViewSignUp V_SignUp { get;set; }
        public static ViewPlayerProfile V_PlayerProfile { get; set; }
        public static ViewMainMenu V_MainMenu { get; private set; }
        public static ViewGame V_Game { get;set; }
        public static ViewRules V_Rules { get; private set; }
        public static ViewStats V_Stats { get; set; }
        public static ViewSelectGameMode V_SelectGameMode { get; private set; }
        public static ViewAbout V_About { get; private set; }
        public static ViewOnline V_OnlineLobbys { get; private set; }
        #endregion

        #region ModelsDeclaration
        public static ModelLogin M_Login { get; private set; }
        public static ModelGame M_Game { get; set; }
        public static ModelProfile M_Profile { get; private set; }
        #endregion

        #region ControllersDeclaration
        public static ControllerLogin C_Login { get; set; }
        public static ControllerGame C_Game { get; set; }
        public static ControllerProfile C_Profile { get; private set; }
        #endregion


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            M_Game = new ModelGame();
            M_Login = new ModelLogin();
            M_Profile = new ModelProfile();

            V_Login = new ViewLogin();
            V_SignUp = new ViewSignUp();
            V_PlayerProfile = new ViewPlayerProfile();
            V_MainMenu = new ViewMainMenu();
            V_Game = new ViewGame();
            V_Rules = new ViewRules();
            V_Stats = new ViewStats();
            V_SelectGameMode = new ViewSelectGameMode();
            V_About = new ViewAbout();
            V_OnlineLobbys = new ViewOnline();

            C_Login= new ControllerLogin();
            C_Game = new ControllerGame();
            C_Profile = new ControllerProfile();
            Application.Run(V_Login);
        }
    }
}
