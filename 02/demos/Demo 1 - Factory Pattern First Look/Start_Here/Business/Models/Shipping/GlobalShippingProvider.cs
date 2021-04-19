namespace Start_Here.Business.Models.Shipping
{
    public class GlobaExpresslShippingProvider : ShippingProvider
    {
        public override string GenerateShippingLabelFor(Order order)
        {
            return "GLOBAL-EXPRESS";
        }
        
    }
}