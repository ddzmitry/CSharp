using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ButtonAsync
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

   

        private async  void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Poop");
            DownloadHtmlAsync("https://www.ganjawars.ru/index.php?frontpage");


            var html =  await GetHtmlAsync("http://msdn.microsoft.com");
                MessageBox.Show(html.Substring(0,50));
        }


        //async version if void return just Task
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();

            // have to call await on async 
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\ddzmi\Desktop\C#\CSharp\ButtonAsync\test.html"))
            {
                    //await on streamwriter
                 await streamWriter.WriteAsync(html);

               
            }
        }


        // NOT ASYNC WITH STRING
        public string GetHtml(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }
        // ASYNC WITH STRING
        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);

        }



        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\ddzmi\Desktop\C#\CSharp\ButtonAsync\test.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
