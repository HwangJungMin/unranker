namespace Unranker.Wpf;

public partial class MainWindow : System.Windows.Window
{
    public string Mode { get; } = "AUTO";

    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
    }
}
