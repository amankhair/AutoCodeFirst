namespace AutoCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackEvaluationPart")]
    public partial class TrackEvaluationPart
    {
        [Key]
        public int intEvaluationPartId { get; set; }

        public int? intEvalutionId { get; set; }

        public int intMasterPartId { get; set; }

        public double? floatQuantity { get; set; }

        public double? floatUnitCostTrack { get; set; }

        public double? floatUnitCostAvia { get; set; }

        [StringLength(50)]
        public string strAvailability { get; set; }

        [StringLength(2500)]
        public string strDescription { get; set; }

        public int? intSimsId { get; set; }

        public int? intPartStatus { get; set; }

        public virtual TrackEvaluation TrackEvaluation { get; set; }
    }
}
