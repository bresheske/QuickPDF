<h1>QuickPDF</h1>
========

<p>Very small C# console tool to create multi-page PDF documents out of images.  </p>

<p>This project uses <strong><a href="http://www.nuget.org/packages/PDFsharp/">PDFSharp</a></strong>, please show them some support!</p>
<p>Author: <a href="http://twitter.com/bresheske">@bresheske</a></p>

<h2>Usage</h2>
========
<p>Your first argument is the output PDF file. The remaining arguments is a list of images. This list may include 
	both relative and absolute paths.</p>
<p>Quick example:</p>
<pre>
QuickPDF.Console.exe samplepdf.pdf imageone.png imagetwo.jpg imagethree.jpeg
</pre>
<p>I highly suggest using <a href="http://resheske.net/docs/dos-console-customization">doskey macros.</a></p>