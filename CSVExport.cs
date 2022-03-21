public class CSVExport
{
    // public void Final(List<string> final)
    // {
    //     List<string> start = new List<string>();
    //     start.AddRange(final);
    //     string path = "D:\\CSVExportOutput";
    //     File.WriteAllText(path, string.Empty);
    //     foreach(string var in start)
    //     {
    //         File.AppendAllText(path,var+"\r\n");
    //     }
    //     return;
    // }
    public static void Main(List<string> final)
    {
        List<string> start = new List<string>();
        start.AddRange(final);
        string path = "D:\\CSVExportOutput";
        File.WriteAllText(path, string.Empty);
        foreach(string var in start)
        {
            File.AppendAllText(path,var+"\r\n");
        }
        return;
    }
}
