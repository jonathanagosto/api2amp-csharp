using Newtonsoft.Json;
using Nustache.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Api2Amp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var posts = GetApiResponse();

                foreach (var post in posts)
                {
                    Console.Write($"Exporting Post ID: {post.id} --- ");
                    var html = Render.FileToString(@"Templates\AMP\article.html", post);
                    writeFile($@"files\{post.id}.html", html);
                    Console.WriteLine("Done!");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<RootObject> GetApiResponse()
        {
            try
            {
                var response = new List<RootObject>();
                string requestUrl = "http://jsonplaceholder.typicode.com/posts";
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                using (HttpWebResponse res = request.GetResponse() as HttpWebResponse)
                {
                    if (res.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format(
                        "Server error (HTTP {0}: {1}).",
                        res.StatusCode,
                        res.StatusDescription));

                    Stream rebut = res.GetResponseStream();
                    StreamReader readStream = new StreamReader(rebut, Encoding.UTF8); // Pipes the stream to a higher level stream reader with the required encoding format.
                    var info = readStream.ReadToEnd();

                    response = JsonConvert.DeserializeObject<List<RootObject>>(info);
                    res.Close();
                    readStream.Close();
                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void writeFile(string filePathName, string content)
        {
            StreamWriter mapFile = new StreamWriter(filePathName);
            mapFile.WriteLine(content);
            mapFile.Close();
        }
    }
}