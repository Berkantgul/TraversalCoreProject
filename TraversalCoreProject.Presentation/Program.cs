
using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using SmartBreadcrumbs.Extensions;
using SmartBreadcrumbs.Attributes;
using System.Reflection;
using TraversalCoreProject.Business.Abstract;
using TraversalCoreProject.Business.Concrete;
using TraversalCoreProject.Business.DependencyResolves.Autofac;
using TraversalCoreProject.DataAccess.Abstract;
using TraversalCoreProject.DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);


// add dependecy injection
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBusinessModule()));



// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Default}/{action=Index}/{id?}");


app.Run();
