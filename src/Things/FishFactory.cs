using System;

namespace AnimatedThings.src.Things;

public class FishFactory : IThingFactory<Fish>
{
    public Fish Create()
    {
        return new Fish();
    }
}
