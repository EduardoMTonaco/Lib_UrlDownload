using System.Threading;
using System.Threading.Tasks;

namespace Lib_UrlDownload
{
    /// <summary>
    /// Interface to return the site http in string
    /// </summary>
    public interface IUrlDownload
    {
        /// <summary>
        /// The url of the site can be set in construtc
        /// </summary>
        string Url { get; }
        /// <summary>
        /// method to return as a string the html of a site seted in the constructor
        /// </summary>
        /// <returns>HTML as string</returns>
        Task<string> SiteToString();
        /// <summary>
        /// method to return as a string the html of a site seted in the constructor, with cancellationToken
        /// </summary>
        /// <param name="ct">Cancelation Token</param>
        /// <returns>HTML as string</returns>
        Task<string> SiteToString(CancellationToken ct);
    }
}