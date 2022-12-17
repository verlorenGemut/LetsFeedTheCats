using Model;
using Model.Entity;
using Ninject;
using System;
using System.Collections.Generic;


namespace Presenter
{
    public class HomeUserPresenter
    {
        private readonly IKernel kernel;
        private IHomeUser view;
        private IRepository<Feeder> feederRepository;
        public List<Feeder> FeederList;

        private string currentUserID;
        private string currentTime;

        public HomeUserPresenter(IKernel kernel, IHomeUser view, IRepository<Feeder> feederRepository)
        {
            this.kernel = kernel;
            this.view = view;
            this.feederRepository = feederRepository;

            this.view.evShowAddFeeder += showAddFeeder;
            this.view.evShowManageTimetables += showManageTimetables;
            this.view.evShowLogOut += showLogOut;
            this.view.evShowFeederInfo += showFeederInfo;
            this.view.evShowFeederSettings += showFeederSettings;
        }

        private void showFeederSettings(string feederID)
        {
            var presenter = kernel.Get<EditFeederPresenter>();
            presenter.Run(currentUserID, feederID, currentTime);
            view.Close();
        }


        private void showFeederInfo(string feederID)
        {
            throw new NotImplementedException();
        }

        private void showManageTimetables()
        {
            var presenter = kernel.Get<ManageTimetablesPresenter>();
            presenter.Run(currentUserID);
            view.Close();
        }

        

        private void showLogOut()
        {
            var presenter = kernel.Get<LogInPresenter>();
            presenter.Run();
            view.Close();
        }

        private void showAddFeeder()
        {
            var presenter = kernel.Get<AddFeederPresenter>();
            presenter.run(currentUserID);
            view.Close();
        }

        public void Run(string username)
        {
            currentUserID = username;
            view.Show();
            FeederList = feederRepository.getFeedersOfUser(username); //по id ползователя (его логин) получаем список кормушек
            view.display_feeder_list(FeederList);
        }
    }
}