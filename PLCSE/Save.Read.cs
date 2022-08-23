using ObscuredInt = System.Int32;
using ObscuredUInt = System.UInt32;
using ObscuredShort = System.Int16;
using ObscuredByte = System.Byte;

namespace PLCSE
{
    public static partial class Save
    {
		public static SaveGameData LoadFromFile(BinaryReader binaryReader, string fileName)
		{
			SaveGameData sgd = new SaveGameData();
			sgd.SaveVerID = binaryReader.ReadInt32();
			sgd.FileName = fileName;
			if (sgd.SaveVerID >= 28)
			{
				sgd.GalaxySaveVerID = binaryReader.ReadInt32();
				sgd.HasGalaxyInfo = sgd.GalaxySaveVerID > 12;
				sgd.SavedDateTime = DateTime.FromBinary(binaryReader.ReadInt64());
				sgd.GalaxySeed = binaryReader.ReadInt32();
				sgd.GameTime = binaryReader.ReadSingle();
				sgd.CrewCredits = binaryReader.ReadInt32();
				sgd.CrewLevel = binaryReader.ReadInt32();
				sgd.CrewXP = binaryReader.ReadInt32();
				sgd.CurrentSectorID = binaryReader.ReadInt32();
				sgd.IronmanMode = binaryReader.ReadBoolean();
				if (sgd.SaveVerID >= 53)
				{
					sgd.Playtime = binaryReader.ReadSingle();
					sgd.FlaggedNonExpertAtAnyTime = binaryReader.ReadBoolean();
					sgd.EnemyKills = binaryReader.ReadInt32();
					sgd.NumJumps = binaryReader.ReadInt32();
				}
				else
				{
					sgd.Playtime = 0f;
					sgd.FlaggedNonExpertAtAnyTime = true;
					sgd.EnemyKills = 0;
					sgd.NumJumps = 0;
				}
				if (sgd.SaveVerID >= 30)
				{
					sgd.PS_BiscuitsSold = binaryReader.ReadInt32();
				}
				else
				{
					sgd.PS_BiscuitsSold = 0;
				}
				if (sgd.SaveVerID >= 33)
				{
					sgd.PS_BiscuitsSold_WonFBContest = binaryReader.ReadBoolean();
				}
				else
				{
					sgd.PS_BiscuitsSold_WonFBContest = false;
				}
				if (sgd.SaveVerID >= 33)
				{
					sgd.PS_BiscuitsSold_WhenContestEnded = binaryReader.ReadInt32();
				}
				else
				{
					sgd.PS_BiscuitsSold_WhenContestEnded = 0;
				}
				if (sgd.SaveVerID >= 31)
				{
					sgd.PS_BBAvailable = binaryReader.ReadBoolean();
				}
				else
				{
					sgd.PS_BBAvailable = false;
				}
				if (sgd.SaveVerID >= 38)
				{
					sgd.PS_CurrentUpgradeMats = binaryReader.ReadInt32();
				}
				else
				{
					sgd.PS_CurrentUpgradeMats = 0;
				}
				if (sgd.SaveVerID >= 39)
				{
					sgd.PS_CurrentItemUpgradeHash = binaryReader.ReadInt32();
				}
				else
				{
					sgd.PS_CurrentItemUpgradeHash = 0;
				}
				sgd.FactionRepInfo = new ObscuredInt[6];
				sgd.FactionRepInfo[0] = binaryReader.ReadInt32();
				sgd.FactionRepInfo[1] = binaryReader.ReadInt32();
				sgd.FactionRepInfo[2] = binaryReader.ReadInt32();
				sgd.FactionRepInfo[3] = binaryReader.ReadInt32();
				sgd.FactionRepInfo[4] = binaryReader.ReadInt32();
				if (sgd.SaveVerID >= 32)
				{
					sgd.BiscuitContestIsOver = binaryReader.ReadBoolean();
				}
				else
				{
					sgd.BiscuitContestIsOver = false;
				}
				if (sgd.SaveVerID >= 46)
				{
					sgd.ActiveBountyHunter_SectorID = binaryReader.ReadInt32();
					sgd.ActiveBountyHunter_SecondsSinceWarp = binaryReader.ReadSingle();
					sgd.ActiveBountyHunter_TypeID = binaryReader.ReadInt32();
					sgd.ActiveBountyHunter_ProcessedChaosLevel = binaryReader.ReadSingle();
				}
				else
				{
					sgd.ActiveBountyHunter_SectorID = -1;
					sgd.ActiveBountyHunter_SecondsSinceWarp = 0f;
					sgd.ActiveBountyHunter_TypeID = -1;
					sgd.ActiveBountyHunter_ProcessedChaosLevel = 0f;
				}
				if (sgd.SaveVerID >= 44)
				{
					sgd.PacifistRun = binaryReader.ReadBoolean();
					sgd.CreditsSpent_InRun = binaryReader.ReadInt32();
					sgd.PerfectBiscuitStreak = binaryReader.ReadInt32();
					sgd.BlindJumpCount = binaryReader.ReadInt32();
				}
				else
				{
					sgd.PacifistRun = false;
					sgd.CreditsSpent_InRun = 0;
					sgd.PerfectBiscuitStreak = 0;
					sgd.BlindJumpCount = 0;
				}
				if (sgd.SaveVerID >= 45)
				{
					sgd.PurchaseLimitsEnabled = binaryReader.ReadBoolean();
				}
				else
				{
					sgd.PurchaseLimitsEnabled = true;
				}
				if (sgd.SaveVerID >= 47)
				{
					sgd.DataFragmentsCollected = binaryReader.ReadInt32();
				}
				else
				{
					sgd.DataFragmentsCollected = 0;
				}
				if (sgd.SaveVerID >= 50)
				{
					sgd.BountyHuntersSpawned = binaryReader.ReadInt32();
				}
				else
				{
					sgd.BountyHuntersSpawned = 0;
				}
				if (sgd.SaveVerID >= 57)
				{
					sgd.PTCountdownArmed = binaryReader.ReadBoolean();
					sgd.PTCountdown = binaryReader.ReadSingle();
					sgd.FactionRepInfo[5] = binaryReader.ReadInt32();
				}
				else
				{
					sgd.PTCountdownArmed = false;
					sgd.PTCountdown = 7200f;
					sgd.FactionRepInfo[5] = 0;
				}
				if (sgd.SaveVerID >= 58)
				{
					sgd.PTCountdownDisabledTimer = binaryReader.ReadBoolean();
				}
				else
				{
					sgd.PTCountdownDisabledTimer = false;
				}
				if (sgd.SaveVerID >= 59)
				{
					sgd.OfflineGame = binaryReader.ReadBoolean();
				}
				else
				{
					sgd.OfflineGame = false;
				}
				if (sgd.SaveVerID >= 51)
				{
					bool flag2 = binaryReader.ReadBoolean();
					sgd.BHI_Exists = flag2;
					if (flag2)
					{
						sgd.BHI_HullPercent = binaryReader.ReadSingle();
						sgd.BHI_ShipName = binaryReader.ReadString();
						sgd.BHI_ShipType = binaryReader.ReadInt32();
					}
					bool flag3 = binaryReader.ReadBoolean();
					sgd.BHL_Exists = flag3;
					if (flag3)
					{
						sgd.BHL_Data = binaryReader.ReadString();
						sgd.BHL_Crew = binaryReader.ReadString();
					}
				}
				if (sgd.SaveVerID >= 42)
				{
					Vector3 zero = Vector3.zero;
					zero.x = binaryReader.ReadSingle();
					zero.y = binaryReader.ReadSingle();
					zero.z = binaryReader.ReadSingle();
					sgd.StormPosition = zero;
				}
				else
				{
					// skip
					//base.StartCoroutine(this.SetupStormPosition_Late_WithoutSaveData());
				}
				if (sgd.SaveVerID >= 37)
				{
					sgd.RacesWonBitfield = binaryReader.ReadInt32();
					sgd.RacesLostBitfield = binaryReader.ReadInt32();
					sgd.RacesStartedBitfield = binaryReader.ReadInt32();
				}
				else
				{
					sgd.RacesWonBitfield = 0;
					sgd.RacesLostBitfield = 0;
					sgd.RacesStartedBitfield = 0;
				}
				sgd.GameName = binaryReader.ReadString();
				sgd.PS_ShipName = binaryReader.ReadString();
				sgd.PS_ShipType = binaryReader.ReadInt32();
				sgd.PS_Fuel = binaryReader.ReadInt32();
				sgd.PS_Hull = binaryReader.ReadSingle();
				if (sgd.SaveVerID >= 30)
				{
					sgd.PS_FBCrateSupply = binaryReader.ReadInt32();
				}
				else
				{
					sgd.PS_FBCrateSupply = 0;
				}
				sgd.PS_CoolantLevel = binaryReader.ReadSingle();
				if (sgd.SaveVerID >= 55)
				{
					sgd.PS_EndGameSequenceActive = binaryReader.ReadBoolean();
					sgd.PS_IsReflection = binaryReader.ReadBoolean();
				}
				else
				{
					sgd.PS_EndGameSequenceActive = false;
					sgd.PS_IsReflection = false;
				}
				if (sgd.SaveVerID >= 32)
				{
					int num = binaryReader.ReadInt32();
					sgd.PS_AdditionalShipData = binaryReader.ReadBytes(num);
				}
				else
				{
					sgd.PS_AdditionalShipData = new ObscuredByte[0];
				}
				sgd.PS_NumComponents = binaryReader.ReadInt32();
				sgd.PS_ComponentHash = new List<ObscuredUInt>(sgd.PS_NumComponents);
				sgd.PS_ComponentSortID = new List<ObscuredInt>(sgd.PS_NumComponents);
				sgd.PS_SubTypeData = new List<ObscuredShort>(sgd.PS_NumComponents);
				sgd.LockerInventories = new List<PawnItemDataBlock>[5];
				for (int i = 0; i < sgd.PS_NumComponents; i++)
				{
					uint num2 = binaryReader.ReadUInt32();
					int num3 = binaryReader.ReadInt32();
					short num4 = binaryReader.ReadInt16();
					if (num2 != 0U || num3 != -1)
					{
						sgd.PS_ComponentHash.Add(num2);
						sgd.PS_ComponentSortID.Add(num3);
						sgd.PS_SubTypeData.Add(num4);
					}
				}
				sgd.PS_DroppedItems = new List<PLPlayerDroppedItem>();
				if (sgd.SaveVerID > 29)
				{
					int num5 = binaryReader.ReadInt32();
					for (int j = 0; j < num5; j++)
					{
						uint num6 = binaryReader.ReadUInt32();
						float num7 = binaryReader.ReadSingle();
						float num8 = binaryReader.ReadSingle();
						float num9 = binaryReader.ReadSingle();
						sgd.PS_DroppedItems.Add(new PLPlayerDroppedItem(num6, new Vector3(num7, num8, num9), -1));
					}
				}
				for (int k = 0; k < 5; k++)
				{
					sgd.LockerInventories[k] = new List<PawnItemDataBlock>();
					int num10 = binaryReader.ReadInt32();
					for (int l = 0; l < num10; l++)
					{
						PawnItemDataBlock pawnItemDataBlock = new PawnItemDataBlock();
						pawnItemDataBlock.ItemType = (EPawnItemType)binaryReader.ReadInt32();
						pawnItemDataBlock.SubType = binaryReader.ReadInt32();
						pawnItemDataBlock.Level = binaryReader.ReadInt32();
						if (pawnItemDataBlock.ItemType != EPawnItemType.E_HANDS)
						{
							sgd.LockerInventories[k].Add(pawnItemDataBlock);
						}
					}
				}
				int num11 = binaryReader.ReadInt32();
				sgd.FactionData = new FactionDataBlock[num11];
				for (int m = 0; m < num11; m++)
				{
					sgd.FactionData[m].ID = binaryReader.ReadInt32();
					sgd.FactionData[m].Continuous_GalaxySpreadLimit = binaryReader.ReadSingle();
					sgd.FactionData[m].Continuous_GalaxySpreadFactor = binaryReader.ReadSingle();
				}
				if (sgd.SaveVerID >= 48)
				{
					sgd.GalaxyGenerationSettingsData = binaryReader.ReadString();
				}
				else
				{
					//sgd.GalaxyGenerationSettingsData = PLGlobal.Instance.Galaxy.DefaultGenSettings.CreateDataString();
				}
				if (string.IsNullOrEmpty(sgd.GalaxyGenerationSettingsData))
				{
					//sgd.GalaxyGenerationSettingsData = PLGlobal.Instance.Galaxy.DefaultGenSettings.CreateDataString();
				}
				if (sgd.SaveVerID >= 60)
				{
					sgd.ShipPosition = binaryReader.ReadVector3();
					sgd.ShipDirection = binaryReader.ReadVector3();
				}
				sgd.ChaosLevel = binaryReader.ReadSingle();
				sgd.ActiveChaosEvents = binaryReader.ReadInt64();
				sgd.TalentLockedStatus = binaryReader.ReadInt64();
				sgd.TalentToResearch = (ETalents)binaryReader.ReadInt32();
				sgd.JumpsNeededToResearchTalent = binaryReader.ReadInt32();
				sgd.ResearchMaterials = new ObscuredInt[6];
				sgd.ResearchMaterials[0] = binaryReader.ReadInt32();
				sgd.ResearchMaterials[1] = binaryReader.ReadInt32();
				sgd.ResearchMaterials[2] = binaryReader.ReadInt32();
				sgd.ResearchMaterials[3] = binaryReader.ReadInt32();
				sgd.ResearchMaterials[4] = binaryReader.ReadInt32();
				sgd.ResearchMaterials[5] = binaryReader.ReadInt32();
				sgd.AtomizerItems = new List<PawnItemDataBlock>();
				int num12 = binaryReader.ReadInt32();
				for (int n = 0; n < num12; n++)
				{
					PawnItemDataBlock pawnItemDataBlock2 = new PawnItemDataBlock();
					pawnItemDataBlock2.ItemType = (EPawnItemType)binaryReader.ReadInt32();
					pawnItemDataBlock2.SubType = binaryReader.ReadInt32();
					pawnItemDataBlock2.Level = binaryReader.ReadInt32();
					sgd.AtomizerItems.Add(pawnItemDataBlock2);
				}
				sgd.ClassData = new ClassDataBlock[5];
				if (sgd.SaveVerID > 30)
				{
					for (int num13 = 0; num13 < 5; num13++)
					{
						if (binaryReader.ReadBoolean())
						{
							sgd.ClassData[num13] = new ClassDataBlock();
							sgd.ClassData[num13].TalentPointsAvailable = binaryReader.ReadInt32();
							if (sgd.SaveVerID >= 43)
							{
								sgd.ClassData[num13].SurvivalBonusCounter = binaryReader.ReadInt32();
							}
							else
							{
								sgd.ClassData[num13].SurvivalBonusCounter = 0;
							}
							int num14 = binaryReader.ReadInt32();
							sgd.ClassData[num13].Talents = new ObscuredInt[num14];
							for (int num15 = 0; num15 < num14; num15++)
							{
								sgd.ClassData[num13].Talents[num15] = binaryReader.ReadInt32();
							}
							int num16 = binaryReader.ReadInt32();
							sgd.ClassData[num13].PawnInventory = new List<PawnItemDataBlock>(num16);
							for (int num17 = 0; num17 < num16; num17++)
							{
								PawnItemDataBlock pawnItemDataBlock3 = new PawnItemDataBlock
								{
									ItemType = (EPawnItemType)binaryReader.ReadInt32(),
									SubType = binaryReader.ReadInt32(),
									Level = binaryReader.ReadInt32(),
									OptionalEquipID = binaryReader.ReadInt32()
								};
								sgd.ClassData[num13].PawnInventory.Add(pawnItemDataBlock3);
							}
						}
					}
				}
				sgd.CrewFactionID = binaryReader.ReadInt32();
				sgd.PlayerShipIsFlagged = binaryReader.ReadBoolean();
				sgd.PlayerShipIsRevealed = binaryReader.ReadBoolean();
				sgd.LongRangeCommsDisabled = binaryReader.ReadBoolean();
				int num18 = binaryReader.ReadInt32();
				for (int num19 = 0; num19 < num18; num19++)
				{
					sgd.AlreadyAttemptedToStartPickupMissionID.Add(binaryReader.ReadInt32());
				}
				sgd.SelectedShipTypeID = binaryReader.ReadInt32();
				sgd.ServerShipIDCounter = binaryReader.ReadInt32();
				int num20 = binaryReader.ReadInt32();
				//Console.WriteLine($"Readed: PDADataBlock[].Length -> {num20}");
				for (int num21 = 0; num21 < num20; num21++)
				{
					PDADataBlock pdadataBlock = new PDADataBlock();
					pdadataBlock.Type = binaryReader.ReadInt32();
					int num22 = pdadataBlock.Type;
					if (num22 != 0)
					{
						if (num22 == 1)
						{
							pdadataBlock.Hostile = binaryReader.ReadBoolean();
							pdadataBlock.ActorID = binaryReader.ReadString();
							pdadataBlock.ShipName = binaryReader.ReadString();
							pdadataBlock.SpecialActionCompleted = binaryReader.ReadBoolean();
							int num23 = binaryReader.ReadInt32();
							for (int num24 = 0; num24 < num23; num24++)
							{
								pdadataBlock.LinesToShowPercent.Add(binaryReader.ReadInt32());
							}
						}
					}
					else
					{
						pdadataBlock.Hostile = binaryReader.ReadBoolean();
						pdadataBlock.ActorID = binaryReader.ReadString();
						pdadataBlock.NPCName = binaryReader.ReadString();
					}
					int num25 = binaryReader.ReadInt32();
					for (int num26 = 0; num26 < num25; num26++)
					{
						pdadataBlock.LinesAlreadyDisplayed.Add(binaryReader.ReadInt32());
					}
					sgd.PDAs.Add(pdadataBlock);
				}
				sgd.ShipDataBlocks = new List<ShipDataBlock>();
				sgd.MissionDataBlocks = new List<MissionDataBlock>();
				sgd.SectorDataBlocks = new List<SectorDataBlock>();
				int num27 = binaryReader.ReadInt32();
				//Console.WriteLine($"Readed: ShipDataBlock[].Length -> {num27}");
				for (int num28 = 0; num28 < num27; num28++)
				{
					ShipDataBlock shipDataBlock = new ShipDataBlock();
					shipDataBlock.ShipType = binaryReader.ReadInt32();
					shipDataBlock.FactionID = binaryReader.ReadInt32();
					shipDataBlock.IsDestroyed = binaryReader.ReadBoolean();
					shipDataBlock.SectorID = binaryReader.ReadInt32();
					shipDataBlock.CompOverrides = new List<ComponentOverrideData>();
					shipDataBlock.ShipName = binaryReader.ReadString();
					int num29 = binaryReader.ReadInt32();
					for (int num30 = 0; num30 < num29; num30++)
					{
						ComponentOverrideData componentOverrideData = new ComponentOverrideData();
						componentOverrideData.CompLevel = binaryReader.ReadInt32();
						componentOverrideData.CompTypeToReplace = binaryReader.ReadInt32();
						componentOverrideData.CompSubType = binaryReader.ReadInt32();
						componentOverrideData.CompType = binaryReader.ReadInt32();
						componentOverrideData.ReplaceExistingComp = binaryReader.ReadBoolean();
						componentOverrideData.CompSubTypeToReplace = binaryReader.ReadInt32();
						componentOverrideData.SlotNumberToReplace = binaryReader.ReadInt32();
						componentOverrideData.IsCargo = binaryReader.ReadBoolean();
						shipDataBlock.CompOverrides.Add(componentOverrideData);
					}
					shipDataBlock.HullPercent = binaryReader.ReadSingle();
					shipDataBlock.ShldPercent = binaryReader.ReadSingle();
					if (sgd.SaveVerID > 27)
					{
						shipDataBlock.Modifiers = binaryReader.ReadInt32();
					}
					else
					{
						shipDataBlock.Modifiers = 0;
					}
					shipDataBlock.IsFlagged = binaryReader.ReadBoolean();
					shipDataBlock.ForceHostile = binaryReader.ReadBoolean();
					shipDataBlock.ForceHostileAll = binaryReader.ReadBoolean();
					shipDataBlock.ForceHostileName = binaryReader.ReadString();
					shipDataBlock.SelectedActorID = binaryReader.ReadString();
					if (sgd.SaveVerID >= 29)
					{
						shipDataBlock.BiscuitsSold = binaryReader.ReadInt32();
					}
					else
					{
						shipDataBlock.BiscuitsSold = 0;
					}
					if (sgd.SaveVerID >= 34)
					{
						shipDataBlock.WonFBContest = binaryReader.ReadBoolean();
					}
					else
					{
						shipDataBlock.WonFBContest = false;
					}
					if (sgd.SaveVerID >= 36)
					{
						shipDataBlock.EnsureNoCrew = binaryReader.ReadBoolean();
					}
					else
					{
						shipDataBlock.EnsureNoCrew = false;
					}
					if (sgd.SaveVerID >= 52)
					{
						shipDataBlock.IsRelicHunter = binaryReader.ReadBoolean();
						if (shipDataBlock.IsRelicHunter)
						{
							shipDataBlock.RH_Data = binaryReader.ReadString();
							shipDataBlock.RH_Crew = binaryReader.ReadString();
						}
					}
					sgd.ShipDataBlocks.Add(shipDataBlock);
				}
				int num31 = binaryReader.ReadInt32();
				//Console.WriteLine($"Readed: MissianDataBlock[].Length -> {num31}");
				for (int num32 = 0; num32 < num31; num32++)
				{
					MissionDataBlock missionDataBlock = new MissionDataBlock();
					missionDataBlock.MissionID = binaryReader.ReadInt32();
					missionDataBlock.Abandoned = binaryReader.ReadBoolean();
					missionDataBlock.Ended = binaryReader.ReadBoolean();
					int num33 = binaryReader.ReadInt32();
					missionDataBlock.ObjectivesCompleted = new bool[num33];
					missionDataBlock.ObjectivesAmountCompleted = new ObscuredInt[num33];
					missionDataBlock.ObjectivesAmountNeeded = new ObscuredInt[num33];
					missionDataBlock.ObjectivesShownCompletedMessage = new bool[num33];
					for (int num34 = 0; num34 < num33; num34++)
					{
						missionDataBlock.ObjectivesCompleted[num34] = binaryReader.ReadBoolean();
						missionDataBlock.ObjectivesAmountCompleted[num34] = binaryReader.ReadInt32();
						missionDataBlock.ObjectivesAmountNeeded[num34] = binaryReader.ReadInt32();
						if (sgd.SaveVerID > 25)
						{
							missionDataBlock.ObjectivesShownCompletedMessage[num34] = binaryReader.ReadBoolean();
						}
						else
						{
							missionDataBlock.ObjectivesShownCompletedMessage[num34] = missionDataBlock.ObjectivesCompleted[num34];
						}
					}
					missionDataBlock.IsPickupMission = binaryReader.ReadBoolean();
					missionDataBlock.RanStartRewards = binaryReader.ReadBoolean();
					sgd.MissionDataBlocks.Add(missionDataBlock);
				}
				int num35 = binaryReader.ReadInt32(); //Console.WriteLine($"Readed: SectorDataBlock[].Length -> {num35}");
				for (int num36 = 0; num36 < num35; num36++)
				{
					SectorDataBlock sectorDataBlock = new SectorDataBlock();
					sectorDataBlock.ID = binaryReader.ReadInt32();
					sectorDataBlock.Type = binaryReader.ReadInt32();
					sectorDataBlock.FactionStrength = binaryReader.ReadSingle();
					sectorDataBlock.Faction = binaryReader.ReadInt32();
					sectorDataBlock.SectorPosition = new Vector3(binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle());
					sectorDataBlock.SectorName = binaryReader.ReadString();
					sectorDataBlock.MissionSpecificID = binaryReader.ReadInt32();
					sectorDataBlock.LockedToFaction = binaryReader.ReadBoolean();
					sectorDataBlock.LastCalculatedSectorStrength = binaryReader.ReadSingle();
					sectorDataBlock.IsPartOfLongRangeWarpNetwork = binaryReader.ReadBoolean();
					if (sgd.SaveVerID > 26)
					{
						sectorDataBlock.Visited = binaryReader.ReadBoolean();
					}
					else
					{
						sectorDataBlock.Visited = false;
					}
					if (sgd.SaveVerID >= 30)
					{
						sectorDataBlock.BiscuitsSoldCounter = binaryReader.ReadInt32();
					}
					else
					{
						sectorDataBlock.BiscuitsSoldCounter = 0;
					}
					sectorDataBlock.HasPED = binaryReader.ReadBoolean();
					sectorDataBlock.PED = new PLPersistantEncounterData();
					sectorDataBlock.PED.m_TraderInfoDictionary = ReadDictionaryIntTPDE(binaryReader);
					sectorDataBlock.PED.m_SpecialNetObjectPersistantData = ReadDictionaryIntSENE(binaryReader);
					sectorDataBlock.PED.m_PickupObjectPersistantData = ReadDictionaryIntBool(binaryReader);
					sectorDataBlock.PED.m_PickupComponentPersistantData = ReadDictionaryIntBool(binaryReader);
					sectorDataBlock.PED.m_PickupRandomComponentPersistantData = ReadDictionaryIntBool(binaryReader);
					if (sgd.SaveVerID >= 35)
					{
						sectorDataBlock.PED.m_ProbePickupPersistantData = ReadDictionaryIntBool(binaryReader);
					}
					sectorDataBlock.PED.m_MiscPersistantData = ReadDictionaryStringString(binaryReader);
					if (sgd.SaveVerID == 40)
					{
						if (sectorDataBlock.HasPED)
						{
							sectorDataBlock.PED.m_DPOPersistantData = ReadDictionaryStringDPO(binaryReader);
							sectorDataBlock.PED.m_DSOPersistantData = ReadDictionaryStringDSO(binaryReader);
						}
					}
					else if (sgd.SaveVerID >= 41)
					{
						sectorDataBlock.PED.m_DPOPersistantData = ReadDictionaryStringDPO(binaryReader);
						sectorDataBlock.PED.m_DSOPersistantData = ReadDictionaryStringDSO(binaryReader);
					}
					if (sgd.SaveVerID >= 56)
					{
						int num37 = binaryReader.ReadInt32();
						if (num37 > 0)
						{
							sectorDataBlock.AdditionalSaveData = binaryReader.ReadBytes(num37);
						}
					}
					sectorDataBlock.DroppedItems = new List<PLPlayerDroppedItem_WithTLIData>();
					int num38 = binaryReader.ReadInt32();
					for (int num39 = 0; num39 < num38; num39++)
					{
						uint num40 = binaryReader.ReadUInt32();
						float num41 = binaryReader.ReadSingle();
						float num42 = binaryReader.ReadSingle();
						float num43 = binaryReader.ReadSingle();
						int num44 = binaryReader.ReadInt32();
						int num45 = binaryReader.ReadInt32();
						sectorDataBlock.DroppedItems.Add(new PLPlayerDroppedItem_WithTLIData(num40, new Vector3(num41, num42, num43), -1, num44, num45));
					}
					sgd.SectorDataBlocks.Add(sectorDataBlock);
				}
				try
				{
					sgd.AIData = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));//PLAIIO.ReadBinary(binaryReader);
				}
				catch (Exception ex)
				{
					Console.WriteLine("LoadFromFile EXCEPTION: " + ex.Message);
				}
			}
			binaryReader.Close();
			sgd.AfterRead();
			return sgd;
		}

		static private Dictionary<ObscuredInt, bool> ReadDictionaryIntBool(BinaryReader inReader)
		{
			Dictionary<ObscuredInt, bool> dictionary = new Dictionary<ObscuredInt, bool>();
			int num = inReader.ReadInt32();
			//Console.WriteLine("Readed IntBool with length " + num);
			for (int i = 0; i < num; i++)
			{
				int num2 = inReader.ReadInt32();
				bool flag = inReader.ReadBoolean();
				dictionary.Add(num2, flag);
			}
			return dictionary;
		}

		static private Dictionary<ObscuredInt, PLSpecialEncounterNetObjectPersistantData> ReadDictionaryIntSENE(BinaryReader inReader)
		{
			Dictionary<ObscuredInt, PLSpecialEncounterNetObjectPersistantData> dictionary = new Dictionary<ObscuredInt, PLSpecialEncounterNetObjectPersistantData>();
			int num = inReader.ReadInt32();
			//Console.WriteLine("Readed SENE with length " + num);
			for (int i = 0; i < num; i++)
			{
				int num2 = inReader.ReadInt32();
				bool flag = inReader.ReadBoolean();
				PLSpecialEncounterNetObjectPersistantData plspecialEncounterNetObjectPersistantData = new PLSpecialEncounterNetObjectPersistantData();
				plspecialEncounterNetObjectPersistantData.PersistantState = flag;
				dictionary.Add(num2, plspecialEncounterNetObjectPersistantData);
			}
			return dictionary;
		}

		static private Dictionary<ObscuredInt, TraderPersistantDataEntry> ReadDictionaryIntTPDE(BinaryReader inReader)
		{
			Dictionary<ObscuredInt, TraderPersistantDataEntry> dictionary = new Dictionary<ObscuredInt, TraderPersistantDataEntry>();
			int num = inReader.ReadInt32();
			//Console.WriteLine("Readed TPDE with length " + num);
			for (int i = 0; i < num; i++)
			{
				TraderPersistantDataEntry traderPersistantDataEntry = new TraderPersistantDataEntry();
				int num2 = inReader.ReadInt32();
				traderPersistantDataEntry.ServerWareIDCounter = inReader.ReadInt32();
				int num3 = inReader.ReadInt32();
				//Console.WriteLine("| Readed TPDE.m_Wars with length " + num3);
				for (int j = 0; j < num3; j++)
				{
					int num4 = inReader.ReadInt32();
					uint num5 = inReader.ReadUInt32();
					PLWare plware = PLWare.CreateFromHash(num4, (int)num5);
					traderPersistantDataEntry.ServerAddWare(plware);
				}
				dictionary.Add(num2, traderPersistantDataEntry);
			}
			return dictionary;
		}

		static private Dictionary<string, PLDPOPersistantData> ReadDictionaryStringDPO(BinaryReader inReader)
		{
			Dictionary<string, PLDPOPersistantData> dictionary = new Dictionary<string, PLDPOPersistantData>();
			int num = inReader.ReadInt32();
			//Console.WriteLine("Readed StringDPO with length " + num);
			for (int i = 0; i < num; i++)
			{
				string text = inReader.ReadString();
				PLDPOPersistantData pldpopersistantData = new PLDPOPersistantData();
				pldpopersistantData.Health = inReader.ReadSingle();
				pldpopersistantData.DestroyedMsgSent = inReader.ReadBoolean();
				pldpopersistantData.RepairedMsgSent = inReader.ReadBoolean();
				dictionary.Add(text, pldpopersistantData);
			}
			return dictionary;
		}

		static private Dictionary<string, PLDSOPersistantData> ReadDictionaryStringDSO(BinaryReader inReader)
		{
			Dictionary<string, PLDSOPersistantData> dictionary = new Dictionary<string, PLDSOPersistantData>();
			int num = inReader.ReadInt32();
			//Console.WriteLine("Readed StringDSO with length " + num);
			for (int i = 0; i < num; i++)
			{
				string text = inReader.ReadString();
				PLDSOPersistantData pldsopersistantData = new PLDSOPersistantData();
				pldsopersistantData.Health = inReader.ReadSingle();
				pldsopersistantData.DestroyedMsgSent = inReader.ReadBoolean();
				dictionary.Add(text, pldsopersistantData);
			}
			return dictionary;
		}

		static private Dictionary<string, string> ReadDictionaryStringString(BinaryReader inReader)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			int num = inReader.ReadInt32();
			//Console.WriteLine("Readed StringString with length " + num);
			for (int i = 0; i < num; i++)
			{
				string text = inReader.ReadString();
				string text2 = inReader.ReadString();
				dictionary.Add(text, text2);
			}
			return dictionary;
		}
	}
}
