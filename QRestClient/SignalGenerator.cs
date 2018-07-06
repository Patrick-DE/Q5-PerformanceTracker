using DasKeyboard.Q;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Wedge.DasKeyboardQClient;
//using Wedge.DasKeyboardQClient.DataContracts;

namespace QTracker
{
    public class SignalGenerator
    {
        dynamic client;

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
            /*if (cloud)  
                Client = new CloudQClient("G1vpEhNG0sDEnnRhUAkvVSS5Q", "CNrF0eq8YtXVobshB7Oui7kbJ");// Cloud Client
            else
                Client = new LocalQClient();// Local Client
            */
            client = new Client
            {
                AuthenticationMode = AuthenticationMode.None,
                ApiEndPoint = Client.LocalEndPoint,
            };
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

            client.CreateSignalAsync(sig);
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

                client.CreateSignalAsync(sig);
            }
        }

        public async Task SendSignalHorizontalRowAsync(string name, Vector2 zoneId, string color, string effect, int length, bool horizontal = true)
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
                        Effect = effect
                    };
                }

                //Client.CreateSignalAsync(sig);
                Send(sig);
            }
        }

        public async Task DrawPercentBarAsync(string name, Vector2 zoneId, string color, string effect, int percentage, int maxlength=10)
        {
            for (int i = 0; i < maxlength; i++)
            {
                String finalColor;

                if (i < percentage)
                    finalColor = color;
                else
                    finalColor = "#00FF00";

                zoneId.x += i;

                Signal sig;
                if (zoneId.x > 23 || zoneId.x < 0)
                    sig = ErrorSig;
                else if (zoneId.y > 5 || zoneId.y < 0)
                    sig = ErrorSig;
                else
                {
                    sig = new Signal()
                    {
                        Name = name + "#" + i + "/" + maxlength,
                        Pid = "DK5QPID",
                        ZoneId = zoneId.x + "," + zoneId.y,
                        Color = color,
                        Effect = effect
                    };
                }

                //Client.CreateSignalAsync(sig);
                Send(sig);
            }
        }

        public async Task Send(Signal sig)
        {
            await client.CreateSignal(sig); // This also updates the signal object.
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
