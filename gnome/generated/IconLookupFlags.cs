// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gnome.IconLookupFlagsGType))]
	public enum IconLookupFlags {

		None,
		EmbeddingText = 1 << 0,
		ShowSmallImagesAsThemselves = 1 << 1,
		AllowSvgAsThemselves = 1 << 2,
	}

	internal class IconLookupFlagsGType {
		[DllImport ("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_icon_lookup_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gnome_icon_lookup_flags_get_type ());
			}
		}
	}
#endregion
}
