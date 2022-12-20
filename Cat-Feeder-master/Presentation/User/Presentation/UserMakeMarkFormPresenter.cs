using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class UserMakeMarkFormPresenter
    {
        private readonly IKernel _kernel;
        private IUserMakeMarkFormView _view;

        public UserMakeMarkFormPresenter(IKernel kernel, IUserMakeMarkFormView view)
        {
            _kernel = kernel;

            _view = view;
            _view.evChooseFeeder += ChooseFeeder;
            _view.evMakeNoteByHand += MakeNoteByHand;
            _view.evMakeNoteToFeeder += MakeNoteToFeeder;
        }

        private void ChooseFeeder()
        {

        }

        private void MakeNoteByHand()
        {

        }

        private void MakeNoteToFeeder()
        {

        }

        public void Run()
        {
            _view.Show();
        }

    }
}
