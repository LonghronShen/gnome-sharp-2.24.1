// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class CanvasText : Gnome.CanvasItem {

		[Obsolete]
		protected CanvasText(GLib.GType gtype) : base(gtype) {}
		public CanvasText(IntPtr raw) : base(raw) {}

		protected CanvasText() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("fill_color")]
		public string FillColor {
			get {
				GLib.Value val = GetProperty ("fill_color");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("fill_color", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("x_offset")]
		public double XOffset {
			get {
				GLib.Value val = GetProperty ("x_offset");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("x_offset", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("font")]
		public string Font {
			get {
				GLib.Value val = GetProperty ("font");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("font", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("font_desc")]
		public Pango.FontDescription FontDesc {
			get {
				GLib.Value val = GetProperty ("font_desc");
				Pango.FontDescription ret = (Pango.FontDescription) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value, "PangoFontDescription");
				SetProperty("font_desc", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("fill_color_gdk")]
		public Gdk.Color FillColorGdk {
			get {
				GLib.Value val = GetProperty ("fill_color_gdk");
				Gdk.Color ret = (Gdk.Color) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("fill_color_gdk", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("variant")]
		public Pango.Variant Variant {
			get {
				GLib.Value val = GetProperty ("variant");
				Pango.Variant ret = (Pango.Variant) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("variant", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("style")]
		public Pango.Style Style {
			get {
				GLib.Value val = GetProperty ("style");
				Pango.Style ret = (Pango.Style) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("style", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("clip_width")]
		public double ClipWidth {
			get {
				GLib.Value val = GetProperty ("clip_width");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("clip_width", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("size")]
		public int Size {
			get {
				GLib.Value val = GetProperty ("size");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("size", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("fill_color_rgba")]
		public uint FillColorRgba {
			get {
				GLib.Value val = GetProperty ("fill_color_rgba");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("fill_color_rgba", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("scale")]
		public double Scale {
			get {
				GLib.Value val = GetProperty ("scale");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("scale", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("underline")]
		public Pango.Underline Underline {
			get {
				GLib.Value val = GetProperty ("underline");
				Pango.Underline ret = (Pango.Underline) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("underline", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("attributes")]
		public Pango.AttrList Attributes {
			get {
				GLib.Value val = GetProperty ("attributes");
				Pango.AttrList ret = (Pango.AttrList) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value, "PangoAttrList");
				SetProperty("attributes", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("clip")]
		public bool Clip {
			get {
				GLib.Value val = GetProperty ("clip");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("clip", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("weight")]
		public int Weight {
			get {
				GLib.Value val = GetProperty ("weight");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("weight", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("size_points")]
		public double SizePoints {
			get {
				GLib.Value val = GetProperty ("size_points");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("size_points", val);
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

		[GLib.Property ("fill_stipple")]
		public Gdk.Drawable FillStipple {
			get {
				GLib.Value val = GetProperty ("fill_stipple");
				Gdk.Drawable ret = (Gdk.Drawable) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("fill_stipple", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("y_offset")]
		public double YOffset {
			get {
				GLib.Value val = GetProperty ("y_offset");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("y_offset", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("justification")]
		public Gtk.Justification Justification {
			get {
				GLib.Value val = GetProperty ("justification");
				Gtk.Justification ret = (Gtk.Justification) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("justification", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("stretch")]
		public Pango.Stretch Stretch {
			get {
				GLib.Value val = GetProperty ("stretch");
				Pango.Stretch ret = (Pango.Stretch) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("stretch", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("clip_height")]
		public double ClipHeight {
			get {
				GLib.Value val = GetProperty ("clip_height");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("clip_height", val);
				val.Dispose ();
			}
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

		[GLib.Property ("family")]
		public string Family {
			get {
				GLib.Value val = GetProperty ("family");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("family", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("text")]
		public string Text {
			get {
				GLib.Value val = GetProperty ("text");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("text", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("rise")]
		public int Rise {
			get {
				GLib.Value val = GetProperty ("rise");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("rise", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("strikethrough")]
		public bool Strikethrough {
			get {
				GLib.Value val = GetProperty ("strikethrough");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("strikethrough", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("markup")]
		public string Markup {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("markup", val);
				val.Dispose ();
			}
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_canvas_text_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gnome_canvas_text_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
#region Customized extensions
#line 1 "CanvasText.custom"
//
// Gnome.CanvasText.custom - Gnome CanvasText class customizations
//
// Author: Rachel Hestilow <hestilow@ximian.com>
//
// Copyright (C) 2002 Rachel Hestilow
// Copyright (c) 2006 Novell, Inc.
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
	
	
public CanvasText (Gnome.CanvasGroup group) : base (group, GType)
{
}

		// to provide backcompat with 2.4/2.6/2.8
		// WRITE was removed in libgnomecanvas-2.14
		[GLib.Property ("text_width")]
		public double TextWidth {
			get {
				GLib.Value val = GetProperty ("text_width");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
			}
		}

		// to provide backcompat with 2.4/2.6/2.8
		// WRITE was removed in libgnomecanvas-2.14
		[GLib.Property ("text_height")]
		public double TextHeight {
			get {
				GLib.Value val = GetProperty ("text_height");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
			}
		}


#endregion
	}
}
