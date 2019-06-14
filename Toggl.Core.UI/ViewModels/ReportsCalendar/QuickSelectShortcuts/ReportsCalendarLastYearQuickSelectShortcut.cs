using System;
using Toggl.Core.Analytics;
using Toggl.Core.Models;
using Toggl.Core.UI.Parameters;
using Toggl.Core.Services;
using Toggl.Shared;
using Toggl.Shared.Extensions;

namespace Toggl.Core.UI.ViewModels.ReportsCalendar.QuickSelectShortcuts
{
    public sealed class ReportsCalendarLastYearQuickSelectShortcut
        : ReportsCalendarBaseQuickSelectShortcut
    {
        public ReportsCalendarLastYearQuickSelectShortcut(ITimeService timeService)
            : base(timeService, Resources.LastYear, ReportPeriod.LastYear)
        {
        }

        public override ReportsDateRange GetDateRange()
        {
            var start = TimeService.CurrentDateTime.RoundDownToLocalYear().AddYears(-1);
            var end = start.AddYears(1).AddDays(-1);
            return ReportsDateRange
                .WithDates(start, end)
                .WithSource(ReportsSource.ShortcutLastYear);
        }
    }
}
