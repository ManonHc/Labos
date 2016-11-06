using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Labo4.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Labo4.ViewModel
{
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<Student> _students;
        private Student _selectedStudent;
        private INavigationService _navigationService;
        private ICommand _editStudentCommand;


       

        [PreferredConstructor]
        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            //init liste
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents()); ;
        }
        public ICommand EditStudentCommand
        {
            get
            {
                if (this._editStudentCommand == null)
                {
                    this._editStudentCommand = new RelayCommand(() => EditStudent());
                }
                return _editStudentCommand;
            }
        }
        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                
                RaisePropertyChanged("Students");
                // l'argument de cette méthode est le nom de la propriété
            }
        }

        

        public MainViewModel()
        {
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());
        }

        public Student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }

            set
            {
                _selectedStudent = value;
                if (_selectedStudent != null)
                {
                    RaisePropertyChanged("SelectedStudent");  
                }

            }
        }
        private void EditStudent()
        {
            if (CanExecute() == true)
            {
                _navigationService.NavigateTo("SecondPage", SelectedStudent);
            }
        }
        public bool CanExecute()
        {
            return (SelectedStudent == null) ? false : true;
        }
    }
}
