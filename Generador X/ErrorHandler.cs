using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Generador_X
{
    class ErrorHandler
    {
        public static void ShowMessage(string message, MessageType type)
        {
            if(type == MessageType.error)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    enum MessageType
    {
        error,
        warning,
        info
    }
}
