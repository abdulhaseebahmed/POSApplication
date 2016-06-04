CREATE DATABASE  IF NOT EXISTS `posdb` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_general_ci */;
USE `posdb`;
-- MySQL dump 10.13  Distrib 5.6.23, for Win32 (x86)
--
-- Host: localhost    Database: posdb
-- ------------------------------------------------------
-- Server version	5.0.15-nt

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Not dumping tablespaces as no INFORMATION_SCHEMA.FILES table on this server
--

--
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `accounts` (
  `AccountID` int(11) NOT NULL auto_increment,
  `AccountName` varchar(45) collate latin1_general_ci default NULL,
  `Description` varchar(150) collate latin1_general_ci default NULL,
  `ParentAccountID` int(11) default NULL,
  PRIMARY KEY  (`AccountID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES (1,'Assets','This account contains asset transactions.',NULL),(2,'Liabilities','Liabilities',NULL),(3,'Expenses','Expenses',NULL),(4,'Revenue','Revenue',NULL),(5,'Current Assets','Current Assets',1),(6,'Non Current Assets','Non Current Assets',1),(7,'Current Liabilities','Current Liabilities',2),(8,'Non Current Liabilities','Non Current Liabilities',2),(9,'Admin Expenses','Admin Expenses',3),(10,'Operational Expenses','Operational Expenses',3),(11,'Income','Income',4),(12,'Other Income','Other Income',4),(13,'Receivables','Receivables',5),(14,'Payables','Payables',7),(15,'Utility Bills Expenses','This account contains transactions against utility bills like electricity, water.',9);
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `business`
--

DROP TABLE IF EXISTS `business`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `business` (
  `BusinessID` int(11) NOT NULL auto_increment,
  `BusinessName` varchar(30) collate latin1_general_ci default NULL,
  `BusinessTypeID` int(11) default NULL,
  `City` varchar(20) collate latin1_general_ci default NULL,
  `State` varchar(20) collate latin1_general_ci default NULL,
  `Country` varchar(20) collate latin1_general_ci default NULL,
  `CurrencyCode` varchar(8) collate latin1_general_ci default NULL,
  `BusLogoFileName` varchar(250) collate latin1_general_ci default NULL,
  `Address` varchar(100) collate latin1_general_ci default NULL,
  `Slogan` varchar(100) collate latin1_general_ci default NULL,
  `EmailAddress` varchar(50) collate latin1_general_ci default NULL,
  `CellNumber` varchar(45) collate latin1_general_ci default NULL,
  `OfficeNumber` varchar(45) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`BusinessID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `business`
--

LOCK TABLES `business` WRITE;
/*!40000 ALTER TABLE `business` DISABLE KEYS */;
INSERT INTO `business` VALUES (4,'DressUp',NULL,'Rawalpindi','Punjab','Pakistan','Rs','companylogo.jpg','House #1, Bostan Khan Road, Tanveer Avenue, near Chaklala Scheme 3','Your One Stop Shopffrfg','abdul.haseeb.ahmed@gmail.com','03339854904','0512011789');
/*!40000 ALTER TABLE `business` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `businesstypes`
--

DROP TABLE IF EXISTS `businesstypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `businesstypes` (
  `BusinessTypeID` int(11) NOT NULL auto_increment,
  `BusinessTypeName` varchar(45) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`BusinessTypeID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `businesstypes`
--

LOCK TABLES `businesstypes` WRITE;
/*!40000 ALTER TABLE `businesstypes` DISABLE KEYS */;
INSERT INTO `businesstypes` VALUES (1,'Grocery Store'),(2,'General Store'),(3,'Fast Food');
/*!40000 ALTER TABLE `businesstypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories` (
  `CategoryID` int(11) NOT NULL auto_increment,
  `CategoryName` varchar(70) collate latin1_general_ci default NULL,
  `ParentCategoryID` int(11) default NULL,
  `Description` varchar(100) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`CategoryID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (16,'Test Category',NULL,'Test Category');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customers` (
  `CustomerID` int(11) NOT NULL auto_increment,
  `CustomerName` varchar(45) collate latin1_general_ci default NULL,
  `ContactNo` varchar(45) collate latin1_general_ci default NULL,
  `Address` varchar(100) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`CustomerID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventory` (
  `ProductID` int(11) NOT NULL,
  `Quantity` decimal(10,2) default NULL,
  `PackingTypeID` int(11) default NULL,
  `PurchasePrice` decimal(10,2) default NULL,
  `SalePrice` decimal(10,2) default NULL,
  `PurchaseDate` timestamp NULL default NULL,
  `SaleDate` datetime default NULL,
  `CreateDt` timestamp NULL default NULL,
  `UpdateDt` timestamp NULL default '0000-00-00 00:00:00',
  `SumQuantity` decimal(10,2) default NULL,
  `InvoiceID` varchar(45) collate latin1_general_ci default NULL,
  `RecordID` int(11) NOT NULL auto_increment,
  PRIMARY KEY  (`RecordID`,`ProductID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT INTO `inventory` VALUES (43,5.00,NULL,1500.00,2000.00,NULL,'2016-05-29 19:47:14','2016-05-29 14:47:14','2016-05-29 14:52:14',35.00,'933b379c-a965-4345-9082-deb31821e59d',127),(43,5.00,NULL,1500.00,2000.00,NULL,'2016-05-29 19:52:14','2016-05-29 14:52:14','2016-05-29 17:33:37',35.00,'fe0477b4-f4da-44c4-82fd-d1c96dbe37f2',128),(43,10.00,NULL,1500.00,4000.00,NULL,'2016-05-29 22:47:43','2016-05-29 17:47:43','2016-05-29 17:56:56',0.00,'5326cf7a-6aed-4fe4-9544-6f085c349ccd',133),(43,0.00,NULL,1500.00,4000.00,NULL,NULL,'2016-05-29 17:47:02','2016-05-29 17:47:43',90.00,NULL,132),(43,0.00,NULL,1606.80,4000.00,NULL,NULL,'2016-05-29 17:47:02','2016-05-29 17:56:56',1.00,NULL,131),(43,5.00,NULL,1606.80,0.00,'2016-05-29 17:45:24',NULL,'2016-05-29 17:45:24','2016-05-29 17:47:02',5.00,'40e2c302-6fcd-4707-b7a8-c7f956cbd7d5',130),(43,2.00,NULL,1500.00,2000.00,'2016-05-29 17:33:37',NULL,'2016-05-29 17:33:37','2016-05-29 17:47:02',100.00,'7a0259e5-de81-4999-b43a-7f64a581e399',129),(43,5.00,NULL,1500.00,2000.00,NULL,'2016-05-29 19:35:04','2016-05-29 14:35:04','2016-05-29 14:47:14',40.00,'5eaeebd0-a5be-4682-9972-ece45c954c13',126),(43,0.00,NULL,1500.00,2000.00,NULL,NULL,'2016-05-29 14:33:54','2016-05-29 14:35:04',45.00,NULL,125),(43,50.00,NULL,1500.00,0.00,'2016-05-29 14:33:25',NULL,'2016-05-29 14:33:25','2016-05-29 14:33:54',50.00,'b6602511-72e2-49a1-a469-f75d689d2a56',124),(43,0.00,0,0.00,0.00,NULL,NULL,'2016-05-29 14:33:11','2016-05-29 14:33:25',0.00,NULL,123),(43,4.00,NULL,1500.00,4000.00,NULL,'2016-05-29 22:56:56','2016-05-29 17:56:56','2016-05-29 17:59:39',0.00,'e5ae26eb-74bc-4d5b-91e6-8d84b61fbd38',134),(43,4.00,NULL,1606.80,4000.00,NULL,'2016-05-29 22:56:56','2016-05-29 17:56:56','2016-05-29 17:59:39',1.00,'e5ae26eb-74bc-4d5b-91e6-8d84b61fbd38',135),(43,4.00,NULL,1500.00,4000.00,NULL,'2016-05-29 22:59:39','2016-05-29 17:59:39','2016-05-29 18:06:32',0.00,'d763357e-b41e-4ab8-af06-6cf3ce3b9699',136),(43,4.00,NULL,1606.80,4000.00,NULL,'2016-05-29 22:59:39','2016-05-29 17:59:39','2016-05-29 18:06:32',1.00,'d763357e-b41e-4ab8-af06-6cf3ce3b9699',137),(43,0.00,NULL,1500.00,4000.00,NULL,'2016-05-29 23:06:32','2016-05-29 18:06:32',NULL,0.00,'0a333a31-74ca-48f5-8747-4599aa44fa50',138),(43,4.00,NULL,1606.80,4000.00,NULL,'2016-05-29 23:06:32','2016-05-29 18:06:32',NULL,1.00,'0a333a31-74ca-48f5-8747-4599aa44fa50',139);
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `most_sellable_product`
--

DROP TABLE IF EXISTS `most_sellable_product`;
/*!50001 DROP VIEW IF EXISTS `most_sellable_product`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `most_sellable_product` AS SELECT 
 1 AS `PRODUCTID`,
 1 AS `SUMY`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `packingtypes`
--

DROP TABLE IF EXISTS `packingtypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `packingtypes` (
  `PackingTypeID` int(11) NOT NULL auto_increment,
  `PackingTypes` varchar(45) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`PackingTypeID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `packingtypes`
--

LOCK TABLES `packingtypes` WRITE;
/*!40000 ALTER TABLE `packingtypes` DISABLE KEYS */;
/*!40000 ALTER TABLE `packingtypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `posusers`
--

DROP TABLE IF EXISTS `posusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `posusers` (
  `UserID` int(11) NOT NULL auto_increment,
  `UserName` varchar(45) collate latin1_general_ci default NULL,
  `Password` varchar(45) collate latin1_general_ci default NULL,
  `LastLoginTime` datetime default NULL,
  `RoleID` int(11) NOT NULL,
  `LogoutTime` datetime default NULL,
  `createdt` datetime default NULL,
  `updatedt` datetime default NULL,
  PRIMARY KEY  (`UserID`,`RoleID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posusers`
--

LOCK TABLES `posusers` WRITE;
/*!40000 ALTER TABLE `posusers` DISABLE KEYS */;
INSERT INTO `posusers` VALUES (4,'abc','abc',NULL,2,NULL,NULL,NULL),(2,'admin','adminpassword','2015-06-04 12:15:15',1,NULL,NULL,NULL);
/*!40000 ALTER TABLE `posusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `product_count`
--

DROP TABLE IF EXISTS `product_count`;
/*!50001 DROP VIEW IF EXISTS `product_count`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `product_count` AS SELECT 
 1 AS `productid`,
 1 AS `sum_quantity`,
 1 AS `normal_date`,
 1 AS `daystring`,
 1 AS `dayint`,
 1 AS `monthstring`,
 1 AS `yearint`,
 1 AS `hourint`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products` (
  `ProductID` int(11) NOT NULL auto_increment,
  `ProductName` varchar(45) collate latin1_general_ci default NULL,
  `ProductDescription` varchar(100) collate latin1_general_ci default NULL,
  `SupplierID` int(11) default NULL,
  `ProductTypeID` int(11) default NULL,
  `CategoryID` int(11) default NULL,
  `Barcode` varchar(20) collate latin1_general_ci default NULL,
  `ImageFileName` varchar(80) collate latin1_general_ci default NULL,
  `GuaranteePeriodYears` varchar(10) collate latin1_general_ci default NULL,
  `WarrantyPeriodYears` varchar(10) collate latin1_general_ci default NULL,
  `ProductSize` varchar(10) collate latin1_general_ci default NULL,
  `ProductWeight` varchar(10) collate latin1_general_ci default NULL,
  `ProductWidth` varchar(10) collate latin1_general_ci default NULL,
  `ProductHeight` varchar(10) collate latin1_general_ci default NULL,
  `ProductColor` varchar(15) collate latin1_general_ci default NULL,
  `ProductCode` varchar(100) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`ProductID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (43,'Test Product','Test Product',33,NULL,16,'123123123',NULL,'','','1','1','1','1','1','Test Product');
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products_reorderlevel`
--

DROP TABLE IF EXISTS `products_reorderlevel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products_reorderlevel` (
  `ProductID` int(11) NOT NULL,
  `ReorderLevel` int(11) default NULL,
  PRIMARY KEY  (`ProductID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products_reorderlevel`
--

LOCK TABLES `products_reorderlevel` WRITE;
/*!40000 ALTER TABLE `products_reorderlevel` DISABLE KEYS */;
/*!40000 ALTER TABLE `products_reorderlevel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchasesorderdetails`
--

DROP TABLE IF EXISTS `purchasesorderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchasesorderdetails` (
  `OrderID` int(11) NOT NULL auto_increment,
  `ProductID` int(11) NOT NULL,
  `Quantity` decimal(10,2) default NULL,
  `Discount` decimal(10,2) default NULL,
  `PurchasePrice` decimal(10,2) default NULL,
  `TaxPercentage` decimal(10,2) default NULL,
  `InvoiceID` varchar(50) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`OrderID`,`ProductID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchasesorderdetails`
--

LOCK TABLES `purchasesorderdetails` WRITE;
/*!40000 ALTER TABLE `purchasesorderdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchasesorderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchasesorders`
--

DROP TABLE IF EXISTS `purchasesorders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchasesorders` (
  `OrderID` int(11) NOT NULL auto_increment,
  `TerminalID` int(11) default NULL,
  `SupplierID` int(11) default NULL,
  `PurchaseAmount` decimal(10,2) default NULL,
  `PurchaseTime` time default NULL,
  `Discount` decimal(10,2) default NULL,
  `TaxPercentage` decimal(10,2) default NULL,
  `PurchaseStatus` int(11) default NULL,
  `AmountPaid` decimal(10,2) default NULL,
  `Balance` decimal(10,2) default NULL,
  `ModeOfPayment` varchar(45) collate latin1_general_ci default NULL,
  `UserName` varchar(45) collate latin1_general_ci default NULL,
  `PurchaseDate` timestamp NULL default NULL,
  `Date_DayofWeek_string` varchar(45) collate latin1_general_ci default NULL,
  `Date_Dayofweek_int` int(11) default NULL,
  `Date_dateofmonth_int` int(11) default NULL,
  `date_month_int` int(11) default NULL,
  `date_month_string` varchar(45) collate latin1_general_ci default NULL,
  `date_year_int` int(11) default NULL,
  `time_hour` int(11) default NULL,
  `UpdateDt` timestamp NULL default NULL,
  `HoldInvoice` int(11) default NULL,
  `InvoiceID` varchar(50) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`OrderID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchasesorders`
--

LOCK TABLES `purchasesorders` WRITE;
/*!40000 ALTER TABLE `purchasesorders` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchasesorders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `regions`
--

DROP TABLE IF EXISTS `regions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `regions` (
  `RegionID` int(11) NOT NULL auto_increment,
  `RegionName` varchar(45) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`RegionID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `regions`
--

LOCK TABLES `regions` WRITE;
/*!40000 ALTER TABLE `regions` DISABLE KEYS */;
/*!40000 ALTER TABLE `regions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roles` (
  `RoleID` int(11) NOT NULL,
  `RoleName` varchar(45) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`RoleID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrator'),(2,'Salesman');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `saleorders_view`
--

DROP TABLE IF EXISTS `saleorders_view`;
/*!50001 DROP VIEW IF EXISTS `saleorders_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `saleorders_view` AS SELECT 
 1 AS `PK_COLUMN`,
 1 AS `_DAY_STRING`,
 1 AS `_MONTH_STRING`,
 1 AS `_YEAR_INT`,
 1 AS `_MONTH_INT`,
 1 AS `_DATE_STRING`,
 1 AS `saleamount`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `salesorderdetails`
--

DROP TABLE IF EXISTS `salesorderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salesorderdetails` (
  `OrderID` int(11) NOT NULL auto_increment,
  `ProductID` int(11) NOT NULL,
  `Quantity` decimal(10,2) default NULL,
  `Discount` decimal(10,2) default NULL,
  `SalePrice` decimal(10,2) default NULL,
  `PurchasePrice` decimal(10,2) default NULL,
  `FinalSalePrice` decimal(10,2) default NULL,
  `ProfitTaken` decimal(10,2) default NULL,
  `TaxPercentage` decimal(10,2) default NULL,
  `InvoiceID` varchar(50) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`OrderID`,`ProductID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salesorderdetails`
--

LOCK TABLES `salesorderdetails` WRITE;
/*!40000 ALTER TABLE `salesorderdetails` DISABLE KEYS */;
INSERT INTO `salesorderdetails` VALUES (1,43,94.00,0.00,4000.00,1500.00,4000.00,2500.00,0.00,'e5ae26eb-74bc-4d5b-91e6-8d84b61fbd38'),(2,43,94.00,0.00,4000.00,1500.00,4000.00,2500.00,0.00,'d763357e-b41e-4ab8-af06-6cf3ce3b9699'),(3,43,99.00,0.00,4000.00,1500.00,4000.00,2500.00,0.00,'0a333a31-74ca-48f5-8747-4599aa44fa50');
/*!40000 ALTER TABLE `salesorderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salesorders`
--

DROP TABLE IF EXISTS `salesorders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salesorders` (
  `OrderID` int(11) NOT NULL auto_increment,
  `TerminalID` int(11) default NULL,
  `CustomerID` int(11) default NULL,
  `SaleAmount` decimal(10,2) default NULL,
  `SaleTime` time default NULL,
  `Discount` decimal(10,2) default NULL,
  `TaxPercentage` decimal(10,2) default NULL,
  `SaleStatus` int(11) default NULL,
  `AmountPaid` decimal(10,2) default NULL,
  `Balance` decimal(10,2) default NULL,
  `ModeOfPayment` varchar(45) collate latin1_general_ci default NULL,
  `UserName` varchar(45) collate latin1_general_ci default NULL,
  `SaleDate` timestamp NULL default NULL,
  `Date_DayofWeek_string` varchar(45) collate latin1_general_ci default NULL,
  `Date_Dayofweek_int` int(11) default NULL,
  `Date_dateofmonth_int` int(11) default NULL,
  `date_month_int` int(11) default NULL,
  `date_month_string` varchar(45) collate latin1_general_ci default NULL,
  `date_year_int` int(11) default NULL,
  `time_hour` int(11) default NULL,
  `UpdateDt` timestamp NULL default NULL,
  `HoldInvoice` int(11) default NULL,
  `InvoiceID` varchar(50) collate latin1_general_ci NOT NULL,
  PRIMARY KEY  (`OrderID`,`InvoiceID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salesorders`
--

LOCK TABLES `salesorders` WRITE;
/*!40000 ALTER TABLE `salesorders` DISABLE KEYS */;
INSERT INTO `salesorders` VALUES (1,1,NULL,376000.00,'22:56:56',0.00,0.00,0,376000.00,0.00,'Cash','admin','2016-05-28 19:00:00','Sunday',7,29,5,'May',2016,22,NULL,0,'e5ae26eb-74bc-4d5b-91e6-8d84b61fbd38'),(2,1,NULL,376000.00,'22:59:39',0.00,0.00,0,376000.00,0.00,'Cash','admin','2016-05-28 19:00:00','Sunday',7,29,5,'May',2016,22,NULL,0,'d763357e-b41e-4ab8-af06-6cf3ce3b9699'),(3,1,NULL,396000.00,'23:06:32',0.00,0.00,0,396000.00,0.00,'Cash','admin','2016-05-28 19:00:00','Sunday',7,29,5,'May',2016,23,NULL,0,'0a333a31-74ca-48f5-8747-4599aa44fa50');
/*!40000 ALTER TABLE `salesorders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stores`
--

DROP TABLE IF EXISTS `stores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stores` (
  `StoreID` int(11) NOT NULL auto_increment,
  `StoreName` varchar(45) collate latin1_general_ci default NULL,
  `StoreAddress` varchar(100) collate latin1_general_ci default NULL,
  `BusinessID` int(11) default NULL,
  `ServerIP` varchar(45) collate latin1_general_ci default NULL,
  `ServerPort` int(11) default NULL,
  PRIMARY KEY  (`StoreID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stores`
--

LOCK TABLES `stores` WRITE;
/*!40000 ALTER TABLE `stores` DISABLE KEYS */;
/*!40000 ALTER TABLE `stores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suppliers` (
  `SupplierID` int(11) NOT NULL auto_increment,
  `SupplierName` varchar(45) collate latin1_general_ci default NULL,
  `ContactName` varchar(45) collate latin1_general_ci default NULL,
  `ContactNumber` varchar(45) collate latin1_general_ci default NULL,
  `SupplierAddress` varchar(200) collate latin1_general_ci default NULL,
  PRIMARY KEY  (`SupplierID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (33,'Test Supplier','Test Supplier','Test Supplier','Test Supplier');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `taxes`
--

DROP TABLE IF EXISTS `taxes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `taxes` (
  `TaxID` int(11) NOT NULL auto_increment,
  `TaxDescription` varchar(45) collate latin1_general_ci default NULL,
  `TaxAppliedDate` date default NULL,
  PRIMARY KEY  (`TaxID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `taxes`
--

LOCK TABLES `taxes` WRITE;
/*!40000 ALTER TABLE `taxes` DISABLE KEYS */;
/*!40000 ALTER TABLE `taxes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `terminals`
--

DROP TABLE IF EXISTS `terminals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `terminals` (
  `TerminalID` int(11) NOT NULL auto_increment,
  `TerminalName` varchar(45) collate latin1_general_ci default NULL,
  `StoreID` int(11) default NULL,
  `PrinterType` int(11) default NULL,
  PRIMARY KEY  (`TerminalID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `terminals`
--

LOCK TABLES `terminals` WRITE;
/*!40000 ALTER TABLE `terminals` DISABLE KEYS */;
INSERT INTO `terminals` VALUES (7,'84A6C886A60A',1,80);
/*!40000 ALTER TABLE `terminals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transactions`
--

DROP TABLE IF EXISTS `transactions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transactions` (
  `entrydate` date default NULL,
  `entrytime` time default NULL,
  `Debit` decimal(10,2) default NULL,
  `Credit` decimal(10,2) default NULL,
  `description` varchar(200) collate latin1_general_ci default NULL,
  `transactionid` int(11) NOT NULL auto_increment,
  `accountid` int(11) default NULL,
  PRIMARY KEY  (`transactionid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transactions`
--

LOCK TABLES `transactions` WRITE;
/*!40000 ALTER TABLE `transactions` DISABLE KEYS */;
/*!40000 ALTER TABLE `transactions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'posdb'
--

--
-- Final view structure for view `most_sellable_product`
--

/*!50001 DROP VIEW IF EXISTS `most_sellable_product`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `most_sellable_product` AS select `product_count`.`productid` AS `PRODUCTID`,max(`product_count`.`sum_quantity`) AS `SUMY` from `product_count` group by `product_count`.`productid` order by max(`product_count`.`sum_quantity`) limit 1 */;

--
-- Final view structure for view `product_count`
--

/*!50001 DROP VIEW IF EXISTS `product_count`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `product_count` AS select `a`.`ProductID` AS `productid`,sum(`a`.`Quantity`) AS `sum_quantity`,`b`.`SaleDate` AS `normal_date`,`b`.`Date_DayofWeek_string` AS `daystring`,`b`.`Date_Dayofweek_int` AS `dayint`,`b`.`date_month_string` AS `monthstring`,`b`.`date_year_int` AS `yearint`,`b`.`time_hour` AS `hourint` from (`salesorders` `b` left join `salesorderdetails` `a` on((`a`.`OrderID` = `b`.`OrderID`))) group by `b`.`SaleDate`,`a`.`ProductID` */;

--
-- Final view structure for view `saleorders_view`
--

/*!50001 DROP VIEW IF EXISTS `saleorders_view`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `saleorders_view` AS select 1 AS `PK_COLUMN`,cast(dayname(`salesorders`.`SaleDate`) as char charset utf8) AS `_DAY_STRING`,cast(monthname(`salesorders`.`SaleDate`) as char charset utf8) AS `_MONTH_STRING`,year(`salesorders`.`SaleDate`) AS `_YEAR_INT`,month(`salesorders`.`SaleDate`) AS `_MONTH_INT`,cast(`salesorders`.`SaleDate` as date) AS `_DATE_STRING`,`salesorders`.`SaleAmount` AS `saleamount` from `salesorders` */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-30 23:32:08
