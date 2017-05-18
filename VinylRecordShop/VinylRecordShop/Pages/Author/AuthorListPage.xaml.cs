﻿using System.Windows.Controls;
using VinylRecordShop.ViewModels.Authors;

namespace VinylRecordShop.Pages.Author
{
    /// <summary>
    /// Логика взаимодействия для AuthorListPage.xaml
    /// </summary>
    public partial class AuthorListPage : Page
    {
        public AuthorListPage()
        {
            InitializeComponent();
        }
        public AuthorListPage(AuthorListViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
