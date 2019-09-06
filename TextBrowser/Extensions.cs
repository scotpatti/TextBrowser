using System;
using System.Net.Sockets;
using System.Text;

namespace TextBrowser
{
    public static class Extensions
    {
        public static bool WriteString(this NetworkStream stream, string data)
        {
            bool rval = true;
            try
            {
                byte[] buffer = ASCIIEncoding.ASCII.GetBytes(data);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
            catch (Exception)
            {
                rval = false;
            }
            return rval;
        }

        public static string ReadString(this NetworkStream stream)
        {
            StringBuilder sb = new StringBuilder();
            byte[] buffer = new byte[65536];
            stream.ReadTimeout = 15000;
            try
            {
                do
                {
                    stream.Read(buffer, 0, buffer.Length);
                    sb.Append(ASCIIEncoding.ASCII.GetString(buffer));
                } while (stream.DataAvailable);
            }
            catch (Exception)
            {
                throw new Exception("Connection Timed out!");
            }
            return sb.ToString();
        }
    }
}
