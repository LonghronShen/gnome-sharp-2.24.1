// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class CanvasPoints : GLib.Opaque {

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_canvas_points_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gnome_canvas_points_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public CanvasPoints(IntPtr raw) : base(raw) {}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_canvas_points_new(int num_points);

		public CanvasPoints (int num_points) 
		{
			Raw = gnome_canvas_points_new(num_points);
		}

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_canvas_points_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gnome_canvas_points_ref (raw);
				Owned = true;
			}
		}

		[Obsolete("Gnome.CanvasPoints is now refcounted automatically")]
		public CanvasPoints Ref () { return this; }

		[DllImport("gnomecanvas-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_canvas_points_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gnome_canvas_points_free (raw);
		}

		[Obsolete("Gnome.CanvasPoints is now freed automatically")]
		public void Free () {}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gnome_canvas_points_free (handle);
				return false;
			}
		}

		~CanvasPoints ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
#region Customized extensions
#line 1 "CanvasPoints.custom"
//
// Gnome.CanvasPoints.custom - Gnome CanvasPoints class customizations
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
	
	
[DllImport("gnomesharpglue-2")]
static extern System.IntPtr
gtksharp_gnome_canvas_points_new_from_array (uint num_points, double[] coords);

public CanvasPoints (double[] coords) : this (gtksharp_gnome_canvas_points_new_from_array ((uint) coords.Length / 2, coords)) {}


#endregion
	}
}
