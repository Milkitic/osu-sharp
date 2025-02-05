﻿using Newtonsoft.Json;
using OsuSharp.Converters;
using OsuSharp.Enums;
using OsuSharp.Models.Beatmaps;
using OsuSharp.Models.Users;

namespace OsuSharp.Models.Scores;

/// <summary>
/// Represents a score.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#score"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/score-json.ts"/>
/// </summary>
public class Score
{
  // TODO: migrate to the new score & API format/version

  #region Default Attributes

  /// <summary>
  /// The accuracy of this score.
  /// </summary>
  [JsonProperty("accuracy")]
  public float Accuracy { get; set; }

  /// <summary>
  /// The ID of the best score the player of this score achieved on the beatmap. This will be null if the player has no best score on the beatmap.
  /// </summary>
  [JsonProperty("best_id")]
  public long? BestId { get; set; }

  /// <summary>
  /// The datetime at which this score was submitted to the osu! servers.
  /// </summary>
  [JsonProperty("created_at")]
  public DateTimeOffset CreatedAt { get; set; }

  /// <summary>
  /// The ID of this score.
  /// </summary>
  [JsonProperty("id")]
  public long Id { get; set; }

  /// <summary>
  /// The maximum combo achieved in this score.
  /// </summary>
  [JsonProperty("max_combo")]
  public int MaxCombo { get; set; }

  /// <summary>
  /// The ruleset this score was achieved in.
  /// </summary>
  [JsonProperty("mode")]
  public Ruleset Ruleset { get; set; }

  /// <summary>
  /// The mods used for this score.
  /// </summary>
  [JsonProperty("mods")]
  public IReadOnlyCollection<string> Mods { get; set; } = default!;

  /// <summary>
  /// Bool whether this score passed the map.
  /// </summary>
  [JsonProperty("passed")]
  public bool IsPass { get; set; }

  /// <summary>
  /// Bool whether this score has a perfect combo.
  /// </summary>
  [JsonProperty("perfect")]
  public bool IsPerfect { get; set; }

  /// <summary>
  /// The amount of performance points the score is worth. This will be null if the score is not ranked.
  /// </summary>
  [JsonProperty("pp")]
  public float? PP { get; set; }

  /// <summary>
  /// The grade of this score. (XH, X, SH, S, A, B, C, D)
  /// </summary>
  [JsonProperty("rank")]
  public Grade Grade { get; set; }

  /// <summary>
  /// Bool whether the replay of this score is available on the osu! servers.
  /// </summary>
  [JsonProperty("replay")]
  public bool IsReplayAvailable { get; set; }

  /// <summary>
  /// The total score points for this score.
  /// </summary>
  [JsonProperty("score")]
  public int TotalScore { get; set; }

  /// <summary>
  /// Bool whether this score is the player's best score on the beatmap.
  /// </summary>
  public bool IsBest { get; set; }

  /// <summary>
  /// The statistics (hit judgments) of this score.
  /// </summary>
  [JsonProperty("statistics")]
  public ScoreStatistics Statistics { get; set; } = default!;

  /// <summary>
  /// The ID of the player of this score.
  /// </summary>
  [JsonProperty("user_id")]
  public int UserId { get; set; }

  #endregion

  #region Optional Attributes

  /// <summary>
  /// The beatmap this score was achieved on. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("beatmap")]
  public BeatmapExtended? Beatmap { get; set; }

  /// <summary>
  /// The beatmapset the beatmap this score was achieved on belongs to. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("beatmapset")]
  public BeatmapSet? BeatmapSet { get; set; }

  /// <summary>
  /// The match this score was achieved in. This is an optional property and will be null if the score was not achieved in a match.
  /// </summary>
  [JsonProperty("match")]
  public Match? Match { get; set; }

  /// <summary>
  /// The placement of the score on the beatmap's leaderboard in the player's country. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("rank_country")]
  public int RankCountry { get; set; }

  /// <summary>
  /// The placement of the score on the beatmap's leaderboard. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("rank_global")]
  public int RankGlobal { get; set; }

  /// <summary>
  /// The user that achieved this score. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("user")]
  public User? User { get; set; }

  /// <summary>
  /// The weighted performance points of this score. This is an optional property and will be null if the score is not ranked.
  /// </summary>
  [JsonProperty("weight")]
  public WeightedPP? WeightedPP { get; set; }

  #endregion
}