using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aifrus.SimGPS2;
using Newtonsoft.Json;

public class HttpServer
{
    private HttpListener _listener;
    private readonly string _url;
    private Func<SimConnectClient.Struct1> _dataProvider;

    public HttpServer(string url, Func<SimConnectClient.Struct1> dataProvider)
    {
        if (!HttpListener.IsSupported)
            throw new NotSupportedException("Needs Windows XP SP2, Server 2003 or later.");

        _url = url;
        _dataProvider = dataProvider;
    }

    public async Task StartServer()
    {
        _listener = new HttpListener();
        _listener.Prefixes.Add(_url);
        _listener.Start();
        while (true)
        {
            try
            {
                var context = await _listener.GetContextAsync();
                await ProcessRequestAsync(context);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


    private async Task ProcessRequestAsync(HttpListenerContext context)
    {
        var data = _dataProvider();
        var json = JsonConvert.SerializeObject(data);
        var buffer = Encoding.UTF8.GetBytes(json);
        var response = context.Response;
        response.ContentType = "application/json";
        response.ContentLength64 = buffer.Length;
        response.OutputStream.Write(buffer, 0, buffer.Length);
        response.OutputStream.Close();
    }

    public void Stop()
    {
        try
        {
            _listener.Stop();
            _listener.Close();
            _listener = null;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
