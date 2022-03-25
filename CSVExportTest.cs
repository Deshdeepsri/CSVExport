using Xunit;
public class CSVExportTest{
    [Fact]
    public void Test1(){
        //Arrange
        string clientpath = "D:\\ClientFile.txt";
        string row_seperator = "|";
        string column_seperator = ";";
        string csv_seperator = ",";

        //Act
        CSVExport.Main(clientpath,column_seperator, row_seperator,csv_seperator);
        string path = "D:\\CSVExportOutput.txt";        

        //Assert
        Assert.Equal(File.ReadAllLines("D:\\TestFile.csv"), File.ReadAllLines(path));

    }
}
