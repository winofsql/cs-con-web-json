using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace cs_0501_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string json_url = "https://lightbox.sakura.ne.jp/demo/template/basic/basic-html/project/basic-01.json";
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.GetEncoding("utf-8");
            string json_text = webClient.DownloadString(json_url);

            Console.WriteLine(json_text);

            // JSON 文字列を一括でクラスのオブシェクトに変換
            MyJson data = JsonConvert.DeserializeObject<MyJson>(json_text);

            Console.WriteLine(data.title);
            Console.WriteLine(data.name);
            Console.WriteLine(data.image);
            Console.WriteLine(data.text);

            Console.ReadLine();
        }

        // ******************************************
        // 一括変換用のクラス
        // ******************************************
        private class MyJson
        {
            public string title { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string text { get; set; }
        }
    }
}
