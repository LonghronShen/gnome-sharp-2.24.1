// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GnomeSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void ReplyCallbackNative(int reply, IntPtr data);

	internal class ReplyCallbackInvoker {

		ReplyCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~ReplyCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal ReplyCallbackInvoker (ReplyCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal ReplyCallbackInvoker (ReplyCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal ReplyCallbackInvoker (ReplyCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gnome.ReplyCallback Handler {
			get {
				return new Gnome.ReplyCallback(InvokeNative);
			}
		}

		void InvokeNative (int reply)
		{
			native_cb (reply, __data);
		}
	}

	internal class ReplyCallbackWrapper {

		public void NativeCallback (int reply, IntPtr data)
		{
			try {
				managed (reply);
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

		internal ReplyCallbackNative NativeDelegate;
		Gnome.ReplyCallback managed;

		public ReplyCallbackWrapper (Gnome.ReplyCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new ReplyCallbackNative (NativeCallback);
		}

		public static Gnome.ReplyCallback GetManagedDelegate (ReplyCallbackNative native)
		{
			if (native == null)
				return null;
			ReplyCallbackWrapper wrapper = (ReplyCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
