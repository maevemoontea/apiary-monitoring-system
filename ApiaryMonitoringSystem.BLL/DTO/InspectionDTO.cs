using System;
using System.Collections.Generic;
using System.Text;

namespace ApiaryMonitoringSystem.BLL.DTO
{
    public class InspectionDTO
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public int? BeehiveId { get; set; }
        public BeeHiveDTO Beehive { get; set; }
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
