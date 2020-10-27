namespace api3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNote")]
    public partial class tblNote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNote()
        {
            tblNoteImgs = new HashSet<tblNoteImg>();
        }

        [Key]
        public int idnote { get; set; }

        public int? idAcc { get; set; }

        public string title { get; set; }

        public string contene { get; set; }

        public string gps { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datecraete { get; set; }

        public virtual tblAccount tblAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNoteImg> tblNoteImgs { get; set; }
    }
}
