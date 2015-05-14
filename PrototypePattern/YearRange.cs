namespace PrototypePattern
{
    public class YearRange
    {
        public int StartYear { get; set; }
        public int EndYear { get; set; }

        public override string ToString()
        {
            return StartYear.ToString() + "-" + EndYear.ToString();
        }
    }
}