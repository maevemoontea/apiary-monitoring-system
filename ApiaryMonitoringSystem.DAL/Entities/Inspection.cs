using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiaryMonitoringSystem.DAL.Entities
{
    [Table("Inspections")]
    public class Inspection
    {
        [Column("inspection_id")]
        [Required]
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        [Column("hive_id")]
        [Required]
        public int? BeehiveId { get; set; }
        public BeeHive Beehive { get; set; }
        public byte? BroodFrames { get; set; }
        public byte? HoneyFrames { get; set; }
        public byte TotalFrames { get; set; }
        public bool? Swarming { get; set; }
        public bool? QueenExist { get; set; }
        public bool? BabyQueensExist { get; set; }
        public bool? DailyBroodExist { get; set; }
        public byte? AggressivenessEstimation { get; set; }
        public byte? BeesFlightEstimation { get; set; }
        public byte HoneyFramesRemoved { get; set; }
        public byte BroodFramesRemoved { get; set; }
        public byte TotalFramesRemoved { get; set; }
        public byte EmptyFramesAdded { get; set; }
        public byte HoneyFramesAdded { get; set; }
        public byte BroodFramesAdded { get; set; }
        public byte TotalFramesAdded { get; set; }
    }
}
