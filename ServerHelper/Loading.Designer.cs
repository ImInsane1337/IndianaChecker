namespace ServerHelper
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.bunifuLoader1 = new Bunifu.UI.WinForms.BunifuLoader();
            this.loadingtext = new Bunifu.UI.WinForms.BunifuLabel();
            this.VersionLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 11;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // bunifuLoader1
            // 
            this.bunifuLoader1.AllowStylePresets = true;
            this.bunifuLoader1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLoader1.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.bunifuLoader1.Color = System.Drawing.Color.AntiqueWhite;
            this.bunifuLoader1.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.bunifuLoader1.Customization = "";
            this.bunifuLoader1.DashWidth = 0.5F;
            this.bunifuLoader1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLoader1.Image = null;
            this.bunifuLoader1.Location = new System.Drawing.Point(123, 52);
            this.bunifuLoader1.Name = "bunifuLoader1";
            this.bunifuLoader1.NoRounding = false;
            this.bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.bunifuLoader1.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.bunifuLoader1.ShowText = false;
            this.bunifuLoader1.Size = new System.Drawing.Size(130, 130);
            this.bunifuLoader1.Speed = 2;
            this.bunifuLoader1.TabIndex = 1;
            this.bunifuLoader1.Text = "bunifuLoader1";
            this.bunifuLoader1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuLoader1.Thickness = 13;
            this.bunifuLoader1.Transparent = true;
            // 
            // loadingtext
            // 
            this.loadingtext.AllowParentOverrides = false;
            this.loadingtext.AutoEllipsis = false;
            this.loadingtext.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadingtext.CursorType = System.Windows.Forms.Cursors.Default;
            this.loadingtext.EllipsisFormat = Bunifu.UI.WinForms.Helpers.Ellipsis.EllipsisFormat.End;
            this.loadingtext.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.loadingtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.loadingtext.Location = new System.Drawing.Point(67, 243);
            this.loadingtext.Name = "loadingtext";
            this.loadingtext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loadingtext.Size = new System.Drawing.Size(242, 25);
            this.loadingtext.TabIndex = 2;
            this.loadingtext.Text = "Проверка обновлений...";
            this.loadingtext.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.loadingtext.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AllowParentOverrides = false;
            this.VersionLabel.AutoEllipsis = false;
            this.VersionLabel.CursorType = null;
            this.VersionLabel.EllipsisFormat = Bunifu.UI.WinForms.Helpers.Ellipsis.EllipsisFormat.End;
            this.VersionLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.VersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.VersionLabel.Location = new System.Drawing.Point(153, 357);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VersionLabel.Size = new System.Drawing.Size(77, 16);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "Версия: 1.0";
            this.VersionLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.VersionLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(377, 385);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.loadingtext);
            this.Controls.Add(this.bunifuLoader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Bunifu.UI.WinForms.BunifuLoader bunifuLoader1;
        private Bunifu.UI.WinForms.BunifuLabel VersionLabel;
        private Bunifu.UI.WinForms.BunifuLabel loadingtext;
    }
}