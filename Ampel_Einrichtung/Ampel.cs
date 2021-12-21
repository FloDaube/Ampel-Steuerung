using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ampel_Einrichtung
{
    public class Ampel
    {
        public string State = "000";

        bool State_Red;
        bool State_Yellow;
        bool State_Green;

        Color color_Red_On = Color.Red;
        Color color_Red_Off = Color.DarkRed;
        Color color_Yellow_On = Color.Yellow;
        Color color_Yellow_Off = Color.DarkOrange;
        Color color_Green_On = Color.Green;
        Color color_Green_Off = Color.DarkGreen;

        public Ampel()
        {
            State_Red = false;
            State_Yellow = false;
            State_Green = false;
        }
        void UpdateState()
        {
            if (State_Red == true)
            {
                State = "1";
            }
            else
            {
                State = "0";
            }
            if (State_Yellow == true)
            {
                State += "1";
            }
            else
            {
                State += "0";
            }
            if (State_Green == true)
            {
                State += "1";
            }
            else
            {
                State += "0";
            }
        }

        public void Set_State(bool Red,bool Yellow,bool Green)
        {
            State_Red = Red;
            State_Yellow = Yellow;
            State_Green = Green;
            UpdateState();
        }

        public void Set_State_Red(bool State)
        {
            State_Red = State;
            UpdateState();
        }

        public void Set_State_Green(bool State)
        {

            State_Green = State;
            UpdateState();
        }

        public void Set_State_Yellow(bool State)
        {
            State_Yellow = State;
            UpdateState();
        }

        public void Draw(ref Panel panel)
        {
            //Pens
            Pen pen_black = new Pen(Color.Black);
            SolidBrush solidBrush_Black = new SolidBrush(Color.Black);

            Pen pen_Red;
            SolidBrush solidBrush_Red;
            if (State_Red)
            {
                pen_Red = new Pen(color_Red_On);
                solidBrush_Red = new SolidBrush(color_Red_On);
            }
            else
            {
                pen_Red = new Pen(color_Red_Off);
                solidBrush_Red = new SolidBrush(color_Red_Off);
            }

            Pen pen_Yellow;
            SolidBrush solidBrush_Yellow;
            if (State_Yellow)
            {
                pen_Yellow = new Pen(color_Yellow_On);
                solidBrush_Yellow = new SolidBrush(color_Yellow_On);
            }
            else
            {
                pen_Yellow = new Pen(color_Yellow_Off);
                solidBrush_Yellow = new SolidBrush(color_Yellow_Off);
            }

            Pen pen_Green;
            SolidBrush solidBrush_Green;
            if (State_Red)
            {
                pen_Green = new Pen(color_Green_On);
                solidBrush_Green = new SolidBrush(color_Green_On);
            }
            else
            {
                pen_Green = new Pen(color_Green_Off);
                solidBrush_Green = new SolidBrush(color_Green_Off);
            }

            Graphics graphic_BG = panel.CreateGraphics();

            Rectangle background = new Rectangle();
            background.X = 0;
            background.Y = 0;
            background.Width = 100;
            background.Height = 170;
            graphic_BG.DrawRectangle(pen_black,background);
            graphic_BG.FillRectangle(solidBrush_Black, background.X,background.Y,background.Width,background.Height);
            
            Graphics graphic_Red = panel.CreateGraphics();

            int durchmesser = 40;
            graphic_Red.DrawEllipse(pen_Red, (background.Width / 2) - (durchmesser / 2), (background.Height / 3) - durchmesser - 5, durchmesser, durchmesser);
            graphic_Red.FillEllipse(solidBrush_Red, (background.Width / 2) - (durchmesser / 2), (background.Height / 3) - durchmesser - 5, durchmesser, durchmesser);

            Graphics graphic_Yellow = panel.CreateGraphics();
            graphic_Yellow.DrawEllipse(pen_Yellow, (background.Width / 2) - (durchmesser / 2), (background.Height / 3) * 2 - durchmesser - 5, durchmesser, durchmesser);
            graphic_Yellow.FillEllipse(solidBrush_Yellow, (background.Width / 2) - (durchmesser / 2), (background.Height / 3) * 2 - durchmesser - 5, durchmesser, durchmesser);

            Graphics graphic_Green = panel.CreateGraphics();
            graphic_Green.DrawEllipse(pen_Green, (background.Width / 2) - (durchmesser / 2), (background.Height / 3) * 3 - durchmesser - 5, durchmesser, durchmesser);
            graphic_Green.FillEllipse(solidBrush_Green, (background.Width / 2) - (durchmesser / 2), (background.Height / 3) * 3 - durchmesser - 5, durchmesser, durchmesser);
        } 
    }
}
