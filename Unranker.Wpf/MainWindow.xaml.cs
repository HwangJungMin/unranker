namespace Unranker.Wpf;

public partial class MainWindow : System.Windows.Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnConfirmClick(object sender, System.Windows.RoutedEventArgs e)
    {
        System.Windows.MessageBox.Show("WPF 앱이 정상적으로 실행 중입니다.", "Unranker", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
    }
}
