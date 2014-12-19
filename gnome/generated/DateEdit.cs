// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class DateEdit : Gtk.HBox {

		[Obsolete]
		protected DateEdit(GLib.GType gtype) : base(gtype) {}
		public DateEdit(IntPtr raw) : base(raw) {}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_date_edit_new_flags(IntPtr the_time, int flags);

		public DateEdit (System.DateTime the_time, Gnome.DateEditFlags flags) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (DateEdit)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				names.Add ("time");
				vals.Add (new GLib.Value (the_time));
				names.Add ("dateedit_flags");
				vals.Add (new GLib.Value (flags));
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			Raw = gnome_date_edit_new_flags(GLib.Marshaller.DateTimeTotime_t (the_time), (int) flags);
		}

		[GLib.Property ("initial_time")]
		public ulong InitialTime {
			get {
				GLib.Value val = GetProperty ("initial_time");
				ulong ret = (ulong) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("initial_time", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("upper_hour")]
		public int UpperHour {
			get {
				GLib.Value val = GetProperty ("upper_hour");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("upper_hour", val);
				val.Dispose ();
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_date_edit_get_time(IntPtr raw);

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_date_edit_set_time(IntPtr raw, IntPtr the_time);

		[GLib.Property ("time")]
		public System.DateTime Time {
			get  {
				IntPtr raw_ret = gnome_date_edit_get_time(Handle);
				System.DateTime ret = GLib.Marshaller.time_tToDateTime (raw_ret);
				return ret;
			}
			set  {
				gnome_date_edit_set_time(Handle, GLib.Marshaller.DateTimeTotime_t (value));
			}
		}

		[GLib.Property ("dateedit_flags")]
		public Gnome.DateEditFlags DateeditFlags {
			get {
				GLib.Value val = GetProperty ("dateedit_flags");
				Gnome.DateEditFlags ret = (Gnome.DateEditFlags) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("dateedit_flags", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("lower_hour")]
		public int LowerHour {
			get {
				GLib.Value val = GetProperty ("lower_hour");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("lower_hour", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DateChangedVMDelegate (IntPtr gde);

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_dateedit_override_date_changed (IntPtr gtype, DateChangedVMDelegate cb);

		static DateChangedVMDelegate DateChangedVMCallback;

		static void datechanged_cb (IntPtr gde)
		{
			try {
				DateEdit gde_managed = GLib.Object.GetObject (gde, false) as DateEdit;
				gde_managed.OnDateChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideDateChanged (GLib.GType gtype)
		{
			if (DateChangedVMCallback == null)
				DateChangedVMCallback = new DateChangedVMDelegate (datechanged_cb);
			gnomesharp_dateedit_override_date_changed (gtype.Val, DateChangedVMCallback);
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_dateedit_base_date_changed (IntPtr gde);

		[GLib.DefaultSignalHandler(Type=typeof(Gnome.DateEdit), ConnectionMethod="OverrideDateChanged")]
		protected virtual void OnDateChanged ()
		{
			gnomesharp_dateedit_base_date_changed (Handle);
		}

		[GLib.Signal("date_changed")]
		public event System.EventHandler DateChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "date_changed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "date_changed");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void TimeChangedVMDelegate (IntPtr gde);

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_dateedit_override_time_changed (IntPtr gtype, TimeChangedVMDelegate cb);

		static TimeChangedVMDelegate TimeChangedVMCallback;

		static void timechanged_cb (IntPtr gde)
		{
			try {
				DateEdit gde_managed = GLib.Object.GetObject (gde, false) as DateEdit;
				gde_managed.OnTimeChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideTimeChanged (GLib.GType gtype)
		{
			if (TimeChangedVMCallback == null)
				TimeChangedVMCallback = new TimeChangedVMDelegate (timechanged_cb);
			gnomesharp_dateedit_override_time_changed (gtype.Val, TimeChangedVMCallback);
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_dateedit_base_time_changed (IntPtr gde);

		[GLib.DefaultSignalHandler(Type=typeof(Gnome.DateEdit), ConnectionMethod="OverrideTimeChanged")]
		protected virtual void OnTimeChanged ()
		{
			gnomesharp_dateedit_base_time_changed (Handle);
		}

		[GLib.Signal("time_changed")]
		public event System.EventHandler TimeChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "time_changed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "time_changed");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_date_edit_get_flags(IntPtr raw);

		public new int Flags { 
			get {
				int raw_ret = gnome_date_edit_get_flags(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_date_edit_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gnome_date_edit_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_date_edit_get_date(IntPtr raw);

		[Obsolete]
		public System.DateTime Date { 
			get {
				IntPtr raw_ret = gnome_date_edit_get_date(Handle);
				System.DateTime ret = GLib.Marshaller.time_tToDateTime (raw_ret);
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_date_edit_set_flags(IntPtr raw, int flags);

		public void SetFlags(Gnome.DateEditFlags flags) {
			gnome_date_edit_set_flags(Handle, (int) flags);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_date_edit_set_popup_range(IntPtr raw, int low_hour, int up_hour);

		public void SetPopupRange(int low_hour, int up_hour) {
			gnome_date_edit_set_popup_range(Handle, low_hour, up_hour);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_date_edit_construct(IntPtr raw, IntPtr the_time, int flags);

		public void Construct(System.DateTime the_time, Gnome.DateEditFlags flags) {
			gnome_date_edit_construct(Handle, GLib.Marshaller.DateTimeTotime_t (the_time), (int) flags);
		}

#endregion
#region Customized extensions
#line 1 "DateEdit.custom"
// DateEdit.custom - Gnome.DateEdit customizations
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
	
		[DllImport("gnomeui-2")]
		static extern IntPtr gnome_date_edit_new(IntPtr the_time, bool show_time, bool use_24_format);

		public DateEdit () : this (System.DateTime.Now, true, false)
		{
		}

		public DateEdit (System.DateTime the_time) : this (the_time, true, false)
		{
		}

		public DateEdit (System.DateTime the_time, bool show_time) : this (the_time, show_time, false)
		{
		}

		public DateEdit (System.DateTime the_time, bool show_time, bool use_24_format) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (DateEdit)) {
				CreateNativeObject (new string[0], new GLib.Value [0]);
				Construct (the_time, ((show_time) ? DateEditFlags.ShowTime : 0) | ((use_24_format) ? DateEditFlags.Two4Hr : 0));
				return;
			}
			Raw = gnome_date_edit_new(GLib.Marshaller.DateTimeTotime_t (the_time), show_time, use_24_format);
		}

#endregion
	}
}