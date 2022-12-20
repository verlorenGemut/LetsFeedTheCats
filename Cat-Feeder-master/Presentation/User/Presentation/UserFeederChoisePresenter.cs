using Ninject;

namespace Presentation
{
    public class UserFeederChoisePresenter
    {
        private readonly IKernel _kernel;
        private IUserFeederChoiseView _view;

        public UserFeederChoisePresenter(IKernel kernel, IUserFeederChoiseView view)
        {
            _kernel = kernel;

            _view = view;
            _view.evChooseFeeder += ChooseFeeder;
        }

        private void ChooseFeeder()
        {
            // Выбрать кормушку
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
