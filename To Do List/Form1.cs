using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        List<string> todo = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            todo.Add(AddTextbox.Text);
           TodoListbox.Items.Add(AddTextbox.Text);
            AddTextbox.Clear();
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            string showtodo = string.Join("\n",todo);//got from google that makes a string which contains all the members of the arrays and lists.
            MessageBox.Show(showtodo);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            TodoListbox.Items.Remove(RemoveTextbox.Text);
            todo.Remove(RemoveTextbox.Text);
            CompletedItemListbox.Items.Add(RemoveTextbox.Text);
            RemoveTextbox.Clear();
        }

        private void RemoveAllBtn_Click(object sender, EventArgs e)
        {
            TodoListbox.Items.Clear();
            string showtodo = string.Join("\n", todo);
            CompletedItemListbox.Items.Add(showtodo);
        }
    }
}
