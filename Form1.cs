using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Musik
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser chromium;

        private string yandexUrl = "https://music.yandex.ru/home";
        private string vkUrl = "https://vk.com/audios529523734";

        public Form1()
        {
            this.InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSettings cefSettings = new CefSettings();
            cefSettings.CachePath = AppDomain.CurrentDomain.BaseDirectory + "plugins\\directory\\cache";
            cefSettings.CefCommandLineArgs.Add("persist_session_cookies", "true");
            cefSettings.Locale = "ru";
            cefSettings.PersistSessionCookies = true;


            Cef.Initialize((CefSettingsBase)cefSettings);

            this.chromium = new ChromiumWebBrowser(yandexUrl);
            this.ChromiumContainerPanel.Controls.Add((Control)this.chromium);
            this.chromium.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.YandexButton.Visible = false;
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            this.chromium.Back();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            this.chromium.Forward();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.chromium.Reload();
        }

        private void BackButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackButton.BorderStyle = BorderStyle.Fixed3D;
        }

        private void BackButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackButton.BorderStyle = BorderStyle.None;
        }

        private void ForwardButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.ForwardButton.BorderStyle = BorderStyle.Fixed3D;
        }

        private void ForwardButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.ForwardButton.BorderStyle = BorderStyle.None;
        }

        private void RefreshButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.RefreshButton.BorderStyle = BorderStyle.Fixed3D;
        }

        private void RefreshButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.RefreshButton.BorderStyle = BorderStyle.None;
        }

        private void YandexButton_Click(object sender, EventArgs e)
        {
            this.YandexButton.Visible = false;
            this.VkButton.Visible = true;

            this.ChromiumContainerPanel.Controls.Remove((Control)this.chromium);
            chromium.Dispose();
            this.chromium = new ChromiumWebBrowser(yandexUrl);
            this.ChromiumContainerPanel.Controls.Add((Control)this.chromium);

            this.Text = "Яндекс.Музыка";
        }

        private void VkButton_Click(object sender, EventArgs e)
        {
            this.YandexButton.Visible = true;
            this.VkButton.Visible = false;

            this.ChromiumContainerPanel.Controls.Remove((Control)this.chromium);
            chromium.Dispose();
            this.chromium = new ChromiumWebBrowser(vkUrl);
            this.ChromiumContainerPanel.Controls.Add((Control)this.chromium);

            this.Text = "VK.Музыка";
        }
    }
}
