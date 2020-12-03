-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: teleapp
-- ------------------------------------------------------
-- Server version	8.0.20

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
-- Table structure for table `admins`
--

DROP TABLE IF EXISTS `admins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admins` (
  `username` varchar(16) NOT NULL,
  `name` varchar(32) NOT NULL,
  `surname` varchar(32) NOT NULL,
  `who` varchar(6) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admins`
--

LOCK TABLES `admins` WRITE;
/*!40000 ALTER TABLE `admins` DISABLE KEYS */;
INSERT INTO `admins` VALUES ('mkrikorianh','Margot','Krikorian','admin'),('ptutingd	','Perry','Tuting','admin'),('rtrase123','Raddie','Trase','admin');
/*!40000 ALTER TABLE `admins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bills`
--

DROP TABLE IF EXISTS `bills`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bills` (
  `date` date NOT NULL,
  `number` varchar(10) NOT NULL,
  `name_program` varchar(16) NOT NULL,
  `totalcost` varchar(5) NOT NULL,
  `status` varchar(10) NOT NULL,
  PRIMARY KEY (`date`,`number`),
  KEY `name_program` (`name_program`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bills`
--

LOCK TABLES `bills` WRITE;
/*!40000 ALTER TABLE `bills` DISABLE KEYS */;
INSERT INTO `bills` VALUES ('2020-01-19','6965989816','Standard Plan','10','pending'),('2020-05-12','6957563833','Student Plan','10','pending'),('2020-07-12','6912316916','Family Plan','40','pending'),('2020-07-12','6965989816','Standard Plan','10','pending'),('2020-12-12','6912316916','Family Plan','40','pending');
/*!40000 ALTER TABLE `bills` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `calls`
--

DROP TABLE IF EXISTS `calls`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `calls` (
  `receiver` varchar(10) NOT NULL,
  `caller` varchar(10) NOT NULL,
  `timestamp` varchar(32) NOT NULL,
  `minutes` varchar(16) NOT NULL,
  PRIMARY KEY (`receiver`,`caller`,`timestamp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `calls`
--

LOCK TABLES `calls` WRITE;
/*!40000 ALTER TABLE `calls` DISABLE KEYS */;
INSERT INTO `calls` VALUES ('6912316916','6957563833','Fri Jul 10 18:55:06 EEST 2020','08:01:46'),('6912316916','6965989816','Fri Jul 10 18:56:32 EEST 2020','05:55:05'),('6912316916','6993711594','Fri Jul 10 18:57:18 EEST 2020','02:58:54'),('6957563833','6912316916','Fri Jul 10 12:09:54 EEST 2020','12:55:12'),('6957563833','6912316916','Fri Jul 10 18:53:39 EEST 2020','16:30:47'),('6957563833','6965989816','Fri Jul 10 18:56:44 EEST 2020','00:39:57'),('6965989816','6912316916','Fri Jul 10 18:54:04 EEST 2020','00:24:27'),('6965989816','6957563833','Fri Jul 10 18:55:32 EEST 2020','02:58:54'),('6965989816','6993711594','Fri Jul 10 18:57:31 EEST 2020','00:45:38'),('6993711594','6912316916','Fri Jul 10 18:54:28 EEST 2020','01:30:30'),('6993711594','6957563833','Fri Jul 10 18:56:11 EEST 2020','00:30:30');
/*!40000 ALTER TABLE `calls` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clients` (
  `username` varchar(16) NOT NULL,
  `name` varchar(32) NOT NULL,
  `surname` varchar(32) NOT NULL,
  `who` varchar(6) NOT NULL,
  `afm` varchar(9) DEFAULT NULL,
  `number` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`username`),
  KEY `clients_ibfk_1` (`number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES ('arumbelow1','Ansel','Rumbelow','client','548837556','6912316916'),('bgatsby0','Bee','Gatsby','client','895114626','6957563833'),('fusborn5','Findlay','Usborn','client','174628079','6965989816'),('garchbould4','Glynis','Archbould','client','804305036','6993711594'),('gclaesens0','Gayelord','Claesens','client','905740795','6937327428'),('pmaccaffery3','Pearle','MacCaffery','client',NULL,NULL),('tpatten2','Torrie','Patten','client','445081731',NULL);
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phonenumbers`
--

DROP TABLE IF EXISTS `phonenumbers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `phonenumbers` (
  `username` varchar(16) NOT NULL,
  `number` varchar(10) DEFAULT NULL,
  `name_program` varchar(16) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phonenumbers`
--

LOCK TABLES `phonenumbers` WRITE;
/*!40000 ALTER TABLE `phonenumbers` DISABLE KEYS */;
INSERT INTO `phonenumbers` VALUES ('arumbelow1','6912316916','Family Plan'),('bgatsby0','6957563833','Student Plan'),('fusborn5','6965989816','Standard Plan'),('garchbould4','6993711594','Standard Plan'),('gclaesens0','6937327428',NULL),('pmaccaffery3',NULL,NULL),('tpatten2',NULL,NULL);
/*!40000 ALTER TABLE `phonenumbers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programs`
--

DROP TABLE IF EXISTS `programs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programs` (
  `name_program` varchar(16) NOT NULL,
  `minutes_of_talk` varchar(5) NOT NULL,
  `Cost` varchar(3) NOT NULL,
  PRIMARY KEY (`name_program`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programs`
--

LOCK TABLES `programs` WRITE;
/*!40000 ALTER TABLE `programs` DISABLE KEYS */;
INSERT INTO `programs` VALUES ('Business Plan','3000','20'),('Family Plan','5000','40'),('Standard Plan','1000','10'),('Student Plan','2000','10');
/*!40000 ALTER TABLE `programs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sellers`
--

DROP TABLE IF EXISTS `sellers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sellers` (
  `username` varchar(16) NOT NULL,
  `name` varchar(32) NOT NULL,
  `surname` varchar(32) NOT NULL,
  `who` varchar(6) NOT NULL,
  `employeeid` varchar(6) DEFAULT NULL,
  `Salary` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sellers`
--

LOCK TABLES `sellers` WRITE;
/*!40000 ALTER TABLE `sellers` DISABLE KEYS */;
INSERT INTO `sellers` VALUES ('csalan888','Chauncey','Salan','seller','539664','30000'),('gbernadzkic','Gannie','Bernadzki','seller','915453','60000'),('mspeerman9','Miles','Speerman','seller','450864','50000'),('sburry777','Sargent','Burry','seller',NULL,NULL),('sjosskoviz6','Shellysheldon','Josskoviz','seller',NULL,NULL);
/*!40000 ALTER TABLE `sellers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userslogininfo`
--

DROP TABLE IF EXISTS `userslogininfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userslogininfo` (
  `username` varchar(16) NOT NULL,
  `password` char(64) NOT NULL,
  `salt` varchar(16) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userslogininfo`
--

LOCK TABLES `userslogininfo` WRITE;
/*!40000 ALTER TABLE `userslogininfo` DISABLE KEYS */;
INSERT INTO `userslogininfo` VALUES ('arumbelow1','872b03d9ba82e5b39c9152e1094f6931406b13597faa08556cb58f3d389e825a','p1RRnkBsbeseAqfF'),('bgatsby0','dcc5ee31e4302df10a5f36b594f67df4333e44c66d40462206918ddb7a9da32f','LE7zHcyOfbcxYhKf'),('csalan888','413387afaaa19ad4ab7ecfc003b3ec32d44f5d67dc2240c825b9d4012f4ab066','eF2kyvygPox664EW'),('fusborn5','5e04054a66673502222f4bab1eab58fa2e629359c78fb5f4dde5481499a5a278','HXmyJYqflpZHDZU0'),('garchbould4','9c8c1c433286e79fc96fd5feaffa2f4e1c143818475fe2259c4929226355492b','Uq4ZbMYgjAUpAafC'),('gbernadzkic','cfbb1a29dd524440e83580bf6ad6c6a929a49623973b59a842ee427398a2faeb','2JzuRPcCLiIUzAK0'),('gclaesens0','7dc11409842a3ce836804d2c2e0358c06c3762a516c4291131d4fe7b08d9207b','ovZejRnct1KT2YnS'),('mkrikorianh','e5670912ada1561c783301a62e07c5c19c84b6d2381cc63e681eab5e859886fa','7jbn3Ynr4E6oylij'),('mspeerman9','b2dddd5268e23bf2bbfd32b0a7a87f8dd08bc6d0af411ca258ab6d4f9f703765','idTmyzcoh8XQ2QEl'),('pmaccaffery3','e14299dc49b69a62d0154f05539c7963e56a064814d1879143d3cb9f8612fac7','YXKa5ZkgdKMryL1v'),('ptutingd	','f07299c10e2861ac6be9bd9ef42810210f3bc0a6cdedcf065d288d0c03c94f6b','L57iQKQhUXdDk8yU'),('rtrase123','44b592f8b88d727fe2a669d713556e43d47aef03cfe82e7c1d4bdef283fc4a50','emGCAmjfgzIHtrSY'),('sburry777','21a7abe6ae0b99270244a57893b19ede874d0349d4fb9dec9b82e2978b252836','yVmWetl9q2af7adn'),('sjosskoviz6','d509c74f52cce3e73f6deb727645c623c6a91445d0ed421a2307aaea1916ba37','bBHvxGllfkXAU9WP'),('tpatten2','ad0d137679166e6410595d2ecd68e9512a70dce65e071d6fa1682c02dd493039','MVZGYC4qkDMkYcdq');
/*!40000 ALTER TABLE `userslogininfo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-10 19:00:57
