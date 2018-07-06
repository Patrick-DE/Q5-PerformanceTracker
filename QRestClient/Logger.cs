using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    static class Logger
    {
        public static RichTextBox context = null;
    /// <summary>
    /// 2=OnlyError, 1=Error+Alert, 0=All
    /// </summary>
    public static int filter = 0;

        /*public static Logger(RichTextBox context, int filter = 2)
        {
            context = context;
            filter = filter;
        }*/
        
         /// <summary>
         /// Nachricht in der MessageBox ausgeben
         /// </summary>
         /// <param name="message">Geloggte Nachricht</param>
         /// <param name="status">2=Error, 1=Alert, 0=Debug</param>
        public static void Log(String message, int status = 0)
        {
            string statusChar = "";
            switch (status) {
                //Debug
                case 0:
                    statusChar = "[-]";
                    break;
                //Alert
                case 1:
                    statusChar = "[!]";
                    break;
                //Error
                case 2:
                    statusChar = "[x_X]";
                    break;
            }                

            if( status >= filter)
                context.AppendText("\n" + statusChar + DateTime.Now + " - " + message);
        }
    }