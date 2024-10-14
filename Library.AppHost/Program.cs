var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Library_ApiService>("apiservice");

builder.AddProject<Projects.Library_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
