using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
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
            //outputDebugger(textInput.Text);
            deserializeJson(textInput.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDebugger.Text = string.Empty;
        }

        #endregion

        #region OutputDebugger

        private void outputDebugger(string text)
        {
            try
            {
                System.Diagnostics.Debug.Write(text + Environment.NewLine);
                textDebugger.Text = textDebugger.Text + text + Environment.NewLine;
                textDebugger.SelectionStart = textDebugger.TextLength;
                textDebugger.ScrollToCaret();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }

        #endregion

        #region json functions

        private void deserializeJson(string json)
        {
            try
            {
                var deserializeObject = JsonConvert.DeserializeObject<dynamic>(json);
                outputDebugger(deserializeObject);
            }
            catch (Exception ex)
            {
                outputDebugger("ERROR: " + ex.Message.ToString());
            }
        }
        #endregion
    }
}
