using Model;
using Model.Entity;
using Ninject;

namespace Presenter
{
    public class EditFeederPresenter
    {
        private readonly IKernel kernel;
        private IEditFeeder view;
        private IRepository<Feeder> feederRepository;
        private IRepository<Timetable> timetableRepository;
        private IFeederService feederService;
        private ITimetableService timetableService;
       
        private string currentUserID;
        private string currentFeederID;
        private string currentTime;  

        public EditFeederPresenter(IKernel kernel, IEditFeeder view, IRepository<Feeder> feederRepository, IRepository<Timetable> timetableRepository, IFeederService feederService,ITimetableService timetableService)
        {
            this.kernel = kernel;
            this.view = view;
            this.feederRepository = feederRepository;
            this.timetableRepository = timetableRepository;
            this.feederService = feederService;
            this.timetableService = timetableService;
  

            this.view.evShowGoback += showGoback;
            this.view.evShowUpdate += showUpdate;
            this.view.evShowTimeUpdate += showTimeUpdate;

        }

        private void showGoback()
        {
            var presenter = kernel.Get<HomeUserPresenter>();
            presenter.Run(currentUserID);
            view.Close();
        }

        public void Run(string username, string feederID, string timetable)
        {
            currentUserID = username;
            currentFeederID = feederID;
            currentTime = timetable;
         
            view.Show();
        }


        private void showUpdate(string feederName)
        {
            short updateResult = feederService.updateFeeder(currentFeederID,feederName);
           
            view.update_result_response(updateResult);

        }

        private void showTimeUpdate(string timetable)
        {
            short updateResult = timetableService.updateFeedTime(currentFeederID, timetable);

            view.update_result_response1(updateResult);
        }


        }
    }
