using System.IO;
using Newtonsoft.Json;

namespace GraphsApp.Services.IO
{
    /// <summary>
    /// Предоставляет методы Json-сериализации и десериализации данных в файл.
    /// </summary>
    public static class JsonManager
    {
        /// <summary>
        /// Настроки Json-сериализатора.
        /// </summary>
        private static readonly JsonSerializerSettings _jsonSerializerSettings =
            new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };

        /// <summary>
        /// Загружает данные из Json-файла.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>Объект данных, хранящийся в файле.</returns>
        public static T Load<T>(string filePath)
        {
            using (FileStream fileReader = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] arrayBytes = new byte[fileReader.Length];
                fileReader.Read(arrayBytes, 0, arrayBytes.Length);
                string text = System.Text.Encoding.Default.GetString(arrayBytes);

                return JsonConvert.DeserializeObject<T>(text, _jsonSerializerSettings);
            }
        }

        /// <summary>
        /// Сохраняет данные в Json-файл.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="data">Данные.</param>
        /// <param name="filePath">Путь к файлу.</param>
        public static void Save<T>(T data, string filePath)
        {
            using (FileStream fileWriter = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                string text = JsonConvert.SerializeObject(data, _jsonSerializerSettings);

                byte[] arrayBytes = System.Text.Encoding.Default.GetBytes(text);
                fileWriter.Write(arrayBytes, 0, arrayBytes.Length);
            }
        }
    }
}