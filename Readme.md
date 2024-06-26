<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128610981/23.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4154)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Rich Text Editor for WinForms - How to Remove an Empty Paragraph when Appending a Content to a Document

This example illustrates multiple methods to remove an empty paragraph when appending a content to a document in the RichEditControl (the same is applicable to the [Word Processing Document API](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditDocumentServer)).

## Implementation Details

The application form contains 4 buttons to use different approaches to complete the task.

1. The first button removes the paragraph mark (e.g., `\par` in case of RTF format) from the source content being added to a document.

2. The second buttons searches and removes paragraph marks.

3. The third button calls the [SubDocument.AppendDocumentContent](https://docs.devexpress.com/OfficeFileAPI/devexpress.xtrarichedit.api.native.subdocument.appenddocumentcontent.overloads) method because it handles this scenario automatically.

4. The last button uses the [SubDocument.Delete](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.SubDocument.Delete(DevExpress.XtraRichEdit.API.Native.DocumentRange)) method to remove empty paragraphs between tables.

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))

## More Examples

* [WinForms Rich Text Editor API – How to Process Word Documents in Code](https://github.com/DevExpress-Examples/winforms-richedit-document-api)

## Documentation

* [How to: Remove Blank Lines from a Document
](https://docs.devexpress.com/WindowsForms/10445/controls-and-libraries/rich-text-editor/examples/search-and-replace/how-to-remove-blank-lines-from-a-document)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-remove-an-empty-paragraph-when-appending-a-content&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-remove-an-empty-paragraph-when-appending-a-content&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
