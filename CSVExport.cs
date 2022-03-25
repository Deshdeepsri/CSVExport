public class CSVExport
{
    public static void Main(string clientpath, string column_seperator,string row_seperator, string csv_seperator)
    {
        string lines = System.IO.File.ReadAllText(clientpath);//Read all text from client file path
        
        List<string> results = lines.Split(column_seperator).ToList();//Make list of the row data as elements 
        string path = "D:\\CSVExportOutput.txt";//Output file formed by Program
        File.WriteAllText(path, string.Empty);

        foreach(string var in results)
        {
            string row_data = var.Replace(row_seperator,csv_seperator);
            File.AppendAllText(path, row_data);
        }        
        return;
    }
}