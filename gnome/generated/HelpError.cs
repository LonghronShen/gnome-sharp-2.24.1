// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gnome.HelpErrorGType))]
	public enum HelpError {

		Internal,
		NotFound,
	}

	internal class HelpErrorGType {
		[DllImport ("gnome-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_help_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gnome_help_error_get_type ());
			}
		}
	}
#endregion
}
