// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Art {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public struct GradientLinear {

		public double A;
		public double B;
		public double C;
		public Art.GradientSpread Spread;
		public int NStops;
		private IntPtr _stops;

		public Art.GradientStop stops {
			get { return Art.GradientStop.New (_stops); }
		}

		public static Art.GradientLinear Zero = new Art.GradientLinear ();

		public static Art.GradientLinear New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Art.GradientLinear.Zero;
			return (Art.GradientLinear) Marshal.PtrToStructure (raw, typeof (Art.GradientLinear));
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
