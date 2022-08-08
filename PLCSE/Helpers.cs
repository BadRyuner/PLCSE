namespace PLCSE
{
	public static class Helpers 
	{
		// to get all strings from c# file -> (^[^""]*\n)(^[^""]*)*(\n)*
		private static string[] ShieldNames = new[] { "Tactical Holoscreen", "Heavy Tactical Holoscreen", "C.G.F. Mini Shield Generator", "C.G.F. Light Shield Generator", "C.G.F. Heavy Shield Generator", "Military-Grade Shield Generator", "G.T.C. Blue Goose", "W.D. Corp Particle Shield", "Reinforced Particle Shield", "Beam Shields", "Second Hull", "Superior Beam Shields", "Corbin's Wall", "Fortified Holoscreen", "Dense Particle Shield", "Tetragonal Surface Projector", "WD XC-7 Prototype Config 4", "Modified Military-Grade Shield Generator", "Sylvassi Shields", "Polytech Shields" };
		private static string[] WarpDriveNames = new[] { "Standard Jump Module", "Long Range Jump Module", "G.T.C. Snappy Cricket", "G.T.C. Silent Cricket", "Ludicrous Range Jump Module", "\"Workhorse\" Jump Drive", "G.T.C. Custom", "W.D. Jump Drive", "W.D. Military Jump Drive", "Dark Drive", "Snap Drive", "Explorers United Jump Drive", "WD XW-5 Prototype Config 1", "Old Wars Super Jumper", "URV Drive", };
		private static string[] ReactorNames = new[] { "Null Point Reactor", "Reinforced Null Point Reactor", "Colonial Fusion Reactor", "Military-Grade Fusion Reactor", "Fluffy Biscuit Jumbo Reactor", "G.T.C. Quiet Cupcake", "Advanced Fusion Reactor", "P.F. Anti-Matter Reactor", "Ancient Reactor", "Roland Reactor", "ThermoCore Reactor", "Strongpoint Reactor", "Leaky Reactor", "Sylvassi Reactor", "P.F. Anti-Matter Reactor (Unmodified)" };
		private static string[] HullNames = new[] { "C.C.G. Light Hull", "C.C.G. Hull", "C.C.G. Hull - Military Grade", "Nano-Active Hull", "Sentry Drone Hull", "Infected Carrier Hull", "W.D. Destroyer Hull", "Phase Drone Hull", "Layered Hull", "Nano Machines", "Infected Fighter Hull", "Deathwarden Hull", "Discount C.C.G. Hull", "Interceptor Hull", "Warp Guardian Hull", "Polytech Hull", "URV Hull" };
		private static string[] CPUNames = new[] { "ARX-JP", "ARX-SCP", "ARX-CD", "QDI-RCG", "BKP-HEAT", "BKP-WARP", "BKP-THRUST", "BKP-WPN-POWER", "ARX-TGT", "QDI-FIX-ENG", "QDI-FIX-WPN", "QDI-FIX-LIFE", "QDI-FIX-SCI", "Research Pipeline Module", "Improved Defenses", "Sylvassi Cyber Defense Processor", "Warp Range Processor", "Overcharge Processor", "'Second Wind'", "Scrapper Processor", "Teleport To: Captain", "Teleport To: Pilot", "Teleport To: Scientist", "Teleport To: Weapons Specialist", "Teleport To: Engineer", "PWR-48", "SHD-28", "QCK-90", "Combo Processor", "ARX-CWR" };
		private static string[] ThrusterNames = new[] { "The \"Adelaide\" Thruster", "Performance Vector Thruster", "Small Vector Thruster", "Racing Thruster", "Dark Thruster", "URV Propeller" };
		private static string[] TurretNames = new[] { "Railgun Turret", "Laser Turret", "Plasma Turret", "Spreadshot Turret", "Focused Laser Turret", "Burst Turret","Ancient Laser Turret", "Spore Turret", "Lightning Turret", "Missile Turret", "Phase Turret", "Defender Turret", "Flamelance Turret", "Bio-Hazard Turret", "Scrapper Turret", "Sylvassi Turret", "Ancient Railgun Turret", "URV Turret", "Warden Turret" };
		private static string[] MainTurretNames = new[] { "Main Turret", "CU Long Range", "Keeper Beam", "RapidFire", "W.D. Prototype \"FlashFire\"", "Modified CU Long Range", "Retrofitted Coil Gun", "URV Heavy Turret" };
		private static string[] ProgramNames = new[] { "Sitting Duck [VIRUS]", "Warp Disable [VIRUS]", "Phalanx [VIRUS]", "Backdoor [VIRUS]", "Emergency Shield Boosting", "Instant Warp Charge", "Instant System Self-Healing", "Instant AntiVirus", "Gentleman's Welcome [VIRUS]", "Siphon Credits [VIRUS]", "0x84B7A2 [VIRUS]", "0xF592B1 [VIRUS]", "Capacitor", "Thrust Booster", "Detector", "Block Long Range Comms", "Barrage", "OverDrive", "Syber's Shield [VIRUS]", "Syber's Threat", "Armor Flaw [VIRUS]", "Shutdown Defenses [VIRUS]", "Discharge", "Digital Coolant", "Quantum Defenses", "Shock The System", "Reinstall++", "Quantum Tunnel", "Extended Shields", "Burst AV", "Sylvassi Capacitor", "Random Access", "Active Reset", "SyberWar", "Military-Grade Shield Boosting", "EMP", "Depressurize", "Fix", "Drain", };
		private static string[] NukeNames = new[] { "W.D. Small", "W.D. Large", "C.U. Enforcer", "C.U. Peacekeeper", "Project Megaton", "Tactical Nuke" };
		private static string[] TrackerNames = new[] { "Tracker Missile", "W.D. Special", "Shield Piercer", "Reactor Buster", "Straight Shot", "Acid Missile", "Armor Piercing Missile", "System Damage Missile", "F.B. Missile", "Torpedo" };
		private static string[] InertiaThrusterNames = new[] { "Inertia Thruster", "Mini Inertia Thruster", "Infected Inertia Thruster", "Super Inertia Thruster", "Gimbal Inertia Thruster" };
		private static string[] ManeuverThrusterNames = new[] { "Maneuvering Thruster", "Heavy Maneuvering Thruster" , "Racing Maneuvering Thruster" };
		private static string[] CaptainChairNames = new[] { "Colonial Classic Captain's Chair", "Colonial Modern Captain's Chair", "W.D. Classic Captain's Chair" };
		private static string[] ExtractorNames = new[] { "StarSalvage E40", "StarSalvage E70", "The Remover", "StarSalvage E900", "P.T. Extractor"};

		public static string DecodeNameForComponent(uint inHash)
		{
			uint type = (uint)(inHash & 63);
			uint subtype = ((uint)inHash >> 6) & 63U;
			uint level = (((uint)inHash >> 12) & 31U) + 1;
			//uint insubtype = ((uint)inHash >> 17) & 63U;
			//uint visualslottype = ((uint)inHash >> 23) & 63U;

			try
			{
				switch (type)
				{
					case 1:
						return ShieldNames[subtype] + $" {level} lvl";
					case 2:
						return WarpDriveNames[subtype] + $" {level} lvl";
					case 3:
						return ReactorNames[subtype] + $" {level} lvl";
					case 5:
						return "Electromagnetic Sensor" + $" {level} lvl";
					case 6:
						return HullNames[subtype] + $" {level} lvl";
					case 7:
						return CPUNames[subtype] + $" {level} lvl";
					case 8:
						return $"{(type == 0 ? "Standard O2 Generator" : type == 1 ? "\"Calypso\" O2 Generator" : "Modded Oxygen Generator")} {level} lvl";
					case 9:
						return ThrusterNames[subtype] + $" {level} lvl";
					case 10:
						return TurretNames[subtype] + $" {level} lvl";
					case 11:
						return MainTurretNames[subtype] + $" {level} lvl";
					case 17:
						return ProgramNames[subtype] + $" {level} lvl";
					case 19:
						return NukeNames[subtype] + $" {level} lvl";
					case 20:
						return TrackerNames[subtype] + $" {level} lvl";
					case 21:
						return $"Scrap {level} lvl";
					case 23:
						return "Unknown Mission Component";
					case 24:
						return $"Automated Railgun Turret {level} lvl";
					case 25:
						return InertiaThrusterNames[subtype] + $" {level} lvl";
					case 26:
						return ManeuverThrusterNames[subtype] + $" {level} lvl";
					case 27:
						return CaptainChairNames[subtype] + $" {level} lvl";
					case 28:
						return ExtractorNames[subtype] + $" {level} lvl";
					case 31:
						return $"Biscuit Bomb {level} lvl";
					case 32:
						return $"Sensord Dish {level} lvl";
					case 33:
						return $"{(subtype == 1 ? "Sylvassi" : null)} Cloaking System {level} lvl";
					default:
						return $"Unknown Component {level} lvl";
				}
			}
			catch
			{
				return $"Unknown or Modded {level} lvl";
			}
		}
	}
}
