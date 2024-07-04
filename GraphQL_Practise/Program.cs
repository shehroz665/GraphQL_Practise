using GraphQL_Practise.Models;
using GraphQL_Practise.Query;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGraphQLServer()
    .AddQueryType<QueryType>()
    .AddProjections()
    .AddSorting()
    .AddFiltering();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    string str = "Server=.\\SQLEXPRESS;Database=GraphQL;Trusted_Connection=True;TrustServerCertificate=True;";
    options.UseSqlServer(str);
    // options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL("/graphql");


app.Run();
