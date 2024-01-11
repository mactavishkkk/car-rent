namespace CarRent.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment()
        {
            return BasicPayment + Tax;
        }

        public override string ToString()
        {
            return "Basic payment: " + BasicPayment.ToString("F2")
                + "\nTax: " + Tax.ToString("F2")
                + "\nTotal payment: " + TotalPayment().ToString("F2");
        }
    }
}
