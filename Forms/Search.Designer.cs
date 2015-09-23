namespace Student_chemistry.Forms
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.SearchBrowser = new System.Windows.Forms.WebBrowser();
            this.Googlebtn = new System.Windows.Forms.Button();
            this.Bingbtn = new System.Windows.Forms.Button();
            this.Yahoobtn = new System.Windows.Forms.Button();
            this.Salambtn = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB1
            // 
            this.PB1.Image = ((System.Drawing.Image)(resources.GetObject("PB1.Image")));
            this.PB1.Location = new System.Drawing.Point(754, 12);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(88, 94);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB1.TabIndex = 0;
            this.PB1.TabStop = false;
            // 
            // SearchBrowser
            // 
            this.SearchBrowser.Location = new System.Drawing.Point(0, 0);
            this.SearchBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.SearchBrowser.Name = "SearchBrowser";
            this.SearchBrowser.Size = new System.Drawing.Size(748, 615);
            this.SearchBrowser.TabIndex = 1;
            this.SearchBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.SearchBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.SearchBrowser_DocumentCompleted);
            // 
            // Googlebtn
            // 
            this.Googlebtn.Location = new System.Drawing.Point(760, 126);
            this.Googlebtn.Name = "Googlebtn";
            this.Googlebtn.Size = new System.Drawing.Size(81, 25);
            this.Googlebtn.TabIndex = 2;
            this.Googlebtn.Text = "Google.com";
            this.Googlebtn.UseVisualStyleBackColor = true;
            this.Googlebtn.Click += new System.EventHandler(this.Googlebtn_Click);
            // 
            // Bingbtn
            // 
            this.Bingbtn.Location = new System.Drawing.Point(760, 168);
            this.Bingbtn.Name = "Bingbtn";
            this.Bingbtn.Size = new System.Drawing.Size(81, 25);
            this.Bingbtn.TabIndex = 3;
            this.Bingbtn.Text = "Bing.com";
            this.Bingbtn.UseVisualStyleBackColor = true;
            this.Bingbtn.Click += new System.EventHandler(this.Bingbtn_Click);
            // 
            // Yahoobtn
            // 
            this.Yahoobtn.Location = new System.Drawing.Point(760, 210);
            this.Yahoobtn.Name = "Yahoobtn";
            this.Yahoobtn.Size = new System.Drawing.Size(81, 25);
            this.Yahoobtn.TabIndex = 4;
            this.Yahoobtn.Text = "Yahoo.com";
            this.Yahoobtn.UseVisualStyleBackColor = true;
            this.Yahoobtn.Click += new System.EventHandler(this.Yahoobtn_Click);
            // 
            // Salambtn
            // 
            this.Salambtn.Location = new System.Drawing.Point(761, 253);
            this.Salambtn.Name = "Salambtn";
            this.Salambtn.Size = new System.Drawing.Size(81, 25);
            this.Salambtn.TabIndex = 5;
            this.Salambtn.Text = "Salam.ir";
            this.Salambtn.UseVisualStyleBackColor = true;
            this.Salambtn.Click += new System.EventHandler(this.Salambtn_Click);
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(803, 298);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(43, 23);
            this.Forward.TabIndex = 6;
            this.Forward.Text = "جلو";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(754, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "برگرد";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 615);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Salambtn);
            this.Controls.Add(this.Yahoobtn);
            this.Controls.Add(this.Bingbtn);
            this.Controls.Add(this.Googlebtn);
            this.Controls.Add(this.SearchBrowser);
            this.Controls.Add(this.PB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(735, 579);
            this.Name = "Search";
            this.ShowIcon = false;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.WebBrowser SearchBrowser;
        private System.Windows.Forms.Button Googlebtn;
        private System.Windows.Forms.Button Bingbtn;
        private System.Windows.Forms.Button Yahoobtn;
        private System.Windows.Forms.Button Salambtn;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button button2;
    }
}