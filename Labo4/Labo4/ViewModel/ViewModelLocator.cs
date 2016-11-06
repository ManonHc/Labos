using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<SecondViewModel>();

            NavigationService navigationpages = new NavigationService();
            //La navigation est déjà enregistré par défaut apparemment, d'après le compilateur ...
            //l'érreur vient peut-être de là ...
            if(!SimpleIoc.Default.IsRegistered<INavigationService>())
                SimpleIoc.Default.Register<INavigationService>(() => navigationpages);
            navigationpages.Configure("MainPage", typeof(MainPage));
            navigationpages.Configure("SecondPage", typeof(SecondPage));

        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public SecondViewModel MainSecond
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SecondViewModel>();
            }
        }
    }
}
