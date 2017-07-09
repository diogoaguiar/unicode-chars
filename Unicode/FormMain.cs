using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicode
{
    public partial class FormMain : Form
    {
        private string character;
        private Timer timer;
        private bool timerIsActive;

        Label status;
        TextBox tb;
        Label preview;

        public FormMain()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += hideStatus;

            status = this.Controls["lb_status"] as Label;
            tb = this.Controls["tb_code"] as TextBox;
            preview = this.Controls["lb_preview"] as Label;
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (character != null)
            {
                Clipboard.SetText(character);
                timer.Stop();
                timer.Start();
                status.Visible = true;
            }
        }

        private void hideStatus(object sender, EventArgs e)
        {
            timer.Stop();
            status.Visible = false;
        }

        private void tb_code_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string stringVal = tb.Text;
                int intVal = Convert.ToInt32(stringVal, 16);
                character = Char.ConvertFromUtf32(intVal);
                preview.Text = character;
            } catch
            {
                Console.WriteLine("Failed to parse character");
                character = null;
                preview.Text = "";
            }
        }

        private void tb_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9a-fA-F]") && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
