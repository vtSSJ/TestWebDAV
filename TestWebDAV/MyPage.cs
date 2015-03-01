using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Sphorium.WebDAV.Server.Framework;

namespace Sphorium.WebDAV.Examples.FileServer
{
	public class MyPage
	{
		public bool Execute()
		{
			var httpApplication = System.Web.HttpContext.Current;
			var request = System.Web.HttpContext.Current.Request;
			var isWebDavRequest = false;
			var requestHttpMethod = request.HttpMethod.ToUpper();
			switch (requestHttpMethod)
			{
				case "GET":
					//Don't process WebDAV requests for the root and for files that exist (ie. default.aspx)
					var mappedPath = httpApplication.Server.MapPath(request.Url.LocalPath);
					isWebDavRequest = !File.Exists(mappedPath);
					break;
				case "PUT":
				case "HEAD":
				case "OPTIONS":
				case "LOCK":
				case "UNLOCK":
				case "PROPFIND":
				case "PROPPATCH":
					isWebDavRequest = true;
					break;
			}
			if (!isWebDavRequest)
				return false;
			var webDavProcessor = new WebDavProcessor();
			webDavProcessor.ProcessRequest(httpApplication.ApplicationInstance);
			return true;
		}
	}
}