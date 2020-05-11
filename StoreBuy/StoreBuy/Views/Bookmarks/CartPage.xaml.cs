using StoreBuy.DataService;
using StoreBuy.ViewModels.Bookmarks;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace StoreBuy.Views.Bookmarks
{
    /// <summary>
    /// Page to show the cart list. 
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartPage" /> class.
        /// </summary>
        public CartPage()
        {
            InitializeComponent();
            // this.BindingContext = CartDataService.Instance.CartPageViewModel;
            //BindingContext = new SearchStoreViewModel(Navigation);
            BindingContext = new CartItems(Navigation);
        }

        protected override void OnAppearing()
        {
            (this.BindingContext as CartItems).GetItems();
        }
    }
}