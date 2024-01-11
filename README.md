# Proxy Design Pattern in C#

This repository contains a simple implementation of the Proxy Design Pattern in C#. The Proxy Design Pattern is a structural pattern that provides a surrogate or placeholder for another object to control access to it.

## Contents

- [Introduction](#introduction)
- [Implementation](#implementation)
- [Usage](#usage)

## Introduction

The proxy design pattern involves creating a proxy class that acts as a substitute for another class, known as the Real Object. In this example, we have an interface `IReportGenerator` representing a report generator, a concrete implementation `RealReportGenerator` for the actual report generation, and a proxy implementation `ProxyReportGenerator` that controls access to the real object.

## Implementation

- **`IReportGenerator`**: Defines the interface for report generation.

- **`RealReportGenerator`**: Implements the real report generation logic.

- **`ProxyReportGenerator`**: Acts as a proxy to the real report generator, providing additional control logic before and after the report generation.

## Usage

To use the proxy design pattern with the report generator, you can follow these steps:

1. Create an instance of the `ProxyReportGenerator`.

```csharp
IReportGenerator reportGenerator = new ProxyReportGenerator();
reportGenerator.GenerateReport("Monthly Sales Report");
```

and this is the output:
```
ProxyReportGenerator: Checking access before generating report: Monthly Sales Report.
Generating report: Monthly Sales Report
ProxyReportGenerator: Logging the generation of report: Monthly Sales Report.
```
