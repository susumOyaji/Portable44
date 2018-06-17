//using Microsoft.Practices.Prism.Mvvm;

namespace Portable44.ViewModels
{
    public abstract class PageViewModel : BindableBase
    {
       
        private string _Title1;
        public string Title1
        {
            get
            {
                return this._Title1;
            }
             set
            {
                this.SetProperty(ref this._Title1, value);
            }
        }


        private string _Title2;
        public string Title2
        {
            get
            {
                return this._Title2;
            }
            set
            {
                this.SetProperty(ref this._Title2, value);
                //this.OnPropertyChanged(nameof(Title2));

            }
        }


        private string _Title3;
        public string Title3
        {
            get
            {
                return this._Title3;
            }
            set
            {
                this.SetProperty(ref this._Title3, value);
            }
        }


    }





    public sealed class Page1ViewModel : PageViewModel
    {

        public Page1ViewModel()
        {
            this.Title1 = null;//"TabbedPage1";
        }

    }
    public sealed class Page2ViewModel : PageViewModel
    {
        public Page2ViewModel()
        {
            this.Title2 = null;// "Title2";
            this.Title3 = null;
        }

    }

}

//      private void Sample()
//{
//    ItemList.Add(new Price
//    {
//        Name = "SampleSony",
//        Stocks = 100,
//        Itemprice = 2015,
//        Realprice = 1000,
//        RealValue = 100,
//        Percent = "5"
//    });