﻿using Newtonsoft.Json;
using OsuSharp.Converters;

namespace OsuSharp.Models.Beatmaps;

/// <summary>
/// Represents an extended beatmap, inheriting from <see cref="Beatmap"/> and includes additional properties.
/// The API differs between normal beatmaps and extended beatmaps, as not all information is available on all endpoints.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#beatmapextended"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/beatmap-extended-json.ts"/>
/// </summary>
public class BeatmapExtended : Beatmap
{
  #region Default Attributes

  /// <summary>
  /// The overall difficulty (OD) of this beatmap.
  /// </summary>
  [JsonProperty("accuracy")]
  public float OverallDifficulty { get; set; }

  /// <summary>
  /// The approach rate (AR) of this beatmap.
  /// </summary>
  [JsonProperty("ar")]
  public float ApproachRate { get; set; }

  /// <summary>
  /// The beats per minute (BPM) of this beatmap.
  /// </summary>
  [JsonProperty("bpm")]
  public float BPM { get; set; }

  /// <summary>
  /// Bool whether this beatmap is converted from a different ruleset or not.
  /// </summary>
  [JsonProperty("convert")]
  public bool IsConverted { get; set; }

  /// <summary>A
  /// The amount of circles in this beatmap.
  /// </summary>
  [JsonProperty("count_circles")]
  public int CountCircles { get; set; }

  /// <summary>
  /// The amount of sliders in this beatmap.
  /// </summary>
  [JsonProperty("count_sliders")]
  public int CountSliders { get; set; }

  /// <summary>
  /// The amount of spinners in this beatmap.
  /// </summary>
  [JsonProperty("count_spinners")]
  public int CountSpinners { get; set; }

  /// <summary>
  /// The circle size (CS) of this beatmap.
  /// </summary>
  [JsonProperty("cs")]
  public float CircleSize { get; set; }

  /// <summary>
  /// The datetiem at which this beatmap was deleted. This will be null if the beatmap has not been deleted.
  /// </summary>
  public DateTimeOffset? DeletedAt { get; set; }

  /// <summary>
  /// The health drain rate (HP) of this beatmap.
  /// </summary>
  [JsonProperty("drain")]
  public float HealthDrain { get; set; }

  /// <summary>
  /// The hit length of this beatmap.
  /// </summary>
  [JsonProperty("hit_length")]
  public TimeSpan HitLength { get; set; }

  /// <summary>
  /// To be documented
  /// </summary>
  [JsonProperty("is_scoreable")]
  public bool IsScoreable { get; set; }

  /// <summary>
  /// The datetime at which this beatmap was last updated.
  /// </summary>
  [JsonProperty("last_updated")]
  public DateTimeOffset LastUpdated { get; set; }

  /// <summary>
  /// The amount of passes this beatmap has.
  /// </summary>
  [JsonProperty("passcount")]
  public int PassCount { get; set; }

  /// <summary>
  /// The amount of plays this beatmap has.
  /// </summary>
  [JsonProperty("playcount")]
  public int PlayCount { get; set; }

  /// <summary>
  /// The URL to the beatmap page of this beatmap.
  /// </summary>
  [JsonProperty("url")]
  public string Url { get; set; } = default!;

  #endregion

  #region Optional Attributes

  private BeatmapSetExtended? _set;
  /// <summary>
  /// The beatmapset this beatmap belongs to. This is an optional property and may be null.
  /// </summary>
  public new BeatmapSetExtended? Set
  {
    get => _set;
    private set
    {
      _set = value;
      base.Set = value;
    }
  }

  #endregion
}
