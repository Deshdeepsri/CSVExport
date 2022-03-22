using Xunit;
public class CSVExportTest{
    [Fact]
    public void Test1(){
        //Arrange
        //List<string> testlist = new List<string>(){"Abhishek Singh,18404,Wisteli", "Abhinav Singh,18401,M.Tech", "Devansh Mishra,18422,TCS"};
        string clientpath = "D:\\ClientFile.txt";

        //Act
        CSVExport.Main(clientpath);
        string path = "D:\\CSVExportOutput.txt";        

        //Assert
        Assert.Equal(File.ReadAllLines("D:\\TestFile.csv"), File.ReadAllLines(path));

    }
}
