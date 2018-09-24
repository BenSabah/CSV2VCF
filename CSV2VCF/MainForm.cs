using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Collections.Generic;

namespace CSV2VCF
{

    public partial class MainForm : Form
    {
        // default settings
        int m_indexOfName = 0;
        int m_indexOfNumber = 1;
        string[][] m_tableData;

        public MainForm(string[][] i_data)
        {

            InitializeComponent();
            if (i_data != null) { updateTableData(i_data); }
            var windowClipboardManager = new ClipboardManager(this);
            windowClipboardManager.ClipboardChanged += ClipboardChanged;
        }

        private void ClipboardChanged(object sender, EventArgs e)
        {
            // Handle your clipboard update here, debug logging example:
            if (Clipboard.ContainsText())
            {
                Debug.WriteLine(Clipboard.GetText());
            }
        }



        private void Button_CSVLoading_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select CSV File";
            theDialog.Filter = "CSV files|*.csv";

            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string path = theDialog.FileName;
                Utils.ReadCsvFileAs2dArray(path, out string[][] data);
                TextBox_CsvFilePath_.Text = path;

                updateSelectors(data[0]);
                updateTableData(data);

                ComboBox_Name.SelectedIndex = m_indexOfName;
                comboBox_Number.SelectedIndex = m_indexOfNumber;

                Button_CreateVCF.Enabled = true;
            }
        }

        private void Button_CreateVCF_Click(object sender, EventArgs e)
        {
            string path = TextBox_CsvFilePath_.Text;
            string outputPath = path.Substring(0, path.LastIndexOf('.'));
            bool mergeToSingleFile = Checkbox_MergeVCFs.Checked;

            if (mergeToSingleFile)
            {
                path += ".vcf";
            }

            VcfObject[] VCFs = convertTableToVcfObjects(m_tableData);
            string result = "";

            try
            {
                bool operationSuccefull = VcfHandler.VcfMaker(outputPath, VCFs, mergeToSingleFile);

                if (operationSuccefull)
                {
                    if (mergeToSingleFile)
                    {
                        result = "Created VCF file:\n" + outputPath;
                        MessageBox.Show(result, "Operation Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        result = "Created VCF files in:\n" + outputPath;
                        MessageBox.Show(result, "Operation Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show(result, "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                result = Utils.flattenedException(ex);
                MessageBox.Show(result, "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Trace.WriteLine(result);
        }

        private void updateSelectors(string[] i_dropdownChoices)
        {
            ComboBox_Name.Items.Clear();
            ComboBox_Name.Items.AddRange(i_dropdownChoices);
            comboBox_Number.Items.Clear();
            comboBox_Number.Items.AddRange(i_dropdownChoices);
        }

        private void updateTableData(string[][] i_data)
        {
            clearDataGridViewRow();
            this.m_tableData = i_data;

            for (int y = 0; y < m_tableData.Length; y++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView_ClipboardData);

                for (int x = 0; x < m_tableData[y].Length; x++)
                {
                    try
                    {
                        row.Cells[x].Value = m_tableData[y][x];
                    }
                    catch (Exception)
                    {
                    }
                }

                dataGridView_ClipboardData.Rows.Add(row);
            }

            Button_CreateVCF.Enabled = true;
        }

        private void clearDataGridViewRow()
        {
            dataGridView_ClipboardData.DataSource = null;
            dataGridView_ClipboardData.Rows.Clear();
        }

        private VcfObject[] convertTableToVcfObjects(string[][] data)
        {
            int lines = data.GetUpperBound(0);
            VcfObject[] VCFs = new VcfObject[data.Length];

            for (int i = 0; i < lines; i++)
            {
                VCFs[i] = new VcfObject(data[i][0], data[i][1]);
            }

            return VCFs;
        }

        private Boolean needToUpdateTable = true;

        private void ComboBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Name.SelectedIndex != m_indexOfName)
            {

                // if selected the other row.
                if (needToUpdateTable && ComboBox_Name.SelectedIndex == comboBox_Number.SelectedIndex)
                {
                    needToUpdateTable = false;
                    comboBox_Number.SelectedIndex = m_indexOfName;
                }

                Utils.SwapColumns(m_tableData, m_indexOfName, ComboBox_Name.SelectedIndex);
                m_indexOfName = ComboBox_Name.SelectedIndex;
                if (needToUpdateTable) { updateTableData(m_tableData); }
                needToUpdateTable = true;
            }
        }

        private void comboBox_Number_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Number.SelectedIndex != m_indexOfNumber)
            {
                // if selected the other row.
                if (needToUpdateTable && comboBox_Number.SelectedIndex == ComboBox_Name.SelectedIndex)
                {
                    needToUpdateTable = false;
                    ComboBox_Name.SelectedIndex = m_indexOfNumber;
                }

                Utils.SwapColumns(m_tableData, m_indexOfNumber, comboBox_Number.SelectedIndex);
                m_indexOfNumber = comboBox_Number.SelectedIndex;
                if (needToUpdateTable) { updateTableData(m_tableData); }
                needToUpdateTable = true;
            }
        }
    }
}
