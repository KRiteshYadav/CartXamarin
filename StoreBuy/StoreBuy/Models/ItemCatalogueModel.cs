using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using Xamarin.Forms.Internals;

namespace StoreBuy.Models
{
    [Preserve(AllMembers = true)]
    [DataContract]
    public class ItemCatalogueModel : INotifyPropertyChanged
    {
        private bool isFavourite;
        [DataMember(Name = "ItemId")]
        public virtual long ItemId { get; set; }



        [DataMember(Name = "ItemName")]
        public virtual string ItemName { get; set; }



        [DataMember(Name = "Price")]
        public virtual float Price { get; set; }



        [DataMember(Name = "ItemDescription")]
        public virtual string ItemDescription { get; set; }



        [DataMember(Name = "CategoryName")]
        public virtual string CategoryName { get; set; }



        [DataMember(Name = "Quantity")]
        public virtual long Quantity { get; set; }


        [DataMember(Name = "ItemImage")]
        public virtual byte[] ItemImage { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;



        [DataMember(Name = "isfavourite")]
        public bool IsFavourite
        {
            get
            {
                return this.isFavourite;
            }



            set
            {
                this.isFavourite = value;
                this.NotifyPropertyChanged(nameof(IsFavourite));
            }
        }
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}