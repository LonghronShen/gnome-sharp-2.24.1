// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public struct UIBuilderData {

		private GnomeSharp.UISignalConnectFuncNative connect_func;
		public Gnome.UISignalConnectFunc ConnectFunc {
			get {
				return GnomeSharp.UISignalConnectFuncWrapper.GetManagedDelegate (connect_func);
			}
		}
		private IntPtr _data;
		public bool IsInterp;
		private GtkSharp.CallbackMarshalNative relay_func;
		public Gtk.CallbackMarshal RelayFunc {
			get {
				return GtkSharp.CallbackMarshalWrapper.GetManagedDelegate (relay_func);
			}
		}
		private GtkSharp.DestroyNotifyNative destroy_func;
		public Gtk.DestroyNotify DestroyFunc {
			get {
				return GtkSharp.DestroyNotifyWrapper.GetManagedDelegate (destroy_func);
			}
		}

		public static Gnome.UIBuilderData Zero = new Gnome.UIBuilderData ();

		public static Gnome.UIBuilderData New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gnome.UIBuilderData.Zero;
			return (Gnome.UIBuilderData) Marshal.PtrToStructure (raw, typeof (Gnome.UIBuilderData));
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}