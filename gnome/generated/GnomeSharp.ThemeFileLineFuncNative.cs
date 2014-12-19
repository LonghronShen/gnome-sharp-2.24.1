// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GnomeSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void ThemeFileLineFuncNative(IntPtr df, IntPtr key, IntPtr locale, IntPtr value, IntPtr data);

	internal class ThemeFileLineFuncInvoker {

		ThemeFileLineFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~ThemeFileLineFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal ThemeFileLineFuncInvoker (ThemeFileLineFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal ThemeFileLineFuncInvoker (ThemeFileLineFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal ThemeFileLineFuncInvoker (ThemeFileLineFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gnome.ThemeFileLineFunc Handler {
			get {
				return new Gnome.ThemeFileLineFunc(InvokeNative);
			}
		}

		void InvokeNative (Gnome.ThemeFile df, string key, string locale, string value)
		{
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_locale = GLib.Marshaller.StringToPtrGStrdup (locale);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			native_cb (df == null ? IntPtr.Zero : df.Handle, native_key, native_locale, native_value, __data);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_locale);
			GLib.Marshaller.Free (native_value);
		}
	}

	internal class ThemeFileLineFuncWrapper {

		public void NativeCallback (IntPtr df, IntPtr key, IntPtr locale, IntPtr value, IntPtr data)
		{
			try {
				managed (df == IntPtr.Zero ? null : (Gnome.ThemeFile) GLib.Opaque.GetOpaque (df, typeof (Gnome.ThemeFile), false), GLib.Marshaller.Utf8PtrToString (key), GLib.Marshaller.Utf8PtrToString (locale), GLib.Marshaller.Utf8PtrToString (value));
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

		internal ThemeFileLineFuncNative NativeDelegate;
		Gnome.ThemeFileLineFunc managed;

		public ThemeFileLineFuncWrapper (Gnome.ThemeFileLineFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new ThemeFileLineFuncNative (NativeCallback);
		}

		public static Gnome.ThemeFileLineFunc GetManagedDelegate (ThemeFileLineFuncNative native)
		{
			if (native == null)
				return null;
			ThemeFileLineFuncWrapper wrapper = (ThemeFileLineFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
