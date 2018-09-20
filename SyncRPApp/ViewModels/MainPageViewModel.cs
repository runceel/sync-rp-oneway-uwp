using Reactive.Bindings;
using SyncRPApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Disposables;
using Reactive.Bindings.Extensions;
using System.Reactive.Concurrency;

namespace SyncRPApp.ViewModels
{
    public class MainPageViewModel
    {
        private readonly TimerModel _timerModel = new TimerModel();

        public ReadOnlyReactiveProperty<string> Output { get; }

        public MainPageViewModel()
        {
            Output = _timerModel.CurrentDateTimeOffset
                .Select(x => x.ToString())
                .ToReadOnlyReactiveProperty();
        }
    }
}
