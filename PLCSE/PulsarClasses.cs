using ObscuredLong = System.Int64;
using ObscuredInt = System.Int32;
using ObscuredUInt = System.UInt32;
using ObscuredShort = System.Int16;
using ObscuredByte = System.Byte;
using ObscuredBool = System.Boolean;
using ObscuredVector3 = PLCSE.Vector3;
using ObscuredString = System.String;
using ObscuredFloat = System.Single;

namespace PLCSE
{
	public class PLPlayerDroppedItem
	{
		public PLPlayerDroppedItem(uint hash, Vector3 pos, int itemID)
		{
			this.ItemHash = hash;
			this.Position = pos;
			this.DroppedItemID = itemID;
		}

		public uint ItemHash;
		public Vector3 Position;
		public int DroppedItemID;
	}

	public class PawnItemDataBlock
	{
		public EPawnItemType ItemType;

		public int SubType;

		public int Level;

		public int OptionalEquipID;
	}


	public class ClassDataBlock
	{
		public int SurvivalBonusCounter;

		public int TalentPointsAvailable;

		public int[] Talents;

		public List<PawnItemDataBlock> PawnInventory;
	}

	public class MissionDataBlock
	{
		public int MissionID;

		public bool Abandoned;

		public bool Ended;

		public bool[] ObjectivesCompleted;

		public int[] ObjectivesAmountCompleted;

		public int[] ObjectivesAmountNeeded;

		public bool[] ObjectivesShownCompletedMessage;

		public bool IsPickupMission;

		public bool RanStartRewards;
	}

	public class PDADataBlock
	{
		public int Type;

		public string ActorID = "";

		public string NPCName = "";

		public string ShipName = "";

		public bool SpecialActionCompleted;

		public bool Hostile;

		public List<int> LinesAlreadyDisplayed = new List<int>();

		public List<int> LinesToShowPercent = new List<int>();
	}

	public struct FactionDataBlock
	{
		public int ID;

		public float Continuous_GalaxySpreadLimit;

		public float Continuous_GalaxySpreadFactor;
	}

	public struct SectorDataBlock
	{
		public int ID;

		public int Type;

		public float FactionStrength;

		public int Faction;

		public Vector3 SectorPosition;

		public string SectorName;

		public int MissionSpecificID;

		public bool LockedToFaction;

		public float LastCalculatedSectorStrength;

		public bool IsPartOfLongRangeWarpNetwork;

		public PLPersistantEncounterData PED;

		public bool HasPED;

		public bool Visited;

		public int BiscuitsSoldCounter;

		public List<PLPlayerDroppedItem_WithTLIData> DroppedItems;

		public byte[] AdditionalSaveData;
	}

	public class PLPlayerDroppedItem_WithTLIData : PLPlayerDroppedItem
	{
		public PLPlayerDroppedItem_WithTLIData(uint hash, Vector3 pos, int itemID, int subhubID, int interiorID)
			: base(hash, pos, itemID)
		{
			this.SubHubID = subhubID;
			this.InteriorID = interiorID;
		}

		public int SubHubID;

		public int InteriorID;
	}

	public class PLPersistantEncounterData
    {
		public Dictionary<ObscuredInt, TraderPersistantDataEntry> m_TraderInfoDictionary = new Dictionary<ObscuredInt, TraderPersistantDataEntry>();

		public Dictionary<ObscuredInt, PLSpecialEncounterNetObjectPersistantData> m_SpecialNetObjectPersistantData = new Dictionary<ObscuredInt, PLSpecialEncounterNetObjectPersistantData>();

		public Dictionary<ObscuredInt, ObscuredBool> m_PickupObjectPersistantData = new Dictionary<ObscuredInt, ObscuredBool>();

		public Dictionary<ObscuredInt, ObscuredBool> m_PickupComponentPersistantData = new Dictionary<ObscuredInt, ObscuredBool>();

		public Dictionary<ObscuredInt, ObscuredBool> m_PickupRandomComponentPersistantData = new Dictionary<ObscuredInt, ObscuredBool>();

		public Dictionary<ObscuredInt, ObscuredBool> m_ProbePickupPersistantData = new Dictionary<ObscuredInt, ObscuredBool>();

		public Dictionary<ObscuredString, PLDPOPersistantData> m_DPOPersistantData = new Dictionary<ObscuredString, PLDPOPersistantData>();

		public Dictionary<ObscuredString, PLDSOPersistantData> m_DSOPersistantData = new Dictionary<ObscuredString, PLDSOPersistantData>();

		public Dictionary<ObscuredString, ObscuredString> m_MiscPersistantData = new Dictionary<ObscuredString, ObscuredString>();
	}

	public class TraderPersistantDataEntry
    {
		public int ServerWareIDCounter;

		public Dictionary<int, PLWare> m_Wares = new Dictionary<int, PLWare>();

		public Dictionary<int, PLWare> m_Specials = new Dictionary<int, PLWare>();

		public int m_LastSpecialRefreshJumpID = -1;

        internal void ServerAddWare(PLWare inShipComp)
        {
			inShipComp.NetID = this.ServerWareIDCounter;
			m_Wares.Add(this.ServerWareIDCounter, inShipComp);
			this.ServerWareIDCounter++;
		}
    }

	public class PLWare
    {
		public int NetID;
		public uint type;
		public uint subtype;
		public uint level;
		public uint subtypedata;
		public uint visualSlotType;
		public int isComp;

		public static void GetPawnInfoFromHash(int inHash, out uint actualSlotTypePart, out uint subTypePart, out uint levelPart)
		{
			actualSlotTypePart = (uint)(inHash & 63);
			subTypePart = ((uint)inHash >> 6) & 63U;
			levelPart = ((uint)inHash >> 12) & 15U;
		}

		public static PLWare CreateFromHash(int inWareType, int inHash)
		{
			if (inWareType == 0)
			{
				GetPawnInfoFromHash(inHash, out uint actualSlotTypePart, out uint subTypePart, out uint levelPart);
				return new PLWare() { type = actualSlotTypePart, subtype = subTypePart, level = levelPart, isComp = 0 };
			}
			if (inWareType != 1)
			{
				return null;
			}
			uint type = (uint)(inHash & 63);
			uint subtype = ((uint)inHash >> 6) & 63U;
			uint level = ((uint)inHash >> 12) & 31U;
			uint num4 = ((uint)inHash >> 17) & 63U;
			uint num5 = ((uint)inHash >> 23) & 63U;
			return new PLWare() { type = type, subtype = subtype, level = level, subtypedata = num4, visualSlotType = num5, isComp = 1 };
		}

		public uint getHash()
        {
			if (isComp == 1)
			{
				uint num = (uint)(type & 63);
				uint num2 = (uint)((uint)(this.subtype & 63) << 6);
				uint num3 = (uint)((uint)(this.level & 31) << 12);
				uint num4 = (uint)((uint)(this.subtypedata & 63) << 17);
				uint num5 = (uint)((uint)(this.visualSlotType & 63) << 23);
				return num | num2 | num3 | num4 | num5;
			}
			else
            {
				uint num = (uint)(this.type & 63);
				uint num2 = (uint)((uint)(this.subtype & 63) << 6);
				uint num3 = (uint)((uint)(this.level & 15) << 12);
				return num | num2 | num3;
			}
        }
	}

	public class PLSpecialEncounterNetObjectPersistantData
	{
		public ObscuredBool PersistantState;
	}

	public class PLDSOPersistantData
	{
		public ObscuredBool DestroyedMsgSent;

		public ObscuredFloat Health;
	}

	public class PLDPOPersistantData
	{
		public ObscuredBool	 DestroyedMsgSent;

		public ObscuredBool RepairedMsgSent;

		public ObscuredFloat Health;
	}

	public struct ShipDataBlock
	{
		public ObscuredInt ShipType;

		public ObscuredInt FactionID;

		public ObscuredInt SectorID;

		public bool IsDestroyed;

		public string ShipName;

		public List<ComponentOverrideData> CompOverrides;

		public float HullPercent;

		public float ShldPercent;

		public ObscuredInt Modifiers;

		public bool IsFlagged;

		public bool ForceHostile;

		public bool ForceHostileAll;

		public string ForceHostileName;

		public string SelectedActorID;

		public ObscuredInt BiscuitsSold;

		public bool WonFBContest;

		public bool EnsureNoCrew;

		public bool IsRelicHunter;

		public string RH_Data;

		public string RH_Crew;
	}

	public class ComponentOverrideData
	{
		public bool ReplaceExistingComp;

		public int CompTypeToReplace;

		public int CompSubTypeToReplace;

		public int SlotNumberToReplace;

		public int CompType;

		public int CompSubType;

		public int CompLevel;

		public bool IsCargo;
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
}
