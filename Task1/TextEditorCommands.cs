using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task1
{
    class TextEditorCommands
    {
        public static RoutedUICommand Exit { get; set; }
        public static RoutedUICommand SetLightTheme { get; set; }
        public static RoutedUICommand SetDarkTheme { get; set; }

        static TextEditorCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(TextEditorCommands), inputs);

            SetLightTheme = new RoutedUICommand("Светлая тема", "SetLightTheme", typeof(TextEditorCommands));

            SetDarkTheme = new RoutedUICommand("Тёмная тема", "SetDarkTheme", typeof(TextEditorCommands));
        }
    }
}