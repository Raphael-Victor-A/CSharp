using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestorDeLista
{
    public partial class Form1 : Form
    {
        private Queue<string> dynamicQueue;
        public Form1()
        {
            InitializeComponent();
            dynamicQueue = new Queue<string>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItem.Text))
            {
                dynamicQueue.Enqueue(txtItem.Text);
                txtItem.Clear();
                UpdateListView();
            }
            else
            {
                MessageBox.Show("O item não pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dynamicQueue.Count > 0)
            {
                dynamicQueue.Dequeue();
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Selecione um item para remover!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dynamicQueue.Clear();
            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UpdateListView()
        {
            listView1.Items.Clear();
            foreach (var item in dynamicQueue)
            {
                listView1.Items.Add(item);
            }
        }
    }
}
