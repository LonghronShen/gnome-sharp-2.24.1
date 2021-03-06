// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Art {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Render : GLib.Opaque {

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_invoke_callbacks(IntPtr raw, out byte dest, int y);

		public byte InvokeCallbacks(int y) {
			byte dest;
			art_render_invoke_callbacks(Handle, out dest, y);
			return dest;
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_gradient_radial(IntPtr raw, IntPtr gradient, int level);

		public void GradientRadial(Art.GradientRadial gradient, Art.FilterLevel level) {
			IntPtr native_gradient = GLib.Marshaller.StructureToPtrAlloc (gradient);
			art_render_gradient_radial(Handle, native_gradient, (int) level);
			gradient = Art.GradientRadial.New (native_gradient);
			Marshal.FreeHGlobal (native_gradient);
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_invoke(IntPtr raw);

		public void Invoke() {
			art_render_invoke(Handle);
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_gradient_linear(IntPtr raw, IntPtr gradient, int level);

		public void GradientLinear(Art.GradientLinear gradient, Art.FilterLevel level) {
			IntPtr native_gradient = GLib.Marshaller.StructureToPtrAlloc (gradient);
			art_render_gradient_linear(Handle, native_gradient, (int) level);
			gradient = Art.GradientLinear.New (native_gradient);
			Marshal.FreeHGlobal (native_gradient);
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_image_solid(IntPtr raw, out byte color);

		public byte ImageSolid() {
			byte color;
			art_render_image_solid(Handle, out color);
			return color;
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_add_image_source(IntPtr raw, IntPtr image_source);

		public void AddImageSource(Art.ImageSource image_source) {
			IntPtr native_image_source = GLib.Marshaller.StructureToPtrAlloc (image_source);
			art_render_add_image_source(Handle, native_image_source);
			image_source = Art.ImageSource.New (native_image_source);
			Marshal.FreeHGlobal (native_image_source);
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_mask_solid(IntPtr raw, int opacity);

		public void MaskSolid(int opacity) {
			art_render_mask_solid(Handle, opacity);
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_mask(IntPtr raw, int x0, int y0, int x1, int y1, out byte mask_buf, int rowstride);

		public byte Mask(int x0, int y0, int x1, int y1, int rowstride) {
			byte mask_buf;
			art_render_mask(Handle, x0, y0, x1, y1, out mask_buf, rowstride);
			return mask_buf;
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_add_mask_source(IntPtr raw, IntPtr mask_source);

		public void AddMaskSource(Art.MaskSource mask_source) {
			IntPtr native_mask_source = GLib.Marshaller.StructureToPtrAlloc (mask_source);
			art_render_add_mask_source(Handle, native_mask_source);
			mask_source = Art.MaskSource.New (native_mask_source);
			Marshal.FreeHGlobal (native_mask_source);
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_svp(IntPtr raw, IntPtr svp);

		public void Svp(Art.SVP svp) {
			IntPtr native_svp = GLib.Marshaller.StructureToPtrAlloc (svp);
			art_render_svp(Handle, native_svp);
			svp = Art.SVP.New (native_svp);
			Marshal.FreeHGlobal (native_svp);
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_clear_rgb(IntPtr raw, uint clear_rgb);

		public void ClearRgb(uint clear_rgb) {
			art_render_clear_rgb(Handle, clear_rgb);
		}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern void art_render_clear(IntPtr raw, out byte clear_color);

		public byte Clear() {
			byte clear_color;
			art_render_clear(Handle, out clear_color);
			return clear_color;
		}

		public Render(IntPtr raw) : base(raw) {}

		[DllImport("art_lgpl", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr art_render_new(int x0, int y0, int x1, int y1, out byte pixels, int rowstride, int n_chan, int depth, int alpha_type, IntPtr alphagamma);

		public Render (int x0, int y0, int x1, int y1, out byte pixels, int rowstride, int n_chan, int depth, Art.AlphaType alpha_type, Art.AlphaGamma alphagamma) 
		{
			Raw = art_render_new(x0, y0, x1, y1, out pixels, rowstride, n_chan, depth, (int) alpha_type, alphagamma == null ? IntPtr.Zero : alphagamma.Handle);
		}

#endregion
	}
}
