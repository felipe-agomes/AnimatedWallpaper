using System;
using System.Reflection.Metadata.Ecma335;

namespace AnimatedThings.src.Things;

public interface IThingFactory<T> where T : IThing
{
    T Create();
}
