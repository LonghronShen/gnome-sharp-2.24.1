// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gnome.EdgePositionGType))]
	public enum EdgePosition {

		Start,
		Finish,
		Other,
		Last,
	}

	internal class EdgePositionGType {
		[DllImport ("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_edge_position_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gnome_edge_position_get_type ());
			}
		}
	}
#endregion
}
