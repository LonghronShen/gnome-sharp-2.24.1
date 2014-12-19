// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public struct UIInfo {

		public Gnome.UIInfoType Type;
		public string Label;
		public string Hint;
		private IntPtr _moreinfo;
		private IntPtr _user_data;
		private IntPtr _unused_data;
		public Gnome.UIPixmapType PixmapType;
		private IntPtr _pixmap_info;
		public uint AcceleratorKey;
		public Gdk.ModifierType AcMods;
		private IntPtr _widget;
		public Gtk.Widget Widget {
			get {
				return GLib.Object.GetObject(_widget) as Gtk.Widget;
			}
			set {
				_widget = value == null ? IntPtr.Zero : value.Handle;
			}
		}

		public static Gnome.UIInfo Zero = new Gnome.UIInfo ();

		public static Gnome.UIInfo New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gnome.UIInfo.Zero;
			return (Gnome.UIInfo) Marshal.PtrToStructure (raw, typeof (Gnome.UIInfo));
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
#region Customized extensions
#line 1 "UIInfo.custom"
// UIInfo.custom - Gnome.UIInfo customizations
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


		[Obsolete ("Replaced by Widget property.")]
		public Gtk.Widget widget {
			get { 
				Gtk.Widget ret = (Gtk.Widget) GLib.Object.GetObject(_widget);
				return ret;
			}
			set { _widget = value.Handle; }
		}


#endregion
	}
}
