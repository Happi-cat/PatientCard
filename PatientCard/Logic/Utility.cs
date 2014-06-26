using System.Windows.Forms;

namespace PatientCard.Logic
{
    public class Utility
    {
        public static void LockTextBoxes(Form form)
        {
            foreach (var control in form.Controls)
            {
                if (control is Panel)
                {
                    LockTextBoxes(control as Panel);
                    continue;
                }
                LockControlForEdit(control as Control);
            }
        }

        private static void LockTextBoxes(Panel panel)
        {
            foreach (var control in panel.Controls)
            {
                if (control is Panel)
                {
                    LockTextBoxes(control as Panel);
                    continue;
                }
                LockControlForEdit(control as Control);
            }
        }

        private static void LockControlForEdit(Control control)
        {
            if (control == null)
            {
                return;
            }
            if (control is TextBox)
            {
                ((TextBox) control).ReadOnly = true;
            }
            if (control is RadioButton || control is DateTimePicker)
            {
                control.Enabled = false;
            }
        }
    }
}