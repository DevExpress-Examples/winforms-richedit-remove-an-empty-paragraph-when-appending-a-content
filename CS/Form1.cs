using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditEmptyParagraph {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            richEditControl1.CreateCommand(RichEditCommandId.ToggleShowWhitespace).Execute();
        }

        private void button1_Click(object sender, EventArgs e) {
            richEditControl1.BeginUpdate();
            RemoveParFromSourceRtf();
            richEditControl1.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e) {
            richEditControl1.BeginUpdate();
            RemoveParViaFindReplace();
            richEditControl1.EndUpdate();
        }

        private void button3_Click(object sender, EventArgs e) {
            AppendDocumentContent();
        }

        private void button4_Click(object sender, EventArgs e) {
            richEditControl1.BeginUpdate();
            RemoveParViaDelete();
            richEditControl1.EndUpdate();
        }

        private void RemoveParFromSourceRtf() {
            string sourceRtfText = File.ReadAllText("sample1.rtf");
            string modifiedRtfText = sourceRtfText;
            int lastParIndex = sourceRtfText.LastIndexOf(@"\par");

            if (lastParIndex != -1)
                modifiedRtfText = sourceRtfText.Remove(lastParIndex, 4);

            richEditControl1.Document.AppendRtfText(modifiedRtfText);
        }

        private void RemoveParViaFindReplace() {
            richEditControl1.Document.AppendRtfText(File.ReadAllText("sample1.rtf"));

            DocumentRange[] par = richEditControl1.Document.FindAll("\r", SearchOptions.None);

            if (par.Length > 0)
                richEditControl1.Document.Replace(par[par.Length - 1], string.Empty);
        }

        private void AppendDocumentContent() {
            richEditControl1.Document.AppendDocumentContent("sample1.rtf", DocumentFormat.Rtf);
        }

        private void RemoveParViaDelete() {
            richEditControl1.LoadDocument("sample2.rtf");

            Document document = richEditControl1.Document;
            DocumentRange range = document.CreateRange(document.Tables[0].Range.End,
                document.Tables[1].Range.Start.ToInt() - document.Tables[0].Range.End.ToInt());

            if (document.GetText(range).Trim() == string.Empty)
                document.Delete(range);
        }       
        
        private void ClearDocument() {
            richEditControl1.CreateNewDocument();
        }
    }
}