using WindowsService;

IHost host = Host.CreateDefaultBuilder(args)
    //Uygulama windows hizmeti olarak çalışacak şekilde yapılandırıldı.
    .UseWindowsService(options =>
    {
        options.ServiceName = ".NET Message Service";
    })
    .ConfigureServices(services =>
    {
        services.AddSingleton<IModel, Model>();
        services.AddSingleton<IMessageService, MessageService>();
        services.AddHostedService<WindowsBackgroundService>();
        //services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
