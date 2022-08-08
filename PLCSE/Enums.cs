﻿namespace PLCSE
{
	public enum EPawnItemType
	{
		E_HANDS,
		E_LASERPISTOL,
		E_PHASEPISTOL,
		E_REPAIRGUN,
		E_FIREGUN,
		E_FOOD,
		E_ARTIFACT,
		E_PIERCING_BEAM_PISTOL,
		E_SMUGGLERS_PISTOL,
		E_BURST_PISTOL,
		E_RANGER,
		E_HEAVY_PISTOL,
		E_HAND_SHOTGUN,
		E_ARMOR,
		E_JETPACK,
		E_QUEST_ITEM,
		E_SCANNER,
		E_RESEARCH_MAT,
		E_KEYCARD,
		E_PULSE_GRENADE,
		E_HEAL_GRENADE,
		E_MINI_GRENADE,
		E_ANTIFIRE_GRENADE,
		E_REPAIR_GRENADE,
		E_FB_SELL_TOOL,
		E_HELD_BEAM_PISTOL,
		E_HELD_BEAM_PISTOL_W_HEALING,
		E_STUN_GRENADE,
		E_VORTEX_GRENADE,
		E_ICE_SPIKES,
		E_WD_HEAVY,
		E_AMMO_CLIP,
		E_BATTERY,
		E_SYRINGE
	}

	public enum ETalents
	{
		HEALTH_BOOST,
		OXYGEN_TRAINING,
		PISTOL_DMG_BOOST,
		QUICK_RESPAWN,
		ADVANCED_OPERATOR,
		CAP_CREW_SPEED_BOOST,
		CAP_SCAVENGER,
		CAP_SHOP_DISCOUNTS,
		PIL_SHIP_SPEED,
		PIL_SHIP_TURNING,
		PIL_KEEN_EYES,
		SCI_SENSOR_BOOST,
		SCI_SENSOR_HIDE,
		SCI_HEAL_NEARBY,
		SCI_FREQ_AMPLIFIER,
		WPNS_TURRET_BOOST,
		WPNS_INTIMIDATION,
		WPNS_MISSILE_EXPERT,
		WPNS_RANGE_BOOST,
		ENG_FIRE_REDUCTION,
		ENG_COOLANT_MIX_CUSTOM,
		ENG_REPAIR_DRONES,
		INC_STAMINA,
		WPNS_COOLING,
		INC_JETPACK,
		WPNS_REDUCE_PAWN_DMG,
		INC_MAX_WEIGHT,
		CAP_ARMOR_BOOST,
		SCI_RESEARCH_SPECIALTY,
		ENG_WARP_CHARGE_BOOST,
		INC_TURRET_ZOOM,
		INC_HEALING_RATE,
		INC_ENEMY_ATRIUM_HEAL,
		SCI_SCANNER_RESEARCH_MAT,
		SCI_SCANNER_PICKUPS,
		PIL_REDUCE_SYS_DAMAGE,
		PIL_REDUCE_HULL_DAMAGE,
		INC_ALLOW_ENCUMBERED_SPRINT,
		WPNS_BOOST_CREW_TURRET_CHARGE,
		WPNS_BOOST_CREW_TURRET_DAMAGE,
		ANTI_RAD_INJECTION,
		ENG_AUX_POWER_BOOST,
		CAP_DIPLOMACY,
		CAP_INTIMIDATION,
		ENG_SALVAGE,
		ENG_COREPOWERBOOST,
		ENG_CORECOOLINGBOOST,
		CAP_SCREEN_DEFENSE,
		WPN_SCREEN_HACKER,
		WPN_AMMO_BOOST,
		CAP_SCREEN_SAFETY,
		SENSOR_DISH_CERT,
		SCI_PROBE_XP,
		SCI_PROBE_COOLDOWN,
		ITEM_UPGRADER_OPERATOR,
		COMPONENT_UPGRADER_OPERATOR,
		ARMOR_BOOST,
		HEALTH_BOOST_2,
		ARMOR_BOOST_2,
		WPNS_RELOAD_SPEED,
		WPNS_RELOAD_SPEED_2,
		E_TURRET_COOLING_CREW_ENGINEER,
		E_TURRET_COOLING_CREW_WEAPONS,
		MAX
	}

	public enum ESlotType
	{
		E_COMP_NONE,
		E_COMP_SHLD,
		E_COMP_WARP,
		E_COMP_REACTOR,
		E_COMP_TELE,
		E_COMP_SENS,
		E_COMP_HULL,
		E_COMP_CPU,
		E_COMP_O2,
		E_COMP_THRUSTER,
		E_COMP_TURRET,
		E_COMP_MAINTURRET,
		E_COMP_CARGO,
		E_COMP_HIDDENCARGO,
		E_COMP_AIRLOCK,
		E_COMP_REAC_COOLING,
		E_COMP_HULLPLATING,
		E_COMP_PROGRAM,
		E_COMP_VIRUS,
		E_COMP_NUCLEARDEVICE,
		E_COMP_TRACKERMISSILE,
		E_COMP_SCRAP,
		E_COMP_DISTRESS_SIGNAL,
		E_COMP_MISSION_COMPONENT,
		E_COMP_AUTO_TURRET,
		E_COMP_INERTIA_THRUSTER,
		E_COMP_MANEUVER_THRUSTER,
		E_COMP_CAPTAINS_CHAIR,
		E_COMP_SALVAGE_SYSTEM,
		E_COMP_BISCUIT_CRATE,
		E_COMP_FB_RECIPE,
		E_COMP_BISCUIT_BOMB,
		E_COMP_SENSORDISH,
		E_COMP_CLOAKING_SYS,
		E_COMP_POLYTECH_MODULE,
		E_POWERED_ARMOR,
		E_COMP_ID_MAX
	}

	public enum CompType : uint
	{
		Shields = 1,
		WarpDrive = 2,
		Reactor = 3,
		Sensor = 5,
		Hull = 6,
		CPU = 7,
		Oxygen = 8,
		Thruster = 9,
		Turret = 10,
		MainTurret = 11,
		HullPlating = 16,
		Program = 17,
		Nuclear = 19,
		Missle = 20,
		Scrap = 21,
		DistressSignal = 22,
		Mission = 23,
		AutoTurret = 24,
		InertiaThruster = 25,
		ManeuverThruster = 26,
		CaptainChair = 27,
		Extractor = 28,
		FBRecipe = 30,
		BiscuitBomb = 31,
		SensorDish = 32
	}
}
