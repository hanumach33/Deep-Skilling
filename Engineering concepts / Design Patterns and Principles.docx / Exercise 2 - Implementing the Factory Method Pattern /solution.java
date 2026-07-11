interface Document
{
    void open();
}

class WordDocument implements Document
{
    public void open()
    {
        System.out.println("Word Document Opened");
    }
}

class PdfDocument implements Document
{
    public void open()
    {
        System.out.println("PDF Document Opened");
    }
}

class ExcelDocument implements Document
{
    public void open()
    {
        System.out.println("Excel Document Opened");
    }
}

abstract class DocumentFactory
{
    public abstract Document createDocument();
}

class WordDocumentFactory extends DocumentFactory
{
    public Document createDocument()
    {
        return new WordDocument();
    }
}

class PdfDocumentFactory extends DocumentFactory
{
    public Document createDocument()
    {
        return new PdfDocument();
    }
}

class ExcelDocumentFactory extends DocumentFactory
{
    public Document createDocument()
    {
        return new ExcelDocument();
    }
}

public class Main
{
    public static void main(String[] args)
    {
        DocumentFactory wordFactory = new WordDocumentFactory();
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        DocumentFactory excelFactory = new ExcelDocumentFactory();

        Document word = wordFactory.createDocument();
        Document pdf = pdfFactory.createDocument();
        Document excel = excelFactory.createDocument();

        word.open();
        pdf.open();
        excel.open();
    }
}
