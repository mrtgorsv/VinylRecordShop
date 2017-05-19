using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;
using VinylRecordShop.ViewModels.VinylRecords;

namespace VinylRecordShop.Pages.VinylRecord
{
    /// <summary>
    /// Логика взаимодействия для VinylRecordDetailPage.xaml
    /// </summary>
    public partial class VinylRecordDetailPage : Page
    {
        public VinylRecordDetailPage()
        {
            InitializeComponent();
        }
        public VinylRecordDetailPage(VinylRecordViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
