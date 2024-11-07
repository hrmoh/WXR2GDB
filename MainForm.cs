using ganjoor;
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

        

        private void btnSelectOutputFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "GDB Files (*.gdb)|*.gdb";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtOutputFile.Text = dlg.FileName;
                }
            }
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(txtInputFile.Text == "")
            {
                MessageBox.Show("txtInputFile.Text == \"\"");
                return;
            }

            if(txtOutputFile.Text == "")
            {
                MessageBox.Show("txtOutputFile.Text == \"\"");
                return;
            }


            if (txtCatTitle.Text == "")
            {
                MessageBox.Show("txtCatTitle.Text == \"\"");
                return;
            }


            DbBrowser db = new DbBrowser(txtOutputFile.Text);

            var poets = db.Poets;
            if(poets.Count != 1)
            {
                MessageBox.Show("db.Poets.Count != 1");
                return;
            }

            var poet = poets.First();


            var newCat = db.CreateNewCategory(txtCatTitle.Text, poet._CatID, poet._ID);

            XmlDocument xml = new XmlDocument();
            xml.Load(txtInputFile.Text);
            XmlNodeList items = xml.SelectNodes("/rss/channel/item");
            foreach (XmlNode item in items)
            {
                string title = item["title"].InnerText;
                string html = item["content:encoded"].InnerText;
                string txt = GetPlainText(html);
                
                string[] lines = txt.Split('\r', '\n');

                var poem = db.CreateNewPoem(title, newCat._ID);
                VersePosition position = VersePosition.Right;
                int x = 0;
                foreach (string line in lines)
                {
                    db.CreateNewVerse(poem._ID, x, position);
                    x++;
                    position = position == VersePosition.Right ? VersePosition.Left : VersePosition.Right;
                }
            }
            MessageBox.Show("done");
        }
    }
}
