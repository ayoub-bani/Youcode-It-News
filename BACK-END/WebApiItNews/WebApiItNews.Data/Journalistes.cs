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
    
    public partial class Journalistes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Journalistes()
        {
            this.Article = new HashSet<Article>();
        }
    
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Nullable<bool> Statu { get; set; }
        public string Tele { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string User_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Article> Article { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
