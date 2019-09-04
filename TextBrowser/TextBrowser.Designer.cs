namespace TextBrowser
{
    partial class TextBrowser
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbWebView = new System.Windows.Forms.TextBox();
            this.btGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(12, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(817, 20);
            this.tbUrl.TabIndex = 0;
            this.tbUrl.Text = "http://www.google.com/";
            // 
            // tbWebView
            // 
            this.tbWebView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWebView.Location = new System.Drawing.Point(12, 38);
            this.tbWebView.Multiline = true;
            this.tbWebView.Name = "tbWebView";
            this.tbWebView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbWebView.Size = new System.Drawing.Size(898, 642);
            this.tbWebView.TabIndex = 1;
            // 
            // btGo
            // 
            this.btGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGo.Location = new System.Drawing.Point(835, 12);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(75, 23);
            this.btGo.TabIndex = 2;
            this.btGo.Text = "GO";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // TextBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 692);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.tbWebView);
            this.Controls.Add(this.tbUrl);
            this.Name = "TextBrowser";
            this.Text = "TextBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbWebView;
        private System.Windows.Forms.Button btGo;
    }
}

