// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome.Vfs {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public struct ModuleCallbackQuestionIn {

		public string PrimaryMessage;
		public string SecondaryMessage;
		public string Choices;
		private IntPtr _reserved1;
		private IntPtr _reserved2;

		public static Gnome.Vfs.ModuleCallbackQuestionIn Zero = new Gnome.Vfs.ModuleCallbackQuestionIn ();

		public static Gnome.Vfs.ModuleCallbackQuestionIn New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gnome.Vfs.ModuleCallbackQuestionIn.Zero;
			return (Gnome.Vfs.ModuleCallbackQuestionIn) Marshal.PtrToStructure (raw, typeof (Gnome.Vfs.ModuleCallbackQuestionIn));
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
