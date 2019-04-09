﻿using Toggl.Shared.Models;

namespace Toggl.Ultrawave.ApiClients
{
    public interface ITagsApi
        : IPullingApiClient<ITag>,
          IPullingChangedApiClient<ITag>,
          ICreatingApiClient<ITag>
    {
    }
}
