// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gnome.IconListModeGType))]
	public enum IconListMode {

		Icons,
		TextBelow,
		TextRight,
	}

	internal class IconListModeGType {
		[DllImport ("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_icon_list_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gnome_icon_list_mode_get_type ());
			}
		}
	}
#endregion
}
