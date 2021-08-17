using System.Windows;
using Minimal.Controls;

namespace Minimal
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TestControl.initWithControl(MyControl, "Test Param");
        }
    }
}
