using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Homework10
{
    class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;

        public Action<string> statusChange; 

        public string Status { get; set; }
        public string ExMessage { get; set; }
        public bool OnlyCurrent { get; set; }
        public List<Url> Urls { get; set; }

        public SimpleCrawler()
        {
            statusChange += StatusChange;
            Urls = new List<Url>();
            OnlyCurrent = true;
            ThreadPool.SetMaxThreads(3, 3);
        }

        public void PrepareCrawl(string startUrl)
        {
            this.urls.Add(startUrl, false);
            new Thread(this.Crawl).Start();
        }

        private void Crawl()
        {
            statusChange("开始爬行了....");
            while (true)
            {
                ExMessage = "";

                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                statusChange("爬行" + current + "页面!");

                Task<string> task = Task.Run(() => DownLoad(current)); // 下载界面
                urls[current] = true;
                count++;

                Task.WaitAll(task);
                if (!OnlyCurrent) Parse(task.Result);//解析,并加入新的链接

                if (ExMessage != "")
                {
                    Urls.Add(new Url(current, ExMessage));
                }
                else
                {
                    Urls.Add(new Url(current, "成功"));
                }
                statusChange("爬行结束");   
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;

                string html = webClient.DownloadString(url);

                string fileName = count.ToString();

                File.WriteAllText(fileName, html, Encoding.UTF8);
                StatusChange("下载完成！");
                return html;
            }
            catch (Exception ex)
            {
                ExMessage = ex.Message;
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        private void StatusChange(string str)
        {
            Status = str;
        }
    }
}
