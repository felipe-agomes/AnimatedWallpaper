using System;
using System.Collections.Generic;

namespace AnimatedThings.src.Things;

public class Fish : IThing
{
    private List<Body> Bodies { get; set; } = [];

    public Fish() {
        Bodies.Add(new Body());
    }

    public List<Body> GetBodies()
    {
        return Bodies;
    }
}
