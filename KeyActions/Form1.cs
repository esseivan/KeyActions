using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyActions
{

    public partial class Form1 : Form
    {
        KeyboardHook kh;

        Keys modifiersToPress = Keys.None;
        Keys keyToPress = Keys.None;

        Keys linkedModifiersToPress = Keys.None;
        Keys linkedKeyToPress = Keys.None;

        Dictionary<string, int> keyDictionary = new Dictionary<string, int>();
        string[] keys;
        private static readonly Keys[] values = (Keys[])Enum.GetValues(typeof(Keys));

        List<Macro> savedMacros = new List<Macro>();


        // Key press simulation

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        public const int VK_RCONTROL = 0xA3; //Right Control key code

        // Key press simulation

        public Form1()
        {
            InitializeComponent();
            kh = new KeyboardHook(true);
            kh.Enabled = false;
            kh.KeyDown += Kh_KeyDown;
            kh.KeyUp += Kh_KeyUp;

            keys = Enum.GetNames(typeof(Keys));

            for (int i = 0; i < keys.Length; i++)
            {
                keyDictionary.Add(keys[i], i);
            }

            cbKeys.Items.AddRange(keys);
            cbKeys.SelectedIndex = 0;

            cbType.Items.AddRange(new string[] { "Shortcut" });
            cbType.SelectedIndex = 0;
        }

        private string KeyToString(Keys key, Keys modifiers)
        {
            string text = string.Empty;
            if (modifiers.HasFlag(Keys.LWin))
            {
                text = "Win";
            }
            if (modifiers.HasFlag(Keys.Control))
            {
                if (text != string.Empty)
                    text += " + ";
                text += "Ctrl";
            }
            if (modifiers.HasFlag(Keys.Alt))
            {
                if (text != string.Empty)
                    text += " + ";
                text += "Alt";
            }
            if (modifiers.HasFlag(Keys.Shift))
            {
                if (text != string.Empty)
                    text += " + ";
                text += "Shift";
            }

            if (key != Keys.None)
            {
                if (text != string.Empty)
                    text += " + ";
                text += key;
            }
            return text;
        }

        private void UpdateControls(Keys key, Keys modifiers, int mode)
        {
            if (mode == 1)
                tbShortcut.Text = KeyToString(key, modifiers);
            else if (mode == 2)
            {
                chbControl.Checked = chbAlt.Checked = chbShift.Checked = chbWin.Checked = false;

                if (modifiers.HasFlag(Keys.Control))
                    chbControl.Checked = true;
                if (modifiers.HasFlag(Keys.Shift))
                    chbShift.Checked = true;
                if (modifiers.HasFlag(Keys.Alt))
                    chbAlt.Checked = true;
                if (modifiers.HasFlag(Keys.LWin))
                    chbWin.Checked = true;

                cbKeys.SelectedIndex = keyDictionary[key.ToString()];
            }

        }

        private void Kh_KeyUp(Keys key, bool Shift, bool Ctrl, bool Alt)
        {

        }

        private void Kh_KeyDown(Keys key, bool Shift, bool Ctrl, bool Alt)
        {

        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kh.Enabled = !kh.Enabled;
            enableToolStripMenuItem.Text = kh.Enabled ? "Disable" : "Enable";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!cbListen.Checked && !cbListenLink.Checked)
                return;

            Console.WriteLine(e.KeyData);
            e.Handled = true;
            e.SuppressKeyPress = true;

            Keys mods = e.Modifiers;
            Keys key = e.KeyCode;

            if (e.KeyData.HasFlag(Keys.LWin))
                mods |= Keys.LWin;

            if (key == Keys.ShiftKey || key == Keys.ControlKey || key == Keys.Menu || key == Keys.LWin)
                key = Keys.None;

            if (cbListen.Checked)
            {
                keyToPress = key;
                modifiersToPress = mods;

                tbShortcut.Text = KeyToString(keyToPress, modifiersToPress);
            }
            if (cbListenLink.Checked)
            {
                linkedKeyToPress = key;
                linkedModifiersToPress = mods;

                tbShortcutLinked.Text = KeyToString(linkedKeyToPress, linkedModifiersToPress);
            }

            UpdateControls(keyToPress, modifiersToPress, 2);
        }

        private void btnListen_Click(object sender, EventArgs e)
        {

        }

        private void cbListen_CheckedChanged(object sender, EventArgs e)
        {
            cbListen.Text = (cbListen.Checked) ? "Listening..." : "Click to listen";
        }

        private void cbListenLink_CheckedChanged(object sender, EventArgs e)
        {
            cbListenLink.Text = (cbListenLink.Checked) ? "Listening..." : "Click to listen";
        }

        private Keys GetSelectedKey()
        {
            Enum.TryParse(keys[cbKeys.SelectedIndex], out Keys key);
            return key;
        }

        private Keys GetSelectedMods()
        {
            Keys mods = Keys.None;
            if (chbControl.Checked)
                mods |= Keys.Control;
            if (chbAlt.Checked)
                mods |= Keys.Alt;
            if (chbShift.Checked)
                mods |= Keys.Shift;
            if (chbWin.Checked)
                mods |= Keys.LWin;

            return mods;
        }

        private void cbWin_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbListen.Checked)
                UpdateControls(GetSelectedKey(), GetSelectedMods(), 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Macro macro = new Macro(keyToPress, modifiersToPress);
            macro.ActionShortcut = linkedKeyToPress | linkedModifiersToPress;

            savedMacros.Add(macro);
            ExecuteMacro(macro);
        }

        public static List<Keys> GetComponents(Keys value)
        {
            List<Keys> output = new List<Keys>();

            foreach (Keys item in values)
            {
                if (value.HasFlag(item))
                    output.Add(item);
            }

            output.Remove(Keys.None);

            return output;
        }

        private void ExecuteMacro(Macro macro)
        {
            switch (macro.ActionMode)
            {
                case Macro.ActionModes.Shortcut:
                    List<Keys> selectedKeys = GetComponents(macro.ActionShortcut);
                    foreach (Keys selectedKey in selectedKeys)
                    {
                        Console.WriteLine(selectedKey);
                        //keybd_event((byte)selectedKey, 0, KEYEVENTF_EXTENDEDKEY, 0);
                        
                    
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
