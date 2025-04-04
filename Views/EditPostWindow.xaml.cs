using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using WpfUrbexApp;
using WpfUrbexApp.Models;
using WpfUrbexApp.Repositories;
using System.IO;
using WpUrbexfApp;

namespace WpfUrbexApp.Views
{
    public partial class EditPostWindow : Window
    {
        private Post _post;
        private PostRepository _postRepository = new PostRepository();

        public EditPostWindow(Post post)
        {
            InitializeComponent();
            _post = post;
            LoadPostData();
        }

        private void LoadPostData()
        {
            txtTitle.Text = _post.Title;
            txtDescription.Text = _post.Description;
            dpDate.SelectedDate = _post.Date;
            txtLocation.Text = _post.Location;

            if (_post.Image != null && _post.Image.Length > 0)
            {
                imgPreview.Source = Utility.ByteArrayToBitmapImage(_post.Image);
            }
            else
            {
                imgPreview.Source = null; // Jeśli brak obrazu, ustaw na pusty
            }
        }


        private void btnChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == true)
            {
                // Konwersja obrazu do byte[]
                _post.Image = File.ReadAllBytes(openFileDialog.FileName);

                // Konwersja byte[] na BitmapImage do wyświetlenia w imgPreview
                imgPreview.Source = Utility.ByteArrayToBitmapImage(_post.Image);

            }
        }


        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _post.Title = txtTitle.Text;
            _post.Description = txtDescription.Text;
            _post.Date = dpDate.SelectedDate ?? DateTime.Now;
            _post.Location = txtLocation.Text;

            bool isUpdated = _postRepository.UpdatePost(_post);
            if (isUpdated)
            {
                MessageBox.Show("Post został zaktualizowany.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nie udało się zaktualizować posta.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
