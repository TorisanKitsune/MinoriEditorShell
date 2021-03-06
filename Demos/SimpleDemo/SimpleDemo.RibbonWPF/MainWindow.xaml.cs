using MinoriEditorShell.Services;
using MvvmCross;

namespace SimpleDemo.RibbonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Mvx.IoCProvider.Resolve<IMesThemeManager>().SetCurrentTheme("Blue");
        }
    }
}