namespace Discord_Webhook_Bomber
{
    partial class Bomber
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.URL_Label = new System.Windows.Forms.Label();
            this.URL_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Message_TextBox = new System.Windows.Forms.TextBox();
            this.Message_Label = new System.Windows.Forms.Label();
            this.BomberToggle_Button = new System.Windows.Forms.Button();
            this.Bomber_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // URL_Label
            // 
            this.URL_Label.AutoSize = true;
            this.URL_Label.Location = new System.Drawing.Point(10, 5);
            this.URL_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.URL_Label.Name = "URL_Label";
            this.URL_Label.Size = new System.Drawing.Size(29, 13);
            this.URL_Label.TabIndex = 0;
            this.URL_Label.Text = "URL";
            // 
            // URL_TextBox
            // 
            this.URL_TextBox.Location = new System.Drawing.Point(13, 19);
            this.URL_TextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.URL_TextBox.Name = "URL_TextBox";
            this.URL_TextBox.Size = new System.Drawing.Size(286, 20);
            this.URL_TextBox.TabIndex = 1;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(13, 61);
            this.Name_TextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name_TextBox.MaxLength = 32;
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(286, 20);
            this.Name_TextBox.TabIndex = 4;
            this.Name_TextBox.Text = "ItsJokerZz Webhook Bomber";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(10, 47);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(35, 13);
            this.Name_Label.TabIndex = 3;
            this.Name_Label.Text = "Name";
            // 
            // Message_TextBox
            // 
            this.Message_TextBox.Location = new System.Drawing.Point(13, 104);
            this.Message_TextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Message_TextBox.MaxLength = 2000;
            this.Message_TextBox.Multiline = true;
            this.Message_TextBox.Name = "Message_TextBox";
            this.Message_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Message_TextBox.Size = new System.Drawing.Size(286, 69);
            this.Message_TextBox.TabIndex = 6;
            this.Message_TextBox.Text = "\r\n:anger: Sent From ItsJokerZz\'s Discord Webhook Bomber :anger:";
            // 
            // Message_Label
            // 
            this.Message_Label.AutoSize = true;
            this.Message_Label.Location = new System.Drawing.Point(10, 89);
            this.Message_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Message_Label.Name = "Message_Label";
            this.Message_Label.Size = new System.Drawing.Size(50, 13);
            this.Message_Label.TabIndex = 5;
            this.Message_Label.Text = "Message";
            // 
            // BomberToggle_Button
            // 
            this.BomberToggle_Button.Location = new System.Drawing.Point(13, 176);
            this.BomberToggle_Button.Name = "BomberToggle_Button";
            this.BomberToggle_Button.Size = new System.Drawing.Size(286, 22);
            this.BomberToggle_Button.TabIndex = 7;
            this.BomberToggle_Button.Text = "Start Bomber";
            this.BomberToggle_Button.UseVisualStyleBackColor = true;
            this.BomberToggle_Button.Click += new System.EventHandler(this.BomberToggle_Button_Click);
            // 
            // Bomber_Timer
            // 
            this.Bomber_Timer.Interval = 1000;
            this.Bomber_Timer.Tick += new System.EventHandler(this.Bomber_Timer_Tick);
            // 
            // Bomber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 203);
            this.Controls.Add(this.BomberToggle_Button);
            this.Controls.Add(this.Message_TextBox);
            this.Controls.Add(this.Message_Label);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.URL_TextBox);
            this.Controls.Add(this.URL_Label);
            this.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name = "Bomber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Webhook Bomber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label URL_Label;
        private System.Windows.Forms.TextBox URL_TextBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox Message_TextBox;
        private System.Windows.Forms.Label Message_Label;
        private System.Windows.Forms.Button BomberToggle_Button;
        private System.Windows.Forms.Timer Bomber_Timer;
    }
}
