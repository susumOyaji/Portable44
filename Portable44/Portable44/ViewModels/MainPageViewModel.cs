using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows.Input;
using System;
using Xamarin.Forms;

using System.Threading.Tasks;
//using Microsoft.Practices.Prism.Mvvm;

namespace Portable44.ViewModels
{
    public /*sealed*/ class MainPageViewModel : BindableBase
    {
        public ICommand SelectCommand { private set; get; }
        //PageViewModel[] PageViewModels;


      


        public MainPageViewModel()
        {
            SelectCommand = new DelegateCommand<object>(Selecter);


            // var tabbedPageViewModels = new TabbedPageViewModel[]
            //{
            //SelectPages = new ObservableCollection<PageViewModel>();
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
            int i = 0;
            var disp = Convert.ToBoolean(sender);

            if (disp == true)
            {

                //PageViewModels = new PageViewModel[]{new Page1ViewModel()};
                //this.SelectPages = new ObservableCollection<PageViewModel>{
                this.SelectPages = new ObservableCollection<PageViewModel>{
                    new Page1ViewModel{ Title1 = "Item1"},
                    new Page1ViewModel{ Title1 = "Item2"},
                    new Page1ViewModel{ Title1 = "Item3"},
                    new Page1ViewModel{ Title1 = "Item4"},
                    new Page1ViewModel{ Title1 = "Item5"},
                    new Page1ViewModel{ Title1 = "Item6"},
                    new Page1ViewModel{ Title1 = "Item7"},
                    new Page1ViewModel{ Title1 = "Item8"},
                    new Page1ViewModel{ Title1 = "Item9"},
                    new Page1ViewModel{ Title1 = "Item10"},
                    new Page1ViewModel{ Title1 = "Item11"},
                    new Page1ViewModel{ Title1 = "Item12"},
                    new Page1ViewModel{ Title1 = "Item13"},
                    new Page1ViewModel{ Title1 = "Item14"},
                    new Page1ViewModel{ Title1 = "Item15"},
                    new Page1ViewModel{ Title1 = "Item16"}
                    };

            }
            else
            {

                //PageViewModels = new PageViewModel[]{new Page2ViewModel()};

                this.SelectPages = new ObservableCollection<PageViewModel>{
                    new Page2ViewModel{ Title2 = "Item1",Title3="Item1-2"},
                    new Page2ViewModel{ Title2 = "Item2"},
                    new Page2ViewModel{ Title2 = "Item3"},
                    new Page2ViewModel{ Title2 = "Item4"},
                    new Page2ViewModel{ Title2 = "Item5"},
                    new Page2ViewModel{ Title2 = "Item6"},
                    new Page2ViewModel{ Title2 = "Item7"},
                    new Page2ViewModel{ Title2 = "Item8"},
                    new Page2ViewModel{ Title2 = "Item9"},
                    new Page2ViewModel{ Title2 = "Item10"},
                    new Page2ViewModel{ Title2 = "Item11"},
                    new Page2ViewModel{ Title2 = "Item12"},
                    new Page2ViewModel{ Title2 = "Item13"},
                    new Page2ViewModel{ Title2 = "Item14"},
                    new Page2ViewModel{ Title2 = "Item15"},
                    new Page2ViewModel{ Title2 = "Item16"}
                    };


                List<Price> pricesanser = await Models.PasonalGetserchi();//登録データの現在値を取得する
                foreach (Price item in pricesanser)
                {
                    SelectPages.Add(new Price
                    {
                        Name = item.Name,// "Sony",
                        Stocks = item.Stocks,//保有数*
                        Itemprice = item.Itemprice,//
                        Prev_day = item.Prev_day,//前日比±**
                        Realprice = item.Realprice,//現在値*// 1000,
                        RealValue = item.RealValue,// 100,
                        Percent = item.Percent,//前日比％**// "5"
                        Gain = item.Gain,//損益
                        Idindex = i,
                        // ButtonColor = item.Polar,
                        Polar = item.Polar
                        //FirstLastName = item.FirstLastName
                    });
                }





            }

            //ListView ItemsSource
            //this.SelectPages = new ObservableCollection<PageViewModel>(PageViewModels);


        }

        //public ObservableCollection<PageViewModel> SelectPages { get; private set; }



        private ObservableCollection<PageViewModel> _selectPages;

        public ObservableCollection<PageViewModel> SelectPages
        {
            get
            {
                return this._selectPages;
            }
            set
            {
                this.SetProperty(ref this._selectPages, value);
            }
        }

    }

}