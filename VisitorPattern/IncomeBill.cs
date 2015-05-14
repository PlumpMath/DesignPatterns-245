namespace VisitorPattern
{
    public class IncomeBill:Bill
    {

        public double IncomeBeforeTax { get; set; }
        public double IncomeAfterTax { get; set; }
        public void Accept(ReviewerVisitor reviewerVisitor)
        {
            reviewerVisitor.Review(this);
        }
    }
}