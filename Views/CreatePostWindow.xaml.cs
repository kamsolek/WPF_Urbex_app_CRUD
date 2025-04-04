using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using WpfUrbexApp.Models;
using WpfUrbexApp.Repositories;
using System.IO;


namespace WpfUrbexApp.Views
{
    /// <summary>
    /// Logika interakcji dla klasy CreatePostWindow.xaml
    /// </summary>
    public partial class CreatePostWindow : Window
    {
        private string selectedImagePath = "";
        private readonly PostRepository _postRepository = new PostRepository();
        public CreatePostWindow()
        {
            InitializeComponent();
        }
        private void btnChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                selectedImagePath = openFileDialog.FileName;
                imgPreview.Source = new BitmapImage(new Uri(selectedImagePath));
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            DateTime date = dpDate.SelectedDate ?? DateTime.Now;
            string location = txtLocation.Text;
            byte[] imageBytes = null;

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                imageBytes = File.ReadAllBytes(selectedImagePath);
            }

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(location) && imageBytes != null)
            {
                Post newPost = new Post(title, description, date, location, imageBytes);
                if (_postRepository.CreatePost(newPost))
                {
                    MessageBox.Show("Post został dodany!", "Sukces", MessageBoxButton.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd przy dodawaniu posta.", "Błąd", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButton.OK);
            }
        }


        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
