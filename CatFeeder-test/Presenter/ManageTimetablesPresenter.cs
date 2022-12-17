using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Model.Entity;
using Ninject;

namespace Presenter
{
    public class ManageTimetablesPresenter
    {
        private readonly IKernel kernel;
        private IManageTimetables view;
        private IRepository<Timetable> timetableRepository;
        private ITimetableService timetableService;

        private List<Timetable> timetableList;

        private string currentUserID;

        public ManageTimetablesPresenter(IKernel kernel, IManageTimetables view, IRepository<Timetable> timetableRepository, ITimetableService timetableService)
        {
            this.kernel = kernel;
            this.view = view;
            this.timetableRepository = timetableRepository;
            this.timetableService = timetableService;

            this.view.evShowGoback += showGoback;
            this.view.evShowEditTimetable += showEditTimetable;
            this.view.evRemoveTimetable += removeTimetable;
            this.view.evAddTimetable += addTimetable;
        }

        private void addTimetable()
        {
            timetableService.addTimetable(currentUserID);
        }

        private void removeTimetable(string timetableID)
        {
            throw new NotImplementedException();
        }

        private void showEditTimetable(string timetableID)
        {
            var presenter = kernel.Get<EditTimetablePresenter>();
            presenter.Run(timetableID);
            view.Close();
        }

        private void showGoback()
        {
            var presenter = kernel.Get<HomeUserPresenter>();
            presenter.Run(currentUserID);
            view.Close();
        }

        public void Run(string username)
        {
            currentUserID = username;
            view.Show();
            timetableList = timetableRepository.getFeedersOfUser(username);
            view.display_timetable_list(timetableList);
        }
    }
}
