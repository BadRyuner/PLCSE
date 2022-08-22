namespace PLCSE
{
    public static partial class Save
    {
        public static byte[] SaveToBytes()
        {
            var s = CurrentSave;
            s.BeforeWrite();
            using (MemoryStream _ms = new MemoryStream())
            using (BinaryWriter w = new BinaryWriter(_ms))
            {
                w.Write(s.SaveVerID); //
                w.Write(s.GalaxySaveVerID); //
                w.Write((long)s.SavedDateTime?.ToBinary());
                w.Write(s.GalaxySeed); //
                w.Write(s.GameTime); // 
                w.Write(s.CrewCredits); //
                w.Write(s.CrewLevel); //
                w.Write(s.CrewXP); //
                w.Write(s.CurrentSectorID); //
                w.Write(s.IronmanMode); //
                w.Write(s.Playtime); //
                w.Write(s.FlaggedNonExpertAtAnyTime); //
                w.Write(s.EnemyKills); //
                w.Write(s.NumJumps); //
                w.Write(s.PS_BiscuitsSold);//
                w.Write(s.PS_BiscuitsSold_WonFBContest);//
                w.Write(s.PS_BiscuitsSold_WhenContestEnded);//
                w.Write(s.PS_BBAvailable);//
                w.Write(s.PS_CurrentUpgradeMats);
                w.Write(s.PS_CurrentItemUpgradeHash);
                w.Write(s.FactionRepInfo[0]);//
                w.Write(s.FactionRepInfo[1]);//
                w.Write(s.FactionRepInfo[2]);//
                w.Write(s.FactionRepInfo[3]);//
                w.Write(s.FactionRepInfo[4]);//
                w.Write(s.BiscuitContestIsOver);//
                w.Write(s.ActiveBountyHunter_SectorID);//
                w.Write(s.ActiveBountyHunter_SecondsSinceWarp);//
                w.Write(s.ActiveBountyHunter_TypeID);//
                w.Write(s.ActiveBountyHunter_ProcessedChaosLevel);//
                w.Write(s.PacifistRun);//
                w.Write(s.CreditsSpent_InRun); //
                w.Write(s.PerfectBiscuitStreak);//
                w.Write(s.BlindJumpCount);//
                w.Write(s.PurchaseLimitsEnabled);//
                w.Write(s.DataFragmentsCollected);//
                w.Write(s.BountyHuntersSpawned);//
                w.Write(s.PTCountdownArmed);//
                w.Write(s.PTCountdown);//
                w.Write(s.FactionRepInfo[5]);//
                w.Write(s.PTCountdownDisabledTimer);//
                w.Write(s.OfflineGame);//
                w.Write(s.BHI_Exists);//
                if (s.BHI_Exists)
                {
                    w.Write(s.BHI_HullPercent);//
                    w.Write(s.BHI_ShipName);//
                    w.Write(s.BHI_ShipType);//
                }
                w.Write(s.BHL_Exists);//
                if (s.BHL_Exists)
                {
                    w.Write(s.BHL_Data);//
                    w.Write(s.BHL_Crew);//
                }
                w.Write(s.StormPosition.x);//
                w.Write(s.StormPosition.y);//
                w.Write(s.StormPosition.z);//
                w.Write(s.RacesWonBitfield);//
                w.Write(s.RacesLostBitfield);//
                w.Write(s.RacesStartedBitfield);//
                w.Write(s.GameName);//
                w.Write(s.PS_ShipName);//
                w.Write(s.PS_ShipType);//
                w.Write(s.PS_Fuel);//
                w.Write(s.PS_Hull);//
                w.Write(s.PS_FBCrateSupply);//
                w.Write(s.PS_CoolantLevel);//
                w.Write(s.PS_EndGameSequenceActive);//
                w.Write(s.PS_IsReflection);//
                w.Write(s.PS_AdditionalShipData.Length);
                w.Write(s.PS_AdditionalShipData);
                w.Write(s.PS_NumComponents);//
                for(int i = 0; i < s.PS_NumComponents; i++)
                {
                    w.Write(s.PS_ComponentHash[i]);//
                    w.Write(s.PS_ComponentSortID[i]);//
                    w.Write(s.PS_SubTypeData[i]);//
                }
                w.Write(s.PS_DroppedItems.Count);
                for(int i = 0; i < s.PS_DroppedItems.Count; i++)
                {
                    w.Write(s.PS_DroppedItems[i].ItemHash);
                    w.Write(s.PS_DroppedItems[i].Position.x);
                    w.Write(s.PS_DroppedItems[i].Position.y);
                    w.Write(s.PS_DroppedItems[i].Position.z);
                }
                //w.Write(s.LockerInventories.Length);
                for (int i = 0; i < s.LockerInventories.Length; i++)
                {
                    w.Write(s.LockerInventories[i].Count);
                    for (int x = 0; x < s.LockerInventories[i].Count; x++)
                    {
                        w.Write((int)s.LockerInventories[i][x].ItemType);
                        w.Write(s.LockerInventories[i][x].SubType);
                        w.Write(s.LockerInventories[i][x].Level);
                    }
                }
                w.Write(s.FactionData.Length);
                for(int i = 0; i < s.FactionData.Length; i++)
                {
                    w.Write(s.FactionData[i].ID);//
                    w.Write(s.FactionData[i].Continuous_GalaxySpreadLimit);//
                    w.Write(s.FactionData[i].Continuous_GalaxySpreadFactor);//
                }
                w.Write(s.GalaxyGenerationSettingsData);
                w.Write(s.ShipPosition.x);//
                w.Write(s.ShipPosition.y);//
                w.Write(s.ShipPosition.z);//
                w.Write(s.ShipDirection.x);//
                w.Write(s.ShipDirection.y);//
                w.Write(s.ShipDirection.z);//
                w.Write(s.ChaosLevel);//
                w.Write(s.ActiveChaosEvents);//
                w.Write(s.TalentLockedStatus);//
                w.Write((int)s.TalentToResearch);
                w.Write(s.JumpsNeededToResearchTalent);//
                w.Write(s.ResearchMaterials[0]);//
                w.Write(s.ResearchMaterials[1]);//
                w.Write(s.ResearchMaterials[2]);//
                w.Write(s.ResearchMaterials[3]);//
                w.Write(s.ResearchMaterials[4]);//
                w.Write(s.ResearchMaterials[5]);//
                w.Write(s.AtomizerItems.Count);
                for(int i = 0; i < s.AtomizerItems.Count; i++)
                {
                    w.Write((int)s.AtomizerItems[i].ItemType);
                    w.Write(s.AtomizerItems[i].SubType);
                    w.Write(s.AtomizerItems[i].Level);
                }
                for (int i = 0; i < 5; i++)
                {
                    w.Write(s.ClassData[i] != null);
                    if (s.ClassData[i] != null)
					{
                        w.Write(s.ClassData[i].TalentPointsAvailable);//
                        w.Write(s.ClassData[i].SurvivalBonusCounter);//
                        w.Write(s.ClassData[i].Talents.Length);//
                        foreach (var t in s.ClassData[i].Talents)//
                            w.Write(t);
                        w.Write(s.ClassData[i].PawnInventory.Count);//
                        foreach (var pi in s.ClassData[i].PawnInventory)//
                        {
                            w.Write((int)pi.ItemType);//
                            w.Write(pi.SubType);//
                            w.Write(pi.Level);//
                            w.Write(pi.OptionalEquipID);//
                        }
                    }
                }
                w.Write(s.CrewFactionID);//
                w.Write(s.PlayerShipIsFlagged);//
                w.Write(s.PlayerShipIsRevealed);//
                w.Write(s.LongRangeCommsDisabled);//
                w.Write(s.AlreadyAttemptedToStartPickupMissionID.Count);//
                foreach (var i in s.AlreadyAttemptedToStartPickupMissionID)//
                    w.Write(i);
                w.Write(s.SelectedShipTypeID);
                w.Write(s.ServerShipIDCounter);
                w.Write(s.PDAs.Count);
                //Console.WriteLine($"Writed: PDAs[].Length -> {s.PDAs.Count}");
                foreach (var i in s.PDAs)
                {
                    w.Write(i.Type);
                    if (i.Type != 0)
                    {
                        if (i.Type == 1)
                        {
                            w.Write(i.Hostile);
                            w.Write(i.ActorID);
                            w.Write(i.ShipName);
                            w.Write(i.SpecialActionCompleted);
                            w.Write(i.LinesToShowPercent.Count);
                            foreach (var x in i.LinesToShowPercent)
                                w.Write(x);
                        }
                    }
                    else
                    {
                        w.Write(i.Hostile);
                        w.Write(i.ActorID);
                        w.Write(i.NPCName);
                    }
                    w.Write(i.LinesAlreadyDisplayed.Count);
                    foreach (var x in i.LinesAlreadyDisplayed)
                        w.Write(x);
                }
                w.Write(s.ShipDataBlocks.Count);
                //Console.WriteLine($"Writed: ShipDataBlocks[].Length -> {s.ShipDataBlocks.Count}");
                foreach (var i in s.ShipDataBlocks)
                {
                    w.Write(i.ShipType);
                    w.Write(i.FactionID);
                    w.Write(i.IsDestroyed);
                    w.Write(i.SectorID);
                    w.Write(i.ShipName);
                    w.Write(i.CompOverrides.Count);
                    foreach(var x in i.CompOverrides)
                    {
                        w.Write(x.CompLevel);
                        w.Write(x.CompTypeToReplace);
                        w.Write(x.CompSubType);
                        w.Write(x.CompType);
                        w.Write(x.ReplaceExistingComp);
                        w.Write(x.CompSubTypeToReplace);
                        w.Write(x.SlotNumberToReplace);
                        w.Write(x.IsCargo);
                    }
                    w.Write(i.HullPercent);
                    w.Write(i.ShldPercent);
                    w.Write(i.Modifiers);
                    w.Write(i.IsFlagged);
                    w.Write(i.ForceHostile);
                    w.Write(i.ForceHostileAll);
                    w.Write(i.ForceHostileName);
                    w.Write(i.SelectedActorID);
                    w.Write(i.BiscuitsSold);
                    w.Write(i.WonFBContest);
                    w.Write(i.EnsureNoCrew);
                    w.Write(i.IsRelicHunter);
                    if (i.IsRelicHunter)
                    {
                        w.Write(i.RH_Data);
                        w.Write(i.RH_Crew);
                    }
                }
                w.Write(s.MissionDataBlocks.Count);//
                //Console.WriteLine($"Writed: MissionDataBlocks[].Length -> {s.MissionDataBlocks.Count}");
                foreach (var i in s.MissionDataBlocks)//
                {
                    w.Write(i.MissionID);//
                    w.Write(i.Abandoned);//
                    w.Write(i.Ended);//
                    w.Write(i.ObjectivesCompleted.Length);//
                    for (int x = 0; x < i.ObjectivesCompleted.Length; x++)
                    {
                        w.Write(i.ObjectivesCompleted[x]);//
                        w.Write(i.ObjectivesAmountCompleted[x]);//
                        w.Write(i.ObjectivesAmountNeeded[x]);//
                        w.Write(i.ObjectivesShownCompletedMessage[x]);//
                    }
                    w.Write(i.IsPickupMission);//
                    w.Write(i.RanStartRewards);//
                }
                w.Write(s.SectorDataBlocks.Count); //Console.WriteLine($"Writed: SectorDataBlock[].Length -> {s.SectorDataBlocks.Count}");
                foreach (var i in s.SectorDataBlocks)
                {
                    w.Write(i.ID);
                    w.Write((int)i.Type);
                    w.Write(i.FactionStrength);
                    w.Write(i.Faction);
                    w.Write(i.SectorPosition.x);
                    w.Write(i.SectorPosition.y);
                    w.Write(i.SectorPosition.z);
                    w.Write(i.SectorName);
                    w.Write(i.MissionSpecificID);
                    w.Write(i.LockedToFaction);
                    w.Write(i.LastCalculatedSectorStrength);
                    w.Write(i.IsPartOfLongRangeWarpNetwork);
                    w.Write(i.Visited);
                    w.Write(i.BiscuitsSoldCounter);
                    w.Write(i.HasPED);
                    if (i.HasPED)
                    {
                        WriteDictionaryIntTPDE(i.PED.m_TraderInfoDictionary, w);
                        WriteDictionaryIntSENE(i.PED.m_SpecialNetObjectPersistantData, w);
                        WriteDictionaryIntBool(i.PED.m_PickupObjectPersistantData, w);
                        WriteDictionaryIntBool(i.PED.m_PickupComponentPersistantData, w);
                        WriteDictionaryIntBool(i.PED.m_PickupRandomComponentPersistantData, w);
                        WriteDictionaryIntBool(i.PED.m_ProbePickupPersistantData, w);
                        WriteDictionaryStringString(i.PED.m_MiscPersistantData, w);
                        WriteDictionaryStringDPO(i.PED.m_DPOPersistantData, w);
                        WriteDictionaryStringDSO(i.PED.m_DSOPersistantData, w);
                        if (i.AdditionalSaveData != null)
                        {
                            w.Write(i.AdditionalSaveData.Length);
                            w.Write(i.AdditionalSaveData);
                        }
                        else
                            w.Write(0);
                        w.Write(i.DroppedItems.Count);
                        foreach(var x in i.DroppedItems)
                        {
                            w.Write(x.ItemHash);
                            w.Write(x.Position.x);
                            w.Write(x.Position.y);
                            w.Write(x.Position.z);
                            w.Write(x.SubHubID);
                            w.Write(x.InteriorID);
                        }
                    }
                    else
                    {
                        //w.Write(false);
                        w.Write(0);
                        w.Write(0);
                        w.Write(0);
                        w.Write(0);
                        w.Write(0);
                        w.Write(0);
                        w.Write(0);
                        w.Write(0);
                        w.Write(0);
                        w.Write(0);
                        w.Write(0);
                    }
                }

                w.Write(s.AIData);

                return _ms.ToArray();
            }
        }

        private static void WriteDictionaryIntTPDE(Dictionary<int, TraderPersistantDataEntry> inDictionary, BinaryWriter inWriter)
        {
            int num = 0;
            foreach (int key in inDictionary.Keys)
            {
                _ = (int)key;
                num++;
            }
            inWriter.Write(num);
            //Console.WriteLine("Writed TPDE with length " + num);
            foreach (int key2 in inDictionary.Keys)
            {
                int num2 = key2;
                inWriter.Write(num2);
                TraderPersistantDataEntry traderPersistantDataEntry = inDictionary[num2];
                inWriter.Write(traderPersistantDataEntry.ServerWareIDCounter);
                int num3 = 0;
                foreach (int key3 in traderPersistantDataEntry.m_Wares.Keys)
                {
                    if (traderPersistantDataEntry.m_Wares[key3] != null)
                    {
                        num3++;
                    }
                }
                inWriter.Write(num3);
                //Console.WriteLine("| Writed TPDE.m_Wars with length " + num3);
                foreach (int key4 in traderPersistantDataEntry.m_Wares.Keys)
                {
                    PLWare pLWare = traderPersistantDataEntry.m_Wares[key4];
                    if (pLWare != null)
                    {
                        inWriter.Write(pLWare.isComp);
                        inWriter.Write(pLWare.getHash());
                    }
                }
            }
        }

        private static void WriteDictionaryIntSENE(Dictionary<int, PLSpecialEncounterNetObjectPersistantData> inDictionary, BinaryWriter inWriter)
        {
            int num = 0;
            foreach (int key in inDictionary.Keys)
            {
                num++;
            }
            inWriter.Write(num);
            //Console.WriteLine("Writed SENE with length " + num);
            foreach (int key2 in inDictionary.Keys)
            {
                int num2 = key2;
                inWriter.Write(num2);
                inWriter.Write(inDictionary[num2].PersistantState);
            }
        }

        private static void WriteDictionaryIntBool(Dictionary<int, bool> inDictionary, BinaryWriter inWriter)
        {
            int num = 0;
            foreach (int key in inDictionary.Keys)
            {
                num++;
            }
            inWriter.Write(num);
            //Console.WriteLine("Writed IntBool with length " + num);
            foreach (int key2 in inDictionary.Keys)
            {
                int num2 = key2;
                inWriter.Write(num2);
                inWriter.Write(inDictionary[num2]);
            }
        }

        private static void WriteDictionaryStringString(Dictionary<string, string> inDictionary, BinaryWriter inWriter)
        {
            int num = 0;
            foreach (string key in inDictionary.Keys)
            {
                num++;
            }
            inWriter.Write(num);
            //Console.WriteLine("Writed StringString with length " + num);
            foreach (string key2 in inDictionary.Keys)
            {
                string text = key2;
                inWriter.Write(text);
                inWriter.Write(inDictionary[text]);
            }
        }

        private static void WriteDictionaryStringDPO(Dictionary<string, PLDPOPersistantData> inDictionary, BinaryWriter inWriter)
        {
            int num = 0;
            foreach (string key in inDictionary.Keys)
            {
                num++;
            }
            inWriter.Write(num);
            //Console.WriteLine("Writed StringDPO with length " + num);
            foreach (string key2 in inDictionary.Keys)
            {
                string text = key2;
                inWriter.Write(text);
                inWriter.Write(inDictionary[text].Health);
                inWriter.Write(inDictionary[text].DestroyedMsgSent);
                inWriter.Write(inDictionary[text].RepairedMsgSent);
            }
        }

        private static void WriteDictionaryStringDSO(Dictionary<string, PLDSOPersistantData> inDictionary, BinaryWriter inWriter)
        {
            int num = 0;
            foreach (string key in inDictionary.Keys)
            {
                num++;
            }
            inWriter.Write(num);
            //Console.WriteLine("Writed StringDSO with length " + num);
            foreach (string key2 in inDictionary.Keys)
            {
                string text = key2;
                inWriter.Write(text);
                inWriter.Write(inDictionary[text].Health);
                inWriter.Write(inDictionary[text].DestroyedMsgSent);
            }
        }
    }

    public static class AAAAAAAAAAAAAAAAAAAAA
	{
        public static T D<T>(this T t)
		{
            Console.WriteLine(t);
            return t;
		}
	}
}
