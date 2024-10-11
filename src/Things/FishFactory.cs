using System;

namespace AnimatedThings.src.Things;

public class FishFactory : IThingFactory<Fish>
{
    private double left;
    private double top;

    public Fish Create()
    {
        return new Fish(top, left);
    }

    public void SetInitialPosition(double top, double left) {
        this.left = left;
        this.top = top;
    }
}
