using System;

using maksd.ViewModels;

using Windows.UI.Xaml.Controls;

namespace maksd.Views
{
    public sealed partial class FilmPage : Page
    {
        public FilmViewModel ViewModel { get; } = new FilmViewModel();

        public FilmPage()
        {
            InitializeComponent();
        }
    }
}
