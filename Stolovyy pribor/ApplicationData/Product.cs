//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stolovyy_pribor.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderProduct = new HashSet<OrderProduct>();
        }
    
        public string CorrectImage
        {
            get
            {
                if (String.IsNullOrEmpty(ProductImage) || String.IsNullOrEmpty(ProductImage))
                    {
                    return "/Resources/picture.png";
                }
                else
                {
                    return "/Resources/" + ProductImage;
                }
            }
        }

        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCategory { get; set; }
        public int ProductManufacturer { get; set; }
        public int ProductCost { get; set; }
        public Nullable<int> ProductDiscountAmount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public Nullable<int> ProductStatus { get; set; }
        public Nullable<int> ProductSuppluer { get; set; }
        public Nullable<int> ProductAmount { get; set; }
        public string ProductEdzm { get; set; }
        public string ProductImage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual TypeCategory TypeCategory { get; set; }
        public virtual TypeManufacturer TypeManufacturer { get; set; }
        public virtual TypeStatus TypeStatus { get; set; }
        public virtual TypeSuppluer TypeSuppluer { get; set; }
    }
}
