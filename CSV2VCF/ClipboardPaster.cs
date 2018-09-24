using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSV2VCF
{
    public partial class ClipboardPaster : Form
    {
        List<string[]> data;

        public ClipboardPaster(List<string[]> data)
        {
            InitializeComponent();
            this.data = data;
            fillTable();
        }

        private void fillTable()
        {
            dataGridView_ClipboardData.Columns[0].HeaderText = "Name";
            dataGridView_ClipboardData.Columns[1].HeaderText = "Phone Number";

            for (int y = 0; y < data.Count; y++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView_ClipboardData);

                for (int x = 0; x < data[y].Length; x++)
                {
                    row.Cells[x].Value = data[y][x];
                }

                dataGridView_ClipboardData.Rows.Add(row);
            }
        }
    }
}
