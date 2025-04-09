using System;
using System.Windows;
using System.Windows.Media.Imaging;
using WpfUrbexApp.Models;
using WpUrbexfApp;

namespace WpfUrbexApp.Views
{
    public partial class PostDetailsWindow : Window
    {
        public PostDetailsWindow(Post post)
        {
            InitializeComponent();
            LoadPostData(post);
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadPostData(Post post)
        {
            txtTitle.Text = post.Title;
            txtDescription.Text = post.Description;
            txtDate.Text = post.Date.ToString("yyyy-MM-dd");
            txtLocation.Text = post.Location;
            // Konwersja `byte[]` na `BitmapImage`
            if (post.Image != null && post.Image.Length > 0)
            {
                imgPreview.Source = Utility.ByteArrayToBitmapImage(post.Image);
            }
            else
            {
                imgPreview.Source = null; // Jeśli brak obrazu, wyczyść widok
            }
        }
    }
}
