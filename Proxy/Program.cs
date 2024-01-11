using Proxy;

IReportGenerator reportGenerator = new ProxyReportGenerator();

reportGenerator.GenerateReport("Monthly Sales Report");

Console.WriteLine("* * * *");

reportGenerator.GenerateReport("Yearly Financial Report");