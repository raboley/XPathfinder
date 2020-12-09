// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
// Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020 Last
// Last Modified On : 07-13-2020 ***********************************************************************
// <copyright file="enums.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PathFinder.Common
{
    /// <summary>
    /// Enum NpcType
    /// </summary>
    public enum NpcType : byte
    {
        /// <summary>
        /// The pc
        /// </summary>
        PC = 0x01,

        /// <summary>
        /// The NPC
        /// </summary>
        NPC = 0x02,

        /// <summary>
        /// The self
        /// </summary>
        Self = 0x0D,

        /// <summary>
        /// The mob
        /// </summary>
        Mob = 0x10,

        /// <summary>
        /// The inanimate object
        /// </summary>
        InanimateObject,
    }
}

/// <summary>
/// Ability List
/// </summary>
public enum AbilityList : byte
{
    /// <summary>
    /// The two hour
    /// </summary>
    Two_Hour = 0,

    /// <summary>
    /// The berserk
    /// </summary>
    Berserk = 1,

    /// <summary>
    /// The warcry
    /// </summary>
    Warcry = 2,

    /// <summary>
    /// The defender
    /// </summary>
    Defender = 3,

    /// <summary>
    /// The aggressor
    /// </summary>
    Aggressor = 4,

    /// <summary>
    /// The provoke
    /// </summary>
    Provoke = 5,

    /// <summary>
    /// The enrage
    /// </summary>
    Enrage = 6,

    /// <summary>
    /// The tomahawk
    /// </summary>
    Tomahawk = 7,

    /// <summary>
    /// The retaliation
    /// </summary>
    Retaliation = 8,

    /// <summary>
    /// The restraint
    /// </summary>
    Restraint = 9,

    /// <summary>
    /// The rune enhancement elemental
    /// </summary>
    Rune_Enhancement_Elemental = 10,

    /// <summary>
    /// The blood rage
    /// </summary>
    Blood_Rage = 11,

    /// <summary>
    /// The focus
    /// </summary>
    Focus = 13,

    /// <summary>
    /// The dodge
    /// </summary>
    Dodge = 14,

    /// <summary>
    /// The chakra
    /// </summary>
    Chakra = 15,

    /// <summary>
    /// The boost
    /// </summary>
    Boost = 16,

    /// <summary>
    /// The counterstance
    /// </summary>
    Counterstance = 17,

    /// <summary>
    /// The chi blast
    /// </summary>
    Chi_Blast = 18,

    /// <summary>
    /// The mantra
    /// </summary>
    Mantra = 19,

    /// <summary>
    /// The formless strikes
    /// </summary>
    Formless_Strikes = 20,

    /// <summary>
    /// The footwork
    /// </summary>
    Footwork = 21,

    /// <summary>
    /// The perfect counter
    /// </summary>
    Perfect_Counter = 22,

    /// <summary>
    /// The vallation
    /// </summary>
    Vallation = 23,

    /// <summary>
    /// The swordplay
    /// </summary>
    Swordplay = 24,

    /// <summary>
    /// The lunge
    /// </summary>
    Lunge = 25,

    /// <summary>
    /// The divine seal
    /// </summary>
    Divine_Seal = 26,

    /// <summary>
    /// The martyr
    /// </summary>
    Martyr = 27,

    /// <summary>
    /// The devotion
    /// </summary>
    Devotion = 28,

    /// <summary>
    /// The afflatus solace
    /// </summary>
    Afflatus_Solace = 29,

    /// <summary>
    /// The afflatus misery
    /// </summary>
    Afflatus_Misery = 30,

    /// <summary>
    /// The impetus
    /// </summary>
    Impetus = 31,

    /// <summary>
    /// The divine caress
    /// </summary>
    Divine_Caress = 32,

    /// <summary>
    /// The sacrosanctity
    /// </summary>
    Sacrosanctity = 33,

    /// <summary>
    /// The enmity douse
    /// </summary>
    Enmity_Douse = 34,

    /// <summary>
    /// The manawell
    /// </summary>
    Manawell = 35,

    /// <summary>
    /// The saboteur
    /// </summary>
    Saboteur = 36,

    /// <summary>
    /// The spontaneity
    /// </summary>
    Spontaneity = 37,

    /// <summary>
    /// The elemental seal
    /// </summary>
    Elemental_Seal = 38,

    /// <summary>
    /// The mana wall
    /// </summary>
    Mana_Wall = 39,

    /// <summary>
    /// The conspirator
    /// </summary>
    Conspirator = 40,

    /// <summary>
    /// The sepulcher
    /// </summary>
    Sepulcher = 41,

    /// <summary>
    /// The palisade
    /// </summary>
    Palisade = 42,

    /// <summary>
    /// The arcane crest
    /// </summary>
    Arcane_Crest = 43,

    /// <summary>
    /// The scarlet delirium
    /// </summary>
    Scarlet_Delirium = 44,

    /// <summary>
    /// The spur
    /// </summary>
    Spur = 45,

    /// <summary>
    /// The run wild
    /// </summary>
    Run_Wild = 46,

    /// <summary>
    /// The tenuto
    /// </summary>
    Tenuto = 47,

    /// <summary>
    /// The marcato
    /// </summary>
    Marcato = 48,

    /// <summary>
    /// The convert
    /// </summary>
    Convert = 49,

    /// <summary>
    /// The composure
    /// </summary>
    Composure = 50,

    /// <summary>
    /// The bounty shot
    /// </summary>
    Bounty_Shot = 51,

    /// <summary>
    /// The decoy shot
    /// </summary>
    Decoy_Shot = 52,

    /// <summary>
    /// The hamanoha
    /// </summary>
    Hamanoha = 53,

    /// <summary>
    /// The hagakure
    /// </summary>
    Hagakure = 54,

    /// <summary>
    /// The issekigan
    /// </summary>
    Issekigan = 57,

    /// <summary>
    /// The dragon breaker
    /// </summary>
    Dragon_Breaker = 58,

    /// <summary>
    /// The pflug
    /// </summary>
    Pflug = 59,

    /// <summary>
    /// The steal
    /// </summary>
    Steal = 60,

    /// <summary>
    /// The despoil
    /// </summary>
    Despoil = 61,

    /// <summary>
    /// The flee
    /// </summary>
    Flee = 62,

    /// <summary>
    /// The hide
    /// </summary>
    Hide = 63,

    /// <summary>
    /// The sneak attack
    /// </summary>
    Sneak_Attack = 64,

    /// <summary>
    /// The mug
    /// </summary>
    Mug = 65,

    /// <summary>
    /// The trick attack
    /// </summary>
    Trick_Attack = 66,

    /// <summary>
    /// The assassins charge
    /// </summary>
    Assassins_Charge = 67,

    /// <summary>
    /// The feint
    /// </summary>
    Feint = 68,

    /// <summary>
    /// The accomplice
    /// </summary>
    Accomplice = 69,

    /// <summary>
    /// The steady wing
    /// </summary>
    Steady_Wing = 70,

    /// <summary>
    /// The mana cede
    /// </summary>
    Mana_Cede = 71,

    /// <summary>
    /// The embolden
    /// </summary>
    Embolden = 72,

    /// <summary>
    /// The shield bash
    /// </summary>
    Shield_Bash = 73,

    /// <summary>
    /// The holy circle
    /// </summary>
    Holy_Circle = 74,

    /// <summary>
    /// The sentinel
    /// </summary>
    Sentinel = 75,

    /// <summary>
    /// The cover
    /// </summary>
    Cover = 76,

    /// <summary>
    /// The rampart
    /// </summary>
    Rampart = 77,

    /// <summary>
    /// The fealty
    /// </summary>
    Fealty = 78,

    /// <summary>
    /// The chivalry
    /// </summary>
    Chivalry = 79,

    /// <summary>
    /// The divine emblem
    /// </summary>
    Divine_Emblem = 80,

    /// <summary>
    /// The unbridled learning
    /// </summary>
    Unbridled_Learning = 81,

    /// <summary>
    /// The triple shot
    /// </summary>
    Triple_Shot = 84,

    /// <summary>
    /// The souleater
    /// </summary>
    Souleater = 85,

    /// <summary>
    /// The arcane circle
    /// </summary>
    Arcane_Circle = 86,

    /// <summary>
    /// The last resort
    /// </summary>
    Last_Resort = 87,

    /// <summary>
    /// The weapon bash
    /// </summary>
    Weapon_Bash = 88,

    /// <summary>
    /// The dark seal
    /// </summary>
    Dark_Seal = 89,

    /// <summary>
    /// The diabolic eye
    /// </summary>
    Diabolic_Eye = 90,

    /// <summary>
    /// The nether void
    /// </summary>
    Nether_Void = 91,

    /// <summary>
    /// The rune enchantment
    /// </summary>
    Rune_Enchantment = 92,

    /// <summary>
    /// The charm
    /// </summary>
    Charm = 97,

    /// <summary>
    /// The gauge
    /// </summary>
    Gauge = 98,

    /// <summary>
    /// The tame
    /// </summary>
    Tame = 99,

    /// <summary>
    /// The fight
    /// </summary>
    Fight = 100,

    /// <summary>
    /// The heel
    /// </summary>
    Heel = 101,

    /// <summary>
    /// The sic
    /// </summary>
    Sic = 102,

    /// <summary>
    /// The reward
    /// </summary>
    Reward = 103,

    /// <summary>
    /// The call beast
    /// </summary>
    Call_Beast = 104,

    /// <summary>
    /// The feral howl
    /// </summary>
    Feral_Howl = 105,

    /// <summary>
    /// The killer instinct
    /// </summary>
    Killer_Instinct = 106,

    /// <summary>
    /// The snarl
    /// </summary>
    Snarl = 107,

    /// <summary>
    /// The nightingale
    /// </summary>
    Nightingale = 109,

    /// <summary>
    /// The troubadour
    /// </summary>
    Troubadour = 110,

    /// <summary>
    /// The pianissimo
    /// </summary>
    Pianissimo = 112,

    /// <summary>
    /// The valiance
    /// </summary>
    Valiance = 113,

    /// <summary>
    /// The cooldown
    /// </summary>
    Cooldown = 114,

    /// <summary>
    /// The deus ex automata
    /// </summary>
    Deus_Ex_Automata = 115,

    /// <summary>
    /// The gambit
    /// </summary>
    Gambit = 116,

    /// <summary>
    /// The liement
    /// </summary>
    Liement = 117,

    /// <summary>
    /// The one for all
    /// </summary>
    One_for_All = 118,

    /// <summary>
    /// The rayke
    /// </summary>
    Rayke = 119,

    /// <summary>
    /// The battuta
    /// </summary>
    Battuta = 120,

    /// <summary>
    /// The scavenge
    /// </summary>
    Scavenge = 121,

    /// <summary>
    /// The shadowbind
    /// </summary>
    Shadowbind = 122,

    /// <summary>
    /// The camouflage
    /// </summary>
    Camouflage = 123,

    /// <summary>
    /// The sharpshot
    /// </summary>
    Sharpshot = 124,

    /// <summary>
    /// The barrage
    /// </summary>
    Barrage = 125,

    /// <summary>
    /// The unlimited shot
    /// </summary>
    Unlimited_Shot = 126,

    /// <summary>
    /// The stealth shot
    /// </summary>
    Stealth_Shot = 127,

    /// <summary>
    /// The flashy shot
    /// </summary>
    Flashy_Shot = 128,

    /// <summary>
    /// The velocity shot
    /// </summary>
    Velocity_Shot = 129,

    /// <summary>
    /// The widened compass
    /// </summary>
    Widened_Compass = 130,

    /// <summary>
    /// The odyllic subterfuge
    /// </summary>
    Odyllic_Subterfuge = 131,

    /// <summary>
    /// The konzen ittai
    /// </summary>
    Konzen_ittai = 132,

    /// <summary>
    /// The third eye
    /// </summary>
    Third_Eye = 133,

    /// <summary>
    /// The meditate
    /// </summary>
    Meditate = 134,

    /// <summary>
    /// The warding circle
    /// </summary>
    Warding_Circle = 135,

    /// <summary>
    /// The shikikoyo
    /// </summary>
    Shikikoyo = 136,

    /// <summary>
    /// The blade bash
    /// </summary>
    Blade_Bash = 137,

    /// <summary>
    /// The hasso
    /// </summary>
    Hasso = 138,

    /// <summary>
    /// The seigan
    /// </summary>
    Seigan = 139,

    /// <summary>
    /// The sekkanoki
    /// </summary>
    Sekkanoki = 140,

    /// <summary>
    /// The sengikori
    /// </summary>
    Sengikori = 141,

    /// <summary>
    /// The ward
    /// </summary>
    Ward = 142,

    /// <summary>
    /// The effusion
    /// </summary>
    Effusion = 143,

    /// <summary>
    /// The sange
    /// </summary>
    Sange = 145,

    /// <summary>
    /// The yonin
    /// </summary>
    Yonin = 146,

    /// <summary>
    /// The innin
    /// </summary>
    Innin = 147,

    /// <summary>
    /// The futae
    /// </summary>
    Futae = 148,

    /// <summary>
    /// The ancient circle
    /// </summary>
    Ancient_Circle = 157,

    /// <summary>
    /// The jump
    /// </summary>
    Jump = 158,

    /// <summary>
    /// The high jump
    /// </summary>
    High_Jump = 159,

    /// <summary>
    /// The super jump
    /// </summary>
    Super_Jump = 160,

    /// <summary>
    /// The dismiss
    /// </summary>
    Dismiss = 161,

    /// <summary>
    /// The spirit link
    /// </summary>
    Spirit_Link = 162,

    /// <summary>
    /// The call wyvern
    /// </summary>
    Call_Wyvern = 163,

    /// <summary>
    /// The deep breathing
    /// </summary>
    Deep_Breathing = 164,

    /// <summary>
    /// The angon
    /// </summary>
    Angon = 165,

    /// <summary>
    /// The assault
    /// </summary>
    Assault = 170,

    /// <summary>
    /// The retreat
    /// </summary>
    Retreat = 171,

    /// <summary>
    /// The release
    /// </summary>
    Release = 172,

    /// <summary>
    /// The blood pact rage
    /// </summary>
    Blood_Pact_Rage = 173,

    /// <summary>
    /// The blood pact ward
    /// </summary>
    Blood_Pact_Ward = 174,

    /// <summary>
    /// The elemental siphon
    /// </summary>
    Elemental_Siphon = 175,

    /// <summary>
    /// The avatars favor
    /// </summary>
    Avatars_Favor = 176,

    /// <summary>
    /// The chain affinity
    /// </summary>
    Chain_Affinity = 181,

    /// <summary>
    /// The burst affinity
    /// </summary>
    Burst_Affinity = 182,

    /// <summary>
    /// The convergence
    /// </summary>
    Convergence = 183,

    /// <summary>
    /// The diffusion
    /// </summary>
    Diffusion = 184,

    /// <summary>
    /// The efflux
    /// </summary>
    Efflux = 185,

    /// <summary>
    /// The cor roll
    /// </summary>
    COR_Roll = 193,

    /// <summary>
    /// The double up
    /// </summary>
    Double_Up = 194,

    /// <summary>
    /// The elemental shot
    /// </summary>
    Elemental_Shot = 195,

    /// <summary>
    /// The random deal
    /// </summary>
    Random_Deal = 196,

    /// <summary>
    /// The snake eye
    /// </summary>
    Snake_Eye = 197,

    /// <summary>
    /// The fold
    /// </summary>
    Fold = 198,

    /// <summary>
    /// The quick draw
    /// </summary>
    Quick_Draw = 199,

    /// <summary>
    /// The activate
    /// </summary>
    Activate = 205,

    /// <summary>
    /// The repair
    /// </summary>
    Repair = 206,

    /// <summary>
    /// The deploy
    /// </summary>
    Deploy = 207,

    /// <summary>
    /// The deactivate
    /// </summary>
    Deactivate = 208,

    /// <summary>
    /// The retrieve
    /// </summary>
    Retrieve = 209,

    /// <summary>
    /// The fire maneuver
    /// </summary>
    Fire_Maneuver = 210,

    /// <summary>
    /// The role reversal
    /// </summary>
    Role_Reversal = 211,

    /// <summary>
    /// The ventriloquy
    /// </summary>
    Ventriloquy = 212,

    /// <summary>
    /// The tactical switch
    /// </summary>
    Tactical_Switch = 213,

    /// <summary>
    /// The maintenance
    /// </summary>
    Maintenance = 214,

    /// <summary>
    /// The healing waltz
    /// </summary>
    Healing_Waltz = 215,

    /// <summary>
    /// The sambas
    /// </summary>
    Sambas = 216,

    /// <summary>
    /// The curing waltz
    /// </summary>
    Curing_Waltz = 217,

    /// <summary>
    /// The spectral jig
    /// </summary>
    Spectral_Jig = 218,

    /// <summary>
    /// The saber dance
    /// </summary>
    Saber_Dance = 219,

    /// <summary>
    /// The steps
    /// </summary>
    Steps = 220,

    /// <summary>
    /// The flourishes i
    /// </summary>
    Flourishes_I = 221,

    /// <summary>
    /// The reverse flourish
    /// </summary>
    Reverse_Flourish = 222,

    /// <summary>
    /// The no foot rise
    /// </summary>
    No_Foot_Rise = 223,

    /// <summary>
    /// The fan dance
    /// </summary>
    Fan_Dance = 224,

    /// <summary>
    /// The divine waltz
    /// </summary>
    Divine_Waltz = 225,

    /// <summary>
    /// The flourishes iii
    /// </summary>
    Flourishes_III = 226,

    /// <summary>
    /// The waltzes
    /// </summary>
    Waltzes = 227,

    /// <summary>
    /// The light arts
    /// </summary>
    Light_Arts = 228,

    /// <summary>
    /// The modus veritas
    /// </summary>
    Modus_Veritas = 230,

    /// <summary>
    /// The penury
    /// </summary>
    Penury = 231,

    /// <summary>
    /// The dark arts
    /// </summary>
    Dark_Arts = 232,

    /// <summary>
    /// The stratagems
    /// </summary>
    Stratagems = 233,

    /// <summary>
    /// The sublimation
    /// </summary>
    Sublimation = 234,

    /// <summary>
    /// The enlightenment
    /// </summary>
    Enlightenment = 235,

    /// <summary>
    /// The presto
    /// </summary>
    Presto = 236,

    /// <summary>
    /// The libra
    /// </summary>
    Libra = 237,

    /// <summary>
    /// The smiting breath
    /// </summary>
    Smiting_Breath = 238,

    /// <summary>
    /// The restoring breath
    /// </summary>
    Restoring_Breath = 239,

    /// <summary>
    /// The bully
    /// </summary>
    Bully = 240,

    /// <summary>
    /// The swipe
    /// </summary>
    Swipe = 241,

    /// <summary>
    /// The vivacious pulse
    /// </summary>
    Vivacious_Pulse = 242,

    /// <summary>
    /// The full circle
    /// </summary>
    Full_Circle = 243,

    /// <summary>
    /// The lasting emanation
    /// </summary>
    Lasting_Emanation = 244,

    /// <summary>
    /// The collimated fervor
    /// </summary>
    Collimated_Fervor = 245,

    /// <summary>
    /// The life cycle
    /// </summary>
    Life_Cycle = 246,

    /// <summary>
    /// The blaze glory
    /// </summary>
    Blaze_Glory = 247,

    /// <summary>
    /// The dematerialize
    /// </summary>
    Dematerialize = 248,

    /// <summary>
    /// The theurgic focus
    /// </summary>
    Theurgic_Focus = 249,

    /// <summary>
    /// The concentric pulse
    /// </summary>
    Concentric_Pulse = 250,

    /// <summary>
    /// The mending halation
    /// </summary>
    Mending_Halation = 251,

    /// <summary>
    /// The radial arcana
    /// </summary>
    Radial_Arcana = 252,

    /// <summary>
    /// The relinquish
    /// </summary>
    Relinquish = 253,

    /// <summary>
    /// The sp ii
    /// </summary>
    SP_II = 254,

    /// <summary>
    /// The pet commands
    /// </summary>
    Pet_commands = 255
}

/// <summary>
/// Chat Modes
/// </summary>
public enum ChatMode : short
{
    /// <summary>
    /// The error
    /// </summary>
    Error = -1,             // "Invented" chat mode, to help catch errors

    /// <summary>
    /// The generic
    /// </summary>
    Generic = 0,        // Unknown = 0,			 // Catch all. it's not a catch all.

    //--------------------------------------------------------------'
    //-Text That's Been Sent To The ChatLog By You aKa (The Player-)'
    //--------------------------------------------------------------'
    /// <summary>
    /// The sent say
    /// </summary>
    SentSay = 1,             // = a say message that the user sends

    /// <summary>
    /// The sent shout
    /// </summary>
    SentShout = 2,         // = a shout message that the user sends

    /// <summary>
    /// The sent yell
    /// </summary>
    SentYell = 3,

    /// <summary>
    /// The sent tell
    /// </summary>
    SentTell = 4,           // = user sends tell to someone else

    /// <summary>
    /// The sent party
    /// </summary>
    SentParty = 5,         // = user message to Party

    /// <summary>
    /// The sent link shell
    /// </summary>
    SentLinkShell = 6,     // = user message to linkshell

    /// <summary>
    /// The sent emote
    /// </summary>
    SentEmote = 7,            // = user uses /emote

    //--------------------------------------------------------------'
    //----Text That's Been Recieved In ChatLog By Other Players-----'
    //--------------------------------------------------------------'
    /// <summary>
    /// The RCVD say
    /// </summary>
    RcvdSay = 9,             // = a say mesage the user recieves from someone else

    /// <summary>
    /// The RCVD shout
    /// </summary>
    RcvdShout = 10,       // = incoming shout

    /// <summary>
    /// The RCVD yell
    /// </summary>
    RcvdYell = 11,

    /// <summary>
    /// The RCVD tell
    /// </summary>
    RcvdTell = 12,         // = incoming tell

    /// <summary>
    /// The RCVD party
    /// </summary>
    RcvdParty = 13,       // = incoming party message

    /// <summary>
    /// The RCVD link shell
    /// </summary>
    RcvdLinkShell = 14,   // = incoming linkshell text

    /// <summary>
    /// The RCVD emote
    /// </summary>
    RcvdEmote = 15,          // = received Emote

    // Yell???

    //--------------------------------------------------------------'
    //-----------You aKa (The Player's) Fight Log Stuff-------------'
    //--------------------------------------------------------------'
    /// <summary>
    /// The player hits
    /// </summary>
    PlayerHits = 20,    // eg. Player hits the Thread Leech for XX points of damage.

    /// <summary>
    /// The player misses
    /// </summary>
    PlayerMisses = 21,

    /// <summary>
    /// The target uses job ability
    /// </summary>
    TargetUsesJobAbility = 22, // eg. The Thread Leech uses TP Drainkiss.

    /// <summary>
    /// The someone recovers hp
    /// </summary>
    SomeoneRecoversHP = 23,

    /// <summary>
    /// The target hits
    /// </summary>
    TargetHits = 28,     // eg. The Thread Leech hits Player for XX points of damage.

    /// <summary>
    /// The target misses
    /// </summary>
    TargetMisses = 29,     // eg. The Thread Leech misses Player.

    /// <summary>
    /// The player additional effect
    /// </summary>
    PlayerAdditionalEffect = 30,

    /// <summary>
    /// The player recovers hp
    /// </summary>
    PlayerRecoversHP = 31,      // Player casts Cure. Player recovers 30 HP.

    /// <summary>
    /// The player defeats
    /// </summary>
    PlayerDefeats = 36,   // eg. Player Defeats the T

    /// <summary>
    /// The played defeated
    /// </summary>
    PlayedDefeated = 38,

    /// <summary>
    /// The NPC hit
    /// </summary>
    NPCHit = 40,

    /// <summary>
    /// The NPC miss
    /// </summary>
    NPCMiss = 41,

    /// <summary>
    /// The NPC spell effect
    /// </summary>
    NPCSpellEffect = 42,

    /// <summary>
    /// The someone spell effect
    /// </summary>
    SomeoneSpellEffect = 43,

    /// <summary>
    /// The someone defeats
    /// </summary>
    SomeoneDefeats = 44,     // = somebody "defeats the" river crab or whatever

    /// <summary>
    /// The player cast complete
    /// </summary>
    PlayerCastComplete = 50,

    /// <summary>
    /// The party spell effect
    /// </summary>
    PartySpellEffect = 51,

    /// <summary>
    /// The player start casting
    /// </summary>
    PlayerStartCasting = 52, // eg. Player starts casting Dia on the Thread Leech., The Antican Princeps starts casting Flash.

    /// <summary>
    /// The player spell result
    /// </summary>
    PlayerSpellResult = 56,

    /// <summary>
    /// The player RCVD effect
    /// </summary>
    PlayerRcvdEffect = 57, // The Antican Princeps casts Flash. <name> is blinded.

    /// <summary>
    /// The player spell resist
    /// </summary>
    PlayerSpellResist = 59,

    /// <summary>
    /// The player spell effect
    /// </summary>
    PlayerSpellEffect = 64,

    /// <summary>
    /// The target effect off
    /// </summary>
    TargetEffectOff = 65,

    /// <summary>
    /// The someone no effect
    /// </summary>
    SomeoneNoEffect = 69,

    /// <summary>
    /// The player learned spell
    /// </summary>
    PlayerLearnedSpell = 81,

    /// <summary>
    /// The itemused
    /// </summary>
    Itemused = 90,

    /// <summary>
    /// The someone item bad effect
    /// </summary>
    SomeoneItemBadEffect = 91,

    /// <summary>
    /// The someone item good efect
    /// </summary>
    SomeoneItemGoodEfect = 92,

    /// <summary>
    /// The target action start
    /// </summary>
    TargetActionStart = 100,

    /// <summary>
    /// The player uses job ability
    /// </summary>
    PlayerUsesJobAbility = 101, // eg. Player uses Divine Seal.

    /// <summary>
    /// The player status result
    /// </summary>
    PlayerStatusResult = 102,

    /// <summary>
    /// The target action miss
    /// </summary>
    TargetActionMiss = 104,

    /// <summary>
    /// The player readies move
    /// </summary>
    PlayerReadiesMove = 110, // eg. The Thread Leech readies Brain Drain.

    /// <summary>
    /// The someone ability
    /// </summary>
    SomeoneAbility = 111,

    /// <summary>
    /// The someone bad effect
    /// </summary>
    SomeoneBadEffect = 112,

    /// <summary>
    /// The player ws miss
    /// </summary>
    PlayerWSMiss = 114,

    /// <summary>
    /// The synth result
    /// </summary>
    SynthResult = 121,     // = you throw away a rusty subligar or whatever

    /// <summary>
    /// The players bad cast
    /// </summary>
    PlayersBadCast = 122,   // eg. Inturrupted or Unable to Cast. eg: Unable To Cast That Spell

    /// <summary>
    /// The tell not RCVD
    /// </summary>
    TellNotRcvd = 123,     // = your tell was not received

    /// <summary>
    /// The obtained
    /// </summary>
    Obtained = 127,

    /// <summary>
    /// The skill boost
    /// </summary>
    SkillBoost = 129,       // = you fishing skill rises 0.1 points

    /// <summary>
    /// The experience
    /// </summary>
    Experience = 131,

    /// <summary>
    /// The action start
    /// </summary>
    ActionStart = 135,

    /// <summary>
    /// The logout message
    /// </summary>
    LogoutMessage = 136,

    /// <summary>
    /// The item sold
    /// </summary>
    ItemSold = 138,       // = item sold

    /// <summary>
    /// The clock information
    /// </summary>
    ClockInfo = 140,

    /// <summary>
    /// The moogle yellow
    /// </summary>
    MoogleYellow = 141,

    /// <summary>
    /// The NPC chat
    /// </summary>
    NPCChat = 142,

    /// <summary>
    /// The moogle white
    /// </summary>
    MoogleWhite = 144,

    /// <summary>
    /// The fish obtained
    /// </summary>
    FishObtained = 146,   // "player caught ....!"

    /// <summary>
    /// The fish result
    /// </summary>
    FishResult = 148,       // = fishing result including:

    /// <summary>
    /// The NPC speaking
    /// </summary>
    NPCSpeaking = 152,    // = something caught on hook... incorrect, NPC speaking to you

    /// <summary>
    /// The command error
    /// </summary>
    CommandError = 157,   // = A command error occurred

    /// <summary>
    /// The drop rip cap
    /// </summary>
    DropRipCap = 159,       // = you release the ripped cap regretfully

    /// <summary>
    /// The reg conquest
    /// </summary>
    RegConquest = 161,     // = regional conquest update message

    /// <summary>
    /// The change job
    /// </summary>
    ChangeJob = 190,

    /// <summary>
    /// The effect wear off
    /// </summary>
    EffectWearOff = 191,     // eg. Player's Protect effect wears off

    /// <summary>
    /// The server notice
    /// </summary>
    ServerNotice = 200,    // = notice of upcoming server maintenance

    /// <summary>
    /// The search comment
    /// </summary>
    SearchComment = 204,

    /// <summary>
    /// The lsmes
    /// </summary>
    LSMES = 205,

    /// <summary>
    /// The echo
    /// </summary>
    Echo = 206,           // = echo

    /// <summary>
    /// The examined
    /// </summary>
    Examined = 208,

    /// <summary>
    /// The abil time left
    /// </summary>
    AbilTimeLeft = 209    // Time left on "job ability"
}

/// <summary>
/// Enum Mode
/// </summary>
public enum Mode
{
    /// <summary>
    /// The farming
    /// </summary>
    Farming = 0,

    /// <summary>
    /// The dynamis
    /// </summary>
    Dynamis = 1,

    /// <summary>
    /// The salvage
    /// </summary>
    Salvage = 2,

    /// <summary>
    /// The limbus
    /// </summary>
    Limbus = 3
}

/// <summary>
/// Spell List
/// </summary>
public enum SpellList : short
{
    /// <summary>
    /// The unknown
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// The cure
    /// </summary>
    Cure = 2,

    /// <summary>
    /// The cure ii
    /// </summary>
    Cure_II = 4,

    /// <summary>
    /// The cure iii
    /// </summary>
    Cure_III = 6,

    /// <summary>
    /// The cure iv
    /// </summary>
    Cure_IV = 8,

    /// <summary>
    /// The cure v
    /// </summary>
    Cure_V = 10,

    /// <summary>
    /// The cure vi
    /// </summary>
    Cure_VI = 12,

    /// <summary>
    /// The curaga
    /// </summary>
    Curaga = 14,

    /// <summary>
    /// The curaga ii
    /// </summary>
    Curaga_II = 16,

    /// <summary>
    /// The curaga iii
    /// </summary>
    Curaga_III = 18,

    /// <summary>
    /// The curaga iv
    /// </summary>
    Curaga_IV = 20,

    /// <summary>
    /// The curaga v
    /// </summary>
    Curaga_V = 22,

    /// <summary>
    /// The raise
    /// </summary>
    Raise = 24,

    /// <summary>
    /// The raise ii
    /// </summary>
    Raise_II = 26,

    /// <summary>
    /// The poisona
    /// </summary>
    Poisona = 28,

    /// <summary>
    /// The paralyna
    /// </summary>
    Paralyna = 30,

    /// <summary>
    /// The blindna
    /// </summary>
    Blindna = 32,

    /// <summary>
    /// The silena
    /// </summary>
    Silena = 34,

    /// <summary>
    /// The stona
    /// </summary>
    Stona = 36,

    /// <summary>
    /// The viruna
    /// </summary>
    Viruna = 38,

    /// <summary>
    /// The cursna
    /// </summary>
    Cursna = 40,

    /// <summary>
    /// The holy
    /// </summary>
    Holy = 42,

    /// <summary>
    /// The holy ii
    /// </summary>
    Holy_II = 44,

    /// <summary>
    /// The dia
    /// </summary>
    Dia = 46,

    /// <summary>
    /// The dia ii
    /// </summary>
    Dia_II = 48,

    /// <summary>
    /// The dia iii
    /// </summary>
    Dia_III = 50,

    /// <summary>
    /// The dia iv
    /// </summary>
    Dia_IV = 52,

    /// <summary>
    /// The dia v
    /// </summary>
    Dia_V = 54,

    /// <summary>
    /// The banish
    /// </summary>
    Banish = 56,

    /// <summary>
    /// The banish ii
    /// </summary>
    Banish_II = 58,

    /// <summary>
    /// The banish iii
    /// </summary>
    Banish_III = 60,

    /// <summary>
    /// The banish iv
    /// </summary>
    Banish_IV = 62,

    /// <summary>
    /// The banish v
    /// </summary>
    Banish_V = 64,

    /// <summary>
    /// The diaga
    /// </summary>
    Diaga = 66,

    /// <summary>
    /// The diaga ii
    /// </summary>
    Diaga_II = 68,

    /// <summary>
    /// The diaga iii
    /// </summary>
    Diaga_III = 70,

    /// <summary>
    /// The diaga iv
    /// </summary>
    Diaga_IV = 72,

    /// <summary>
    /// The diaga v
    /// </summary>
    Diaga_V = 74,

    /// <summary>
    /// The banishga
    /// </summary>
    Banishga = 76,

    /// <summary>
    /// The banishga ii
    /// </summary>
    Banishga_II = 78,

    /// <summary>
    /// The banishga iii
    /// </summary>
    Banishga_III = 80,

    /// <summary>
    /// The banishga iv
    /// </summary>
    Banishga_IV = 82,

    /// <summary>
    /// The banishga v
    /// </summary>
    Banishga_V = 84,

    /// <summary>
    /// The protect
    /// </summary>
    Protect = 86,

    /// <summary>
    /// The protect ii
    /// </summary>
    Protect_II = 88,

    /// <summary>
    /// The protect iii
    /// </summary>
    Protect_III = 90,

    /// <summary>
    /// The protect iv
    /// </summary>
    Protect_IV = 92,

    /// <summary>
    /// The protect v
    /// </summary>
    Protect_V = 94,

    /// <summary>
    /// The shell
    /// </summary>
    Shell = 96,

    /// <summary>
    /// The shell ii
    /// </summary>
    Shell_II = 98,

    /// <summary>
    /// The shell iii
    /// </summary>
    Shell_III = 100,

    /// <summary>
    /// The shell iv
    /// </summary>
    Shell_IV = 102,

    /// <summary>
    /// The shell v
    /// </summary>
    Shell_V = 104,

    /// <summary>
    /// The blink
    /// </summary>
    Blink = 106,

    /// <summary>
    /// The stoneskin
    /// </summary>
    Stoneskin = 108,

    /// <summary>
    /// The aquaveil
    /// </summary>
    Aquaveil = 110,

    /// <summary>
    /// The slow
    /// </summary>
    Slow = 112,

    /// <summary>
    /// The haste
    /// </summary>
    Haste = 114,

    /// <summary>
    /// The paralyze
    /// </summary>
    Paralyze = 116,

    /// <summary>
    /// The silence
    /// </summary>
    Silence = 118,

    /// <summary>
    /// The barfire
    /// </summary>
    Barfire = 120,

    /// <summary>
    /// The barblizzard
    /// </summary>
    Barblizzard = 122,

    /// <summary>
    /// The baraero
    /// </summary>
    Baraero = 124,

    /// <summary>
    /// The barstone
    /// </summary>
    Barstone = 126,

    /// <summary>
    /// The barthunder
    /// </summary>
    Barthunder = 128,

    /// <summary>
    /// The barwater
    /// </summary>
    Barwater = 130,

    /// <summary>
    /// The barfira
    /// </summary>
    Barfira = 132,

    /// <summary>
    /// The barblizzara
    /// </summary>
    Barblizzara = 134,

    /// <summary>
    /// The baraera
    /// </summary>
    Baraera = 136,

    /// <summary>
    /// The barstonra
    /// </summary>
    Barstonra = 138,

    /// <summary>
    /// The barthundra
    /// </summary>
    Barthundra = 140,

    /// <summary>
    /// The barwatera
    /// </summary>
    Barwatera = 142,

    /// <summary>
    /// The barsleep
    /// </summary>
    Barsleep = 144,

    /// <summary>
    /// The barpoison
    /// </summary>
    Barpoison = 146,

    /// <summary>
    /// The barparalyze
    /// </summary>
    Barparalyze = 148,

    /// <summary>
    /// The barblind
    /// </summary>
    Barblind = 150,

    /// <summary>
    /// The barsilence
    /// </summary>
    Barsilence = 152,

    /// <summary>
    /// The barpetrify
    /// </summary>
    Barpetrify = 154,

    /// <summary>
    /// The barvirus
    /// </summary>
    Barvirus = 156,

    /// <summary>
    /// The slow ii
    /// </summary>
    Slow_II = 158,

    /// <summary>
    /// The paralyze ii
    /// </summary>
    Paralyze_II = 160,

    /// <summary>
    /// The recall jugner
    /// </summary>
    Recall_Jugner = 162,

    /// <summary>
    /// The recall pashh
    /// </summary>
    Recall_Pashh = 164,

    /// <summary>
    /// The recall meriph
    /// </summary>
    Recall_Meriph = 166,

    /// <summary>
    /// The baramnesia
    /// </summary>
    Baramnesia = 168,

    /// <summary>
    /// The baramnesra
    /// </summary>
    Baramnesra = 170,

    /// <summary>
    /// The barsleepra
    /// </summary>
    Barsleepra = 172,

    /// <summary>
    /// The barpoisonra
    /// </summary>
    Barpoisonra = 174,

    /// <summary>
    /// The barparalyzra
    /// </summary>
    Barparalyzra = 176,

    /// <summary>
    /// The barblindra
    /// </summary>
    Barblindra = 178,

    /// <summary>
    /// The barsilencera
    /// </summary>
    Barsilencera = 180,

    /// <summary>
    /// The barpetra
    /// </summary>
    Barpetra = 182,

    /// <summary>
    /// The barvira
    /// </summary>
    Barvira = 184,

    /// <summary>
    /// The cura
    /// </summary>
    Cura = 186,

    /// <summary>
    /// The sacrifice
    /// </summary>
    Sacrifice = 188,

    /// <summary>
    /// The esuna
    /// </summary>
    Esuna = 190,

    /// <summary>
    /// The auspice
    /// </summary>
    Auspice = 192,

    /// <summary>
    /// The reprisal
    /// </summary>
    Reprisal = 194,

    /// <summary>
    /// The repose
    /// </summary>
    Repose = 196,

    /// <summary>
    /// The sandstorm
    /// </summary>
    Sandstorm = 198,

    /// <summary>
    /// The enfire
    /// </summary>
    Enfire = 200,

    /// <summary>
    /// The enblizzard
    /// </summary>
    Enblizzard = 202,

    /// <summary>
    /// The enaero
    /// </summary>
    Enaero = 204,

    /// <summary>
    /// The enstone
    /// </summary>
    Enstone = 206,

    /// <summary>
    /// The enthunder
    /// </summary>
    Enthunder = 208,

    /// <summary>
    /// The enwater
    /// </summary>
    Enwater = 210,

    /// <summary>
    /// The phalanx
    /// </summary>
    Phalanx = 212,

    /// <summary>
    /// The phalanx ii
    /// </summary>
    Phalanx_II = 214,

    /// <summary>
    /// The regen
    /// </summary>
    Regen = 216,

    /// <summary>
    /// The refresh
    /// </summary>
    Refresh = 218,

    /// <summary>
    /// The regen ii
    /// </summary>
    Regen_II = 220,

    /// <summary>
    /// The regen iii
    /// </summary>
    Regen_III = 222,

    /// <summary>
    /// The flash
    /// </summary>
    Flash = 224,

    /// <summary>
    /// The rainstorm
    /// </summary>
    Rainstorm = 226,

    /// <summary>
    /// The windstorm
    /// </summary>
    Windstorm = 228,

    /// <summary>
    /// The firestorm
    /// </summary>
    Firestorm = 230,

    /// <summary>
    /// The hailstorm
    /// </summary>
    Hailstorm = 232,

    /// <summary>
    /// The thunderstorm
    /// </summary>
    Thunderstorm = 234,

    /// <summary>
    /// The voidstorm
    /// </summary>
    Voidstorm = 236,

    /// <summary>
    /// The aurorastorm
    /// </summary>
    Aurorastorm = 238,

    /// <summary>
    /// The teleport yhoat
    /// </summary>
    Teleport_Yhoat = 240,

    /// <summary>
    /// The teleport altep
    /// </summary>
    Teleport_Altep = 242,

    /// <summary>
    /// The teleport holla
    /// </summary>
    Teleport_Holla = 244,

    /// <summary>
    /// The teleport dem
    /// </summary>
    Teleport_Dem = 246,

    /// <summary>
    /// The teleport mea
    /// </summary>
    Teleport_Mea = 248,

    /// <summary>
    /// The protectra
    /// </summary>
    Protectra = 250,

    /// <summary>
    /// The protectra ii
    /// </summary>
    Protectra_II = 252,

    /// <summary>
    /// The protectra iii
    /// </summary>
    Protectra_III = 254,

    /// <summary>
    /// The protectra iv
    /// </summary>
    Protectra_IV = 256,

    /// <summary>
    /// The protectra v
    /// </summary>
    Protectra_V = 258,

    /// <summary>
    /// The shellra
    /// </summary>
    Shellra = 260,

    /// <summary>
    /// The shellra ii
    /// </summary>
    Shellra_II = 262,

    /// <summary>
    /// The shellra iii
    /// </summary>
    Shellra_III = 264,

    /// <summary>
    /// The shellra iv
    /// </summary>
    Shellra_IV = 266,

    /// <summary>
    /// The shellra v
    /// </summary>
    Shellra_V = 268,

    /// <summary>
    /// The reraise
    /// </summary>
    Reraise = 270,

    /// <summary>
    /// The invisible
    /// </summary>
    Invisible = 272,

    /// <summary>
    /// The sneak
    /// </summary>
    Sneak = 274,

    /// <summary>
    /// The deodorize
    /// </summary>
    Deodorize = 276,

    /// <summary>
    /// The teleport vahzl
    /// </summary>
    Teleport_Vahzl = 278,

    /// <summary>
    /// The raise iii
    /// </summary>
    Raise_III = 280,

    /// <summary>
    /// The reraise ii
    /// </summary>
    Reraise_II = 282,

    /// <summary>
    /// The reraise iii
    /// </summary>
    Reraise_III = 284,

    /// <summary>
    /// The erase
    /// </summary>
    Erase = 286,

    /// <summary>
    /// The fire
    /// </summary>
    Fire = 288,

    /// <summary>
    /// The fire ii
    /// </summary>
    Fire_II = 290,

    /// <summary>
    /// The fire iii
    /// </summary>
    Fire_III = 292,

    /// <summary>
    /// The fire iv
    /// </summary>
    Fire_IV = 294,

    /// <summary>
    /// The fire v
    /// </summary>
    Fire_V = 296,

    /// <summary>
    /// The blizzard
    /// </summary>
    Blizzard = 298,

    /// <summary>
    /// The blizzard ii
    /// </summary>
    Blizzard_II = 300,

    /// <summary>
    /// The blizzard iii
    /// </summary>
    Blizzard_III = 302,

    /// <summary>
    /// The blizzard iv
    /// </summary>
    Blizzard_IV = 304,

    /// <summary>
    /// The blizzard v
    /// </summary>
    Blizzard_V = 306,

    /// <summary>
    /// The aero
    /// </summary>
    Aero = 308,

    /// <summary>
    /// The aero ii
    /// </summary>
    Aero_II = 310,

    /// <summary>
    /// The aero iii
    /// </summary>
    Aero_III = 312,

    /// <summary>
    /// The aero iv
    /// </summary>
    Aero_IV = 314,

    /// <summary>
    /// The aero v
    /// </summary>
    Aero_V = 316,

    /// <summary>
    /// The stone
    /// </summary>
    Stone = 318,

    /// <summary>
    /// The stone ii
    /// </summary>
    Stone_II = 320,

    /// <summary>
    /// The stone iii
    /// </summary>
    Stone_III = 322,

    /// <summary>
    /// The stone iv
    /// </summary>
    Stone_IV = 324,

    /// <summary>
    /// The stone v
    /// </summary>
    Stone_V = 326,

    /// <summary>
    /// The thunder
    /// </summary>
    Thunder = 328,

    /// <summary>
    /// The thunder ii
    /// </summary>
    Thunder_II = 330,

    /// <summary>
    /// The thunder iii
    /// </summary>
    Thunder_III = 332,

    /// <summary>
    /// The thunder iv
    /// </summary>
    Thunder_IV = 334,

    /// <summary>
    /// The thunder v
    /// </summary>
    Thunder_V = 336,

    /// <summary>
    /// The water
    /// </summary>
    Water = 338,

    /// <summary>
    /// The water ii
    /// </summary>
    Water_II = 340,

    /// <summary>
    /// The water iii
    /// </summary>
    Water_III = 342,

    /// <summary>
    /// The water iv
    /// </summary>
    Water_IV = 344,

    /// <summary>
    /// The water v
    /// </summary>
    Water_V = 346,

    /// <summary>
    /// The firaga
    /// </summary>
    Firaga = 348,

    /// <summary>
    /// The firaga ii
    /// </summary>
    Firaga_II = 350,

    /// <summary>
    /// The firaga iii
    /// </summary>
    Firaga_III = 352,

    /// <summary>
    /// The firaga iv
    /// </summary>
    Firaga_IV = 354,

    /// <summary>
    /// The firaga v
    /// </summary>
    Firaga_V = 356,

    /// <summary>
    /// The blizzaga
    /// </summary>
    Blizzaga = 358,

    /// <summary>
    /// The blizzaga ii
    /// </summary>
    Blizzaga_II = 360,

    /// <summary>
    /// The blizzaga iii
    /// </summary>
    Blizzaga_III = 362,

    /// <summary>
    /// The blizzaga iv
    /// </summary>
    Blizzaga_IV = 364,

    /// <summary>
    /// The blizzaga v
    /// </summary>
    Blizzaga_V = 366,

    /// <summary>
    /// The aeroga
    /// </summary>
    Aeroga = 368,

    /// <summary>
    /// The aeroga ii
    /// </summary>
    Aeroga_II = 370,

    /// <summary>
    /// The aeroga iii
    /// </summary>
    Aeroga_III = 372,

    /// <summary>
    /// The aeroga iv
    /// </summary>
    Aeroga_IV = 374,

    /// <summary>
    /// The aeroga v
    /// </summary>
    Aeroga_V = 376,

    /// <summary>
    /// The stonega
    /// </summary>
    Stonega = 378,

    /// <summary>
    /// The stonega ii
    /// </summary>
    Stonega_II = 380,

    /// <summary>
    /// The stonega iii
    /// </summary>
    Stonega_III = 382,

    /// <summary>
    /// The stonega iv
    /// </summary>
    Stonega_IV = 384,

    /// <summary>
    /// The stonega v
    /// </summary>
    Stonega_V = 386,

    /// <summary>
    /// The thundaga
    /// </summary>
    Thundaga = 388,

    /// <summary>
    /// The thundaga ii
    /// </summary>
    Thundaga_II = 390,

    /// <summary>
    /// The thundaga iii
    /// </summary>
    Thundaga_III = 392,

    /// <summary>
    /// The thundaga iv
    /// </summary>
    Thundaga_IV = 394,

    /// <summary>
    /// The thundaga v
    /// </summary>
    Thundaga_V = 396,

    /// <summary>
    /// The waterga
    /// </summary>
    Waterga = 398,

    /// <summary>
    /// The waterga ii
    /// </summary>
    Waterga_II = 400,

    /// <summary>
    /// The waterga iii
    /// </summary>
    Waterga_III = 402,

    /// <summary>
    /// The waterga iv
    /// </summary>
    Waterga_IV = 404,

    /// <summary>
    /// The waterga v
    /// </summary>
    Waterga_V = 406,

    /// <summary>
    /// The flare
    /// </summary>
    Flare = 408,

    /// <summary>
    /// The flare ii
    /// </summary>
    Flare_II = 410,

    /// <summary>
    /// The freeze
    /// </summary>
    Freeze = 412,

    /// <summary>
    /// The freeze ii
    /// </summary>
    Freeze_II = 414,

    /// <summary>
    /// The tornado
    /// </summary>
    Tornado = 416,

    /// <summary>
    /// The tornado ii
    /// </summary>
    Tornado_II = 418,

    /// <summary>
    /// The quake
    /// </summary>
    Quake = 420,

    /// <summary>
    /// The quake ii
    /// </summary>
    Quake_II = 422,

    /// <summary>
    /// The burst
    /// </summary>
    Burst = 424,

    /// <summary>
    /// The burst ii
    /// </summary>
    Burst_II = 426,

    /// <summary>
    /// The flood
    /// </summary>
    Flood = 428,

    /// <summary>
    /// The flood ii
    /// </summary>
    Flood_II = 430,

    /// <summary>
    /// The gravity
    /// </summary>
    Gravity = 432,

    /// <summary>
    /// The gravity ii
    /// </summary>
    Gravity_II = 434,

    /// <summary>
    /// The meteor
    /// </summary>
    Meteor = 436,

    /// <summary>
    /// The comet
    /// </summary>
    Comet = 438,

    /// <summary>
    /// The poison
    /// </summary>
    Poison = 440,

    /// <summary>
    /// The poison ii
    /// </summary>
    Poison_II = 442,

    /// <summary>
    /// The poison iii
    /// </summary>
    Poison_III = 444,

    /// <summary>
    /// The poison iv
    /// </summary>
    Poison_IV = 446,

    /// <summary>
    /// The poison v
    /// </summary>
    Poison_V = 448,

    /// <summary>
    /// The poisonga
    /// </summary>
    Poisonga = 450,

    /// <summary>
    /// The poisonga ii
    /// </summary>
    Poisonga_II = 452,

    /// <summary>
    /// The poisonga iii
    /// </summary>
    Poisonga_III = 454,

    /// <summary>
    /// The poisonga iv
    /// </summary>
    Poisonga_IV = 456,

    /// <summary>
    /// The poisonga v
    /// </summary>
    Poisonga_V = 458,

    /// <summary>
    /// The bio
    /// </summary>
    Bio = 460,

    /// <summary>
    /// The bio ii
    /// </summary>
    Bio_II = 462,

    /// <summary>
    /// The bio iii
    /// </summary>
    Bio_III = 464,

    /// <summary>
    /// The bio iv
    /// </summary>
    Bio_IV = 466,

    /// <summary>
    /// The bio v
    /// </summary>
    Bio_V = 468,

    /// <summary>
    /// The burn
    /// </summary>
    Burn = 470,

    /// <summary>
    /// The frost
    /// </summary>
    Frost = 472,

    /// <summary>
    /// The choke
    /// </summary>
    Choke = 474,

    /// <summary>
    /// The rasp
    /// </summary>
    Rasp = 476,

    /// <summary>
    /// The shock
    /// </summary>
    Shock = 478,

    /// <summary>
    /// The drown
    /// </summary>
    Drown = 480,

    /// <summary>
    /// The retrace
    /// </summary>
    Retrace = 482,

    /// <summary>
    /// The absorb acc
    /// </summary>
    Absorb_ACC = 484,

    /// <summary>
    /// The absorb attri
    /// </summary>
    Absorb_Attri = 486,

    /// <summary>
    /// The meteor ii
    /// </summary>
    Meteor_II = 488,

    /// <summary>
    /// The drain
    /// </summary>
    Drain = 490,

    /// <summary>
    /// The drain ii
    /// </summary>
    Drain_II = 492,

    /// <summary>
    /// The aspir
    /// </summary>
    Aspir = 494,

    /// <summary>
    /// The aspir ii
    /// </summary>
    Aspir_II = 496,

    /// <summary>
    /// The blaze spikes
    /// </summary>
    Blaze_Spikes = 498,

    /// <summary>
    /// The ice spikes
    /// </summary>
    Ice_Spikes = 500,

    /// <summary>
    /// The shock spikes
    /// </summary>
    Shock_Spikes = 502,

    /// <summary>
    /// The stun
    /// </summary>
    Stun = 504,

    /// <summary>
    /// The sleep
    /// </summary>
    Sleep = 506,

    /// <summary>
    /// The blind
    /// </summary>
    Blind = 508,

    /// <summary>
    /// The break
    /// </summary>
    Break = 510,

    /// <summary>
    /// The virus
    /// </summary>
    Virus = 512,

    /// <summary>
    /// The curse
    /// </summary>
    Curse = 514,

    /// <summary>
    /// The bind
    /// </summary>
    Bind = 516,

    /// <summary>
    /// The sleep ii
    /// </summary>
    Sleep_II = 518,

    /// <summary>
    /// The dispel
    /// </summary>
    Dispel = 520,

    /// <summary>
    /// The warp
    /// </summary>
    Warp = 522,

    /// <summary>
    /// The warp ii
    /// </summary>
    Warp_II = 524,

    /// <summary>
    /// The escape
    /// </summary>
    Escape = 526,

    /// <summary>
    /// The tractor
    /// </summary>
    Tractor = 528,

    /// <summary>
    /// The tractor ii
    /// </summary>
    Tractor_II = 530,

    /// <summary>
    /// The absorb string
    /// </summary>
    Absorb_STR = 532,

    /// <summary>
    /// The absorb dex
    /// </summary>
    Absorb_DEX = 534,

    /// <summary>
    /// The absorb vit
    /// </summary>
    Absorb_VIT = 536,

    /// <summary>
    /// The absorb agi
    /// </summary>
    Absorb_AGI = 538,

    /// <summary>
    /// The absorb int
    /// </summary>
    Absorb_INT = 540,

    /// <summary>
    /// The absorb MND
    /// </summary>
    Absorb_MND = 542,

    /// <summary>
    /// The absorb character
    /// </summary>
    Absorb_CHR = 544,

    /// <summary>
    /// The sleepga DRK
    /// </summary>
    Sleepga_DRK = 546,

    /// <summary>
    /// The sleepga ii DRK
    /// </summary>
    Sleepga_II_DRK = 548,

    /// <summary>
    /// The absorb tp
    /// </summary>
    Absorb_TP = 550,

    /// <summary>
    /// The blind ii DRK
    /// </summary>
    Blind_II_DRK = 552,

    /// <summary>
    /// The dread spikes
    /// </summary>
    Dread_Spikes = 554,

    /// <summary>
    /// The geohelix
    /// </summary>
    Geohelix = 556,

    /// <summary>
    /// The hydrohelix
    /// </summary>
    Hydrohelix = 558,

    /// <summary>
    /// The anemohelix
    /// </summary>
    Anemohelix = 560,

    /// <summary>
    /// The pyrohelix
    /// </summary>
    Pyrohelix = 562,

    /// <summary>
    /// The cryohelix
    /// </summary>
    Cryohelix = 564,

    /// <summary>
    /// The ionohelix
    /// </summary>
    Ionohelix = 566,

    /// <summary>
    /// The noctohelix
    /// </summary>
    Noctohelix = 568,

    /// <summary>
    /// The luminohelix
    /// </summary>
    Luminohelix = 570,

    /// <summary>
    /// The addle
    /// </summary>
    Addle = 572,

    /// <summary>
    /// The klimaform
    /// </summary>
    Klimaform = 574,

    /// <summary>
    /// The fire spirit
    /// </summary>
    Fire_Spirit = 576,

    /// <summary>
    /// The ice spirit
    /// </summary>
    Ice_Spirit = 578,

    /// <summary>
    /// The air spirit
    /// </summary>
    Air_Spirit = 580,

    /// <summary>
    /// The earth spirit
    /// </summary>
    Earth_Spirit = 582,

    /// <summary>
    /// The thunder spirit
    /// </summary>
    Thunder_Spirit = 584,

    /// <summary>
    /// The water spirit
    /// </summary>
    Water_Spirit = 586,

    /// <summary>
    /// The light spirit
    /// </summary>
    Light_Spirit = 588,

    /// <summary>
    /// The dark spirit
    /// </summary>
    Dark_Spirit = 590,

    /// <summary>
    /// The carbuncle
    /// </summary>
    Carbuncle = 592,

    /// <summary>
    /// The fenrir
    /// </summary>
    Fenrir = 594,

    /// <summary>
    /// The ifrit
    /// </summary>
    Ifrit = 596,

    /// <summary>
    /// The titan
    /// </summary>
    Titan = 598,

    /// <summary>
    /// The leviathan
    /// </summary>
    Leviathan = 600,

    /// <summary>
    /// The garuda
    /// </summary>
    Garuda = 602,

    /// <summary>
    /// The shiva
    /// </summary>
    Shiva = 604,

    /// <summary>
    /// The ramuh
    /// </summary>
    Ramuh = 606,

    /// <summary>
    /// The diabolos
    /// </summary>
    Diabolos = 608,

    /// <summary>
    /// The odin
    /// </summary>
    Odin = 610,

    /// <summary>
    /// The alexander
    /// </summary>
    Alexander = 612,

    /// <summary>
    /// The cait sith
    /// </summary>
    Cait_Sith = 614,

    /// <summary>
    /// The animus augeo
    /// </summary>
    Animus_Augeo = 616,

    /// <summary>
    /// The animus minuo
    /// </summary>
    Animus_Minuo = 618,

    /// <summary>
    /// The enlight
    /// </summary>
    Enlight = 620,

    /// <summary>
    /// The endark
    /// </summary>
    Endark = 622,

    /// <summary>
    /// The enfire ii
    /// </summary>
    Enfire_II = 624,

    /// <summary>
    /// The enblizzard ii
    /// </summary>
    Enblizzard_II = 626,

    /// <summary>
    /// The enaero ii
    /// </summary>
    Enaero_II = 628,

    /// <summary>
    /// The enstone ii
    /// </summary>
    Enstone_II = 630,

    /// <summary>
    /// The enthunder ii
    /// </summary>
    Enthunder_II = 632,

    /// <summary>
    /// The enwater ii
    /// </summary>
    Enwater_II = 634,

    /// <summary>
    /// The monomi ichi
    /// </summary>
    Monomi_Ichi = 636,

    /// <summary>
    /// The aisha ichi
    /// </summary>
    Aisha_Ichi = 638,

    /// <summary>
    /// The katon ichi
    /// </summary>
    Katon_Ichi = 640,

    /// <summary>
    /// The katon ni
    /// </summary>
    Katon_Ni = 642,

    /// <summary>
    /// The katon san
    /// </summary>
    Katon_San = 644,

    /// <summary>
    /// The hyoton ichi
    /// </summary>
    Hyoton_Ichi = 646,

    /// <summary>
    /// The hyoton ni
    /// </summary>
    Hyoton_Ni = 648,

    /// <summary>
    /// The hyoton san
    /// </summary>
    Hyoton_San = 650,

    /// <summary>
    /// The huton ichi
    /// </summary>
    Huton_Ichi = 652,

    /// <summary>
    /// The huton ni
    /// </summary>
    Huton_Ni = 654,

    /// <summary>
    /// The huton san
    /// </summary>
    Huton_San = 656,

    /// <summary>
    /// The doton ichi
    /// </summary>
    Doton_Ichi = 658,

    /// <summary>
    /// The doton ni
    /// </summary>
    Doton_Ni = 660,

    /// <summary>
    /// The doton san
    /// </summary>
    Doton_San = 662,

    /// <summary>
    /// The raiton ichi
    /// </summary>
    Raiton_Ichi = 664,

    /// <summary>
    /// The raiton ni
    /// </summary>
    Raiton_Ni = 666,

    /// <summary>
    /// The raiton san
    /// </summary>
    Raiton_San = 668,

    /// <summary>
    /// The suiton ichi
    /// </summary>
    Suiton_Ichi = 670,

    /// <summary>
    /// The suiton ni
    /// </summary>
    Suiton_Ni = 672,

    /// <summary>
    /// The suiton san
    /// </summary>
    Suiton_San = 674,

    /// <summary>
    /// The utsusemi ichi
    /// </summary>
    Utsusemi_Ichi = 676,

    /// <summary>
    /// The utsusemi ni
    /// </summary>
    Utsusemi_Ni = 678,

    /// <summary>
    /// The utsusemi san
    /// </summary>
    Utsusemi_San = 680,

    /// <summary>
    /// The jubaku ichi
    /// </summary>
    Jubaku_Ichi = 682,

    /// <summary>
    /// The jubaku ni
    /// </summary>
    Jubaku_Ni = 684,

    /// <summary>
    /// The jubaku san
    /// </summary>
    Jubaku_San = 686,

    /// <summary>
    /// The hojo ichi
    /// </summary>
    Hojo_Ichi = 688,

    /// <summary>
    /// The hojo ni
    /// </summary>
    Hojo_Ni = 690,

    /// <summary>
    /// The hojo san
    /// </summary>
    Hojo_San = 692,

    /// <summary>
    /// The kurayami ichi
    /// </summary>
    Kurayami_Ichi = 694,

    /// <summary>
    /// The kurayami ni
    /// </summary>
    Kurayami_Ni = 696,

    /// <summary>
    /// The kurayami san
    /// </summary>
    Kurayami_San = 698,

    /// <summary>
    /// The dokumori ichi
    /// </summary>
    Dokumori_Ichi = 700,

    /// <summary>
    /// The dokumori ni
    /// </summary>
    Dokumori_Ni = 702,

    /// <summary>
    /// The dokumori san
    /// </summary>
    Dokumori_San = 704,

    /// <summary>
    /// The tonko ichi
    /// </summary>
    Tonko_Ichi = 706,

    /// <summary>
    /// The tonko ni
    /// </summary>
    Tonko_Ni = 708,

    /// <summary>
    /// The tonko san
    /// </summary>
    Tonko_San = 710,

    /// <summary>
    /// The paralyga
    /// </summary>
    Paralyga = 712,

    /// <summary>
    /// The slowga
    /// </summary>
    Slowga = 714,

    /// <summary>
    /// The hastega
    /// </summary>
    Hastega = 716,

    /// <summary>
    /// The silencega
    /// </summary>
    Silencega = 718,

    /// <summary>
    /// The dispelga
    /// </summary>
    Dispelga = 720,

    /// <summary>
    /// The blindga
    /// </summary>
    Blindga = 722,

    /// <summary>
    /// The bindga
    /// </summary>
    Bindga = 724,

    /// <summary>
    /// The sleepga
    /// </summary>
    Sleepga = 726,

    /// <summary>
    /// The sleepga ii
    /// </summary>
    Sleepga_II = 728,

    /// <summary>
    /// The breakga
    /// </summary>
    Breakga = 730,

    /// <summary>
    /// The graviga
    /// </summary>
    Graviga = 732,

    /// <summary>
    /// The death
    /// </summary>
    Death = 734,

    /// <summary>
    /// The foe requiem
    /// </summary>
    Foe_Requiem = 736,

    /// <summary>
    /// The foe requiem ii
    /// </summary>
    Foe_Requiem_II = 738,

    /// <summary>
    /// The foe requiem iii
    /// </summary>
    Foe_Requiem_III = 740,

    /// <summary>
    /// The foe requiem iv
    /// </summary>
    Foe_Requiem_IV = 742,

    /// <summary>
    /// The foe requiem v
    /// </summary>
    Foe_Requiem_V = 744,

    /// <summary>
    /// The foe requiem vi
    /// </summary>
    Foe_Requiem_VI = 746,

    /// <summary>
    /// The foe requiem vii
    /// </summary>
    Foe_Requiem_VII = 748,

    /// <summary>
    /// The foe requiem viii
    /// </summary>
    Foe_Requiem_VIII = 750,

    /// <summary>
    /// The horde lullaby
    /// </summary>
    Horde_Lullaby = 752,

    /// <summary>
    /// The horde lullaby ii
    /// </summary>
    Horde_Lullaby_II = 754,

    /// <summary>
    /// The armys paeon
    /// </summary>
    Armys_Paeon = 756,

    /// <summary>
    /// The armys paeon ii
    /// </summary>
    Armys_Paeon_II = 758,

    /// <summary>
    /// The armys paeon iii
    /// </summary>
    Armys_Paeon_III = 760,

    /// <summary>
    /// The armys paeon iv
    /// </summary>
    Armys_Paeon_IV = 762,

    /// <summary>
    /// The armys paeon v
    /// </summary>
    Armys_Paeon_V = 764,

    /// <summary>
    /// The armys paeon vi
    /// </summary>
    Armys_Paeon_VI = 766,

    /// <summary>
    /// The armys paeon vii
    /// </summary>
    Armys_Paeon_VII = 768,

    /// <summary>
    /// The armys paeon viii
    /// </summary>
    Armys_Paeon_VIII = 770,

    /// <summary>
    /// The mages ballad
    /// </summary>
    Mages_Ballad = 772,

    /// <summary>
    /// The mages ballad ii
    /// </summary>
    Mages_Ballad_II = 774,

    /// <summary>
    /// The mages ballad iii
    /// </summary>
    Mages_Ballad_III = 776,

    /// <summary>
    /// The knights minne
    /// </summary>
    Knights_Minne = 778,

    /// <summary>
    /// The knights minne ii
    /// </summary>
    Knights_Minne_II = 780,

    /// <summary>
    /// The knights minne iii
    /// </summary>
    Knights_Minne_III = 782,

    /// <summary>
    /// The knights minne iv
    /// </summary>
    Knights_Minne_IV = 784,

    /// <summary>
    /// The knights minne v
    /// </summary>
    Knights_Minne_V = 786,

    /// <summary>
    /// The valor minuet
    /// </summary>
    Valor_Minuet = 788,

    /// <summary>
    /// The valor minuet ii
    /// </summary>
    Valor_Minuet_II = 790,

    /// <summary>
    /// The valor minuet iii
    /// </summary>
    Valor_Minuet_III = 792,

    /// <summary>
    /// The valor minuet iv
    /// </summary>
    Valor_Minuet_IV = 794,

    /// <summary>
    /// The valor minuet v
    /// </summary>
    Valor_Minuet_V = 796,

    /// <summary>
    /// The sword madrigal
    /// </summary>
    Sword_Madrigal = 798,

    /// <summary>
    /// The blade madrigal
    /// </summary>
    Blade_Madrigal = 800,

    /// <summary>
    /// The navs prelude
    /// </summary>
    Navs_Prelude = 802,

    /// <summary>
    /// The archers prelude
    /// </summary>
    Archers_Prelude = 804,

    /// <summary>
    /// The sheepfoe mambo
    /// </summary>
    Sheepfoe_Mambo = 806,

    /// <summary>
    /// The dragonfoe mambo
    /// </summary>
    Dragonfoe_Mambo = 808,

    /// <summary>
    /// The fowl aubade
    /// </summary>
    Fowl_Aubade = 810,

    /// <summary>
    /// The herb pastoral
    /// </summary>
    Herb_Pastoral = 812,

    /// <summary>
    /// The chocobo hum
    /// </summary>
    Chocobo_Hum = 814,

    /// <summary>
    /// The shining fantasia
    /// </summary>
    Shining_Fantasia = 816,

    /// <summary>
    /// The scops operetta
    /// </summary>
    Scops_Operetta = 818,

    /// <summary>
    /// The puppets operetta
    /// </summary>
    Puppets_Operetta = 820,

    /// <summary>
    /// The jesters operetta
    /// </summary>
    Jesters_Operetta = 822,

    /// <summary>
    /// The gold capriccio
    /// </summary>
    Gold_Capriccio = 824,

    /// <summary>
    /// The devotee serenade
    /// </summary>
    Devotee_Serenade = 826,

    /// <summary>
    /// The warding round
    /// </summary>
    Warding_Round = 828,

    /// <summary>
    /// The goblin gavotte
    /// </summary>
    Goblin_Gavotte = 830,

    /// <summary>
    /// The cactuar fugue
    /// </summary>
    Cactuar_Fugue = 832,

    /// <summary>
    /// The moogle rhapsody
    /// </summary>
    Moogle_Rhapsody = 834,

    /// <summary>
    /// The protected aria
    /// </summary>
    Protected_Aria = 836,

    /// <summary>
    /// The advancing march
    /// </summary>
    Advancing_March = 838,

    /// <summary>
    /// The victory march
    /// </summary>
    Victory_March = 840,

    /// <summary>
    /// The battlefield elegy
    /// </summary>
    Battlefield_Elegy = 842,

    /// <summary>
    /// The carnage elegy
    /// </summary>
    Carnage_Elegy = 844,

    /// <summary>
    /// The massacre elegy
    /// </summary>
    Massacre_Elegy = 846,

    /// <summary>
    /// The sinewy etude
    /// </summary>
    Sinewy_Etude = 848,

    /// <summary>
    /// The dextrous etude
    /// </summary>
    Dextrous_Etude = 850,

    /// <summary>
    /// The vivacious etude
    /// </summary>
    Vivacious_Etude = 852,

    /// <summary>
    /// The quick etude
    /// </summary>
    Quick_Etude = 854,

    /// <summary>
    /// The learned etude
    /// </summary>
    Learned_Etude = 856,

    /// <summary>
    /// The spirited etude
    /// </summary>
    Spirited_Etude = 858,

    /// <summary>
    /// The enchanting etude
    /// </summary>
    Enchanting_Etude = 860,

    /// <summary>
    /// The herculean etude
    /// </summary>
    Herculean_Etude = 862,

    /// <summary>
    /// The uncanny etude
    /// </summary>
    Uncanny_Etude = 864,

    /// <summary>
    /// The vital etude
    /// </summary>
    Vital_Etude = 866,

    /// <summary>
    /// The swift etude
    /// </summary>
    Swift_Etude = 868,

    /// <summary>
    /// The sage etude
    /// </summary>
    Sage_Etude = 870,

    /// <summary>
    /// The logical etude
    /// </summary>
    Logical_Etude = 872,

    /// <summary>
    /// The bewitching etude
    /// </summary>
    Bewitching_Etude = 874,

    /// <summary>
    /// The fire carol
    /// </summary>
    Fire_Carol = 876,

    /// <summary>
    /// The ice carol
    /// </summary>
    Ice_Carol = 878,

    /// <summary>
    /// The wind carol
    /// </summary>
    Wind_Carol = 880,

    /// <summary>
    /// The earth carol
    /// </summary>
    Earth_Carol = 882,

    /// <summary>
    /// The lightning carol
    /// </summary>
    Lightning_Carol = 884,

    /// <summary>
    /// The water carol
    /// </summary>
    Water_Carol = 886,

    /// <summary>
    /// The light carol
    /// </summary>
    Light_Carol = 888,

    /// <summary>
    /// The dark carol
    /// </summary>
    Dark_Carol = 890,

    /// <summary>
    /// The fire carol ii
    /// </summary>
    Fire_Carol_II = 892,

    /// <summary>
    /// The ice carol ii
    /// </summary>
    Ice_Carol_II = 894,

    /// <summary>
    /// The wind carol ii
    /// </summary>
    Wind_Carol_II = 896,

    /// <summary>
    /// The earth carol ii
    /// </summary>
    Earth_Carol_II = 898,

    /// <summary>
    /// The lightning carol ii
    /// </summary>
    Lightning_Carol_II = 900,

    /// <summary>
    /// The water carol ii
    /// </summary>
    Water_Carol_II = 902,

    /// <summary>
    /// The light carol ii
    /// </summary>
    Light_Carol_II = 904,

    /// <summary>
    /// The dark carol ii
    /// </summary>
    Dark_Carol_II = 906,

    /// <summary>
    /// The fire threnody
    /// </summary>
    Fire_Threnody = 908,

    /// <summary>
    /// The ice threnody
    /// </summary>
    Ice_Threnody = 910,

    /// <summary>
    /// The wind threnody
    /// </summary>
    Wind_Threnody = 912,

    /// <summary>
    /// The earth threnody
    /// </summary>
    Earth_Threnody = 914,

    /// <summary>
    /// The lightning threnody
    /// </summary>
    Lightning_Threnody = 916,

    /// <summary>
    /// The water threnody
    /// </summary>
    Water_Threnody = 918,

    /// <summary>
    /// The light threnody
    /// </summary>
    Light_Threnody = 920,

    /// <summary>
    /// The dark threnody
    /// </summary>
    Dark_Threnody = 922,

    /// <summary>
    /// The magic finale
    /// </summary>
    Magic_Finale = 924,

    /// <summary>
    /// The foe lullaby
    /// </summary>
    Foe_Lullaby = 926,

    /// <summary>
    /// The goddesss hymnus
    /// </summary>
    Goddesss_Hymnus = 928,

    /// <summary>
    /// The chocobo mazurka
    /// </summary>
    Chocobo_Mazurka = 930,

    /// <summary>
    /// The maidens virelai
    /// </summary>
    Maidens_Virelai = 932,

    /// <summary>
    /// The raptor mazurka
    /// </summary>
    Raptor_Mazurka = 934,

    /// <summary>
    /// The foe sirvente
    /// </summary>
    Foe_Sirvente = 936,

    /// <summary>
    /// The adventurers dirge
    /// </summary>
    Adventurers_Dirge = 938,

    /// <summary>
    /// The sentinels scherzo
    /// </summary>
    Sentinels_Scherzo = 940,

    /// <summary>
    /// The foe lullaby ii
    /// </summary>
    Foe_Lullaby_II = 942,

    /// <summary>
    /// The pining nocturne
    /// </summary>
    Pining_Nocturne = 944,

    /// <summary>
    /// The refresh ii
    /// </summary>
    Refresh_II = 946,

    /// <summary>
    /// The cura ii
    /// </summary>
    Cura_II = 948,

    /// <summary>
    /// The cura iii
    /// </summary>
    Cura_III = 950,

    /// <summary>
    /// The crusade
    /// </summary>
    Crusade = 952,

    /// <summary>
    /// The regen iv
    /// </summary>
    Regen_IV = 954,

    /// <summary>
    /// The embrava
    /// </summary>
    Embrava = 956,

    /// <summary>
    /// The boost string
    /// </summary>
    Boost_STR = 958,

    /// <summary>
    /// The boost dex
    /// </summary>
    Boost_DEX = 960,

    /// <summary>
    /// The boost vit
    /// </summary>
    Boost_VIT = 962,

    /// <summary>
    /// The boost agi
    /// </summary>
    Boost_AGI = 964,

    /// <summary>
    /// The boost int
    /// </summary>
    Boost_INT = 966,

    /// <summary>
    /// The boost MND
    /// </summary>
    Boost_MND = 968,

    /// <summary>
    /// The boost character
    /// </summary>
    Boost_CHR = 970,

    /// <summary>
    /// The gain string
    /// </summary>
    Gain_STR = 972,

    /// <summary>
    /// The gain dex
    /// </summary>
    Gain_DEX = 974,

    /// <summary>
    /// The gain vit
    /// </summary>
    Gain_VIT = 976,

    /// <summary>
    /// The gain agi
    /// </summary>
    Gain_AGI = 978,

    /// <summary>
    /// The gain int
    /// </summary>
    Gain_INT = 980,

    /// <summary>
    /// The gain MND
    /// </summary>
    Gain_MND = 982,

    /// <summary>
    /// The gain character
    /// </summary>
    Gain_CHR = 984,

    /// <summary>
    /// The temper
    /// </summary>
    Temper = 986,

    /// <summary>
    /// The arise
    /// </summary>
    Arise = 988,

    /// <summary>
    /// The adloquium
    /// </summary>
    Adloquium = 990,

    /// <summary>
    /// The firaja
    /// </summary>
    Firaja = 992,

    /// <summary>
    /// The blizzaja
    /// </summary>
    Blizzaja = 994,

    /// <summary>
    /// The aeroja
    /// </summary>
    Aeroja = 996,

    /// <summary>
    /// The stoneja
    /// </summary>
    Stoneja = 998,

    /// <summary>
    /// The thundaja
    /// </summary>
    Thundaja = 1000,

    /// <summary>
    /// The waterja
    /// </summary>
    Waterja = 1002,

    /// <summary>
    /// The kaustra
    /// </summary>
    Kaustra = 1004,

    /// <summary>
    /// The impact
    /// </summary>
    Impact = 1006,

    /// <summary>
    /// The regen v
    /// </summary>
    Regen_V = 1008,

    /// <summary>
    /// The gekka ichi
    /// </summary>
    Gekka_Ichi = 1010,

    /// <summary>
    /// The yain ichi
    /// </summary>
    Yain_Ichi = 1012,

    /// <summary>
    /// The myoshu ichi
    /// </summary>
    Myoshu_Ichi = 1014,

    /// <summary>
    /// The yurin ichi
    /// </summary>
    Yurin_Ichi = 1016,

    /// <summary>
    /// The kakka ichi
    /// </summary>
    Kakka_Ichi = 1018,

    /// <summary>
    /// The migawari ichi
    /// </summary>
    Migawari_Ichi = 1020,

    /// <summary>
    /// The haste ii
    /// </summary>
    Haste_II = 1022,

    /// <summary>
    /// The venom shell
    /// </summary>
    Venom_Shell = 1026,

    /// <summary>
    /// The maelstrom
    /// </summary>
    Maelstrom = 1030,

    /// <summary>
    /// The metallic body
    /// </summary>
    Metallic_Body = 1034,

    /// <summary>
    /// The screwdriver
    /// </summary>
    Screwdriver = 1038,

    /// <summary>
    /// The mp drainkiss
    /// </summary>
    MP_Drainkiss = 1042,

    /// <summary>
    /// The death ray
    /// </summary>
    Death_Ray = 1044,

    /// <summary>
    /// The sandspin
    /// </summary>
    Sandspin = 1048,

    /// <summary>
    /// The smite of rage
    /// </summary>
    Smite_of_Rage = 1054,

    /// <summary>
    /// The bludgeon
    /// </summary>
    Bludgeon = 1058,

    /// <summary>
    /// The refueling
    /// </summary>
    Refueling = 1060,

    /// <summary>
    /// The ice break
    /// </summary>
    Ice_Break = 1062,

    /// <summary>
    /// The blitzstrahl
    /// </summary>
    Blitzstrahl = 1064,

    /// <summary>
    /// The self destruct
    /// </summary>
    Self_Destruct = 1066,

    /// <summary>
    /// The mysterious light
    /// </summary>
    Mysterious_Light = 1068,

    /// <summary>
    /// The cold wave
    /// </summary>
    Cold_Wave = 1070,

    /// <summary>
    /// The poison breath
    /// </summary>
    Poison_Breath = 1072,

    /// <summary>
    /// The stinking gas
    /// </summary>
    Stinking_Gas = 1074,

    /// <summary>
    /// The memento mori
    /// </summary>
    Memento_Mori = 1076,

    /// <summary>
    /// The terror touch
    /// </summary>
    Terror_Touch = 1078,

    /// <summary>
    /// The spinal cleave
    /// </summary>
    Spinal_Cleave = 1080,

    /// <summary>
    /// The blood saber
    /// </summary>
    Blood_Saber = 1082,

    /// <summary>
    /// The digest
    /// </summary>
    Digest = 1084,

    /// <summary>
    /// The mandibular bite
    /// </summary>
    Mandibular_Bite = 1086,

    /// <summary>
    /// The cursed sphere
    /// </summary>
    Cursed_Sphere = 1088,

    /// <summary>
    /// The sickle slash
    /// </summary>
    Sickle_Slash = 1090,

    /// <summary>
    /// The cocoon
    /// </summary>
    Cocoon = 1094,

    /// <summary>
    /// The filamented hold
    /// </summary>
    Filamented_Hold = 1096,

    /// <summary>
    /// The pollen
    /// </summary>
    Pollen = 1098,

    /// <summary>
    /// The power attack
    /// </summary>
    Power_Attack = 1102,

    /// <summary>
    /// The death scissors
    /// </summary>
    Death_Scissors = 1108,

    /// <summary>
    /// The magnetite cloud
    /// </summary>
    Magnetite_Cloud = 1110,

    /// <summary>
    /// The eyes on me
    /// </summary>
    Eyes_On_Me = 1114,

    /// <summary>
    /// The frenetic rip
    /// </summary>
    Frenetic_Rip = 1120,

    /// <summary>
    /// The frightful roar
    /// </summary>
    Frightful_Roar = 1122,

    /// <summary>
    /// The hecatomb wave
    /// </summary>
    Hecatomb_Wave = 1126,

    /// <summary>
    /// The body slam
    /// </summary>
    Body_Slam = 1128,

    /// <summary>
    /// The radiant breath
    /// </summary>
    Radiant_Breath = 1130,

    /// <summary>
    /// The helldive
    /// </summary>
    Helldive = 1134,

    /// <summary>
    /// The jet stream
    /// </summary>
    Jet_Stream = 1138,

    /// <summary>
    /// The blood drain
    /// </summary>
    Blood_Drain = 1140,

    /// <summary>
    /// The sound blast
    /// </summary>
    Sound_Blast = 1144,

    /// <summary>
    /// The feather tickle
    /// </summary>
    Feather_Tickle = 1146,

    /// <summary>
    /// The feather barrier
    /// </summary>
    Feather_Barrier = 1148,

    /// <summary>
    /// The jettatura
    /// </summary>
    Jettatura = 1150,

    /// <summary>
    /// The yawn
    /// </summary>
    Yawn = 1152,

    /// <summary>
    /// The foot kick
    /// </summary>
    Foot_Kick = 1154,

    /// <summary>
    /// The wild carrot
    /// </summary>
    Wild_Carrot = 1156,

    /// <summary>
    /// The voracious trunk
    /// </summary>
    Voracious_Trunk = 1158,

    /// <summary>
    /// The healing breeze
    /// </summary>
    Healing_Breeze = 1162,

    /// <summary>
    /// The chaotic eye
    /// </summary>
    Chaotic_Eye = 1164,

    /// <summary>
    /// The sheep song
    /// </summary>
    Sheep_Song = 1168,

    /// <summary>
    /// The ram charge
    /// </summary>
    Ram_Charge = 1170,

    /// <summary>
    /// The claw cyclone
    /// </summary>
    Claw_Cyclone = 1174,

    /// <summary>
    /// The lowing
    /// </summary>
    Lowing = 1176,

    /// <summary>
    /// The dimensional death
    /// </summary>
    Dimensional_Death = 1178,

    /// <summary>
    /// The heat breath
    /// </summary>
    Heat_Breath = 1182,

    /// <summary>
    /// The blank gaze
    /// </summary>
    Blank_Gaze = 1184,

    /// <summary>
    /// The magic fruit
    /// </summary>
    Magic_Fruit = 1186,

    /// <summary>
    /// The uppercut
    /// </summary>
    Uppercut = 1188,

    /// <summary>
    /// The thousand needles
    /// </summary>
    Thousand_Needles = 1190,

    /// <summary>
    /// The pinecone bomb
    /// </summary>
    Pinecone_Bomb = 1192,

    /// <summary>
    /// The sprout smack
    /// </summary>
    Sprout_Smack = 1194,

    /// <summary>
    /// The soporific
    /// </summary>
    Soporific = 1196,

    /// <summary>
    /// The queasyshroom
    /// </summary>
    Queasyshroom = 1198,

    /// <summary>
    /// The wild oats
    /// </summary>
    Wild_Oats = 1206,

    /// <summary>
    /// The bad breath
    /// </summary>
    Bad_Breath = 1208,

    /// <summary>
    /// The geist wall
    /// </summary>
    Geist_Wall = 1210,

    /// <summary>
    /// The awful eye
    /// </summary>
    Awful_Eye = 1212,

    /// <summary>
    /// The frost breath
    /// </summary>
    Frost_Breath = 1216,

    /// <summary>
    /// The infrasonics
    /// </summary>
    Infrasonics = 1220,

    /// <summary>
    /// The disseverment
    /// </summary>
    Disseverment = 1222,

    /// <summary>
    /// The actinic burst
    /// </summary>
    Actinic_Burst = 1224,

    /// <summary>
    /// The reactor cool
    /// </summary>
    Reactor_Cool = 1226,

    /// <summary>
    /// The saline coat
    /// </summary>
    Saline_Coat = 1228,

    /// <summary>
    /// The plasma charge
    /// </summary>
    Plasma_Charge = 1230,

    /// <summary>
    /// The temporal shift
    /// </summary>
    Temporal_Shift = 1232,

    /// <summary>
    /// The vertical cleave
    /// </summary>
    Vertical_Cleave = 1234,

    /// <summary>
    /// The blastbomb
    /// </summary>
    Blastbomb = 1236,

    /// <summary>
    /// The battle dance
    /// </summary>
    Battle_Dance = 1240,

    /// <summary>
    /// The sandspray
    /// </summary>
    Sandspray = 1242,

    /// <summary>
    /// The grand slam
    /// </summary>
    Grand_Slam = 1244,

    /// <summary>
    /// The head butt
    /// </summary>
    Head_Butt = 1246,

    /// <summary>
    /// The bomb toss
    /// </summary>
    Bomb_Toss = 1252,

    /// <summary>
    /// The frypan
    /// </summary>
    Frypan = 1256,

    /// <summary>
    /// The flying hip press
    /// </summary>
    Flying_Hip_Press = 1258,

    /// <summary>
    /// The hydro shot
    /// </summary>
    Hydro_Shot = 1262,

    /// <summary>
    /// The diamondhide
    /// </summary>
    Diamondhide = 1264,

    /// <summary>
    /// The enervation
    /// </summary>
    Enervation = 1266,

    /// <summary>
    /// The light of penance
    /// </summary>
    Light_of_Penance = 1268,

    /// <summary>
    /// The warm up
    /// </summary>
    Warm_Up = 1272,

    /// <summary>
    /// The firespit
    /// </summary>
    Firespit = 1274,

    /// <summary>
    /// The feather storm
    /// </summary>
    Feather_Storm = 1276,

    /// <summary>
    /// The tail slap
    /// </summary>
    Tail_Slap = 1280,

    /// <summary>
    /// The hysteric barrage
    /// </summary>
    Hysteric_Barrage = 1282,

    /// <summary>
    /// The amplification
    /// </summary>
    Amplification = 1284,

    /// <summary>
    /// The cannonball
    /// </summary>
    Cannonball = 1286,

    /// <summary>
    /// The mind blast
    /// </summary>
    Mind_Blast = 1288,

    /// <summary>
    /// The exuviation
    /// </summary>
    Exuviation = 1290,

    /// <summary>
    /// The magic hammer
    /// </summary>
    Magic_Hammer = 1292,

    /// <summary>
    /// The zephyr mantle
    /// </summary>
    Zephyr_Mantle = 1294,

    /// <summary>
    /// The regurgitation
    /// </summary>
    Regurgitation = 1296,

    /// <summary>
    /// The seedspray
    /// </summary>
    Seedspray = 1300,

    /// <summary>
    /// The corrosive ooze
    /// </summary>
    Corrosive_Ooze = 1302,

    /// <summary>
    /// The spiral spin
    /// </summary>
    Spiral_Spin = 1304,

    /// <summary>
    /// The asuran claws
    /// </summary>
    Asuran_Claws = 1306,

    /// <summary>
    /// The sub zero smash
    /// </summary>
    Sub_zero_Smash = 1308,

    /// <summary>
    /// The triumphant roar
    /// </summary>
    Triumphant_Roar = 1310,

    /// <summary>
    /// The acrid stream
    /// </summary>
    Acrid_Stream = 1312,

    /// <summary>
    /// The blazing bound
    /// </summary>
    Blazing_Bound = 1314,

    /// <summary>
    /// The plenilune embrace
    /// </summary>
    Plenilune_Embrace = 1316,

    /// <summary>
    /// The demoralizing roar
    /// </summary>
    Demoralizing_Roar = 1318,

    /// <summary>
    /// The cimicine discharge
    /// </summary>
    Cimicine_Discharge = 1320,

    /// <summary>
    /// The animating wail
    /// </summary>
    Animating_Wail = 1322,

    /// <summary>
    /// The battery charge
    /// </summary>
    Battery_Charge = 1324,

    /// <summary>
    /// The leafstorm
    /// </summary>
    Leafstorm = 1326,

    /// <summary>
    /// The regeneration
    /// </summary>
    Regeneration = 1328,

    /// <summary>
    /// The final sting
    /// </summary>
    Final_Sting = 1330,

    /// <summary>
    /// The goblin rush
    /// </summary>
    Goblin_Rush = 1332,

    /// <summary>
    /// The vanity dive
    /// </summary>
    Vanity_Dive = 1334,

    /// <summary>
    /// The magic barrier
    /// </summary>
    Magic_Barrier = 1336,

    /// <summary>
    /// The whirl of rage
    /// </summary>
    Whirl_of_Rage = 1338,

    /// <summary>
    /// The benthic typhoon
    /// </summary>
    Benthic_Typhoon = 1340,

    /// <summary>
    /// The auroral drape
    /// </summary>
    Auroral_Drape = 1342,

    /// <summary>
    /// The osmosis
    /// </summary>
    Osmosis = 1344,

    /// <summary>
    /// The quad continuum
    /// </summary>
    Quad_Continuum = 1346,

    /// <summary>
    /// The fantod
    /// </summary>
    Fantod = 1348,

    /// <summary>
    /// The thermal pulse
    /// </summary>
    Thermal_Pulse = 1350,

    /// <summary>
    /// The empty thrash
    /// </summary>
    Empty_Thrash = 1354,

    /// <summary>
    /// The dream flower
    /// </summary>
    Dream_Flower = 1356,

    /// <summary>
    /// The occultation
    /// </summary>
    Occultation = 1358,

    /// <summary>
    /// The charged whisker
    /// </summary>
    Charged_Whisker = 1360,

    /// <summary>
    /// The winds promyvion
    /// </summary>
    Winds_Promyvion = 1362,

    /// <summary>
    /// The delta thrust
    /// </summary>
    Delta_Thrust = 1364,

    /// <summary>
    /// The everyones grudge
    /// </summary>
    Everyones_Grudge = 1366,

    /// <summary>
    /// The reaving wind
    /// </summary>
    Reaving_Wind = 1368,

    /// <summary>
    /// The barrier tusk
    /// </summary>
    Barrier_Tusk = 1370,

    /// <summary>
    /// The mortal ray
    /// </summary>
    Mortal_Ray = 1372,

    /// <summary>
    /// The water bomb
    /// </summary>
    Water_Bomb = 1374,

    /// <summary>
    /// The heavy strike
    /// </summary>
    Heavy_Strike = 1376,

    /// <summary>
    /// The dark orb
    /// </summary>
    Dark_Orb = 1378,

    /// <summary>
    /// The white wind
    /// </summary>
    White_Wind = 1380,

    /// <summary>
    /// The sudden lunge
    /// </summary>
    Sudden_Lunge = 1384,

    /// <summary>
    /// The quadrastrike
    /// </summary>
    Quadrastrike = 1386,

    /// <summary>
    /// The vapor spray
    /// </summary>
    Vapor_Spray = 1388,

    /// <summary>
    /// The thunder breath
    /// </summary>
    Thunder_Breath = 1390,

    /// <summary>
    /// The o counterstance
    /// </summary>
    O_Counterstance = 1392,

    /// <summary>
    /// The amorphic spikes
    /// </summary>
    Amorphic_Spikes = 1394,

    /// <summary>
    /// The wind breath
    /// </summary>
    Wind_Breath = 1396,

    /// <summary>
    /// The barbed crescent
    /// </summary>
    Barbed_Crescent = 1398,

    /// <summary>
    /// The nat meditation
    /// </summary>
    Nat_Meditation = 1400,

    /// <summary>
    /// The tem upheaval
    /// </summary>
    Tem_Upheaval = 1402,

    /// <summary>
    /// The rending deluge
    /// </summary>
    Rending_Deluge = 1404,

    /// <summary>
    /// The embalming earth
    /// </summary>
    Embalming_Earth = 1406,

    /// <summary>
    /// The paralyzing triad
    /// </summary>
    Paralyzing_Triad = 1408,

    /// <summary>
    /// The foul waters
    /// </summary>
    Foul_Waters = 1410,

    /// <summary>
    /// The glutinous dart
    /// </summary>
    Glutinous_Dart = 1412,

    /// <summary>
    /// The retinal glare
    /// </summary>
    Retinal_Glare = 1414,

    /// <summary>
    /// The subduction
    /// </summary>
    Subduction = 1416,

    /// <summary>
    /// The thrashing assault
    /// </summary>
    Thrashing_Assault = 1418,

    /// <summary>
    /// The erratic flutter
    /// </summary>
    Erratic_Flutter = 1420,

    /// <summary>
    /// The thunderbolt
    /// </summary>
    Thunderbolt = 1472,

    /// <summary>
    /// The harden shell
    /// </summary>
    Harden_Shell = 1474,

    /// <summary>
    /// The absolute terror
    /// </summary>
    Absolute_Terror = 1476,

    /// <summary>
    /// The gates of hades
    /// </summary>
    Gates_of_Hades = 1478,

    /// <summary>
    /// The tourbillion
    /// </summary>
    Tourbillion = 1480,

    /// <summary>
    /// The pyric bulwark
    /// </summary>
    Pyric_Bulwark = 1482,

    /// <summary>
    /// The bilgestorm
    /// </summary>
    Bilgestorm = 1484,

    /// <summary>
    /// The bloodrake
    /// </summary>
    Bloodrake = 1486,

    /// <summary>
    /// The droning whirlwind
    /// </summary>
    Droning_Whirlwind = 1488,

    /// <summary>
    /// The carcharian verve
    /// </summary>
    Carcharian_Verve = 1490,

    /// <summary>
    /// The blistering roar
    /// </summary>
    Blistering_Roar = 1492,

    /// <summary>
    /// The indi regen
    /// </summary>
    Indi_Regen = 1536,

    /// <summary>
    /// The indi poison
    /// </summary>
    Indi_Poison = 1538,

    /// <summary>
    /// The indi refresh
    /// </summary>
    Indi_Refresh = 1540,

    /// <summary>
    /// The indi haste
    /// </summary>
    Indi_Haste = 1542,

    /// <summary>
    /// The indi string
    /// </summary>
    Indi_STR = 1544,

    /// <summary>
    /// The indi dex
    /// </summary>
    Indi_DEX = 1546,

    /// <summary>
    /// The indi vit
    /// </summary>
    Indi_VIT = 1548,

    /// <summary>
    /// The indi agi
    /// </summary>
    Indi_AGI = 1550,

    /// <summary>
    /// The indi int
    /// </summary>
    Indi_INT = 1552,

    /// <summary>
    /// The indi MND
    /// </summary>
    Indi_MND = 1554,

    /// <summary>
    /// The indi character
    /// </summary>
    Indi_CHR = 1556,

    /// <summary>
    /// The indi fury
    /// </summary>
    Indi_Fury = 1558,

    /// <summary>
    /// The indi barrier
    /// </summary>
    Indi_Barrier = 1560,

    /// <summary>
    /// The indi acumen
    /// </summary>
    Indi_Acumen = 1562,

    /// <summary>
    /// The indi fend
    /// </summary>
    Indi_Fend = 1564,

    /// <summary>
    /// The indi precision
    /// </summary>
    Indi_Precision = 1566,

    /// <summary>
    /// The indi voidance
    /// </summary>
    Indi_Voidance = 1568,

    /// <summary>
    /// The indi focus
    /// </summary>
    Indi_Focus = 1570,

    /// <summary>
    /// The indi attunement
    /// </summary>
    Indi_Attunement = 1572,

    /// <summary>
    /// The indi wilt
    /// </summary>
    Indi_Wilt = 1574,

    /// <summary>
    /// The indi frailty
    /// </summary>
    Indi_Frailty = 1576,

    /// <summary>
    /// The indi fade
    /// </summary>
    Indi_Fade = 1578,

    /// <summary>
    /// The indi malaise
    /// </summary>
    Indi_Malaise = 1580,

    /// <summary>
    /// The indi slip
    /// </summary>
    Indi_Slip = 1582,

    /// <summary>
    /// The indi torpor
    /// </summary>
    Indi_Torpor = 1584,

    /// <summary>
    /// The indi vex
    /// </summary>
    Indi_Vex = 1586,

    /// <summary>
    /// The indi languor
    /// </summary>
    Indi_Languor = 1588,

    /// <summary>
    /// The indi slow
    /// </summary>
    Indi_Slow = 1590,

    /// <summary>
    /// The indi paralysis
    /// </summary>
    Indi_Paralysis = 1592,

    /// <summary>
    /// The indi gravity
    /// </summary>
    Indi_Gravity = 1594,

    /// <summary>
    /// The geo regen
    /// </summary>
    Geo_Regen = 1596,

    /// <summary>
    /// The geo poison
    /// </summary>
    Geo_Poison = 1598,

    /// <summary>
    /// The geo refresh
    /// </summary>
    Geo_Refresh = 1600,

    /// <summary>
    /// The geo haste
    /// </summary>
    Geo_Haste = 1602,

    /// <summary>
    /// The geo string
    /// </summary>
    Geo_STR = 1604,

    /// <summary>
    /// The geo dex
    /// </summary>
    Geo_DEX = 1606,

    /// <summary>
    /// The geo vit
    /// </summary>
    Geo_VIT = 1608,

    /// <summary>
    /// The geo agi
    /// </summary>
    Geo_AGI = 1610,

    /// <summary>
    /// The geo int
    /// </summary>
    Geo_INT = 1612,

    /// <summary>
    /// The geo MND
    /// </summary>
    Geo_MND = 1614,

    /// <summary>
    /// The geo character
    /// </summary>
    Geo_CHR = 1616,

    /// <summary>
    /// The geo fury
    /// </summary>
    Geo_Fury = 1618,

    /// <summary>
    /// The geo barrier
    /// </summary>
    Geo_Barrier = 1620,

    /// <summary>
    /// The geo acumen
    /// </summary>
    Geo_Acumen = 1622,

    /// <summary>
    /// The geo fend
    /// </summary>
    Geo_Fend = 1624,

    /// <summary>
    /// The geo precision
    /// </summary>
    Geo_Precision = 1626,

    /// <summary>
    /// The geo voidance
    /// </summary>
    Geo_Voidance = 1628,

    /// <summary>
    /// The geo focus
    /// </summary>
    Geo_Focus = 1630,

    /// <summary>
    /// The geo attunement
    /// </summary>
    Geo_Attunement = 1632,

    /// <summary>
    /// The geo wilt
    /// </summary>
    Geo_Wilt = 1634,

    /// <summary>
    /// The geo frailty
    /// </summary>
    Geo_Frailty = 1636,

    /// <summary>
    /// The geo fade
    /// </summary>
    Geo_Fade = 1638,

    /// <summary>
    /// The geo malaise
    /// </summary>
    Geo_Malaise = 1640,

    /// <summary>
    /// The geo slip
    /// </summary>
    Geo_Slip = 1642,

    /// <summary>
    /// The geo torpor
    /// </summary>
    Geo_Torpor = 1644,

    /// <summary>
    /// The geo vex
    /// </summary>
    Geo_Vex = 1646,

    /// <summary>
    /// The geo languor
    /// </summary>
    Geo_Languor = 1648,

    /// <summary>
    /// The geo slow
    /// </summary>
    Geo_Slow = 1650,

    /// <summary>
    /// The geo paralysis
    /// </summary>
    Geo_Paralysis = 1652,

    /// <summary>
    /// The geo gravity
    /// </summary>
    Geo_Gravity = 1654,

    /// <summary>
    /// The fira
    /// </summary>
    Fira = 1656,

    /// <summary>
    /// The fira ii
    /// </summary>
    Fira_II = 1658,

    /// <summary>
    /// The blizzara
    /// </summary>
    Blizzara = 1660,

    /// <summary>
    /// The blizzara ii
    /// </summary>
    Blizzara_II = 1662,

    /// <summary>
    /// The aerora
    /// </summary>
    Aerora = 1664,

    /// <summary>
    /// The aerora ii
    /// </summary>
    Aerora_II = 1666,

    /// <summary>
    /// The stonera
    /// </summary>
    Stonera = 1668,

    /// <summary>
    /// The stonera ii
    /// </summary>
    Stonera_II = 1670,

    /// <summary>
    /// The thundara
    /// </summary>
    Thundara = 1672,

    /// <summary>
    /// The thundara ii
    /// </summary>
    Thundara_II = 1674,

    /// <summary>
    /// The watera
    /// </summary>
    Watera = 1676,

    /// <summary>
    /// The watera ii
    /// </summary>
    Watera_II = 1678,

    /// <summary>
    /// The foil
    /// </summary>
    Foil = 1680,

    /// <summary>
    /// The distract
    /// </summary>
    Distract = 1682,

    /// <summary>
    /// The distract ii
    /// </summary>
    Distract_II = 1684,

    /// <summary>
    /// The frazzle
    /// </summary>
    Frazzle = 1686,

    /// <summary>
    /// The frazzle ii
    /// </summary>
    Frazzle_II = 1688,

    /// <summary>
    /// The flurry
    /// </summary>
    Flurry = 1690,

    /// <summary>
    /// The flurry ii
    /// </summary>
    Flurry_II = 1692,

    /// <summary>
    /// The shantotto
    /// </summary>
    Shantotto = 1792,

    /// <summary>
    /// The naji
    /// </summary>
    Naji = 1794,

    /// <summary>
    /// The kupipi
    /// </summary>
    Kupipi = 1796,

    /// <summary>
    /// The excenmille
    /// </summary>
    Excenmille = 1798,

    /// <summary>
    /// The ayame
    /// </summary>
    Ayame = 1800,

    /// <summary>
    /// The nanaa mihgo
    /// </summary>
    Nanaa_Mihgo = 1802,

    /// <summary>
    /// The curilla
    /// </summary>
    Curilla = 1804,

    /// <summary>
    /// The volker
    /// </summary>
    Volker = 1806,

    /// <summary>
    /// The ajido marujido
    /// </summary>
    Ajido_Marujido = 1808,

    /// <summary>
    /// The trion
    /// </summary>
    Trion = 1810,

    /// <summary>
    /// The zeid
    /// </summary>
    Zeid = 1812,

    /// <summary>
    /// The lion
    /// </summary>
    Lion = 1814,

    /// <summary>
    /// The tenzen
    /// </summary>
    Tenzen = 1816,

    /// <summary>
    /// The mihli aliapoh
    /// </summary>
    Mihli_Aliapoh = 1818,

    /// <summary>
    /// The valaineral
    /// </summary>
    Valaineral = 1820,

    /// <summary>
    /// The joachim
    /// </summary>
    Joachim = 1822,

    /// <summary>
    /// The naja salaheem
    /// </summary>
    Naja_Salaheem = 1824,

    /// <summary>
    /// The prishe
    /// </summary>
    Prishe = 1826,

    /// <summary>
    /// The ulmia
    /// </summary>
    Ulmia = 1828,

    /// <summary>
    /// The cherukiki
    /// </summary>
    Cherukiki = 1832,

    /// <summary>
    /// The iron eater
    /// </summary>
    Iron_Eater = 1834,

    /// <summary>
    /// The gessho
    /// </summary>
    Gessho = 1836,

    /// <summary>
    /// The gadalar
    /// </summary>
    Gadalar = 1838,

    /// <summary>
    /// The rainemard
    /// </summary>
    Rainemard = 1840,

    /// <summary>
    /// The ingrid
    /// </summary>
    Ingrid = 1842,

    /// <summary>
    /// The lehko habhoka
    /// </summary>
    Lehko_Habhoka = 1844,

    /// <summary>
    /// The nashmeira
    /// </summary>
    Nashmeira = 1846,

    /// <summary>
    /// The zazarg
    /// </summary>
    Zazarg = 1848,

    /// <summary>
    /// The ovjang
    /// </summary>
    Ovjang = 1850,

    /// <summary>
    /// The mnejing
    /// </summary>
    Mnejing = 1852,

    /// <summary>
    /// The sakura
    /// </summary>
    Sakura = 1854,

    /// <summary>
    /// The luzaf
    /// </summary>
    Luzaf = 1856,

    /// <summary>
    /// The najelith
    /// </summary>
    Najelith = 1858,

    /// <summary>
    /// The aldo
    /// </summary>
    Aldo = 1860,

    /// <summary>
    /// The moogle
    /// </summary>
    Moogle = 1862,

    /// <summary>
    /// The fablinix
    /// </summary>
    Fablinix = 1864,

    /// <summary>
    /// The maat
    /// </summary>
    Maat = 1866,

    /// <summary>
    /// The d shantotto
    /// </summary>
    D_Shantotto = 1868,

    /// <summary>
    /// The star sibyl
    /// </summary>
    Star_Sibyl = 1870,

    /// <summary>
    /// The elivira
    /// </summary>
    Elivira = 1882,

    /// <summary>
    /// The noillurie
    /// </summary>
    Noillurie = 1884,

    /// <summary>
    /// The lhu mhakaracca
    /// </summary>
    Lhu_Mhakaracca = 1886,

    /// <summary>
    /// The ferreous coffin
    /// </summary>
    Ferreous_Coffin = 1888,

    /// <summary>
    /// The mumor
    /// </summary>
    Mumor = 1892,

    /// <summary>
    /// The uka totlihn
    /// </summary>
    Uka_Totlihn = 1894,

    /// <summary>
    /// The klara
    /// </summary>
    Klara = 1896,

    /// <summary>
    /// The romaa mihgo
    /// </summary>
    Romaa_Mihgo = 1898,

    /// <summary>
    /// The excenmille s
    /// </summary>
    Excenmille__S = 2008,

    /// <summary>
    /// The reraise iv
    /// </summary>
    Reraise_IV = 2009,

    /// <summary>
    /// The refresh iii
    /// </summary>
    Refresh_III = 2010,

    /// <summary>
    /// The curing waltz
    /// </summary>
    Curing_Waltz = 2011,           //just added these to make actions easier to sort out

    /// <summary>
    /// The curing waltz ii
    /// </summary>
    Curing_Waltz_II = 2012,        //just added these to make actions easier to sort out

    /// <summary>
    /// The curing waltz iii
    /// </summary>
    Curing_Waltz_III = 2013,        //just added these to make actions easier to sort out

    /// <summary>
    /// The curing waltz iv
    /// </summary>
    Curing_Waltz_IV = 2014,         //just added these to make actions easier to sort out

    /// <summary>
    /// The curing waltz v
    /// </summary>
    Curing_Waltz_V = 2015,         //just added these to make actions easier to sort out

    /// <summary>
    /// The en dark ii
    /// </summary>
    EnDark_II = 2016,

    /// <summary>
    /// The en light ii
    /// </summary>
    EnLight_II = 2017,

    /// <summary>
    /// The temper ii
    /// </summary>
    Temper_II = 2018
}

/// <summary>
/// Enum DnC
/// </summary>
public enum DnC : short
{
    /// <summary>
    /// The curing waltz
    /// </summary>
    Curing_Waltz = 2011,           //just added these to make actions easier to sort out

    /// <summary>
    /// The curing waltz ii
    /// </summary>
    Curing_Waltz_II = 2012,        //just added these to make actions easier to sort out

    /// <summary>
    /// The curing waltz iii
    /// </summary>
    Curing_Waltz_III = 2013,        //just added these to make actions easier to sort out

    /// <summary>
    /// The curing waltz iv
    /// </summary>
    Curing_Waltz_IV = 2014,         //just added these to make actions easier to sort out

    /// <summary>
    /// The curing waltz v
    /// </summary>
    Curing_Waltz_V = 2015         //just added these to make actions easier to sort out
}

/// <summary>
/// Player Statuses
/// </summary>
public enum Status : byte
{
    /// <summary>
    /// The standing
    /// </summary>
    Standing = 0,

    /// <summary>
    /// The fighting
    /// </summary>
    Fighting = 1,

    /// <summary>
    /// The dead1
    /// </summary>
    Dead1 = 2,

    /// <summary>
    /// The dead2
    /// </summary>
    Dead2 = 3,

    /// <summary>
    /// The event
    /// </summary>
    Event = 4,

    /// <summary>
    /// The chocobo
    /// </summary>
    Chocobo = 5,

    /// <summary>
    /// The healing
    /// </summary>
    Healing = 33,

    /// <summary>
    /// The synthing
    /// </summary>
    Synthing = 44,

    /// <summary>
    /// The sitting
    /// </summary>
    Sitting = 47,

    /// <summary>
    /// The fishing
    /// </summary>
    Fishing = 56,

    /// <summary>
    /// The fish bite
    /// </summary>
    FishBite = 57,

    /// <summary>
    /// The obtained
    /// </summary>
    Obtained = 58,

    /// <summary>
    /// The rod break
    /// </summary>
    RodBreak = 59,

    /// <summary>
    /// The line break
    /// </summary>
    LineBreak = 60,

    /// <summary>
    /// The catch monster
    /// </summary>
    CatchMonster = 61,

    /// <summary>
    /// The lost catch
    /// </summary>
    LostCatch = 62,

    /// <summary>
    /// The unknown
    /// </summary>
    Unknown
}

/// <summary>
/// Status effects
/// </summary>
public enum StatusEffect : short
{
    /// <summary>
    /// The unknown
    /// </summary>
    Unknown = -1,

    /// <summary>
    /// The ko
    /// </summary>
    KO = 0,

    /// <summary>
    /// The weakness
    /// </summary>
    Weakness = 1,

    /// <summary>
    /// The sleep
    /// </summary>
    Sleep = 2,

    /// <summary>
    /// The poison
    /// </summary>
    Poison = 3,

    /// <summary>
    /// The paralysis
    /// </summary>
    Paralysis = 4,

    /// <summary>
    /// The blindness
    /// </summary>
    Blindness = 5,

    /// <summary>
    /// The silence
    /// </summary>
    Silence = 6,

    /// <summary>
    /// The petrification
    /// </summary>
    Petrification = 7,

    /// <summary>
    /// The disease
    /// </summary>
    Disease = 8,

    /// <summary>
    /// The curse
    /// </summary>
    Curse = 9,

    /// <summary>
    /// The stun
    /// </summary>
    Stun = 10,

    /// <summary>
    /// The bind
    /// </summary>
    Bind = 11,

    /// <summary>
    /// The weight
    /// </summary>
    Weight = 12,

    /// <summary>
    /// The slow
    /// </summary>
    Slow = 13,

    /// <summary>
    /// The charm1
    /// </summary>
    Charm1 = 14,

    /// <summary>
    /// The doom
    /// </summary>
    Doom = 15,

    /// <summary>
    /// The amnesia
    /// </summary>
    Amnesia = 16,

    /// <summary>
    /// The charm2
    /// </summary>
    Charm2 = 17,

    /// <summary>
    /// The gradual petrification
    /// </summary>
    Gradual_Petrification = 18,

    /// <summary>
    /// The sleep2
    /// </summary>
    Sleep2 = 19,

    /// <summary>
    /// The curse2
    /// </summary>
    Curse2 = 20,

    /// <summary>
    /// The addle
    /// </summary>
    Addle = 21,

    /// <summary>
    /// The terror
    /// </summary>
    Terror = 28,

    /// <summary>
    /// The mute
    /// </summary>
    Mute = 29,

    /// <summary>
    /// The bane
    /// </summary>
    Bane = 30,

    /// <summary>
    /// The plague
    /// </summary>
    Plague = 31,

    /// <summary>
    /// The flee
    /// </summary>
    Flee = 32,

    /// <summary>
    /// The haste
    /// </summary>
    Haste = 33,

    /// <summary>
    /// The blaze spikes
    /// </summary>
    Blaze_Spikes = 34,

    /// <summary>
    /// The ice spikes
    /// </summary>
    Ice_Spikes = 35,

    /// <summary>
    /// The blink
    /// </summary>
    Blink = 36,

    /// <summary>
    /// The stoneskin
    /// </summary>
    Stoneskin = 37,

    /// <summary>
    /// The shock spikes
    /// </summary>
    Shock_Spikes = 38,

    /// <summary>
    /// The aquaveil
    /// </summary>
    Aquaveil = 39,

    /// <summary>
    /// The protect
    /// </summary>
    Protect = 40,

    /// <summary>
    /// The shell
    /// </summary>
    Shell = 41,

    /// <summary>
    /// The regen
    /// </summary>
    Regen = 42,

    /// <summary>
    /// The refresh
    /// </summary>
    Refresh = 43,

    /// <summary>
    /// The mighty strikes
    /// </summary>
    Mighty_Strikes = 44,

    /// <summary>
    /// The boost
    /// </summary>
    Boost = 45,

    /// <summary>
    /// The hundred fists
    /// </summary>
    Hundred_Fists = 46,

    /// <summary>
    /// The manafont
    /// </summary>
    Manafont = 47,

    /// <summary>
    /// The chainspell
    /// </summary>
    Chainspell = 48,

    /// <summary>
    /// The perfect dodge
    /// </summary>
    Perfect_Dodge = 49,

    /// <summary>
    /// The invincible
    /// </summary>
    Invincible = 50,

    /// <summary>
    /// The blood weapon
    /// </summary>
    Blood_Weapon = 51,

    /// <summary>
    /// The soul voice
    /// </summary>
    Soul_Voice = 52,

    /// <summary>
    /// The eagle eye shot
    /// </summary>
    Eagle_Eye_Shot = 53,

    /// <summary>
    /// The meikyo shisui
    /// </summary>
    Meikyo_Shisui = 54,

    /// <summary>
    /// The astral flow
    /// </summary>
    Astral_Flow = 55,

    /// <summary>
    /// The berserk
    /// </summary>
    Berserk = 56,

    /// <summary>
    /// The defender
    /// </summary>
    Defender = 57,

    /// <summary>
    /// The aggressor
    /// </summary>
    Aggressor = 58,

    /// <summary>
    /// The focus
    /// </summary>
    Focus = 59,

    /// <summary>
    /// The dodge
    /// </summary>
    Dodge = 60,

    /// <summary>
    /// The counterstance
    /// </summary>
    Counterstance = 61,

    /// <summary>
    /// The sentinel
    /// </summary>
    Sentinel = 62,

    /// <summary>
    /// The souleater
    /// </summary>
    Souleater = 63,

    /// <summary>
    /// The last resort
    /// </summary>
    Last_Resort = 64,

    /// <summary>
    /// The sneak attack
    /// </summary>
    Sneak_Attack = 65,

    //Copy_Image = 66,
    /// <summary>
    /// The utsusemi 1 shadow left
    /// </summary>
    Utsusemi_1_Shadow_Left = 66,

    /// <summary>
    /// The third eye
    /// </summary>
    Third_Eye = 67,

    /// <summary>
    /// The warcry
    /// </summary>
    Warcry = 68,

    /// <summary>
    /// The invisible
    /// </summary>
    Invisible = 69,

    /// <summary>
    /// The deodorize
    /// </summary>
    Deodorize = 70,

    /// <summary>
    /// The sneak
    /// </summary>
    Sneak = 71,

    /// <summary>
    /// The sharpshot
    /// </summary>
    Sharpshot = 72,

    /// <summary>
    /// The barrage
    /// </summary>
    Barrage = 73,

    /// <summary>
    /// The holy circle
    /// </summary>
    Holy_Circle = 74,

    /// <summary>
    /// The arcane circle
    /// </summary>
    Arcane_Circle = 75,

    /// <summary>
    /// The hide
    /// </summary>
    Hide = 76,

    /// <summary>
    /// The camouflage
    /// </summary>
    Camouflage = 77,

    /// <summary>
    /// The divine seal
    /// </summary>
    Divine_Seal = 78,

    /// <summary>
    /// The elemental seal
    /// </summary>
    Elemental_Seal = 79,

    /// <summary>
    /// The string boost1
    /// </summary>
    STR_Boost1 = 80,

    /// <summary>
    /// The dex boost1
    /// </summary>
    DEX_Boost1 = 81,

    /// <summary>
    /// The vit boost1
    /// </summary>
    VIT_Boost1 = 82,

    /// <summary>
    /// The agi boost1
    /// </summary>
    AGI_Boost1 = 83,

    /// <summary>
    /// The int boost1
    /// </summary>
    INT_Boost1 = 84,

    /// <summary>
    /// The MND boost1
    /// </summary>
    MND_Boost1 = 85,

    /// <summary>
    /// The character boost1
    /// </summary>
    CHR_Boost1 = 86,

    /// <summary>
    /// The trick attack
    /// </summary>
    Trick_Attack = 87,

    /// <summary>
    /// The maximum hp boost
    /// </summary>
    Max_HP_Boost = 88,

    /// <summary>
    /// The maximum mp boost
    /// </summary>
    Max_MP_Boost = 89,

    /// <summary>
    /// The accuracy boost
    /// </summary>
    Accuracy_Boost = 90,

    /// <summary>
    /// The attack boost
    /// </summary>
    Attack_Boost = 91,

    /// <summary>
    /// The evasion boost
    /// </summary>
    Evasion_Boost = 92,

    /// <summary>
    /// The defense boost
    /// </summary>
    Defense_Boost = 93,

    /// <summary>
    /// The enfire
    /// </summary>
    Enfire = 94,

    /// <summary>
    /// The enblizzard
    /// </summary>
    Enblizzard = 95,

    /// <summary>
    /// The enaero
    /// </summary>
    Enaero = 96,

    /// <summary>
    /// The enstone
    /// </summary>
    Enstone = 97,

    /// <summary>
    /// The enthunder
    /// </summary>
    Enthunder = 98,

    /// <summary>
    /// The enwater
    /// </summary>
    Enwater = 99,

    /// <summary>
    /// The barfire
    /// </summary>
    Barfire = 100,

    /// <summary>
    /// The barblizzard
    /// </summary>
    Barblizzard = 101,

    /// <summary>
    /// The baraero
    /// </summary>
    Baraero = 102,

    /// <summary>
    /// The barstone
    /// </summary>
    Barstone = 103,

    /// <summary>
    /// The barthunder
    /// </summary>
    Barthunder = 104,

    /// <summary>
    /// The barwater
    /// </summary>
    Barwater = 105,

    /// <summary>
    /// The barsleep
    /// </summary>
    Barsleep = 106,

    /// <summary>
    /// The barpoison
    /// </summary>
    Barpoison = 107,

    /// <summary>
    /// The barparalyze
    /// </summary>
    Barparalyze = 108,

    /// <summary>
    /// The barblind
    /// </summary>
    Barblind = 109,

    /// <summary>
    /// The barsilence
    /// </summary>
    Barsilence = 110,

    /// <summary>
    /// The barpetrify
    /// </summary>
    Barpetrify = 111,

    /// <summary>
    /// The barvirus
    /// </summary>
    Barvirus = 112,

    /// <summary>
    /// The reraise
    /// </summary>
    Reraise = 113,

    /// <summary>
    /// The cover
    /// </summary>
    Cover = 114,

    /// <summary>
    /// The unlimited shot
    /// </summary>
    Unlimited_Shot = 115,

    /// <summary>
    /// The phalanx
    /// </summary>
    Phalanx = 116,

    /// <summary>
    /// The warding circle
    /// </summary>
    Warding_Circle = 117,

    /// <summary>
    /// The ancient circle
    /// </summary>
    Ancient_Circle = 118,

    /// <summary>
    /// The string boost2
    /// </summary>
    STR_Boost2 = 119,

    /// <summary>
    /// The dex boost2
    /// </summary>
    DEX_Boost2 = 120,

    /// <summary>
    /// The vit boost2
    /// </summary>
    VIT_Boost2 = 121,

    /// <summary>
    /// The agi boost2
    /// </summary>
    AGI_Boost2 = 122,

    /// <summary>
    /// The int boost2
    /// </summary>
    INT_Boost2 = 123,

    /// <summary>
    /// The MND boost2
    /// </summary>
    MND_Boost2 = 124,

    /// <summary>
    /// The character boost2
    /// </summary>
    CHR_Boost2 = 125,

    /// <summary>
    /// The spirit surge
    /// </summary>
    Spirit_Surge = 126,

    /// <summary>
    /// The costume
    /// </summary>
    Costume = 127,

    /// <summary>
    /// The burn
    /// </summary>
    Burn = 128,

    /// <summary>
    /// The frost
    /// </summary>
    Frost = 129,

    /// <summary>
    /// The choke
    /// </summary>
    Choke = 130,

    /// <summary>
    /// The rasp
    /// </summary>
    Rasp = 131,

    /// <summary>
    /// The shock
    /// </summary>
    Shock = 132,

    /// <summary>
    /// The drown
    /// </summary>
    Drown = 133,

    /// <summary>
    /// The dia
    /// </summary>
    Dia = 134,

    /// <summary>
    /// The bio
    /// </summary>
    Bio = 135,

    /// <summary>
    /// The string down
    /// </summary>
    STR_Down = 136,

    /// <summary>
    /// The dex down
    /// </summary>
    DEX_Down = 137,

    /// <summary>
    /// The vit down
    /// </summary>
    VIT_Down = 138,

    /// <summary>
    /// The agi down
    /// </summary>
    AGI_Down = 139,

    /// <summary>
    /// The int down
    /// </summary>
    INT_Down = 140,

    /// <summary>
    /// The MND down
    /// </summary>
    MND_Down = 141,

    /// <summary>
    /// The character down
    /// </summary>
    CHR_Down = 142,

    /// <summary>
    /// The level restriction
    /// </summary>
    Level_Restriction = 143,

    /// <summary>
    /// The maximum hp down
    /// </summary>
    Max_HP_Down = 144,

    /// <summary>
    /// The maximum mp down
    /// </summary>
    Max_MP_Down = 145,

    /// <summary>
    /// The accuracy down
    /// </summary>
    Accuracy_Down = 146,

    /// <summary>
    /// The attack down
    /// </summary>
    Attack_Down = 147,

    /// <summary>
    /// The evasion down
    /// </summary>
    Evasion_Down = 148,

    /// <summary>
    /// The defense down
    /// </summary>
    Defense_Down = 149,

    /// <summary>
    /// The physical shield
    /// </summary>
    Physical_Shield = 150,

    /// <summary>
    /// The arrow shield
    /// </summary>
    Arrow_Shield = 151,

    /// <summary>
    /// The magic shield
    /// </summary>
    Magic_Shield = 152,

    /// <summary>
    /// The damage spikes
    /// </summary>
    Damage_Spikes = 153,

    /// <summary>
    /// The shining ruby
    /// </summary>
    Shining_Ruby = 154,

    /// <summary>
    /// The medicine
    /// </summary>
    Medicine = 155,

    /// <summary>
    /// The flash
    /// </summary>
    Flash = 156,

    /// <summary>
    /// The subjob restriction
    /// </summary>
    Subjob_Restriction = 157,

    /// <summary>
    /// The provoke
    /// </summary>
    Provoke = 158,

    /// <summary>
    /// The penalty
    /// </summary>
    Penalty = 159,

    /// <summary>
    /// The preparations
    /// </summary>
    Preparations = 160,

    /// <summary>
    /// The sprint
    /// </summary>
    Sprint = 161,

    /// <summary>
    /// The enchantment
    /// </summary>
    Enchantment = 162,

    /// <summary>
    /// The azure lore
    /// </summary>
    Azure_Lore = 163,

    /// <summary>
    /// The chain affinity
    /// </summary>
    Chain_Affinity = 164,

    /// <summary>
    /// The burst affinity
    /// </summary>
    Burst_Affinity = 165,

    /// <summary>
    /// The overdrive
    /// </summary>
    Overdrive = 166,

    /// <summary>
    /// The magic definition down
    /// </summary>
    Magic_Def_Down = 167,

    /// <summary>
    /// The inhibit tp
    /// </summary>
    Inhibit_TP = 168,

    /// <summary>
    /// The potency
    /// </summary>
    Potency = 169,

    /// <summary>
    /// The regain
    /// </summary>
    Regain = 170,

    /// <summary>
    /// The pax
    /// </summary>
    Pax = 171,

    /// <summary>
    /// The intension
    /// </summary>
    Intension = 172,

    /// <summary>
    /// The dread spikes
    /// </summary>
    Dread_Spikes = 173,

    /// <summary>
    /// The magic acc down
    /// </summary>
    Magic_Acc_Down = 174,

    /// <summary>
    /// The magic atk down
    /// </summary>
    Magic_Atk_Down = 175,

    /// <summary>
    /// The quickening
    /// </summary>
    Quickening = 176,

    /// <summary>
    /// The encumbrance
    /// </summary>
    Encumbrance = 177,

    /// <summary>
    /// The firestorm
    /// </summary>
    Firestorm = 178,

    /// <summary>
    /// The hailstorm
    /// </summary>
    Hailstorm = 179,

    /// <summary>
    /// The windstorm
    /// </summary>
    Windstorm = 180,

    /// <summary>
    /// The sandstorm
    /// </summary>
    Sandstorm = 181,

    /// <summary>
    /// The thunderstorm
    /// </summary>
    Thunderstorm = 182,

    /// <summary>
    /// The rainstorm
    /// </summary>
    Rainstorm = 183,

    /// <summary>
    /// The aurorastorm
    /// </summary>
    Aurorastorm = 184,

    /// <summary>
    /// The voidstorm
    /// </summary>
    Voidstorm = 185,

    /// <summary>
    /// The helix
    /// </summary>
    Helix = 186,

    /// <summary>
    /// The sublimation activated
    /// </summary>
    Sublimation_Activated = 187,

    /// <summary>
    /// The sublimation complete
    /// </summary>
    Sublimation_Complete = 188,

    /// <summary>
    /// The maximum tp down
    /// </summary>
    Max_TP_Down = 189,

    /// <summary>
    /// The magic atk boost
    /// </summary>
    Magic_Atk_Boost = 190,

    /// <summary>
    /// The magic definition boost
    /// </summary>
    Magic_Def_Boost = 191,

    /// <summary>
    /// The requiem
    /// </summary>
    Requiem = 192,

    /// <summary>
    /// The lullaby
    /// </summary>
    Lullaby = 193,

    /// <summary>
    /// The elegy
    /// </summary>
    Elegy = 194,

    /// <summary>
    /// The paeon
    /// </summary>
    Paeon = 195,

    /// <summary>
    /// The ballad
    /// </summary>
    Ballad = 196,

    /// <summary>
    /// The minne
    /// </summary>
    Minne = 197,

    /// <summary>
    /// The minuet
    /// </summary>
    Minuet = 198,

    /// <summary>
    /// The madrigal
    /// </summary>
    Madrigal = 199,

    /// <summary>
    /// The prelude
    /// </summary>
    Prelude = 200,

    /// <summary>
    /// The mambo
    /// </summary>
    Mambo = 201,

    /// <summary>
    /// The aubade
    /// </summary>
    Aubade = 202,

    /// <summary>
    /// The pastoral
    /// </summary>
    Pastoral = 203,

    /// <summary>
    /// The hum
    /// </summary>
    Hum = 204,

    /// <summary>
    /// The fantasia
    /// </summary>
    Fantasia = 205,

    /// <summary>
    /// The operetta
    /// </summary>
    Operetta = 206,

    /// <summary>
    /// The capriccio
    /// </summary>
    Capriccio = 207,

    /// <summary>
    /// The serenade
    /// </summary>
    Serenade = 208,

    /// <summary>
    /// The round
    /// </summary>
    Round = 209,

    /// <summary>
    /// The gavotte
    /// </summary>
    Gavotte = 210,

    /// <summary>
    /// The fugue
    /// </summary>
    Fugue = 211,

    /// <summary>
    /// The rhapsody
    /// </summary>
    Rhapsody = 212,

    /// <summary>
    /// The aria
    /// </summary>
    Aria = 213,

    /// <summary>
    /// The march
    /// </summary>
    March = 214,

    /// <summary>
    /// The etude
    /// </summary>
    Etude = 215,

    /// <summary>
    /// The carol
    /// </summary>
    Carol = 216,

    /// <summary>
    /// The threnody
    /// </summary>
    Threnody = 217,

    /// <summary>
    /// The hymnus
    /// </summary>
    Hymnus = 218,

    /// <summary>
    /// The mazurka
    /// </summary>
    Mazurka = 219,

    /// <summary>
    /// The sirvente
    /// </summary>
    Sirvente = 220,

    /// <summary>
    /// The dirge
    /// </summary>
    Dirge = 221,

    /// <summary>
    /// The scherzo
    /// </summary>
    Scherzo = 222,

    /// <summary>
    /// The automatic regen
    /// </summary>
    Auto_Regen = 233,

    /// <summary>
    /// The automatic refresh
    /// </summary>
    Auto_Refresh = 234,

    /// <summary>
    /// The fishing imagery
    /// </summary>
    Fishing_Imagery = 235,

    /// <summary>
    /// The woodworking imagery
    /// </summary>
    Woodworking_Imagery = 236,

    /// <summary>
    /// The smithing imagery
    /// </summary>
    Smithing_Imagery = 237,

    /// <summary>
    /// The goldsmithing imagery
    /// </summary>
    Goldsmithing_Imagery = 238,

    /// <summary>
    /// The clothcraft imagery
    /// </summary>
    Clothcraft_Imagery = 239,

    /// <summary>
    /// The leathercraft imagery
    /// </summary>
    Leathercraft_Imagery = 240,

    /// <summary>
    /// The bonecraft imagery
    /// </summary>
    Bonecraft_Imagery = 241,

    /// <summary>
    /// The alchemy imagery
    /// </summary>
    Alchemy_Imagery = 242,

    /// <summary>
    /// The cooking imagery
    /// </summary>
    Cooking_Imagery = 243,

    /// <summary>
    /// The dedication
    /// </summary>
    Dedication = 249,

    /// <summary>
    /// The ef badge
    /// </summary>
    Ef_Badge = 250,

    /// <summary>
    /// The food
    /// </summary>
    Food = 251,

    /// <summary>
    /// The chocobo
    /// </summary>
    Chocobo = 252,

    /// <summary>
    /// The signet
    /// </summary>
    Signet = 253,

    /// <summary>
    /// The battlefield
    /// </summary>
    Battlefield = 254,

    /// <summary>
    /// The sanction
    /// </summary>
    Sanction = 256,

    /// <summary>
    /// The besieged
    /// </summary>
    Besieged = 257,

    /// <summary>
    /// The illusion
    /// </summary>
    Illusion = 258,

    //Encumbrance
    /// <summary>
    /// The no weapons armor
    /// </summary>
    No_Weapons_Armor = 259,

    //Obliviscence
    /// <summary>
    /// The no support job
    /// </summary>
    No_Support_Job = 260,

    //Impairment
    /// <summary>
    /// The no job abilities
    /// </summary>
    No_Job_Abilities = 261,

    //Omerta
    /// <summary>
    /// The no magic casting
    /// </summary>
    No_Magic_Casting = 262,

    //Debilitation
    /// <summary>
    /// The penalty to attributes
    /// </summary>
    Penalty_to_Attributes = 263,

    /// <summary>
    /// The pathos
    /// </summary>
    Pathos = 264,

    /// <summary>
    /// The flurry
    /// </summary>
    Flurry = 265,

    /// <summary>
    /// The concentration
    /// </summary>
    Concentration = 266,

    /// <summary>
    /// The allied tags
    /// </summary>
    Allied_Tags = 267,

    /// <summary>
    /// The sigil
    /// </summary>
    Sigil = 268,

    /// <summary>
    /// The level synchronize
    /// </summary>
    Level_Sync = 269,

    /// <summary>
    /// The aftermath LVL1
    /// </summary>
    Aftermath_lvl1 = 270,

    /// <summary>
    /// The aftermath LVL2
    /// </summary>
    Aftermath_lvl2 = 271,

    /// <summary>
    /// The aftermath LVL3
    /// </summary>
    Aftermath_lvl3 = 272,

    /// <summary>
    /// The aftermath
    /// </summary>
    Aftermath = 273,

    /// <summary>
    /// The enlight
    /// </summary>
    Enlight = 274,

    /// <summary>
    /// The auspice
    /// </summary>
    Auspice = 275,

    /// <summary>
    /// The confrontation
    /// </summary>
    Confrontation = 276,

    /// <summary>
    /// The enfire 2
    /// </summary>
    Enfire_2 = 277,

    /// <summary>
    /// The enblizzard 2
    /// </summary>
    Enblizzard_2 = 278,

    /// <summary>
    /// The enaero 2
    /// </summary>
    Enaero_2 = 279,

    /// <summary>
    /// The enstone 2
    /// </summary>
    Enstone_2 = 280,

    /// <summary>
    /// The enthunder 2
    /// </summary>
    Enthunder_2 = 281,

    /// <summary>
    /// The enwater 2
    /// </summary>
    Enwater_2 = 282,

    /// <summary>
    /// The perfect defense
    /// </summary>
    Perfect_Defense = 283,

    /// <summary>
    /// The egg
    /// </summary>
    Egg = 284,

    /// <summary>
    /// The visitant
    /// </summary>
    Visitant = 285,

    /// <summary>
    /// The baramnesia
    /// </summary>
    Baramnesia = 286,

    /// <summary>
    /// The atma
    /// </summary>
    Atma = 287,

    /// <summary>
    /// The endark
    /// </summary>
    Endark = 288,

    /// <summary>
    /// The enmity boost
    /// </summary>
    Enmity_Boost = 289,

    /// <summary>
    /// The subtle blow plus
    /// </summary>
    Subtle_Blow_Plus = 290,

    /// <summary>
    /// The enmity down
    /// </summary>
    Enmity_Down = 291,

    /// <summary>
    /// The pennant
    /// </summary>
    Pennant = 292,

    /// <summary>
    /// The negate petrify
    /// </summary>
    Negate_Petrify = 293,

    /// <summary>
    /// The negate terror
    /// </summary>
    Negate_Terror = 294,

    /// <summary>
    /// The negate amnesia
    /// </summary>
    Negate_Amnesia = 295,

    /// <summary>
    /// The negate doom
    /// </summary>
    Negate_Doom = 296,

    /// <summary>
    /// The negate poison
    /// </summary>
    Negate_Poison = 297,

    /// <summary>
    /// The critical hit evasion down
    /// </summary>
    Critical_Hit_Evasion_Down = 298,

    /// <summary>
    /// The overload
    /// </summary>
    Overload = 299,

    /// <summary>
    /// The fire maneuver
    /// </summary>
    Fire_Maneuver = 300,

    /// <summary>
    /// The ice maneuver
    /// </summary>
    Ice_Maneuver = 301,

    /// <summary>
    /// The wind maneuver
    /// </summary>
    Wind_Maneuver = 302,

    /// <summary>
    /// The earth maneuver
    /// </summary>
    Earth_Maneuver = 303,

    /// <summary>
    /// The thunder maneuver
    /// </summary>
    Thunder_Maneuver = 304,

    /// <summary>
    /// The water maneuver
    /// </summary>
    Water_Maneuver = 305,

    /// <summary>
    /// The light maneuver
    /// </summary>
    Light_Maneuver = 306,

    /// <summary>
    /// The dark maneuver
    /// </summary>
    Dark_Maneuver = 307,

    /// <summary>
    /// The double up chance
    /// </summary>
    DoubleUp_Chance = 308,

    /// <summary>
    /// The bust
    /// </summary>
    Bust = 309,

    /// <summary>
    /// The fighters roll
    /// </summary>
    Fighters_Roll = 310,

    /// <summary>
    /// The monks roll
    /// </summary>
    Monks_Roll = 311,

    /// <summary>
    /// The healers roll
    /// </summary>
    Healers_Roll = 312,

    /// <summary>
    /// The wizards roll
    /// </summary>
    Wizards_Roll = 313,

    /// <summary>
    /// The warlocks roll
    /// </summary>
    Warlocks_Roll = 314,

    /// <summary>
    /// The rogues roll
    /// </summary>
    Rogues_Roll = 315,

    /// <summary>
    /// The gallants roll
    /// </summary>
    Gallants_Roll = 316,

    /// <summary>
    /// The chaos roll
    /// </summary>
    Chaos_Roll = 317,

    /// <summary>
    /// The beast roll
    /// </summary>
    Beast_Roll = 318,

    /// <summary>
    /// The choral roll
    /// </summary>
    Choral_Roll = 319,

    /// <summary>
    /// The navs roll
    /// </summary>
    Navs_Roll = 320,

    /// <summary>
    /// The samurai roll
    /// </summary>
    Samurai_Roll = 321,

    /// <summary>
    /// The ninja roll
    /// </summary>
    Ninja_Roll = 322,

    /// <summary>
    /// The drachen roll
    /// </summary>
    Drachen_Roll = 323,

    /// <summary>
    /// The evokers roll
    /// </summary>
    Evokers_Roll = 324,

    /// <summary>
    /// The maguss roll
    /// </summary>
    Maguss_Roll = 325,

    /// <summary>
    /// The corsairs roll
    /// </summary>
    Corsairs_Roll = 326,

    /// <summary>
    /// The puppet roll
    /// </summary>
    Puppet_Roll = 327,

    /// <summary>
    /// The dancers roll
    /// </summary>
    Dancers_Roll = 328,

    /// <summary>
    /// The scholars roll
    /// </summary>
    Scholars_Roll = 329,

    /// <summary>
    /// The bolters roll
    /// </summary>
    Bolters__Roll = 330,

    /// <summary>
    /// The casters roll
    /// </summary>
    Casters_Roll = 331,

    /// <summary>
    /// The coursers roll
    /// </summary>
    Coursers_Roll = 332,

    /// <summary>
    /// The blitzers roll
    /// </summary>
    Blitzers_Roll = 333,

    /// <summary>
    /// The tacticians roll
    /// </summary>
    Tacticians_Roll = 334,

    /// <summary>
    /// The allies roll
    /// </summary>
    Allies_Roll = 335,

    /// <summary>
    /// The misers roll
    /// </summary>
    Misers_Roll = 336,

    /// <summary>
    /// The companions roll
    /// </summary>
    Companions_Roll = 337,

    /// <summary>
    /// The avengers roll
    /// </summary>
    Avengers_Roll = 338,

    /// <summary>
    /// The warriors charge
    /// </summary>
    Warriors_Charge = 340,

    /// <summary>
    /// The formless strikes
    /// </summary>
    Formless_Strikes = 341,

    /// <summary>
    /// The assassins charge
    /// </summary>
    Assassins_Charge = 342,

    /// <summary>
    /// The feint
    /// </summary>
    Feint = 343,

    /// <summary>
    /// The fealty
    /// </summary>
    Fealty = 344,

    /// <summary>
    /// The dark seal
    /// </summary>
    Dark_Seal = 345,

    /// <summary>
    /// The diabolic eye
    /// </summary>
    Diabolic_Eye = 346,

    /// <summary>
    /// The nightingale
    /// </summary>
    Nightingale = 347,

    /// <summary>
    /// The troubadour
    /// </summary>
    Troubadour = 348,

    /// <summary>
    /// The killer instinct
    /// </summary>
    Killer_Instinct = 349,

    /// <summary>
    /// The stealth shot
    /// </summary>
    Stealth_Shot = 350,

    /// <summary>
    /// The flashy shot
    /// </summary>
    Flashy_Shot = 351,

    /// <summary>
    /// The sange
    /// </summary>
    Sange = 352,

    /// <summary>
    /// The hasso
    /// </summary>
    Hasso = 353,

    /// <summary>
    /// The seigan
    /// </summary>
    Seigan = 354,

    /// <summary>
    /// The convergence
    /// </summary>
    Convergence = 355,

    /// <summary>
    /// The diffusion
    /// </summary>
    Diffusion = 356,

    /// <summary>
    /// The snake eye
    /// </summary>
    Snake_Eye = 357,

    /// <summary>
    /// The light arts
    /// </summary>
    Light_Arts = 358,

    /// <summary>
    /// The dark arts
    /// </summary>
    Dark_Arts = 359,

    /// <summary>
    /// The penury
    /// </summary>
    Penury = 360,

    /// <summary>
    /// The parsimony
    /// </summary>
    Parsimony = 361,

    /// <summary>
    /// The celerity
    /// </summary>
    Celerity = 362,

    /// <summary>
    /// The alacrity
    /// </summary>
    Alacrity = 363,

    /// <summary>
    /// The rapture
    /// </summary>
    Rapture = 364,

    /// <summary>
    /// The ebullience
    /// </summary>
    Ebullience = 365,

    /// <summary>
    /// The accession
    /// </summary>
    Accession = 366,

    /// <summary>
    /// The manifestation
    /// </summary>
    Manifestation = 367,

    /// <summary>
    /// The drain samba
    /// </summary>
    Drain_Samba = 368,

    /// <summary>
    /// The aspir samba
    /// </summary>
    Aspir_Samba = 369,

    /// <summary>
    /// The haste samba
    /// </summary>
    Haste_Samba = 370,

    /// <summary>
    /// The velocity shot
    /// </summary>
    Velocity_Shot = 371,

    /// <summary>
    /// The building flourish
    /// </summary>
    Building_Flourish = 375,

    /// <summary>
    /// The trance
    /// </summary>
    Trance = 376,

    /// <summary>
    /// The tabula rasa
    /// </summary>
    Tabula_Rasa = 377,

    /// <summary>
    /// The drain daze
    /// </summary>
    Drain_Daze = 378,

    /// <summary>
    /// The aspir daze
    /// </summary>
    Aspir_Daze = 379,

    /// <summary>
    /// The haste daze
    /// </summary>
    Haste_Daze = 380,

    /// <summary>
    /// The finishing move1
    /// </summary>
    Finishing_Move1 = 381,

    /// <summary>
    /// The finishing move2
    /// </summary>
    Finishing_Move2 = 382,

    /// <summary>
    /// The finishing move3
    /// </summary>
    Finishing_Move3 = 383,

    /// <summary>
    /// The finishing move4
    /// </summary>
    Finishing_Move4 = 384,

    /// <summary>
    /// The finishing move5
    /// </summary>
    Finishing_Move5 = 385,

    /// <summary>
    /// The lethargic daze1
    /// </summary>
    Lethargic_Daze1 = 386,

    /// <summary>
    /// The lethargic daze2
    /// </summary>
    Lethargic_Daze2 = 387,

    /// <summary>
    /// The lethargic daze3
    /// </summary>
    Lethargic_Daze3 = 388,

    /// <summary>
    /// The lethargic daze4
    /// </summary>
    Lethargic_Daze4 = 389,

    /// <summary>
    /// The lethargic daze5
    /// </summary>
    Lethargic_Daze5 = 390,

    /// <summary>
    /// The sluggish daze1
    /// </summary>
    Sluggish_Daze1 = 391,

    /// <summary>
    /// The sluggish daze2
    /// </summary>
    Sluggish_Daze2 = 392,

    /// <summary>
    /// The sluggish daze3
    /// </summary>
    Sluggish_Daze3 = 393,

    /// <summary>
    /// The sluggish daze4
    /// </summary>
    Sluggish_Daze4 = 394,

    /// <summary>
    /// The sluggish daze5
    /// </summary>
    Sluggish_Daze5 = 395,

    /// <summary>
    /// The weakened daze1
    /// </summary>
    Weakened_Daze1 = 396,

    /// <summary>
    /// The weakened daze2
    /// </summary>
    Weakened_Daze2 = 397,

    /// <summary>
    /// The weakened daze3
    /// </summary>
    Weakened_Daze3 = 398,

    /// <summary>
    /// The weakened daze4
    /// </summary>
    Weakened_Daze4 = 399,

    /// <summary>
    /// The weakened daze5
    /// </summary>
    Weakened_Daze5 = 400,

    /// <summary>
    /// The addendum white
    /// </summary>
    Addendum_White = 401,

    /// <summary>
    /// The addendum black
    /// </summary>
    Addendum_Black = 402,

    /// <summary>
    /// The reprisal
    /// </summary>
    Reprisal = 403,

    /// <summary>
    /// The magic evasion down
    /// </summary>
    Magic_Evasion_Down = 404,

    /// <summary>
    /// The retaliation
    /// </summary>
    Retaliation = 405,

    /// <summary>
    /// The footwork
    /// </summary>
    Footwork = 406,

    /// <summary>
    /// The klimaform
    /// </summary>
    Klimaform = 407,

    /// <summary>
    /// The sekkanoki
    /// </summary>
    Sekkanoki = 408,

    /// <summary>
    /// The pianissimo
    /// </summary>
    Pianissimo = 409,

    /// <summary>
    /// The saber dance
    /// </summary>
    Saber_Dance = 410,

    /// <summary>
    /// The fan dance
    /// </summary>
    Fan_Dance = 411,

    /// <summary>
    /// The altruism
    /// </summary>
    Altruism = 412,

    /// <summary>
    /// The focalization
    /// </summary>
    Focalization = 413,

    /// <summary>
    /// The tranquility
    /// </summary>
    Tranquility = 414,

    /// <summary>
    /// The equanimity
    /// </summary>
    Equanimity = 415,

    /// <summary>
    /// The enlightenment
    /// </summary>
    Enlightenment = 416,

    /// <summary>
    /// The afflatus solace
    /// </summary>
    Afflatus_Solace = 417,

    /// <summary>
    /// The afflatus misery
    /// </summary>
    Afflatus_Misery = 418,

    /// <summary>
    /// The composure
    /// </summary>
    Composure = 419,

    /// <summary>
    /// The yonin
    /// </summary>
    Yonin = 420,

    /// <summary>
    /// The innin
    /// </summary>
    Innin = 421,

    /// <summary>
    /// The carbuncles favor
    /// </summary>
    Carbuncles_Favor = 422,

    /// <summary>
    /// The ifrits favor
    /// </summary>
    Ifrits_Favor = 423,

    /// <summary>
    /// The shivas favor
    /// </summary>
    Shivas_Favor = 424,

    /// <summary>
    /// The garudas favor
    /// </summary>
    Garudas_Favor = 425,

    /// <summary>
    /// The titans favor
    /// </summary>
    Titans_Favor = 426,

    /// <summary>
    /// The ramuhs favor
    /// </summary>
    Ramuhs_Favor = 427,

    /// <summary>
    /// The leviathans favor
    /// </summary>
    Leviathans_Favor = 428,

    /// <summary>
    /// The fenrirs favor
    /// </summary>
    Fenrirs_Favor = 429,

    /// <summary>
    /// The diabolos favor
    /// </summary>
    Diabolos_Favor = 430,

    /// <summary>
    /// The avatars favor
    /// </summary>
    Avatars_Favor = 431,

    /// <summary>
    /// The multi strikes
    /// </summary>
    Multi_Strikes = 432,

    /// <summary>
    /// The double shot
    /// </summary>
    Double_Shot = 433,

    /// <summary>
    /// The transcendency
    /// </summary>
    Transcendency = 434,

    /// <summary>
    /// The restraint
    /// </summary>
    Restraint = 435,

    /// <summary>
    /// The perfect counter
    /// </summary>
    Perfect_Counter = 436,

    /// <summary>
    /// The mana wall
    /// </summary>
    Mana_Wall = 437,

    /// <summary>
    /// The divine emblem
    /// </summary>
    Divine_Emblem = 438,

    /// <summary>
    /// The nether void
    /// </summary>
    Nether_Void = 439,

    /// <summary>
    /// The sengikori
    /// </summary>
    Sengikori = 440,

    /// <summary>
    /// The futae
    /// </summary>
    Futae = 441,

    /// <summary>
    /// The presto
    /// </summary>
    Presto = 442,

    /// <summary>
    /// The climactic flourish
    /// </summary>
    Climactic_Flourish = 443,

    /// <summary>
    /// The utsusemi 2 shadows left
    /// </summary>
    Utsusemi_2_Shadows_Left = 444,

    /// <summary>
    /// The utsusemi 3 shadows left
    /// </summary>
    Utsusemi_3_Shadows_Left = 445,

    /// <summary>
    /// The utsusemi 4 shadows left
    /// </summary>
    Utsusemi_4_Shadows_Left = 446,

    /// <summary>
    /// The multi shots
    /// </summary>
    Multi_Shots = 447,

    /// <summary>
    /// The bewildered daze1
    /// </summary>
    Bewildered_Daze1 = 448,

    /// <summary>
    /// The bewildered daze2
    /// </summary>
    Bewildered_Daze2 = 449,

    /// <summary>
    /// The bewildered daze3
    /// </summary>
    Bewildered_Daze3 = 450,

    /// <summary>
    /// The bewildered daze4
    /// </summary>
    Bewildered_Daze4 = 451,

    /// <summary>
    /// The bewildered daze5
    /// </summary>
    Bewildered_Daze5 = 452,

    /// <summary>
    /// The divine caress
    /// </summary>
    Divine_Caress = 453,

    /// <summary>
    /// The saboteur
    /// </summary>
    Saboteur = 454,

    /// <summary>
    /// The tenuto
    /// </summary>
    Tenuto = 455,

    /// <summary>
    /// The spur
    /// </summary>
    Spur = 456,

    /// <summary>
    /// The efflux
    /// </summary>
    Efflux = 457,

    /// <summary>
    /// The earthen armor
    /// </summary>
    Earthen_Armor = 458,

    /// <summary>
    /// The divine caress2
    /// </summary>
    Divine_Caress2 = 459,

    /// <summary>
    /// The blood rage
    /// </summary>
    Blood_Rage = 460,

    /// <summary>
    /// The impetus
    /// </summary>
    Impetus = 461,

    /// <summary>
    /// The conspirator
    /// </summary>
    Conspirator = 462,

    /// <summary>
    /// The sepulcher
    /// </summary>
    Sepulcher = 463,

    /// <summary>
    /// The arcane crest
    /// </summary>
    Arcane_Crest = 464,

    /// <summary>
    /// The hamanoha
    /// </summary>
    Hamanoha = 465,

    /// <summary>
    /// The dragon breaker
    /// </summary>
    Dragon_Breaker = 466,

    /// <summary>
    /// The triple shot
    /// </summary>
    Triple_Shot = 467,

    /// <summary>
    /// The striking flourish
    /// </summary>
    Striking_Flourish = 468,

    /// <summary>
    /// The perpetuance
    /// </summary>
    Perpetuance = 469,

    /// <summary>
    /// The immanence
    /// </summary>
    Immanence = 470,

    /// <summary>
    /// The migawari
    /// </summary>
    Migawari = 471,

    /// <summary>
    /// The ternary flourish
    /// </summary>
    Ternary_Flourish = 472,

    /// <summary>
    /// The muddled
    /// </summary>
    Muddled = 473,

    /// <summary>
    /// The prowess
    /// </summary>
    Prowess = 474,

    /// <summary>
    /// The voidwatcher
    /// </summary>
    Voidwatcher = 475,

    /// <summary>
    /// The ensphere
    /// </summary>
    Ensphere = 476,

    /// <summary>
    /// The sacrosanctity
    /// </summary>
    Sacrosanctity = 477,

    /// <summary>
    /// The palisade
    /// </summary>
    Palisade = 478,

    /// <summary>
    /// The scarlet delirium
    /// </summary>
    Scarlet_Delirium = 479,

    /// <summary>
    /// The scarlet delirium2
    /// </summary>
    Scarlet_Delirium2 = 480,

    /// <summary>
    /// The decoy shot
    /// </summary>
    Decoy_Shot = 482,

    /// <summary>
    /// The hagakure
    /// </summary>
    Hagakure = 483,

    /// <summary>
    /// The issekigan
    /// </summary>
    Issekigan = 484,

    /// <summary>
    /// The unbridled learning
    /// </summary>
    Unbridled_Learning = 485,

    /// <summary>
    /// The counter boost
    /// </summary>
    Counter_Boost = 486,

    /// <summary>
    /// The endrain
    /// </summary>
    Endrain = 487,

    /// <summary>
    /// The enaspir
    /// </summary>
    Enaspir = 488,

    /// <summary>
    /// The afterglow
    /// </summary>
    Afterglow = 489,

    /// <summary>
    /// The imminent strikes
    /// </summary>
    Imminent_Strikes = 490,

    /// <summary>
    /// The MNK s p2
    /// </summary>
    MNK_SP2 = 491,

    /// <summary>
    /// The asylum
    /// </summary>
    Asylum = 492,

    /// <summary>
    /// The subtle sorcery
    /// </summary>
    Subtle_Sorcery = 493,

    /// <summary>
    /// The encomium
    /// </summary>
    Encomium = 494,

    /// <summary>
    /// The THF s p2
    /// </summary>
    THF_SP2 = 495,

    /// <summary>
    /// The righteous guard
    /// </summary>
    Righteous_Guard = 496,

    /// <summary>
    /// The DRK s p2
    /// </summary>
    DRK_SP2 = 497,

    /// <summary>
    /// The BST s p2
    /// </summary>
    BST_SP2 = 498,

    /// <summary>
    /// The malinconico
    /// </summary>
    Malinconico = 499,

    /// <summary>
    /// The instinctive aim
    /// </summary>
    Instinctive_Aim = 500,

    /// <summary>
    /// The yaegasumi
    /// </summary>
    Yaegasumi = 501,

    /// <summary>
    /// The tengen
    /// </summary>
    Tengen = 502,

    /// <summary>
    /// The rouse wyvern
    /// </summary>
    Rouse_Wyvern = 503,

    /// <summary>
    /// The astral conduit
    /// </summary>
    Astral_Conduit = 504,

    /// <summary>
    /// The unbridled wisdom
    /// </summary>
    Unbridled_Wisdom = 505,

    /// <summary>
    /// The three to one
    /// </summary>
    Three_To_One = 506,
}

/// <summary>
/// Enum ViewMode
/// </summary>
public enum ViewMode
{
    /// <summary>
    /// The third person
    /// </summary>
    ThirdPerson = 0,

    /// <summary>
    /// The first person
    /// </summary>
    FirstPerson = 1,
}

/// <summary>
/// Weapon Skill List
/// </summary>
public enum WeaponSkillList : short
{
    /// <summary>
    /// The combo
    /// </summary>
    Combo = 769,

    /// <summary>
    /// The shoulder tackle
    /// </summary>
    Shoulder_Tackle = 770,

    /// <summary>
    /// The one inch punch
    /// </summary>
    One_Inch_Punch = 771,

    /// <summary>
    /// The backhand blow
    /// </summary>
    Backhand_Blow = 772,

    /// <summary>
    /// The raging fists
    /// </summary>
    Raging_Fists = 773,

    /// <summary>
    /// The spinning attack
    /// </summary>
    Spinning_Attack = 774,

    /// <summary>
    /// The howling fist
    /// </summary>
    Howling_Fist = 775,

    /// <summary>
    /// The dragon kick
    /// </summary>
    Dragon_Kick = 776,

    /// <summary>
    /// The asuran fists
    /// </summary>
    Asuran_Fists = 777,

    /// <summary>
    /// The final heaven
    /// </summary>
    Final_Heaven = 778,

    /// <summary>
    /// The ascetics fury
    /// </summary>
    Ascetics_Fury = 779,

    /// <summary>
    /// The stringing pummel
    /// </summary>
    Stringing_Pummel = 780,

    /// <summary>
    /// The tornado kick
    /// </summary>
    Tornado_Kick = 781,

    /// <summary>
    /// The victory smite
    /// </summary>
    Victory_Smite = 782,

    /// <summary>
    /// The shijin spiral
    /// </summary>
    Shijin_Spiral = 783,

    /// <summary>
    /// The wasp sting
    /// </summary>
    Wasp_Sting = 784,

    /// <summary>
    /// The viper bite
    /// </summary>
    Viper_Bite = 785,

    /// <summary>
    /// The shadowstitch
    /// </summary>
    Shadowstitch = 786,

    /// <summary>
    /// The gust slash
    /// </summary>
    Gust_Slash = 787,

    /// <summary>
    /// The cyclone
    /// </summary>
    Cyclone = 788,

    /// <summary>
    /// The energy steal
    /// </summary>
    Energy_Steal = 789,

    /// <summary>
    /// The energy drain
    /// </summary>
    Energy_Drain = 790,

    /// <summary>
    /// The dancing edge
    /// </summary>
    Dancing_Edge = 791,

    /// <summary>
    /// The shark bite
    /// </summary>
    Shark_Bite = 792,

    /// <summary>
    /// The evisceration
    /// </summary>
    Evisceration = 793,

    /// <summary>
    /// The mercy stroke
    /// </summary>
    Mercy_Stroke = 794,

    /// <summary>
    /// The mandalic stab
    /// </summary>
    Mandalic_Stab = 795,

    /// <summary>
    /// The mordant rime
    /// </summary>
    Mordant_Rime = 796,

    /// <summary>
    /// The pyrrhic kleos
    /// </summary>
    Pyrrhic_Kleos = 797,

    /// <summary>
    /// The aeolian edge
    /// </summary>
    Aeolian_Edge = 798,

    /// <summary>
    /// The rudras storm
    /// </summary>
    Rudras_Storm = 799,

    /// <summary>
    /// The fast blade
    /// </summary>
    Fast_Blade = 800,

    /// <summary>
    /// The burning blade
    /// </summary>
    Burning_Blade = 801,

    /// <summary>
    /// The red lotus blade
    /// </summary>
    Red_Lotus_Blade = 802,

    /// <summary>
    /// The flat blade
    /// </summary>
    Flat_Blade = 803,

    /// <summary>
    /// The shining blade
    /// </summary>
    Shining_Blade = 804,

    /// <summary>
    /// The seraph blade
    /// </summary>
    Seraph_Blade = 805,

    /// <summary>
    /// The circle blade
    /// </summary>
    Circle_Blade = 806,

    /// <summary>
    /// The spirits within
    /// </summary>
    Spirits_Within = 807,

    /// <summary>
    /// The vorpal blade
    /// </summary>
    Vorpal_Blade = 808,

    /// <summary>
    /// The swift blade
    /// </summary>
    Swift_Blade = 809,

    /// <summary>
    /// The savage blade
    /// </summary>
    Savage_Blade = 810,

    /// <summary>
    /// The knights of round
    /// </summary>
    Knights_of_Round = 811,

    /// <summary>
    /// The death blossom
    /// </summary>
    Death_Blossom = 812,

    /// <summary>
    /// The atonement
    /// </summary>
    Atonement = 813,

    /// <summary>
    /// The expiacion
    /// </summary>
    Expiacion = 814,

    /// <summary>
    /// The sanguine blade
    /// </summary>
    Sanguine_Blade = 815,

    /// <summary>
    /// The hard slash
    /// </summary>
    Hard_Slash = 816,

    /// <summary>
    /// The power slash
    /// </summary>
    Power_Slash = 817,

    /// <summary>
    /// The frostbite
    /// </summary>
    Frostbite = 818,

    /// <summary>
    /// The freezebite
    /// </summary>
    Freezebite = 819,

    /// <summary>
    /// The shockwave
    /// </summary>
    Shockwave = 820,

    /// <summary>
    /// The crescent moon
    /// </summary>
    Crescent_Moon = 821,

    /// <summary>
    /// The sickle moon
    /// </summary>
    Sickle_Moon = 822,

    /// <summary>
    /// The spinning slash
    /// </summary>
    Spinning_Slash = 823,

    /// <summary>
    /// The ground strike
    /// </summary>
    Ground_Strike = 824,

    /// <summary>
    /// The scourge
    /// </summary>
    Scourge = 825,

    /// <summary>
    /// The herculean slash
    /// </summary>
    Herculean_Slash = 826,

    /// <summary>
    /// The torcleaver
    /// </summary>
    Torcleaver = 827,

    /// <summary>
    /// The resolution
    /// </summary>
    Resolution = 828,

    /// <summary>
    /// The raging axe
    /// </summary>
    Raging_Axe = 832,

    /// <summary>
    /// The smash axe
    /// </summary>
    Smash_Axe = 833,

    /// <summary>
    /// The gale axe
    /// </summary>
    Gale_Axe = 834,

    /// <summary>
    /// The avalanche axe
    /// </summary>
    Avalanche_Axe = 835,

    /// <summary>
    /// The spinning axe
    /// </summary>
    Spinning_Axe = 836,

    /// <summary>
    /// The rampage
    /// </summary>
    Rampage = 837,

    /// <summary>
    /// The calamity
    /// </summary>
    Calamity = 838,

    /// <summary>
    /// The mistral axe
    /// </summary>
    Mistral_Axe = 839,

    /// <summary>
    /// The decimation
    /// </summary>
    Decimation = 840,

    /// <summary>
    /// The onslaught
    /// </summary>
    Onslaught = 841,

    /// <summary>
    /// The primal rend
    /// </summary>
    Primal_Rend = 842,

    /// <summary>
    /// The bora axe
    /// </summary>
    Bora_Axe = 843,

    /// <summary>
    /// The cloudsplitter
    /// </summary>
    Cloudsplitter = 844,

    /// <summary>
    /// The ruinator
    /// </summary>
    Ruinator = 845,

    /// <summary>
    /// The shield break
    /// </summary>
    Shield_Break = 848,

    /// <summary>
    /// The iron tempest
    /// </summary>
    Iron_Tempest = 849,

    /// <summary>
    /// The sturmwind
    /// </summary>
    Sturmwind = 850,

    /// <summary>
    /// The armor break
    /// </summary>
    Armor_Break = 851,

    /// <summary>
    /// The keen edge
    /// </summary>
    Keen_Edge = 852,

    /// <summary>
    /// The weapon break
    /// </summary>
    Weapon_Break = 853,

    /// <summary>
    /// The raging rush
    /// </summary>
    Raging_Rush = 854,

    /// <summary>
    /// The full break
    /// </summary>
    Full_Break = 855,

    /// <summary>
    /// The steel cyclone
    /// </summary>
    Steel_Cyclone = 856,

    /// <summary>
    /// The metatron torment
    /// </summary>
    Metatron_Torment = 857,

    /// <summary>
    /// The kings justice
    /// </summary>
    Kings_Justice = 858,

    /// <summary>
    /// The fell cleave
    /// </summary>
    Fell_Cleave = 859,

    /// <summary>
    /// The ukkos fury
    /// </summary>
    Ukkos_Fury = 860,

    /// <summary>
    /// The upheaval
    /// </summary>
    Upheaval = 861,

    /// <summary>
    /// The slice
    /// </summary>
    Slice = 864,

    /// <summary>
    /// The dark harvest
    /// </summary>
    Dark_Harvest = 865,

    /// <summary>
    /// The shadow of death
    /// </summary>
    Shadow_of_Death = 866,

    /// <summary>
    /// The nightmare scythe
    /// </summary>
    Nightmare_Scythe = 867,

    /// <summary>
    /// The spinning scythe
    /// </summary>
    Spinning_Scythe = 868,

    /// <summary>
    /// The vorpal scythe
    /// </summary>
    Vorpal_Scythe = 869,

    /// <summary>
    /// The guillotine
    /// </summary>
    Guillotine = 870,

    /// <summary>
    /// The cross reaper
    /// </summary>
    Cross_Reaper = 871,

    /// <summary>
    /// The spiral hell
    /// </summary>
    Spiral_Hell = 872,

    /// <summary>
    /// The catastrophe
    /// </summary>
    Catastrophe = 873,

    /// <summary>
    /// The insurgency
    /// </summary>
    Insurgency = 874,

    /// <summary>
    /// The infernal scythe
    /// </summary>
    Infernal_Scythe = 875,

    /// <summary>
    /// The quietus
    /// </summary>
    Quietus = 876,

    /// <summary>
    /// The entropy
    /// </summary>
    Entropy = 877,

    /// <summary>
    /// The double thrust
    /// </summary>
    Double_Thrust = 880,

    /// <summary>
    /// The thunder thrust
    /// </summary>
    Thunder_Thrust = 881,

    /// <summary>
    /// The raiden thrust
    /// </summary>
    Raiden_Thrust = 882,

    /// <summary>
    /// The leg sweep
    /// </summary>
    Leg_Sweep = 883,

    /// <summary>
    /// The penta thrust
    /// </summary>
    Penta_Thrust = 884,

    /// <summary>
    /// The vorpal thrust
    /// </summary>
    Vorpal_Thrust = 885,

    /// <summary>
    /// The skewer
    /// </summary>
    Skewer = 886,

    /// <summary>
    /// The wheeling thrust
    /// </summary>
    Wheeling_Thrust = 887,

    /// <summary>
    /// The impulse drive
    /// </summary>
    Impulse_Drive = 888,

    /// <summary>
    /// The geirskogul
    /// </summary>
    Geirskogul = 889,

    /// <summary>
    /// The drakesbane
    /// </summary>
    Drakesbane = 890,

    /// <summary>
    /// The sonic thrust
    /// </summary>
    Sonic_Thrust = 891,

    /// <summary>
    /// The camlanns torment
    /// </summary>
    Camlanns_Torment = 892,

    /// <summary>
    /// The stardiver
    /// </summary>
    Stardiver = 893,

    /// <summary>
    /// The blade rin
    /// </summary>
    Blade_Rin = 896,

    /// <summary>
    /// The blade retsu
    /// </summary>
    Blade_Retsu = 897,

    /// <summary>
    /// The blade teki
    /// </summary>
    Blade_Teki = 898,

    /// <summary>
    /// The blade to
    /// </summary>
    Blade_To = 899,

    /// <summary>
    /// The blade chi
    /// </summary>
    Blade_Chi = 900,

    /// <summary>
    /// The blade ei
    /// </summary>
    Blade_Ei = 901,

    /// <summary>
    /// The blade jin
    /// </summary>
    Blade_Jin = 902,

    /// <summary>
    /// The blade ten
    /// </summary>
    Blade_Ten = 903,

    /// <summary>
    /// The blade ku
    /// </summary>
    Blade_Ku = 904,

    /// <summary>
    /// The blade metsu
    /// </summary>
    Blade_Metsu = 905,

    /// <summary>
    /// The blade kamu
    /// </summary>
    Blade_Kamu = 906,

    /// <summary>
    /// The blade yu
    /// </summary>
    Blade_Yu = 907,

    /// <summary>
    /// The blade hi
    /// </summary>
    Blade_Hi = 908,

    /// <summary>
    /// The blade shun
    /// </summary>
    Blade_Shun = 909,

    /// <summary>
    /// The tachi enpi
    /// </summary>
    Tachi_Enpi = 912,

    /// <summary>
    /// The tachi hobaku
    /// </summary>
    Tachi_Hobaku = 913,

    /// <summary>
    /// The tachi goten
    /// </summary>
    Tachi_Goten = 914,

    /// <summary>
    /// The tachi kagero
    /// </summary>
    Tachi_Kagero = 915,

    /// <summary>
    /// The tachi jinpu
    /// </summary>
    Tachi_Jinpu = 916,

    /// <summary>
    /// The tachi koki
    /// </summary>
    Tachi_Koki = 917,

    /// <summary>
    /// The tachi yukikaze
    /// </summary>
    Tachi_Yukikaze = 918,

    /// <summary>
    /// The tachi gekko
    /// </summary>
    Tachi_Gekko = 919,

    /// <summary>
    /// The tachi kasha
    /// </summary>
    Tachi_Kasha = 920,

    /// <summary>
    /// The tachi kaiten
    /// </summary>
    Tachi_Kaiten = 921,

    /// <summary>
    /// The tachi rana
    /// </summary>
    Tachi_Rana = 922,

    /// <summary>
    /// The tachi ageha
    /// </summary>
    Tachi_Ageha = 923,

    /// <summary>
    /// The tachi fudo
    /// </summary>
    Tachi_Fudo = 924,

    /// <summary>
    /// The tachi shoha
    /// </summary>
    Tachi_Shoha = 925,

    /// <summary>
    /// The shining strike
    /// </summary>
    Shining_Strike = 928,

    /// <summary>
    /// The seraph strike
    /// </summary>
    Seraph_Strike = 929,

    /// <summary>
    /// The brainshaker
    /// </summary>
    Brainshaker = 930,

    /// <summary>
    /// The starlight
    /// </summary>
    Starlight = 931,

    /// <summary>
    /// The moonlight
    /// </summary>
    Moonlight = 932,

    /// <summary>
    /// The skullbreaker
    /// </summary>
    Skullbreaker = 933,

    /// <summary>
    /// The true strike
    /// </summary>
    True_Strike = 934,

    /// <summary>
    /// The judgment
    /// </summary>
    Judgment = 935,

    /// <summary>
    /// The hexa strike
    /// </summary>
    Hexa_Strike = 936,

    /// <summary>
    /// The black halo
    /// </summary>
    Black_Halo = 937,

    /// <summary>
    /// The randgrith
    /// </summary>
    Randgrith = 938,

    /// <summary>
    /// The mystic boon
    /// </summary>
    Mystic_Boon = 939,

    /// <summary>
    /// The flash nova
    /// </summary>
    Flash_Nova = 940,

    /// <summary>
    /// The dagan
    /// </summary>
    Dagan = 941,

    /// <summary>
    /// The realmrazer
    /// </summary>
    Realmrazer = 942,

    /// <summary>
    /// The heavy swing
    /// </summary>
    Heavy_Swing = 944,

    /// <summary>
    /// The rock crusher
    /// </summary>
    Rock_Crusher = 945,

    /// <summary>
    /// The earth crusher
    /// </summary>
    Earth_Crusher = 946,

    /// <summary>
    /// The starburst
    /// </summary>
    Starburst = 947,

    /// <summary>
    /// The sunburst
    /// </summary>
    Sunburst = 948,

    /// <summary>
    /// The shell crusher
    /// </summary>
    Shell_Crusher = 949,

    /// <summary>
    /// The full swing
    /// </summary>
    Full_Swing = 950,

    /// <summary>
    /// The spirit taker
    /// </summary>
    Spirit_Taker = 951,

    /// <summary>
    /// The retribution
    /// </summary>
    Retribution = 952,

    /// <summary>
    /// The gate of tartarus
    /// </summary>
    Gate_of_Tartarus = 953,

    /// <summary>
    /// The vidohunir
    /// </summary>
    Vidohunir = 954,

    /// <summary>
    /// The garland of bliss
    /// </summary>
    Garland_of_Bliss = 955,

    /// <summary>
    /// The omniscience
    /// </summary>
    Omniscience = 956,

    /// <summary>
    /// The cataclysm
    /// </summary>
    Cataclysm = 957,

    /// <summary>
    /// The myrkr
    /// </summary>
    Myrkr = 958,

    /// <summary>
    /// The shattersoul
    /// </summary>
    Shattersoul = 959,

    /// <summary>
    /// The flaming arrow
    /// </summary>
    Flaming_Arrow = 960,

    /// <summary>
    /// The piercing arrow
    /// </summary>
    Piercing_Arrow = 961,

    /// <summary>
    /// The dulling arrow
    /// </summary>
    Dulling_Arrow = 962,

    /// <summary>
    /// The sidewinder
    /// </summary>
    Sidewinder = 964,

    /// <summary>
    /// The blast arrow
    /// </summary>
    Blast_Arrow = 965,

    /// <summary>
    /// The arching arrow
    /// </summary>
    Arching_Arrow = 966,

    /// <summary>
    /// The empyreal arrow
    /// </summary>
    Empyreal_Arrow = 967,

    /// <summary>
    /// The namas arrow
    /// </summary>
    Namas_Arrow = 968,

    /// <summary>
    /// The refulgent arrow
    /// </summary>
    Refulgent_Arrow = 969,

    /// <summary>
    /// The jishnus radiance
    /// </summary>
    Jishnus_Radiance = 970,

    /// <summary>
    /// The apex arrow
    /// </summary>
    Apex_Arrow = 971,

    /// <summary>
    /// The hot shot
    /// </summary>
    Hot_Shot = 976,

    /// <summary>
    /// The split shot
    /// </summary>
    Split_Shot = 977,

    /// <summary>
    /// The sniper shot
    /// </summary>
    Sniper_Shot = 978,

    /// <summary>
    /// The slug shot
    /// </summary>
    Slug_Shot = 980,

    /// <summary>
    /// The blast shot
    /// </summary>
    Blast_Shot = 981,

    /// <summary>
    /// The heavy shot
    /// </summary>
    Heavy_Shot = 982,

    /// <summary>
    /// The detonator
    /// </summary>
    Detonator = 983,

    /// <summary>
    /// The coronach
    /// </summary>
    Coronach = 984,

    /// <summary>
    /// The trueflight
    /// </summary>
    Trueflight = 985,

    /// <summary>
    /// The leaden salute
    /// </summary>
    Leaden_Salute = 986,

    /// <summary>
    /// The numbing shot
    /// </summary>
    Numbing_Shot = 987,

    /// <summary>
    /// The wildfire
    /// </summary>
    Wildfire = 988,

    /// <summary>
    /// The last stand
    /// </summary>
    Last_Stand = 989,

    /// <summary>
    /// The exenterator
    /// </summary>
    Exenterator = 992,

    /// <summary>
    /// The chant du cygne
    /// </summary>
    Chant_du_Cygne = 993,

    /// <summary>
    /// The requiescat
    /// </summary>
    Requiescat = 994,

    /// <summary>
    /// The uriel blade
    /// </summary>
    Uriel_Blade = 1006,

    /// <summary>
    /// The glory slash
    /// </summary>
    Glory_Slash = 1007
}

// @ public enum StatusEffect : short
/// <summary>
/// Zones
/// </summary>
public enum Zone : short
{
    /// <summary>
    /// The grand pas
    /// </summary>
    Grand_Pas = 507,

    /// <summary>
    /// The unknown
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// The phanauet channel
    /// </summary>
    Phanauet_Channel = 1,

    /// <summary>
    /// The carpenters landing
    /// </summary>
    Carpenters_Landing = 2,

    /// <summary>
    /// The manaclipper
    /// </summary>
    Manaclipper = 3,

    /// <summary>
    /// The bibiki bay
    /// </summary>
    Bibiki_Bay = 4,

    /// <summary>
    /// The uleguerand range
    /// </summary>
    Uleguerand_Range = 5,

    /// <summary>
    /// The bearclaw pinnacle
    /// </summary>
    Bearclaw_Pinnacle = 6,

    /// <summary>
    /// The attohwa chasm
    /// </summary>
    Attohwa_Chasm = 7,

    /// <summary>
    /// The boneyard gully
    /// </summary>
    Boneyard_Gully = 8,

    /// <summary>
    /// The pso xja
    /// </summary>
    PsoXja = 9,

    /// <summary>
    /// The shrouded maw
    /// </summary>
    The_Shrouded_Maw = 10,

    /// <summary>
    /// The oldton movalpolos
    /// </summary>
    Oldton_Movalpolos = 11,

    /// <summary>
    /// The newton movalpolos
    /// </summary>
    Newton_Movalpolos = 12,

    /// <summary>
    /// The mineshaft 2716
    /// </summary>
    Mineshaft_2716 = 13,

    /// <summary>
    /// The hall of transference
    /// </summary>
    Hall_of_Transference = 14,

    /// <summary>
    /// The abyssea konschtat
    /// </summary>
    Abyssea_Konschtat = 15,

    /// <summary>
    /// The promyvion holla
    /// </summary>
    Promyvion_Holla = 16,

    /// <summary>
    /// The spire of holla
    /// </summary>
    Spire_of_Holla = 17,

    /// <summary>
    /// The promyvion dem
    /// </summary>
    Promyvion_Dem = 18,

    /// <summary>
    /// The spire of dem
    /// </summary>
    Spire_of_Dem = 19,

    /// <summary>
    /// The promyvion mea
    /// </summary>
    Promyvion_Mea = 20,

    /// <summary>
    /// The spire of mea
    /// </summary>
    Spire_of_Mea = 21,

    /// <summary>
    /// The promyvion vahzl
    /// </summary>
    Promyvion_Vahzl = 22,

    /// <summary>
    /// The spire of vahzl
    /// </summary>
    Spire_of_Vahzl = 23,

    /// <summary>
    /// The lufaise meadows
    /// </summary>
    Lufaise_Meadows = 24,

    /// <summary>
    /// The misareaux coast
    /// </summary>
    Misareaux_Coast = 25,

    /// <summary>
    /// The tavnazian safehold
    /// </summary>
    Tavnazian_Safehold = 26,

    /// <summary>
    /// The phomiuna aqueducts
    /// </summary>
    Phomiuna_Aqueducts = 27,

    /// <summary>
    /// The sacrarium
    /// </summary>
    Sacrarium = 28,

    /// <summary>
    /// The riverne site B01
    /// </summary>
    Riverne_Site_B01 = 29,

    /// <summary>
    /// The riverne site a01
    /// </summary>
    Riverne_Site_A01 = 30,

    /// <summary>
    /// The monarch linn
    /// </summary>
    Monarch_Linn = 31,

    /// <summary>
    /// The sealions den
    /// </summary>
    Sealions_Den = 32,

    /// <summary>
    /// The al taieu
    /// </summary>
    AlTaieu = 33,

    /// <summary>
    /// The grand palace of hu xzoi
    /// </summary>
    Grand_Palace_of_HuXzoi = 34,

    /// <summary>
    /// The garden of ru hmet
    /// </summary>
    The_Garden_of_RuHmet = 35,

    /// <summary>
    /// The empyreal paradox
    /// </summary>
    Empyreal_Paradox = 36,

    /// <summary>
    /// The temenos
    /// </summary>
    Temenos = 37,

    /// <summary>
    /// The apollyon
    /// </summary>
    Apollyon = 38,

    /// <summary>
    /// The dynamis valkurm
    /// </summary>
    Dynamis_Valkurm = 39,

    /// <summary>
    /// The dynamis buburimu
    /// </summary>
    Dynamis_Buburimu = 40,

    /// <summary>
    /// The dynamis qufim
    /// </summary>
    Dynamis_Qufim = 41,

    /// <summary>
    /// The dynamis tavnazia
    /// </summary>
    Dynamis_Tavnazia = 42,

    /// <summary>
    /// The diorama abdhaljs ghelsba
    /// </summary>
    Diorama_Abdhaljs_Ghelsba = 43,

    /// <summary>
    /// The abdhaljs isle purgonorgo
    /// </summary>
    Abdhaljs_Isle_Purgonorgo = 44,

    /// <summary>
    /// The abyssea tahrongi
    /// </summary>
    Abyssea_Tahrongi = 45,

    /// <summary>
    /// The open sea route to al zahbi
    /// </summary>
    Open_sea_route_to_Al_Zahbi = 46,

    /// <summary>
    /// The open sea route to mhaura
    /// </summary>
    Open_sea_route_to_Mhaura = 47,

    /// <summary>
    /// The al zahbi
    /// </summary>
    Al_Zahbi = 48,

    /// <summary>
    /// The aht urhgan whitegate
    /// </summary>
    Aht_Urhgan_Whitegate = 50,

    /// <summary>
    /// The wajaom woodlands
    /// </summary>
    Wajaom_Woodlands = 51,

    /// <summary>
    /// The bhaflau thickets
    /// </summary>
    Bhaflau_Thickets = 52,

    /// <summary>
    /// The nashmau
    /// </summary>
    Nashmau = 53,

    /// <summary>
    /// The arrapago reef
    /// </summary>
    Arrapago_Reef = 54,

    /// <summary>
    /// The ilrusi atoll
    /// </summary>
    Ilrusi_Atoll = 55,

    /// <summary>
    /// The periqia
    /// </summary>
    Periqia = 56,

    /// <summary>
    /// The talacca cove
    /// </summary>
    Talacca_Cove = 57,

    /// <summary>
    /// The silver sea route to nashmau
    /// </summary>
    Silver_Sea_Route_to_Nashmau = 58,

    /// <summary>
    /// The silver sea route to al zahbi
    /// </summary>
    Silver_Sea_Route_to_Al_Zahbi = 59,

    /// <summary>
    /// The ashu talif
    /// </summary>
    The_Ashu_Talif = 60,

    /// <summary>
    /// The mount zhayolm
    /// </summary>
    Mount_Zhayolm = 61,

    /// <summary>
    /// The halvung
    /// </summary>
    Halvung = 62,

    /// <summary>
    /// The lebros cavern
    /// </summary>
    Lebros_Cavern = 63,

    /// <summary>
    /// The navukgo execution chamber
    /// </summary>
    Navukgo_Execution_Chamber = 64,

    /// <summary>
    /// The mamook
    /// </summary>
    Mamook = 65,

    /// <summary>
    /// The mamool ja training grounds
    /// </summary>
    Mamool_Ja_Training_Grounds = 66,

    /// <summary>
    /// The jade sepulcher
    /// </summary>
    Jade_Sepulcher = 67,

    /// <summary>
    /// The aydeewa subterrane
    /// </summary>
    Aydeewa_Subterrane = 68,

    /// <summary>
    /// The leujaoam sanctum
    /// </summary>
    Leujaoam_Sanctum = 69,

    /// <summary>
    /// The chocobo circuit
    /// </summary>
    Chocobo_Circuit = 70,

    /// <summary>
    /// The colosseum
    /// </summary>
    The_Colosseum = 71,

    /// <summary>
    /// The alzadaal undersea ruins
    /// </summary>
    Alzadaal_Undersea_Ruins = 72,

    /// <summary>
    /// The zhayolm remnants
    /// </summary>
    Zhayolm_Remnants = 73,

    /// <summary>
    /// The arrapago remnants
    /// </summary>
    Arrapago_Remnants = 74,

    /// <summary>
    /// The bhaflau remnants
    /// </summary>
    Bhaflau_Remnants = 75,

    /// <summary>
    /// The silver sea remnants
    /// </summary>
    Silver_Sea_Remnants = 76,

    /// <summary>
    /// The nyzul isle
    /// </summary>
    Nyzul_Isle = 77,

    /// <summary>
    /// The hazhalm testing grounds
    /// </summary>
    Hazhalm_Testing_Grounds = 78,

    /// <summary>
    /// The caedarva mire
    /// </summary>
    Caedarva_Mire = 79,

    /// <summary>
    /// The southern san d oria s
    /// </summary>
    Southern_San_dOria_S = 80,

    /// <summary>
    /// The east ronfaure s
    /// </summary>
    East_Ronfaure_S = 81,

    /// <summary>
    /// The jugner forest s
    /// </summary>
    Jugner_Forest_S = 82,

    /// <summary>
    /// The vunkerl inlet s
    /// </summary>
    Vunkerl_Inlet_S = 83,

    /// <summary>
    /// The batallia downs s
    /// </summary>
    Batallia_Downs_S = 84,

    /// <summary>
    /// The la vaule s
    /// </summary>
    La_Vaule_S = 85,

    /// <summary>
    /// The everbloom hollow
    /// </summary>
    Everbloom_Hollow = 86,

    /// <summary>
    /// The bastok markets s
    /// </summary>
    Bastok_Markets_S = 87,

    /// <summary>
    /// The north gustaberg s
    /// </summary>
    North_Gustaberg_S = 88,

    /// <summary>
    /// The grauberg s
    /// </summary>
    Grauberg_S = 89,

    /// <summary>
    /// The pashhow marshlands s
    /// </summary>
    Pashhow_Marshlands_S = 90,

    /// <summary>
    /// The rolanberry fields s
    /// </summary>
    Rolanberry_Fields_S = 91,

    /// <summary>
    /// The beadeaux s
    /// </summary>
    Beadeaux_S = 92,

    /// <summary>
    /// The ruhotz silvermines
    /// </summary>
    Ruhotz_Silvermines = 93,

    /// <summary>
    /// The windurst waters s
    /// </summary>
    Windurst_Waters_S = 94,

    /// <summary>
    /// The west sarutabaruta s
    /// </summary>
    West_Sarutabaruta_S = 95,

    /// <summary>
    /// The fort karugo narugo s
    /// </summary>
    Fort_Karugo_Narugo_S = 96,

    /// <summary>
    /// The meriphataud mountains s
    /// </summary>
    Meriphataud_Mountains_S = 97,

    /// <summary>
    /// The sauromugue champaign s
    /// </summary>
    Sauromugue_Champaign_S = 98,

    /// <summary>
    /// The castle oztroja s
    /// </summary>
    Castle_Oztroja_S = 99,

    /// <summary>
    /// The ronfaure west
    /// </summary>
    Ronfaure_West = 100,

    /// <summary>
    /// The ronfaure east
    /// </summary>
    Ronfaure_East = 101,

    /// <summary>
    /// The la theine plateau
    /// </summary>
    La_Theine_Plateau = 102,

    /// <summary>
    /// The valkurm dunes
    /// </summary>
    Valkurm_Dunes = 103,

    /// <summary>
    /// The jugner forest
    /// </summary>
    Jugner_Forest = 104,

    /// <summary>
    /// The batallia downs
    /// </summary>
    Batallia_Downs = 105,

    /// <summary>
    /// The gustaberg north
    /// </summary>
    Gustaberg_North = 106,

    /// <summary>
    /// The gustaberg south
    /// </summary>
    Gustaberg_South = 107,

    /// <summary>
    /// The konschtat highlands
    /// </summary>
    Konschtat_Highlands = 108,

    /// <summary>
    /// The pashhow marshlands
    /// </summary>
    Pashhow_Marshlands = 109,

    /// <summary>
    /// The rolanberry fields
    /// </summary>
    Rolanberry_Fields = 110,

    /// <summary>
    /// The beaucedine glacier
    /// </summary>
    Beaucedine_Glacier = 111,

    /// <summary>
    /// The xarcabard
    /// </summary>
    Xarcabard = 112,

    /// <summary>
    /// The cape teriggan
    /// </summary>
    Cape_Teriggan = 113,

    /// <summary>
    /// The altepa eastern desert
    /// </summary>
    Altepa_Eastern_Desert = 114,

    /// <summary>
    /// The sarutabaruta west
    /// </summary>
    Sarutabaruta_West = 115,

    /// <summary>
    /// The sarutabaruta east
    /// </summary>
    Sarutabaruta_East = 116,

    /// <summary>
    /// The tahrongi canyon
    /// </summary>
    Tahrongi_Canyon = 117,

    /// <summary>
    /// The buburimu peninsula
    /// </summary>
    Buburimu_Peninsula = 118,

    /// <summary>
    /// The meriphataud mountains
    /// </summary>
    Meriphataud_Mountains = 119,

    /// <summary>
    /// The sauromugue champaign
    /// </summary>
    Sauromugue_Champaign = 120,

    /// <summary>
    /// The sanctuary of zi tah
    /// </summary>
    Sanctuary_of_ZiTah = 121,

    /// <summary>
    /// The ro maeve
    /// </summary>
    RoMaeve = 122,

    /// <summary>
    /// The yuhtunga jungle
    /// </summary>
    Yuhtunga_Jungle = 123,

    /// <summary>
    /// The yhoator jungle
    /// </summary>
    Yhoator_Jungle = 124,

    /// <summary>
    /// The altepa western desert
    /// </summary>
    Altepa_Western_Desert = 125,

    /// <summary>
    /// The qufim island
    /// </summary>
    Qufim_Island = 126,

    /// <summary>
    /// The behemoths dominion
    /// </summary>
    Behemoths_Dominion = 127,

    /// <summary>
    /// The valley of sorrows
    /// </summary>
    Valley_of_Sorrows = 128,

    /// <summary>
    /// The ghoyus reverie
    /// </summary>
    Ghoyus_Reverie = 129,

    /// <summary>
    /// The ru aun gardens
    /// </summary>
    RuAun_Gardens = 130,

    /// <summary>
    /// The mordion gaol
    /// </summary>
    Mordion_Gaol = 131,

    /// <summary>
    /// The abyssea la theine
    /// </summary>
    Abyssea_La_Theine = 132,

    /// <summary>
    /// The lobby
    /// </summary>
    Lobby = 133,

    /// <summary>
    /// The dynamis beaucedine
    /// </summary>
    Dynamis_Beaucedine = 134,

    /// <summary>
    /// The dynamis xarcabard
    /// </summary>
    Dynamis_Xarcabard = 135,

    /// <summary>
    /// The beaucedine glacier s
    /// </summary>
    Beaucedine_Glacier_S = 136,

    /// <summary>
    /// The xarcabard s
    /// </summary>
    Xarcabard_S = 137,

    /// <summary>
    /// The castle zvahl baileys s
    /// </summary>
    Castle_Zvahl_Baileys_S = 138,

    /// <summary>
    /// The horlais peak
    /// </summary>
    Horlais_Peak = 139,

    /// <summary>
    /// The ghelsba outpost
    /// </summary>
    Ghelsba_Outpost = 140,

    /// <summary>
    /// The fort ghelsba
    /// </summary>
    Fort_Ghelsba = 141,

    /// <summary>
    /// The yughott grotto
    /// </summary>
    Yughott_Grotto = 142,

    /// <summary>
    /// The palborough mines
    /// </summary>
    Palborough_Mines = 143,

    /// <summary>
    /// The waughroon shrine
    /// </summary>
    Waughroon_Shrine = 144,

    /// <summary>
    /// The giddeus
    /// </summary>
    Giddeus = 145,

    /// <summary>
    /// The balgas dais
    /// </summary>
    Balgas_Dais = 146,

    /// <summary>
    /// The beadeaux
    /// </summary>
    Beadeaux = 147,

    /// <summary>
    /// The qulun dome
    /// </summary>
    Qulun_Dome = 148,

    /// <summary>
    /// The davoi
    /// </summary>
    Davoi = 149,

    /// <summary>
    /// The monastic cavern
    /// </summary>
    Monastic_Cavern = 150,

    /// <summary>
    /// The castle oztroja
    /// </summary>
    Castle_Oztroja = 151,

    /// <summary>
    /// The altar room
    /// </summary>
    Altar_Room = 152,

    /// <summary>
    /// The boyahda tree
    /// </summary>
    Boyahda_Tree = 153,

    /// <summary>
    /// The dragons aery
    /// </summary>
    Dragons_Aery = 154,

    /// <summary>
    /// The castle zvahl keep s
    /// </summary>
    Castle_Zvahl_Keep_S = 155,

    /// <summary>
    /// The throne room s
    /// </summary>
    Throne_Room_S = 156,

    /// <summary>
    /// The delkfutts middle tower
    /// </summary>
    Delkfutts_Middle_Tower = 157,

    /// <summary>
    /// The delkfutts upper tower
    /// </summary>
    Delkfutts_Upper_Tower = 158,

    /// <summary>
    /// The temple of uggalepih
    /// </summary>
    Temple_of_Uggalepih = 159,

    /// <summary>
    /// The den of rancor
    /// </summary>
    Den_of_Rancor = 160,

    /// <summary>
    /// The castle zvahl baileys
    /// </summary>
    Castle_Zvahl_Baileys = 161,

    /// <summary>
    /// The castle zvahl keep
    /// </summary>
    Castle_Zvahl_Keep = 162,

    /// <summary>
    /// The sacrificial chamber
    /// </summary>
    Sacrificial_Chamber = 163,

    /// <summary>
    /// The garlaige citadel s
    /// </summary>
    Garlaige_Citadel_S = 164,

    /// <summary>
    /// The throne room
    /// </summary>
    Throne_Room = 165,

    /// <summary>
    /// The ranguemont pass
    /// </summary>
    Ranguemont_Pass = 166,

    /// <summary>
    /// The bostaunieux oubliette
    /// </summary>
    Bostaunieux_Oubliette = 167,

    /// <summary>
    /// The chamber of oracles
    /// </summary>
    Chamber_of_Oracles = 168,

    /// <summary>
    /// The toraimarai canal
    /// </summary>
    Toraimarai_Canal = 169,

    /// <summary>
    /// The full moon fountain
    /// </summary>
    Full_Moon_Fountain = 170,

    /// <summary>
    /// The crawlers nest s
    /// </summary>
    Crawlers_Nest_S = 171,

    /// <summary>
    /// The zeruhn mines
    /// </summary>
    Zeruhn_Mines = 172,

    /// <summary>
    /// The korroloka tunnel
    /// </summary>
    Korroloka_Tunnel = 173,

    /// <summary>
    /// The kuftal tunnel
    /// </summary>
    Kuftal_Tunnel = 174,

    /// <summary>
    /// The eldieme necropolis s
    /// </summary>
    The_Eldieme_Necropolis_S = 175,

    /// <summary>
    /// The sea serpent grotto
    /// </summary>
    Sea_Serpent_Grotto = 176,

    /// <summary>
    /// The ve lugannon palace
    /// </summary>
    VeLugannon_Palace = 177,

    /// <summary>
    /// The shrine of ru avitau
    /// </summary>
    Shrine_of_RuAvitau = 178,

    /// <summary>
    /// The stellar fulcrum
    /// </summary>
    Stellar_Fulcrum = 179,

    /// <summary>
    /// The la loff amphitheater
    /// </summary>
    LaLoff_Amphitheater = 180,

    /// <summary>
    /// The celestial nexus
    /// </summary>
    The_Celestial_Nexus = 181,

    /// <summary>
    /// The walk of echoes
    /// </summary>
    Walk_of_Echoes = 182,

    /// <summary>
    /// The last stand
    /// </summary>
    The_Last_Stand = 183,

    /// <summary>
    /// The delkfutts lower tower
    /// </summary>
    Delkfutts_Lower_Tower = 184,

    /// <summary>
    /// The dynamis san d oria
    /// </summary>
    Dynamis_San_dOria = 185,

    /// <summary>
    /// The dynamis bastok
    /// </summary>
    Dynamis_Bastok = 186,

    /// <summary>
    /// The dynamis windurst
    /// </summary>
    Dynamis_Windurst = 187,

    /// <summary>
    /// The dynamis jeuno
    /// </summary>
    Dynamis_Jeuno = 188,

    /// <summary>
    /// The king ranperres tomb
    /// </summary>
    King_Ranperres_Tomb = 190,

    /// <summary>
    /// The dangruf wadi
    /// </summary>
    Dangruf_Wadi = 191,

    /// <summary>
    /// The horutoto inner ruins
    /// </summary>
    Horutoto_Inner_Ruins = 192,

    /// <summary>
    /// The ordelles caves
    /// </summary>
    Ordelles_Caves = 193,

    /// <summary>
    /// The outer horutoto ruins
    /// </summary>
    Outer_Horutoto_Ruins = 194,

    /// <summary>
    /// The eldieme necropolis
    /// </summary>
    Eldieme_Necropolis = 195,

    /// <summary>
    /// The gusgen mines
    /// </summary>
    Gusgen_Mines = 196,

    /// <summary>
    /// The crawlers nest
    /// </summary>
    Crawlers_Nest = 197,

    /// <summary>
    /// The maze of shakhrami
    /// </summary>
    Maze_of_Shakhrami = 198,

    /// <summary>
    /// The garlaige citadel
    /// </summary>
    Garlaige_Citadel = 200,

    /// <summary>
    /// The cloister of gales
    /// </summary>
    Cloister_of_Gales = 201,

    /// <summary>
    /// The cloister of storms
    /// </summary>
    Cloister_of_Storms = 202,

    /// <summary>
    /// The cloister of frost
    /// </summary>
    Cloister_of_Frost = 203,

    /// <summary>
    /// The fei yin
    /// </summary>
    FeiYin = 204,

    /// <summary>
    /// The ifrits cauldron
    /// </summary>
    Ifrits_Cauldron = 205,

    /// <summary>
    /// The qu bia arena
    /// </summary>
    QuBia_Arena = 206,

    /// <summary>
    /// The cloister of flames
    /// </summary>
    Cloister_of_Flames = 207,

    /// <summary>
    /// The quicksand caves
    /// </summary>
    Quicksand_Caves = 208,

    /// <summary>
    /// The cloister of tremors
    /// </summary>
    Cloister_of_Tremors = 209,

    /// <summary>
    /// The cloister of tides
    /// </summary>
    Cloister_of_Tides = 211,

    /// <summary>
    /// The gustav tunnel
    /// </summary>
    Gustav_Tunnel = 212,

    /// <summary>
    /// The labyrinth of onzozo
    /// </summary>
    Labyrinth_of_Onzozo = 213,

    /// <summary>
    /// The abyssea attohwa
    /// </summary>
    Abyssea_Attohwa = 215,

    /// <summary>
    /// The abyssea misareaux
    /// </summary>
    Abyssea_Misareaux = 216,

    /// <summary>
    /// The abyssea vunkerl
    /// </summary>
    Abyssea_Vunkerl = 217,

    /// <summary>
    /// The abyssea altepa
    /// </summary>
    Abyssea_Altepa = 218,

    /// <summary>
    /// The ferry between mhaura selbina
    /// </summary>
    Ferry_between_Mhaura__Selbina = 220,

    /// <summary>
    /// The ferry between selbina mhaura
    /// </summary>
    Ferry_between_Selbina__Mhaura = 221,

    /// <summary>
    /// The provenance
    /// </summary>
    Provenance = 222,

    /// <summary>
    /// The airship from san d oria to jeuno
    /// </summary>
    Airship_from_San_dOria_to_Jeuno = 223,

    /// <summary>
    /// The airship from bastok to jeuno
    /// </summary>
    Airship_from_Bastok_to_Jeuno = 224,

    /// <summary>
    /// The airship from windurst to jeuno
    /// </summary>
    Airship_from_Windurst_to_Jeuno = 225,

    /// <summary>
    /// The airship from kazham to jeuno
    /// </summary>
    Airship_from_Kazham_to_Jeuno = 226,

    /// <summary>
    /// The ferry between mhaura selbina pirates
    /// </summary>
    Ferry_between_Mhaura__Selbina_Pirates = 227,

    /// <summary>
    /// The ferry between selbina mhaura pirates
    /// </summary>
    Ferry_between_Selbina__Mhaura_Pirates = 228,

    /// <summary>
    /// The southern san d oria
    /// </summary>
    Southern_San_dOria = 230,

    /// <summary>
    /// The northern san d oria
    /// </summary>
    Northern_San_dOria = 231,

    /// <summary>
    /// The port san d oria
    /// </summary>
    Port_San_dOria = 232,

    /// <summary>
    /// The chateau d oraguille
    /// </summary>
    Chateau_dOraguille = 233,

    /// <summary>
    /// The bastok mines
    /// </summary>
    Bastok_Mines = 234,

    /// <summary>
    /// The bastok markets
    /// </summary>
    Bastok_Markets = 235,

    /// <summary>
    /// The port bastok
    /// </summary>
    Port_Bastok = 236,

    /// <summary>
    /// The metalworks
    /// </summary>
    Metalworks = 237,

    /// <summary>
    /// The windurst waters
    /// </summary>
    Windurst_Waters = 238,

    /// <summary>
    /// The windurst walls
    /// </summary>
    Windurst_Walls = 239,

    /// <summary>
    /// The port windurst
    /// </summary>
    Port_Windurst = 240,

    /// <summary>
    /// The windurst woods
    /// </summary>
    Windurst_Woods = 241,

    /// <summary>
    /// The heavens tower
    /// </summary>
    Heavens_Tower = 242,

    /// <summary>
    /// The ru lude gardens
    /// </summary>
    Ru_Lude_Gardens = 243,

    /// <summary>
    /// The upper jeuno
    /// </summary>
    Upper_Jeuno = 244,

    /// <summary>
    /// The lower jeuno
    /// </summary>
    Lower_Jeuno = 245,

    /// <summary>
    /// The port jeuno
    /// </summary>
    Port_Jeuno = 246,

    /// <summary>
    /// The rabao
    /// </summary>
    Rabao = 247,

    /// <summary>
    /// The selbina
    /// </summary>
    Selbina = 248,

    /// <summary>
    /// The mhaura
    /// </summary>
    Mhaura = 249,

    /// <summary>
    /// The kazham
    /// </summary>
    Kazham = 250,

    /// <summary>
    /// The hall of the gods
    /// </summary>
    Hall_of_the_Gods = 251,

    /// <summary>
    /// The norg
    /// </summary>
    Norg = 252,

    /// <summary>
    /// The abyssea uleguerand
    /// </summary>
    Abyssea_Uleguerand = 253,

    /// <summary>
    /// The abyssea grauberg
    /// </summary>
    Abyssea_Grauberg = 254,

    /// <summary>
    /// The abyssea empyreal paradox
    /// </summary>
    Abyssea_Empyreal_Paradox = 255,

    /// <summary>
    /// The western adoulin
    /// </summary>
    Western_Adoulin = 256,

    /// <summary>
    /// The eastern adoulin
    /// </summary>
    Eastern_Adoulin = 257,

    /// <summary>
    /// The rala waterways
    /// </summary>
    Rala_Waterways = 258,

    /// <summary>
    /// The rala waterways u
    /// </summary>
    Rala_Waterways_U = 259,

    /// <summary>
    /// The yahse hunting grounds
    /// </summary>
    Yahse_Hunting_Grounds = 260,

    /// <summary>
    /// The ceizak battlegrounds
    /// </summary>
    Ceizak_Battlegrounds = 261,

    /// <summary>
    /// The foret de hennetiel
    /// </summary>
    Foret_de_Hennetiel = 262,

    /// <summary>
    /// The yorcia weald
    /// </summary>
    Yorcia_Weald = 263,

    /// <summary>
    /// The yorcia weald u
    /// </summary>
    Yorcia_Weald_U = 264,

    /// <summary>
    /// The morimar basalt fields
    /// </summary>
    Morimar_Basalt_Fields = 265,

    /// <summary>
    /// The marjami ravine
    /// </summary>
    Marjami_Ravine = 266,

    /// <summary>
    /// The kamihr drifts
    /// </summary>
    Kamihr_Drifts = 267,

    /// <summary>
    /// The sih gates
    /// </summary>
    Sih_Gates = 268,

    /// <summary>
    /// The moh gates
    /// </summary>
    Moh_Gates = 269,

    /// <summary>
    /// The cirdas caverns
    /// </summary>
    Cirdas_Caverns = 270,

    /// <summary>
    /// The cirdas caverns u
    /// </summary>
    Cirdas_Caverns_U = 271,

    /// <summary>
    /// The dho gates
    /// </summary>
    Dho_Gates = 272,

    /// <summary>
    /// The woh gates
    /// </summary>
    Woh_Gates = 273,

    /// <summary>
    /// The outer ra kaznar
    /// </summary>
    Outer_RaKaznar = 274,

    /// <summary>
    /// The outer ra kaznar u
    /// </summary>
    Outer_RaKaznar_U = 275,

    /// <summary>
    /// The ra kaznar inner court
    /// </summary>
    RaKaznar_Inner_Court = 276,

    /// <summary>
    /// The mog garden
    /// </summary>
    Mog_Garden = 280,

    /// <summary>
    /// The silver knife
    /// </summary>
    Silver_Knife = 283,

    /// <summary>
    /// The celennia wexworth memorial library
    /// </summary>
    Celennia_Wexworth_Memorial_Library = 284,

    /// <summary>
    /// The feretory
    /// </summary>
    Feretory = 285,

    /// <summary>
    /// The escha zi tah
    /// </summary>
    Escha_ZiTah = 288,
}

/// <summary>
/// Struct Position
/// </summary>
public struct Position
{
    /// <summary>
    /// Gets or sets the h.
    /// </summary>
    /// <value>The h.</value>
    public float H { get; set; }

    /// <summary>
    /// Gets or sets the x.
    /// </summary>
    /// <value>The x.</value>
    public float X { get; set; }

    /// <summary>
    /// Gets or sets the y.
    /// </summary>
    /// <value>The y.</value>
    public float Y { get; set; }

    /// <summary>
    /// Gets or sets the z.
    /// </summary>
    /// <value>The z.</value>
    public float Z { get; set; }
}

// @ public enum ChatMode : short

/// <summary>
/// Class Chatentry.
/// </summary>
public class Chatentry
{
    /// <summary>
    /// Gets or sets the color of the chat.
    /// </summary>
    /// <value>The color of the chat.</value>
    public Color ChatColor { get; set; }

    /// <summary>
    /// Gets or sets the type of the chat.
    /// </summary>
    /// <value>The type of the chat.</value>
    public int ChatType { get; set; }

    /// <summary>
    /// Gets or sets the index1.
    /// </summary>
    /// <value>The index1.</value>
    public int Index1 { get; set; }

    /// <summary>
    /// Gets or sets the index2.
    /// </summary>
    /// <value>The index2.</value>
    public int Index2 { get; set; }

    /// <summary>
    /// Gets or sets the length.
    /// </summary>
    /// <value>The length.</value>
    public int Length { get; set; }

    /// <summary>
    /// Gets or sets the raw line.
    /// </summary>
    /// <value>The raw line.</value>
    public string RawLine { get; set; }

    /// <summary>
    /// Gets or sets the raw text.
    /// </summary>
    /// <value>The raw text.</value>
    public string RawText { get; set; }

    /// <summary>
    /// Gets or sets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text { get; set; }

    /// <summary>
    /// Gets or sets the timestamp.
    /// </summary>
    /// <value>The timestamp.</value>
    public DateTime Timestamp { get; set; }
}

// @ public enum Status : byte

// @ public enum Zone : short

// @ public enum SpellList : short

// @ public enum AbilityList : byte @ public enum NPCType

/// <summary>
/// Class Structures.
/// </summary>
public class Structures
{
    /// <summary>
    /// Stats of the player
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PlayerStats
    {
        /// <summary>
        /// The string
        /// </summary>
        public short Str;

        /// <summary>
        /// The dex
        /// </summary>
        public short Dex;

        /// <summary>
        /// The vit
        /// </summary>
        public short Vit;

        /// <summary>
        /// The agi
        /// </summary>
        public short Agi;

        /// <summary>
        /// The int
        /// </summary>
        public short Int;

        /// <summary>
        /// The MND
        /// </summary>
        public short Mnd;

        /// <summary>
        /// The character
        /// </summary>
        public short Chr;
    }

    // @ public struct PlayerStats
}