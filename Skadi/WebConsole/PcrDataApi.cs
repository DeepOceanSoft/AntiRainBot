using System.Threading.Tasks;
using BeetleX.FastHttpApi;
using Skadi.Tool;
using YukariToolBox.LightLog;

namespace Skadi.WebConsole;

[Controller]
public class PcrDataApi
{
    [Get(Route = "/pcr/rank/update")]
    public Task<JsonResult> PcrRankUpdate(IHttpContext context, string path)
    {
        Log.Debug("PcrRankApi", $"Get PcrRankUpdate api request from {context.Request.RemoteIPAddress}");
        if (!WebUtil.CheckRequestAddress(context))
            return Task.FromResult(WebUtil.GenResult(null, 403, "illegal request"));
        if (string.IsNullOrEmpty(path))
            return Task.FromResult(WebUtil.GenResult(null, 400, "illegal request"));
        return Task.FromResult(WebUtil.GenResult(new {path}));
    }
}