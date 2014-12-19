// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Client : Gtk.Object {

		[Obsolete]
		protected Client(GLib.GType gtype) : base(gtype) {}
		public Client(IntPtr raw) : base(raw) {}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_client_new();

		public Client () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Client)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gnome_client_new();
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_client_new_without_connection();

		public static Client NewWithoutConnection()
		{
			Client result = new Client (gnome_client_new_without_connection());
			return result;
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_user_id(IntPtr raw, IntPtr id);

		public string UserId {
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gnome_client_set_user_id(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_client_get_config_prefix(IntPtr raw);

		public string ConfigPrefix {
			get  {
				IntPtr raw_ret = gnome_client_get_config_prefix(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_client_get_global_config_prefix(IntPtr raw);

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_global_config_prefix(IntPtr raw, IntPtr prefix);

		public string GlobalConfigPrefix {
			get  {
				IntPtr raw_ret = gnome_client_get_global_config_prefix(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gnome_client_set_global_config_prefix(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_client_get_previous_id(IntPtr raw);

		public string PreviousId {
			get  {
				IntPtr raw_ret = gnome_client_get_previous_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_current_directory(IntPtr raw, IntPtr dir);

		public string CurrentDirectory {
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gnome_client_set_current_directory(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_program(IntPtr raw, IntPtr program);

		public string Program {
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gnome_client_set_program(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_restart_style(IntPtr raw, int style);

		public Gnome.RestartStyle RestartStyle {
			set  {
				gnome_client_set_restart_style(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ConnectedVMDelegate (IntPtr client, bool restarted);

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_client_override_connect (IntPtr gtype, ConnectedVMDelegate cb);

		static ConnectedVMDelegate ConnectedVMCallback;

		static void connected_cb (IntPtr client, bool restarted)
		{
			try {
				Client client_managed = GLib.Object.GetObject (client, false) as Client;
				client_managed.OnConnected (restarted);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideConnected (GLib.GType gtype)
		{
			if (ConnectedVMCallback == null)
				ConnectedVMCallback = new ConnectedVMDelegate (connected_cb);
			gnomesharp_client_override_connect (gtype.Val, ConnectedVMCallback);
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_client_base_connect (IntPtr client, bool restarted);

		[GLib.DefaultSignalHandler(Type=typeof(Gnome.Client), ConnectionMethod="OverrideConnected")]
		protected virtual void OnConnected (bool restarted)
		{
			gnomesharp_client_base_connect (Handle, restarted);
		}

		[GLib.Signal("connect")]
		public event Gnome.ConnectedHandler Connected {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "connect", typeof (Gnome.ConnectedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "connect", typeof (Gnome.ConnectedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SaveCompleteVMDelegate (IntPtr client);

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_client_override_save_complete (IntPtr gtype, SaveCompleteVMDelegate cb);

		static SaveCompleteVMDelegate SaveCompleteVMCallback;

		static void savecomplete_cb (IntPtr client)
		{
			try {
				Client client_managed = GLib.Object.GetObject (client, false) as Client;
				client_managed.OnSaveComplete ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideSaveComplete (GLib.GType gtype)
		{
			if (SaveCompleteVMCallback == null)
				SaveCompleteVMCallback = new SaveCompleteVMDelegate (savecomplete_cb);
			gnomesharp_client_override_save_complete (gtype.Val, SaveCompleteVMCallback);
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_client_base_save_complete (IntPtr client);

		[GLib.DefaultSignalHandler(Type=typeof(Gnome.Client), ConnectionMethod="OverrideSaveComplete")]
		protected virtual void OnSaveComplete ()
		{
			gnomesharp_client_base_save_complete (Handle);
		}

		[GLib.Signal("save_complete")]
		public event System.EventHandler SaveComplete {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "save_complete");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "save_complete");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DisconnectedVMDelegate (IntPtr client);

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_client_override_disconnect (IntPtr gtype, DisconnectedVMDelegate cb);

		static DisconnectedVMDelegate DisconnectedVMCallback;

		static void disconnected_cb (IntPtr client)
		{
			try {
				Client client_managed = GLib.Object.GetObject (client, false) as Client;
				client_managed.OnDisconnected ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideDisconnected (GLib.GType gtype)
		{
			if (DisconnectedVMCallback == null)
				DisconnectedVMCallback = new DisconnectedVMDelegate (disconnected_cb);
			gnomesharp_client_override_disconnect (gtype.Val, DisconnectedVMCallback);
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_client_base_disconnect (IntPtr client);

		[GLib.DefaultSignalHandler(Type=typeof(Gnome.Client), ConnectionMethod="OverrideDisconnected")]
		protected virtual void OnDisconnected ()
		{
			gnomesharp_client_base_disconnect (Handle);
		}

		[GLib.Signal("disconnect")]
		public event System.EventHandler Disconnected {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "disconnect");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "disconnect");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SaveYourselfVMDelegate (IntPtr client, int phase, int save_style, bool shutdown, int interact_style, bool fast);

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_client_override_save_yourself (IntPtr gtype, SaveYourselfVMDelegate cb);

		static SaveYourselfVMDelegate SaveYourselfVMCallback;

		static bool saveyourself_cb (IntPtr client, int phase, int save_style, bool shutdown, int interact_style, bool fast)
		{
			try {
				Client client_managed = GLib.Object.GetObject (client, false) as Client;
				return client_managed.OnSaveYourself (phase, (Gnome.SaveStyle) save_style, shutdown, (Gnome.InteractStyle) interact_style, fast);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call doesn't return
				throw e;
			}
		}

		private static void OverrideSaveYourself (GLib.GType gtype)
		{
			if (SaveYourselfVMCallback == null)
				SaveYourselfVMCallback = new SaveYourselfVMDelegate (saveyourself_cb);
			gnomesharp_client_override_save_yourself (gtype.Val, SaveYourselfVMCallback);
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gnomesharp_client_base_save_yourself (IntPtr client, int phase, int save_style, bool shutdown, int interact_style, bool fast);

		[GLib.DefaultSignalHandler(Type=typeof(Gnome.Client), ConnectionMethod="OverrideSaveYourself")]
		protected virtual bool OnSaveYourself (int phase, Gnome.SaveStyle save_style, bool shutdown, Gnome.InteractStyle interact_style, bool fast)
		{
			bool __ret = gnomesharp_client_base_save_yourself (Handle, phase, (int) save_style, shutdown, (int) interact_style, fast);
			return __ret;
		}

		[GLib.Signal("save_yourself")]
		public event Gnome.SaveYourselfHandler SaveYourself {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "save_yourself", typeof (Gnome.SaveYourselfArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "save_yourself", typeof (Gnome.SaveYourselfArgs));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DieVMDelegate (IntPtr client);

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_client_override_die (IntPtr gtype, DieVMDelegate cb);

		static DieVMDelegate DieVMCallback;

		static void die_cb (IntPtr client)
		{
			try {
				Client client_managed = GLib.Object.GetObject (client, false) as Client;
				client_managed.OnDie ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideDie (GLib.GType gtype)
		{
			if (DieVMCallback == null)
				DieVMCallback = new DieVMDelegate (die_cb);
			gnomesharp_client_override_die (gtype.Val, DieVMCallback);
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_client_base_die (IntPtr client);

		[GLib.DefaultSignalHandler(Type=typeof(Gnome.Client), ConnectionMethod="OverrideDie")]
		protected virtual void OnDie ()
		{
			gnomesharp_client_base_die (Handle);
		}

		[GLib.Signal("die")]
		public event System.EventHandler Die {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "die");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "die");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ShutdownCancelledVMDelegate (IntPtr client);

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_client_override_shutdown_cancelled (IntPtr gtype, ShutdownCancelledVMDelegate cb);

		static ShutdownCancelledVMDelegate ShutdownCancelledVMCallback;

		static void shutdowncancelled_cb (IntPtr client)
		{
			try {
				Client client_managed = GLib.Object.GetObject (client, false) as Client;
				client_managed.OnShutdownCancelled ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideShutdownCancelled (GLib.GType gtype)
		{
			if (ShutdownCancelledVMCallback == null)
				ShutdownCancelledVMCallback = new ShutdownCancelledVMDelegate (shutdowncancelled_cb);
			gnomesharp_client_override_shutdown_cancelled (gtype.Val, ShutdownCancelledVMCallback);
		}

		[DllImport ("gnomesharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnomesharp_client_base_shutdown_cancelled (IntPtr client);

		[GLib.DefaultSignalHandler(Type=typeof(Gnome.Client), ConnectionMethod="OverrideShutdownCancelled")]
		protected virtual void OnShutdownCancelled ()
		{
			gnomesharp_client_base_shutdown_cancelled (Handle);
		}

		[GLib.Signal("shutdown_cancelled")]
		public event System.EventHandler ShutdownCancelled {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "shutdown_cancelled");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "shutdown_cancelled");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_save_any_dialog(IntPtr raw, IntPtr dialog);

		public void SaveAnyDialog(Gtk.Dialog dialog) {
			gnome_client_save_any_dialog(Handle, dialog == null ? IntPtr.Zero : dialog.Handle);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_client_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gnome_client_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_environment(IntPtr raw, IntPtr name, IntPtr value);

		public void SetEnvironment(string name, string value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			gnome_client_set_environment(Handle, native_name, native_value);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_value);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_resign_command(IntPtr raw, int argc, IntPtr[] argv);

		public void SetResignCommand(int argc, string[] argv) {
			int cnt_argv = argv == null ? 0 : argv.Length;
			IntPtr[] native_argv = new IntPtr [cnt_argv];
			for (int i = 0; i < cnt_argv; i++)
				native_argv [i] = GLib.Marshaller.StringToPtrGStrdup(argv[i]);
			gnome_client_set_resign_command(Handle, argc, native_argv);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_client_get_desktop_id(IntPtr raw);

		public string DesktopId { 
			get {
				IntPtr raw_ret = gnome_client_get_desktop_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_request_phase_2(IntPtr raw);

		public void RequestPhase2() {
			gnome_client_request_phase_2(Handle);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_save_error_dialog(IntPtr raw, IntPtr dialog);

		public void SaveErrorDialog(Gtk.Dialog dialog) {
			gnome_client_save_error_dialog(Handle, dialog == null ? IntPtr.Zero : dialog.Handle);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_connect(IntPtr raw);

		public void Connect() {
			gnome_client_connect(Handle);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_disconnect(IntPtr raw);

		public void Disconnect() {
			gnome_client_disconnect(Handle);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_discard_command(IntPtr raw, int argc, IntPtr[] argv);

		public void SetDiscardCommand(int argc, string[] argv) {
			int cnt_argv = argv == null ? 0 : argv.Length;
			IntPtr[] native_argv = new IntPtr [cnt_argv];
			for (int i = 0; i < cnt_argv; i++)
				native_argv [i] = GLib.Marshaller.StringToPtrGStrdup(argv[i]);
			gnome_client_set_discard_command(Handle, argc, native_argv);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_client_get_id(IntPtr raw);

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_id(IntPtr raw, IntPtr id);

		public string Id { 
			get {
				IntPtr raw_ret = gnome_client_get_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gnome_client_set_id(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_request_interaction(IntPtr raw, int dialog_type, GnomeSharp.InteractFunctionNative function, IntPtr data);

		public void RequestInteraction(Gnome.DialogType dialog_type, Gnome.InteractFunction function) {
			GnomeSharp.InteractFunctionWrapper function_wrapper = new GnomeSharp.InteractFunctionWrapper (function);
			gnome_client_request_interaction(Handle, (int) dialog_type, function_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_request_interaction_interp(IntPtr raw, int dialog_type, GtkSharp.CallbackMarshalNative function, IntPtr data, GtkSharp.DestroyNotifyNative destroy);

		public void RequestInteractionInterp(Gnome.DialogType dialog_type, Gtk.CallbackMarshal function, Gtk.DestroyNotify destroy) {
			GtkSharp.CallbackMarshalWrapper function_wrapper = new GtkSharp.CallbackMarshalWrapper (function);
			GtkSharp.DestroyNotifyWrapper destroy_wrapper = new GtkSharp.DestroyNotifyWrapper (destroy);
			gnome_client_request_interaction_interp(Handle, (int) dialog_type, function_wrapper.NativeDelegate, IntPtr.Zero, destroy_wrapper.NativeDelegate);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_disable_master_connection();

		[Obsolete]
		public static void DisableMasterConnection() {
			gnome_client_disable_master_connection();
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_client_module_info_get();

		public static Gnome.ModuleInfo ModuleInfoGet() {
			IntPtr raw_ret = gnome_client_module_info_get();
			Gnome.ModuleInfo ret = raw_ret == IntPtr.Zero ? null : (Gnome.ModuleInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (Gnome.ModuleInfo), false);
			return ret;
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_clone_command(IntPtr raw, int argc, IntPtr[] argv);

		public void SetCloneCommand(int argc, string[] argv) {
			int cnt_argv = argv == null ? 0 : argv.Length;
			IntPtr[] native_argv = new IntPtr [cnt_argv];
			for (int i = 0; i < cnt_argv; i++)
				native_argv [i] = GLib.Marshaller.StringToPtrGStrdup(argv[i]);
			gnome_client_set_clone_command(Handle, argc, native_argv);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_shutdown_command(IntPtr raw, int argc, IntPtr[] argv);

		public void SetShutdownCommand(int argc, string[] argv) {
			int cnt_argv = argv == null ? 0 : argv.Length;
			IntPtr[] native_argv = new IntPtr [cnt_argv];
			for (int i = 0; i < cnt_argv; i++)
				native_argv [i] = GLib.Marshaller.StringToPtrGStrdup(argv[i]);
			gnome_client_set_shutdown_command(Handle, argc, native_argv);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_request_save(IntPtr raw, int save_style, bool shutdown, int interact_style, bool fast, bool global);

		public void RequestSave(Gnome.SaveStyle save_style, bool shutdown, Gnome.InteractStyle interact_style, bool fast, bool global) {
			gnome_client_request_save(Handle, (int) save_style, shutdown, (int) interact_style, fast, global);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_flush(IntPtr raw);

		public void Flush() {
			gnome_client_flush(Handle);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_client_get_flags(IntPtr raw);

		public Gnome.ClientFlags Flags { 
			get {
				int raw_ret = gnome_client_get_flags(Handle);
				Gnome.ClientFlags ret = (Gnome.ClientFlags) raw_ret;
				return ret;
			}
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_restart_command(IntPtr raw, int argc, IntPtr[] argv);

		public void SetRestartCommand(int argc, string[] argv) {
			int cnt_argv = argv == null ? 0 : argv.Length;
			IntPtr[] native_argv = new IntPtr [cnt_argv];
			for (int i = 0; i < cnt_argv; i++)
				native_argv [i] = GLib.Marshaller.StringToPtrGStrdup(argv[i]);
			gnome_client_set_restart_command(Handle, argc, native_argv);
		}

		[DllImport("gnomeui-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_client_set_priority(IntPtr raw, uint priority);

		public uint Priority { 
			set {
				gnome_client_set_priority(Handle, value);
			}
		}

#endregion
#region Customized extensions
#line 1 "Client.custom"
// Client.custom - Gnome.Client customizations
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

		[Obsolete("Replaced by overload with no IntPtr arg")]
		public void RequestInteractionInterp (Gnome.DialogType dialog_type, Gtk.CallbackMarshal function, IntPtr data, Gtk.DestroyNotify destroy)
		{
			RequestInteractionInterp (dialog_type, function, destroy);
		}

#endregion
	}
}