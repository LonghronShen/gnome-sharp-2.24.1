// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GnomeSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void GdkPixbufDoneCallbackNative(IntPtr handle, IntPtr cb_data);

	internal class GdkPixbufDoneCallbackInvoker {

		GdkPixbufDoneCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~GdkPixbufDoneCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal GdkPixbufDoneCallbackInvoker (GdkPixbufDoneCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal GdkPixbufDoneCallbackInvoker (GdkPixbufDoneCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal GdkPixbufDoneCallbackInvoker (GdkPixbufDoneCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gnome.GdkPixbufDoneCallback Handler {
			get {
				return new Gnome.GdkPixbufDoneCallback(InvokeNative);
			}
		}

		void InvokeNative (Gnome.GdkPixbufAsyncHandle handle)
		{
			native_cb (handle == null ? IntPtr.Zero : handle.Handle, __data);
		}
	}

	internal class GdkPixbufDoneCallbackWrapper {

		public void NativeCallback (IntPtr handle, IntPtr cb_data)
		{
			try {
				managed (handle == IntPtr.Zero ? null : (Gnome.GdkPixbufAsyncHandle) GLib.Opaque.GetOpaque (handle, typeof (Gnome.GdkPixbufAsyncHandle), false));
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

		internal GdkPixbufDoneCallbackNative NativeDelegate;
		Gnome.GdkPixbufDoneCallback managed;

		public GdkPixbufDoneCallbackWrapper (Gnome.GdkPixbufDoneCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new GdkPixbufDoneCallbackNative (NativeCallback);
		}

		public static Gnome.GdkPixbufDoneCallback GetManagedDelegate (GdkPixbufDoneCallbackNative native)
		{
			if (native == null)
				return null;
			GdkPixbufDoneCallbackWrapper wrapper = (GdkPixbufDoneCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
