// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;

	public delegate void FinishClickedHandler(object o, FinishClickedArgs args);

	public class FinishClickedArgs : GLib.SignalArgs {
		public Gtk.Widget Druid{
			get {
				return (Gtk.Widget) Args [0];
			}
		}

	}
}