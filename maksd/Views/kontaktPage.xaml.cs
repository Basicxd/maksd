using System;

using maksd.ViewModels;

using Windows.UI.Xaml.Controls;

namespace maksd.Views
{
    public sealed partial class kontaktPage : Page
    {
        public kontaktViewModel ViewModel { get; } = new kontaktViewModel();

        public kontaktPage()
        {
            InitializeComponent();
        }
    }
}
