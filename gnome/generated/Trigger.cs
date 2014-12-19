// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public struct Trigger {

		public Gnome.TriggerType Type;
		private GnomeSharp.TriggerActionFunctionNative function;
		public Gnome.TriggerActionFunction Function {
			get {
				return GnomeSharp.TriggerActionFunctionWrapper.GetManagedDelegate (function);
			}
		}
		public string Level;

		public static Gnome.Trigger Zero = new Gnome.Trigger ();

		public static Gnome.Trigger New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gnome.Trigger.Zero;
			return (Gnome.Trigger) Marshal.PtrToStructure (raw, typeof (Gnome.Trigger));
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
