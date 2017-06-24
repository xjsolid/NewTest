using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTSM2.PluginInterface
{
    public interface IPlugin : IDisposable
    {
        string Name { get; }
        string Description { get; }

        void Initialize();
        void Start();
    }
}
