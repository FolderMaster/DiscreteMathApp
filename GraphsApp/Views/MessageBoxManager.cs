using System.Windows.Forms;

namespace GraphsApp.Views
{
    public static class MessageBoxManager
    {
        public static DialogResult ShowError(string text)
        {
            return MessageBox.Show(text, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowInformation(string text)
        {
            return MessageBox.Show(text, "Information!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}