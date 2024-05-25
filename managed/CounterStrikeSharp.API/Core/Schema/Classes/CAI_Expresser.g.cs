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

public partial class CAI_Expresser : NativeObject
{
    public CAI_Expresser (IntPtr pointer) : base(pointer) {}

	// m_flStopTalkTime
	[SchemaMember("CAI_Expresser", "m_flStopTalkTime")]
	public ref float StopTalkTime => ref Schema.GetRef<float>(this.Handle, "CAI_Expresser", "m_flStopTalkTime");

	// m_flStopTalkTimeWithoutDelay
	[SchemaMember("CAI_Expresser", "m_flStopTalkTimeWithoutDelay")]
	public ref float StopTalkTimeWithoutDelay => ref Schema.GetRef<float>(this.Handle, "CAI_Expresser", "m_flStopTalkTimeWithoutDelay");

	// m_flBlockedTalkTime
	[SchemaMember("CAI_Expresser", "m_flBlockedTalkTime")]
	public ref float BlockedTalkTime => ref Schema.GetRef<float>(this.Handle, "CAI_Expresser", "m_flBlockedTalkTime");

	// m_voicePitch
	[SchemaMember("CAI_Expresser", "m_voicePitch")]
	public ref Int32 VoicePitch => ref Schema.GetRef<Int32>(this.Handle, "CAI_Expresser", "m_voicePitch");

	// m_flLastTimeAcceptedSpeak
	[SchemaMember("CAI_Expresser", "m_flLastTimeAcceptedSpeak")]
	public ref float LastTimeAcceptedSpeak => ref Schema.GetRef<float>(this.Handle, "CAI_Expresser", "m_flLastTimeAcceptedSpeak");

	// m_bAllowSpeakingInterrupts
	[SchemaMember("CAI_Expresser", "m_bAllowSpeakingInterrupts")]
	public ref bool AllowSpeakingInterrupts => ref Schema.GetRef<bool>(this.Handle, "CAI_Expresser", "m_bAllowSpeakingInterrupts");

	// m_bConsiderSceneInvolvementAsSpeech
	[SchemaMember("CAI_Expresser", "m_bConsiderSceneInvolvementAsSpeech")]
	public ref bool ConsiderSceneInvolvementAsSpeech => ref Schema.GetRef<bool>(this.Handle, "CAI_Expresser", "m_bConsiderSceneInvolvementAsSpeech");

	// m_bSceneEntityDisabled
	[SchemaMember("CAI_Expresser", "m_bSceneEntityDisabled")]
	public ref bool SceneEntityDisabled => ref Schema.GetRef<bool>(this.Handle, "CAI_Expresser", "m_bSceneEntityDisabled");

	// m_nLastSpokenPriority
	[SchemaMember("CAI_Expresser", "m_nLastSpokenPriority")]
	public ref Int32 LastSpokenPriority => ref Schema.GetRef<Int32>(this.Handle, "CAI_Expresser", "m_nLastSpokenPriority");

	// m_pOuter
	[SchemaMember("CAI_Expresser", "m_pOuter")]
	public CBaseFlex? Outer => Schema.GetPointer<CBaseFlex>(this.Handle, "CAI_Expresser", "m_pOuter");

}
