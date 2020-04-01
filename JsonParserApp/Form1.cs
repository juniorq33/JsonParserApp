using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonParserApp
{
    public partial class JsonApp : Form
    {
        public JsonApp()
        {
            InitializeComponent();
        }

        #region UI events

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            textDebugger.Text = textInput.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDebugger.Text = string.Empty;
        }

        #endregion
    }
}
