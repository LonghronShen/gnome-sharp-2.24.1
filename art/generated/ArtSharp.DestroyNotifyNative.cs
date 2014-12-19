// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace ArtSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void DestroyNotifyNative(IntPtr func_data, IntPtr data);

	internal class DestroyNotifyInvoker {

		DestroyNotifyNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~DestroyNotifyInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal DestroyNotifyInvoker (DestroyNotifyNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal DestroyNotifyInvoker (DestroyNotifyNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal DestroyNotifyInvoker (DestroyNotifyNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Art.DestroyNotify Handler {
			get {
				return new Art.DestroyNotify(InvokeNative);
			}
		}

		void InvokeNative (IntPtr func_data)
		{
			native_cb (__data, __data);
		}
	}

	internal class DestroyNotifyWrapper {

		public void NativeCallback (IntPtr func_data, IntPtr data)
		{
			try {
				managed (func_data);
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

		internal DestroyNotifyNative NativeDelegate;
		Art.DestroyNotify managed;

		public DestroyNotifyWrapper (Art.DestroyNotify managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new DestroyNotifyNative (NativeCallback);
		}

		public static Art.DestroyNotify GetManagedDelegate (DestroyNotifyNative native)
		{
			if (native == null)
				return null;
			DestroyNotifyWrapper wrapper = (DestroyNotifyWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}