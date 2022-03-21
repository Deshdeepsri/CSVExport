using Xunit;
public class CSVExportTest{
    [Fact]
    public void Test1(){
        //Arrange
        List<string> testlist = new List<string>(){"Abhishek Singh,18404,Wisteli", "Abhinav Singh,18401,M.Tech", "Devansh Mishra,18422,TCS"};

        //Act
        CSVExport.Main(testlist);
        string path = "D:\\CSVExportOutput";        

        //Assert
        Assert.Equal(File.ReadAllLines(path), File.ReadAllLines("D:\\testit.csv"));

    }
}