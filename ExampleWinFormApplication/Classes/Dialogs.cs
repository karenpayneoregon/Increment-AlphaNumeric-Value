using System.Windows.Forms;

namespace ExampleWinFormApplication.Classes
{
    public static class Dialogs
    {
        public static bool Question(string Text)
        {
            return (MessageBox.Show(Text, "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
    }
}
