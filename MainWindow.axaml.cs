using Avalonia.Controls;
using System.Threading;
using System.Threading.Tasks;
namespace desktop_bg;

public partial class MainWindow : Window
{
    public MainWindow()
    {
         ImageGenerator.GenerateImage().Wait();
        InitializeComponent();
    }
}