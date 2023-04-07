﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OptionEdge.API.AliceBlue.Records
{
    public class SquareOffPositionResult : BaseResponseResult
    {
        [JsonPropertyName("nestOrderNumber")]
        public string OrderNumber { get; set; }
    }
}
