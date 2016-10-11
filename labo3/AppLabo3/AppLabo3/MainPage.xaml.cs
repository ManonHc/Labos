using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Model;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppLabo3
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Contact> lstContacts = new List<Contact>()
        {
            new Contact("Libert","Manon","manon@wallontours.be"),
            new Contact("Gaone","Leandro","leandro@pokerbelgique.be")
        };


        public MainPage()
        {
            this.InitializeComponent();
            DataContext = lstContacts;
        }
    }
}
