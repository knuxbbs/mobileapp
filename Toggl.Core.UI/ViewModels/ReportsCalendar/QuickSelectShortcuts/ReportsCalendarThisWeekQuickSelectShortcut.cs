﻿using Toggl.Foundation.Analytics;
using Toggl.Foundation.MvvmCross.Parameters;
using Toggl.Foundation.Services;
using Toggl.Shared;

namespace Toggl.Foundation.MvvmCross.ViewModels.ReportsCalendar.QuickSelectShortcuts
{
    public sealed class ReportsCalendarThisWeekQuickSelectShortcut
        : ReportsCalendarBaseQuickSelectShortcut
    {
        private readonly BeginningOfWeek beginningOfWeek;

        public ReportsCalendarThisWeekQuickSelectShortcut
            (ITimeService timeService, BeginningOfWeek beginningOfWeek)
            : base(timeService, Resources.ThisWeek, ReportPeriod.ThisWeek)
        {
            this.beginningOfWeek = beginningOfWeek;
        }

        public override ReportsDateRangeParameter GetDateRange()
        {
            var now = TimeService.CurrentDateTime.Date;
            var difference = (now.DayOfWeek - beginningOfWeek.ToDayOfWeekEnum() + 7) % 7;
            var start = now.AddDays(-difference);
            var end = start.AddDays(6);
            return ReportsDateRangeParameter
                .WithDates(start, end)
                .WithSource(ReportsSource.ShortcutThisWeek);
        }
    }
}
