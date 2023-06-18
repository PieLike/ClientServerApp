using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

var serverTask = new Task(() => StartServer());
serverTask.Start();

while (Console.ReadLine() != "exit");

void StartServer()
{
    var builder = WebApplication.CreateBuilder();
    var app = builder.Build();

    app.MapPost("/", async (HttpContext httpContext) =>
    {
        using StreamReader reader = new StreamReader(httpContext.Request.Body);
        string data = await reader.ReadToEndAsync();

        //string[] pathAndContent = data.Split('/', StringSplitOptions.RemoveEmptyEntries);
        //string path = pathAndContent[0];
        //string fileContent = pathAndContent.Length > 1 ? pathAndContent[1] : "";

        var contentData = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
        if (contentData == null)
        {
            Console.WriteLine("��������� ������ ��������� ������ ��������, ������ ���������� � ���������� ����� �����������");
            return "��������� ������ ��������� ������ ��������, ������ ���������� � ���������� ����� �����������";
        }

        string path = contentData["Path"];
        string fileContent = contentData["Content"];

        bool executionSucces = WriteContentInFile(path, fileContent);

        if (executionSucces == true)
        {
            Console.WriteLine("���� ������� �������");
            return "���� ������� �������";
        }
        else
        {
            Console.WriteLine("��������� ������, ���� �� ��� �������");
            return "��������� ������ ������ �����, ���� �� ��� �������";
        }
    });
    app.Run();
}

bool WriteContentInFile(string path,  string content)
{
    try
    {
        FileStream stream = File.Create(Path.Combine(path, "NewFile.txt"));

        using StreamWriter writer = new StreamWriter(stream);
        {
            writer.WriteLine(content);
        }
        return true;
    }
    catch 
    {
        return false;
    }
}
