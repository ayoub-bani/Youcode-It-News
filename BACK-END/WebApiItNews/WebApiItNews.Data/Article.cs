//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiItNews.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            this.Commentaire = new HashSet<Commentaire>();
        }
    
        public int ID { get; set; }
        public Nullable<int> CategorieID { get; set; }
        public int JournalistesID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Titre { get; set; }
        public string Status { get; set; }
        public string Img { get; set; }
        public string video { get; set; }
        public string Body { get; set; }
    
        public virtual Journalistes Journalistes { get; set; }
        public virtual Categorie Categorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commentaire> Commentaire { get; set; }
    }
}
