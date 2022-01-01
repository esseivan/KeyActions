using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyActions
{
    public class Macro
    {
        public Keys Keys { get; set; } = Keys.None;
        public Keys Modifiers { get; set; } = Keys.None;

        public ActionModes ActionMode { get; set; } = ActionModes.Shortcut;

        public Keys ActionShortcut { get; set; } = Keys.None;

        public enum ActionModes
        {
            Shortcut
        }

        public Macro() { }

        public Macro(Keys keys)
        {
            this.Keys = keys;
        }

        public Macro (Keys keys, Keys modifiers)
        {
            this.Keys = keys;
            this.Modifiers = modifiers;
        }
    }
}
