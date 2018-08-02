using DasKeyboard.Q;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QTracker
{
    public class SignalGenerator
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        dynamic client;
        Logger log = new Logger(0);

        Signal ErrorSig = new Signal()
        {
            Name = "QTracker Error",
            Pid = "DK5QPID",
            ZoneId = "2,2",
            Color = "#FF0000",
            Effect = "BLINK"
        };

        public SignalGenerator(bool cloud = false)
        {
            if (cloud)
            {
                client = new Client
                {
                    AuthenticationMode = AuthenticationMode.ClientCredentials,
                    Credentials = new NetworkCredential(
                    "pkCIaqfX5mbT6QxLFPqZVbKsg",  // client_id
                    "GPC4ITTy80ISOT3hB2ZG98bhN"), // client_secret
                };
                log.Log("Cloud connection established!");
            }
            else { 
                client = new Client
                {
                    AuthenticationMode = AuthenticationMode.None,
                    ApiEndPoint = Client.LocalEndPoint,
                };
                log.Log("Local connection established!");
            }
        }
        public void SendSignal(String name, Vector2  zoneId, String color, String effect)
        {
            var sig = new Signal()
            {
                Name = name,
                Pid = "DK5QPID",
                ZoneId = zoneId.ToString(),
                Color = color,
            };
            //if(GetAsyncKeyState(System.Windows.Forms.Keys.Space) != 0)
                client.CreateSignal(sig);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="zoneId"></param>
        /// <param name="color"></param>
        /// <param name="effect"></param>
        /// <param name="horizontal"></param>
        public void SendSignalHorizontalRow(String name, Vector2 zoneId, String[] color, String effect, bool horizontal = true)
        {
            for(int i=0; i<color.Length; i++)
            {
                if (horizontal)
                    zoneId.x += i;
                else
                    zoneId.y += i;

                Signal sig;
                if (zoneId.x > 23 || zoneId.x < 0)
                    sig = ErrorSig;
                else if (zoneId.y > 5 || zoneId.y < 0)
                    sig = ErrorSig;
                else {
                    sig = new Signal() {
                        Name = name+"#"+i+"/"+color.Length,
                        Pid = "DK5QPID",
                        ZoneId = zoneId.x + "," + zoneId.y,
                        Color = color[i],
                        Effect = effect
                    };
                }

                client.CreateSignal(sig);
            }
        }

        public void SendSignalHorizontalRow(string name, Vector2 zoneId, string color, string effect, int length, bool horizontal = true)
        {
            for (int i = 0; i < length; i++)
            {
                if (horizontal)
                    zoneId.x += i;
                else
                    zoneId.y += i;

                Signal sig;
                if (zoneId.x > 23 || zoneId.x < 0)
                    sig = ErrorSig;
                else if (zoneId.y > 5 || zoneId.y < 0)
                    sig = ErrorSig;
                else
                {
                    sig = new Signal()
                    {
                        Name = name + "#" + i + "/" + length,
                        Pid = "DK5QPID",
                        ZoneId = zoneId.x + "," + zoneId.y,
                        Color = color,
                        Effect = effect,
                    };
                }

                client.CreateSignal(sig);
            }
        }

        public void DrawPercentBarAsync(string name, Vector2 zoneId, string color, string effect, int percentage, int maxlength=10)
        {
            Console.Clear();

            for (int i = 0; i < maxlength; i++)
            {
                String finalColor;

                if (i < percentage)
                    finalColor = color;
                else
                    finalColor = "#00FF00";

                int newZoneX = zoneId.x + i;

                log.Log("Position" + zoneId.x + "," + newZoneX);

                Signal sig;
                if (newZoneX > 23 || newZoneX < 0)
                    sig = ErrorSig;
                else if (zoneId.y > 5 || zoneId.y < 0)
                    sig = ErrorSig;
                else
                {
                    sig = new Signal()
                    {
                        Name = name + "-" + i + "/" + maxlength,
                        Pid = "DK5QPID",
                        ZoneId = newZoneX + "," + zoneId.y,
                        Color = finalColor,
                        Effect = effect,
                        Message = "Position: " + zoneId.x + "," + newZoneX + " Color: " + finalColor + " Percentage: " + percentage,
                        ShouldNotify = false,
                        IsMuted = true,
                        IsRead = true,
                        IsArchived = true
                    };
                }
                log.Log("Position: " + zoneId.x + "," + newZoneX + " Color: " + finalColor + " Percentage: " + percentage);
                client.CreateSignal(sig);
            }
        }

    }


    public class Vector2
    {
        public int x, y;
        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return this.x + "," + this.y;
        }
    }
}
