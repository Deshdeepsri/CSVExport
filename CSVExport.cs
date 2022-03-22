public class CSVExport
{
    public static void Main(string clientpath)
    {
        string lines = System.IO.File.ReadAllText(clientpath);//Read all text from client file path
        string column_seperator = ";";
        string row_seperator = "|";
        List<string> result = lines.Split(column_seperator).ToList();//Make list of the row data as elements 
        string path = "D:\\CSVExportOutput.txt";//Output file formed by Program
        File.WriteAllText(path, string.Empty);
        foreach(string rows in result)
        {
            string row_data = rows.Replace(row_seperator,",");
            File.AppendAllText(path,row_data);
        }
        return;
    }
}
