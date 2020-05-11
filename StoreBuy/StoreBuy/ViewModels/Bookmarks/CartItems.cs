using Newtonsoft.Json;
using StoreBuy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using Xamarin.Forms;

namespace StoreBuy.ViewModels.Bookmarks
{
    class CartItems : BaseViewModel
    {
        public INavigation Navigation { get; set; }

        public CartItems(INavigation _navigation)
        {
            Navigation = _navigation;
        }

        //public async void GetCartItems()
        //{
        //    var LoginURI = Resources.CartList ;
        //    HttpClient client = new HttpClient();
        //    var response = await client.GetStringAsync(LoginURI);
        //    var ItemList = JsonConvert.DeserializeObject<List<Cart>>(response);
        //    Items = new ObservableCollection<Cart>(ItemList);

        //}


        private ObservableCollection<ItemCatalogueModel> items;


        [DataMember(Name = "ItemCatalogueModel")]
        public ObservableCollection<ItemCatalogueModel> ItemCatalogueModel
        {
            get { return this.items; }
            set
            {
                if (this.items == value)
                {
                    return;
                }



                this.items = value;
                this.NotifyPropertyChanged();
            }
        }

        public async void GetItems()
        {
            using (var client = new HttpClient())
            {
                var uri = "http://192.168.1.5/api/item/CategoryRelatedItems?CategoryId=1";
                var response = await client.GetStringAsync(uri);
                var ItemCatalogue = JsonConvert.DeserializeObject<List<ItemCatalogueModel>>(response);
                ItemCatalogueModel = new ObservableCollection<ItemCatalogueModel>(ItemCatalogue);
            }
        }

        ObservableCollection<Cart> _items;
        public ObservableCollection<Cart> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                NotifyPropertyChanged();
            }
        }


    }
}
