
namespace skidle_md
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menucontrol = new MaterialSkin.Controls.MaterialTabControl();
            this.maintab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabcontrol = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.tabselector = new MaterialSkin.Controls.MaterialTabSelector();
            this.settinstab = new System.Windows.Forms.TabPage();
            this.icos = new System.Windows.Forms.ImageList(this.components);
            this.menuCS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prjectpanel = new System.Windows.Forms.Panel();
            this.titleproj = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new MaterialSkin.Controls.MaterialButton();
            this.createfolder = new MaterialSkin.Controls.MaterialButton();
            this.createfile = new MaterialSkin.Controls.MaterialButton();
            this.updatefolder = new MaterialSkin.Controls.MaterialButton();
            this.tabcont = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.spksite = new CefSharp.WinForms.ChromiumWebBrowser();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.menucontrol.SuspendLayout();
            this.maintab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.Home.SuspendLayout();
            this.menuCS.SuspendLayout();
            this.prjectpanel.SuspendLayout();
            this.tabcont.SuspendLayout();
            this.SuspendLayout();
            // 
            // menucontrol
            // 
            this.menucontrol.Controls.Add(this.maintab);
            this.menucontrol.Controls.Add(this.settinstab);
            this.menucontrol.Depth = 0;
            this.menucontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menucontrol.ImageList = this.icos;
            this.menucontrol.Location = new System.Drawing.Point(0, 24);
            this.menucontrol.Margin = new System.Windows.Forms.Padding(0);
            this.menucontrol.MouseState = MaterialSkin.MouseState.HOVER;
            this.menucontrol.Multiline = true;
            this.menucontrol.Name = "menucontrol";
            this.menucontrol.Padding = new System.Drawing.Point(0, 3);
            this.menucontrol.SelectedIndex = 0;
            this.menucontrol.Size = new System.Drawing.Size(770, 476);
            this.menucontrol.TabIndex = 0;
            // 
            // maintab
            // 
            this.maintab.Controls.Add(this.splitContainer1);
            this.maintab.ImageKey = "main";
            this.maintab.Location = new System.Drawing.Point(4, 23);
            this.maintab.Name = "maintab";
            this.maintab.Padding = new System.Windows.Forms.Padding(3);
            this.maintab.Size = new System.Drawing.Size(762, 449);
            this.maintab.TabIndex = 0;
            this.maintab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.prjectpanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabcontrol);
            this.splitContainer1.Panel2.Controls.Add(this.tabselector);
            this.splitContainer1.Size = new System.Drawing.Size(756, 443);
            this.splitContainer1.SplitterDistance = 159;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabcontrol
            // 
            this.tabcontrol.ContextMenuStrip = this.tabcont;
            this.tabcontrol.Controls.Add(this.Home);
            this.tabcontrol.Depth = 0;
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(0, 36);
            this.tabcontrol.Margin = new System.Windows.Forms.Padding(0);
            this.tabcontrol.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabcontrol.Multiline = true;
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(593, 407);
            this.tabcontrol.TabIndex = 2;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.spksite);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(585, 381);
            this.Home.TabIndex = 2;
            this.Home.Text = "Welcome";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // tabselector
            // 
            this.tabselector.BaseTabControl = this.tabcontrol;
            this.tabselector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabselector.Depth = 0;
            this.tabselector.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabselector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabselector.Location = new System.Drawing.Point(0, 0);
            this.tabselector.Margin = new System.Windows.Forms.Padding(0);
            this.tabselector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabselector.Name = "tabselector";
            this.tabselector.Size = new System.Drawing.Size(593, 36);
            this.tabselector.TabIndex = 1;
            this.tabselector.TabIndicatorHeight = 1;
            this.tabselector.Text = "materialTabSelector1";
            this.tabselector.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabselector_MouseClick);
            // 
            // settinstab
            // 
            this.settinstab.ImageKey = "settings";
            this.settinstab.Location = new System.Drawing.Point(4, 23);
            this.settinstab.Name = "settinstab";
            this.settinstab.Padding = new System.Windows.Forms.Padding(3);
            this.settinstab.Size = new System.Drawing.Size(762, 449);
            this.settinstab.TabIndex = 1;
            this.settinstab.UseVisualStyleBackColor = true;
            // 
            // icos
            // 
            this.icos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icos.ImageStream")));
            this.icos.TransparentColor = System.Drawing.Color.Transparent;
            this.icos.Images.SetKeyName(0, "settings");
            this.icos.Images.SetKeyName(1, "main");
            // 
            // menuCS
            // 
            this.menuCS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.folderToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuCS.Name = "menuCS";
            this.menuCS.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuCS.Size = new System.Drawing.Size(181, 92);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAllToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveAllToolStripMenuItem.Text = "Save all";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.openProjectToolStripMenuItem});
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFolderToolStripMenuItem.Text = "Open folder";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openProjectToolStripMenuItem.Text = "Open project";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redoToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // prjectpanel
            // 
            this.prjectpanel.Controls.Add(this.titleproj);
            this.prjectpanel.Controls.Add(this.createfolder);
            this.prjectpanel.Controls.Add(this.createfile);
            this.prjectpanel.Controls.Add(this.updatefolder);
            this.prjectpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.prjectpanel.Location = new System.Drawing.Point(0, 0);
            this.prjectpanel.Name = "prjectpanel";
            this.prjectpanel.Size = new System.Drawing.Size(159, 36);
            this.prjectpanel.TabIndex = 0;
            // 
            // titleproj
            // 
            this.titleproj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleproj.AutoSize = false;
            this.titleproj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleproj.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.titleproj.Depth = 0;
            this.titleproj.HighEmphasis = true;
            this.titleproj.Icon = null;
            this.titleproj.Location = new System.Drawing.Point(3, 0);
            this.titleproj.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.titleproj.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleproj.Name = "titleproj";
            this.titleproj.NoAccentTextColor = System.Drawing.Color.Empty;
            this.titleproj.Size = new System.Drawing.Size(48, 36);
            this.titleproj.TabIndex = 3;
            this.titleproj.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.titleproj.UseAccentColor = false;
            this.titleproj.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 407);
            this.panel1.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.menu.Depth = 0;
            this.menu.HighEmphasis = true;
            this.menu.Icon = global::skidle_md.Properties.Resources.icons8_menu_480;
            this.menu.Location = new System.Drawing.Point(10, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.menu.Name = "menu";
            this.menu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.menu.Size = new System.Drawing.Size(40, 24);
            this.menu.TabIndex = 1;
            this.menu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.menu.UseAccentColor = false;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // createfolder
            // 
            this.createfolder.AutoSize = false;
            this.createfolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createfolder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createfolder.Depth = 0;
            this.createfolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.createfolder.HighEmphasis = true;
            this.createfolder.Icon = global::skidle_md.Properties.Resources.icons8_opened_folder_480;
            this.createfolder.Location = new System.Drawing.Point(51, 0);
            this.createfolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createfolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.createfolder.Name = "createfolder";
            this.createfolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createfolder.Size = new System.Drawing.Size(36, 36);
            this.createfolder.TabIndex = 2;
            this.createfolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createfolder.UseAccentColor = false;
            this.createfolder.UseVisualStyleBackColor = true;
            // 
            // createfile
            // 
            this.createfile.AutoSize = false;
            this.createfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createfile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createfile.Depth = 0;
            this.createfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.createfile.HighEmphasis = true;
            this.createfile.Icon = global::skidle_md.Properties.Resources.icons8_file_480;
            this.createfile.Location = new System.Drawing.Point(87, 0);
            this.createfile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.createfile.Name = "createfile";
            this.createfile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createfile.Size = new System.Drawing.Size(36, 36);
            this.createfile.TabIndex = 1;
            this.createfile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createfile.UseAccentColor = false;
            this.createfile.UseVisualStyleBackColor = true;
            this.createfile.Click += new System.EventHandler(this.createfile_Click);
            // 
            // updatefolder
            // 
            this.updatefolder.AutoSize = false;
            this.updatefolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updatefolder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updatefolder.Depth = 0;
            this.updatefolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.updatefolder.HighEmphasis = true;
            this.updatefolder.Icon = global::skidle_md.Properties.Resources.icons8_update_480;
            this.updatefolder.Location = new System.Drawing.Point(123, 0);
            this.updatefolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updatefolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.updatefolder.Name = "updatefolder";
            this.updatefolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updatefolder.Size = new System.Drawing.Size(36, 36);
            this.updatefolder.TabIndex = 0;
            this.updatefolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updatefolder.UseAccentColor = false;
            this.updatefolder.UseVisualStyleBackColor = true;
            // 
            // tabcont
            // 
            this.tabcont.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabcont.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.tabcont.Name = "tabcont";
            this.tabcont.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tabcont.Size = new System.Drawing.Size(158, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // spksite
            // 
            this.spksite.ActivateBrowserOnCreation = true;
            this.spksite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spksite.Location = new System.Drawing.Point(0, 0);
            this.spksite.Name = "spksite";
            this.spksite.Size = new System.Drawing.Size(585, 381);
            this.spksite.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 500);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menucontrol);
            this.DrawerAutoHide = false;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.menucontrol;
            this.DrawerUseColors = true;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MinimumSize = new System.Drawing.Size(770, 500);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.Text = "skidle";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menucontrol.ResumeLayout(false);
            this.maintab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabcontrol.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.menuCS.ResumeLayout(false);
            this.prjectpanel.ResumeLayout(false);
            this.tabcont.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl menucontrol;
        private System.Windows.Forms.TabPage maintab;
        private System.Windows.Forms.TabPage settinstab;
        private MaterialSkin.Controls.MaterialTabSelector tabselector;
        private MaterialSkin.Controls.MaterialTabControl tabcontrol;
        private System.Windows.Forms.ImageList icos;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialButton menu;
        private System.Windows.Forms.ContextMenuStrip menuCS;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel prjectpanel;
        private MaterialSkin.Controls.MaterialButton createfile;
        private MaterialSkin.Controls.MaterialButton updatefolder;
        private MaterialSkin.Controls.MaterialButton createfolder;
        private MaterialSkin.Controls.MaterialButton titleproj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip tabcont;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private CefSharp.WinForms.ChromiumWebBrowser spksite;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

