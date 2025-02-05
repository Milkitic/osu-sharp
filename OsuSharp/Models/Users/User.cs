using Newtonsoft.Json;
using OsuSharp.Converters;

namespace OsuSharp.Models.Users;

/// <summary>
/// Represents an osu! user.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#user"/><br/>
/// Sources:<br/>
/// <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/user-json.ts"/><br/>
/// <a href="https://github.com/ppy/osu-web/blob/master/app/Transformers/UserTransformer.php"/>
/// </summary>
public class User
{
  // TODO: potentially add the statistics_rulesets? doesnt seem to be returned by the api

  #region Default Attributes

  /// <summary>
  /// The URL for the avatar of this user.
  /// </summary>
  [JsonProperty("avatar_url")]
  public string AvatarUrl { get; set; } = default!;

  /// <summary>
  /// TODO: what is this?
  /// </summary>
  [JsonProperty("default_group")]
  public string? DefaultGroup { get; set; }

  /// <summary>
  /// The ID of the user.
  /// </summary>
  [JsonProperty("id")]
  public int Id { get; set; }

  /// <summary>
  /// Bool whether the user is active on osu!.
  /// </summary>
  [JsonProperty("is_active")]
  public bool IsActive { get; set; }

  /// <summary>
  /// Bool whether the user is a bot.
  /// </summary>
  [JsonProperty("is_bot")]
  public bool IsBot { get; set; }

  /// <summary>
  /// Bool whether the user was deleted.
  /// </summary>
  [JsonProperty("is_deleted")]
  public bool IsDeleted { get; set; }

  /// <summary>
  /// Bool whether the user is currently online.
  /// </summary>
  [JsonProperty("is_online")]
  public bool IsOnline { get; set; }

  /// <summary>
  /// Bool whether the user has the osu!supporter status.
  /// </summary>
  [JsonProperty("is_supporter")]
  public bool IsSupporter { get; set; }

  /// <summary>
  /// The datetime at which the user last visited osu!.
  /// </summary>
  [JsonProperty("last_visit")]
  public DateTimeOffset? LastVisit { get; set; }

  /// <summary>
  /// Bool whether the user only accepts private messages from friends.
  /// </summary>
  [JsonProperty("pm_friends_only")]
  public bool IsPMFriendsOnly { get; set; }

  /// <summary>
  /// The hex color of the user's profile. This may be null.
  /// </summary>
  [JsonProperty("profile_colour")]
  public string? ProfileColour { get; set; }

  /// <summary>
  /// The name of the user.
  /// </summary>
  [JsonProperty("username")]
  public string Username { get; set; } = default!;

  #endregion

  #region Optional Attributes

  /// <summary>
  /// The account history of this user, containing their restrictions, silences, etc. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("account_history")]
  public AccountHistoryEntry[]? AccountHistory { get; set; }

  /// <summary>
  /// TODO: what is this? i thought it might be the "main" one or if its just one
  /// but flary for example got the USA one and this is still null (banners array is not)
  /// </summary>
  [JsonProperty("active_tournament_banner")]
  public ProfileBanner? ActiveBanner { get; set; }

  /// <summary>
  /// The tournament banners of this user. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("active_tournament_banners")]
  public ProfileBanner[]? Banners { get; set; }

  /// <summary>
  /// The badges of this user. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("badges")]
  public Badge[]? Badges { get; set; }

  /// <summary>
  /// The amount of "most played beatmap" entries this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("beatmap_playcounts_count")]
  public int? MostPlayedCount { get; set; }

  /// <summary>
  /// TODO: what is this?
  /// </summary>
  [JsonProperty("comments_count")]
  public int? CommentsCount { get; set; }

  /// <summary>
  /// The country of this user. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("country")]
  public Country? Country { get; set; }

  /// <summary>
  /// The cover of this user. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("cover")]
  public UserCover? Cover { get; set; }

  /// <summary>
  /// The amount of favourited beatmapsets this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("favourite_beatmapset_count")]
  public int? FavouriteBeatmapSetsCount { get; set; }

  /// <summary>
  /// TODO: What is this?
  /// </summary>
  [JsonProperty("follow_user_mapping")]
  public int[]? FollowUserMapping { get; set; }

  /// <summary>
  /// The amount of followers this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("follower_count")]
  public int? FollowerCount { get; set; }

  /// <summary>
  /// The amount of graveyarded beatmapsets this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("graveyard_beatmapset_count")]
  public int? GraveyardedBeatmapSetsCount { get; set; }

  /// <summary>
  /// The groups the user is in. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("groups")]
  public Group[]? Groups { get; set; }

  /// <summary>
  /// The amount of guest participation on ranked or loved beatmapsets this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("guest_beatmapset_count")]
  public int? GuestBeatmapSetsCount { get; set; }

  /// <summary>
  /// Bool whether the user is an admin. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("is_admin")]
  public bool? IsAdmin { get; set; }

  /// <summary>
  /// Bool whether the user is part of the Beatmap Nomination Group. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("is_bng")]
  public bool? IsBNG { get; set; }

  /// <summary>
  /// Bool whether the user is a full beatmap nominator (not probationary). This is an optional property and may be null.
  /// </summary>
  [JsonProperty("is_full_bn")]
  public bool? IsFullNominator { get; set; }

  /// <summary>
  /// Bool whether the user is part of the Global Moderation Team. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("is_gmt")]
  public bool? IsGMT { get; set; }

  /// <summary>
  /// Bool whether the user is a probationary beatmap nominator. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("is_limited_bn")]
  public bool? IsProbationaryNominator { get; set; }

  /// <summary>
  /// TODO: what is this?
  /// </summary>
  [JsonProperty("is_moderator")]
  public bool? IsModerator { get; set; }

  /// <summary>
  /// Bool whether the user is part of the Nomination Assessment Team. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("is_nat")]
  public bool? IsNAT { get; set; }

  /// <summary>
  /// Bool whether the user is restricted. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("is_restricted")]
  public bool? IsRestricted { get; set; }

  /// <summary>
  /// Bool whether the user is silenced. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("is_silenced")]
  public bool? IsSilenced { get; set; }

  /// <summary>
  /// The amount of kudosu this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("kudosu")]
  public Kudosu? Kudosu { get; set; }

  /// <summary>
  /// The amount of loved beatmapsets this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("loved_beatmapset_count")]
  public int? LovedBeatmapSetsCount { get; set; }

  /// <summary>
  /// The amount of mapping followers this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("mapping_follower_count")]
  public int? MappingFollowerCount { get; set; }

  /// <summary>
  /// The monthly playcount of this user. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("monthly_playcounts")]
  public MonthlyPlaycountEntry[]? MonthlyPlaycount { get; set; }

  /// <summary>
  /// The amount of beatmapsets this user has nominated. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("nominated_beatmapset_count")]
  public int? NominatedBeatmapSetsCount { get; set; }

  /// <summary>
  /// The me! section of this user's profile. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("page")]
  public UserPage? Page { get; set; }

  /// <summary>
  /// The amount of pending beatmapsets this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("pending_beatmapset_count")]
  public int? PendingBeatmapSetsCount { get; set; }

  /// <summary>
  /// The previous usernames of this user. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("previous_usernames")]
  public string[]? PreviousUsernames { get; set; }

  /// <summary>
  /// The highest rank this user has achieved. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("rank_highest")]
  public HighestRank? HighestRank { get; set; }

  /// <summary>
  /// The rank history of this user. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("rank_history")]
  public RankHistory? RankHistory { get; set; }

  /// <summary>
  /// The amount of ranked beatmapsets this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("ranked_beatmapset_count")]
  public int? RankedBeatmapSetsCount { get; set; }

  /// <summary>
  /// The monthly replays watched from this user. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("replays_watched_counts")]
  public MonthlyReplaysWatchedEntry[]? ReplaysWatched { get; set; }

  /// <summary>
  /// The amount of top plays this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("scores_best_count")]
  public int? BestScoresCount { get; set; }

  /// <summary>
  /// The amount of first place scores this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("scores_first_count")]
  public int? FirstScoresCount { get; set; }

  /// <summary>
  /// The amount of pinned scores this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("scores_pinned_count")]
  public int? PinnedScoresCount { get; set; }

  /// <summary>
  /// The amount of recent scores this user has. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("scores_recent_count")]
  public int? RecentScoresCount { get; set; }

  /// <summary>
  /// The statistics of this user. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("statistics")]
  public UserStatistics? Statistics { get; set; }

  /// <summary>
  /// TODO: what is this?
  /// </summary>
  [JsonProperty("support_level")]
  public int? SupportLevel { get; set; }

  /// <summary>
  /// The achievements of this user. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("user_achievements")]
  public Achievement[]? Achievements { get; set; }

  #endregion
}
