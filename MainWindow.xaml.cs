using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfUrbexApp.Models;
using WpfUrbexApp.Views;
using WpfUrbexApp.Repositories;
using System.Collections.Generic;
using System.IO;

namespace WpfUrbexApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PostRepository _postRepository = new PostRepository();
        private List<Post> _posts = new List<Post>();
        public MainWindow()
        {
            InitializeComponent();
            LoadPosts();
        }
        private void LoadPosts()
        {
            _posts = _postRepository.GetAllPosts();
            lvPosts.ItemsSource = null; // Wyczyść dane
            lvPosts.ItemsSource = _posts; // Załaduj ponownie
        }

        

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreatePostWindow createWindow = new CreatePostWindow();
            createWindow.ShowDialog();
            LoadPosts();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (lvPosts.SelectedItem is Post selectedPost)
            {
                EditPostWindow editWindow = new EditPostWindow(selectedPost);
                editWindow.ShowDialog();
                LoadPosts();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lvPosts.SelectedItem is Post selectedPost)
            {
                MessageBox.Show($"Usuwanie posta o ID: {selectedPost.Id}", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);

                MessageBoxResult result = MessageBox.Show("Czy na pewno chcesz usunąć ten post?", "Usuń post", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        bool isDeleted = _postRepository.DeletePost(selectedPost.Id);
                        if (isDeleted)
                        {
                            MessageBox.Show($"Post o ID: {selectedPost.Id} został usunięty.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Nie udało się usunąć posta o ID: {selectedPost.Id}.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        LoadPosts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas usuwania posta o ID: {selectedPost.Id}. Szczegóły: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego posta do usunięcia.", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void lvPosts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvPosts.SelectedItem != null)
            {
                btnEdit.IsEnabled = true;
                btnDelete.IsEnabled = true;
            }
            else
            {
                btnEdit.IsEnabled = false;
                btnDelete.IsEnabled = false;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void lvPosts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lvPosts.SelectedItem is Post selectedPost)
            {
                PostDetailsWindow detailsWindow = new PostDetailsWindow(selectedPost);
                detailsWindow.ShowDialog();
            }
        }
    }
}