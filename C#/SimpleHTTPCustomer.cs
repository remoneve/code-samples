using System.Net.Sockets;
using System.Text;

public class SimpleHTTPCustomer
{
    public static void Main()
    {
        System.Console.WriteLine();
        string url = "www.example.com";
        System.Console.WriteLine("-----------------------------------------------------------------");
        Console.Write(getHTMLPage(url));
        System.Console.WriteLine("-----------------------------------------------------------------");

        System.Console.WriteLine();
        string url2 = "http://example.org";
        System.Console.WriteLine("-----------------------------------------------------------------");
        Console.Write(getHTMLPage(url2));
        System.Console.WriteLine("-----------------------------------------------------------------");
    }

    /// <summary>
    /// Method gets and returns a HTML page as a string.
    /// </summary>
    /// <param name="url">URL for a page.</param>
    /// <returns>HTML page as a string</returns>
    public static string getHTMLPage(string url)
    {
        string server;
        string resource;
        if (url.StartsWith("https")) return "URL error";

        if (url.StartsWith("http://"))
        {
            StringBuilder sb = new StringBuilder(url);
            sb.Remove(0, 7);
            server = sb.ToString();
            if (server.Contains("/"))
            {
                resource = server.Substring(server.IndexOf('/'));
                server = server.Substring(0, server.Length - resource.Length);
            }
            else resource = "/";
        }
        else
        {
            server = url;
            if (server.Contains("/"))
            {
                resource = server.Substring(server.IndexOf('/'));
                server = server.Substring(0, server.Length - resource.Length);
            }
            else resource = "/";
        }

        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        s.Connect(server, 80);
        byte[] message = Encoding.UTF8.GetBytes("GET " + resource + " HTTP/1.1\r\nHost: " + server + "\r\n\r\n Connection: close\r\n\r\n");
        s.Send(message, 0, message.Length, SocketFlags.None);

        byte[] rec = new byte[2048];
        int bytesReceived = s.Receive(rec);

        string wholePage = System.Text.Encoding.ASCII.GetString(rec, 0, bytesReceived);
        string htmlPage = wholePage.Substring(wholePage.IndexOf('<'));

        return htmlPage;
    }
}

