using Contacts.Application;
using Contacts.Constants;
using Contacts.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistenceService(builder.Configuration);
builder.Services.AddApplicationService(builder.Configuration);
builder.Services.Configure<ContactSettings>(builder.Configuration.GetSection("Options"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

