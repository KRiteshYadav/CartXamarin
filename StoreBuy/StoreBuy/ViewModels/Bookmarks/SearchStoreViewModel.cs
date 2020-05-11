using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StoreBuy.ViewModels.Bookmarks
{
    class SearchStoreViewModel
    {
        public INavigation Navigation { get; set; }

        public SearchStoreViewModel(INavigation _navigation)
        {
            Navigation = _navigation;
            this.SearchStoreCommand = new Command(this.SearchStoreClicked);
        }

        public Command SearchStoreCommand { set; get; }

        private async void SearchStoreClicked(object obj)
        {

          

       
        }


    }
}
