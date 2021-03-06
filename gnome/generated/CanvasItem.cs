// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class CanvasItem : Gtk.Object {

		[Obsolete]
		protected CanvasItem(GLib.GType gtype) : base(gtype) {}
		public CanvasItem(IntPtr raw) : base(raw) {}

		protected CanvasItem() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("parent")]
		public Gnome.CanvasItem Parent {
			get {
				GLib.Value val = GetProperty ("parent");
				Gnome.CanvasItem ret = (Gnome.CanvasItem) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("parent", val);
				val.Dispose ();
			}
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gnomesharp_gnome_canvasitem_get_canvas_offset ();

		static uint canvas_offset = gnomesharp_gnome_canvasitem_get_canvas_offset ();
		public Gnome.Canvas Canvas {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + canvas_offset);
					return GLib.Object.GetObject((*raw_ptr)) as Gnome.Canvas;
				}
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CanvasEventVMDelegate (IntPtr item, IntPtr evnt);

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_canvasitem_override_event (IntPtr gtype, CanvasEventVMDelegate cb);

		static CanvasEventVMDelegate CanvasEventVMCallback;

		static bool canvasevent_cb (IntPtr item, IntPtr evnt)
		{
			try {
				CanvasItem item_managed = GLib.Object.GetObject (item, false) as CanvasItem;
				return item_managed.OnCanvasEvent (Gdk.Event.GetEvent (evnt));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call doesn't return
				throw e;
			}
		}

		private static void OverrideCanvasEvent (GLib.GType gtype)
		{
			if (CanvasEventVMCallback == null)
				CanvasEventVMCallback = new CanvasEventVMDelegate (canvasevent_cb);
			gnomesharp_canvasitem_override_event (gtype.Val, CanvasEventVMCallback);
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gnomesharp_canvasitem_base_event (IntPtr item, IntPtr evnt);

		[GLib.DefaultSignalHandler(Type=typeof(Gnome.CanvasItem), ConnectionMethod="OverrideCanvasEvent")]
		protected virtual bool OnCanvasEvent (Gdk.Event evnt)
		{
			bool __ret = gnomesharp_canvasitem_base_event (Handle, evnt == null ? IntPtr.Zero : evnt.Handle);
			return __ret;
		}

		[GLib.Signal("event")]
		public event Gnome.CanvasEventHandler CanvasEvent {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "event", typeof (Gnome.CanvasEventArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "event", typeof (Gnome.CanvasEventArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_reset_bounds(IntPtr raw);

		public void ResetBounds() {
			gnome_canvas_item_reset_bounds(Handle);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_request_update(IntPtr raw);

		public void RequestUpdate() {
			gnome_canvas_item_request_update(Handle);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_move(IntPtr raw, double dx, double dy);

		public void Move(double dx, double dy) {
			gnome_canvas_item_move(Handle, dx, dy);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_i2w(IntPtr raw, ref double x, ref double y);

		public void I2w(ref double x, ref double y) {
			gnome_canvas_item_i2w(Handle, ref x, ref y);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_raise(IntPtr raw, int positions);

		public void Raise(int positions) {
			gnome_canvas_item_raise(Handle, positions);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_ungrab(IntPtr raw, uint etime);

		public void Ungrab(uint etime) {
			gnome_canvas_item_ungrab(Handle, etime);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_canvas_item_grab(IntPtr raw, uint event_mask, IntPtr cursor, uint etime);

		public int Grab(uint event_mask, Gdk.Cursor cursor, uint etime) {
			int raw_ret = gnome_canvas_item_grab(Handle, event_mask, cursor == null ? IntPtr.Zero : cursor.Handle, etime);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_reparent(IntPtr raw, IntPtr new_group);

		public void Reparent(Gnome.CanvasGroup new_group) {
			gnome_canvas_item_reparent(Handle, new_group == null ? IntPtr.Zero : new_group.Handle);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_affine_absolute(IntPtr raw, double[] affine);

		public void AffineAbsolute(double[] affine) {
			gnome_canvas_item_affine_absolute(Handle, affine);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_get_bounds(IntPtr raw, out double x1, out double y1, out double x2, out double y2);

		public void GetBounds(out double x1, out double y1, out double x2, out double y2) {
			gnome_canvas_item_get_bounds(Handle, out x1, out y1, out x2, out y2);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_update_svp_clip(IntPtr raw, IntPtr p_svp, IntPtr new_svp, IntPtr clip_svp);

		public void UpdateSvpClip(Art.SVP p_svp, Art.SVP new_svp, Art.SVP clip_svp) {
			IntPtr native_p_svp = GLib.Marshaller.StructureToPtrAlloc (p_svp);
			IntPtr native_new_svp = GLib.Marshaller.StructureToPtrAlloc (new_svp);
			IntPtr native_clip_svp = GLib.Marshaller.StructureToPtrAlloc (clip_svp);
			gnome_canvas_item_update_svp_clip(Handle, native_p_svp, native_new_svp, native_clip_svp);
			p_svp = Art.SVP.New (native_p_svp);
			Marshal.FreeHGlobal (native_p_svp);
			new_svp = Art.SVP.New (native_new_svp);
			Marshal.FreeHGlobal (native_new_svp);
			clip_svp = Art.SVP.New (native_clip_svp);
			Marshal.FreeHGlobal (native_clip_svp);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_lower(IntPtr raw, int positions);

		public void Lower(int positions) {
			gnome_canvas_item_lower(Handle, positions);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_update_svp(IntPtr raw, IntPtr p_svp, IntPtr new_svp);

		public void UpdateSvp(Art.SVP p_svp, Art.SVP new_svp) {
			IntPtr native_p_svp = GLib.Marshaller.StructureToPtrAlloc (p_svp);
			IntPtr native_new_svp = GLib.Marshaller.StructureToPtrAlloc (new_svp);
			gnome_canvas_item_update_svp(Handle, native_p_svp, native_new_svp);
			p_svp = Art.SVP.New (native_p_svp);
			Marshal.FreeHGlobal (native_p_svp);
			new_svp = Art.SVP.New (native_new_svp);
			Marshal.FreeHGlobal (native_new_svp);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_w2i(IntPtr raw, ref double x, ref double y);

		public void W2i(ref double x, ref double y) {
			gnome_canvas_item_w2i(Handle, ref x, ref y);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_raise_to_top(IntPtr raw);

		public void RaiseToTop() {
			gnome_canvas_item_raise_to_top(Handle);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_hide(IntPtr raw);

		public void Hide() {
			gnome_canvas_item_hide(Handle);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_lower_to_bottom(IntPtr raw);

		public void LowerToBottom() {
			gnome_canvas_item_lower_to_bottom(Handle);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_grab_focus(IntPtr raw);

		public void GrabFocus() {
			gnome_canvas_item_grab_focus(Handle);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_request_redraw_svp(IntPtr raw, IntPtr svp);

		public void RequestRedrawSvp(Art.SVP svp) {
			IntPtr native_svp = GLib.Marshaller.StructureToPtrAlloc (svp);
			gnome_canvas_item_request_redraw_svp(Handle, native_svp);
			svp = Art.SVP.New (native_svp);
			Marshal.FreeHGlobal (native_svp);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_show(IntPtr raw);

		public void Show() {
			gnome_canvas_item_show(Handle);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_canvas_item_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gnome_canvas_item_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_item_affine_relative(IntPtr raw, double[] affine);

		public void AffineRelative(double[] affine) {
			gnome_canvas_item_affine_relative(Handle, affine);
		}

#endregion
#region Customized extensions
#line 1 "CanvasItem.custom"
//
// Gnome.CanvasItem.custom - Gnome CanvasItem class customizations
//
// Author: Rachel Hestilow <hestilow@ximian.com>
//
// Copyright (C) 2002 Rachel Hestilow
//
// This code is inserted after the automatically generated code.
//
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.
	
                [DllImport("gnomecanvas-2")]
                static extern System.IntPtr gnome_canvas_item_new (IntPtr group, IntPtr type, IntPtr null_terminator);
                
                [DllImport("libgobject-2.0-0.dll")]
                static extern void g_object_ref (IntPtr raw);
                
                public CanvasItem (Gnome.CanvasGroup group, GLib.GType type)
                	: base (gnome_canvas_item_new (group.Handle, type.Val, IntPtr.Zero))
                {
                	g_object_ref (Handle);
                }
                
		[DllImport("gnomecanvas-2")]
		static extern void gnome_canvas_item_i2c_affine(IntPtr raw, double[] affine);

		public void I2cAffine(out double[] affine) {
                        affine = new double [6];
			gnome_canvas_item_i2c_affine(Handle, affine);
		}

		[DllImport("gnomecanvas-2")]
		static extern void gnome_canvas_item_i2w_affine(IntPtr raw, double[] affine);

		public void I2wAffine(out double[] affine) {
                        affine = new double [6];
			gnome_canvas_item_i2w_affine(Handle, affine);
		}

		[DllImport("gnomesharpglue-2")]
		static extern void gnomesharp_canvas_item_base_realize (IntPtr handle);

		[DllImport("gnomesharpglue-2")]
		static extern void gnomesharp_canvas_item_override_realize (IntPtr gtype, RealizeDelegate cb);

		[GLib.CDeclCallback]
		delegate void RealizeDelegate (IntPtr item);

                static RealizeDelegate RealizeCallback;

                static void Realize_cb (IntPtr item)
                {
                        CanvasItem obj = GLib.Object.GetObject (item, false) as CanvasItem;
                        obj.Realize ();
                }

                static void OverrideRealize (GLib.GType gtype)
                {
                        if (RealizeCallback == null)
                                RealizeCallback = new RealizeDelegate (Realize_cb);
                        gnomesharp_canvas_item_override_realize (gtype.Val, RealizeCallback);
                }

		[GLib.DefaultSignalHandler (Type=typeof(Gnome.CanvasItem), ConnectionMethod="OverrideRealize")]
		protected virtual void Realize ()
		{
			gnomesharp_canvas_item_base_realize (Handle);
		}

		[DllImport("gnomesharpglue-2")]
		static extern double gnomesharp_canvas_item_base_point (IntPtr handle, double x, double y, int cx, int cy, out IntPtr actual_item_handle);

		[DllImport("gnomesharpglue-2")]
		static extern void gnomesharp_canvas_item_override_point (IntPtr gtype, PointDelegate cb);

		[GLib.CDeclCallback]
		delegate double PointDelegate (IntPtr item, double x, double y, int cx, int cy, out IntPtr actual_item_handle);

                static PointDelegate PointCallback;

                static double Point_cb (IntPtr item, double x, double y, int cx, int cy, out IntPtr actual_item_handle)
                {
                        CanvasItem obj = GLib.Object.GetObject (item, false) as CanvasItem;
			CanvasItem actual_item;
                        double result = obj.Point (x, y, cx, cy, out actual_item);
			actual_item_handle = actual_item != null ? actual_item.Handle : IntPtr.Zero;
			return result;
                }

                static void OverridePoint (GLib.GType gtype)
                {
                        if (PointCallback == null)
                                PointCallback = new PointDelegate (Point_cb);
                        gnomesharp_canvas_item_override_point (gtype.Val, PointCallback);
                }

		[GLib.DefaultSignalHandler (Type=typeof(Gnome.CanvasItem), ConnectionMethod="OverridePoint")]
		protected virtual double Point (double x, double y, int cx, int cy, out CanvasItem actual_item)
		{
			IntPtr actual_item_handle;
			double result = gnomesharp_canvas_item_base_point (Handle, x, y, cx, cy, out actual_item_handle);
			actual_item = GLib.Object.GetObject (actual_item_handle, false) as CanvasItem;
			return result;
		}

		[DllImport("gnomesharpglue-2")]
		static extern void gnomesharp_canvas_item_base_draw (IntPtr handle, IntPtr drawable, int x, int y, int width, int height);

		[DllImport("gnomesharpglue-2")]
		static extern void gnomesharp_canvas_item_override_draw (IntPtr gtype, DrawDelegate cb);

		[GLib.CDeclCallback]
		delegate void DrawDelegate (IntPtr handle, IntPtr drawable, int x, int y, int width, int height);

                static DrawDelegate DrawCallback;

                static void Draw_cb (IntPtr handle, IntPtr drawable_handle, int x, int y, int width, int height)
                {
                        CanvasItem obj = GLib.Object.GetObject (handle, false) as CanvasItem;
                        Gdk.Drawable drawable = GLib.Object.GetObject (drawable_handle, false) as Gdk.Drawable;
                        obj.Draw (drawable, x, y, width, height);
                }

                static void OverrideDraw (GLib.GType gtype)
                {
                        if (DrawCallback == null)
                                DrawCallback = new DrawDelegate (Draw_cb);
                        gnomesharp_canvas_item_override_draw (gtype.Val, DrawCallback);
                }

		[GLib.DefaultSignalHandler (Type=typeof(Gnome.CanvasItem), ConnectionMethod="OverrideDraw")]
		protected virtual void Draw (Gdk.Drawable drawable, int x, int y, int width, int height)
		{
			gnomesharp_canvas_item_base_draw (Handle, drawable.Handle, x, y, width, height);
		}

		[DllImport("gnomesharpglue-2")]
		static extern void gnomesharp_canvas_item_base_render (IntPtr handle, ref CanvasBuf buf);

		[DllImport("gnomesharpglue-2")]
		static extern void gnomesharp_canvas_item_override_render (IntPtr gtype, RenderDelegate cb);

		[GLib.CDeclCallback]
		delegate void RenderDelegate (IntPtr handle, ref CanvasBuf buf);

                static RenderDelegate RenderCallback;

                static void Render_cb (IntPtr handle, ref CanvasBuf buf)
                {
                        CanvasItem obj = GLib.Object.GetObject (handle, false) as CanvasItem;
                        obj.Render (ref buf);
                }

		[GLib.DefaultSignalHandler (Type=typeof(Gnome.CanvasItem), ConnectionMethod="OverrideRender")]
                static void OverrideRender (GLib.GType gtype)
                {
                        if (RenderCallback == null)
                                RenderCallback = new RenderDelegate (Render_cb);
                        gnomesharp_canvas_item_override_render (gtype.Val, RenderCallback);
                }

		protected virtual void Render (ref CanvasBuf buf)
		{
			gnomesharp_canvas_item_base_render (Handle, ref buf);
		}

		[DllImport("gnomesharpglue-2")]
		static extern void gnomesharp_canvas_item_base_update (IntPtr handle, double[] affine, ref Art.SVP clip_path, int flags);

		[DllImport("gnomesharpglue-2")]
		static extern void gnomesharp_canvas_item_override_update (IntPtr gtype, UpdateDelegate cb);

		[GLib.CDeclCallback]
		delegate void UpdateDelegate (IntPtr item, IntPtr affine_ptr, IntPtr clip_path, int flags);

                static UpdateDelegate UpdateCallback;

                static void Update_cb (IntPtr item, IntPtr affine_ptr, IntPtr clip_path_handle, int flags)
                {
                        CanvasItem obj = GLib.Object.GetObject (item, false) as CanvasItem;
			double[] affine = new double [6];
			Marshal.Copy (affine_ptr, affine, 0, 6);
			Art.SVP clip_path;
			if (clip_path_handle == IntPtr.Zero)
				clip_path = Art.SVP.Zero;
			else
				clip_path = (Art.SVP) Marshal.PtrToStructure (clip_path_handle, typeof(Art.SVP));
                        obj.Update (affine, ref clip_path, flags);
                }

                static void OverrideUpdate (GLib.GType gtype)
                {
                        if (UpdateCallback == null)
                                UpdateCallback = new UpdateDelegate (Update_cb);
                        gnomesharp_canvas_item_override_update (gtype.Val, UpdateCallback);
                }

		[GLib.DefaultSignalHandler (Type=typeof(Gnome.CanvasItem), ConnectionMethod="OverrideUpdate")]
		protected virtual void Update (double[] affine, ref Art.SVP clip_path, int flags)
		{
			gnomesharp_canvas_item_base_update (Handle, affine, ref clip_path, flags);
		}


#endregion
	}
}
