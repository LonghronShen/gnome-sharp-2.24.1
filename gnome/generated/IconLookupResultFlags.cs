// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gnome.IconLookupResultFlagsGType))]
	public enum IconLookupResultFlags {

		None,
		Thumbnail = 1 << 0,
	}

	internal class IconLookupResultFlagsGType {
		[DllImport ("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_icon_lookup_result_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gnome_icon_lookup_result_flags_get_type ());
			}
		}
	}
#endregion
}