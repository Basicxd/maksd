using System;

using maksd.ViewModels;

using Windows.UI.Xaml.Controls;

namespace maksd.Views
{
    public sealed partial class ForsidePage : Page
    {
        public ForsideViewModel ViewModel { get; } = new ForsideViewModel();

        public ForsidePage()
        {
            InitializeComponent();
        }
    }
}
