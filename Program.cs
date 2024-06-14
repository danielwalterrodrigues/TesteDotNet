var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao container.
builder.Services.AddControllers();

var app = builder.Build();

// Configura o pipeline de solicitação HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
