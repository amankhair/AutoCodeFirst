namespace AutoCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackEvaluation")]
    public partial class TrackEvaluation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrackEvaluation()
        {
            TrackEvaluationComment = new HashSet<TrackEvaluationComment>();
            TrackEvaluationHistory = new HashSet<TrackEvaluationHistory>();
            TrackEvaluationPart = new HashSet<TrackEvaluationPart>();
        }

        [Key]
        public int intEvalutionId { get; set; }

        public int? intEvalutionNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dCreateDate { get; set; }

        public int? intCreateUserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dCreateDateBL { get; set; }

        public int? intCreateUserIdBL { get; set; }

        [StringLength(1024)]
        public string CustomerRequestNumber { get; set; }

        public int? intTypeOfInspection { get; set; }

        public int? intSMCSComponentID { get; set; }

        public int? intMachineSystem { get; set; }

        public int? intStatysId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dSendDateCustomer { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dReceiveDateCustomer { get; set; }

        [StringLength(255)]
        public string strOrderNo { get; set; }

        [StringLength(255)]
        public string strSalesOrderNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dDateOfSale { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dEstimatedDateArrival { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dArrivalDate { get; set; }

        public int? intEquipmentID { get; set; }

        public double? intMetered { get; set; }

        [StringLength(1024)]
        public string strDescriptionDefect { get; set; }

        [StringLength(1024)]
        public string strReasonDefect { get; set; }

        [StringLength(1024)]
        public string strRemedyDefect { get; set; }

        [StringLength(1024)]
        public string strSymptoms { get; set; }

        public int? intPriority { get; set; }

        public double? floatETTR { get; set; }

        public double? floatELTR { get; set; }

        public int? intConfirmUserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dConfirmDate { get; set; }

        public bool? intConfirmStatus { get; set; }

        public int? intEvaluationSysStatusId { get; set; }

        public int? intLocationId { get; set; }

        public int? intServiceHistoryId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackEvaluationComment> TrackEvaluationComment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackEvaluationHistory> TrackEvaluationHistory { get; set; }

        public virtual ICollection<TrackEvaluationPart> TrackEvaluationPart { get; set; }
    }
}
