using System.Windows.Forms;

namespace GraphsApp.Views
{
    /// <summary>
    /// Класс менеджера диалоговых окон с методами создания их.
    /// </summary>
    public static class MessageBoxManager
    {
        /// <summary>
        /// Показывает диалоговое окно ошибки.
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <returns>Возвращаемое значение диалога.</returns>
        public static DialogResult ShowError(string text)
        {
            return MessageBox.Show(text, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Показывает диалоговое окно информации.
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <returns>Возвращаемое значение диалога.</returns>
        public static DialogResult ShowInformation(string text)
        {
            return MessageBox.Show(text, "Information!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}