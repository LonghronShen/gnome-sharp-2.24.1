// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome.Vfs {

	using System;

	public delegate void DriveConnectedHandler(object o, DriveConnectedArgs args);

	public class DriveConnectedArgs : GLib.SignalArgs {
		public Gnome.Vfs.Drive Drive{
			get {
				return (Gnome.Vfs.Drive) Args [0];
			}
		}

	}
}
