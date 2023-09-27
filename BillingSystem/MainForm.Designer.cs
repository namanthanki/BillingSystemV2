namespace BillingSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UsernameTextField = new MaterialSkin.Controls.MaterialTextBox2();
            this.PasswordTextField = new MaterialSkin.Controls.MaterialTextBox2();
            this.LoginButton = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.LoginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RegisterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RegisterButton = new MaterialSkin.Controls.MaterialButton();
            this.RPasswordTextField = new MaterialSkin.Controls.MaterialTextBox2();
            this.RUsernameTextField = new MaterialSkin.Controls.MaterialTextBox2();
            this.REmailTextField = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // UsernameTextField
            // 
            this.UsernameTextField.AnimateReadOnly = false;
            this.UsernameTextField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UsernameTextField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UsernameTextField.Depth = 0;
            this.UsernameTextField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameTextField.HideSelection = true;
            this.UsernameTextField.Hint = "Enter Username";
            this.UsernameTextField.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("UsernameTextField.LeadingIcon")));
            this.UsernameTextField.Location = new System.Drawing.Point(59, 261);
            this.UsernameTextField.MaxLength = 32767;
            this.UsernameTextField.MouseState = MaterialSkin.MouseState.OUT;
            this.UsernameTextField.Name = "UsernameTextField";
            this.UsernameTextField.PasswordChar = '\0';
            this.UsernameTextField.PrefixSuffixText = null;
            this.UsernameTextField.ReadOnly = false;
            this.UsernameTextField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameTextField.SelectedText = "";
            this.UsernameTextField.SelectionLength = 0;
            this.UsernameTextField.SelectionStart = 0;
            this.UsernameTextField.ShortcutsEnabled = true;
            this.UsernameTextField.Size = new System.Drawing.Size(300, 48);
            this.UsernameTextField.TabIndex = 0;
            this.UsernameTextField.TabStop = false;
            this.UsernameTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UsernameTextField.TrailingIcon = null;
            this.UsernameTextField.UseSystemPasswordChar = false;
            // 
            // PasswordTextField
            // 
            this.PasswordTextField.AnimateReadOnly = false;
            this.PasswordTextField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PasswordTextField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordTextField.Depth = 0;
            this.PasswordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordTextField.HideSelection = true;
            this.PasswordTextField.Hint = "Enter Password";
            this.PasswordTextField.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("PasswordTextField.LeadingIcon")));
            this.PasswordTextField.Location = new System.Drawing.Point(59, 329);
            this.PasswordTextField.MaxLength = 32767;
            this.PasswordTextField.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordTextField.Name = "PasswordTextField";
            this.PasswordTextField.PasswordChar = '●';
            this.PasswordTextField.PrefixSuffixText = null;
            this.PasswordTextField.ReadOnly = false;
            this.PasswordTextField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordTextField.SelectedText = "";
            this.PasswordTextField.SelectionLength = 0;
            this.PasswordTextField.SelectionStart = 0;
            this.PasswordTextField.ShortcutsEnabled = true;
            this.PasswordTextField.Size = new System.Drawing.Size(300, 48);
            this.PasswordTextField.TabIndex = 1;
            this.PasswordTextField.TabStop = false;
            this.PasswordTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTextField.TrailingIcon = null;
            this.PasswordTextField.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = false;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoginButton.Depth = 0;
            this.LoginButton.HighEmphasis = true;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(59, 400);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LoginButton.Size = new System.Drawing.Size(300, 36);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "login";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(413, 84);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 500);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Depth = 0;
            this.LoginLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LoginLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.LoginLabel.Location = new System.Drawing.Point(166, 193);
            this.LoginLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(84, 41);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Login";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Depth = 0;
            this.RegisterLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RegisterLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.RegisterLabel.Location = new System.Drawing.Point(554, 166);
            this.RegisterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(126, 41);
            this.RegisterLabel.TabIndex = 8;
            this.RegisterLabel.Text = "Register";
            // 
            // RegisterButton
            // 
            this.RegisterButton.AutoSize = false;
            this.RegisterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RegisterButton.Depth = 0;
            this.RegisterButton.HighEmphasis = true;
            this.RegisterButton.Icon = null;
            this.RegisterButton.Location = new System.Drawing.Point(472, 439);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegisterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RegisterButton.Size = new System.Drawing.Size(300, 40);
            this.RegisterButton.TabIndex = 7;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RegisterButton.UseAccentColor = false;
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RPasswordTextField
            // 
            this.RPasswordTextField.AnimateReadOnly = false;
            this.RPasswordTextField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RPasswordTextField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RPasswordTextField.Depth = 0;
            this.RPasswordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RPasswordTextField.HideSelection = true;
            this.RPasswordTextField.Hint = "Enter Password";
            this.RPasswordTextField.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("RPasswordTextField.LeadingIcon")));
            this.RPasswordTextField.Location = new System.Drawing.Point(472, 367);
            this.RPasswordTextField.MaxLength = 32767;
            this.RPasswordTextField.MouseState = MaterialSkin.MouseState.OUT;
            this.RPasswordTextField.Name = "RPasswordTextField";
            this.RPasswordTextField.PasswordChar = '●';
            this.RPasswordTextField.PrefixSuffixText = null;
            this.RPasswordTextField.ReadOnly = false;
            this.RPasswordTextField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RPasswordTextField.SelectedText = "";
            this.RPasswordTextField.SelectionLength = 0;
            this.RPasswordTextField.SelectionStart = 0;
            this.RPasswordTextField.ShortcutsEnabled = true;
            this.RPasswordTextField.Size = new System.Drawing.Size(300, 48);
            this.RPasswordTextField.TabIndex = 6;
            this.RPasswordTextField.TabStop = false;
            this.RPasswordTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RPasswordTextField.TrailingIcon = null;
            this.RPasswordTextField.UseSystemPasswordChar = true;
            // 
            // RUsernameTextField
            // 
            this.RUsernameTextField.AnimateReadOnly = false;
            this.RUsernameTextField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RUsernameTextField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RUsernameTextField.Depth = 0;
            this.RUsernameTextField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RUsernameTextField.HideSelection = true;
            this.RUsernameTextField.Hint = "Enter Username";
            this.RUsernameTextField.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("RUsernameTextField.LeadingIcon")));
            this.RUsernameTextField.Location = new System.Drawing.Point(472, 231);
            this.RUsernameTextField.MaxLength = 32767;
            this.RUsernameTextField.MouseState = MaterialSkin.MouseState.OUT;
            this.RUsernameTextField.Name = "RUsernameTextField";
            this.RUsernameTextField.PasswordChar = '\0';
            this.RUsernameTextField.PrefixSuffixText = null;
            this.RUsernameTextField.ReadOnly = false;
            this.RUsernameTextField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RUsernameTextField.SelectedText = "";
            this.RUsernameTextField.SelectionLength = 0;
            this.RUsernameTextField.SelectionStart = 0;
            this.RUsernameTextField.ShortcutsEnabled = true;
            this.RUsernameTextField.Size = new System.Drawing.Size(300, 48);
            this.RUsernameTextField.TabIndex = 5;
            this.RUsernameTextField.TabStop = false;
            this.RUsernameTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RUsernameTextField.TrailingIcon = null;
            this.RUsernameTextField.UseSystemPasswordChar = false;
            // 
            // REmailTextField
            // 
            this.REmailTextField.AnimateReadOnly = false;
            this.REmailTextField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.REmailTextField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.REmailTextField.Depth = 0;
            this.REmailTextField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.REmailTextField.HideSelection = true;
            this.REmailTextField.Hint = "Enter Email";
            this.REmailTextField.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("REmailTextField.LeadingIcon")));
            this.REmailTextField.Location = new System.Drawing.Point(472, 299);
            this.REmailTextField.MaxLength = 32767;
            this.REmailTextField.MouseState = MaterialSkin.MouseState.OUT;
            this.REmailTextField.Name = "REmailTextField";
            this.REmailTextField.PasswordChar = '\0';
            this.REmailTextField.PrefixSuffixText = null;
            this.REmailTextField.ReadOnly = false;
            this.REmailTextField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.REmailTextField.SelectedText = "";
            this.REmailTextField.SelectionLength = 0;
            this.REmailTextField.SelectionStart = 0;
            this.REmailTextField.ShortcutsEnabled = true;
            this.REmailTextField.Size = new System.Drawing.Size(300, 48);
            this.REmailTextField.TabIndex = 9;
            this.REmailTextField.TabStop = false;
            this.REmailTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.REmailTextField.TrailingIcon = null;
            this.REmailTextField.UseSystemPasswordChar = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 600);
            this.Controls.Add(this.REmailTextField);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RPasswordTextField);
            this.Controls.Add(this.RUsernameTextField);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextField);
            this.Controls.Add(this.UsernameTextField);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Sizable = false;
            this.Text = "Billing System - Welcome";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 UsernameTextField;
        private MaterialSkin.Controls.MaterialTextBox2 PasswordTextField;
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel LoginLabel;
        private MaterialSkin.Controls.MaterialLabel RegisterLabel;
        private MaterialSkin.Controls.MaterialButton RegisterButton;
        private MaterialSkin.Controls.MaterialTextBox2 RPasswordTextField;
        private MaterialSkin.Controls.MaterialTextBox2 RUsernameTextField;
        private MaterialSkin.Controls.MaterialTextBox2 REmailTextField;
    }
}

