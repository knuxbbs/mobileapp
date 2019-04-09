﻿using System.Linq;
using Toggl.Shared;
using Toggl.Shared.Models;
using Toggl.PrimeRadiant;

namespace Toggl.Foundation.Models
{
    internal partial class WorkspaceFeatureCollection
    {
        public long Id => WorkspaceId;

        public static WorkspaceFeatureCollection From(IWorkspaceFeatureCollection entity)
            => new WorkspaceFeatureCollection(entity);
    }
}
