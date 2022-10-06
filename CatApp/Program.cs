using CatCore;
using Microsoft.Extensions.DependencyInjection;
//You cannot change this

//1) A cat should have a tail. Use the CatCustomizer service to add a tail
//2) Give the cat a name. Use the CatShelterImpl service to assign a name

IServiceCollection services = new ServiceCollection();
services.AddCatCoreServices();

using(var scope = services.BuildServiceProvider().CreateScope()) {
    Console.WriteLine(scope.ServiceProvider.GetRequiredService<ICatFactory>().CreateCat());
}
