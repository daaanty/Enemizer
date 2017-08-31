﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemizerLibrary
{
    public static class RoomIdConstants
    {
        public static string GetRoomName(int roomId)
        {
            string roomName;

            if (roomNames.TryGetValue(roomId, out roomName))
            {
                return roomName;
            }

            return null;
        }
        static Dictionary<int, string> roomNames = new Dictionary<int, string>()
        {
            { 0, "Ganon" },
            { 1, "Hyrule Castle (North Corridor)" },
            { 2, "Hyrule Castle (Switch Room)" },
            { 3, "Houlihan Room" },
            { 4, "Turtle Rock (Crysta-roller Room)" },
            { 5, "Empty Clone Room" },
            { 6, "Swamp Palace (Arrghus[Boss])" },
            { 7, "Tower of Hera (Moldorm[Boss])" },
            { 8, "Cave (Healing Fairy)" },
            { 9, "Palace of Darkness" },
            { 10, "Palace of Darkness (Stalfos Trap Room)" },
            { 11, "Palace of Darkness (Turtle Room)" },
            { 12, "Ganon's Tower (Entrance Room)" },
            { 13, "Ganon's Tower (Agahnim2[Boss])" },
            { 14, "Ice Palace (Entrance Room)" },
            { 15, "Empty Clone Room" },
            { 16, "Ganon Evacuation Route" },
            { 17, "Hyrule Castle (Bombable Stock Room)" },
            { 18, "Sanctuary" },
            { 19, "Turtle Rock (Hokku-Bokku Key Room 2)" },
            { 20, "Turtle Rock (Big Key Room)" },
            { 21, "Turtle Rock" },
            { 22, "Swamp Palace (Swimming Treadmill)" },
            { 23, "Tower of Hera (Moldorm Fall Room)" },
            { 24, "Cave" },
            { 25, "Palace of Darkness (Dark Maze)" },
            { 26, "Palace of Darkness (Big Chest Room)" },
            { 27, "Palace of Darkness (Mimics / Moving Wall Room)" },
            { 28, "Ganon's Tower (Ice Armos)" },
            { 29, "Ganon's Tower (Final Hallway)" },
            { 30, "Ice Palace (Bomb Floor / Bari Room)" },
            { 31, "Ice Palace (Pengator / Big Key Room)" },
            { 32, "Agahnim's Tower (Agahnim[Boss])" },
            { 33, "Hyrule Castle (Key-rat Room)" },
            { 34, "Hyrule Castle (Sewer Text Trigger Room)" },
            { 35, "Turtle Rock (West Exit to Balcony)" },
            { 36, "Turtle Rock (Double Hokku-Bokku / Big chest Room)" },
            { 37, "Empty Clone Room" },
            { 38, "Swamp Palace (Statue Room)" },
            { 39, "Tower of Hera (Big Chest)" },
            { 40, "Swamp Palace (Entrance Room)" },
            { 41, "Skull Woods (Mothula[Boss])" },
            { 42, "Palace of Darkness (Big Hub Room)" },
            { 43, "Palace of Darkness (Map Chest / Fairy Room)" },
            { 44, "Cave" },
            { 45, "Empty Clone Room" },
            { 46, "Ice Palace (Compass Room)" },
            { 47, "Cave (Kakariko Well HP)" },
            { 48, "Agahnim's Tower (Maiden Sacrifice Chamber)" },
            { 49, "Tower of Hera (Hardhat Beetles Room)" },
            { 50, "Hyrule Castle (Sewer Key Chest Room)" },
            { 51, "Desert Palace (Lanmolas[Boss])" },
            { 52, "Swamp Palace (Push Block Puzzle / Pre-Big Key Room)" },
            { 53, "Swamp Palace (Big Key / BS Room)" },
            { 54, "Swamp Palace (Big Chest Room)" },
            { 55, "Swamp Palace (Map Chest / Water Fill Room)" },
            { 56, "Swamp Palace (Key Pot Room)" },
            { 57, "Skull Woods (Gibdo Key / Mothula Hole Room)" },
            { 58, "Palace of Darkness (Bombable Floor Room)" },
            { 59, "Palace of Darkness (Spike Block / Conveyor Room)" },
            { 60, "Cave" },
            { 61, "Ganon's Tower (Torch Room 2)" },
            { 62, "Ice Palace (Stalfos Knights / Conveyor Hellway)" },
            { 63, "Ice Palace (Map Chest Room)" },
            { 64, "Agahnim's Tower (Final Bridge Room)" },
            { 65, "Hyrule Castle (First Dark Room)" },
            { 66, "Hyrule Castle (6 Ropes Room)" },
            { 67, "Desert Palace (Torch Puzzle / Moving Wall Room)" },
            { 68, "Thieves Town (Big Chest Room)" },
            { 69, "Thieves Town (Jail Cells Room)" },
            { 70, "Swamp Palace (Compass Chest Room)" },
            { 71, "Empty Clone Room" },
            { 72, "Empty Clone Room" },
            { 73, "Skull Woods (Gibdo Torch Puzzle Room)" },
            { 74, "Palace of Darkness (Entrance Room)" },
            { 75, "Palace of Darkness (Warps / South Mimics Room)" },
            { 76, "Ganon's Tower (Mini-Helmasaur Conveyor Room)" },
            { 77, "Ganon's Tower (Moldorm Room)" },
            { 78, "Ice Palace (Bomb-Jump Room)" },
            { 79, "Ice Palace Clone Room (Fairy Room)" },
            { 80, "Hyrule Castle (West Corridor)" },
            { 81, "Hyrule Castle (Throne Room)" },
            { 82, "Hyrule Castle (East Corridor)" },
            { 83, "Desert Palace (Popos 2 / Beamos Hellway Room)" },
            { 84, "Swamp Palace (Upstairs Pits Room)" },
            { 85, "Castle Secret Entrance / Uncle Death Room" },
            { 86, "Skull Woods (Key Pot / Trap Room)" },
            { 87, "Skull Woods (Big Key Room)" },
            { 88, "Skull Woods (Big Chest Room)" },
            { 89, "Skull Woods (Final Section Entrance Room)" },
            { 90, "Palace of Darkness (Helmasaur King[Boss])" },
            { 91, "Ganon's Tower (Spike Pit Room)" },
            { 92, "Ganon's Tower (Ganon-Ball Z)" },
            { 93, "Ganon's Tower (Gauntlet 1/2/3)" },
            { 94, "Ice Palace (Lonely Firebar)" },
            { 95, "Ice Palace (Hidden Chest / Spike Floor Room)" },
            { 96, "Hyrule Castle (West Entrance Room)" },
            { 97, "Hyrule Castle (Main Entrance Room)" },
            { 98, "Hyrule Castle (East Entrance Room)" },
            { 99, "Desert Palace (Final Section Entrance Room)" },
            { 100, "Thieves Town (West Attic Room)" },
            { 101, "Thieves Town (East Attic Room)" },
            { 102, "Swamp Palace (Hidden Chest / Hidden Door Room)" },
            { 103, "Skull Woods (Compass Chest Room)" },
            { 104, "Skull Woods (Key Chest / Trap Room)" },
            { 105, "Empty Clone Room" },
            { 106, "Palace of Darkness (Rupee Room)" },
            { 107, "Ganon's Tower (Mimics Rooms)" },
            { 108, "Ganon's Tower (Lanmolas Room)" },
            { 109, "Ganon's Tower (Gauntlet 4/5)" },
            { 110, "Ice Palace (Pengators Room)" },
            { 111, "Empty Clone Room" },
            { 112, "Hyrule Castle (Small Corridor to Jail Cells)" },
            { 113, "Hyrule Castle (Boomerang Chest Room)" },
            { 114, "Hyrule Castle (Map Chest Room)" },
            { 115, "Desert Palace (Big Chest Room)" },
            { 116, "Desert Palace (Map Chest Room)" },
            { 117, "Desert Palace (Big Key Chest Room)" },
            { 118, "Swamp Palace (Water Drain Room)" },
            { 119, "Tower of Hera (Entrance Room)" },
            { 120, "Empty Clone Room" },
            { 121, "Empty Clone Room" },
            { 122, "Empty Clone Room" },
            { 123, "Ganon's Tower" },
            { 124, "Ganon's Tower (East Side Collapsing Bridge / Exploding Wall Room)" },
            { 125, "Ganon's Tower (Winder / Warp Maze Room)" },
            { 126, "Ice Palace (Hidden Chest / Bombable Floor Room)" },
            { 127, "Ice Palace ( Big Spike Traps Room)" },
            { 128, "Hyrule Castle (Jail Cell Room)" },
            { 129, "Hyrule Castle" },
            { 130, "Hyrule Castle (Basement Chasm Room)" },
            { 131, "Desert Palace (West Entrance Room)" },
            { 132, "Desert Palace (Main Entrance Room)" },
            { 133, "Desert Palace (East Entrance Room)" },
            { 134, "Empty Clone Room" },
            { 135, "Tower of Hera (Tile Room)" },
            { 136, "Empty Clone Room" },
            { 137, "Eastern Palace (Fairy Room)" },
            { 138, "Empty Clone Room" },
            { 139, "Ganon's Tower (Block Puzzle / Spike Skip / Map Chest Room)" },
            { 140, "Ganon's Tower (East and West Downstairs / Big Chest Room)" },
            { 141, "Ganon's Tower (Tile / Torch Puzzle Room)" },
            { 142, "Ice Palace" },
            { 143, "Empty Clone Room" },
            { 144, "Misery Mire (Vitreous[Boss])" },
            { 145, "Misery Mire (Final Switch Room)" },
            { 146, "Misery Mire (Dark Bomb Wall / Switches Room)" },
            { 147, "Misery Mire (Dark Cane Floor Switch Puzzle Room)" },
            { 148, "Empty Clone Room" },
            { 149, "Ganon's Tower (Final Collapsing Bridge Room)" },
            { 150, "Ganon's Tower (Torches 1 Room)" },
            { 151, "Misery Mire (Torch Puzzle / Moving Wall Room)" },
            { 152, "Misery Mire (Entrance Room)" },
            { 153, "Eastern Palace (Eyegore Key Room)" },
            { 154, "Empty Clone Room" },
            { 155, "Ganon's Tower (Many Spikes / Warp Maze Room)" },
            { 156, "Ganon's Tower (Invisible Floor Maze Room)" },
            { 157, "Ganon's Tower (Compass Chest / Invisible Floor Room)" },
            { 158, "Ice Palace (Big Chest Room)" },
            { 159, "Ice Palace" },
            { 160, "Misery Mire (Pre-Vitreous Room)" },
            { 161, "Misery Mire (Fish Room)" },
            { 162, "Misery Mire (Bridge Key Chest Room)" },
            { 163, "Misery Mire" },
            { 164, "Turtle Rock (Trinexx[Boss])" },
            { 165, "Ganon's Tower (Wizzrobes Rooms)" },
            { 166, "Ganon's Tower (Moldorm Fall Room)" },
            { 167, "Tower of Hera (Fairy Room)" },
            { 168, "Eastern Palace (Stalfos Spawn Room)" },
            { 169, "Eastern Palace (Big Chest Room)" },
            { 170, "Eastern Palace (Map Chest Room)" },
            { 171, "Thieves Town (Moving Spikes / Key Pot Room)" },
            { 172, "Thieves Town (Blind The Thief[Boss])" },
            { 173, "Empty Clone Room" },
            { 174, "Ice Palace" },
            { 175, "Ice Palace (Ice Bridge Room)" },
            { 176, "Agahnim's Tower (Circle of Pots)" },
            { 177, "Misery Mire (Hourglass Room)" },
            { 178, "Misery Mire (Slug Room)" },
            { 179, "Misery Mire (Spike Key Chest Room)" },
            { 180, "Turtle Rock (Pre-Trinexx Room)" },
            { 181, "Turtle Rock (Dark Maze)" },
            { 182, "Turtle Rock (Chain Chomps Room)" },
            { 183, "Turtle Rock (Map Chest / Key Chest / Roller Room)" },
            { 184, "Eastern Palace (Big Key Room)" },
            { 185, "Eastern Palace (Lobby Cannonballs Room)" },
            { 186, "Eastern Palace (Dark Antifairy / Key Pot Room)" },
            { 187, "Thieves Town (Hellway)" },
            { 188, "Thieves Town (Conveyor Toilet)" },
            { 189, "Empty Clone Room" },
            { 190, "Ice Palace (Block Puzzle Room)" },
            { 191, "Ice Palace Clone Room (Switch Room)" },
            { 192, "Agahnim's Tower (Dark Bridge Room)" },
            { 193, "Misery Mire (Compass Chest / Tile Room)" },
            { 194, "Misery Mire (Big Hub Room)" },
            { 195, "Misery Mire (Big Chest Room)" },
            { 196, "Turtle Rock (Final Crystal Switch Puzzle Room)" },
            { 197, "Turtle Rock (Laser Bridge)" },
            { 198, "Turtle Rock" },
            { 199, "Turtle Rock (Torch Puzzle)" },
            { 200, "Eastern Palace (Armos Knights[Boss])" },
            { 201, "Eastern Palace (Entrance Room)" },
            { 202, "??" },
            { 203, "Thieves Town (North West Entrance Room)" },
            { 204, "Thieves Town (North East Entrance Room)" },
            { 205, "Empty Clone Room" },
            { 206, "Ice Palace (Hole to Kholdstare Room)" },
            { 207, "Empty Clone Room" },
            { 208, "Agahnim's Tower (Dark Maze)" },
            { 209, "Misery Mire (Conveyor Slug / Big Key Room)" },
            { 210, "Misery Mire (Mire02 / Wizzrobes Room)" },
            { 211, "Empty Clone Room" },
            { 212, "Empty Clone Room" },
            { 213, "Turtle Rock (Laser Key Room)" },
            { 214, "Turtle Rock (Entrance Room)" },
            { 215, "Empty Clone Room" },
            { 216, "Eastern Palace ('Zeldagamer Room' / Pre-Armos Knights Room)" },
            { 217, "Eastern Palace (Canonball Room)" },
            { 218, "Eastern Palace" },
            { 219, "Thieves Town (Main (South West) Entrance Room)" },
            { 220, "Thieves Town (South East Entrance Room)" },
            { 221, "Empty Clone Room" },
            { 222, "Ice Palace (Kholdstare[Boss])" },
            { 223, "Cave" },
            { 224, "Agahnim's Tower (Entrance Room)" },
            { 225, "Cave (Lost Woods HP)" },
            { 226, "Cave (Lumberjack's Tree HP)" },
            { 227, "Cave (1/2 Magic)" },
            { 228, "Cave (Lost Old Man Final Cave)" },
            { 229, "Cave (Lost Old Man Final Cave)" },
            { 230, "Cave" },
            { 231, "Cave" },
            { 232, "Cave" },
            { 233, "Empty Clone Room" },
            { 234, "Cave (Spectacle Rock HP)" },
            { 235, "Cave" },
            { 236, "Empty Clone Room" },
            { 237, "Cave" },
            { 238, "Cave (Spiral Cave)" },
            { 239, "Cave (Crystal Switch / 5 Chests Room)" },
            { 240, "Cave (Lost Old Man Starting Cave)" },
            { 241, "Cave (Lost Old Man Starting Cave)" },
            { 242, "House" },
            { 243, "House (Old Woman (Sahasrahla's Wife?))" },
            { 244, "House (Angry Brothers)" },
            { 245, "House (Angry Brothers)" },
            { 246, "Empty Clone Room" },
            { 247, "Empty Clone Room" },
            { 248, "Cave" },
            { 249, "Cave" },
            { 250, "Cave" },
            { 251, "Cave" },
            { 252, "Empty Clone Room" },
            { 253, "Cave" },
            { 254, "Cave" },
            { 255, "Cave " },
            { 267, "Swamp Floodway Room" },
            { 268, "Mimic Cave" },
            { 291, "Mini-Moldorm Cave" }
    };


        public static readonly int
            R0_Ganon = 0,
            R1_HyruleCastle_NorthCorridor = 1,
            R2_HyruleCastle_SwitchRoom = 2,
            R3_HoulihanRoom = 3,
            R4_TurtleRock_CrystalRollerRoom = 4,
            R5_EmptyCloneRoom0x05 = 5,
            R6_SwampPalace_Arrghus = 6,
            R7_TowerofHera_Moldorm = 7,
            R8_Cave_HealingFairy = 8,
            R9_PalaceofDarkness0x09 = 9,
            R10_PalaceofDarkness_StalfosTrapRoom = 10,
            R11_PalaceofDarkness_TurtleRoom = 11,
            R12_GanonsTower_EntranceRoom = 12,
            R13_GanonsTower_Agahnim2 = 13,
            R14_IcePalace_EntranceRoom = 14,
            R15_EmptyCloneRoom0x0F = 15,
            R16_GanonEvacuationRoute = 16,
            R17_HyruleCastle_BombableStockRoom = 17,
            R18_Sanctuary = 18,
            R19_TurtleRock_Hokku_BokkuKeyRoom2 = 19,
            R20_TurtleRock_BigKeyRoom = 20,
            R21_TurtleRock0x15 = 21,
            R22_SwampPalace_SwimmingTreadmill = 22,
            R23_TowerofHera_MoldormFallRoom = 23,
            R24_Cave0x18 = 24,
            R25_PalaceofDarkness_DarkMaze = 25,
            R26_PalaceofDarkness_BigChestRoom = 26,
            R27_PalaceofDarkness_Mimics_MovingWallRoom = 27,
            R28_GanonsTower_IceArmos = 28,
            R29_GanonsTower_FinalHallway = 29,
            R30_IcePalace_BombFloor_BariRoom = 30,
            R31_IcePalace_Pengator_BigKeyRoom = 31,
            R32_AgahnimsTower_Agahnim = 32,
            R33_HyruleCastle_KeyRatRoom = 33,
            R34_HyruleCastle_SewerTextTriggerRoom = 34,
            R35_TurtleRock_WestExittoBalcony = 35,
            R36_TurtleRock_DoubleHokku_Bokku_BigchestRoom = 36,
            R37_EmptyCloneRoom0x25 = 37,
            R38_SwampPalace_StatueRoom = 38,
            R39_TowerofHera_BigChest = 39,
            R40_SwampPalace_EntranceRoom = 40,
            R41_SkullWoods_Mothula = 41,
            R42_PalaceofDarkness_BigHubRoom = 42,
            R43_PalaceofDarkness_MapChest_FairyRoom = 43,
            R44_Cave0x2C = 44,
            R45_EmptyCloneRoom0x2D = 45,
            R46_IcePalace_CompassRoom = 46,
            R47_Cave_KakarikoWellHP = 47,
            R48_AgahnimsTower_MaidenSacrificeChamber = 48,
            R49_TowerofHera_HardhatBeetlesRoom = 49,
            R50_HyruleCastle_SewerKeyChestRoom = 50,
            R51_DesertPalace_Lanmolas = 51,
            R52_SwampPalace_PushBlockPuzzle_Pre_BigKeyRoom = 52,
            R53_SwampPalace_BigKey_BSRoom = 53,
            R54_SwampPalace_BigChestRoom = 54,
            R55_SwampPalace_MapChest_WaterFillRoom = 55,
            R56_SwampPalace_KeyPotRoom = 56,
            R57_SkullWoods_GibdoKey_MothulaHoleRoom = 57,
            R58_PalaceofDarkness_BombableFloorRoom = 58,
            R59_PalaceofDarkness_SpikeBlock_ConveyorRoom = 59,
            R60_Cave0x3C = 60,
            R61_GanonsTower_TorchRoom2 = 61,
            R62_IcePalace_StalfosKnights_ConveyorHellway = 62,
            R63_IcePalace_MapChestRoom = 63,
            R64_AgahnimsTower_FinalBridgeRoom = 64,
            R65_HyruleCastle_FirstDarkRoom = 65,
            R66_HyruleCastle_6RopesRoom = 66,
            R67_DesertPalace_TorchPuzzle_MovingWallRoom = 67,
            R68_ThievesTown_BigChestRoom = 68,
            R69_ThievesTown_JailCellsRoom = 69,
            R70_SwampPalace_CompassChestRoom = 70,
            R71_EmptyCloneRoom0x47 = 71,
            R72_EmptyCloneRoom0x48 = 72,
            R73_SkullWoods_GibdoTorchPuzzleRoom = 73,
            R74_PalaceofDarkness_EntranceRoom = 74,
            R75_PalaceofDarkness_Warps_SouthMimicsRoom = 75,
            R76_GanonsTower_Mini_HelmasaurConveyorRoom = 76,
            R77_GanonsTower_MoldormRoom = 77,
            R78_IcePalace_Bomb_JumpRoom = 78,
            R79_IcePalaceCloneRoom_FairyRoom = 79,
            R80_HyruleCastle_WestCorridor = 80,
            R81_HyruleCastle_ThroneRoom = 81,
            R82_HyruleCastle_EastCorridor = 82,
            R83_DesertPalace_Popos2_BeamosHellwayRoom = 83,
            R84_SwampPalace_UpstairsPitsRoom = 84,
            R85_CastleSecretEntrance_UncleDeathRoom = 85,
            R86_SkullWoods_KeyPot_TrapRoom = 86,
            R87_SkullWoods_BigKeyRoom = 87,
            R88_SkullWoods_BigChestRoom = 88,
            R89_SkullWoods_FinalSectionEntranceRoom = 89,
            R90_PalaceofDarkness_HelmasaurKing = 90,
            R91_GanonsTower_SpikePitRoom = 91,
            R92_GanonsTower_Ganon_BallZ = 92,
            R93_GanonsTower_Gauntlet1_2_3 = 93,
            R94_IcePalace_LonelyFirebar = 94,
            R95_IcePalace_HiddenChest_SpikeFloorRoom = 95,
            R96_HyruleCastle_WestEntranceRoom = 96,
            R97_HyruleCastle_MainEntranceRoom = 97,
            R98_HyruleCastle_EastEntranceRoom = 98,
            R99_DesertPalace_FinalSectionEntranceRoom = 99,
            R100_ThievesTown_WestAtticRoom = 100,
            R101_ThievesTown_EastAtticRoom = 101,
            R102_SwampPalace_HiddenChest_HiddenDoorRoom = 102,
            R103_SkullWoods_CompassChestRoom = 103,
            R104_SkullWoods_KeyChest_TrapRoom = 104,
            R105_EmptyCloneRoom0x69 = 105,
            R106_PalaceofDarkness_RupeeRoom = 106,
            R107_GanonsTower_MimicsRooms = 107,
            R108_GanonsTower_LanmolasRoom = 108,
            R109_GanonsTower_Gauntlet4_5 = 109,
            R110_IcePalace_PengatorsRoom = 110,
            R111_EmptyCloneRoom0x6F = 111,
            R112_HyruleCastle_SmallCorridortoJailCells = 112,
            R113_HyruleCastle_BoomerangChestRoom = 113,
            R114_HyruleCastle_MapChestRoom = 114,
            R115_DesertPalace_BigChestRoom = 115,
            R116_DesertPalace_MapChestRoom = 116,
            R117_DesertPalace_BigKeyChestRoom = 117,
            R118_SwampPalace_WaterDrainRoom = 118,
            R119_TowerofHera_EntranceRoom = 119,
            R120_EmptyCloneRoom0x78 = 120,
            R121_EmptyCloneRoom0x79 = 121,
            R122_EmptyCloneRoom0x7A = 122,
            R123_GanonsTower = 123,
            R124_GanonsTower_EastSideCollapsingBridge_ExplodingWallRoom = 124,
            R125_GanonsTower_Winder_WarpMazeRoom = 125,
            R126_IcePalace_HiddenChest_BombableFloorRoom = 126,
            R127_IcePalace_BigSpikeTrapsRoom = 127,
            R128_HyruleCastle_JailCellRoom = 128,
            R129_HyruleCastle_NextToChasmRoom = 129,
            R130_HyruleCastle_BasementChasmRoom = 130,
            R131_DesertPalace_WestEntranceRoom = 131,
            R132_DesertPalace_MainEntranceRoom = 132,
            R133_DesertPalace_EastEntranceRoom = 133,
            R134_EmptyCloneRoom0x86 = 134,
            R135_TowerofHera_TileRoom = 135,
            R136_EmptyCloneRoom0x88 = 136,
            R137_EasternPalace_FairyRoom = 137,
            R138_EmptyCloneRoom0x8A = 138,
            R139_GanonsTower_BlockPuzzle_SpikeSkip_MapChestRoom = 139,
            R140_GanonsTower_EastandWestDownstairs_BigChestRoom = 140,
            R141_GanonsTower_Tile_TorchPuzzleRoom = 141,
            R142_IcePalace0x8E = 142,
            R143_EmptyCloneRoom0x8F = 143,
            R144_MiseryMire_Vitreous = 144,
            R145_MiseryMire_FinalSwitchRoom = 145,
            R146_MiseryMire_DarkBombWall_SwitchesRoom = 146,
            R147_MiseryMire_DarkCaneFloorSwitchPuzzleRoom = 147,
            R148_EmptyCloneRoom0x94 = 148,
            R149_GanonsTower_FinalCollapsingBridgeRoom = 149,
            R150_GanonsTower_Torches1Room = 150,
            R151_MiseryMire_TorchPuzzle_MovingWallRoom = 151,
            R152_MiseryMire_EntranceRoom = 152,
            R153_EasternPalace_EyegoreKeyRoom = 153,
            R154_EmptyCloneRoom0x9A = 154,
            R155_GanonsTower_ManySpikes_WarpMazeRoom = 155,
            R156_GanonsTower_InvisibleFloorMazeRoom = 156,
            R157_GanonsTower_CompassChest_InvisibleFloorRoom = 157,
            R158_IcePalace_BigChestRoom = 158,
            R159_IcePalace0x9F = 159,
            R160_MiseryMire_Pre_VitreousRoom = 160,
            R161_MiseryMire_FishRoom = 161,
            R162_MiseryMire_BridgeKeyChestRoom = 162,
            R163_MiseryMire0xA3 = 163,
            R164_TurtleRock_Trinexx = 164,
            R165_GanonsTower_WizzrobesRooms = 165,
            R166_GanonsTower_MoldormFallRoom = 166,
            R167_TowerofHera_FairyRoom = 167,
            R168_EasternPalace_StalfosSpawnRoom = 168,
            R169_EasternPalace_BigChestRoom = 169,
            R170_EasternPalace_MapChestRoom = 170,
            R171_ThievesTown_MovingSpikes_KeyPotRoom = 171,
            R172_ThievesTown_BlindTheThief = 172,
            R173_EmptyCloneRoom0xAD = 173,
            R174_IcePalace0xAE = 174,
            R175_IcePalace_IceBridgeRoom = 175,
            R176_AgahnimsTower_CircleofPots = 176,
            R177_MiseryMire_HourglassRoom = 177,
            R178_MiseryMire_SlugRoom = 178,
            R179_MiseryMire_SpikeKeyChestRoom = 179,
            R180_TurtleRock_Pre_TrinexxRoom = 180,
            R181_TurtleRock_DarkMaze = 181,
            R182_TurtleRock_ChainChompsRoom = 182,
            R183_TurtleRock_MapChest_KeyChest_RollerRoom = 183,
            R184_EasternPalace_BigKeyRoom = 184,
            R185_EasternPalace_LobbyCannonballsRoom = 185,
            R186_EasternPalace_DarkAntifairy_KeyPotRoom = 186,
            R187_ThievesTown_Hellway = 187,
            R188_ThievesTown_ConveyorToilet = 188,
            R189_EmptyCloneRoom0xBD = 189,
            R190_IcePalace_BlockPuzzleRoom = 190,
            R191_IcePalaceCloneRoom_SwitchRoom = 191,
            R192_AgahnimsTower_DarkBridgeRoom = 192,
            R193_MiseryMire_CompassChest_TileRoom = 193,
            R194_MiseryMire_BigHubRoom = 194,
            R195_MiseryMire_BigChestRoom = 195,
            R196_TurtleRock_FinalCrystalSwitchPuzzleRoom = 196,
            R197_TurtleRock_LaserBridge = 197,
            R198_TurtleRock0xC6 = 198,
            R199_TurtleRock_TorchPuzzle = 199,
            R200_EasternPalace_ArmosKnights = 200,
            R201_EasternPalace_EntranceRoom = 201,
            R202_UnknownRoom = 202,
            R203_ThievesTown_NorthWestEntranceRoom = 203,
            R204_ThievesTown_NorthEastEntranceRoom = 204,
            R205_EmptyCloneRoom0xCD = 205,
            R206_IcePalace_HoletoKholdstareRoom = 206,
            R207_EmptyCloneRoom0xCF = 207,
            R208_AgahnimsTower_DarkMaze = 208,
            R209_MiseryMire_ConveyorSlug_BigKeyRoom = 209,
            R210_MiseryMire_Mire02_WizzrobesRoom = 210,
            R211_EmptyCloneRoom0xD3 = 211,
            R212_EmptyCloneRoom0xD4 = 212,
            R213_TurtleRock_LaserKeyRoom = 213,
            R214_TurtleRock_EntranceRoom = 214,
            R215_EmptyCloneRoom0xD7 = 215,
            R216_EasternPalace_PreArmosKnightsRoom = 216,
            R217_EasternPalace_CanonballRoom = 217,
            R218_EasternPalace = 218,
            R219_ThievesTown_Main_SouthWestEntranceRoom = 219,
            R220_ThievesTown_SouthEastEntranceRoom = 220,
            R221_EmptyCloneRoom0xDD = 221,
            R222_IcePalace_Kholdstare = 222,
            R223_Cave0xDF = 223,
            R224_AgahnimsTower_EntranceRoom = 224,
            R225_Cave_LostWoodsHP = 225,
            R226_Cave_LumberjacksTreeHP = 226,
            R227_Cave_HalfMagic = 227,
            R228_Cave_LostOldManFinalCave = 228,
            R229_Cave_LostOldManFinalCave2 = 229,
            R230_Cave0xE6 = 230,
            R231_Cave0xE7 = 231,
            R232_Cave0xE8 = 232,
            R233_EmptyCloneRoom0xE9 = 233,
            R234_Cave_SpectacleRockHP = 234,
            R235_Cave0xEB = 235,
            R236_EmptyCloneRoom0xEC = 236,
            R237_Cave0xED = 237,
            R238_Cave_SpiralCave = 238,
            R239_Cave_CrystalSwitch_5ChestsRoom = 239,
            R240_Cave_LostOldManStartingCave = 240,
            R241_Cave_LostOldManStartingCave2 = 241,
            R242_House = 242,
            R243_House_OldWoman_SahasrahlasWifeMaybe = 243,
            R244_House_AngryBrothers = 244,
            R245_House_AngryBrothers2 = 245,
            R246_EmptyCloneRoom0xE6 = 246,
            R247_EmptyCloneRoom0xE7 = 247,
            R248_Cave0xF8 = 248,
            R249_Cave0xF9 = 249,
            R250_Cave0xFA = 250,
            R251_Cave0xFB = 251,
            R252_EmptyCloneRoom0xFC = 252,
            R253_Cave0xFD = 253,
            R254_Cave0xFE = 254,
            R255_Cave0xFF = 255,
            R267_SwampFloodwayRoom = 267,
            R268_MimicCave = 268,
            R291_MiniMoldormCave = 291;

        //All the rooms that need every sprite dead for doors to open
        public static readonly int[] NeedKillable_doors =
        {
            R11_PalaceofDarkness_TurtleRoom,
            R27_PalaceofDarkness_Mimics_MovingWallRoom,
            R36_TurtleRock_DoubleHokku_Bokku_BigchestRoom,
            R40_SwampPalace_EntranceRoom,
            R46_IcePalace_CompassRoom,
            R49_TowerofHera_HardhatBeetlesRoom,
            R62_IcePalace_StalfosKnights_ConveyorHellway,
            R68_ThievesTown_BigChestRoom,
            R75_PalaceofDarkness_Warps_SouthMimicsRoom,
            R83_DesertPalace_Popos2_BeamosHellwayRoom,
            R93_GanonsTower_Gauntlet1_2_3,
            R107_GanonsTower_MimicsRooms,
            R109_GanonsTower_Gauntlet4_5,
            R110_IcePalace_PengatorsRoom,
            R113_HyruleCastle_BoomerangChestRoom,
            R117_DesertPalace_BigKeyChestRoom,
            R123_GanonsTower,
            R125_GanonsTower_Winder_WarpMazeRoom,
            R133_DesertPalace_EastEntranceRoom,
            R135_TowerofHera_TileRoom,
            R141_GanonsTower_Tile_TorchPuzzleRoom,
            R165_GanonsTower_WizzrobesRooms,
            R168_EasternPalace_StalfosSpawnRoom,
            R176_AgahnimsTower_CircleofPots,
            R178_MiseryMire_SlugRoom,
            R182_TurtleRock_ChainChompsRoom,
            R210_MiseryMire_Mire02_WizzrobesRoom,
            R216_EasternPalace_PreArmosKnightsRoom,
            R224_AgahnimsTower_EntranceRoom,
            R239_Cave_CrystalSwitch_5ChestsRoom,
            R268_MimicCave,
            R291_MiniMoldormCave
        };
        //room 113 is not in needkillable is it in key_sprite?

        //All the rooms that require special handling
        public static readonly int[] IcemanRoom =
        {
            R14_IcePalace_EntranceRoom,
            R126_IcePalace_HiddenChest_BombableFloorRoom,
            R142_IcePalace0x8E,
            R158_IcePalace_BigChestRoom,
            R190_IcePalace_BlockPuzzleRoom
        }; //these room need to be locked on the gfx ID : 28

        public static readonly int[] WaterRoom =
        {
            R22_SwampPalace_SwimmingTreadmill,
            R40_SwampPalace_EntranceRoom,
            R52_SwampPalace_PushBlockPuzzle_Pre_BigKeyRoom,
            R54_SwampPalace_BigChestRoom,
            R56_SwampPalace_KeyPotRoom,
            R70_SwampPalace_CompassChestRoom,
            R102_SwampPalace_HiddenChest_HiddenDoorRoom
        }; //these room need to be locked on the gfx ID : 17 //118 removed

        public static readonly int[] ShadowRoom =
        {
            R62_IcePalace_StalfosKnights_ConveyorHellway,
            R159_IcePalace0x9F
        };//28,27,30

        public static readonly int[] WallMasterRoom =
        {
            R57_SkullWoods_GibdoKey_MothulaHoleRoom,
            R73_SkullWoods_GibdoTorchPuzzleRoom,
            R86_SkullWoods_KeyPot_TrapRoom,
            R104_SkullWoods_KeyChest_TrapRoom,
            R141_GanonsTower_Tile_TorchPuzzleRoom
        };//force 82 on 3

        public static readonly int[] bumperandcrystalRoom =
        {
            R23_TowerofHera_MoldormFallRoom,
            R4_TurtleRock_CrystalRollerRoom,
            R11_PalaceofDarkness_TurtleRoom,
            R19_TurtleRock_Hokku_BokkuKeyRoom2,
            R27_PalaceofDarkness_Mimics_MovingWallRoom,
            R30_IcePalace_BombFloor_BariRoom,
            R42_PalaceofDarkness_BigHubRoom,
            R43_PalaceofDarkness_MapChest_FairyRoom,
            R49_TowerofHera_HardhatBeetlesRoom,
            R68_ThievesTown_BigChestRoom,
            R76_GanonsTower_Mini_HelmasaurConveyorRoom,
            R88_SkullWoods_BigChestRoom,
            R89_SkullWoods_FinalSectionEntranceRoom,
            R91_GanonsTower_SpikePitRoom,
            R103_SkullWoods_CompassChestRoom,
            R104_SkullWoods_KeyChest_TrapRoom,
            R107_GanonsTower_MimicsRooms,
            R119_TowerofHera_EntranceRoom,
            R135_TowerofHera_TileRoom,
            R139_GanonsTower_BlockPuzzle_SpikeSkip_MapChestRoom,
            R145_MiseryMire_FinalSwitchRoom,
            R150_GanonsTower_Torches1Room,
            R146_MiseryMire_DarkBombWall_SwitchesRoom,
            R155_GanonsTower_ManySpikes_WarpMazeRoom,
            R157_GanonsTower_CompassChest_InvisibleFloorRoom,
            R161_MiseryMire_FishRoom,
            R171_ThievesTown_MovingSpikes_KeyPotRoom,
            R182_TurtleRock_ChainChompsRoom,
            R191_IcePalaceCloneRoom_SwitchRoom,
            R193_MiseryMire_CompassChest_TileRoom,
            R196_TurtleRock_FinalCrystalSwitchPuzzleRoom,
            R235_Cave0xEB,
            R64_AgahnimsTower_FinalBridgeRoom,
            R74_PalaceofDarkness_EntranceRoom,
            R165_GanonsTower_WizzrobesRooms,
            R195_MiseryMire_BigChestRoom,
            R197_TurtleRock_LaserBridge,
            R213_TurtleRock_LaserKeyRoom,
            R214_TurtleRock_EntranceRoom,
            R239_Cave_CrystalSwitch_5ChestsRoom,
            R61_GanonsTower_TorchRoom2,
            R126_IcePalace_HiddenChest_BombableFloorRoom
        };//also laser shooting eyes //can be 82 or 83 on 3
        //126 IR,

        public static readonly int[] SwitchesRoom =
        {
            R2_HyruleCastle_SwitchRoom,
            R88_SkullWoods_BigChestRoom,
            R100_ThievesTown_WestAtticRoom,
            R267_SwampFloodwayRoom
        };// WM, ?? 73:no switch in that room

        public static readonly int[] TonguesRoom =
        {
            R4_TurtleRock_CrystalRollerRoom,
            R35_TurtleRock_WestExittoBalcony,
            R53_SwampPalace_BigKey_BSRoom,
            R55_SwampPalace_MapChest_WaterFillRoom,
            R63_IcePalace_MapChestRoom,
            R118_SwampPalace_WaterDrainRoom,
            R206_IcePalace_HoletoKholdstareRoom
        };

        //byte[] PushSwitchesRoom = { 53, 55, 118 }; //83 same as tongue

        public static readonly int[] noStatueRoom =
        {
            R22_SwampPalace_SwimmingTreadmill,
            R38_SwampPalace_StatueRoom,
            R40_SwampPalace_EntranceRoom,
            R43_PalaceofDarkness_MapChest_FairyRoom,
            R52_SwampPalace_PushBlockPuzzle_Pre_BigKeyRoom,
            R54_SwampPalace_BigChestRoom,
            R70_SwampPalace_CompassChestRoom,
            R87_SkullWoods_BigKeyRoom,
            R118_SwampPalace_WaterDrainRoom,
            R177_MiseryMire_HourglassRoom,
            R194_MiseryMire_BigHubRoom,
            R208_AgahnimsTower_DarkMaze
        }; //do not generate statue in these rooms
        //ROOM 127 do not spawn  anti-faerie

        public static readonly int[] canonRoom =
        {
            R92_GanonsTower_Ganon_BallZ,
            R117_DesertPalace_BigKeyChestRoom
        }; //47 on 0

        public static readonly int[] canonRoom2 =
        {
            R185_EasternPalace_LobbyCannonballsRoom,
            R217_EasternPalace_CanonballRoom,
            R268_MimicCave
        };//46 on 2


    }
}
