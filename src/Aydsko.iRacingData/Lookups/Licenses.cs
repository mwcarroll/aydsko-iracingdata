﻿// © 2022 Adrian Clark
// This file is licensed to you under the MIT license.

using System.Text.Json.Serialization;

namespace Aydsko.iRacingData.Lookups;

public class License
{
    [JsonPropertyName("license_group")]
    public int LicenseGroup { get; set; }
    [JsonPropertyName("group_name")]
    public string GroupName { get; set; } = default!;
    [JsonPropertyName("min_num_races")]
    public int? MinimumNumberOfRaces { get; set; }
    [JsonPropertyName("participation_credits")]
    public int ParticipationCredits { get; set; }
    [JsonPropertyName("min_sr_to_fast_track")]
    public int? MinimumSafetyRatingToFastTrack { get; set; }
    [JsonPropertyName("levels")]
    public LicenseLevel[] Levels { get; set; } = default!;
    [JsonPropertyName("min_num_tt")]
    public int? MinimumNumberOfTimeTrials { get; set; }
}

[JsonSerializable(typeof(License[])), JsonSourceGenerationOptions(WriteIndented = true)]
internal partial class LicenseArrayContext : JsonSerializerContext
{ }
