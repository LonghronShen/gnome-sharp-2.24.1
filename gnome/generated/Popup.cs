// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Popup {

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_popup_menu_do_popup_modal(IntPtr popup, GtkSharp.MenuPositionFuncNative pos_func, IntPtr pos_data, IntPtr evnt, IntPtr user_data, IntPtr for_widget);

		[Obsolete]
		public static int MenuDoPopupModal(Gtk.Widget popup, Gtk.MenuPositionFunc pos_func, Gdk.EventButton evnt, IntPtr user_data, Gtk.Widget for_widget) {
			GtkSharp.MenuPositionFuncWrapper pos_func_wrapper = new GtkSharp.MenuPositionFuncWrapper (pos_func);
			int raw_ret = gnome_popup_menu_do_popup_modal(popup == null ? IntPtr.Zero : popup.Handle, pos_func_wrapper.NativeDelegate, IntPtr.Zero, evnt == null ? IntPtr.Zero : evnt.Handle, user_data, for_widget == null ? IntPtr.Zero : for_widget.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_popup_menu_attach(IntPtr popup, IntPtr widget, IntPtr user_data);

		[Obsolete]
		public static void MenuAttach(Gtk.Widget popup, Gtk.Widget widget, IntPtr user_data) {
			gnome_popup_menu_attach(popup == null ? IntPtr.Zero : popup.Handle, widget == null ? IntPtr.Zero : widget.Handle, user_data);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_popup_menu_append(IntPtr popup, IntPtr uiinfo);

		[Obsolete]
		public static void MenuAppend(Gtk.Widget popup, Gnome.UIInfo uiinfo) {
			IntPtr native_uiinfo = GLib.Marshaller.StructureToPtrAlloc (uiinfo);
			gnome_popup_menu_append(popup == null ? IntPtr.Zero : popup.Handle, native_uiinfo);
			uiinfo = Gnome.UIInfo.New (native_uiinfo);
			Marshal.FreeHGlobal (native_uiinfo);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_popup_menu_get_accel_group(IntPtr menu);

		[Obsolete]
		public static Gtk.AccelGroup MenuGetAccelGroup(Gtk.Menu menu) {
			IntPtr raw_ret = gnome_popup_menu_get_accel_group(menu == null ? IntPtr.Zero : menu.Handle);
			Gtk.AccelGroup ret = GLib.Object.GetObject(raw_ret) as Gtk.AccelGroup;
			return ret;
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_popup_menu_new_with_accelgroup(IntPtr uiinfo, IntPtr accelgroup);

		[Obsolete]
		public static Gtk.Widget MenuNewWithAccelgroup(Gnome.UIInfo uiinfo, Gtk.AccelGroup accelgroup) {
			IntPtr native_uiinfo = GLib.Marshaller.StructureToPtrAlloc (uiinfo);
			IntPtr raw_ret = gnome_popup_menu_new_with_accelgroup(native_uiinfo, accelgroup == null ? IntPtr.Zero : accelgroup.Handle);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			uiinfo = Gnome.UIInfo.New (native_uiinfo);
			Marshal.FreeHGlobal (native_uiinfo);
			return ret;
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_popup_menu_do_popup(IntPtr popup, GtkSharp.MenuPositionFuncNative pos_func, IntPtr pos_data, IntPtr evnt, IntPtr user_data, IntPtr for_widget);

		[Obsolete]
		public static void MenuDoPopup(Gtk.Widget popup, Gtk.MenuPositionFunc pos_func, Gdk.EventButton evnt, IntPtr user_data, Gtk.Widget for_widget) {
			GtkSharp.MenuPositionFuncWrapper pos_func_wrapper = new GtkSharp.MenuPositionFuncWrapper (pos_func);
			gnome_popup_menu_do_popup(popup == null ? IntPtr.Zero : popup.Handle, pos_func_wrapper.NativeDelegate, IntPtr.Zero, evnt == null ? IntPtr.Zero : evnt.Handle, user_data, for_widget == null ? IntPtr.Zero : for_widget.Handle);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_popup_menu_new(IntPtr uiinfo);

		[Obsolete]
		public static Gtk.Widget MenuNew(Gnome.UIInfo uiinfo) {
			IntPtr native_uiinfo = GLib.Marshaller.StructureToPtrAlloc (uiinfo);
			IntPtr raw_ret = gnome_popup_menu_new(native_uiinfo);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			uiinfo = Gnome.UIInfo.New (native_uiinfo);
			Marshal.FreeHGlobal (native_uiinfo);
			return ret;
		}

#endregion
#region Customized extensions
#line 1 "Popup.custom"
// Popup.custom - Gnome.Popup customizations
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

		[Obsolete]
		public static int MenuDoPopupModal (Gtk.Widget popup, Gtk.MenuPositionFunc pos_func, IntPtr data, Gdk.EventButton evnt, IntPtr user_data, Gtk.Widget for_widget)
		{
			return MenuDoPopupModal (popup, pos_func, evnt, user_data, for_widget);
		}

		[Obsolete]
		public static void MenuDoPopup (Gtk.Widget popup, Gtk.MenuPositionFunc pos_func, IntPtr data, Gdk.EventButton evnt, IntPtr user_data, Gtk.Widget for_widget)
		{
			MenuDoPopup (popup, pos_func, evnt, user_data, for_widget);
		}

#endregion
	}
}
