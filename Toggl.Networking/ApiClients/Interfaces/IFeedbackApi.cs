﻿using System;
using System.Collections.Generic;
using System.Reactive;
using Toggl.Shared;

namespace Toggl.Ultrawave.ApiClients
{
    public interface IFeedbackApi
    {
        IObservable<Unit> Send(Email email, string message, IDictionary<string, string> data);
    }
}
