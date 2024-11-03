# --------------------------------------------------
# DB Browser for SQLite https://sqlitebrowser.org/
#
#
# --------------------------------------------------

pragma encoding = 'UTF-8';
DROP TABLE IF EXISTS `another_paper`;
CREATE TABLE IF NOT EXISTS `another_paper` (
  `paper_id` int(10) NOT NULL default '0',
  `char_id` int(10) default NULL,
  `paper_value` bigint(20) default NULL,
  `paper_lv` tinyint(3) default NULL,
  PRIMARY KEY  (`paper_id`)
);

DROP TABLE IF EXISTS `avar`;
CREATE TABLE IF NOT EXISTS `avar` (
  `account_id` int(10) NOT NULL,
  `values` blob NOT NULL,
  PRIMARY KEY  (`account_id`)
);

DROP TABLE IF EXISTS `bbs`;
CREATE TABLE IF NOT EXISTS `bbs` (
  `postid` INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,
  `bbsid` int(10) NOT NULL default '0',
  `postdate` datetime NOT NULL default '1970-01-01 00:00:00',
  `charid` int(10) NOT NULL default '0',
  `name` varchar(30) NOT NULL default ' ',
  `title` varchar(256) NOT NULL default ' ',
  `content` varchar(256) NOT NULL default ' '
);


DROP TABLE IF EXISTS `char`;
CREATE TABLE IF NOT EXISTS `char` (
  `char_id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `account_id` int(10) NOT NULL,
  `name` varchar(30) NOT NULL,
  `firstname` varchar(30) NOT NULL default 'Testing',
  `showfirstname` tinyint(3) NOT NULL default '0',
  `race` tinyint(4) NOT NULL,
  `usingpaper_id` smallint(5) NOT NULL default '0',
  `title_id` smallint(5) NOT NULL default '0',
  `gender` tinyint(3) NOT NULL,
  `hairStyle` smallint(5) NOT NULL,
  `hairColor` tinyint(3) NOT NULL,
  `wig` smallint(5) NOT NULL,
  `face` smallint(5) NOT NULL,
  `job` tinyint(3) NOT NULL,
  `lv` tinyint(3) NOT NULL,
  `lv1` tinyint(3) NOT NULL default '0',
  `jointjlv` tinyint(3) NOT NULL default '1',
  `jlv1` tinyint(3) NOT NULL,
  `jlv2x` tinyint(3) NOT NULL,
  `jlv2t` tinyint(3) NOT NULL,
  `jlv3` tinyint(3) NOT NULL,
  `questRemaining` smallint(5) NOT NULL,
  `fame` int(10) NOT NULL default '0',
  `questresettime` datetime NOT NULL default '2000-01-01 00:00:00',
  `slot` tinyint(3) default NULL,
  `mapID` int(10) NOT NULL,
  `x` tinyint(3) NOT NULL,
  `y` tinyint(3) NOT NULL,
  `save_map` int(10) NOT NULL default '0',
  `save_x` tinyint(3) NOT NULL default '0',
  `save_y` tinyint(3) NOT NULL default '0',
  `dir` tinyint(3) NOT NULL,
  `hp` int(10) NOT NULL,
  `max_hp` int(10) NOT NULL,
  `mp` int(10) NOT NULL,
  `max_mp` int(10) NOT NULL,
  `sp` int(10)  NOT NULL,
  `max_sp` int(10) NOT NULL,
  `ep` int(10)  NOT NULL default '0',
  `eplogindate` datetime NOT NULL default '2000-01-01 00:00:00',
  `epgreetingdate` datetime NOT NULL default '2000-01-01 00:00:00',
  `epused` smallint(6) NOT NULL default '0',
  `tailStyle` tinyint(3) NOT NULL default '0',
  `wingStyle` tinyint(3) NOT NULL default '0',
  `wingColor` tinyint(3) NOT NULL default '0',
  `online` tinyint(4) NOT NULL default '0',
  `cl` smallint(6) NOT NULL default '9',
  `str` smallint(5) NOT NULL,
  `dex` smallint(5) NOT NULL,
  `intel` smallint(5) NOT NULL,
  `vit` smallint(5) NOT NULL,
  `agi` smallint(6) NOT NULL,
  `mag` smallint(6) NOT NULL,
  `statspoint` smallint(5) NOT NULL default '0',
  `skillpoint` smallint(5) NOT NULL default '0',
  `skillpoint2x` smallint(5) NOT NULL default '0',
  `skillpoint2t` smallint(5) NOT NULL default '0',
  `skillpoint3` smallint(5) NOT NULL default '0',
  `exstatpoint`  smallint(5) NOT NULL default '0',
  `explorerEXP` bigint(10) NOT NULL default '0',
  `exskillpoint` tinyint(3) NOT NULL default '0',
  `gold` bigint(10) NOT NULL default '0',
  `cp` int(10) NOT NULL default '0',
  `ecoin` int(10) NOT NULL default '0',
  `cexp` bigint(10) NOT NULL default '0',
  `jexp` bigint(10) NOT NULL default '0',
  `jjexp` bigint(10) NOT NULL default '0',
  `wrp` int(11) NOT NULL default '0',
  `possession_target` int(10) NOT NULL default '0',
  `questid` int(10) NOT NULL default '0',
  `questendtime` datetime default NULL,
  `queststatus` tinyint(3) NOT NULL default '1',
  `questcurrentcount1` int(11) NOT NULL default '0',
  `questcurrentcount2` int(11) NOT NULL default '0',
  `questcurrentcount3` int(11) NOT NULL default '0',
  `party` int(10) NOT NULL default '0',
  `ring` int(10) NOT NULL default '0',
  `golem` int(10) NOT NULL default '0',
  `WaitType` tinyint(3) NOT NULL default '0',
  `abyssfloor` int(10) NOT NULL default '0',
  
  `DualJobID` tinyint(3) NOT NULL default '0'
);

DROP TABLE IF EXISTS `cvar`;
CREATE TABLE IF NOT EXISTS `cvar` (
  `char_id` int(10) NOT NULL,
  `values` blob NOT NULL,
  PRIMARY KEY  (`char_id`)
);

DROP TABLE IF EXISTS `dualjob`;
--
-- 副職業相關
--
CREATE TABLE IF NOT EXISTS `dualjob`
(
  `recordID` varchar(36) NOT NULL,
  `char_id` int(10) NOT NULL,
  `series_id` int(10) NOT NULL,
  `level` tinyint(3) NOT NULL default '1',
  `exp` bigint(20) default '0',
  PRIMARY KEY  (`recordID`)
);
CREATE INDEX 'searchIndex' ON dualjob(`char_id`,`series_id`);


DROP TABLE IF EXISTS `dualjob_skill`;
--
-- 副職技能記錄
--
CREATE TABLE IF NOT EXISTS `dualjob_skill` 
(
  `recordid` varchar(36) NOT NULL,
  `char_id` int(10) NOT NULL,
  `series_id` tinyint(3)  NOT NULL,
  `skill_id` int(10)  NOT NULL,
  `skill_level` tinyint(3)  NOT NULL,
  PRIMARY KEY  (`recordid`)
);
CREATE INDEX 'char_id_series_id' ON dualjob_skill(`char_id`,`series_id`);

DROP TABLE IF EXISTS `ff`;
CREATE TABLE IF NOT EXISTS `ff` (
  `ff_id` int(10)  NOT NULL default '0',
  `ring_id` int(10)  NOT NULL default '0',
  `name` varchar(50) NOT NULL default '',
  `content` text NOT NULL,
  `level` int(10) NOT NULL default '0',
  PRIMARY KEY  (`ff_id`)
);

DROP TABLE IF EXISTS `ff_furniture`;
CREATE TABLE IF NOT EXISTS `ff_furniture` (
  `ff_id` int(10) NOT NULL default '0',
  `place` tinyint(3) NOT NULL default '0',
  `item_id` int(10) NOT NULL default '0',
  `pict_id` int(10) NOT NULL default '0',
  `x` smallint(6) NOT NULL default '0',
  `y` smallint(6) NOT NULL default '0',
  `z` smallint(6) NOT NULL default '0',
  `xaxis` smallint(6) NOT NULL default '0',
  `yaxis` smallint(6) NOT NULL default '0',
  `zaxis` smallint(6) NOT NULL default '0',
  `motion` smallint(11) NOT NULL default '0',
  `name` varchar(50) NOT NULL default ''
);

DROP TABLE IF EXISTS `fgarden`;
CREATE TABLE IF NOT EXISTS `fgarden` (
  `fgarden_id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `account_id` int(10) NOT NULL default '0',
  `part1` int(10) NOT NULL default '0',
  `part2` int(10) NOT NULL default '0',
  `part3` int(10) NOT NULL default '0',
  `part4` int(10) NOT NULL default '0',
  `part5` int(10) NOT NULL default '0',
  `part6` int(10) NOT NULL default '0',
  `part7` int(10) NOT NULL default '0',
  `part8` int(10) NOT NULL default '0',
  `fuel` int(10) NOT NULL default '0'
);
CREATE INDEX 'account_id' ON fgarden(`account_id`);

DROP TABLE IF EXISTS `fgarden_furniture`;
CREATE TABLE IF NOT EXISTS `fgarden_furniture` (
  `fgarden_id` int(10) NOT NULL default '0',
  `place` tinyint(3) NOT NULL default '0',
  `item_id` int(10) NOT NULL default '0',
  `pict_id` int(10) NOT NULL default '0',
  `x` smallint(6) NOT NULL default '0',
  `y` smallint(6) NOT NULL default '0',
  `z` smallint(6) NOT NULL default '0',
  `xaxis` smallint(6) NOT NULL default '0',
  `yaxis` smallint(6) NOT NULL default '0',
  `zaxis` smallint(6) NOT NULL default '0',
  `dir` smallint(5) NOT NULL default '0',
  `motion` smallint(5) NOT NULL default '0',
  `name` varchar(50) NOT NULL default ' '
);
CREATE INDEX 'fgarden_id' ON fgarden_furniture(`fgarden_id`);

DROP TABLE IF EXISTS `friend`;
CREATE TABLE IF NOT EXISTS `friend` (
  `char_id` int(10) NOT NULL,
  `friend_char_id` int(10) NOT NULL
);
CREATE INDEX 'char_id' ON friend(`char_id`);
CREATE INDEX 'friend_char_id' ON friend(`friend_char_id`);

DROP TABLE IF EXISTS `gifts`;
CREATE TABLE IF NOT EXISTS `gifts` (
  `GiftID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `a_id` int(11) NOT NULL default '0',
  `mail_id` int(11) NOT NULL default '0',
  `sender` varchar(50) NOT NULL,
  `title` varchar(50) NOT NULL,
  `postdate` datetime NOT NULL,
  `itemid1` int(11) NOT NULL,
  `itemid2` int(11) NOT NULL,
  `itemid3` int(11) NOT NULL,
  `itemid4` int(11) NOT NULL,
  `itemid5` int(11) NOT NULL,
  `itemid6` int(11) NOT NULL,
  `itemid7` int(11) NOT NULL,
  `itemid8` int(11) NOT NULL,
  `itemid9` int(11) NOT NULL,
  `itemid10` int(11) NOT NULL,
  `count1` int(11) NOT NULL,
  `count2` int(11) NOT NULL,
  `count3` int(11) NOT NULL,
  `count4` int(11) NOT NULL,
  `count5` int(11) NOT NULL,
  `count6` int(11) NOT NULL,
  `count7` int(11) NOT NULL,
  `count8` int(11) NOT NULL,
  `count9` int(11) NOT NULL,
  `count10` int(11) NOT NULL
);

DROP TABLE IF EXISTS `inventory`;
CREATE TABLE IF NOT EXISTS `inventory` (
  `char_id` int(10) NOT NULL default '0',
  `data` blob,
  PRIMARY KEY  (`char_id`)
);

DROP TABLE IF EXISTS `levellimit`;
CREATE TABLE IF NOT EXISTS `levellimit` (
  `NowLevelLimit` int(10) NOT NULL default '30',
  `NextLevelLimit` int(10) NOT NULL default '40',
  `SetNextUpLevel` int(10) NOT NULL,
  `LastTimeLevelLimit` int(10) NOT NULL default '110',
  `SetNextUpDays` int(10) NOT NULL default '30',
  `ReachTime` datetime NOT NULL,
  `NextTime` datetime NOT NULL,
  `FirstPlayer` int(10) NOT NULL default '0',
  `SecondPlayer` int(10) NOT NULL default '0',
  `ThirdPlayer` int(10) NOT NULL default '0',
  `FourthPlayer` int(10) NOT NULL default '0',
  `FifthPlayer` int(10) NOT NULL default '0',
  `IsLock` tinyint(3) NOT NULL default '0'
);

DROP TABLE IF EXISTS `log`;
CREATE TABLE IF NOT EXISTS `log` (
  `eventType` varchar(20) NOT NULL,
  `eventTime` datetime NOT NULL,
  `src` varchar(50) NOT NULL,
  `dst` varchar(50) default NULL,
  `detail` varchar(1024) default NULL
);

DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `account_id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `username` varchar(30) NOT NULL,
  `password` varchar(32) NOT NULL,
  `deletepass` varchar(32) NOT NULL,
  `banned` tinyint(3) NOT NULL default '0',
  `gmlevel` tinyint(3) NOT NULL default '0',
  `bank` int(10) NOT NULL default '0',
  `vshop_points` int(10) NOT NULL default '0',
  `used_vshop_points` int(10) NOT NULL default '0',
  `lastip` varchar(20) default NULL,
  `questresettime` datetime default '2000-01-01 00:00:00',
  `lastlogintime` datetime default '2000-01-01 00:00:00',
  `macaddress` varchar(15) default '',
  `playernames` varchar(50) default ''
);


DROP TABLE IF EXISTS `mails`;
/*
 * 郵件用
 */
CREATE TABLE IF NOT EXISTS `mails` 
(
  `char_id` int(10) default NULL,
  `name` TEXT,
  `title` TEXT,
  `content` TEXT,
  `postdate` datetime default NULL
);

DROP TABLE IF EXISTS `mobstates`;
CREATE TABLE IF NOT EXISTS `mobstates` (
  `char_id` int(10) NOT NULL,
  `mob_id` int(10) NOT NULL,
  `state` tinyint(1) NOT NULL default '0',
  PRIMARY KEY  (`char_id`)
);

DROP TABLE IF EXISTS `npcstates`;
CREATE TABLE IF NOT EXISTS `npcstates` (
  `char_id` int(10) NOT NULL,
  `npc_id` int(10) NOT NULL,
  `state` tinyint(1) default '0',
  PRIMARY KEY  (`char_id`)
);

DROP TABLE IF EXISTS `partner`;
CREATE TABLE IF NOT EXISTS `partner` (
  `apid` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `pid` int(10) NOT NULL,
  `name` varchar(30) default NULL,
  `lv` tinyint(3) NOT NULL default '1',
  `tlv` tinyint(3) NOT NULL default '1',
  `rb` tinyint(3) NOT NULL,
  `rank` tinyint(3) NOT NULL,
  `perkspoints` smallint(5) NOT NULL,
  `perk0` tinyint(3) NOT NULL,
  `perk1` tinyint(3) NOT NULL,
  `perk2` tinyint(3) NOT NULL,
  `perk3` tinyint(3) NOT NULL,
  `perk4` tinyint(3) NOT NULL,
  `perk5` tinyint(3) NOT NULL,
  `aimode` tinyint(3) NOT NULL,
  `basicai1` tinyint(3) NOT NULL,
  `basicai2` tinyint(3) NOT NULL,
  `hp` int(10) NOT NULL,
  `maxhp` int(10) NOT NULL,
  `mp` int(10) NOT NULL,
  `maxmp` int(10) NOT NULL,
  `sp` int(10) NOT NULL,
  `maxsp` int(10) NOT NULL,
  `nextfeedtime` datetime NOT NULL default '2000-01-01 00:00:00',
  `exp` bigint(10) NOT NULL default '0',
  `pictid` int(10) NOT NULL default '0',
  `reliabilityuprate` smallint(5) NOT NULL default '0',
  `texp` bigint(10) NOT NULL default '0'
);

-- 得解決兩個 primary key 加 自動遞號，否則無法與 MySQL 資料架構一致。
DROP TABLE IF EXISTS `partnerai`;
CREATE TABLE IF NOT EXISTS `partnerai` (
  `parthnerai_id` INTEGER PRIMARY KEY AUTOINCREMENT,
  `apid` int(10) NOT NULL,
  `type` tinyint(4) NOT NULL,
  `index` tinyint(4) NOT NULL,
  `value` smallint(5) NOT NULL
  --PRIMARY KEY ('index','parthnerai_id')
);
CREATE INDEX 'partneraiIndex' ON partnerai(`parthnerai_id`,`index`);


DROP TABLE IF EXISTS `partnercube`;
CREATE TABLE IF NOT EXISTS `partnercube` (
  `partnercube_id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `apid` int(10)  NOT NULL,
  `type` tinyint(4) NOT NULL,
  `unique_id` smallint(5)  NOT NULL
);

DROP TABLE IF EXISTS `partnerequip`;
CREATE TABLE IF NOT EXISTS `partnerequip` (
  `partnerequip_id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `apid` int(10)  NOT NULL,
  `type` tinyint(4) NOT NULL,
  `item_id` int(10)  NOT NULL,
  `count` smallint(5)  NOT NULL
);


DROP TABLE IF EXISTS `party`;
CREATE TABLE IF NOT EXISTS `party` (
  `party_id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `name` varchar(30) NOT NULL,
  `leader` int(10) NOT NULL default '0'
);


DROP TABLE IF EXISTS `partymember`;
CREATE TABLE IF NOT EXISTS `partymember` (
  `party_id` int(10) NOT NULL,
  `index` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `char_id` int(10) NOT NULL
);
CREATE INDEX 'party_id' ON partymember(`party_id`);


DROP TABLE IF EXISTS `questinfo`;
CREATE TABLE IF NOT EXISTS `questinfo` (
  `char_id` int(10) NOT NULL,
  `object_id` int(10) NOT NULL,
  `count` int(10) NOT NULL default '0',
  `totalcount` int(10) NOT NULL default '0',
  `infinish` tinyint(3) NOT NULL default '0',
  PRIMARY KEY  (`char_id`)
);


DROP TABLE IF EXISTS `ring`;
CREATE TABLE IF NOT EXISTS `ring` (
  `ring_id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `name` varchar(50) NOT NULL default ' ',
  `leader` int(10) NOT NULL default '0',
  `fame` int(10) NOT NULL default '0',
  `emblem` blob,
  `emblem_date` datetime default NULL,
  `ff_id` int(10) default '0'
);

DROP TABLE IF EXISTS `ringmember`;
CREATE TABLE IF NOT EXISTS `ringmember` (
  `ring_id` int(10) NOT NULL,
  `char_id` int(10) NOT NULL,
  `right` int(10) NOT NULL
);
CREATE INDEX 'ring_id' ON ringmember(`ring_id`);

DROP TABLE IF EXISTS `skill`;
CREATE TABLE IF NOT EXISTS `skill` (
  `char_id` int(10) NOT NULL,
  `skills` blob NOT NULL,
  `jobbasic` int(10) default NULL,
  `joblv` tinyint(3) default NULL,
  `jobexp` bigint(20) default NULL,
  `skillpoint` smallint(10) default NULL,
  `skillpoint2x` smallint(10) default NULL,
  `skillpoint2t` smallint(10) default NULL,
  `skillpoint3` smallint(10) default NULL,
  PRIMARY KEY  (`char_id`)
);

DROP TABLE IF EXISTS `slist`;
CREATE TABLE IF NOT EXISTS `slist` (
  `ServerVarID` varchar(36) default 'uuid()',
  `name` varchar(36) default NULL,
  `key` varchar(36) default NULL,
  `type` tinyint(3) default NULL,
  `content` varchar(36) default NULL
);

DROP TABLE IF EXISTS `stamp`;
CREATE TABLE IF NOT EXISTS `stamp` (
  `char_id` int(10) NOT NULL default '0',
  `stamp_id` tinyint(3) NOT NULL default '0',
  `value` smallint(6) NOT NULL default '0',
  PRIMARY KEY  (`char_id`,`stamp_id`)
);

DROP TABLE IF EXISTS `svar`;
CREATE TABLE IF NOT EXISTS `svar` (
  `name` varchar(25) NOT NULL,
  `type` tinyint(3) NOT NULL default '0',
  `content` varchar(25) NOT NULL,
  PRIMARY KEY  (`name`)
);


DROP TABLE IF EXISTS `tamairelending`;
CREATE TABLE IF NOT EXISTS `tamairelending` (
  `char_id` int(10) NOT NULL default '0',
  `jobtype` tinyint(3) NOT NULL default '0',
  `baselv` tinyint(3) NOT NULL default '0',
  `postdue` datetime NOT NULL default '2000-01-01 00:00:00',
  `comment` varchar(256) NOT NULL default ' ',
  `renter1` int(10) NOT NULL default '0',
  `renter2` int(10) NOT NULL default '0',
  `renter3` int(10) NOT NULL default '0',
  `renter4` int(10) NOT NULL default '0',
  PRIMARY KEY  (`char_id`)
);

DROP TABLE IF EXISTS `tamairerental`;
CREATE TABLE IF NOT EXISTS `tamairerental` (
  `char_id` int(10) NOT NULL default '0',
  `rentdue` datetime NOT NULL default '2000-01-01 00:00:00',
  `currentlender` int(10) NOT NULL default '0',
  `lastlender` int(10) NOT NULL default '0',
  PRIMARY KEY  (`char_id`)
);


DROP TABLE IF EXISTS `titleprerequisites`;
CREATE TABLE IF NOT EXISTS `titleprerequisites` (
  `char_id` int(10) NOT NULL,
  `prerequisite_id` int(10) NOT NULL,
  `progress` bigint(10) NOT NULL default '0',
  PRIMARY KEY  (`char_id`)
);


DROP TABLE IF EXISTS `titlestates`;
CREATE TABLE IF NOT EXISTS `titlestates` (
  `char_id` int(10)  NOT NULL,
  `title_id` int(10)  NOT NULL,
  `state` tinyint(3) NOT NULL default '0',
  PRIMARY KEY  (`char_id`)
);


DROP TABLE IF EXISTS `warehouse`;
CREATE TABLE IF NOT EXISTS `warehouse` (
  `account_id` int(10) NOT NULL default '0',
  `data` blob,
  PRIMARY KEY  (`account_id`)
);

DROP TABLE IF EXISTS `apiitem`;
CREATE TABLE `apiitem` (
  `apiitem_id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `char_id` int(10)  NOT NULL,
  `item_id` int(10)  NOT NULL,
  `qty` smallint(5)  NOT NULL DEFAULT '1',
  `request_time` datetime NOT NULL,
  `process_time` datetime DEFAULT NULL,
  `status` tinyint(4) NOT NULL DEFAULT '0'
);