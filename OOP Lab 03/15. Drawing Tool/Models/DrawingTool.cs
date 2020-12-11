namespace FigureDrawing.Models
{
    public class DrawingTool
    {
        public IDrawable FigureToDraw { get; }

        public DrawingTool(IDrawable figure) => FigureToDraw = figure;

        public void DrawFigure() => FigureToDraw?.Draw();
    }
}
