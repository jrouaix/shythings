using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyThings
{
    public class Listener : IObservable<bool>
    {
        public IDisposable Subscribe(IObserver<bool> observer)
        {
            throw new NotImplementedException();
        }
    }
}
