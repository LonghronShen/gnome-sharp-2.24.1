// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public struct CanvasBuf {

		private IntPtr _buf;
		public Art.IRect Rect;
		public int BufRowstride;
		public uint BgColor;
		private uint _bitfield0;

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static bool gnomesharp_gnome_canvasbuf_get_is_bg (IntPtr raw);
		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static void gnomesharp_gnome_canvasbuf_set_is_bg (IntPtr raw, bool value);
		public bool IsBg {
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				bool result = gnomesharp_gnome_canvasbuf_get_is_bg (this_as_native);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return result;
			}
			set {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				gnomesharp_gnome_canvasbuf_set_is_bg (this_as_native, value);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			}
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static bool gnomesharp_gnome_canvasbuf_get_is_buf (IntPtr raw);
		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static void gnomesharp_gnome_canvasbuf_set_is_buf (IntPtr raw, bool value);
		public bool IsBuf {
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				bool result = gnomesharp_gnome_canvasbuf_get_is_buf (this_as_native);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return result;
			}
			set {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				gnomesharp_gnome_canvasbuf_set_is_buf (this_as_native, value);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			}
		}


		public static Gnome.CanvasBuf Zero = new Gnome.CanvasBuf ();

		public static Gnome.CanvasBuf New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gnome.CanvasBuf.Zero;
			return (Gnome.CanvasBuf) Marshal.PtrToStructure (raw, typeof (Gnome.CanvasBuf));
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_buf_ensure_buf(IntPtr raw);

		public void EnsureBuf() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gnome_canvas_buf_ensure_buf(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		static void ReadNative (IntPtr native, ref Gnome.CanvasBuf target)
		{
			target = New (native);
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}