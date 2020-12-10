using Generador_X.Model;
using Generador_X.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Generador_X.Controls
{
    /// <summary>
    /// Panel con las opciones personalizadas de cada tipo de campo.
    /// </summary>
    class OptionsPanel : FlowLayoutPanel
    {
        public FieldType ftype;
        public BaseOptionsType Options;
        public string Nulls;

        public OptionsPanel(FieldType fieldType)
        {
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Location = new Point(384, 5);
            Size = new Size(339, 38);
            //BorderStyle = BorderStyle.FixedSingle;
            Padding = new Padding(4);

            ftype = fieldType;

            SuspendLayout();
            Options = CreateOption(ftype.BName);
            Nulls = Options.NullsCount.Text;
            Controls.AddRange(Options.panelControls.ToArray());

            ResumeLayout(false);
        }

        private BaseOptionsType CreateOption(EBFieldType type)
        {
            switch (type)
            {
                case EBFieldType.Between:
                    return new OptionsDateType();
                case EBFieldType.Time:
                    return new OptionsDateType(EBFieldType.Time);
                case EBFieldType.FirstName:
                case EBFieldType.FullName:
                    return new OptionsName(type);
                //case EBFieldType.Email:
                //    break;
                //case EBFieldType.ExampleEmail:
                //    break;
                //case EBFieldType.UserName:
                //    break;
                //case EBFieldType.DomainName:
                //    break;
                case EBFieldType.id:
                default:
                    return new RowNumberOptionsType();
            }
        }

    }
}
