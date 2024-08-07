using InventoryIT.Areas.Identity;
using InventoryIT.Contracts;
using InventoryIT.Controllers;
using InventoryIT.Data;
using InventoryIT.Model;
using InventoryIT.Utilities;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using PdfSharp.Charting;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var InventoryconnectionString = builder.Configuration.GetConnectionString("Inventory");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContextFactory<InventoryDbContext>(options => options.UseSqlServer(InventoryconnectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
     .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();

// PDF generation
builder.Services.AddScoped<PDFService>();
builder.Services.AddHttpContextAccessor(); // Agregar el IHttpContextAccessor para acceder al contexto HTTP


#region Contracts to CRUD DB
builder.Services.AddScoped<IControllerServices<Brand>, BrandService>();
builder.Services.AddScoped<IControllerServices<ComputerModel>, ComputerService>();
builder.Services.AddScoped<IControllerServices<Employee>, EmployeeService>();
builder.Services.AddScoped<IControllerServices<Departament>, DepartamentService>();
builder.Services.AddScoped<IControllerServices<SmartPhoneModel>, SmartPhoneService>();
builder.Services.AddScoped<IHistoryServices<HistoryModel>, HistoryService>();
builder.Services.AddScoped<IControllerServices<PeripheralModel>, PeripheralService>();
builder.Services.AddScoped<IControllerServices<PhoneExtension>, PhoneExtensionService>();
builder.Services.AddScoped<IControllerServices<PhoneNumber>, PhoneNumbersService>();
builder.Services.AddScoped<IControllerServices<Phone_Number_User_Model>, Phone_Number_UserService>();
builder.Services.AddScoped<FileService>();
builder.Services.AddScoped<ImageService>();
builder.Services.AddTransient<IEmailSender, SmtpEmailSender>();




#endregion
//builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();


#region Create The Database

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<InventoryDbContext>();
    if (db.Database.CanConnect())
    {
        Console.WriteLine("Base de datos existente");
    }
    else
    {
        Console.WriteLine("La base de datos no existe. Intentando crearla");
        try
        {
            db.Database.Migrate();
            Console.WriteLine("Base de datos creada");
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"Error al intentar crear la base de datos: {ex.Message}");
        }
        finally
        {
        }
    }
}

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    if (db.Database.CanConnect())
    {
        Console.WriteLine("Base de datos existente");
    }
    else
    {
        Console.WriteLine("La base de datos no existe. Intentando crearla");
        try
        {
            db.Database.Migrate();
            Console.WriteLine("Base de datos creada");
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"Error al intentar crear la base de datos: {ex.Message}");
        }
        finally
        {
        }
    }
}

#endregion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
