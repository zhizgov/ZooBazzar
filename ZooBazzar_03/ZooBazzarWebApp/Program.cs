using LogicLayer;
using Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(240);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true; ;
});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
    options =>
    {
        options.LoginPath = "/Login";
        options.AccessDeniedPath = "/Error";
    });

builder.Services.AddTransient<IAccount, AccountManagerDB>();
builder.Services.AddTransient<ICRU<Account>, AccountManagerDB>();
builder.Services.AddTransient<ICRU<Employee>, EmployeeDB>();
builder.Services.AddTransient<ICRU<Ticket>, TicketsDB>();
builder.Services.AddTransient<IAutoIncrementable,TicketsDB>();
builder.Services.AddTransient<IScheduleDB<DailySchedule>, ScheduleDB>();
builder.Services.AddTransient<ICageDB<Cage>, CageDB>();
builder.Services.AddTransient<IContractDataManagement<EmployeeContract>,ContractDB>();
builder.Services.AddTransient<ISubscription, SubscriptionDB>();
builder.Services.AddTransient<ICustomerDB, CustomerDB>();

builder.Services.AddSingleton<EmployeeManagment>();
builder.Services.AddSingleton<TicketManager>();
builder.Services.AddSingleton<AccountManager>();
builder.Services.AddSingleton<ScheduleManager>();
builder.Services.AddSingleton<SubscriptionManager>();
builder.Services.AddSingleton<CustomerManager>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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
app.MapRazorPages();

app.Run();
app.UseSession();
