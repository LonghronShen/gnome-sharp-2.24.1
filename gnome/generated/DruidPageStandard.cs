// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Obsolete]
	public class DruidPageStandard : Gnome.DruidPage {

		[Obsolete]
		protected DruidPageStandard(GLib.GType gtype) : base(gtype) {}
		public DruidPageStandard(IntPtr raw) : base(raw) {}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_druid_page_standard_new();

		public DruidPageStandard () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (DruidPageStandard)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gnome_druid_page_standard_new();
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_druid_page_standard_new_with_vals(IntPtr title, IntPtr logo, IntPtr top_watermark);

		public DruidPageStandard (string title, Gdk.Pixbuf logo, Gdk.Pixbuf top_watermark) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (DruidPageStandard)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				names.Add ("title");
				vals.Add (new GLib.Value (title));
				if (logo != null) {
					names.Add ("logo");
					vals.Add (new GLib.Value (logo));
				}
				if (top_watermark != null) {
					names.Add ("top_watermark");
					vals.Add (new GLib.Value (top_watermark));
				}
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			IntPtr native_title = GLib.Marshaller.StringToPtrGStrdup (title);
			Raw = gnome_druid_page_standard_new_with_vals(native_title, logo == null ? IntPtr.Zero : logo.Handle, top_watermark == null ? IntPtr.Zero : top_watermark.Handle);
			GLib.Marshaller.Free (native_title);
		}

		[GLib.Property ("background_set")]
		public bool BackgroundSet {
			get {
				GLib.Value val = GetProperty ("background_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("background_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("logo_background_set")]
		public bool LogoBackgroundSet {
			get {
				GLib.Value val = GetProperty ("logo_background_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("logo_background_set", val);
				val.Dispose ();
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_druid_page_standard_set_top_watermark(IntPtr raw, IntPtr top_watermark_image);

		[GLib.Property ("top_watermark")]
		public Gdk.Pixbuf TopWatermark {
			get {
				GLib.Value val = GetProperty ("top_watermark");
				Gdk.Pixbuf ret = (Gdk.Pixbuf) val;
				val.Dispose ();
				return ret;
			}
			set  {
				gnome_druid_page_standard_set_top_watermark(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("background_gdk")]
		public Gdk.Color BackgroundGdk {
			get {
				GLib.Value val = GetProperty ("background_gdk");
				Gdk.Color ret = (Gdk.Color) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("background_gdk", val);
				val.Dispose ();
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_druid_page_standard_set_title(IntPtr raw, IntPtr title);

		[GLib.Property ("title")]
		public string Title {
			get {
				GLib.Value val = GetProperty ("title");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gnome_druid_page_standard_set_title(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.Property ("logo_background_gdk")]
		public Gdk.Color LogoBackgroundGdk {
			get {
				GLib.Value val = GetProperty ("logo_background_gdk");
				Gdk.Color ret = (Gdk.Color) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("logo_background_gdk", val);
				val.Dispose ();
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_druid_page_standard_set_logo(IntPtr raw, IntPtr logo_image);

		[GLib.Property ("logo")]
		public Gdk.Pixbuf Logo {
			get {
				GLib.Value val = GetProperty ("logo");
				Gdk.Pixbuf ret = (Gdk.Pixbuf) val;
				val.Dispose ();
				return ret;
			}
			set  {
				gnome_druid_page_standard_set_logo(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("contents_background_set")]
		public bool ContentsBackgroundSet {
			get {
				GLib.Value val = GetProperty ("contents_background_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("contents_background_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("contents_background_gdk")]
		public Gdk.Color ContentsBackgroundGdk {
			get {
				GLib.Value val = GetProperty ("contents_background_gdk");
				Gdk.Color ret = (Gdk.Color) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("contents_background_gdk", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("title_foreground_set")]
		public bool TitleForegroundSet {
			get {
				GLib.Value val = GetProperty ("title_foreground_set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("title_foreground_set", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("title_foreground_gdk")]
		public Gdk.Color TitleForegroundGdk {
			get {
				GLib.Value val = GetProperty ("title_foreground_gdk");
				Gdk.Color ret = (Gdk.Color) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("title_foreground_gdk", val);
				val.Dispose ();
			}
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gnomesharp_gnome_druidpagestandard_get_contents_background_offset ();

		static uint contents_background_offset = gnomesharp_gnome_druidpagestandard_get_contents_background_offset ();
		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_druid_page_standard_set_contents_background(IntPtr raw, IntPtr value);

		public Gdk.Color ContentsBackground {
			get {
				unsafe {
					Gdk.Color* raw_ptr = (Gdk.Color*)(((byte*)Handle) + contents_background_offset);
					return *raw_ptr;
				}
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gnome_druid_page_standard_set_contents_background(Handle, native_value);
				value = Gdk.Color.New (native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gnomesharp_gnome_druidpagestandard_get_vbox_offset ();

		static uint vbox_offset = gnomesharp_gnome_druidpagestandard_get_vbox_offset ();
		public Gtk.VBox VBox {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + vbox_offset);
					return GLib.Object.GetObject((*raw_ptr)) as Gtk.VBox;
				}
			}
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gnomesharp_gnome_druidpagestandard_get_background_offset ();

		static uint background_offset = gnomesharp_gnome_druidpagestandard_get_background_offset ();
		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_druid_page_standard_set_background(IntPtr raw, IntPtr value);

		public Gdk.Color Background {
			get {
				unsafe {
					Gdk.Color* raw_ptr = (Gdk.Color*)(((byte*)Handle) + background_offset);
					return *raw_ptr;
				}
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gnome_druid_page_standard_set_background(Handle, native_value);
				value = Gdk.Color.New (native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gnomesharp_gnome_druidpagestandard_get_logo_background_offset ();

		static uint logo_background_offset = gnomesharp_gnome_druidpagestandard_get_logo_background_offset ();
		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_druid_page_standard_set_logo_background(IntPtr raw, IntPtr value);

		public Gdk.Color LogoBackground {
			get {
				unsafe {
					Gdk.Color* raw_ptr = (Gdk.Color*)(((byte*)Handle) + logo_background_offset);
					return *raw_ptr;
				}
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gnome_druid_page_standard_set_logo_background(Handle, native_value);
				value = Gdk.Color.New (native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gnomesharp_gnome_druidpagestandard_get_title_foreground_offset ();

		static uint title_foreground_offset = gnomesharp_gnome_druidpagestandard_get_title_foreground_offset ();
		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_druid_page_standard_set_title_foreground(IntPtr raw, IntPtr value);

		public Gdk.Color TitleForeground {
			get {
				unsafe {
					Gdk.Color* raw_ptr = (Gdk.Color*)(((byte*)Handle) + title_foreground_offset);
					return *raw_ptr;
				}
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gnome_druid_page_standard_set_title_foreground(Handle, native_value);
				value = Gdk.Color.New (native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_druid_page_standard_append_item(IntPtr raw, IntPtr question, IntPtr item, IntPtr additional_info);

		public void AppendItem(string question, Gtk.Widget item, string additional_info) {
			IntPtr native_question = GLib.Marshaller.StringToPtrGStrdup (question);
			IntPtr native_additional_info = GLib.Marshaller.StringToPtrGStrdup (additional_info);
			gnome_druid_page_standard_append_item(Handle, native_question, item == null ? IntPtr.Zero : item.Handle, native_additional_info);
			GLib.Marshaller.Free (native_question);
			GLib.Marshaller.Free (native_additional_info);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_druid_page_standard_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gnome_druid_page_standard_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
