using System;
using System.Windows.Forms;

namespace BuggyForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            comboBox1.Items.Add("First item");
            comboBox1.Items.Add("Second item");
            comboBox1.Items.Add("Third item");
        }

        private void buttonGoClick(object sender, EventArgs e)
        {
            String textBox1 = this.textBox1.Text;
            String textBox2 = this.textBox2.Text;
            String comboBoxSelection = comboBox1.Text;
            String checkBoxStatus = checkBox1.Checked ? "Checked" : "UnChecked";
            
            richTextBox1.AppendText("textBox1: " + textBox1 +
                                    "\ntextBox2: " + textBox2 +
                                    "\nComboBox selection: " + comboBoxSelection +
                                    "\nCheckBox status: " + checkBoxStatus +
                                    "\n");
            
            tabControl.SelectTab(tabPage1);
        }

        private void buttonCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            this.textBox3.Text = "Mouse Hover";
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            this.textBox3.Clear();
        }
    }
}