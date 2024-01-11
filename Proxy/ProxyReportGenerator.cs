namespace Proxy;

// The Proxy
internal class ProxyReportGenerator : IReportGenerator
{
    private RealReportGenerator _realReportGenerator;

    public void GenerateReport(string reportName)
    {
        // Lazy initialization: Create the RealReportGenerator only when it's actually needed
        if (_realReportGenerator == null)
        {
            _realReportGenerator = new RealReportGenerator();
        }

        // Additional control logic can be added here before generating the report
        Console.WriteLine($"ProxyReportGenerator: Checking access before generating report: {reportName}.");

        // Forward the report generation request to the RealReportGenerator
        _realReportGenerator.GenerateReport(reportName);

        // Additional control logic can be added here after generating the report
        Console.WriteLine($"ProxyReportGenerator: Logging the generation of report: {reportName}.");
    }
}
