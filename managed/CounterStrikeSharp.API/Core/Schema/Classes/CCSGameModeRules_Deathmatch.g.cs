// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CCSGameModeRules_Deathmatch : CCSGameModeRules
{
    public CCSGameModeRules_Deathmatch (IntPtr pointer) : base(pointer) {}

	// m_flDMBonusStartTime
	[SchemaMember("CCSGameModeRules_Deathmatch", "m_flDMBonusStartTime")]
	public ref float DMBonusStartTime => ref Schema.GetRef<float>(this.Handle, "CCSGameModeRules_Deathmatch", "m_flDMBonusStartTime");

	// m_flDMBonusTimeLength
	[SchemaMember("CCSGameModeRules_Deathmatch", "m_flDMBonusTimeLength")]
	public ref float DMBonusTimeLength => ref Schema.GetRef<float>(this.Handle, "CCSGameModeRules_Deathmatch", "m_flDMBonusTimeLength");

	// m_sDMBonusWeapon
	[SchemaMember("CCSGameModeRules_Deathmatch", "m_sDMBonusWeapon")]
	public string DMBonusWeapon
	{
		get { return Schema.GetUtf8String(this.Handle, "CCSGameModeRules_Deathmatch", "m_sDMBonusWeapon"); }
		set { Schema.SetString(this.Handle, "CCSGameModeRules_Deathmatch", "m_sDMBonusWeapon", value); }
	}

}
