namespace AutoCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackEvaluationHistory")]
    public partial class TrackEvaluationHistory
    {
        [Key]
        public int intEvalutionHistoryId { get; set; }

        public int? intEvalutionId { get; set; }

        public DateTime? dCreateDate { get; set; }

        public int? intCreateUserId { get; set; }

        public int? intEvalutionStatus { get; set; }

        public virtual TrackEvaluation TrackEvaluation { get; set; }
    }
}
