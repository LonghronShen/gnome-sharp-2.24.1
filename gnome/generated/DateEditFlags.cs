// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gnome.DateEditFlagsGType))]
	public enum DateEditFlags {

		ShowTime = 1 << 0,
		Two4Hr = 1 << 1,
		WeekStartsOnMonday = 1 << 2,
		DisplaySeconds = 1 << 3,
	}

	internal class DateEditFlagsGType {
		[DllImport ("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_date_edit_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gnome_date_edit_flags_get_type ());
			}
		}
	}
#endregion
}
