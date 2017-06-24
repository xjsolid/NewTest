using TTSM2.PluginInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTSM2.Host
{
    public class PluginInfo
    {
        public PluginInfo(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public IPlugin Instance { get; set; }
        public string AssemblyPath { get; set; }
    }
}
