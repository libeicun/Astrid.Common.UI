using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrid.Common.UI {
    public partial class TextDisplay : UserControl {
        public TextDisplay() {
            InitializeComponent();
        }

        public override Color ForeColor {
            get {
                return rtxt.ForeColor;
            }
            set {
                rtxt.ForeColor = value;
            }
        }
        public override Color BackColor {
            get {
                return rtxt.BackColor;
            }
            set {
                rtxt.BackColor = value;
            }
        }

        public void AppendLine(string str) {
            AppendLine(str, Color.Green, Color.Black);
        }
        public void AppendLine(string str, Color foreColor, Color backColor) {
            rtxt.AppendText(str);
            rtxt.AppendText("\r\n");
            ForeColor = foreColor;
            BackColor = backColor;
        }
    }
}
