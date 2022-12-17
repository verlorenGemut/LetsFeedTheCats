using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Model.Entity;
using Ninject;

namespace Presenter
{
    public class EditTimetablePresenter
    {
        private readonly IKernel kernel;
        private IEditTimetable view;
        private IRepository<Timetable> timetableRepository;
        private ITimetableService timetableService;

        private string currentTimetableID;
        private string currentFeederID;
        private string currentTime;


        public EditTimetablePresenter(IKernel kernel, IEditTimetable view, IRepository<Timetable> timetablerepository)
        {
            this.kernel = kernel;
            this.view = view;
            timetableRepository = timetablerepository;

            this.view.evShowGoback += showGoback;
            this.view.evRemoveTimestamp += removeTimestamp;
 
        }

        private void removeTimestamp(string obj)
        {
            throw new NotImplementedException();
        }

        public void Run(string timetableID)
        {
            currentTimetableID = timetableID;
            view.Show();
            Timetable timetable = timetableRepository.getFeederFromDatabase(timetableID);
            view.display_timestamp_list(timetable);
        }

        private void showGoback()
        {
            var presenter = kernel.Get<EditTimetablePresenter>();
           presenter.Run(currentTimetableID);
            view.Close();
        }
    }
}
