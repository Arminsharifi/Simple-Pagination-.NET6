using Microsoft.EntityFrameworkCore;
using Simple_Pagination_Dotnet.Context;
using Simple_Pagination_Dotnet.Interfaces;
using Simple_Pagination_Dotnet.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProductContext>(x => x.UseSqlite("Data Source = " + AppDomain.CurrentDomain.BaseDirectory + "Products.db" + ";"));
builder.Services.AddScoped<IProductRepository,ProductRepository>();
builder.Services.AddControllersWithViews();
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ProductContext>();
    await dbContext.Database.EnsureCreatedAsync();
}
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();