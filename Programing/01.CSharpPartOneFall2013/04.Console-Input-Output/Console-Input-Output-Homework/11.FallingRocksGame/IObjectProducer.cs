using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.FallingRocksGame
{
    public interface IObjectProducer
    {
        IEnumerable<GameObject> ProduceObjects();
    }
}
