using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build4Performance
{
    class BuildContainer
    {
        private Build[] builds { get; set; }
        public int buildCount { get; private set; }

        public BuildContainer(int size)
        {
            builds = new Build[size];
        }
        public void AddBuild(Build build)
        {
            builds[buildCount++] = build;
        }
        public Build GetBuild(int idx)
        {
            return builds[idx];
        }
    }
}
