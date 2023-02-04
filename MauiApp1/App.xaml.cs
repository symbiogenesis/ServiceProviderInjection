namespace MauiApp1;

public partial class App : Application
{
    public App(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        this.MainPage = serviceProvider.GetRequiredService<AppShell>();
    }
}
