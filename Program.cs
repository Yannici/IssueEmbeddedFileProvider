using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();

// Embedded file provider
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new EmbeddedFileProvider(typeof(Program).Assembly)
});

app.MapRazorPages();

app.Run();
