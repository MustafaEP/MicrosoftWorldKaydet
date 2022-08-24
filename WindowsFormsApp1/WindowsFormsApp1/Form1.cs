using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object documantFinal = "\\endofdoc";

            word.Application creat;
            word.Document document;

            creat = new word.Application();
            creat.Visible = true;

            document = creat.Documents.Add(ref oMissing);

            word.Paragraph name;
            name = document.Content.Paragraphs.Add(ref oMissing);
            name.Range.Text = "Ad: " + tbxName.Text;
            name.Format.SpaceAfter = 10;
            name.Range.InsertParagraphAfter();

            word.Paragraph surname;
            object orng = document.Bookmarks.get_Item(ref documantFinal).Range;
            surname = document.Content.Paragraphs.Add(ref orng);
            surname.Range.Text = "Soyad: " + tbxSurname.Text;
            surname.Format.SpaceAfter = 10;
            surname.Range.InsertParagraphAfter();

            word.Paragraph age;
            orng = document.Content.Bookmarks.get_Item(ref documantFinal).Range;
            age = document.Content.Paragraphs.Add(ref orng);
            age.Range.Text = "Yaş: " + tbxAge.Text;
            age.Format.SpaceAfter = 10;
            age.Range.InsertParagraphAfter();

            word.Paragraph city;
            orng = document.Content.Bookmarks.get_Item(ref documantFinal).Range;
            city = document.Content.Paragraphs.Add(ref orng);
            city.Range.Text = "Şehir: " + cbxCity.Text;
            city.Format.SpaceAfter = 10;
            city.Range.InsertParagraphAfter();

            word.Paragraph tel;
            orng = document.Content.Bookmarks.get_Item(ref documantFinal).Range;
            tel = document.Content.Paragraphs.Add(ref orng);
            tel.Range.Text = "Tel: " + tbxTelNumber.Text;
            tel.Format.SpaceAfter = 10;
            tel.Range.InsertParagraphAfter();

            word.Paragraph job;
            orng = document.Content.Bookmarks.get_Item(ref documantFinal).Range;
            job = document.Content.Paragraphs.Add(ref orng);
            job.Range.Text = "Meslek: " + tbxJob.Text;
            job.Format.SpaceAfter = 10;
            job.Range.InsertParagraphAfter();

        }
    }
}
