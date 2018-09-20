using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace SyncRPApp.Models
{
    public class TimerModel
    {
        private readonly ReactiveTimer _timer;
        public ReadOnlyReactivePropertySlim<DateTimeOffset> CurrentDateTimeOffset { get; }

        public TimerModel()
        {
            _timer = new ReactiveTimer(TimeSpan.FromSeconds(1));
            CurrentDateTimeOffset = _timer.Select(_ => DateTimeOffset.Now)
                .ToReadOnlyReactivePropertySlim();
            _timer.Start();
        }
    }
}
