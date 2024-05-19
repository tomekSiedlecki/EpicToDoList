using EpicToDoList.models;
using EpicToDoList.services;
using EpicToDoList.stores;
using EpicToDoList.viewmodels;
using System.Windows;


namespace EpicToDoList
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly AssignmentList assignmentList;
        private readonly NavigationStore navigationStore;

        private readonly DbService service;

        public App()
        {
            service = new DbService();
            assignmentList = new AssignmentList(service.GetAllAssignments());
            navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            navigationStore.CurrentViewModel = CreateAssignmentListingModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            service.SaveAssignments(assignmentList.GetAllAssignments());
            base.OnExit(e);
        }

        private MakeAssignmentViewModel CreateMakeAssignmentViewModel()
        {
            return new MakeAssignmentViewModel(assignmentList,new NavigationService(navigationStore, CreateAssignmentListingModel));
        }

        private AssignmentListingViewModel CreateAssignmentListingModel()
        {
            return new AssignmentListingViewModel(assignmentList, new NavigationService(navigationStore, CreateMakeAssignmentViewModel));
        }
    }

}
