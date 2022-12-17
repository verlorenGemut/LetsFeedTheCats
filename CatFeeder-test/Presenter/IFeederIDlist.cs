using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface IFeederIDlist : IView
    {
        public event Action evShowGoback;
        public event Action<string> evAddFeeder;
        public event Action<string> evRemoveFeeder;

        void display_GLOBAL_feeder_list(List<Feeder> gLOBAL_feederlist);
    }
}
