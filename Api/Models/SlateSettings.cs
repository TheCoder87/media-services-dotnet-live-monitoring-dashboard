﻿using System;

namespace MediaDashboard.Operations.Api.Models
{
    public class SlateSettings
    {
        public int Duration { get; set; }

        public int CueId { get; set; }

        public string SlateAssetId { get; set; }

        public bool ShowSlate { get; set; }
    }
}
