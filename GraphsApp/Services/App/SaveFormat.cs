namespace GraphsApp.Services.App
{
    public class SaveFormat
    {
        public int[,] Graph { get; set; } = new int[0, 0];

        public SaveFormat()
        {
        }

        public SaveFormat(int[,] graph)
        {
            Graph = graph;
        }
    }
}