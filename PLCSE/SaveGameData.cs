using ObscuredLong = System.Int64;
using ObscuredInt = System.Int32;
using ObscuredUInt = System.UInt32;
using ObscuredShort = System.Int16;
using ObscuredByte = System.Byte;
using ObscuredBool = System.Boolean;
using ObscuredVector3 = PLCSE.Vector3;
using ObscuredString = System.String;
using ObscuredFloat = System.Single;

using System.Collections;
using PLCSE;

namespace PLCSE
{
	public class SaveGameData : SaveGameDataBasic
	{
		//public bool[] TalentsArray = new bool[64];

		public void AfterRead()
        {
			//for (int i = 0; i < TalentsArray.Length; i++) TalentsArray[i] = (TalentLockedStatus & (1L << i)) == 1;
			int counter = 1;
			foreach (var i in ClassData)
			{
				if (i != null)
				{
					i._id = counter;
					counter++;
				}
			}
        }

		public void BeforeWrite()
        {
			
        }

		public ObscuredInt[] FactionRepInfo;

		public ObscuredBool BiscuitContestIsOver;

		public ObscuredVector3 StormPosition;

		public ObscuredInt RacesWonBitfield;

		public ObscuredInt RacesLostBitfield;

		public ObscuredInt RacesStartedBitfield;

		public ObscuredString GameName;

		public ObscuredString PS_ShipName;

		public ObscuredInt PS_ShipType;

		public ObscuredInt PS_Fuel;

		public ObscuredFloat PS_Hull;

		public ObscuredInt PS_FBCrateSupply;

		public ObscuredInt PS_BiscuitsSold;

		public ObscuredInt PS_BiscuitsSold_WhenContestEnded;

		public ObscuredBool PS_BiscuitsSold_WonFBContest;

		public ObscuredBool PS_BBAvailable;

		public ObscuredInt ActiveBountyHunter_SectorID;

		public ObscuredFloat ActiveBountyHunter_SecondsSinceWarp;

		public ObscuredInt ActiveBountyHunter_TypeID;

		public ObscuredFloat ActiveBountyHunter_ProcessedChaosLevel;

		public ObscuredBool PacifistRun;

		public ObscuredInt CreditsSpent_InRun;

		public ObscuredInt BlindJumpCount;

		public ObscuredInt PerfectBiscuitStreak;

		public ObscuredBool PurchaseLimitsEnabled;

		public ObscuredInt DataFragmentsCollected;

		public ObscuredInt BountyHuntersSpawned;

		public ObscuredBool PTCountdownArmed;

		public ObscuredFloat PTCountdown;

		public ObscuredBool PTCountdownDisabledTimer;

		public ObscuredBool BHI_Exists;

		public ObscuredFloat BHI_HullPercent;

		public ObscuredString BHI_ShipName;

		public ObscuredInt BHI_ShipType;

		public ObscuredBool BHL_Exists;

		public ObscuredString BHL_Data;

		public ObscuredString BHL_Crew;

		public ObscuredInt PS_CurrentUpgradeMats;

		public ObscuredInt PS_CurrentItemUpgradeHash;

		public ObscuredFloat PS_CoolantLevel;

		public ObscuredBool PS_EndGameSequenceActive;

		public ObscuredBool PS_IsReflection;

		public ObscuredByte[] PS_AdditionalShipData;

		public ObscuredInt PS_NumComponents;

		public List<ObscuredUInt> PS_ComponentHash;

		public List<ObscuredInt> PS_ComponentSortID;

		public List<ObscuredShort> PS_SubTypeData;

		public List<PLPlayerDroppedItem> PS_DroppedItems;

		public ObscuredInt CrewFactionID;

		public ObscuredBool PlayerShipIsFlagged;

		public ObscuredBool PlayerShipIsRevealed;

		public ObscuredBool LongRangeCommsDisabled;

		public List<ObscuredInt> AlreadyAttemptedToStartPickupMissionID = new List<ObscuredInt>();

		public List<PawnItemDataBlock>[] LockerInventories;

		public ClassDataBlock[] ClassData;

		public FactionDataBlock[] FactionData;

		public ObscuredFloat ChaosLevel;

		public ObscuredLong ActiveChaosEvents;

		public ObscuredLong TalentLockedStatus;

		public ETalents TalentToResearch;

		public ObscuredInt JumpsNeededToResearchTalent;

		public ObscuredInt[] ResearchMaterials;

		public List<PawnItemDataBlock> AtomizerItems;

		public List<MissionDataBlock> MissionDataBlocks;

		public ObscuredBool OfflineGame;

		public List<ShipDataBlock> ShipDataBlocks;

		public List<SectorDataBlock> SectorDataBlocks;

		public ObscuredInt SelectedShipTypeID;

		public ObscuredInt ServerShipIDCounter;

		public List<PDADataBlock> PDAs = new List<PDADataBlock>();

		public byte[] AIData;

		public string GalaxyGenerationSettingsData;

		public Vector3 ShipPosition;

		public Vector3 ShipDirection;
	}

	public class SaveGameDataBasic
	{
		public ObscuredInt SaveVerID;

		public ObscuredString FileName;

		public ObscuredInt GalaxySaveVerID;

		public ObscuredBool HasGalaxyInfo;

		public DateTime? SavedDateTime;

		public ObscuredBool LocalSave;

		public ObscuredInt GalaxySeed;

		public ObscuredFloat GameTime;

		public ObscuredInt CrewCredits;

		public ObscuredInt CrewLevel;

		public ObscuredInt CrewXP;

		public ObscuredInt CurrentSectorID;

		public ObscuredBool IronmanMode;

		public ObscuredFloat Playtime;

		public ObscuredBool FlaggedNonExpertAtAnyTime;

		public ObscuredInt EnemyKills;

		public ObscuredInt NumJumps;
	}
}
