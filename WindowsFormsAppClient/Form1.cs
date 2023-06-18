using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Task task;
        static HttpClient client;
        bool isServerConnected = false;

        private void connectionButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(addressBox.Text))
                UpdateTaskStatus("Введите адрес сервера");
            else
            {
                Uri uri = new Uri($"https://{addressBox.Text}");

                using (TcpClient tcpClient = new TcpClient())
                {
                    try
                    {
                        tcpClient.Connect(uri.Host, uri.Port);

                        client = new HttpClient();
                        client.BaseAddress = uri;

                        UpdateTaskStatus("Соединение установлено");
                        isServerConnected = true;
                    }
                    catch (SocketException)
                    {
                        UpdateTaskStatus("Сервер недоступен");
                        isServerConnected = false;
                    }
                }
            }
        }
        
        private void executionButton_Click(object sender, EventArgs e)
        {
            if (!isServerConnected || client == null)
                UpdateTaskStatus("Подключитесь к серверу");

            else if(String.IsNullOrEmpty(pathBox.Text))
                UpdateTaskStatus("Введите директорию файла");

            else if (!Directory.Exists(pathBox.Text))
                UpdateTaskStatus("Введёт некоректный путь директории");

            else
            {
                Dictionary<string, string> contentDictionary = new Dictionary<string, string>();
                contentDictionary["Path"] = pathBox.Text;
                contentDictionary["Content"] = contentBox.Text;
                string jsonData = JsonConvert.SerializeObject(contentDictionary);

                task = new Task(() => PerformTask(jsonData));
                task.Start();
            }
        }
        async void PerformTask(string fileContent)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsync(client.BaseAddress, new StringContent(fileContent, System.Text.Encoding.UTF8, "application/json"));
                string stringResponse = await response.Content.ReadAsStringAsync();
                UpdateTaskStatus(stringResponse);
            }
            catch (HttpRequestException ex)
            {
                UpdateTaskStatus($"Возникло исключение: {ex.Message}");
            }            
        }

        void UpdateTaskStatus(string status)
        {
            if (statusLabel.InvokeRequired)
            {
                statusLabel.BeginInvoke((MethodInvoker)(() => statusLabel.Text = status));
            }
            else
            {
                statusLabel.Text = status;
            }
        }        
    }
}
