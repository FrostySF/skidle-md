using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using skidle_md.Libs;

namespace skidle_md
{
    public partial class TabCode : System.Windows.Forms.TabPage
    {
        HighLighting highLighting = new HighLighting();
        public TabCode()
        {
            InitializeComponent();
            this.fctb.TextChangedDelayed += new EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(highLighting._HighLighting);
        }

        public TabCode(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.fctb.TextChangedDelayed += new EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(highLighting._HighLighting);
        }
    }
}
