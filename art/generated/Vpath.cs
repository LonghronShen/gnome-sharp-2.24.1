// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Art {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Vpath : GLib.Opaque {

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_vpath_bbox_irect(IntPtr raw, IntPtr irect);

		public void BboxIrect(Art.IRect irect) {
			IntPtr native_irect = GLib.Marshaller.StructureToPtrAlloc (irect);
			art_vpath_bbox_irect(Handle, native_irect);
			irect = Art.IRect.New (native_irect);
			Marshal.FreeHGlobal (native_irect);
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr art_vpath_from_svp(IntPtr svp);

		public static Art.Vpath FromSvp(Art.SVP svp) {
			IntPtr native_svp = GLib.Marshaller.StructureToPtrAlloc (svp);
			IntPtr raw_ret = art_vpath_from_svp(native_svp);
			Art.Vpath ret = raw_ret == IntPtr.Zero ? null : (Art.Vpath) GLib.Opaque.GetOpaque (raw_ret, typeof (Art.Vpath), false);
			svp = Art.SVP.New (native_svp);
			Marshal.FreeHGlobal (native_svp);
			return ret;
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr art_vpath_dash(IntPtr raw, IntPtr dash);

		public Art.Vpath Dash(Art.VpathDash dash) {
			IntPtr native_dash = GLib.Marshaller.StructureToPtrAlloc (dash);
			IntPtr raw_ret = art_vpath_dash(Handle, native_dash);
			Art.Vpath ret = raw_ret == IntPtr.Zero ? null : (Art.Vpath) GLib.Opaque.GetOpaque (raw_ret, typeof (Art.Vpath), false);
			dash = Art.VpathDash.New (native_dash);
			Marshal.FreeHGlobal (native_dash);
			return ret;
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr art_vpath_perturb(IntPtr raw);

		public Art.Vpath Perturb() {
			IntPtr raw_ret = art_vpath_perturb(Handle);
			Art.Vpath ret = raw_ret == IntPtr.Zero ? null : (Art.Vpath) GLib.Opaque.GetOpaque (raw_ret, typeof (Art.Vpath), false);
			return ret;
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr art_vpath_affine_transform(IntPtr raw, double[] matrix);

		public Art.Vpath AffineTransform(double[] matrix) {
			IntPtr raw_ret = art_vpath_affine_transform(Handle, matrix);
			Art.Vpath ret = raw_ret == IntPtr.Zero ? null : (Art.Vpath) GLib.Opaque.GetOpaque (raw_ret, typeof (Art.Vpath), false);
			return ret;
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_vpath_add_point(IntPtr raw, out int pn_points, out int pn_points_max, int code, double x, double y);

		public void AddPoint(out int pn_points, out int pn_points_max, Art.Pathcode code, double x, double y) {
			art_vpath_add_point(Handle, out pn_points, out pn_points_max, (int) code, x, y);
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_vpath_bbox_drect(IntPtr raw, IntPtr drect);

		public void BboxDrect(Art.DRect drect) {
			IntPtr native_drect = GLib.Marshaller.StructureToPtrAlloc (drect);
			art_vpath_bbox_drect(Handle, native_drect);
			drect = Art.DRect.New (native_drect);
			Marshal.FreeHGlobal (native_drect);
		}

		public Vpath(IntPtr raw) : base(raw) {}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr art_vpath_new_circle(double x, double y, double r);

		public Vpath (double x, double y, double r) 
		{
			Raw = art_vpath_new_circle(x, y, r);
		}

#endregion
	}
}
