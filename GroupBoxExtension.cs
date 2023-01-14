using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR
{
    public static class GroupBoxExtension
    {
        public static bool Validate(this GroupBox groupBox, TextBox textBoxName, TextBox textBoxSurname, TextBox textBoxJobTitle, TextBox textBoxBirthPlace)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxJobTitle.Text)
                || string.IsNullOrEmpty(textBoxSurname.Text) || string.IsNullOrEmpty(textBoxBirthPlace.Text))
                return false;

            if (textBoxName.Text.Length > DBWorker.TextSize || textBoxSurname.Text.Length > DBWorker.TextSize || textBoxJobTitle.Text.Length > DBWorker.TextSize
                || textBoxBirthPlace.Text.Length > DBWorker.TextSize)
                return false;

            return true;
        }
    }
}
