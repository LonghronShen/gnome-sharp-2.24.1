// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome.VfsSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void AsyncSeekCallbackNative(IntPtr handle, int result, IntPtr callback_data);

	internal class AsyncSeekCallbackInvoker {

		AsyncSeekCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~AsyncSeekCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal AsyncSeekCallbackInvoker (AsyncSeekCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal AsyncSeekCallbackInvoker (AsyncSeekCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal AsyncSeekCallbackInvoker (AsyncSeekCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gnome.Vfs.AsyncSeekCallback Handler {
			get {
				return new Gnome.Vfs.AsyncSeekCallback(InvokeNative);
			}
		}

		void InvokeNative (Gnome.Vfs.AsyncHandle handle, Gnome.Vfs.Result result)
		{
			native_cb (handle == null ? IntPtr.Zero : handle.Handle, (int) result, __data);
		}
	}

	internal class AsyncSeekCallbackWrapper {

		public void NativeCallback (IntPtr handle, int result, IntPtr callback_data)
		{
			try {
				managed (handle == IntPtr.Zero ? null : (Gnome.Vfs.AsyncHandle) GLib.Opaque.GetOpaque (handle, typeof (Gnome.Vfs.AsyncHandle), false), (Gnome.Vfs.Result) result);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal AsyncSeekCallbackNative NativeDelegate;
		Gnome.Vfs.AsyncSeekCallback managed;

		public AsyncSeekCallbackWrapper (Gnome.Vfs.AsyncSeekCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new AsyncSeekCallbackNative (NativeCallback);
		}

		public static Gnome.Vfs.AsyncSeekCallback GetManagedDelegate (AsyncSeekCallbackNative native)
		{
			if (native == null)
				return null;
			AsyncSeekCallbackWrapper wrapper = (AsyncSeekCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
