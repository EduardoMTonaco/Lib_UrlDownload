# Lib_UrlDownload
Class to convert site's HTML in string, async method

This class has one string Url, private set and public get,
One constructor, that receive the string Url,
Two statics methods that retorns the site html as string and it is needed pass the url ans a parameter, one has a cancelation token as a parameter,
Two functions to return the URL's HTML as string , the url was passed on the constructor 
All functions are async

This project has a interface IUrlDownload, has string Url, the ascyn function SiteToString() and SiteToString(CancellationToken ct).




