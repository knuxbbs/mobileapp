﻿using Toggl.Core.Analytics;
using Toggl.Core.Models;
using Toggl.Core.UI.Parameters;
using Toggl.Core.Services;
using Toggl.Shared;
using Toggl.Shared.Extensions;

namespace Toggl.Core.UI.ViewModels.ReportsCalendar.QuickSelectShortcuts
{
    public sealed class ReportsCalendarTodayQuickSelectShortcut : ReportsCalendarBaseQuickSelectShortcut
    {
        public ReportsCalendarTodayQuickSelectShortcut(ITimeService timeService)
            : base(timeService, Resources.Today, ReportPeriod.Today)
        {
        }

        public override ReportsDateRange GetDateRange()
        {
            var today = TimeService.CurrentDateTime.RoundDownToLocalDate();
            return ReportsDateRange
                .WithDates(today, today)
                .WithSource(ReportsSource.ShortcutToday);
        }
    }
}
