-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: daniel_lindsey
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `CustomerId` int NOT NULL AUTO_INCREMENT,
  `StylistId` int NOT NULL DEFAULT '0',
  `Name` varchar(255) DEFAULT NULL,
  `Email` varchar(255) NOT NULL,
  `Phone` bigint DEFAULT '0',
  `Birthday` datetime DEFAULT NULL,
  `TimesVisited` int DEFAULT NULL,
  `HaircutTypeId` int DEFAULT NULL,
  PRIMARY KEY (`CustomerId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,8,'Tiny Time','tinytime@gmail.com',6021235555,'1998-01-01 00:00:00',2,6),(2,5,'Daniel Lindsey','daniellindsey@gmail.com',1231234123,'2022-02-28 00:00:00',4,2),(4,6,'Bob Humbug','awef@awef.com',1231231234,'1975-11-19 00:00:00',9,11),(5,6,'Jack The Zipper','jack@zippersRus.com',5031235432,'1990-01-01 00:00:00',0,3),(6,3,'Jane Janerr','jane@thejanerr.com',0,'2001-01-01 00:00:00',0,1),(7,6,'Joe Low','joe@low.com',5031231234,'0001-01-01 00:00:00',0,1),(8,4,'Rudy Samwise Sean','yes@awoeirj.com',0,'0001-01-01 00:00:00',0,8),(9,4,'Cremput','aw@woij.com',1231234123,'1990-12-01 00:00:00',7,1);
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `haircuttypes`
--

DROP TABLE IF EXISTS `haircuttypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `haircuttypes` (
  `HaircutTypeId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `Cost` int NOT NULL DEFAULT '0',
  `TimeEstimate` int DEFAULT '15',
  PRIMARY KEY (`HaircutTypeId`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `haircuttypes`
--

LOCK TABLES `haircuttypes` WRITE;
/*!40000 ALTER TABLE `haircuttypes` DISABLE KEYS */;
INSERT INTO `haircuttypes` VALUES (1,'Trim',25,30),(2,'Buzz Cut',20,20),(3,'Mowhawk',40,25),(4,'Long Hair',60,60),(6,'Fade',20,15),(7,'Coloring',70,35),(8,'Eat On Job',100,5),(9,'Highlights',40,35),(10,'Shave Head',5,2),(11,'50s Slick Back look',60,15),(12,'The Flame Cut',1000,2);
/*!40000 ALTER TABLE `haircuttypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stylists`
--

DROP TABLE IF EXISTS `stylists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `Position` varchar(255) NOT NULL DEFAULT 'Stylist',
  `HireDate` datetime DEFAULT NULL,
  `HaircutTypeId` int DEFAULT '1',
  `PriorExperienceInYears` int DEFAULT '0',
  `ShiftStart` time DEFAULT NULL,
  `ShiftEnd` time DEFAULT NULL,
  `ScheduledSunday` tinyint DEFAULT '0',
  `ScheduledMonday` tinyint DEFAULT '0',
  `ScheduledTuesday` tinyint DEFAULT '0',
  `ScheduledWednesday` tinyint DEFAULT '0',
  `ScheduledThursday` tinyint DEFAULT '0',
  `ScheduledFriday` tinyint DEFAULT '0',
  `ScheduledSaturday` tinyint DEFAULT '0',
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stylists`
--

LOCK TABLES `stylists` WRITE;
/*!40000 ALTER TABLE `stylists` DISABLE KEYS */;
INSERT INTO `stylists` VALUES (1,'John','Stamos','Stylist','2022-03-01 00:00:00',5,1,'10:00:00','17:00:00',0,1,1,0,1,1,0),(2,'Bob','TheBuilder','Stylist','2020-01-28 00:00:00',4,44,'12:30:00','17:00:00',0,0,1,1,1,1,1),(3,'Henry','The 5th','Stylist','2022-03-01 00:00:00',2,2,'08:00:00','16:00:00',0,1,1,1,0,0,0),(4,'Hair','CutterManman','Stylist','2022-03-01 00:00:00',6,2,'08:00:00','17:30:00',1,1,1,0,0,0,0),(5,'John','Jollyman','Manager','2022-02-28 00:00:00',9,7,'09:30:00','16:00:00',1,1,1,0,1,0,0),(6,'Zbovb','Byi','Striker','2022-03-11 00:00:00',4,4,'12:00:00','19:30:00',1,1,0,0,0,1,1),(8,'Everyday','Worker','Mgr - Asst','2022-02-27 00:00:00',6,23,'08:30:00','16:00:00',0,1,1,0,0,0,0),(9,'Pumpkin','O\'Lantern','Manager','1988-12-21 00:00:00',10,4,'08:30:00','15:30:00',1,1,0,0,1,0,0);
/*!40000 ALTER TABLE `stylists` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-13 19:43:51
