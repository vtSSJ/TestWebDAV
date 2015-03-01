<%@ Page Language="C#" AutoEventWireup="true" %>
<%@ Import Namespace="Sphorium.WebDAV.Examples.FileServer" %>
<%
    var o = new MyPage();
//    if (!o.Execute())
    { %>
        <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
        <html xmlns="http://www.w3.org/1999/xhtml">
        <head runat="server">
	        <title>WebDAV.NET Framework Example</title>
        </head>
        <body>
		        <h4 align="center">
			        This is a simple example on how to use the WebDAV Server framework<br />
		        </h4>
		        <p align="center">
		            Open file: <a href="ms-word:http://localhost:49416/tz7.doc">Test</a>
		        </p>
        </body>
        </html>
    <% }
%>
