// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome.Vfs {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Unlink {

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_unlink_from_uri(IntPtr uri);

		public static Gnome.Vfs.Result FromUri(Gnome.Vfs.Uri uri) {
			int raw_ret = gnome_vfs_unlink_from_uri(uri == null ? IntPtr.Zero : uri.Handle);
			Gnome.Vfs.Result ret = (Gnome.Vfs.Result) raw_ret;
			return ret;
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_unlink_from_uri_cancellable(IntPtr uri, IntPtr context);

		public static Gnome.Vfs.Result FromUriCancellable(Gnome.Vfs.Uri uri, Gnome.Vfs.Context context) {
			int raw_ret = gnome_vfs_unlink_from_uri_cancellable(uri == null ? IntPtr.Zero : uri.Handle, context == null ? IntPtr.Zero : context.Handle);
			Gnome.Vfs.Result ret = (Gnome.Vfs.Result) raw_ret;
			return ret;
		}

#endregion
	}
}