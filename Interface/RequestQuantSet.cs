using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class RequestQuantSet : Form
    {
        List<string> Sets = new List<string>();
        public string finalquant = "";
        public string finalset = "";
        public RequestQuantSet(List<string> sets)
        {
            InitializeComponent();
            Sets = sets;
        }

        private void set_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(set_combo.SelectedItem.ToString()))
            {
                finalset = set_combo.SelectedItem.ToString();
            }

        }

        private void RequestQuantSet_Load(object sender, EventArgs e)
        {
            foreach (string set in Sets)
            {
                set_combo.Items.Add(set);
            }
        }

        private void quant_txt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(quant_txt.Text))
            {
                finalquant = quant_txt.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Tuple<string, string> RunQuantSet()
        {
            this.ShowDialog();
            return new Tuple<string, string>(finalquant, finalset);
        }
    }
}
