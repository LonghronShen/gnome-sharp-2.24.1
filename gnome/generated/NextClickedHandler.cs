// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;

	public delegate void NextClickedHandler(object o, NextClickedArgs args);

	public class NextClickedArgs : GLib.SignalArgs {
		public Gtk.Widget Druid{
			get {
				return (Gtk.Widget) Args [0];
			}
		}

	}
}
