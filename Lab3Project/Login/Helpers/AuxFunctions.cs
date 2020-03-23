using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject
{
    public static class AuxFunctions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        private static readonly Random GetRandom = new Random(DateTime.Now.Millisecond);

        public static void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
        public static int GetRandomNumber(int min, int max)
        {
            lock (GetRandom) // synchronize
            {
                return GetRandom.Next(min, max);
            }
        }

        public static Point GetPosition(System.Windows.Forms.Label l, int Height, int Width)
        {
            int y = (Height / 2) - (l.Height/ 2);
           
            int x = (Width / 2) - (l.Width / 2);
            return new Point(x, y);
        }

        public static bool IsBetween(int a, int b, int value)
        {
            if (value<b && value> a )
            {
                return true;
            }
            return false;

        }

        public static int Highest(params int[] inputs)
        {
            return inputs.Max();
        }

        public static int Lowest(params int[] inputs)
        {
            return inputs.Min();
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
