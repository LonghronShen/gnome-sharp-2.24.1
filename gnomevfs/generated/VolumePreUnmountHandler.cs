// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome.Vfs {

	using System;

	public delegate void VolumePreUnmountHandler(object o, VolumePreUnmountArgs args);

	public class VolumePreUnmountArgs : GLib.SignalArgs {
		public Gnome.Vfs.Volume Volume{
			get {
				return (Gnome.Vfs.Volume) Args [0];
			}
		}

	}
}
