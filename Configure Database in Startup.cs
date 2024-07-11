public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<InvestmentContext>(options =>
        options.UseInMemoryDatabase("InvestmentsDB"));
    services.AddControllers();
}
