using api_for_kursach.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
//��������� ������ 14:28
=======
//������� ���������� ������
>>>>>>> 404eac4ffdc6985037cd80d15f04a81505ecf4cf

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddControllers();
builder.Services.AddDbContext<AppliContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
    options =>
    {
        options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
        options.SlidingExpiration = true; // ���������� ������� ����� ��� ������ �������
        
        options.Cookie.Name = "AuthCookie";

    });
var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.Run();
