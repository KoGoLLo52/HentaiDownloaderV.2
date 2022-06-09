using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HentaiDownloaderV._2
{
    internal class HDownloader
    {
        public HttpClient client = new HttpClient();
        
        string imgurl = "https://";

        public async Task HentaiP(string url, string path)
        {
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.99 Safari/537.36");

            await Task.Run(async () =>
            {
                var doc = new HtmlWeb();
                var FullPage = await doc.LoadFromWebAsync(url);
                var ImagePage1 = await doc.LoadFromWebAsync($"{url}/1/");

                var Image1ForFullSet = ImagePage1.DocumentNode.SelectNodes("/html/body/div[2]/section[3]/a/img");
                var Pages = FullPage.DocumentNode.SelectNodes("/html/body/div[2]/div[1]/div[2]/div/section/div[8]/span/a/span");
                var HTitle = FullPage.DocumentNode.SelectNodes("/html/body/div[2]/div[1]/div[2]/div/h1/span[1]");
                int IntPages = int.Parse(Pages[0].InnerText);

                var DownloadURL = Image1ForFullSet[0].OuterHtml.Split(new char[] { '"' }, StringSplitOptions.RemoveEmptyEntries);

                var FileBytes = await client.GetByteArrayAsync(DownloadURL[1]);
                var NewPath = HTitle[0].InnerText.Trim(new char[] { '[', ']', ' ' });

                if (!Directory.Exists($"{path}\\{NewPath}"))
                {
                    Directory.CreateDirectory($"{path}\\{NewPath}");
                }

                File.WriteAllBytes($"{path}\\{NewPath}\\1.jpg", FileBytes);

                //[1]https://i5.nhentai.net/galleries/907598/1.jpg

                var LoopURL = DownloadURL[1].Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 2; i <= IntPages; i++)
                {
                    imgurl = "https://";
                    int previous = i - 1;
                    LoopURL[LoopURL.Length - 1] = LoopURL[LoopURL.Length - 1].Replace(previous.ToString(), i.ToString());

                    for (int j = 1; j < LoopURL.Length; j++)
                    {
                        imgurl += $"{LoopURL[j]}/";
                    }
                    imgurl = imgurl.Remove(imgurl.Length - 1);
                    var FileBytesLoop = await client.GetByteArrayAsync(imgurl);
                    File.WriteAllBytes($"{path}\\{NewPath}\\Page{i}.jpg", FileBytesLoop);
                }
            });
        }
    }
}
