// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public struct IconData {

		public bool HasEmbeddedRect;
		public int X0;
		public int Y0;
		public int X1;
		public int Y1;
		private IntPtr _attach_points;

		public Gnome.IconDataPoint attach_points {
			get { return Gnome.IconDataPoint.New (_attach_points); }
		}
		public int NAttachPoints;
		public string DisplayName;

		public static Gnome.IconData Zero = new Gnome.IconData ();

		public static Gnome.IconData New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gnome.IconData.Zero;
			return (Gnome.IconData) Marshal.PtrToStructure (raw, typeof (Gnome.IconData));
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_icon_data_free(IntPtr raw);

		[Obsolete]
		public void Free() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gnome_icon_data_free(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_icon_data_dup(IntPtr raw);

		[Obsolete]
		public Gnome.IconData Dup() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gnome_icon_data_dup(this_as_native);
			Gnome.IconData ret = Gnome.IconData.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gnome.IconData target)
		{
			target = New (native);
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
