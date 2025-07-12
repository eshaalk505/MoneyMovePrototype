using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMovePrototype
{
    public class FormManagement
    {
        public static void NavigateToNextForm(Form presentForm, Form nextForm)
        {
            presentForm.Hide();
            nextForm.ShowDialog();
            presentForm.Close();
        }

        public static void MoveBackToPreviousForm(Form presentForm, Form previousForm)
        {
            presentForm.Hide();
            previousForm.ShowDialog();
            presentForm.Close();
        }
    }
}
