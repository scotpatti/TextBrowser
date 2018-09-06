using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TextBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            var url = tbUrl.Text;
            tbWebView.Text += GetResponse(url);
        }

        private string GetResponse(string url)
        {
            string rval = "";
            try
            {
                Request req = new Request(url);
                TcpClient client = new TcpClient();
                client.Connect(req.Hostname, 80);
                NetworkStream stream = client.GetStream();
                stream.WriteString(req.GetRequest());
                rval = stream.ReadString();
                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                rval = ex.Message;
            }
            return rval;
        }
    }
}
