using System;

using maksd.ViewModels;

using Windows.UI.Xaml.Controls;

namespace maksd.Views
{
    public sealed partial class KommendefilmPage : Page
    {
        public KommendefilmViewModel ViewModel { get; } = new KommendefilmViewModel();

        public KommendefilmPage()
        {
            InitializeComponent();
        }
    }
}
