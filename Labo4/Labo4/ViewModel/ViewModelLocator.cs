﻿using GalaSoft.MvvmLight.Ioc;
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
            NavigationService navigationpages = new NavigationService();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<SecondViewModel>();
            SimpleIoc.Default.Register<INavigationService>(() => navigationpages);
            navigationpages.Configure("MainPage", typeof(MainPage));
            navigationpages.Configure("MainPage", typeof(SecondPage));

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
