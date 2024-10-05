using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;

namespace AnimatedThings.src.Shapes;

public class ControlBuilder
{
    public List<Ellipse> createFish() {
        const int FISH_QTD_ELLIPSE = 10;

        List<Ellipse> ellipses = [];

        for (int i = 0; i < FISH_QTD_ELLIPSE; i++) {
            ellipses.Add(new Ellipse {
                Stroke = Brushes.White,
                StrokeThickness = 5,
                Width = 100,
                Height = 100
            });
        }

        return ellipses;
    }
}
