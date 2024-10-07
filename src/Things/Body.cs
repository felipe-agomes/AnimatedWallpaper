using System;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;

namespace AnimatedThings.src.Things;

public class Body : IBody
{
    private Control control;
    private double top;
    private double left;
    private double width;
    private double height;

    public Body()
    {
        this.top = 0;
        this.left = 0;
        this.control = new Ellipse { Width = 100, Height = 100, Stroke = Brushes.White, StrokeThickness = 5 };
    }

    public Control GetControl()
    {
        return control;
    }

    public double GetLeft()
    {
        return left;
    }

    public double GetTop()
    {
        return top;
    }

    public double GetWidth()
    {
        return width;
    }

    public double GetHeight() {
        return height;
    }
}
