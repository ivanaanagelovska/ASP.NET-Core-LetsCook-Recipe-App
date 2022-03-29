namespace LetsCook.Infrastructure
{
    using Data;
    public static class DbInitializer
    {
        public static IApplicationBuilder Initialize(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var dbContext = scopedServices.ServiceProvider.GetService<LetsCookDbContext>();

            dbContext.Database.EnsureCreated();

            return app;
        }
    }
}
