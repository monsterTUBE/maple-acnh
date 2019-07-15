using System;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Net;

namespace Discord_Webhook_Bomber
{
    public partial class Bomber : Form
    {
        public Bomber() => InitializeComponent();

        public static byte[] Post(string URI, NameValueCollection Value)
        {
            using (WebClient WebClient = new WebClient()) return WebClient.UploadValues(URI, Value);
        }

        public void SendWebhook(string URL, string Username, string Message)
        {
            Post(URL, new NameValueCollection()
            {
                { "username", Username },
                { "content", Message }
            });
        }

        private void Bomber_Timer_Tick(object sender, EventArgs e)
        {
            SendWebhook(URL_TextBox.Text, Name_TextBox.Text, Message_TextBox.Text);
        }

        private void BomberToggle_Button_Click(object sender, EventArgs e)
        {
            if (Name_TextBox.Text.Length == 0) Name_TextBox.Text = "ItsJokerZz Webhook Bomber";
            if (URL_TextBox.Text.Length == 0) MessageBox.Show("Please enter a webhook URL."); else
            if (BomberToggle_Button.Text == "Start Bomber")
            { Bomber_Timer.Start(); BomberToggle_Button.Text = "Stop Bomber"; MessageBox.Show("Don't run it too long or you will get a 429 error."); }
            else { Bomber_Timer.Stop(); BomberToggle_Button.Text = "Start Bomber"; }
        }
    }
}
