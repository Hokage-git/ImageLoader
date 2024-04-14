using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Net.Http;

namespace ImageLoader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient _client = new HttpClient();
        private CancellationTokenSource _cts;
        private int _totalImages = 3;
        private int _imagesLoaded = 0;

        public MainWindow()
        {
            InitializeComponent();
            TotalProgressBar.Maximum = _totalImages;
        }

        private async Task<BitmapImage> LoadImageAsync(string url, CancellationToken cancellationToken)
        {
            var response = await _client.GetAsync(url, cancellationToken);
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
            var image = new BitmapImage();

            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();

            return image;
        }

        private void UrlStr_GotFocus(object sender, RoutedEventArgs e)
        {
            var UrlStr = (TextBox)sender;
            if (UrlStr.Text == "Url...")
            {
                UrlStr.Text = "";
                Brush b = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                UrlStr.Foreground = b;
            }
        }

        private void UrlStr_LostFocus(object sender, RoutedEventArgs e)
        {
             var UrlStr = (TextBox)sender;
            if (UrlStr.Text == "")
            {
                UrlStr.Text = "Url...";
                Brush b = new SolidColorBrush(Color.FromRgb(128, 128, 128));
                UrlStr.Foreground = b;
            }
        }

        private async void StartLoadImg_Click(object sender, RoutedEventArgs e)
        {
            _cts = new CancellationTokenSource();

            var button = (Button)sender;
            var textBox = (TextBox)this.FindName(button.Name.Replace("StartLoadImg", "UrlStr"));
            var imageViewer = (Image)this.FindName(button.Name.Replace("StartLoadImg", "Image"));

            try
            {
                var url = textBox.Text;
                var image = await LoadImageAsync(url, _cts.Token);
                if(imageViewer.Source == null)
                    _imagesLoaded++;
                TotalProgressBar.Value = _imagesLoaded;
                imageViewer.Source = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
            }
        }

        private void StopLoadImg_Click(object sender, RoutedEventArgs e)
        {
            _cts?.Cancel();
        }

        private async void LoadAllButton_Click(object sender, RoutedEventArgs e)
        {
            _cts = new CancellationTokenSource();

            try
            {
                var tasks = new List<Task>
                {
                    StartLoadingAsync("UrlStr1", "Image1"),
                    StartLoadingAsync("UrlStr2", "Image2"),
                    StartLoadingAsync("UrlStr3", "Image3")
                };

                await Task.WhenAll(tasks);
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Загрузка изображений была отменена");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображений: {ex.Message}");
            }
        }

        private async Task StartLoadingAsync(string textBoxName, string imageViewerName)
        {
            var textBox = (TextBox)this.FindName(textBoxName);
            var imageViewer = (Image)this.FindName(imageViewerName);

            var url = textBox.Text;
            var image = await LoadImageAsync(url, _cts.Token);
            imageViewer.Source = image;
            _imagesLoaded++;
            TotalProgressBar.Value = _imagesLoaded;
        }
    }
}