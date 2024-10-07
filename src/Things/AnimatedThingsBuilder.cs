using System;

namespace AnimatedThings.src.Things;

public class AnimatedThingsBuilder<T> where T : IThing
{
    public T Build(IThingFactory<T> thingFactory)
    {
        return thingFactory.Create();
    }
}
