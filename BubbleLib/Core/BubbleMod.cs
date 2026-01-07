using AurieSharpInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleLib.Core
{
    public abstract class BubbleMod
    {
        public AurieManagedModule Module { get; }

        public abstract string Name { get; }

        protected BubbleMod(AurieManagedModule module)
        {
            Module = module;
        }

        public abstract void Initialize();

        public virtual void Update(double dt) { }

        public virtual void DrawGUI() { }

        //TODO: Implement functionality
        public virtual void Draw() {}
    }
}
