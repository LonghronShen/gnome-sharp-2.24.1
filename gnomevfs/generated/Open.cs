// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome.Vfs {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Open {

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_open_fd(IntPtr handle, int filedes);

		public static Gnome.Vfs.Result Fd(Gnome.Vfs.Handle handle, int filedes) {
			int raw_ret = gnome_vfs_open_fd(handle == null ? IntPtr.Zero : handle.Handle, filedes);
			Gnome.Vfs.Result ret = (Gnome.Vfs.Result) raw_ret;
			return ret;
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_open_uri(IntPtr handle, IntPtr uri, int open_mode);

		public static Gnome.Vfs.Result Uri(Gnome.Vfs.Handle handle, Gnome.Vfs.Uri uri, Gnome.Vfs.OpenMode open_mode) {
			int raw_ret = gnome_vfs_open_uri(handle == null ? IntPtr.Zero : handle.Handle, uri == null ? IntPtr.Zero : uri.Handle, (int) open_mode);
			Gnome.Vfs.Result ret = (Gnome.Vfs.Result) raw_ret;
			return ret;
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_open_uri_cancellable(IntPtr handle, IntPtr uri, int open_mode, IntPtr context);

		public static Gnome.Vfs.Result UriCancellable(Gnome.Vfs.Handle handle, Gnome.Vfs.Uri uri, Gnome.Vfs.OpenMode open_mode, Gnome.Vfs.Context context) {
			int raw_ret = gnome_vfs_open_uri_cancellable(handle == null ? IntPtr.Zero : handle.Handle, uri == null ? IntPtr.Zero : uri.Handle, (int) open_mode, context == null ? IntPtr.Zero : context.Handle);
			Gnome.Vfs.Result ret = (Gnome.Vfs.Result) raw_ret;
			return ret;
		}

#endregion
	}
}