﻿using System.Reflection;

namespace Blogifier.Core.Common
{
	public class ApplicationSettings
    {
        public static bool UseInMemoryDatabase { get; set; } = true;

        public static string ConnectionString { get; set; } = @"Server=.\SQLEXPRESS;Database=Blogifier;Trusted_Connection=True;";

        public static string Title { get; set; } = "Blog Name";

		public static string Description { get; set; } = "Short description of the blog";

		public static int ItemsPerPage { get; set; } = 10;

		public static string WebRootPath { get; set; }

		public static string ContentRootPath { get; set; }

        public static bool AddContentTypeHeaders { get; set; }

        public static bool AddContentLengthHeaders { get; set; }

        public static bool PrependFileProvider { get; set; }
        
        public static string SupportedStorageFiles { get; set; } = "zip,txt,mp3,mp4,pdf,doc,docx,xls,xlsx,xml";

		public static string Version
		{
			get
			{
				return typeof(ApplicationSettings)
					.GetTypeInfo()
					.Assembly
					.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
					.InformationalVersion;
			}
		}

		public static string OSDescription
		{
			get
			{
				return System.Runtime.InteropServices.RuntimeInformation.OSDescription;
			}
		}
	}
}