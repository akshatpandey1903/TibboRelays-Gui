namespace relays
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.relayButton1On = new System.Windows.Forms.Button();
            this.relayButton1Off = new System.Windows.Forms.Button();
            this.relayButton2On = new System.Windows.Forms.Button();
            this.relayButton2Off = new System.Windows.Forms.Button();
            this.relayButton3On = new System.Windows.Forms.Button();
            this.relayButton3Off = new System.Windows.Forms.Button();
            this.relayButton4On = new System.Windows.Forms.Button();
            this.relayButton4Off = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(96, 86);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 30);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // relayButton1On
            // 
            this.relayButton1On.BackColor = System.Drawing.Color.LightGreen;
            this.relayButton1On.Location = new System.Drawing.Point(6, 21);
            this.relayButton1On.Name = "relayButton1On";
            this.relayButton1On.Size = new System.Drawing.Size(100, 30);
            this.relayButton1On.TabIndex = 1;
            this.relayButton1On.Text = "On";
            this.relayButton1On.UseVisualStyleBackColor = false;
            this.relayButton1On.Visible = false;
            this.relayButton1On.Click += new System.EventHandler(this.relayButton1On_Click);
            // 
            // relayButton1Off
            // 
            this.relayButton1Off.BackColor = System.Drawing.Color.LightCoral;
            this.relayButton1Off.Location = new System.Drawing.Point(112, 21);
            this.relayButton1Off.Name = "relayButton1Off";
            this.relayButton1Off.Size = new System.Drawing.Size(100, 30);
            this.relayButton1Off.TabIndex = 2;
            this.relayButton1Off.Text = "Off";
            this.relayButton1Off.UseVisualStyleBackColor = false;
            this.relayButton1Off.Visible = false;
            this.relayButton1Off.Click += new System.EventHandler(this.relayButton1Off_Click);
            // 
            // relayButton2On
            // 
            this.relayButton2On.BackColor = System.Drawing.Color.LightGreen;
            this.relayButton2On.Location = new System.Drawing.Point(6, 21);
            this.relayButton2On.Name = "relayButton2On";
            this.relayButton2On.Size = new System.Drawing.Size(100, 30);
            this.relayButton2On.TabIndex = 3;
            this.relayButton2On.Text = "On";
            this.relayButton2On.UseVisualStyleBackColor = false;
            this.relayButton2On.Visible = false;
            this.relayButton2On.Click += new System.EventHandler(this.relayButton2On_Click);
            // 
            // relayButton2Off
            // 
            this.relayButton2Off.BackColor = System.Drawing.Color.LightCoral;
            this.relayButton2Off.Location = new System.Drawing.Point(112, 21);
            this.relayButton2Off.Name = "relayButton2Off";
            this.relayButton2Off.Size = new System.Drawing.Size(100, 30);
            this.relayButton2Off.TabIndex = 4;
            this.relayButton2Off.Text = "Off";
            this.relayButton2Off.UseVisualStyleBackColor = false;
            this.relayButton2Off.Visible = false;
            this.relayButton2Off.Click += new System.EventHandler(this.relayButton2Off_Click);
            // 
            // relayButton3On
            // 
            this.relayButton3On.BackColor = System.Drawing.Color.LightGreen;
            this.relayButton3On.Location = new System.Drawing.Point(6, 21);
            this.relayButton3On.Name = "relayButton3On";
            this.relayButton3On.Size = new System.Drawing.Size(100, 30);
            this.relayButton3On.TabIndex = 5;
            this.relayButton3On.Text = "On";
            this.relayButton3On.UseVisualStyleBackColor = false;
            this.relayButton3On.Visible = false;
            this.relayButton3On.Click += new System.EventHandler(this.relayButton3On_Click);
            // 
            // relayButton3Off
            // 
            this.relayButton3Off.BackColor = System.Drawing.Color.LightCoral;
            this.relayButton3Off.Location = new System.Drawing.Point(112, 21);
            this.relayButton3Off.Name = "relayButton3Off";
            this.relayButton3Off.Size = new System.Drawing.Size(100, 30);
            this.relayButton3Off.TabIndex = 6;
            this.relayButton3Off.Text = "Off";
            this.relayButton3Off.UseVisualStyleBackColor = false;
            this.relayButton3Off.Visible = false;
            this.relayButton3Off.Click += new System.EventHandler(this.relayButton3Off_Click);
            // 
            // relayButton4On
            // 
            this.relayButton4On.BackColor = System.Drawing.Color.LightGreen;
            this.relayButton4On.Location = new System.Drawing.Point(6, 21);
            this.relayButton4On.Name = "relayButton4On";
            this.relayButton4On.Size = new System.Drawing.Size(100, 30);
            this.relayButton4On.TabIndex = 7;
            this.relayButton4On.Text = "On";
            this.relayButton4On.UseVisualStyleBackColor = false;
            this.relayButton4On.Visible = false;
            this.relayButton4On.Click += new System.EventHandler(this.relayButton4On_Click);
            // 
            // relayButton4Off
            // 
            this.relayButton4Off.BackColor = System.Drawing.Color.LightCoral;
            this.relayButton4Off.Location = new System.Drawing.Point(112, 21);
            this.relayButton4Off.Name = "relayButton4Off";
            this.relayButton4Off.Size = new System.Drawing.Size(100, 30);
            this.relayButton4Off.TabIndex = 8;
            this.relayButton4Off.Text = "Off";
            this.relayButton4Off.UseVisualStyleBackColor = false;
            this.relayButton4Off.Visible = false;
            this.relayButton4Off.Click += new System.EventHandler(this.relayButton4Off_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(300, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(400, 400);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.relayButton1On);
            this.groupBox1.Controls.Add(this.relayButton1Off);
            this.groupBox1.Location = new System.Drawing.Point(50, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relay 1";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.relayButton2On);
            this.groupBox2.Controls.Add(this.relayButton2Off);
            this.groupBox2.Location = new System.Drawing.Point(50, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 60);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relay 2";
            this.groupBox2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.relayButton3On);
            this.groupBox3.Controls.Add(this.relayButton3Off);
            this.groupBox3.Location = new System.Drawing.Point(50, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 60);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Relay 3";
            this.groupBox3.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.relayButton4On);
            this.groupBox4.Controls.Add(this.relayButton4Off);
            this.groupBox4.Location = new System.Drawing.Point(50, 360);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 60);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relay 4";
            this.groupBox4.Visible = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(50, 20);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(209, 35);
            this.headerLabel.TabIndex = 14;
            this.headerLabel.Text = "Relay Control";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "Relay Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button relayButton1On;
        private System.Windows.Forms.Button relayButton1Off;
        private System.Windows.Forms.Button relayButton2On;
        private System.Windows.Forms.Button relayButton2Off;
        private System.Windows.Forms.Button relayButton3On;
        private System.Windows.Forms.Button relayButton3Off;
        private System.Windows.Forms.Button relayButton4On;
        private System.Windows.Forms.Button relayButton4Off;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label headerLabel;
    }
}
