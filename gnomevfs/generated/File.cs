// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome.Vfs {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class File {

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_file_control(IntPtr handle, IntPtr operation, IntPtr operation_data);

		public static Gnome.Vfs.Result Control(Gnome.Vfs.Handle handle, string operation, IntPtr operation_data) {
			IntPtr native_operation = GLib.Marshaller.StringToPtrGStrdup (operation);
			int raw_ret = gnome_vfs_file_control(handle == null ? IntPtr.Zero : handle.Handle, native_operation, operation_data);
			Gnome.Vfs.Result ret = (Gnome.Vfs.Result) raw_ret;
			GLib.Marshaller.Free (native_operation);
			return ret;
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_file_control_cancellable(IntPtr handle, IntPtr operation, IntPtr operation_data, IntPtr context);

		public static Gnome.Vfs.Result ControlCancellable(Gnome.Vfs.Handle handle, string operation, IntPtr operation_data, Gnome.Vfs.Context context) {
			IntPtr native_operation = GLib.Marshaller.StringToPtrGStrdup (operation);
			int raw_ret = gnome_vfs_file_control_cancellable(handle == null ? IntPtr.Zero : handle.Handle, native_operation, operation_data, context == null ? IntPtr.Zero : context.Handle);
			Gnome.Vfs.Result ret = (Gnome.Vfs.Result) raw_ret;
			GLib.Marshaller.Free (native_operation);
			return ret;
		}

#endregion
	}
}
