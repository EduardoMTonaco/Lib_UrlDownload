using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lib_UrlDownload
{
    /// <summary>
    /// Return the site http in string
    /// </summary>
    public class UrlDownload : IUrlDownload
    {
        /// <summary>
        /// The url of the site can be set in construtc
        /// </summary>
        public string Url { get; private set; }
        /// <summary>
        /// It can be use without the constructor, but if using the builder, the site url is required
        /// </summary>
        /// <param name="url">The url of the site for string convertion</param>
        public UrlDownload(string url)
        {
            Url = url;
        }
        /// <summary>
        /// Static method to return as a string the html of a site, with cancellationToken
        /// </summary>
        /// <param name="url">site's url</param>
        /// <param name="ct">Cancelation Token</param>
        /// <returns>HTML as string</returns>
        public static async Task<string> GetSiteToString(string url, CancellationToken ct)
        {
            var httpHandler = new HttpClient();

            var task = Task.Factory.StartNew(() => { return httpHandler.GetStringAsync(url); }, ct);

            return await task.Result;
        }
        /// <summary>
        /// Static method to return as a string the html of a site
        /// </summary>
        /// <param name="url">site's url</param>
        /// <returns>HTML as string</returns>
        public static async Task<string> GetSiteToString(string url)
        {
            var httpHandler = new HttpClient();

            var task = Task.Factory.StartNew(() => { return httpHandler.GetStringAsync(url); });

            return await task.Result;
        }
        /// <summary>
        /// method to return as a string the html of a site seted in the constructor, with cancellationToken
        /// </summary>
        /// <param name="ct">Cancelation Token</param>
        /// <returns>HTML as string</returns>
        public async Task<string> GetSiteToString(CancellationToken ct)
        {
            var httpHandler = new HttpClient();

            var task = Task.Factory.StartNew(() => { return httpHandler.GetStringAsync(Url); }, ct);

            return await task.Result;
        }
        /// <summary>
        /// method to return as a string the html of a site seted in the constructor
        /// </summary>
        /// <returns>HTML as string</returns>
        public async Task<string> GetSiteToString()
        {
            var httpHandler = new HttpClient();

            var task = Task.Factory.StartNew(() => { return httpHandler.GetStringAsync(Url); });

            return await task.Result;
        }

    }
}
