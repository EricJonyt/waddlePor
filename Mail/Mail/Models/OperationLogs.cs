namespace Mail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperationLogs
    {
        [Key]
        public long LogId { get; set; }

        [StringLength(50)]
        public string LogName { get; set; }

        [Required]
        [StringLength(10)]
        public string Level { get; set; }

        [Required]
        [StringLength(40)]
        public string TraceId { get; set; }

        [Required]
        [StringLength(40)]
        public string OperationTime { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }

        public string Url { get; set; }

        [StringLength(40)]
        public string BusinessId { get; set; }

        [StringLength(100)]
        public string Application { get; set; }

        [StringLength(100)]
        public string Tenant { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(200)]
        public string Class { get; set; }

        [StringLength(50)]
        public string Method { get; set; }

        public string Params { get; set; }

        [StringLength(30)]
        public string Ip { get; set; }

        [StringLength(50)]
        public string Host { get; set; }

        [StringLength(200)]
        public string Browser { get; set; }

        [StringLength(12)]
        public string ThreadId { get; set; }

        [StringLength(30)]
        public string UserId { get; set; }

        [StringLength(30)]
        public string Operator { get; set; }

        [StringLength(30)]
        public string Role { get; set; }

        [StringLength(100)]
        public string Caption { get; set; }

        public string Content { get; set; }

        public string Sql { get; set; }

        public string SqlParams { get; set; }

        [StringLength(10)]
        public string ErrorCode { get; set; }

        [StringLength(2000)]
        public string Error { get; set; }

        public string StackTrace { get; set; }
    }
}
