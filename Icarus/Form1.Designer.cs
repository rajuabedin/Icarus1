namespace Icarus
{
    partial class Dashboard
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topBar = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.salesText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.predictedText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.differenceText = new System.Windows.Forms.Label();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.satrtAnalisyB = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.stopAnalisyB = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.showGraphB = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.topBar.Controls.Add(this.bunifuLabel1);
            this.topBar.Controls.Add(this.closeButton);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(926, 40);
            this.topBar.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(74, 22);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Dashboard";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(890, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 5;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.salesText);
            this.panel1.Location = new System.Drawing.Point(59, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 135);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "SALES";
            // 
            // salesText
            // 
            this.salesText.BackColor = System.Drawing.Color.Transparent;
            this.salesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesText.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesText.ForeColor = System.Drawing.Color.LightSalmon;
            this.salesText.Location = new System.Drawing.Point(0, 0);
            this.salesText.Name = "salesText";
            this.salesText.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.salesText.Size = new System.Drawing.Size(244, 135);
            this.salesText.TabIndex = 4;
            this.salesText.Text = "10340";
            this.salesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.predictedText);
            this.panel2.Location = new System.Drawing.Point(335, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 135);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "PREDICTED";
            // 
            // predictedText
            // 
            this.predictedText.BackColor = System.Drawing.Color.Transparent;
            this.predictedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.predictedText.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictedText.ForeColor = System.Drawing.Color.LightSalmon;
            this.predictedText.Location = new System.Drawing.Point(0, 0);
            this.predictedText.Name = "predictedText";
            this.predictedText.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.predictedText.Size = new System.Drawing.Size(244, 135);
            this.predictedText.TabIndex = 5;
            this.predictedText.Text = "10460";
            this.predictedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.differenceText);
            this.panel3.Location = new System.Drawing.Point(608, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 135);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(158, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "DIFFERENCE";
            // 
            // differenceText
            // 
            this.differenceText.BackColor = System.Drawing.Color.Transparent;
            this.differenceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.differenceText.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceText.ForeColor = System.Drawing.Color.Crimson;
            this.differenceText.Location = new System.Drawing.Point(0, 0);
            this.differenceText.Name = "differenceText";
            this.differenceText.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.differenceText.Size = new System.Drawing.Size(244, 135);
            this.differenceText.TabIndex = 6;
            this.differenceText.Text = "0";
            this.differenceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(59, 515);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.MediumSlateBlue;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(793, 10);
            this.bunifuProgressBar1.TabIndex = 3;
            this.bunifuProgressBar1.Value = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LawnGreen;
            this.label7.Location = new System.Drawing.Point(56, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Analisy for new prediction started...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // satrtAnalisyB
            // 
            this.satrtAnalisyB.BackColor = System.Drawing.Color.Transparent;
            this.satrtAnalisyB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("satrtAnalisyB.BackgroundImage")));
            this.satrtAnalisyB.ButtonText = "Start Analisy";
            this.satrtAnalisyB.ButtonTextMarginLeft = 0;
            this.satrtAnalisyB.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.satrtAnalisyB.DisabledFillColor = System.Drawing.Color.Gray;
            this.satrtAnalisyB.DisabledForecolor = System.Drawing.Color.White;
            this.satrtAnalisyB.ForeColor = System.Drawing.Color.White;
            this.satrtAnalisyB.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.satrtAnalisyB.IconPadding = 10;
            this.satrtAnalisyB.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.satrtAnalisyB.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.satrtAnalisyB.IdleBorderRadius = 1;
            this.satrtAnalisyB.IdleBorderThickness = 0;
            this.satrtAnalisyB.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.satrtAnalisyB.IdleIconLeftImage = null;
            this.satrtAnalisyB.IdleIconRightImage = null;
            this.satrtAnalisyB.Location = new System.Drawing.Point(335, 232);
            this.satrtAnalisyB.Name = "satrtAnalisyB";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.satrtAnalisyB.onHoverState = stateProperties3;
            this.satrtAnalisyB.Size = new System.Drawing.Size(244, 45);
            this.satrtAnalisyB.TabIndex = 6;
            this.satrtAnalisyB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.satrtAnalisyB.Click += new System.EventHandler(this.satrtAnalisyB_Click);
            // 
            // stopAnalisyB
            // 
            this.stopAnalisyB.BackColor = System.Drawing.Color.Transparent;
            this.stopAnalisyB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopAnalisyB.BackgroundImage")));
            this.stopAnalisyB.ButtonText = "Stop Analisy";
            this.stopAnalisyB.ButtonTextMarginLeft = 0;
            this.stopAnalisyB.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.stopAnalisyB.DisabledFillColor = System.Drawing.Color.Gray;
            this.stopAnalisyB.DisabledForecolor = System.Drawing.Color.White;
            this.stopAnalisyB.ForeColor = System.Drawing.Color.White;
            this.stopAnalisyB.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.stopAnalisyB.IconPadding = 10;
            this.stopAnalisyB.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.stopAnalisyB.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.stopAnalisyB.IdleBorderRadius = 1;
            this.stopAnalisyB.IdleBorderThickness = 0;
            this.stopAnalisyB.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.stopAnalisyB.IdleIconLeftImage = null;
            this.stopAnalisyB.IdleIconRightImage = null;
            this.stopAnalisyB.Location = new System.Drawing.Point(608, 232);
            this.stopAnalisyB.Name = "stopAnalisyB";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.stopAnalisyB.onHoverState = stateProperties2;
            this.stopAnalisyB.Size = new System.Drawing.Size(244, 45);
            this.stopAnalisyB.TabIndex = 7;
            this.stopAnalisyB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stopAnalisyB.Click += new System.EventHandler(this.stopAnalisyB_Click);
            // 
            // showGraphB
            // 
            this.showGraphB.BackColor = System.Drawing.Color.Transparent;
            this.showGraphB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showGraphB.BackgroundImage")));
            this.showGraphB.ButtonText = "Show Graph";
            this.showGraphB.ButtonTextMarginLeft = 0;
            this.showGraphB.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.showGraphB.DisabledFillColor = System.Drawing.Color.Gray;
            this.showGraphB.DisabledForecolor = System.Drawing.Color.White;
            this.showGraphB.ForeColor = System.Drawing.Color.White;
            this.showGraphB.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.showGraphB.IconPadding = 10;
            this.showGraphB.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.showGraphB.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.showGraphB.IdleBorderRadius = 1;
            this.showGraphB.IdleBorderThickness = 0;
            this.showGraphB.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.showGraphB.IdleIconLeftImage = null;
            this.showGraphB.IdleIconRightImage = null;
            this.showGraphB.Location = new System.Drawing.Point(59, 232);
            this.showGraphB.Name = "showGraphB";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.showGraphB.onHoverState = stateProperties1;
            this.showGraphB.Size = new System.Drawing.Size(244, 45);
            this.showGraphB.TabIndex = 8;
            this.showGraphB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showGraphB.Click += new System.EventHandler(this.showGraphB_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(926, 537);
            this.Controls.Add(this.showGraphB);
            this.Controls.Add(this.stopAnalisyB);
            this.Controls.Add(this.satrtAnalisyB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topBar);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topBar;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label differenceText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label predictedText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label salesText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton stopAnalisyB;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton satrtAnalisyB;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton showGraphB;
    }
}

