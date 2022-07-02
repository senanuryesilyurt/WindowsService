

namespace WindowsService
{
    public class WindowsBackgroundService : BackgroundService
    {
        private readonly IMessageService _messageService;
        private readonly ILogger<WindowsBackgroundService> _logger;

        public WindowsBackgroundService(IMessageService messageService, ILogger<WindowsBackgroundService> logger)
        {
            _messageService = messageService;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation(_messageService.GetMessage());
                _logger.LogInformation(Constans.logInformationForMessage, DateTime.Now);
                await Task.Delay(2000);
            }
        }
    }
}
