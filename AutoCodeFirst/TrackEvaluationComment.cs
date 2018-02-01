namespace AutoCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackEvaluationComment")]
    public partial class TrackEvaluationComment
    {
        [Key]
        public int intEvalutionCommentId { get; set; }

        public int? intEvalutionId { get; set; }

        [StringLength(1024)]
        public string strComment { get; set; }

        public int? intCreateUserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dCreateDate { get; set; }

        public virtual TrackEvaluation TrackEvaluation { get; set; }
    }
}
