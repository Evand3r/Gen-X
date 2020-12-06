using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Controls
{
    class FieldType
    {
        private FlowLayoutPanel Parent;

        public FieldType(FlowLayoutPanel parent)
        {
            this.Parent = parent;
        }

        public FieldPanel CreateField(string FieldName, string Type)
        {
            return new FieldPanel(Parent, FieldName, Type);
        }
    }
}
