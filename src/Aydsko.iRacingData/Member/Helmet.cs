﻿// © 2022 Adrian Clark
// This file is licensed to you under the MIT license.

using System.Text.Json.Serialization;

namespace Aydsko.iRacingData.Member;

public class Helmet
{
    [JsonPropertyName("pattern")]
    public int Pattern { get; set; }
    [JsonPropertyName("color1")]
    public string Color1 { get; set; } = default!;
    [JsonPropertyName("color2")]
    public string Color2 { get; set; } = default!;
    [JsonPropertyName("color3")]
    public string Color3 { get; set; } = default!;
    [JsonPropertyName("face_type")]
    public int FaceType { get; set; }
    [JsonPropertyName("helmet_type")]
    public int HelmetType { get; set; }
}
