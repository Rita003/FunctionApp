var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureFunctionsProject<Projects.FunctionApp9_0>("functionapp9-0");

builder.Build().Run();
