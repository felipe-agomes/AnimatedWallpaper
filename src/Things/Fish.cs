using System;
using System.Collections.Generic;
using Avalonia.Media;

namespace AnimatedThings.src.Things;

public class Fish : IThing
{
    private List<Body> Bodies { get; set; } = [];

    public Fish(double top, double left) {
        for (int i = 0; i < 6; i++) {
            Bodies.Add(new Body(100, 100, top, left, Brushes.White, 5));

            left = left += 50;
        }
    }

    public List<Body> GetBodies()
    {
        return Bodies;
    }

    public void ApplyGravity() {
        double gravity = 5;

        Body body = Bodies[0];

        body.SetTop(body.GetTop() + gravity);
    }
}
