namespace ThesisManagementProject.Forms
{
    partial class FThesisStop
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FThesisStop));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gShadowPanelTeam = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblThesisTopic = new Label();
            gTextBoxTopic = new Guna.UI2.WinForms.Guna2TextBox();
            lblReason = new Label();
            gTextBoxReason = new Guna.UI2.WinForms.Guna2TextBox();
            gButtonConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            gButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            erpReason = new ErrorProvider(components);
            gShadowPanelTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpReason).BeginInit();
            SuspendLayout();
            // 
            // gShadowPanelTeam
            // 
            gShadowPanelTeam.BackColor = Color.Transparent;
            gShadowPanelTeam.Controls.Add(lblThesisTopic);
            gShadowPanelTeam.Controls.Add(gTextBoxTopic);
            gShadowPanelTeam.Controls.Add(lblReason);
            gShadowPanelTeam.Controls.Add(gTextBoxReason);
            gShadowPanelTeam.FillColor = Color.White;
            gShadowPanelTeam.Location = new Point(27, 33);
            gShadowPanelTeam.Name = "gShadowPanelTeam";
            gShadowPanelTeam.Radius = 7;
            gShadowPanelTeam.ShadowColor = Color.Black;
            gShadowPanelTeam.ShadowShift = 8;
            gShadowPanelTeam.Size = new Size(811, 387);
            gShadowPanelTeam.TabIndex = 43;
            // 
            // lblThesisTopic
            // 
            lblThesisTopic.AutoSize = true;
            lblThesisTopic.BackColor = Color.Transparent;
            lblThesisTopic.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThesisTopic.Location = new Point(38, 28);
            lblThesisTopic.Name = "lblThesisTopic";
            lblThesisTopic.Size = new Size(155, 28);
            lblThesisTopic.TabIndex = 12;
            lblThesisTopic.Text = "THESIS TOPIC";
            // 
            // gTextBoxTopic
            // 
            gTextBoxTopic.AutoScroll = true;
            gTextBoxTopic.BorderColor = Color.FromArgb(74, 97, 94);
            gTextBoxTopic.BorderRadius = 5;
            gTextBoxTopic.CustomizableEdges = customizableEdges1;
            gTextBoxTopic.DefaultText = "";
            gTextBoxTopic.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gTextBoxTopic.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gTextBoxTopic.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gTextBoxTopic.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gTextBoxTopic.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gTextBoxTopic.Font = new Font("Segoe UI", 9F);
            gTextBoxTopic.ForeColor = Color.Black;
            gTextBoxTopic.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gTextBoxTopic.IconLeft = (Image)resources.GetObject("gTextBoxTopic.IconLeft");
            gTextBoxTopic.IconLeftOffset = new Point(5, 0);
            gTextBoxTopic.Location = new Point(38, 60);
            gTextBoxTopic.Margin = new Padding(3, 4, 3, 4);
            gTextBoxTopic.Multiline = true;
            gTextBoxTopic.Name = "gTextBoxTopic";
            gTextBoxTopic.PasswordChar = '\0';
            gTextBoxTopic.PlaceholderForeColor = Color.Gray;
            gTextBoxTopic.PlaceholderText = "Thesis topic";
            gTextBoxTopic.ReadOnly = true;
            gTextBoxTopic.SelectedText = "";
            gTextBoxTopic.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gTextBoxTopic.Size = new Size(728, 120);
            gTextBoxTopic.TabIndex = 11;
            gTextBoxTopic.TextOffset = new Point(5, 0);
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.BackColor = Color.Transparent;
            lblReason.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReason.Location = new Point(38, 196);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(343, 28);
            lblReason.TabIndex = 10;
            lblReason.Text = "REASON FOR NOT COMPLETING";
            // 
            // gTextBoxReason
            // 
            gTextBoxReason.AutoScroll = true;
            gTextBoxReason.BorderColor = Color.FromArgb(74, 97, 94);
            gTextBoxReason.BorderRadius = 5;
            gTextBoxReason.CustomizableEdges = customizableEdges3;
            gTextBoxReason.DefaultText = "";
            gTextBoxReason.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gTextBoxReason.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gTextBoxReason.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gTextBoxReason.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gTextBoxReason.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gTextBoxReason.Font = new Font("Segoe UI", 9F);
            gTextBoxReason.ForeColor = Color.Black;
            gTextBoxReason.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gTextBoxReason.IconLeft = Properties.Resources.PicAddDescription;
            gTextBoxReason.IconLeftOffset = new Point(5, 0);
            gTextBoxReason.Location = new Point(38, 228);
            gTextBoxReason.Margin = new Padding(3, 4, 3, 4);
            gTextBoxReason.Multiline = true;
            gTextBoxReason.Name = "gTextBoxReason";
            gTextBoxReason.PasswordChar = '\0';
            gTextBoxReason.PlaceholderForeColor = Color.Gray;
            gTextBoxReason.PlaceholderText = "Your reason";
            gTextBoxReason.SelectedText = "";
            gTextBoxReason.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gTextBoxReason.Size = new Size(728, 123);
            gTextBoxReason.TabIndex = 9;
            gTextBoxReason.TextOffset = new Point(5, 0);
            gTextBoxReason.TextChanged += gTextBoxReason_TextChanged;
            // 
            // gButtonConfirm
            // 
            gButtonConfirm.BackColor = Color.Transparent;
            gButtonConfirm.BorderRadius = 7;
            gButtonConfirm.CustomizableEdges = customizableEdges5;
            gButtonConfirm.DisabledState.BorderColor = Color.DarkGray;
            gButtonConfirm.DisabledState.CustomBorderColor = Color.DarkGray;
            gButtonConfirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gButtonConfirm.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            gButtonConfirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gButtonConfirm.FillColor = Color.FromArgb(2, 0, 214);
            gButtonConfirm.FillColor2 = Color.FromArgb(94, 148, 255);
            gButtonConfirm.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gButtonConfirm.ForeColor = Color.White;
            gButtonConfirm.Location = new Point(693, 426);
            gButtonConfirm.Name = "gButtonConfirm";
            gButtonConfirm.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gButtonConfirm.Size = new Size(100, 35);
            gButtonConfirm.TabIndex = 44;
            gButtonConfirm.Text = "Confirm";
            gButtonConfirm.Click += gButtonConfirm_Click;
            // 
            // gButtonCancel
            // 
            gButtonCancel.BackColor = Color.Transparent;
            gButtonCancel.BorderRadius = 7;
            gButtonCancel.CustomizableEdges = customizableEdges7;
            gButtonCancel.DisabledState.BorderColor = Color.DarkGray;
            gButtonCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            gButtonCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gButtonCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gButtonCancel.FillColor = Color.Silver;
            gButtonCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gButtonCancel.ForeColor = Color.White;
            gButtonCancel.Location = new Point(587, 426);
            gButtonCancel.Name = "gButtonCancel";
            gButtonCancel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            gButtonCancel.Size = new Size(100, 35);
            gButtonCancel.TabIndex = 1;
            gButtonCancel.Text = "Cancel";
            gButtonCancel.Click += gButtonCancel_Click;
            // 
            // erpReason
            // 
            erpReason.ContainerControl = this;
            erpReason.Icon = (Icon)resources.GetObject("erpReason.Icon");
            // 
            // FThesisStop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(867, 488);
            Controls.Add(gButtonConfirm);
            Controls.Add(gButtonCancel);
            Controls.Add(gShadowPanelTeam);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FThesisStop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FThesisStop";
            gShadowPanelTeam.ResumeLayout(false);
            gShadowPanelTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpReason).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel gShadowPanelTeam;
        private Label lblReason;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxReason;
        private Guna.UI2.WinForms.Guna2GradientButton gButtonConfirm;
        private Guna.UI2.WinForms.Guna2Button gButtonCancel;
        private Label lblThesisTopic;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxTopic;
        private ErrorProvider erpReason;
    }
}