<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128610981/23.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4154)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to remove an empty paragraph when appending a content to a document


<p>This example illustrates several methods to remove an empty paragraph when appending a content to a document in the RichEditControl (the same is applicable to the <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditRichEditDocumentServertopic"><u>RichEditDocumentServer</u></a>). These methods include:</p><p>1) The most obvious solution is to remove the paragraph mark (e.g., <strong>'\par'</strong> in case of RTF format) from the source content being added to a document. </p><p>2) A more robust solution is to use built-in Search API (see the <a href="https://www.devexpress.com/Support/Center/p/E1677">Using the Search and Replace API functionality</a> and <a href="https://www.devexpress.com/Support/Center/p/E3147">Search API - An example of use</a> examples).</p><p>3) The most simple solution is to use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSubDocument_AppendDocumentContenttopic"><u>SubDocument.AppendDocumentContent Method</u></a> because generally it will handle this scenario automatically.</p><p>4) The <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSubDocument_Deletetopic"><u>SubDocument.Delete Method</u></a> is quite an effective solution when it is necessary to remove empty paragraphs between tables (e.g., see <a href="https://www.devexpress.com/Support/Center/p/Q356749">Blank Line when passing a table to docvariable</a>).</p><p>In a particular scenario you can choose a method that is most appropriate for your task.</p>

<br/>


