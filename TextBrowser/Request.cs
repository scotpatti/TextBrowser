using System;

namespace TextBrowser
{
    class Request
    {
        public string Hostname { get; set; }
        public string Path { get; set; }

        public Request()
        {
            throw new NotImplementedException();
        }

        public Request(string url)
        {
            string[] parts = url.Split(new string[] { "//" },
                StringSplitOptions.RemoveEmptyEntries);
            int pathIndex = parts[1].IndexOf('/');
            if (pathIndex <1)
            {
                Hostname = parts[1];
                Path = "/";
            }
            else
            {
                Hostname = parts[1].Substring(0, pathIndex);
                Path = parts[1].Substring(pathIndex);
            }
        }

        public string GetRequest()
        {
            return "GET " + Path + " HTTP/1.1\r\n" +
                "Hostname=" + Hostname + "\r\n\r\n";
        }
    }
}
