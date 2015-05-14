namespace BridgePattern
{
    public abstract class AbstractShape
    {
        protected DrawingImpl drawing;

        public abstract void Draw();

        protected AbstractShape(DrawingImpl drawing)
        {
            this.drawing = drawing;
        }

        protected void DrawLine(double x1, double y1, double x2, double y2)
        {
            drawing.DrawLine(x1, y1, x2, y2);
        }

        protected void DrawCircle(double x, double y, double r)
        {
            drawing.DrawCircle(x,y,r);
        }

    }
}