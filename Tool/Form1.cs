using HtmlAgilityPack;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtUrl.Text = "https://www.2mcnm.com/html/book/1/1398/";
            this.toolStripStatusLabel1.Text = "";
            this.toolStripProgressBar1.Visible = false;
        }

        private string GethtmlContent(string url)
        {
            Thread.Sleep(1000);
            var htmlContent = "";
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;//解决 未能创建 SSL/TLS 安全通道 的问题。

            WebRequest req = WebRequest.Create(url);//向指定Url发出请求 
            HttpWebResponse response = req.GetResponse() as HttpWebResponse;//将hwr对HTTP的请求 
            string code = response.ContentEncoding;//请求响应得到的内容类型

            if (code == "gzip")
            {
                using (GZipStream stream = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress))
                {
                    using (StreamReader reader = new StreamReader(stream, Encoding.Default))
                    {
                        htmlContent = reader.ReadToEnd();
                    }
                }
            }
            else
            {
                Stream stream = response.GetResponseStream();
                using (StreamReader reader = new StreamReader(stream, Encoding.Default))
                {
                    htmlContent = reader.ReadToEnd();
                }
            }
            return htmlContent;
        }

        private void btnJiexi_Click(object sender, EventArgs e)
        {

            var TitleList = GetHtmlNodes(txtUrl.Text, "//div[@class='listmain']/dl/dd/a");

            DataTable dt = new DataTable();
            int i = 1;
            dt.Columns.Add("index");
            dt.Columns.Add("Title");
            dt.Columns.Add("Link");

            foreach (var title in TitleList)
            {
                DataRow dr = dt.NewRow();
                dr["index"] = i;
                dr["Title"] = title.InnerText;
                dr["Link"] = "https://www.2mcnm.com" + title.Attributes[0].Value;
                dt.Rows.Add(dr);
                i++;
            }
            dataGridView1.DataSource = dt;
        }

        private void 下载选中章节DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            RunAsync(() =>
            {
                this.toolStripProgressBar1.Visible = true;
                string SelectUrl = "";
                string Title = "";
                string HtmlContent = "";
                string saveName = dataGridView1.SelectedRows[dataGridView1.SelectedRows.Count - 1].Cells[1].Value.ToString() + "~" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + ".doc";
                int x = 0;
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    Title = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                    RunInMainthread(() =>
                    {
                        toolStripProgressBar1.Value = (int)(Math.Round((x + 1) / (double)dataGridView1.SelectedRows.Count, 2) * 100);
                        toolStripStatusLabel1.Text = "正在下载：" + Title;
                    });

                    SelectUrl = dataGridView1.SelectedRows[i].Cells[2].Value.ToString();
                    var html1 = this.GethtmlContent(SelectUrl);

                    var htmlDocument = new HtmlAgilityPack.HtmlDocument();
                    htmlDocument.LoadHtml(html1);
                    var html = htmlDocument.DocumentNode;
                    var tit = "<h2>" + Title + "</h2>";
                    var Content = tit + html.SelectNodes("//div[@id='content']")[0].InnerHtml;
                    HtmlContent += Content;
                    x++;
                }
                toolStripStatusLabel1.Text = "正在保存...";
                HtmlToWord(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "tmp.doc", System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + saveName, HtmlContent);
                toolStripStatusLabel1.Text = "下载完成。";
            });   
        }

        private void 下载选中章节分别保存EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            string SelectUrl = "";
            string Title = "";
            int x = 0;
            RunAsync(() =>
            {
                this.toolStripProgressBar1.Visible = true;
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    SelectUrl = dataGridView1.SelectedRows[i].Cells[2].Value.ToString();
                    Title = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                    RunInMainthread(() =>
                    {
                        toolStripProgressBar1.Value = (int)(Math.Round((x + 1) / (double)dataGridView1.SelectedRows.Count, 2) * 100);
                        toolStripStatusLabel1.Text = "正在下载：" + Title;
                    });
                    var html1 = this.GethtmlContent(SelectUrl);
                    var htmlDocument = new HtmlAgilityPack.HtmlDocument();
                    htmlDocument.LoadHtml(html1);
                    var html = htmlDocument.DocumentNode;
                    var tit = "<h2>" + Title + "</h2>";
                    var Content = tit + html.SelectNodes("//div[@id='content']")[0].InnerHtml;
                    HtmlToWord(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "tmp.doc", System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + Title + ".doc", Content);
                    x++;
                }
                toolStripStatusLabel1.Text = "下载完成。";
            });    
        }

        private void 下载选中章节到TXTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            string SelectUrl = "";
            string Title = "";
            int x = 0;
            RunAsync(() =>
            {
                this.toolStripProgressBar1.Visible = true;
                for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                {
                    SelectUrl = dataGridView1.SelectedRows[i].Cells[2].Value.ToString();
                    Title = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                    RunInMainthread(() =>
                    {
                        toolStripProgressBar1.Value = (int)(Math.Round((x + 1) / (double)dataGridView1.SelectedRows.Count, 2) * 100);
                        toolStripStatusLabel1.Text = "正在下载：" + Title;
                    });
                    var html1 = this.GethtmlContent(SelectUrl);
                    var htmlDocument = new HtmlAgilityPack.HtmlDocument();
                    htmlDocument.LoadHtml(html1);
                    var html = htmlDocument.DocumentNode;
                    var tit = "<h2>" + Title + "</h2>";
                    var Content = tit + html.SelectNodes("//div[@id='content']")[0].InnerHtml.Replace("<p>喜欢花都最强医神请大家收藏：(www.shouda8.com)花都最强医神手打吧小说网更新速度最快。</p>", "");
                    System.IO.File.WriteAllText(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + Title + ".txt", Content);
                    x++;
                }
                toolStripStatusLabel1.Text = "下载完成。";
            });
        }

        #region 异步线程
        //异步线程
        public static void RunAsync(Action action)
        {
            ((Action)(delegate ()
            {
                action.Invoke();
            })).BeginInvoke(null, null);
        }

        public void RunInMainthread(Action action)
        {
            this.BeginInvoke((Action)(delegate ()
            {
                action.Invoke();
            }));
        } 
        #endregion

        #region 解析指定的HTML
        /// <summary>
        /// 解析指定的HTML
        /// </summary>
        /// <param name="url">HTML地址</param>
        /// <param name="xpath"></param>
        /// <returns></returns>
        private HtmlNodeCollection GetHtmlNodes(string url, string xpath)
        {
            var html1 = this.GethtmlContent(url);
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html1);
            var html = htmlDocument.DocumentNode;
            return html.SelectNodes(xpath);
        }
        #endregion

        #region html转word
        /// <summary>
        /// html转word文件需要先创建一个模板word，再指定新的word文件的地址
        /// </summary>
        /// <param name="templatePath">加密采用的编码方式</param>
        /// <param name="newFilePath">加密采用的编码方式</param>
        /// <param name="html">待加密的明文</param>
        /// <returns></returns>
        private void HtmlToWord(string templatePath, string newFilePath, string html)
        {
            //加载word模板。
            Aspose.Words.Document doc = new Aspose.Words.Document(string.Format(@"{0}", templatePath));
            Aspose.Words.DocumentBuilder builder = new Aspose.Words.DocumentBuilder(doc);
            builder.InsertHtml(html);
            doc.Save(newFilePath, Aspose.Words.SaveFormat.Doc);
        }

        #endregion

    }
}
