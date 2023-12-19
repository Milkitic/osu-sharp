﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSharp.Enums;

/// <summary>
/// The type of a changelog entry, describing the type of change made (Add, Fix, ...).
/// <br/><br/>
/// API docs: Not documented, refer to source<br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/database/factories/ChangelogFactory.php"/>
/// </summary>
public enum ChangelogEntryType
{
  /// <summary>
  /// Indicates an addition.
  /// </summary>
  [Description("add")]
  Add,

  /// <summary>
  /// Indicates a change that fixes a bug.
  /// </summary>
  [Description("fix")]
  Fix
}
