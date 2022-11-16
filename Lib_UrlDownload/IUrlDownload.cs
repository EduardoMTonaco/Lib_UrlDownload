using System.Threading;
using System.Threading.Tasks;

namespace Lib_UrlDownload
{
    public interface IUrlDownload
    {
        string Url { get; }

        Task<string> SiteToString();
        Task<string> SiteToString(CancellationToken ct);
    }
}