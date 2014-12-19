// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Url {

		[DllImport("gnome-2", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gnome_url_show_with_env(IntPtr url, IntPtr envp, out IntPtr error);

		public static unsafe bool ShowWithEnv(string url, string envp) {
			IntPtr native_url = GLib.Marshaller.StringToPtrGStrdup (url);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gnome_url_show_with_env(native_url, GLib.Marshaller.StringToPtrGStrdup(envp), out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_url);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gnome-2", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gnome_url_show(IntPtr url, out IntPtr error);

		public static unsafe bool Show(string url) {
			IntPtr native_url = GLib.Marshaller.StringToPtrGStrdup (url);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gnome_url_show(native_url, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_url);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gnome-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_url_error_quark();

		public static int ErrorQuark() {
			int raw_ret = gnome_url_error_quark();
			int ret = raw_ret;
			return ret;
		}

#endregion
	}
}