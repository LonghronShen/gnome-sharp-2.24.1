// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;

	public delegate void BackClickedHandler(object o, BackClickedArgs args);

	public class BackClickedArgs : GLib.SignalArgs {
		public Gtk.Widget Druid{
			get {
				return (Gtk.Widget) Args [0];
			}
		}

	}
}