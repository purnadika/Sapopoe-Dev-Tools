using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XTools__purnadika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabPage2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listSelectedFiles.Items.Count.Equals(0))
                {
                    MessageBox.Show("No file(s) selected", "Warning", MessageBoxButtons.OK);
                    return;
                }
                if (string.IsNullOrEmpty(tbKeyTextAuto.Text))
                {
                    MessageBox.Show("Key text is empty", "Warning", MessageBoxButtons.OK);
                    return;
                }
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Select the mode first", "Warning", MessageBoxButtons.OK);
                    return;
                }
                if (checkBox1.Checked)
                {
                    if (string.IsNullOrEmpty(tbTarget.Text))
                    {
                        MessageBox.Show("Target text cannot empty", "Warning", MessageBoxButtons.OK);
                        return;
                    }
                }
                bool isRemoveMode = radioButton1.Checked;
                progressBar1.Value = 0;
                progressBar1.Maximum = openFileDialog1.FileNames.Length;
                foreach (var file in openFileDialog1.FileNames)
                {
                    var newFile = Path.GetTempFileName();
                    var linesToKeep = File.ReadLines(file).Where(l => isRemoveMode ? l.Contains(tbKeyTextAuto.Text) : !l.Contains(tbKeyTextAuto.Text));
                    if (cbRemoveEmptyLine.Checked)
                    {
                        linesToKeep = linesToKeep.Where(x => !string.IsNullOrEmpty(x));
                    }
                    if (cbExtraTabsSpaces.Checked)
                    {
                        linesToKeep = linesToKeep.Select(x => x.Trim());
                    }
                    if (cbDuplicate.Checked)
                    {
                        linesToKeep = linesToKeep.Distinct();
                    }
                    if (checkBox1.Checked)
                    {
                        linesToKeep = linesToKeep.Select(x => x.Replace(tbTarget.Text, tbWith.Text));
                    }

                    File.WriteAllLines(newFile, linesToKeep);

                    File.Delete(file);
                    File.Move(newFile, file);
                    progressBar1.Value += 1;
                }
                if (progressBar1.Value.Equals(progressBar1.Maximum))
                {
                    MessageBox.Show("Task completed successfully", "Completed", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Some task failed successfully", "Warning", MessageBoxButtons.OK);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void listAllFiles(object sender, CancelEventArgs e)
        {
            listSelectedFiles.Items.Clear();
            progressBar2.Value = 0;
            progressBar2.Maximum = openFileDialog1.FileNames.Length;
            if (openFileDialog1.CheckFileExists)
            {
                foreach (var file in openFileDialog1.FileNames)
                {
                    if (!string.IsNullOrEmpty(file))
                    {
                        listSelectedFiles.Items.Add(file);
                        progressBar2.Value += 1;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listSelectedFiles.Items.Clear();
            progressBar1.Value = 0;
            progressBar2.Value = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }
    }
}
