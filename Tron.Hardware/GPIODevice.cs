using System.Collections.Generic;

namespace Tron.Hardware
{
    public abstract class GPIODevice<T>
    where T :IDictionary<string, IGPIO>
    {
    }
}