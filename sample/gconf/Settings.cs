namespace Sample
{
	public class Settings
	{
		static GConf.Client client = new GConf.Client ();

		public static event GConf.NotifyEventHandler Changed
		{
			add {
				client.AddNotify ("/apps/gconfsharp/sample_app", value);
			}
			remove{
				client.RemoveNotify ("/apps/gconfsharp/sample_app", value);
			}
		}

		public static double TheFloat
		{
			get {
				return (double) client.Get ("/apps/gconfsharp/sample_app/the_float");
			}
			set {
				client.Set ("/apps/gconfsharp/sample_app/the_float", value);
			}
		}

		public static event GConf.NotifyEventHandler TheFloatChanged
		{
			add {
				client.AddNotify ("/apps/gconfsharp/sample_app/the_float", value);
			}
			remove{
				client.RemoveNotify ("/apps/gconfsharp/sample_app/the_float", value);
			}
		}

		public static bool Enable
		{
			get {
				return (bool) client.Get ("/apps/gconfsharp/sample_app/enable");
			}
			set {
				client.Set ("/apps/gconfsharp/sample_app/enable", value);
			}
		}

		public static event GConf.NotifyEventHandler EnableChanged
		{
			add {
				client.AddNotify ("/apps/gconfsharp/sample_app/enable", value);
			}
			remove{
				client.RemoveNotify ("/apps/gconfsharp/sample_app/enable", value);
			}
		}

		public static int TheInteger
		{
			get {
				return (int) client.Get ("/apps/gconfsharp/sample_app/the_integer");
			}
			set {
				client.Set ("/apps/gconfsharp/sample_app/the_integer", value);
			}
		}

		public static event GConf.NotifyEventHandler TheIntegerChanged
		{
			add {
				client.AddNotify ("/apps/gconfsharp/sample_app/the_integer", value);
			}
			remove{
				client.RemoveNotify ("/apps/gconfsharp/sample_app/the_integer", value);
			}
		}

		public static string TheFilename
		{
			get {
				return (string) client.Get ("/apps/gconfsharp/sample_app/the_filename");
			}
			set {
				client.Set ("/apps/gconfsharp/sample_app/the_filename", value);
			}
		}

		public static event GConf.NotifyEventHandler TheFilenameChanged
		{
			add {
				client.AddNotify ("/apps/gconfsharp/sample_app/the_filename", value);
			}
			remove{
				client.RemoveNotify ("/apps/gconfsharp/sample_app/the_filename", value);
			}
		}

		public static Sample.Direction TheSecondEnum
		{
			get {
				try {
					return (Sample.Direction) System.Enum.Parse (typeof (Sample.Direction), (string) client.Get ("/apps/gconfsharp/sample_app/the_second_enum"));
				} catch (System.Exception e) {
					return (Sample.Direction) 0;
				}
			}
			set {
				client.Set ("/apps/gconfsharp/sample_app/the_second_enum", System.Enum.GetName (typeof (Sample.Direction), value));
			}
		}

		public static event GConf.NotifyEventHandler TheSecondEnumChanged
		{
			add {
				client.AddNotify ("/apps/gconfsharp/sample_app/the_second_enum", value);
			}
			remove{
				client.RemoveNotify ("/apps/gconfsharp/sample_app/the_second_enum", value);
			}
		}

		public static Sample.Names TheFirstEnum
		{
			get {
				try {
					return (Sample.Names) System.Enum.Parse (typeof (Sample.Names), (string) client.Get ("/apps/gconfsharp/sample_app/the_first_enum"));
				} catch (System.Exception e) {
					return (Sample.Names) 0;
				}
			}
			set {
				client.Set ("/apps/gconfsharp/sample_app/the_first_enum", System.Enum.GetName (typeof (Sample.Names), value));
			}
		}

		public static event GConf.NotifyEventHandler TheFirstEnumChanged
		{
			add {
				client.AddNotify ("/apps/gconfsharp/sample_app/the_first_enum", value);
			}
			remove{
				client.RemoveNotify ("/apps/gconfsharp/sample_app/the_first_enum", value);
			}
		}

		public static string TheText
		{
			get {
				return (string) client.Get ("/apps/gconfsharp/sample_app/the_text");
			}
			set {
				client.Set ("/apps/gconfsharp/sample_app/the_text", value);
			}
		}

		public static event GConf.NotifyEventHandler TheTextChanged
		{
			add {
				client.AddNotify ("/apps/gconfsharp/sample_app/the_text", value);
			}
			remove{
				client.RemoveNotify ("/apps/gconfsharp/sample_app/the_text", value);
			}
		}
	}

	public class SettingKeys
	{
		public static string TheFloat
		{
			get {
				 return "/apps/gconfsharp/sample_app/the_float";
			}
		}
		public static string Enable
		{
			get {
				 return "/apps/gconfsharp/sample_app/enable";
			}
		}
		public static string TheInteger
		{
			get {
				 return "/apps/gconfsharp/sample_app/the_integer";
			}
		}
		public static string TheFilename
		{
			get {
				 return "/apps/gconfsharp/sample_app/the_filename";
			}
		}
		public static string TheSecondEnum
		{
			get {
				 return "/apps/gconfsharp/sample_app/the_second_enum";
			}
		}
		public static string TheFirstEnum
		{
			get {
				 return "/apps/gconfsharp/sample_app/the_first_enum";
			}
		}
		public static string TheText
		{
			get {
				 return "/apps/gconfsharp/sample_app/the_text";
			}
		}
	}
}
