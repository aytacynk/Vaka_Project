using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaka_Project.Models
{
    public class Robotic
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }
        public List<string> changeDirection = new List<string>();

        public override string ToString()
        {
            return this.X.ToString() + this.Y.ToString() + this.Direction;
        }

        public void RoboticDirection(Robotic r)
        {
            changeDirection.Add(Convert.ToString(r.X));
            changeDirection.Add(Convert.ToString(r.Y));
            changeDirection.Add(r.Direction.ToString());
        }

        public string FindNewDirection(char newDirection, int maxCoordi_X, int maxCoordi_Y)
        {
            switch (newDirection)
            {
                case 'L':
                    if (changeDirection[2] == "N")
                        changeDirection[2] = "W";
                    else if (changeDirection[2] == "W")
                        changeDirection[2] = "S";
                    else if (changeDirection[2] == "S")
                        changeDirection[2] = "E";
                    else if (changeDirection[2] == "E")
                        changeDirection[2] = "N";
                    break;
                case 'R':
                    if (changeDirection[2] == "N")
                        changeDirection[2] = "E";
                    else if (changeDirection[2] == "E")
                        changeDirection[2] = "S";
                    else if (changeDirection[2] == "S")
                        changeDirection[2] = "W";
                    else if (changeDirection[2] == "W")
                        changeDirection[2] = "N";
                    break;
                case 'M':
                    if (changeDirection[2] == "N")
                        changeDirection[1] = (Convert.ToInt32(changeDirection[1]) + 1).ToString();
                    else if (changeDirection[2] == "E")
                        changeDirection[0] = (Convert.ToInt32(changeDirection[0]) + 1).ToString();
                    else if (changeDirection[2] == "W")
                        changeDirection[0] = (Convert.ToInt32(changeDirection[0]) - 1).ToString();
                    else if (changeDirection[2] == "S")
                        changeDirection[1] = (Convert.ToInt32(changeDirection[1]) - 1).ToString();
                    break;
            }
            if (Convert.ToInt32(changeDirection[0]) > maxCoordi_X)
                changeDirection[0] = maxCoordi_X.ToString();
            else if (Convert.ToInt32(changeDirection[1]) > maxCoordi_Y)
                changeDirection[1] = maxCoordi_Y.ToString();
            else if (Convert.ToInt32(changeDirection[0]) < 0)
                changeDirection[0] = "0";
            else if (Convert.ToInt32(changeDirection[1]) < 0)
                changeDirection[1] = "0";
            return "Yeni Yönünüz -->  " + changeDirection[0] + " " + changeDirection[1] + " " + changeDirection[2];
        }

    }
}
