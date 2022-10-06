using CatCore;
using Microsoft.Extensions.DependencyInjection;
//You cannot change this
IServiceCollection services = new ServiceCollection();
services.AddCatCoreServices();

using(var scope = services.BuildServiceProvider().CreateScope()) {
    Console.WriteLine(scope.ServiceProvider.GetRequiredService<ICatFactory>().CreateCat());
}
