// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome.Vfs {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Context : GLib.Opaque {

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_vfs_context_peek_current();

		public static Gnome.Vfs.Context PeekCurrent() {
			IntPtr raw_ret = gnome_vfs_context_peek_current();
			Gnome.Vfs.Context ret = raw_ret == IntPtr.Zero ? null : (Gnome.Vfs.Context) GLib.Opaque.GetOpaque (raw_ret, typeof (Gnome.Vfs.Context), false);
			return ret;
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gnome_vfs_context_check_cancellation_current();

		public static bool CheckCancellationCurrent() {
			bool raw_ret = gnome_vfs_context_check_cancellation_current();
			bool ret = raw_ret;
			return ret;
		}

		public Context(IntPtr raw) : base(raw) {}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_vfs_context_new();

		public Context () 
		{
			Raw = gnome_vfs_context_new();
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_vfs_context_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gnome_vfs_context_free (raw);
		}

		[Obsolete("Gnome.Vfs.Context is now freed automatically")]
		public void Free () {}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gnome_vfs_context_free (handle);
				return false;
			}
		}

		~Context ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}
