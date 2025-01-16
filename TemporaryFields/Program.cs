namespace TemporaryFields
{
    internal class InvoiceGenerator
    {
        public void GenerateInvoice()
        {
            int invoiceNumber = 12345;
            using PdfWriter pdfWriter = new PdfWriter($"Invoice_{invoiceNumber}.pdf");
            pdfWriter.Write("Invoice Content");
        }

        public void OtherMethod()
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator generator = new();
            generator.GenerateInvoice();
        }
    }
}
