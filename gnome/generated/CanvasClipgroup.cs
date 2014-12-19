// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class CanvasClipgroup : Gnome.CanvasGroup {

		[Obsolete]
		protected CanvasClipgroup(GLib.GType gtype) : base(gtype) {}
		public CanvasClipgroup(IntPtr raw) : base(raw) {}

		protected CanvasClipgroup() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("wind")]
		public Art.WindRule Wind {
			get {
				GLib.Value val = GetProperty ("wind");
				Art.WindRule ret = (Art.WindRule) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("wind", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("path")]
		public IntPtr Path {
			get {
				GLib.Value val = GetProperty ("path");
				IntPtr ret = (IntPtr) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("path", val);
				val.Dispose ();
			}
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_canvas_clipgroup_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gnome_canvas_clipgroup_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
#region Customized extensions
#line 1 "CanvasClipgroup.custom"
// Gnome.CanvasClipgroup.custom - Gnome CanvasClipgroup class customizations
//
// Author: Rachel Hestilow <hestilow@ximian.com>
//
// Copyright (C) 2002 Rachel Hestilow
//
// This code is inserted after the automatically generated code.
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
	
	
public CanvasClipgroup (Gnome.CanvasGroup group) : base (group, GType)
{
}


#endregion
	}
}