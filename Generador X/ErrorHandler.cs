using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Generador_X
{
    class ErrorHandler
    {
        public static void ShowMessage(string message, MessageType type = MessageType.error)
        {
            MessageBoxIcon icon = MessageBoxIcon.None;
            string Title = "";

            switch (type)
            {
                case MessageType.error:
                    icon = MessageBoxIcon.Error;
                    Title = "Error";
                    break;
                case MessageType.warning:
                    icon = MessageBoxIcon.Warning;
                    Title = "Advertencia";
                    break;
                case MessageType.info:
                    icon = MessageBoxIcon.Information;
                    Title = "Info";
                    break;
                default:
                    break;
            }

                MessageBox.Show(message, Title, MessageBoxButtons.OK, icon);
        }
    }

    enum MessageType
    {
        error,
        warning,
        info
    }
}
