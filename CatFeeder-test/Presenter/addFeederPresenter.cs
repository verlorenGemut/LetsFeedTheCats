using Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class AddFeederPresenter
    {
        private readonly IKernel kernel;
        private IAddFeeder view;
        private IFeederService feederService;

        private string currentUserID;

        public AddFeederPresenter(IKernel kernel, IAddFeeder view, IFeederService feederService)
        {
            this.kernel = kernel;
            this.view = view;
            this.feederService = feederService;

            this.view.evShowGoback += showGoback;
            this.view.evAddFeeder += addFeeder;
        }

        private void showGoback()
        {
            var presenter = kernel.Get<HomeUserPresenter>();
            presenter.Run(currentUserID);
            view.Close();
        }

        private void addFeeder(string id)
        {
            short activationResult = feederService.activateFeeder(currentUserID, id);
            view.Activation_result_response(activationResult);
        }

        public void run(string username)
        {
            currentUserID = username;
            view.Show();
        }
    }
}
