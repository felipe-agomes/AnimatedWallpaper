using System;
using AnimatedThings.src.Things;
using Avalonia.Controls;

namespace AnimatedThings.src.Canvaz;

public class CanvasService
{
    private Canvas _canvas;
    public CanvasService(Canvas canvas)
    {
        this._canvas = canvas;
    }
    public void InsertBody(IBody body)
    {
        // TODO: Ajustar a duplicacao de codigo
        double width = body.GetWidth();
        double heign = body.GetHeight();
        double top = body.GetTop();
        double left = body.GetLeft();

        double centerTop = top - heign / 2;
        double centerLeft = left - width / 2;

        Control control = body.GetControl();
        Canvas.SetTop(control, centerTop);
        Canvas.SetLeft(control, centerLeft);

        this._canvas.Children.Add(control);
    }

    public void UpdateBody(IBody body)
    {
        // TODO: Ajustar a duplicacao de codigo
        double width = body.GetWidth();
        double heign = body.GetHeight();
        double top = body.GetTop();
        double left = body.GetLeft();

        double centerTop = top - heign / 2;
        double centerLeft = left - width / 2;

        Control control = body.GetControl();
        Canvas.SetTop(control, centerTop);
        Canvas.SetLeft(control, centerLeft);
    }
}
