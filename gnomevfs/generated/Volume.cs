// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gnome.Vfs {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Volume : GLib.Object {

		[Obsolete]
		protected Volume(GLib.GType gtype) : base(gtype) {}
		public Volume(IntPtr raw) : base(raw) {}

		protected Volume() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_vfs_volume_get_drive(IntPtr raw);

		public Gnome.Vfs.Drive Drive { 
			get {
				IntPtr raw_ret = gnome_vfs_volume_get_drive(Handle);
				Gnome.Vfs.Drive ret = GLib.Object.GetObject(raw_ret) as Gnome.Vfs.Drive;
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_vfs_volume_get_filesystem_type(IntPtr raw);

		public string FilesystemType { 
			get {
				IntPtr raw_ret = gnome_vfs_volume_get_filesystem_type(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_vfs_volume_get_display_name(IntPtr raw);

		public string DisplayName { 
			get {
				IntPtr raw_ret = gnome_vfs_volume_get_display_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_vfs_volume_get_hal_udi(IntPtr raw);

		public string HalUdi { 
			get {
				IntPtr raw_ret = gnome_vfs_volume_get_hal_udi(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_vfs_volume_get_icon(IntPtr raw);

		public string Icon { 
			get {
				IntPtr raw_ret = gnome_vfs_volume_get_icon(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gnome_vfs_volume_get_id(IntPtr raw);

		public ulong Id { 
			get {
				UIntPtr raw_ret = gnome_vfs_volume_get_id(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gnome_vfs_volume_is_mounted(IntPtr raw);

		public bool IsMounted { 
			get {
				bool raw_ret = gnome_vfs_volume_is_mounted(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_vfs_volume_get_activation_uri(IntPtr raw);

		public string ActivationUri { 
			get {
				IntPtr raw_ret = gnome_vfs_volume_get_activation_uri(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_vfs_volume_get_device_path(IntPtr raw);

		public string DevicePath { 
			get {
				IntPtr raw_ret = gnome_vfs_volume_get_device_path(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_vfs_volume_eject(IntPtr raw, Gnome.VfsSharp.VolumeOpCallbackNative cb, IntPtr user_data);

		public void Eject(Gnome.Vfs.VolumeOpCallback cb) {
			Gnome.VfsSharp.VolumeOpCallbackWrapper cb_wrapper = new Gnome.VfsSharp.VolumeOpCallbackWrapper (cb);
			gnome_vfs_volume_eject(Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gnome_vfs_volume_unmount(IntPtr raw, Gnome.VfsSharp.VolumeOpCallbackNative cb, IntPtr user_data);

		public void Unmount(Gnome.Vfs.VolumeOpCallback cb) {
			Gnome.VfsSharp.VolumeOpCallbackWrapper cb_wrapper = new Gnome.VfsSharp.VolumeOpCallbackWrapper (cb);
			gnome_vfs_volume_unmount(Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_volume_get_volume_type(IntPtr raw);

		public Gnome.Vfs.VolumeType VolumeType { 
			get {
				int raw_ret = gnome_vfs_volume_get_volume_type(Handle);
				Gnome.Vfs.VolumeType ret = (Gnome.Vfs.VolumeType) raw_ret;
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_volume_compare(IntPtr raw, IntPtr b);

		public int Compare(Gnome.Vfs.Volume b) {
			int raw_ret = gnome_vfs_volume_compare(Handle, b == null ? IntPtr.Zero : b.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gnome_vfs_volume_is_user_visible(IntPtr raw);

		public bool IsUserVisible { 
			get {
				bool raw_ret = gnome_vfs_volume_is_user_visible(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gnome_vfs_volume_handles_trash(IntPtr raw);

		public bool HandlesTrash { 
			get {
				bool raw_ret = gnome_vfs_volume_handles_trash(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gnome_vfs_volume_is_read_only(IntPtr raw);

		public bool IsReadOnly { 
			get {
				bool raw_ret = gnome_vfs_volume_is_read_only(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern int gnome_vfs_volume_get_device_type(IntPtr raw);

		public Gnome.Vfs.DeviceType DeviceType { 
			get {
				int raw_ret = gnome_vfs_volume_get_device_type(Handle);
				Gnome.Vfs.DeviceType ret = (Gnome.Vfs.DeviceType) raw_ret;
				return ret;
			}
		}

		[DllImport("gnomevfs-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gnome_vfs_volume_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gnome_vfs_volume_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static Volume ()
		{
			GtkSharp.GnomeVfsSharp.ObjectManager.Initialize ();
		}
#endregion
	}
}
