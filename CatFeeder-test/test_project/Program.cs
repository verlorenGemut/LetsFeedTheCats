using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Model.Entity;
using Model.Repository;
using Model.Service;
using MySql.Data.MySqlClient;
using Ninject;
using Presenter;
using test_project;


namespace CatFeeder
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            kernel.Bind<IHomeUser>().To<HomeUser>();
            kernel.Bind<ILogIn>().To<Form1>();
            kernel.Bind<IAddFeeder>().To<AddFeeder>();
            kernel.Bind<IManageTimetables>().To<ManageTimetables>();
            kernel.Bind<IEditTimetable>().To<EditTimetable>();
            kernel.Bind<IHomeAdmin>().To<HomeAdmin>();
            kernel.Bind<IEditFeeder>().To<EditFeeder>();
            kernel.Bind<IRegistrationScreen>().To<RegistrationScreen>();
            kernel.Bind<IFeederIDlist>().To<Feeder_ID_list>();

            kernel.Bind<IFeederService>().To<FeederService>();
            kernel.Bind<IAuthService>().To<AuthService>();
            kernel.Bind<ITimetableService>().To<TimetableService>();

            kernel.Bind<IRepository<User>>().To<UserRepository>();
            kernel.Bind<IRepository<Timetable>>().To<TimetableRepository>();
            kernel.Bind<IRepository<Feeder>>().To<FeederRepository>();

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<LogInPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());

            
        }
    }
}