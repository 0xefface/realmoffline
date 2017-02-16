/*
Navicat MySQL Data Transfer

Source Server         : Local
Source Server Version : 50621
Source Host           : localhost:3306
Source Database       : realmemu

Target Server Type    : MYSQL
Target Server Version : 50621
File Encoding         : 65001

Date: 2015-01-25 13:22:28
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `affects`
-- ----------------------------
DROP TABLE IF EXISTS `affects`;
CREATE TABLE `affects` (
  `CharId` int(11) NOT NULL,
  `Unarmed_Attack_Fire` tinyint(1) NOT NULL DEFAULT '0',
  `Unarmed_Attack_Cold` tinyint(1) NOT NULL DEFAULT '0',
  `Unarmed_Attack_Lightning` tinyint(1) NOT NULL DEFAULT '0',
  `Unarmed_Attack_Acid` tinyint(1) NOT NULL DEFAULT '0',
  `Unarmed_Attack_Poison` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown1` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown2` tinyint(1) NOT NULL DEFAULT '0',
  `Unarmed_Attack_Exp_Drain` tinyint(1) NOT NULL DEFAULT '0',
  `Unarmed_Attack_Exp_Steal` tinyint(1) NOT NULL DEFAULT '0',
  `Unarmed_Attack_Life_Steal` tinyint(1) NOT NULL DEFAULT '0',
  `Unarmed_Attack_Rust` tinyint(1) NOT NULL DEFAULT '0',
  `Can_Hit_Etheral` tinyint(1) NOT NULL DEFAULT '0',
  `Unarmed_Attack_Stun` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown3` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown4` tinyint(1) NOT NULL DEFAULT '0',
  `Improved_Unarmed_Attack_Damage` tinyint(1) NOT NULL DEFAULT '0',
  `Can_See_Invis` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown5` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown6` tinyint(1) NOT NULL DEFAULT '0',
  `Defenseless` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown7` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown8` tinyint(1) NOT NULL DEFAULT '0',
  `Fire_Immolated` tinyint(1) NOT NULL DEFAULT '0',
  `Cold_Immolated` tinyint(1) NOT NULL DEFAULT '0',
  `Acid_Immolated` tinyint(1) NOT NULL DEFAULT '0',
  `Poison_Immolated` tinyint(1) NOT NULL DEFAULT '0',
  `Lightning_Immolated` tinyint(1) NOT NULL DEFAULT '0',
  `Frozen` tinyint(1) NOT NULL DEFAULT '0',
  `Held` tinyint(1) NOT NULL DEFAULT '0',
  `Confused` tinyint(1) NOT NULL DEFAULT '0',
  `Unable_To_Flee_Combat` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown9` tinyint(1) NOT NULL DEFAULT '0',
  `Berzerked` tinyint(1) NOT NULL DEFAULT '0',
  `Stunned` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown10` tinyint(1) NOT NULL DEFAULT '0',
  `Scared` tinyint(1) NOT NULL DEFAULT '0',
  `Quickened` tinyint(1) NOT NULL DEFAULT '0',
  `Slowed` tinyint(1) NOT NULL DEFAULT '0',
  `Empowered` tinyint(1) NOT NULL DEFAULT '0',
  `Enfeebled` tinyint(1) NOT NULL DEFAULT '0',
  `Shielded` tinyint(1) NOT NULL DEFAULT '0',
  `Shielded2` tinyint(1) NOT NULL DEFAULT '0',
  `Invulnerable` tinyint(1) NOT NULL DEFAULT '0',
  `Regenerating` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown11` tinyint(1) NOT NULL DEFAULT '0',
  `Cursed` tinyint(1) NOT NULL DEFAULT '0',
  `Rotting_In_Jail` tinyint(1) NOT NULL DEFAULT '0',
  `Resistant_To_Magic` tinyint(1) NOT NULL DEFAULT '0',
  `Immune_To_Magic` tinyint(1) NOT NULL DEFAULT '0',
  `Rust_Immolated` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown12` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown13` tinyint(1) NOT NULL DEFAULT '0',
  `Resurrecting_25` tinyint(1) NOT NULL DEFAULT '0',
  `Resurrecting_50` tinyint(1) NOT NULL DEFAULT '0',
  `Resurrecting_100` tinyint(1) NOT NULL DEFAULT '0',
  `Extra_Attack` tinyint(1) NOT NULL DEFAULT '0',
  `Extra_Dodge` tinyint(1) NOT NULL DEFAULT '0',
  `Spell_Memory_Protected` tinyint(1) NOT NULL DEFAULT '0',
  `Heightened_Dexterity` tinyint(1) NOT NULL DEFAULT '0',
  `Lowered_Dexterity` tinyint(1) NOT NULL DEFAULT '0',
  `Heightened_Intelligence` tinyint(1) NOT NULL DEFAULT '0',
  `Lowered_Intelligence` tinyint(1) NOT NULL DEFAULT '0',
  `Heightened_Endurance` tinyint(1) NOT NULL DEFAULT '0',
  `Lowered_Endurance` tinyint(1) NOT NULL DEFAULT '0',
  `Retention` tinyint(1) NOT NULL DEFAULT '0',
  `Vulnerable` tinyint(1) NOT NULL DEFAULT '0',
  `Nourished` tinyint(1) NOT NULL DEFAULT '0',
  `Changed_Gender` tinyint(1) NOT NULL DEFAULT '0',
  `Naked` tinyint(1) NOT NULL DEFAULT '0',
  `Ugly` tinyint(1) NOT NULL DEFAULT '0',
  `Disguised` tinyint(1) NOT NULL DEFAULT '0',
  `Encumberance_Bonus` tinyint(1) NOT NULL DEFAULT '0',
  `Encumberance_Penalty` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown14` tinyint(1) NOT NULL DEFAULT '0',
  `Shifting` tinyint(1) NOT NULL DEFAULT '0',
  `Spell_Extention` tinyint(1) NOT NULL DEFAULT '0',
  `Poisoned` tinyint(1) NOT NULL DEFAULT '0',
  `Acid_Burned` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown15` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown16` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown17` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown18` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown19` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown20` tinyint(1) NOT NULL DEFAULT '0',
  `Protected_From_Death_Magic` tinyint(1) NOT NULL DEFAULT '0',
  `Magical_Will_Increase` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown21` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown22` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown23` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown24` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown25` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown26` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown27` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown28` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown29` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown30` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown31` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown32` tinyint(1) NOT NULL DEFAULT '0',
  `Unknown33` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`CharId`),
  UNIQUE KEY `CharId` (`CharId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of affects
-- ----------------------------
INSERT INTO `affects` VALUES ('398', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');

-- ----------------------------
-- Table structure for `characters`
-- ----------------------------
DROP TABLE IF EXISTS `characters`;
CREATE TABLE `characters` (
  `Id` int(11) unsigned NOT NULL AUTO_INCREMENT COMMENT 'Unique Id For each char',
  `AccountID` int(11) unsigned NOT NULL,
  `Charname` varchar(16) NOT NULL,
  `Class` smallint(2) NOT NULL,
  `Race` smallint(1) NOT NULL,
  `Gender` smallint(1) NOT NULL,
  `Strength` smallint(1) NOT NULL,
  `Dexterity` smallint(1) NOT NULL,
  `Intelligence` smallint(1) NOT NULL,
  `Constitution` smallint(1) NOT NULL,
  `Alignment` smallint(1) NOT NULL,
  `Invis` smallint(1) NOT NULL,
  `Girth` smallint(1) NOT NULL,
  `Height` smallint(1) NOT NULL,
  `RaceHead` smallint(1) NOT NULL,
  `HeadPart` smallint(1) NOT NULL,
  `ChinPart` smallint(1) NOT NULL,
  `HairPart` smallint(1) NOT NULL,
  `EyeBrowPart` smallint(1) NOT NULL,
  `EyePart` smallint(1) NOT NULL,
  `NosePart` smallint(1) NOT NULL,
  `EarPart` smallint(1) NOT NULL,
  `MouthPart` smallint(1) NOT NULL,
  `FacialHairPart` smallint(1) NOT NULL,
  `SkinColor` smallint(1) NOT NULL,
  `HairColor` smallint(1) NOT NULL,
  `EyeColor` smallint(1) NOT NULL,
  `Title` varchar(24) NOT NULL,
  `Pvp` smallint(1) NOT NULL,
  `Biography` varchar(511) NOT NULL DEFAULT ' ',
  `Gold` int(4) NOT NULL DEFAULT '750',
  `Mana` int(4) NOT NULL DEFAULT '750',
  `Level` smallint(2) NOT NULL DEFAULT '1',
  `CurrentHP` int(4) NOT NULL DEFAULT '30',
  `TotalHP` int(4) NOT NULL DEFAULT '30',
  `BuildPoints` smallint(2) NOT NULL DEFAULT '0',
  `CurrentXP` int(4) NOT NULL DEFAULT '0',
  `IsMob` int(11) NOT NULL DEFAULT '0',
  `MobGraphic` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `CharName_Unique` (`Charname`)
) ENGINE=InnoDB AUTO_INCREMENT=399 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of characters
-- ----------------------------
INSERT INTO `characters` VALUES ('398', '51', 'Dad', '0', '0', '0', '18', '10', '10', '10', '128', '0', '90', '98', '0', '0', '0', '2', '1', '7', '4', '4', '4', '6', '2', '1', '0', ' ', '1', 'Enter personal information about your character here.', '1000000', '1000000', '1', '30', '30', '1', '0', '0', '0');

-- ----------------------------
-- Table structure for `debug`
-- ----------------------------
DROP TABLE IF EXISTS `debug`;
CREATE TABLE `debug` (
  `RowID` int(11) NOT NULL AUTO_INCREMENT,
  `AccountID` int(11) NOT NULL,
  `CharID` int(11) NOT NULL,
  `DateTime` varchar(255) NOT NULL,
  `Error` longtext NOT NULL,
  PRIMARY KEY (`RowID`),
  UNIQUE KEY `RowID` (`RowID`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of debug
-- ----------------------------

-- ----------------------------
-- Table structure for `doors`
-- ----------------------------
DROP TABLE IF EXISTS `doors`;
CREATE TABLE `doors` (
  `SqlID` int(11) NOT NULL AUTO_INCREMENT,
  `GameID` int(10) unsigned NOT NULL,
  `Room` int(10) unsigned NOT NULL,
  `LocationX` int(11) NOT NULL,
  `LocationY` int(11) NOT NULL,
  `LeadsToRoom` int(10) unsigned NOT NULL,
  `ExitX` int(11) NOT NULL,
  `ExitY` int(11) NOT NULL,
  PRIMARY KEY (`SqlID`),
  UNIQUE KEY `SqlID` (`SqlID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of doors
-- ----------------------------

-- ----------------------------
-- Table structure for `inventory`
-- ----------------------------
DROP TABLE IF EXISTS `inventory`;
CREATE TABLE `inventory` (
  `SqlID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `SqlOwnerID` int(11) unsigned NOT NULL DEFAULT '0',
  `Graphic` smallint(6) NOT NULL,
  `Color` smallint(6) NOT NULL DEFAULT '0',
  `Name` varchar(255) NOT NULL DEFAULT '',
  `Equiped` int(2) NOT NULL DEFAULT '0',
  `LookDescription` varchar(255) NOT NULL DEFAULT '',
  `ItemType` int(11) NOT NULL DEFAULT '0',
  `EquipmentSlot` int(11) NOT NULL DEFAULT '0',
  `ArmorFactor` int(11) NOT NULL DEFAULT '0',
  `Durability` int(11) NOT NULL DEFAULT '0',
  `MinDamage` int(11) NOT NULL DEFAULT '0',
  `MaxDamage` int(11) NOT NULL DEFAULT '0',
  `Enchants` blob NOT NULL,
  PRIMARY KEY (`SqlID`),
  UNIQUE KEY `SqlId` (`SqlID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of inventory
-- ----------------------------
INSERT INTO `inventory` VALUES ('1', '398', '1242', '43', '', '1', 'This is the long sought after Hood of Shifting, you got one, i would keep it a secret if i were you.', '1', '1', '45', '100', '0', '0', 0x20);
INSERT INTO `inventory` VALUES ('2', '398', '1524', '43', '', '1', 'You see the legendary Thurisaz Cowl, best when its the only thing worn.', '1', '2', '25', '100', '0', '0', 0x20);
INSERT INTO `inventory` VALUES ('3', '398', '1160', '43', '', '1', 'You see a Champion Tunic, only the bravest in the realm obtain these.', '1', '4', '135', '100', '0', '0', 0x20);
INSERT INTO `inventory` VALUES ('4', '398', '1531', '43', '', '1', 'A pair of Finvarra\'s Bracers, strong and durable, a must for any serious warrior.', '1', '5', '35', '100', '0', '0', 0x20);
INSERT INTO `inventory` VALUES ('5', '398', '1503', '43', '', '1', 'Magistrate\'s Leggings, who said judges wear nothing under their robes!', '1', '9', '85', '100', '0', '0', 0x20);
INSERT INTO `inventory` VALUES ('6', '398', '1595', '43', '', '1', 'A pair of Boots of Evasion, you\'ll never catch me now!', '1', '10', '25', '100', '0', '0', 0x20);
INSERT INTO `inventory` VALUES ('7', '398', '1538', '43', '', '1', 'A Belt of Carrying, your ready to help a friend move now!', '1', '8', '5', '100', '0', '0', 0x20);
INSERT INTO `inventory` VALUES ('8', '398', '1577', '43', '', '1', 'The powerful Spirit Sword, your enemies will quake with fear now!', '2', '12', '0', '100', '344', '1024', 0x20);
INSERT INTO `inventory` VALUES ('9', '398', '1600', '43', '', '1', 'The Amazing Shield of Infinite Though, you feel smarter just looking at it.', '1', '11', '95', '100', '0', '0', 0x20);
INSERT INTO `inventory` VALUES ('10', '398', '1609', '43', '', '1', 'A Thistlebark Sash, refinement and class all wrapped up in a bow.', '12', '15', '5', '100', '0', '0', 0x20);
INSERT INTO `inventory` VALUES ('11', '398', '1610', '43', '', '1', 'A Ring of Destruction, it hurts your finger just a little.', '8', '7', '0', '100', '0', '0', 0x20);
INSERT INTO `inventory` VALUES ('12', '398', '1610', '43', '', '1', 'A Ring of Destruction, it hurts your finger just a little.', '8', '6', '0', '100', '0', '0', 0x20);
INSERT INTO `inventory` VALUES ('13', '398', '1539', '43', '', '0', 'The Mage\'s Robe, you may not be a mage, but it still looks good.', '12', '13', '0', '100', '0', '0', 0x20);

-- ----------------------------
-- Table structure for `mail`
-- ----------------------------
DROP TABLE IF EXISTS `mail`;
CREATE TABLE `mail` (
  `CharID` int(11) NOT NULL,
  `MailID` int(11) NOT NULL,
  `TimeStamp` int(11) NOT NULL,
  `Subject` varchar(255) NOT NULL,
  `From` varchar(255) NOT NULL,
  `Body` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of mail
-- ----------------------------

-- ----------------------------
-- Table structure for `skills`
-- ----------------------------
DROP TABLE IF EXISTS `skills`;
CREATE TABLE `skills` (
  `CharID` int(11) NOT NULL COMMENT 'The character in characters table that these skills belong too',
  `Short_Sword` smallint(1) NOT NULL DEFAULT '0',
  `Long_Sword` smallint(1) NOT NULL DEFAULT '0',
  `Two_Handed` smallint(1) NOT NULL DEFAULT '0',
  `Dagger` smallint(1) NOT NULL DEFAULT '0',
  `Axe` smallint(1) NOT NULL DEFAULT '0',
  `Club` smallint(1) NOT NULL DEFAULT '0',
  `Mace` smallint(1) NOT NULL DEFAULT '0',
  `Unarmed_Combat` smallint(1) NOT NULL DEFAULT '0',
  `Throwing` smallint(1) NOT NULL DEFAULT '0',
  `Acrobatics` smallint(1) NOT NULL DEFAULT '0',
  `Maul` smallint(1) NOT NULL DEFAULT '0',
  `Sorcery` smallint(1) NOT NULL DEFAULT '0',
  `Elementalism` smallint(1) NOT NULL DEFAULT '0',
  `Mysticism` smallint(1) NOT NULL DEFAULT '0',
  `Thaumaturgy` smallint(1) NOT NULL DEFAULT '0',
  `Necromancy` smallint(1) NOT NULL DEFAULT '0',
  `Theurgism` smallint(1) NOT NULL DEFAULT '0',
  `Alchemy` smallint(1) NOT NULL DEFAULT '0',
  `Weaponsmith` smallint(1) NOT NULL DEFAULT '0',
  `Armorsmith` smallint(1) NOT NULL DEFAULT '0',
  `Unknown1` smallint(1) NOT NULL DEFAULT '0',
  `Unknown2` smallint(1) NOT NULL DEFAULT '0',
  `Unknown3` smallint(1) NOT NULL DEFAULT '0',
  `Unknown4` smallint(1) NOT NULL DEFAULT '0',
  `Unknown5` smallint(1) NOT NULL DEFAULT '0',
  `Pickpocketing` smallint(1) NOT NULL DEFAULT '0',
  `Disarm_Traps` smallint(1) NOT NULL DEFAULT '0',
  `Lockpicking` smallint(1) NOT NULL DEFAULT '0',
  `Meditation` smallint(1) NOT NULL DEFAULT '0',
  `Critical_Strike` smallint(1) NOT NULL DEFAULT '0',
  `Shield_Usage` smallint(1) NOT NULL DEFAULT '0',
  `Crafting` smallint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`CharID`),
  UNIQUE KEY `CharId` (`CharID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of skills
-- ----------------------------
INSERT INTO `skills` VALUES ('398', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '0', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');

-- ----------------------------
-- Table structure for `spells`
-- ----------------------------
DROP TABLE IF EXISTS `spells`;
CREATE TABLE `spells` (
  `CharID` int(11) NOT NULL COMMENT 'Character in characters table id',
  `Home` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Killstar` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Unlock_Spell` tinyint(1) NOT NULL DEFAULT '0',
  `Dispell_Magic` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Engrave` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Multiblade` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Gather_The_Fellowship` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Cornucopia` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Cloud_Of_Fog` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Improve_Armor` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Teleport` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Extention` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Invisibility_See` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Shift` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Invisibility` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Teleport_Combat` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Teleport_Group` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Permanency` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Rust` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Defencelessness` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Invisibility_Improved` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Enchant_Item` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Mass_Rust` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Elphames_Justice` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Fire_Grasp` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Flame_Orb` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Arctic_Grasp` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Ice_Orb` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Earth_Spike` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Incinerate` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Gust_Of_Wind` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Immolation` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Dancing_Flame` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Flame_Blade` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Electric_Charge` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Cold_Steel` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Sandstorm` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Spark` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Ice_Storm` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Freezing_Wind` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Hurricane` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Crawling_Charge` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Stoning` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Fireball` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Lightning_Bolt` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Freeze` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Crushing_Boulder` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Electric_Fury` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Cold_Snap` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Earthquake` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Despothes_Wrath` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Hold_Monster` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Fumble` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Psychic_Orb` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Confusion` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Forget` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Mind_Shackle` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Identify` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Berzerk` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Stun` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Loyalty_Shift` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Warp_Mind` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Etherealize` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Spell_Blast` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Mass_Hold` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Unknown1` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Unknown in Myst',
  `Mass_Fumble` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Fear` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Iron_Chains` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Mass_Berserk` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Mass_Stun` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Mass_Loyalty_Shift` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Mabons_Forced_Flee` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Illusionary_Foe` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Anti_Magic_Aura` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Mysticism',
  `Light_Dart` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Curse_Of_Clumsiness` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Nimbility` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Empower` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Enfeeble` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Missle_Resistance` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Heal` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Summon_Pixie` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Purify` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Cure_Poison` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Unknown2` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Heal_Greater` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Remove_Curse` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Summon_Fairy` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Curse_Fire` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Curse_Cold` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Curse_Electric` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Shield` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Shield_Greater` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Wrath_Of_The_Gods` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Shield_Fire` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Shield_Cold` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Shield_Lightning` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Summon_Nymph` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Regeneration` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Indestruction` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Invulnerability` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Enids_Blessing` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Banishment` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Summon_Fairy_Queen` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Acid_Sphere` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Venomous_Touch` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Unknown3` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Poison_Bolt` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Unknown4` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Drain_Life` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Acid_Cloud` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Summon_Zombie` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Venom` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Summon_Undead` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Acid_Rain` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Night_Friends` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Steal_Life` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Unknown5` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Summon_Doppleganger` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Death_Touch` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Banish` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Shadow_Warrior` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Summon_Daemon` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Duachs_Vengence` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Death_Wish` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Mass_Drain` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Curse_Poison` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Curse_Acid` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Necromancy',
  `Shield_Poison` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thaumaturgy',
  `Shield_Acid` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thaumaturgy',
  `Head_Of_Death` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Identify_Greater` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Summon_Monster_I` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Summon_Monster_II` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Summon_Monster_III` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Sorcery',
  `Summon_Ratling` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Summon_Bat` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Summon_Fenris` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Summon_Imp` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Summon_Orge` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Summon_Troll` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Summon_Seraph` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Unknown6` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Unknown7` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Unknown8` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Unknown9` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Unknown10` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  `Heal_Mass` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Thamaturgy',
  `Unknown11` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Elementalism',
  PRIMARY KEY (`CharID`),
  UNIQUE KEY `CharId` (`CharID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of spells
-- ----------------------------
INSERT INTO `spells` VALUES ('398', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1');

-- ----------------------------
-- Table structure for `states`
-- ----------------------------
DROP TABLE IF EXISTS `states`;
CREATE TABLE `states` (
  `CharId` int(4) NOT NULL,
  `Attacks_Per_Round` smallint(1) NOT NULL DEFAULT '0',
  `Dodges_Per_Round` smallint(1) NOT NULL DEFAULT '0',
  `Blocks_Per_Round` smallint(1) NOT NULL DEFAULT '0',
  `Damage_Low` mediumint(2) NOT NULL DEFAULT '0',
  `Damage_High` mediumint(2) NOT NULL DEFAULT '0',
  `Movement_Rate` smallint(1) NOT NULL DEFAULT '0',
  `Encumberance_Low` mediumint(2) NOT NULL DEFAULT '1',
  `Encumberance_High` mediumint(2) NOT NULL DEFAULT '100',
  `Kills_Good` int(4) NOT NULL DEFAULT '0',
  `Kills_Evil` int(4) NOT NULL DEFAULT '0',
  `Mana_Drain` int(4) NOT NULL DEFAULT '0',
  `Armor_Pierce` int(4) NOT NULL DEFAULT '0',
  `Evil_Mdm` int(4) NOT NULL DEFAULT '0',
  `Good_Mdm` int(4) NOT NULL DEFAULT '0',
  `Spell_Resists` varchar(19) NOT NULL DEFAULT 'S:0 E:0 M:0 T:0 N:0',
  `Cast_Resists` varchar(19) NOT NULL DEFAULT 'S:0 E:0 M:0 T:0 N:0',
  `Account_Type` varchar(15) NOT NULL DEFAULT 'FREE',
  `Billing_Date` mediumint(2) NOT NULL DEFAULT '2',
  `Time_Credits` mediumint(2) NOT NULL DEFAULT '0',
  `Coppers` int(4) NOT NULL DEFAULT '0',
  `Referal_Code` varchar(8) NOT NULL DEFAULT 'OFFLINE',
  `Melee_Damage_Mod` mediumint(2) NOT NULL DEFAULT '0',
  `Spell_Damage_Mod` mediumint(2) NOT NULL DEFAULT '0',
  PRIMARY KEY (`CharId`),
  UNIQUE KEY `CharId` (`CharId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of states
-- ----------------------------
INSERT INTO `states` VALUES ('398', '0', '0', '0', '0', '0', '0', '1', '100', '0', '0', '0', '0', '0', '0', 'S:0 E:0 M:0 T:0 N:0', 'S:0 E:0 M:0 T:0 N:0', 'FREE', '2', '0', '0', 'OFFLINE', '0', '0');

-- ----------------------------
-- Table structure for `users`
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(16) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `SecretWord` varchar(100) NOT NULL,
  `PLevel` int(1) NOT NULL DEFAULT '3',
  `CreatedOn` bigint(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Username_Unique` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('51', '1', '1000:LeSUkBHAiERMo6+HtZZwwyKiMcedVtSk:ZBL2nP/ZBQCxKgEHW9t5V/qD+pXgF6Kv', 'AutoCreate', 'Autocreate', '5', '-8587793873894820838');

-- ----------------------------
-- Table structure for `whatsnew`
-- ----------------------------
DROP TABLE IF EXISTS `whatsnew`;
CREATE TABLE `whatsnew` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Color` int(11) NOT NULL DEFAULT '4',
  `Message` longtext NOT NULL,
  `TimeStamp` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL DEFAULT 'ROL Emulator Staff',
  PRIMARY KEY (`ID`,`TimeStamp`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `TimeStamp` (`TimeStamp`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of whatsnew
-- ----------------------------
INSERT INTO `whatsnew` VALUES ('3', '108', 'Need stress testing done, multiple accts logged in at once.', '12/25/2014 3:17:44 PM', 'TerdSmeller');
INSERT INTO `whatsnew` VALUES ('4', '6', 'What does not work, Spells do not work and will crash you, giving items to others will not work and will crash you, picking items up in a room do not work and will crash you, may be more that will crash you too :)', '12/25/2014 3:20:18 PM', 'TerdSmeller');
INSERT INTO `whatsnew` VALUES ('6', '56', 'What does work, equiping and unequiping items, seeing other players, Magic Mail, Gossip (all), Roomchat, add fake freinds, walk around a bit and /tp list and /tp room# to teleport around.', '12/25/2014 3:24:10 PM', 'TerdSmeller');
