namespace Icarus
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameText = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.passwordText = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usernameText
            // 
            this.usernameText.AcceptsReturn = false;
            this.usernameText.AcceptsTab = false;
            this.usernameText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usernameText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usernameText.BackColor = System.Drawing.Color.Transparent;
            this.usernameText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usernameText.BackgroundImage")));
            this.usernameText.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.usernameText.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.usernameText.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.usernameText.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.usernameText.BorderRadius = 5;
            this.usernameText.BorderThickness = 2;
            this.usernameText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameText.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.DefaultText = "";
            this.usernameText.FillColor = System.Drawing.Color.White;
            this.usernameText.HideSelection = true;
            this.usernameText.IconLeft = null;
            this.usernameText.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.usernameText.IconPadding = 10;
            this.usernameText.IconRight = null;
            this.usernameText.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.usernameText.Location = new System.Drawing.Point(84, 242);
            this.usernameText.MaxLength = 32767;
            this.usernameText.MinimumSize = new System.Drawing.Size(100, 35);
            this.usernameText.Modified = false;
            this.usernameText.Name = "usernameText";
            this.usernameText.PasswordChar = '\0';
            this.usernameText.ReadOnly = false;
            this.usernameText.SelectedText = "";
            this.usernameText.SelectionLength = 0;
            this.usernameText.SelectionStart = 0;
            this.usernameText.ShortcutsEnabled = true;
            this.usernameText.Size = new System.Drawing.Size(232, 35);
            this.usernameText.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.usernameText.TabIndex = 2;
            this.usernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameText.TextMarginLeft = 5;
            this.usernameText.TextPlaceholder = "Username";
            this.usernameText.UseSystemPasswordChar = false;
            // 
            // passwordText
            // 
            this.passwordText.AcceptsReturn = false;
            this.passwordText.AcceptsTab = false;
            this.passwordText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordText.BackColor = System.Drawing.Color.Transparent;
            this.passwordText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordText.BackgroundImage")));
            this.passwordText.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.passwordText.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.passwordText.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.passwordText.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.passwordText.BorderRadius = 5;
            this.passwordText.BorderThickness = 2;
            this.passwordText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordText.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.DefaultText = "";
            this.passwordText.FillColor = System.Drawing.Color.White;
            this.passwordText.HideSelection = true;
            this.passwordText.IconLeft = null;
            this.passwordText.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.passwordText.IconPadding = 10;
            this.passwordText.IconRight = null;
            this.passwordText.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.passwordText.Location = new System.Drawing.Point(84, 292);
            this.passwordText.MaxLength = 32767;
            this.passwordText.MinimumSize = new System.Drawing.Size(100, 35);
            this.passwordText.Modified = false;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.ReadOnly = false;
            this.passwordText.SelectedText = "";
            this.passwordText.SelectionLength = 0;
            this.passwordText.SelectionStart = 0;
            this.passwordText.ShortcutsEnabled = true;
            this.passwordText.Size = new System.Drawing.Size(232, 35);
            this.passwordText.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.passwordText.TabIndex = 3;
            this.passwordText.Tag = "";
            this.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordText.TextMarginLeft = 5;
            this.passwordText.TextPlaceholder = "Password";
            this.passwordText.UseSystemPasswordChar = false;
            // 
            // loginButton
            // 
            this.loginButton.Active = false;
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 5;
            this.loginButton.ButtonText = "Login";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = null;
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = true;
            this.loginButton.IconZoom = 90D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(151, 333);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(165, 38);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(353, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 6;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 513);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox usernameText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox passwordText;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
    }
}