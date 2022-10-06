// See https://aka.ms/new-console-template for more information

using CatApp;
using CatCore;
using CatShelter;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

IServiceCollection services = new ServiceCollection();
services.AddCatCoreServices();
services.AddCatShelterServices();

services.AddScoped<CatCustomizer>();

var s = services.BuildServiceProvider();
using(var scope = s.CreateScope()) {
    var cat = scope.ServiceProvider.GetRequiredService<ICatFactory>().CreateCat();
    Console.WriteLine(cat);
}
