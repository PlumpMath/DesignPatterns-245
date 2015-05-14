namespace BridgePattern
{
    public interface DrawingImpl
    {
        void DrawLine(double x1, double y1, double x2, double y2);
        void DrawCircle(double x, double y, double r);
    }
}