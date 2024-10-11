using System;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;

namespace AnimatedThings.src.Things;

public class Body : IBody
{
    private Control control;
    private double Top {get; set;}
    private double Left {get; set;}
    private double Width {get; set;}
    private double Height {get; set;}

    public Body(double width, double height, double top, double left, IBrush brush, double strokeThickness)
    {
        this.Width = width;
        this.Height = height;
        this.Top = top;
        this.Left = left;
        control = new Ellipse { Width = width, Height = height, Stroke = brush, StrokeThickness = strokeThickness };
    }

    public Control GetControl()
    {
        return control;
    }

    public double GetLeft()
    {
        return Left;
    }

    public double GetTop()
    {
        return Top;
    }

    public void SetTop(double top) {
        Top = top;
    }

    public double GetWidth()
    {
        return Width;
    }

    public double GetHeight() {
        return Height;
    }
}
