using Accounting.DataLayer.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddAuthorization();
builder.Services.AddAuthentication();
builder.Services.AddMvc();
builder.Services.AddDbContext<AccountingContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("AccountingConnection"));
    var app = builder.Build();
});



app.MapGet("/", () => "Hello World!");

app.Run();
