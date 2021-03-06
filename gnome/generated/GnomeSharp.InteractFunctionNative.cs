// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GnomeSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void InteractFunctionNative(IntPtr client, int key, int dialog_type, IntPtr data);

	internal class InteractFunctionInvoker {

		InteractFunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~InteractFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal InteractFunctionInvoker (InteractFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal InteractFunctionInvoker (InteractFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal InteractFunctionInvoker (InteractFunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gnome.InteractFunction Handler {
			get {
				return new Gnome.InteractFunction(InvokeNative);
			}
		}

		void InvokeNative (Gnome.Client client, int key, Gnome.DialogType dialog_type)
		{
			native_cb (client == null ? IntPtr.Zero : client.Handle, key, (int) dialog_type, __data);
		}
	}

	internal class InteractFunctionWrapper {

		public void NativeCallback (IntPtr client, int key, int dialog_type, IntPtr data)
		{
			try {
				managed (GLib.Object.GetObject(client) as Gnome.Client, key, (Gnome.DialogType) dialog_type);
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

		internal InteractFunctionNative NativeDelegate;
		Gnome.InteractFunction managed;

		public InteractFunctionWrapper (Gnome.InteractFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new InteractFunctionNative (NativeCallback);
		}

		public static Gnome.InteractFunction GetManagedDelegate (InteractFunctionNative native)
		{
			if (native == null)
				return null;
			InteractFunctionWrapper wrapper = (InteractFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
