using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows.Input;
using System;
//using Microsoft.Practices.Prism.Mvvm;

namespace Portable44.ViewModels
{
    public sealed class MainPageViewModel : BindableBase
    {
        public ICommand SelectCommand { private set; get; }
        PageViewModel[] PageViewModels;


      


        public MainPageViewModel()
        {
           
            // var tabbedPageViewModels = new TabbedPageViewModel[]
            //{
            //SelectPages = new ObservableCollection<PageViewModel>();
            SelectCommand = new DelegateCommand<object>(Selecter);
            //new TabbedPage2ViewModel(),
            //new TabbedPage1ViewModel(),
            //new TabbedPage2ViewModel(),
            // };

            //this.TabbedPages = new ObservableCollection<TabbedPageViewModel>(tabbedPageViewModels);
        }



        public void Selecter(object sender)
        {
            //var SourceBool = (string)sender.CommandParameter;//FirstLastName (Prev_day or Percent)

            //PageViewModel[] PageViewModels;

            var disp = Convert.ToBoolean(sender);

            if (disp == true)
            {

                PageViewModels = new PageViewModel[]
                {
                    new Page1ViewModel()
                };

            }
            else
            {

                //PageViewModels = new PageViewModel[]
                //{
                //   new Page2ViewModel()
                //};

                SelectPages.Add(new Page2ViewModel
                {
                    Title2 = "sa"
                });
            }

            //ListView ItemsSource
            this.SelectPages = new ObservableCollection<PageViewModel>(PageViewModels);


        }





        private ObservableCollection<PageViewModel> _selectPages;

        public ObservableCollection<PageViewModel> SelectPages
        {
            get
            {
                return this._selectPages;
            }
            protected set
            {
                this.SetProperty(ref this._selectPages, value);
            }
        }

    }

}