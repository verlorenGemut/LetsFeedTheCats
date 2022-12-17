using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface IHomeUser : IView
    {
        public event Action evShowAddFeeder;
        public event Action evShowManageTimetables;
        public event Action evShowLogOut;
        public event Action<string> evShowFeederSettings;
        public event Action<string> evShowFeederInfo;
        void display_feeder_list(List<Feeder> feederlist);
    }
}
