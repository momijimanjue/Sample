using System;
using System.Windows.Forms;

namespace HelloGUI {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            //MessageBox.Show("C#.NETプログラミング", "ようこそ", MessageBoxButtons.OKCancel);
            textBox1.AppendText("こんにちは、GUIの世界へようこそ！");

        }
    }
}
