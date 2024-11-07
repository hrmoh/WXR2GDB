using System.Net;
using System.Text.RegularExpressions;
using System.Xml;

namespace WXR2GDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "XML Files (*.xml)|*.xml";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtInputFile.Text = dlg.FileName;
                }
            }
        }

        public string GetPlainText(string html)
        {
            html = Regex.Replace(html, "<.*?>", "\n");

            html = Regex.Replace(html, @"\\r|\\n|\n|\r", @"$");
            html = Regex.Replace(html, @"\$ +", @"$");
            html = Regex.Replace(html, @"(\$)+", Environment.NewLine);

            return html;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(txtInputFile.Text);
            XmlNodeList items = xml.SelectNodes("/rss/channel/item");
            foreach(XmlNode item in items)
            {
                string title = item["title"].InnerText;
                string html = item["content:encoded"].InnerText;
                string txt = GetPlainText(html);
                while (txt.StartsWith("\r\n"))
                    txt = txt.Substring(2);
                if (DialogResult.No == MessageBox.Show(txt, "", MessageBoxButtons.YesNo))
                {
                    return;
                }
            }
        }
    }
}
