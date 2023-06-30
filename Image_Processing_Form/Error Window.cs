using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Form
{
    public partial class Error_Window : Form
    {
        public string message { get; set; }
        public MessageType DialogMessageType { get; set; }

        public enum MessageType
        {
            Information,
            Warning,
            Error
        }

        public Error_Window()
        {
            InitializeComponent();
        }

        //will need some change
        private void Error_Window_Load(object sender, EventArgs e)
        {
            label1.Text = this.message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
