// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;

	public delegate void ColorSetHandler(object o, ColorSetArgs args);

	public class ColorSetArgs : GLib.SignalArgs {
		public uint R{
			get {
				return (uint) Args [0];
			}
		}

		public uint G{
			get {
				return (uint) Args [1];
			}
		}

		public uint B{
			get {
				return (uint) Args [2];
			}
		}

		public uint A{
			get {
				return (uint) Args [3];
			}
		}

	}
}