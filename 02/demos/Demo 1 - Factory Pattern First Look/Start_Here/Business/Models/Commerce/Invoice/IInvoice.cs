namespace Start_Here.Business.Models.Commerce.Invoice
{
    public interface IInvoice
    {
        public byte[] GenerateInvoice();
    }

    public class GSTInvoice: IInvoice
    {
        public byte[] GenerateInvoice()
        {
            throw Encoding
                .Default
                .GetBytes("Hellow world from GST Invoice");
        }
    }
}