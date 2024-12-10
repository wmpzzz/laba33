using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace laba33
{
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();
        }

        private void NoteButton_Click(object sender, EventArgs e)
        {
            string time = "\n"+Convert.ToString(DateTime.Now)+ "\n";
            
            if (File.Exists("C:\\Users\\POMAXA\\source\\repos\\laba33\\laba33\\Notes.txt"))
            {
                MessageBox.Show("Файл существует");
                File.AppendAllText("C:\\Users\\POMAXA\\source\\repos\\laba33\\laba33\\Notes.txt", time );
                File.AppendAllText("C:\\Users\\POMAXA\\source\\repos\\laba33\\laba33\\Notes.txt", NoteTextBox.Text + "\n");
                File.AppendAllText("C:\\Users\\POMAXA\\source\\repos\\laba33\\laba33\\Notes.txt", "");
            }
            else
            {
                MessageBox.Show("Файла нет");
                File.AppendAllText("C:\\Users\\POMAXA\\source\\repos\\laba33\\laba33\\Notes.txt",time);
                File.AppendAllText("C:\\Users\\POMAXA\\source\\repos\\laba33\\laba33\\Notes.txt", NoteTextBox.Text + "\n");
                File.AppendAllText("C:\\Users\\POMAXA\\source\\repos\\laba33\\laba33\\Notes.txt", "");
            }
        }
    }
}
