using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string MenuName = "Folder\\shell\\NewMenuOption";
        private const string Command = "Folder\\shell\\NewMenuOption\\command";

        protected override void OnStartup(StartupEventArgs e)
        {

            foreach (string arg in e.Args)
            {

                //var client = new HttpClient();
                //FileStream file = new FileStream(arg, FileMode.Open);
                ////StreamContent fileContent = new StreamContent(file);

                //string formDataBoundary = String.Format("----------{0:N}", Guid.NewGuid());
                //string contentType = "multipart/form-data; boundary=" + formDataBoundary;

                //string fileName = Path.GetFileName(arg);


                //HttpRequestMessage message = new HttpRequestMessage();
                //MultipartFormDataContent content = new MultipartFormDataContent();
                //content.Add(new StreamContent(file),"foo",fileName);

                //message.Method = HttpMethod.Post;
                //message.Content = content;
                ////message.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("multipart/form-data");
                ////message.Content.Headers.ContentType.MediaType = "multipart/form-data";
                ////message.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("file");
                ////message.Content.Headers.ContentDisposition.Name = "\r\n-- strathweb --\r\n";
                //message.RequestUri = new Uri("http://localhost:51884/api/uploading/");
                //client.SendAsync(message);  

            }

            base.OnStartup(e);

        }
    }
}
