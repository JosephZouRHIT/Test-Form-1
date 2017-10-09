using System;
using System.Net;
using System.Net.Http;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using HtmlAgilityPack;

public class RHIT_EIT_Network_Connect
{
	public string Connect(string username, string password)
	{
        var client = new WebClient();
        client.UseDefaultCredentials = true;
        client.Credentials = new NetworkCredential(username, password);
        var contents = client.DownloadString("https://netreg.rose-hulman.edu/tools/networkUsage.pl");
        var htmldoc = new HtmlDocument();
        htmldoc.LoadHtml(contents);
        var node = htmldoc.DocumentNode.SelectSingleNode("//div[@class='mainContainer']");
        return node.InnerText;
	}
}
