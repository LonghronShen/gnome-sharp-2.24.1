// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class CanvasWidget : Gnome.CanvasItem {

		[Obsolete]
		protected CanvasWidget(GLib.GType gtype) : base(gtype) {}
		public CanvasWidget(IntPtr raw) : base(raw) {}

		protected CanvasWidget() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("x")]
		public double X {
			get {
				GLib.Value val = GetProperty ("x");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("x", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("y")]
		public double Y {
			get {
				GLib.Value val = GetProperty ("y");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("y", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("size_pixels")]
		public bool SizePixels {
			get {
				GLib.Value val = GetProperty ("size_pixels");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("size_pixels", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("widget")]
		public Gtk.Widget Widget {
			get {
				GLib.Value val = GetProperty ("widget");
				Gtk.Widget ret = (Gtk.Widget) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("widget", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("anchor")]
		public Gtk.AnchorType Anchor {
			get {
				GLib.Value val = GetProperty ("anchor");
				Gtk.AnchorType ret = (Gtk.AnchorType) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("anchor", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("height")]
		public double Height {
			get {
				GLib.Value val = GetProperty ("height");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("height", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("width")]
		public double Width {
			get {
				GLib.Value val = GetProperty ("width");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("width", val);
				val.Dispose ();
			}
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_canvas_widget_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gnome_canvas_widget_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
#region Customized extensions
#line 1 "CanvasWidget.custom"
//
// Gnome.CanvasWidget.custom - Gnome CanvasWidget class customizations
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
	
	
public CanvasWidget (Gnome.CanvasGroup group) : base (group, GType)
{
}


#endregion
	}
}
