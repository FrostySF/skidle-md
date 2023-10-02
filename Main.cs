using System;
using MaterialSkin.Controls;
using System.Windows.Forms;
using MaterialSkin;
using System.Drawing;
using System.IO;
using skidle_md.Libs;

namespace skidle_md
{
    public partial class Main : MaterialForm
    {
        HighLighting highLighting = new HighLighting();
        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Point screenPoint = menu.PointToScreen(new Point(menu.Left, menu.Bottom));
            if (screenPoint.Y + menuCS.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                menuCS.Show(menu, new Point(0, -menuCS.Size.Height));
            }
            else
            {
                menuCS.Show(menu, new Point(0, menu.Height));
            }
        }

        private void createfile_Click(object sender, EventArgs e)
        {
            CreateTab();
        }

        private void tabselector_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.tabcont.Show(this.tabselector, e.Location);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabcontrol.TabPages.Count <= 1)
            {
                CreateTab();
                tabcontrol.TabPages.Remove(tabcontrol.SelectedTab);
            }
            else
            {
                tabcontrol.TabPages.Remove(tabcontrol.SelectedTab);
            }
            tabcontrol.SelectTab(tabcontrol.TabCount - 1);
            //MessageBox.Show(tabcontrol.TabCount.ToString());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                CreateTab(ofd.FileName);
            }
        }

        private void CreateTab(string path)
        {
            
            try
            {
                FileInfo info = new FileInfo(path);
                TabCode tc = new TabCode();
                tc.BackColor = BackColor;
                tc.Text = info.Name;
                tc.Name = info.FullName;
                tc.fctb.OpenFile(info.FullName);
                tabcontrol.TabPages.Add(tc);
                tabcontrol.SelectedTab = tc;
                tc.fctb.TextChangedDelayed += new EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(highLighting._HighLighting);
            }
            catch
            {
                TabCode tc = new TabCode();
                tc.BackColor = BackColor;
                tc.Text = "new";
                tabcontrol.TabPages.Add(tc);
                tabcontrol.SelectedTab = tc;
                tc.fctb.TextChangedDelayed += new EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(highLighting._HighLighting);
            }
        }

        private void CreateTab()
        {
            CreateTab("none");
        }

        private void Save(TabCode tab)
        {
            var fctb = tab;
            try
            {
                fctb.fctb.SaveToFile(fctb.Name, System.Text.Encoding.UTF8);
            }
            catch
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fctb.fctb.SaveToFile(sfd.FileName, System.Text.Encoding.UTF8);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save((TabCode)tabcontrol.SelectedTab);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fctb = (TabCode)tabcontrol.SelectedTab;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fctb.fctb.SaveToFile(sfd.FileName, System.Text.Encoding.UTF8);
            }
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var tab in tabcontrol.TabPages)
                Save((TabCode)tab);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var tab in tabcontrol.TabPages)
                Save((TabCode)tab);
            Application.Exit();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fctb = (TabCode)tabcontrol.SelectedTab;
            fctb.fctb.Redo();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fctb = (TabCode)tabcontrol.SelectedTab;
            fctb.fctb.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fctb = (TabCode)tabcontrol.SelectedTab;
            fctb.fctb.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fctb = (TabCode)tabcontrol.SelectedTab;
            fctb.fctb.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fctb = (TabCode)tabcontrol.SelectedTab;
            fctb.fctb.Paste();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            spksite.Load("https://frostysf.github.io/SpecialKeySite");
        }
    }
}
