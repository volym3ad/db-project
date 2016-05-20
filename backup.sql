-- MySqlBackup.NET 2.0.9.3
-- Dump Time: 2016-05-20 12:43:09
-- --------------------------------------
-- Server version 5.6.17 MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of players
-- 

DROP TABLE IF EXISTS `players`;
CREATE TABLE IF NOT EXISTS `players` (
  `Name` varchar(30) NOT NULL,
  `Position` varchar(20) NOT NULL,
  `Team` varchar(20) NOT NULL,
  `Shoots` varchar(10) NOT NULL,
  `Height` float unsigned NOT NULL,
  `Weight` float unsigned NOT NULL,
  `Experience` tinyint(3) unsigned NOT NULL,
  PRIMARY KEY (`Name`),
  KEY `Team` (`Team`),
  CONSTRAINT `players_ibfk_1` FOREIGN KEY (`Team`) REFERENCES `team` (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table players
-- 

/*!40000 ALTER TABLE `players` DISABLE KEYS */;
INSERT INTO `players`(`Name`,`Position`,`Team`,`Shoots`,`Height`,`Weight`,`Experience`) VALUES
('Anderson Varejao','Center','GSW','R',6.1,273,12),
('Andre Iguodala','Small Forward','GSW','R',6.6,207,12),
('Andrew Bogut','Center','GSW','R',7,260,11),
('LaMarcus Aldridge','Power Forward','SA','R',6.11,240,10),
('Lebron James','Small Forward','CLE','R',6.8,250,13),
('Tim Duncan','Power Forward','SA','R',6.11,250,19);
/*!40000 ALTER TABLE `players` ENABLE KEYS */;

-- 
-- Definition of statistics
-- 

DROP TABLE IF EXISTS `statistics`;
CREATE TABLE IF NOT EXISTS `statistics` (
  `Position` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `Wins` tinyint(3) unsigned NOT NULL,
  `Loss` tinyint(3) unsigned NOT NULL,
  PRIMARY KEY (`Position`,`Name`),
  KEY `Name` (`Name`),
  CONSTRAINT `statistics_ibfk_1` FOREIGN KEY (`Name`) REFERENCES `team` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table statistics
-- 

/*!40000 ALTER TABLE `statistics` DISABLE KEYS */;
INSERT INTO `statistics`(`Position`,`Name`,`Wins`,`Loss`) VALUES
(1,'GSW',73,9),
(2,'SA',67,15),
(3,'CLE',57,25),
(4,'TOR',56,26),
(5,'OKL',55,27);
/*!40000 ALTER TABLE `statistics` ENABLE KEYS */;

-- 
-- Definition of team
-- 

DROP TABLE IF EXISTS `team`;
CREATE TABLE IF NOT EXISTS `team` (
  `Name` varchar(20) NOT NULL,
  `City` varchar(20) NOT NULL,
  `State` varchar(20) NOT NULL,
  `Head_Coach` varchar(20) NOT NULL,
  `PPG` float unsigned NOT NULL,
  `Amount_of_Titles` tinyint(3) unsigned NOT NULL,
  PRIMARY KEY (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table team
-- 

/*!40000 ALTER TABLE `team` DISABLE KEYS */;
INSERT INTO `team`(`Name`,`City`,`State`,`Head_Coach`,`PPG`,`Amount_of_Titles`) VALUES
('CLE','Cleveland','Ohio','Tyronn Lue',114.73,0),
('GSW','Oakland','California','Steve Kerr',246.298,4),
('OKL','Oklahoma City','Oklahoma','Billy Donovan',110.2,1),
('SA','San Antonio','Texas','Gregg Popovich',103.5,5),
('TOR','Toronto','Ontario','Dwane Casey',112.97,0);
/*!40000 ALTER TABLE `team` ENABLE KEYS */;

-- 
-- Dumping views
-- 

DROP TABLE IF EXISTS `myview`;
DROP VIEW IF EXISTS `myview`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `myview` AS select `team`.`Name` AS `Name`,`team`.`PPG` AS `PPG`,`statistics`.`Wins` AS `Wins`,`statistics`.`Loss` AS `Loss` from (`team` join `statistics` on((`team`.`Name` = `statistics`.`Name`)));



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2016-05-20 12:43:09
-- Total time: 0:0:0:0:148 (d:h:m:s:ms)
