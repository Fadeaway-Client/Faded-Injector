﻿namespace FadedInjector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragPanel = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Inject = new Guna.UI2.WinForms.Guna2Button();
            this.Titlebar = new Guna.UI2.WinForms.Guna2Panel();
            this.Help = new Guna.UI2.WinForms.Guna2CircleButton();
            this.InjectorLabel = new System.Windows.Forms.Label();
            this.ClientList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SelectDLL = new Guna.UI2.WinForms.Guna2Button();
            this.AutoInject = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.SettingsPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.RpcLabel = new System.Windows.Forms.Label();
            this.DiscordRpc = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.AutoInjectLabel = new System.Windows.Forms.Label();
            this.InjectPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ClientsPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.DragTitle = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Titlebar.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.InjectPanel.SuspendLayout();
            this.ClientsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 16;
            this.Elipse.TargetControl = this;
            // 
            // DragPanel
            // 
            this.DragPanel.DockIndicatorTransparencyValue = 0.6D;
            this.DragPanel.TargetControl = this;
            this.DragPanel.UseTransparentDrag = true;
            // 
            // Shadow
            // 
            this.Shadow.BorderRadius = 16;
            this.Shadow.TargetForm = this;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BorderRadius = 16;
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(799, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(28, 28);
            this.Exit.TabIndex = 0;
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BorderRadius = 16;
            this.Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Minimize.IconColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(765, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(28, 28);
            this.Minimize.TabIndex = 1;
            // 
            // Inject
            // 
            this.Inject.Animated = true;
            this.Inject.AutoRoundedCorners = true;
            this.Inject.BorderColor = System.Drawing.Color.Fuchsia;
            this.Inject.BorderRadius = 17;
            this.Inject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Inject.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.Inject.ForeColor = System.Drawing.Color.White;
            this.Inject.Location = new System.Drawing.Point(161, 25);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(140, 37);
            this.Inject.TabIndex = 2;
            this.Inject.Text = "Inject Client";
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // Titlebar
            // 
            this.Titlebar.BorderColor = System.Drawing.Color.Black;
            this.Titlebar.BorderThickness = 1;
            this.Titlebar.Controls.Add(this.Help);
            this.Titlebar.Controls.Add(this.InjectorLabel);
            this.Titlebar.Controls.Add(this.Minimize);
            this.Titlebar.Controls.Add(this.Exit);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(830, 37);
            this.Titlebar.TabIndex = 3;
            // 
            // Help
            // 
            this.Help.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Help.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Help.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Help.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Help.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.Color.White;
            this.Help.Location = new System.Drawing.Point(731, 3);
            this.Help.Name = "Help";
            this.Help.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Help.Size = new System.Drawing.Size(28, 28);
            this.Help.TabIndex = 10;
            this.Help.Text = "?";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // InjectorLabel
            // 
            this.InjectorLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InjectorLabel.ForeColor = System.Drawing.Color.White;
            this.InjectorLabel.Location = new System.Drawing.Point(3, 3);
            this.InjectorLabel.Name = "InjectorLabel";
            this.InjectorLabel.Size = new System.Drawing.Size(168, 33);
            this.InjectorLabel.TabIndex = 2;
            this.InjectorLabel.Text = "Faded Injector";
            this.InjectorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientList
            // 
            this.ClientList.BackColor = System.Drawing.Color.Transparent;
            this.ClientList.BorderColor = System.Drawing.Color.Fuchsia;
            this.ClientList.BorderRadius = 6;
            this.ClientList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ClientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ClientList.ForeColor = System.Drawing.Color.White;
            this.ClientList.ItemHeight = 30;
            this.ClientList.Items.AddRange(new object[] {
            "Horion",
            "Packet",
            "Onix",
            "NG",
            "Fadeaway (1.16.201)",
            "Fadeaway (1.17.11)"});
            this.ClientList.Location = new System.Drawing.Point(16, 26);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(220, 36);
            this.ClientList.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ClientList.TabIndex = 4;
            this.ClientList.SelectedIndexChanged += new System.EventHandler(this.ClientList_SelectedIndexChanged);
            // 
            // SelectDLL
            // 
            this.SelectDLL.Animated = true;
            this.SelectDLL.AutoRoundedCorners = true;
            this.SelectDLL.BorderColor = System.Drawing.Color.Fuchsia;
            this.SelectDLL.BorderRadius = 17;
            this.SelectDLL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectDLL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectDLL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectDLL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectDLL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SelectDLL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.SelectDLL.ForeColor = System.Drawing.Color.White;
            this.SelectDLL.Location = new System.Drawing.Point(20, 25);
            this.SelectDLL.Name = "SelectDLL";
            this.SelectDLL.Size = new System.Drawing.Size(140, 37);
            this.SelectDLL.TabIndex = 5;
            this.SelectDLL.Text = "Select DLL";
            this.SelectDLL.Click += new System.EventHandler(this.SelectDLL_Click);
            // 
            // AutoInject
            // 
            this.AutoInject.BackColor = System.Drawing.Color.Transparent;
            this.AutoInject.Checked = true;
            this.AutoInject.CheckedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.AutoInject.CheckedState.BorderRadius = 2;
            this.AutoInject.CheckedState.BorderThickness = 0;
            this.AutoInject.CheckedState.FillColor = System.Drawing.Color.Fuchsia;
            this.AutoInject.ForeColor = System.Drawing.Color.White;
            this.AutoInject.Location = new System.Drawing.Point(12, 16);
            this.AutoInject.Name = "AutoInject";
            this.AutoInject.Size = new System.Drawing.Size(20, 20);
            this.AutoInject.TabIndex = 6;
            this.AutoInject.Text = "Auto Inject";
            this.AutoInject.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoInject.UncheckedState.BorderRadius = 2;
            this.AutoInject.UncheckedState.BorderThickness = 0;
            this.AutoInject.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoInject.Click += new System.EventHandler(this.AutoInject_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsPanel.Controls.Add(this.RpcLabel);
            this.SettingsPanel.Controls.Add(this.DiscordRpc);
            this.SettingsPanel.Controls.Add(this.AutoInjectLabel);
            this.SettingsPanel.Controls.Add(this.AutoInject);
            this.SettingsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SettingsPanel.ForeColor = System.Drawing.Color.White;
            this.SettingsPanel.Location = new System.Drawing.Point(512, 43);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.ShadowColor = System.Drawing.Color.Black;
            this.SettingsPanel.Size = new System.Drawing.Size(306, 84);
            this.SettingsPanel.TabIndex = 7;
            // 
            // RpcLabel
            // 
            this.RpcLabel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RpcLabel.ForeColor = System.Drawing.Color.White;
            this.RpcLabel.Location = new System.Drawing.Point(38, 42);
            this.RpcLabel.Name = "RpcLabel";
            this.RpcLabel.Size = new System.Drawing.Size(130, 20);
            this.RpcLabel.TabIndex = 9;
            this.RpcLabel.Text = "Discord RPC";
            this.RpcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DiscordRpc
            // 
            this.DiscordRpc.BackColor = System.Drawing.Color.Transparent;
            this.DiscordRpc.CheckedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.DiscordRpc.CheckedState.BorderRadius = 2;
            this.DiscordRpc.CheckedState.BorderThickness = 0;
            this.DiscordRpc.CheckedState.FillColor = System.Drawing.Color.Fuchsia;
            this.DiscordRpc.ForeColor = System.Drawing.Color.White;
            this.DiscordRpc.Location = new System.Drawing.Point(12, 42);
            this.DiscordRpc.Name = "DiscordRpc";
            this.DiscordRpc.Size = new System.Drawing.Size(20, 20);
            this.DiscordRpc.TabIndex = 8;
            this.DiscordRpc.Text = "Auto Inject";
            this.DiscordRpc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DiscordRpc.UncheckedState.BorderRadius = 2;
            this.DiscordRpc.UncheckedState.BorderThickness = 0;
            this.DiscordRpc.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DiscordRpc.Click += new System.EventHandler(this.DiscordRpc_Click);
            // 
            // AutoInjectLabel
            // 
            this.AutoInjectLabel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoInjectLabel.ForeColor = System.Drawing.Color.White;
            this.AutoInjectLabel.Location = new System.Drawing.Point(38, 16);
            this.AutoInjectLabel.Name = "AutoInjectLabel";
            this.AutoInjectLabel.Size = new System.Drawing.Size(130, 20);
            this.AutoInjectLabel.TabIndex = 7;
            this.AutoInjectLabel.Text = "Auto Inject DLL";
            this.AutoInjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InjectPanel
            // 
            this.InjectPanel.BackColor = System.Drawing.Color.Transparent;
            this.InjectPanel.Controls.Add(this.SelectDLL);
            this.InjectPanel.Controls.Add(this.Inject);
            this.InjectPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.InjectPanel.ForeColor = System.Drawing.Color.White;
            this.InjectPanel.Location = new System.Drawing.Point(492, 365);
            this.InjectPanel.Name = "InjectPanel";
            this.InjectPanel.ShadowColor = System.Drawing.Color.Black;
            this.InjectPanel.Size = new System.Drawing.Size(326, 88);
            this.InjectPanel.TabIndex = 8;
            // 
            // ClientsPanel
            // 
            this.ClientsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ClientsPanel.Controls.Add(this.ClientList);
            this.ClientsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientsPanel.ForeColor = System.Drawing.Color.White;
            this.ClientsPanel.Location = new System.Drawing.Point(7, 43);
            this.ClientsPanel.Name = "ClientsPanel";
            this.ClientsPanel.ShadowColor = System.Drawing.Color.Black;
            this.ClientsPanel.Size = new System.Drawing.Size(262, 88);
            this.ClientsPanel.TabIndex = 9;
            // 
            // DragTitle
            // 
            this.DragTitle.DockIndicatorTransparencyValue = 0.6D;
            this.DragTitle.TargetControl = this.Titlebar;
            this.DragTitle.UseTransparentDrag = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(830, 465);
            this.Controls.Add(this.ClientsPanel);
            this.Controls.Add(this.InjectPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.Titlebar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faded Injector";
            this.Titlebar.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.InjectPanel.ResumeLayout(false);
            this.ClientsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private Guna.UI2.WinForms.Guna2DragControl DragPanel;
        private Guna.UI2.WinForms.Guna2ShadowForm Shadow;
        private Guna.UI2.WinForms.Guna2ControlBox Minimize;
        private Guna.UI2.WinForms.Guna2Panel Titlebar;
        private System.Windows.Forms.Label InjectorLabel;
        private Guna.UI2.WinForms.Guna2Button Inject;
        private Guna.UI2.WinForms.Guna2CustomCheckBox AutoInject;
        private Guna.UI2.WinForms.Guna2Button SelectDLL;
        private Guna.UI2.WinForms.Guna2ShadowPanel SettingsPanel;
        private System.Windows.Forms.Label AutoInjectLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel InjectPanel;
        private System.Windows.Forms.Label RpcLabel;
        private Guna.UI2.WinForms.Guna2CustomCheckBox DiscordRpc;
        private Guna.UI2.WinForms.Guna2ShadowPanel ClientsPanel;
        private Guna.UI2.WinForms.Guna2CircleButton Help;
        public Guna.UI2.WinForms.Guna2ComboBox ClientList;
        private Guna.UI2.WinForms.Guna2DragControl DragTitle;
    }
}
