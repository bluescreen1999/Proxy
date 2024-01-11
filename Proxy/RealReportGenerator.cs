namespace Proxy;

// The Real Object
public class RealReportGenerator : IReportGenerator
{
    public void GenerateReport(string reportName)
    {
        // Actual report generation logic goes here
        Console.WriteLine($"Generating report: {reportName}");
    }
}

