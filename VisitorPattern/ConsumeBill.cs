namespace VisitorPattern
{
    public class ConsumeBill:Bill
    {
        public double Expense { get; set; }

        public void Accept(ReviewerVisitor reviewerVisitor)
        {
            reviewerVisitor.Review(this);
        }
    }
}