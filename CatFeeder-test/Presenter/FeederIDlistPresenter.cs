using Model;
using Model.Entity;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    class FeederIDlistPresenter
    {
        private readonly IKernel kernel;
        private IFeederIDlist view;
        private IRepository<Feeder> feederRepository;

        private string currentAdmin;
        private List<Feeder> GLOBAL_feederList;

        public FeederIDlistPresenter(IKernel kernel, IFeederIDlist view, IRepository<Feeder> feederRepository)
        {
            this.kernel = kernel;
            this.view = view;
            this.feederRepository = feederRepository;

            this.view.evAddFeeder += addFeeder;
            this.view.evRemoveFeeder += deleteFeeder;
            this.view.evShowGoback += showGoback;
        }

        private void showGoback()
        {
            var presenter = kernel.Get<HomeAdminPresenter>();
            presenter.Run(currentAdmin);
            view.Close();
        }

        private void deleteFeeder(string feederID)
        {
            if (feederRepository.getFeederFromDatabase(feederID) != null)
            {
                feederRepository.removeFeederFromDatabase(feederRepository.getFeederFromDatabase(feederID));
                GLOBAL_feederList = feederRepository.getAllFeeders();
                view.display_GLOBAL_feeder_list(GLOBAL_feederList);
            }
        }

        private void addFeeder(string feederID)
        {
            if (feederID == null)
                return;

            Feeder feeder0 = feederRepository.getFeederFromDatabase(feederID);

            if (feeder0 != null)
                return;

            Feeder feeder = new Feeder(feederID, "Feeder ^_^");
            feederRepository.addFeederToDatabase(feeder);
            GLOBAL_feederList = feederRepository.getAllFeeders();
            view.display_GLOBAL_feeder_list(GLOBAL_feederList);
        }

        public void Run(string username)
        {
            currentAdmin = username;
            view.Show();
            GLOBAL_feederList = feederRepository.getAllFeeders();
            view.display_GLOBAL_feeder_list(GLOBAL_feederList);
        }
    }
}
