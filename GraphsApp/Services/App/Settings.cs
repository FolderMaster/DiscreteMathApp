namespace GraphsApp.Services.App
{
    public class Settings
    {
        public string SavePath { get; set; } = "Save.txt";

        public Settings()
        {

        }

        public Settings(string savePath)
        {
            SavePath = savePath;
        }
    }
}