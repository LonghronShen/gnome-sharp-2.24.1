// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class AppBar : Gtk.HBox {

		[Obsolete]
		protected AppBar(GLib.GType gtype) : base(gtype) {}
		public AppBar(IntPtr raw) : base(raw) {}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_appbar_new(bool has_progress, bool has_status, int interactivity);

		public AppBar (bool has_progress, bool has_status, Gnome.PreferencesType interactivity) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (AppBar)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				names.Add ("has_progress");
				vals.Add (new GLib.Value (has_progress));
				names.Add ("has_status");
				vals.Add (new GLib.Value (has_status));
				names.Add ("interactivity");
				vals.Add (new GLib.Value (interactivity));
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			Raw = gnome_appbar_new(has_progress, has_status, (int) interactivity);
		}

		[GLib.Property ("has_status")]
		public bool HasStatus {
			get {
				GLib.Value val = GetProperty ("has_status");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("has_status", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("has_progress")]
		public bool HasProgress {
			get {
				GLib.Value val = GetProperty ("has_progress");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("has_progress", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("interactivity")]
		public Gnome.PreferencesType Interactivity {
			get {
				GLib.Value val = GetProperty ("interactivity");
				Gnome.PreferencesType ret = (Gnome.PreferencesType) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("interactivity", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UserResponseVMDelegate (IntPtr ab);

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_appbar_override_user_response (IntPtr gtype, UserResponseVMDelegate cb);

		static UserResponseVMDelegate UserResponseVMCallback;

		static void userresponse_cb (IntPtr ab)
		{
			try {
				AppBar ab_managed = GLib.Object.GetObject (ab, false) as AppBar;
				ab_managed.OnUserResponse ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideUserResponse (GLib.GType gtype)
		{
			if (UserResponseVMCallback == null)
				UserResponseVMCallback = new UserResponseVMDelegate (userresponse_cb);
			gnomesharp_appbar_override_user_response (gtype.Val, UserResponseVMCallback);
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_appbar_base_user_response (IntPtr ab);

		[GLib.DefaultSignalHandler(Type=typeof(Gnome.AppBar), ConnectionMethod="OverrideUserResponse")]
		protected virtual void OnUserResponse ()
		{
			gnomesharp_appbar_base_user_response (Handle);
		}

		[GLib.Signal("user_response")]
		public event System.EventHandler UserResponse {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "user_response");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "user_response");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PromptClearedVMDelegate (IntPtr ab);

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_appbar_override_clear_prompt (IntPtr gtype, PromptClearedVMDelegate cb);

		static PromptClearedVMDelegate PromptClearedVMCallback;

		static void promptcleared_cb (IntPtr ab)
		{
			try {
				AppBar ab_managed = GLib.Object.GetObject (ab, false) as AppBar;
				ab_managed.OnPromptCleared ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverridePromptCleared (GLib.GType gtype)
		{
			if (PromptClearedVMCallback == null)
				PromptClearedVMCallback = new PromptClearedVMDelegate (promptcleared_cb);
			gnomesharp_appbar_override_clear_prompt (gtype.Val, PromptClearedVMCallback);
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_appbar_base_clear_prompt (IntPtr ab);

		[GLib.DefaultSignalHandler(Type=typeof(Gnome.AppBar), ConnectionMethod="OverridePromptCleared")]
		protected virtual void OnPromptCleared ()
		{
			gnomesharp_appbar_base_clear_prompt (Handle);
		}

		[GLib.Signal("clear_prompt")]
		public event System.EventHandler PromptCleared {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "clear_prompt");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "clear_prompt");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_appbar_set_status(IntPtr raw, IntPtr status);

		public void SetStatus(string status) {
			IntPtr native_status = GLib.Marshaller.StringToPtrGStrdup (status);
			gnome_appbar_set_status(Handle, native_status);
			GLib.Marshaller.Free (native_status);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_appbar_set_prompt(IntPtr raw, IntPtr prompt, bool modal);

		public void SetPrompt(string prompt, bool modal) {
			IntPtr native_prompt = GLib.Marshaller.StringToPtrGStrdup (prompt);
			gnome_appbar_set_prompt(Handle, native_prompt, modal);
			GLib.Marshaller.Free (native_prompt);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_appbar_set_progress_percentage(IntPtr raw, float percentage);

		public float ProgressPercentage { 
			set {
				gnome_appbar_set_progress_percentage(Handle, value);
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_appbar_refresh(IntPtr raw);

		public void Refresh() {
			gnome_appbar_refresh(Handle);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_appbar_set_default(IntPtr raw, IntPtr default_status);

		public string Default { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gnome_appbar_set_default(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_appbar_get_progress(IntPtr raw);

		public Gtk.ProgressBar Progress { 
			get {
				IntPtr raw_ret = gnome_appbar_get_progress(Handle);
				Gtk.ProgressBar ret = GLib.Object.GetObject(raw_ret) as Gtk.ProgressBar;
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_appbar_push(IntPtr raw, IntPtr status);

		public void Push(string status) {
			IntPtr native_status = GLib.Marshaller.StringToPtrGStrdup (status);
			gnome_appbar_push(Handle, native_status);
			GLib.Marshaller.Free (native_status);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_appbar_get_status(IntPtr raw);

		public Gtk.Widget Status { 
			get {
				IntPtr raw_ret = gnome_appbar_get_status(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_appbar_get_response(IntPtr raw);

		public string Response { 
			get {
				IntPtr raw_ret = gnome_appbar_get_response(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_appbar_clear_prompt(IntPtr raw);

		public void ClearPrompt() {
			gnome_appbar_clear_prompt(Handle);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_appbar_pop(IntPtr raw);

		public void Pop() {
			gnome_appbar_pop(Handle);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_appbar_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gnome_appbar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_appbar_clear_stack(IntPtr raw);

		public void ClearStack() {
			gnome_appbar_clear_stack(Handle);
		}

#endregion
	}
}