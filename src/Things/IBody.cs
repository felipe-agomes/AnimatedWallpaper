using System;
using Avalonia.Controls;

namespace AnimatedThings.src.Things;

public interface IBody
{
    double GetTop();
    double GetLeft();
    double GetWidth();
    double GetHeight();
    Control GetControl();
}
