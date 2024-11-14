var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureFunctionsProject<Projects.FunctionApp8_0>("functionapp8-0");

builder.Build().Run();
