using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void WebBrowser_Load(object sender, EventArgs e)
        {
            string url = "http://www.google.com/";
            browser.Navigate(url);
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            browser.Navigate(SearchField.Text);
        }

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            SearchField.Text = browser.Document.Url.ToString();
            this.Text = browser.Document.Title;
        }
    }
}
