// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome.Vfs {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Create {

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_create_symbolic_link(IntPtr uri, IntPtr target_reference);

		public static Gnome.Vfs.Result SymbolicLink(Gnome.Vfs.Uri uri, string target_reference) {
			IntPtr native_target_reference = GLib.Marshaller.StringToPtrGStrdup (target_reference);
			int raw_ret = gnome_vfs_create_symbolic_link(uri == null ? IntPtr.Zero : uri.Handle, native_target_reference);
			Gnome.Vfs.Result ret = (Gnome.Vfs.Result) raw_ret;
			GLib.Marshaller.Free (native_target_reference);
			return ret;
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_create_uri(IntPtr handle, IntPtr uri, int open_mode, bool exclusive, uint perm);

		public static Gnome.Vfs.Result Uri(Gnome.Vfs.Handle handle, Gnome.Vfs.Uri uri, Gnome.Vfs.OpenMode open_mode, bool exclusive, uint perm) {
			int raw_ret = gnome_vfs_create_uri(handle == null ? IntPtr.Zero : handle.Handle, uri == null ? IntPtr.Zero : uri.Handle, (int) open_mode, exclusive, perm);
			Gnome.Vfs.Result ret = (Gnome.Vfs.Result) raw_ret;
			return ret;
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_create_uri_cancellable(IntPtr handle, IntPtr uri, int open_mode, bool exclusive, uint perm, IntPtr context);

		public static Gnome.Vfs.Result UriCancellable(Gnome.Vfs.Handle handle, Gnome.Vfs.Uri uri, Gnome.Vfs.OpenMode open_mode, bool exclusive, uint perm, Gnome.Vfs.Context context) {
			int raw_ret = gnome_vfs_create_uri_cancellable(handle == null ? IntPtr.Zero : handle.Handle, uri == null ? IntPtr.Zero : uri.Handle, (int) open_mode, exclusive, perm, context == null ? IntPtr.Zero : context.Handle);
			Gnome.Vfs.Result ret = (Gnome.Vfs.Result) raw_ret;
			return ret;
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_create_symbolic_link_cancellable(IntPtr uri, IntPtr target_reference, IntPtr context);

		public static Gnome.Vfs.Result SymbolicLinkCancellable(Gnome.Vfs.Uri uri, string target_reference, Gnome.Vfs.Context context) {
			IntPtr native_target_reference = GLib.Marshaller.StringToPtrGStrdup (target_reference);
			int raw_ret = gnome_vfs_create_symbolic_link_cancellable(uri == null ? IntPtr.Zero : uri.Handle, native_target_reference, context == null ? IntPtr.Zero : context.Handle);
			Gnome.Vfs.Result ret = (Gnome.Vfs.Result) raw_ret;
			GLib.Marshaller.Free (native_target_reference);
			return ret;
		}

#endregion
	}
}
