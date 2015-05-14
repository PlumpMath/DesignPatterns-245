namespace VisitorPattern
{
    public interface ReviewerVisitor
    {
        void Review(ConsumeBill bill);
        void Review(IncomeBill bill);
    }
}