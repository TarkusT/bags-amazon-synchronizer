﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Models
{
    public class UpdateSummary
    {
        public int ProductCount { get; set; }
        public int UpdatedCount { get; set; }
        public int UnavailableCount { get; set; }
        public int ErrorCount => ErrorAsins.Count;
        public List<string> ErrorAsins { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Duration => (EndDate - StartDate).ToString("g");

        public UpdateSummary()
        {
            ErrorAsins = new List<string>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine($"########## Summary ##########");
            sb.AppendLine($"Total Products : {ProductCount}");
            sb.AppendLine($"Total Updated Products : {UpdatedCount}");
            sb.AppendLine($"Total Unavailable Products : {UnavailableCount}");
            sb.AppendLine($"Total Update Errors  : {ErrorCount}");
            sb.AppendLine($"Update Duration : {(EndDate - StartDate).ToString("g")}");
            return sb.ToString();
        }
    }
}
