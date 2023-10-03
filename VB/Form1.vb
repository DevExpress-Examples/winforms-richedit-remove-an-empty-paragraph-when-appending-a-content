Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditEmptyParagraph

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            richEditControl1.CreateCommand(RichEditCommandId.ToggleShowWhitespace).Execute()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.BeginUpdate()
            RemoveParFromSourceRtf()
            richEditControl1.EndUpdate()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.BeginUpdate()
            RemoveParViaFindReplace()
            richEditControl1.EndUpdate()
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            AppendDocumentContent()
        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl1.BeginUpdate()
            RemoveParViaDelete()
            richEditControl1.EndUpdate()
        End Sub

        Private Sub RemoveParFromSourceRtf()
            Dim sourceRtfText As String = File.ReadAllText("sample1.rtf")
            Dim modifiedRtfText As String = sourceRtfText
            Dim lastParIndex As Integer = sourceRtfText.LastIndexOf("\par")
            If lastParIndex <> -1 Then modifiedRtfText = sourceRtfText.Remove(lastParIndex, 4)
            richEditControl1.Document.AppendRtfText(modifiedRtfText)
        End Sub

        Private Sub RemoveParViaFindReplace()
            richEditControl1.Document.AppendRtfText(File.ReadAllText("sample1.rtf"))
            Dim par As DocumentRange() = richEditControl1.Document.FindAll(Microsoft.VisualBasic.Constants.vbCr, SearchOptions.None)
            If par.Length > 0 Then richEditControl1.Document.Replace(par(par.Length - 1), String.Empty)
        End Sub

        Private Sub AppendDocumentContent()
            richEditControl1.Document.AppendDocumentContent("sample1.rtf", DocumentFormat.Rtf)
        End Sub

        Private Sub RemoveParViaDelete()
            richEditControl1.LoadDocument("sample2.rtf")
            Dim document As Document = richEditControl1.Document
            Dim range As DocumentRange = document.CreateRange(document.Tables(0).Range.End, document.Tables(1).Range.Start.ToInt() - document.Tables(0).Range.End.ToInt())
            If Equals(document.GetText(range).Trim(), String.Empty) Then document.Delete(range)
        End Sub

        Private Sub ClearDocument()
            richEditControl1.CreateNewDocument()
        End Sub
    End Class
End Namespace
