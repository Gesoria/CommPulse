var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CommPulse>("commpulse");

builder.Build().Run();
