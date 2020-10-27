namespace api3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNoteImg")]
    public partial class tblNoteImg
    {
        [Key]
        public int idnoteimg { get; set; }

        public int? idnote { get; set; }

        public string imglink { get; set; }

        public virtual tblNote tblNote { get; set; }
    }
}
