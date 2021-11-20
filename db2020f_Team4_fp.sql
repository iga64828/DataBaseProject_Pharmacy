-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2020-12-21 17:21:35
-- 伺服器版本： 10.4.14-MariaDB
-- PHP 版本： 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `db2020f_fp`
--
CREATE DATABASE IF NOT EXISTS `db2020f_fp` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `db2020f_fp`;

-- --------------------------------------------------------

--
-- 資料表結構 `drug`
--

CREATE TABLE `drug` (
  `DRUG_NO` char(12) NOT NULL,
  `DRUG_NAME` char(12) NOT NULL,
  `DRUG_SIDEFFECTS` char(15) NOT NULL,
  `INDICATIONS` char(20) NOT NULL,
  `NOTES` char(50) NOT NULL,
  `UNIT` char(10) NOT NULL,
  `UNIT_Price` int(10) NOT NULL,
  `DRUG_USE_PATH` char(10) NOT NULL,
  `DRUG_QTY` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- 資料表結構 `medication recipt`
--

CREATE TABLE `medication recipt` (
  `Prescription_NO` varchar(20) NOT NULL,
  `DRUG_NO` char(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- 資料表結構 `member`
--

CREATE TABLE `member` (
  `TEL_NUM` int(10) NOT NULL,
  `MEMBER_NAME` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `member`
--

INSERT INTO `member` (`TEL_NUM`, `MEMBER_NAME`) VALUES
(914636510, 'Waldon'),
(927457521, 'Monte'),
(929449037, 'Ximenes'),
(930127333, 'Russ'),
(938474397, 'Temp'),
(952369486, 'Flynn'),
(960374846, 'Cyril'),
(963276960, 'Tucker'),
(970509488, 'Dur'),
(970801501, 'Laird');

-- --------------------------------------------------------

--
-- 資料表結構 `patient`
--

CREATE TABLE `patient` (
  `PATIENT_ID` varchar(10) NOT NULL,
  `PATIENT_NAME` char(20) NOT NULL,
  `PATIENT_GENDER` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `patient`
--

INSERT INTO `patient` (`PATIENT_ID`, `PATIENT_NAME`, `PATIENT_GENDER`) VALUES
('A102559301', 'John', 'M'),
('A126782535', 'Harry', 'M'),
('A130337566', 'mike', 'M'),
('A135230795', 'jobs', 'M'),
('A158720176', 'lisa', 'F'),
('A162717221', 'mike', 'M'),
('A189040907', 'Marry', 'F'),
('A193416857', 'june', 'F'),
('B190465895', 'louis', 'M'),
('B197194666', 'jason', 'M');

-- --------------------------------------------------------

--
-- 資料表結構 `prescription`
--

CREATE TABLE `prescription` (
  `Prescription_NO` varchar(20) NOT NULL,
  `DRUG_NO` char(12) NOT NULL,
  `DRUG_QTY` int(100) NOT NULL,
  `PATIENT_ID` varchar(10) NOT NULL,
  `Diagnosis ID` varchar(10) NOT NULL,
  `DRUG_FRQ` varchar(20) NOT NULL,
  `Prescription_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- 資料表結構 `product`
--

CREATE TABLE `product` (
  `Product_NO` varchar(5) NOT NULL,
  `Product_NAME` char(50) NOT NULL,
  `Category` varchar(20) NOT NULL,
  `UNIT_PRICE` int(10) NOT NULL,
  `NOTE` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `product`
--

INSERT INTO `product` (`Product_NO`, `Product_NAME`, `Category`, `UNIT_PRICE`, `NOTE`) VALUES
('01', 'Sambucol Immuno Forte Black Elderberry Capsules', 'Vitamins', 343, 'Not suitable for children aged below 12.\r\nStore below 25°C in a dry place out of direct sunlight and out of sight and reach of children.\r\nDo not exceed the recommended dosage.\r\nDo not take on an empty stomach.'),
('02', 'Adcal D3 Chewable Tablets', 'Vitamins', 227, 'this medicine is for a child under 12 years of age.\r\nThyroxine, bisphosphonates, sodium fluoride, quinolones, tetracycline antibiotics or iron - take these medicines at least four hours before you take a calcium preparation\r\nPhenytoin; barbiturates; thiazide diuretics; glucocorticoids; cardiac glycosides such as digoxin; calcium and vitamin D preparations'),
('03', 'Calcichew D3 Forte Chewable Tablets', 'Vitamins', 400, 'are allergic (hypersensitive) to any of the ingredients.\r\nare allergic (hypersensitive) to soya or peanuts.\r\nhave a condition causing high levels of calcium in your blood or urine hypercalcaemia or hypercalciuria) e.g.renal (kidney failure), cancer that has affected your bones, have high levels of Vitamin D in your blood, have kidney stones.'),
('04', 'Seven Seas Cod Liver Oil One-A-Day Capsules\r\n', 'Vitamins', 336, 'Store in a cool, dry place\r\nKeep out of reach of children'),
('05', 'Suresign Automatic Blood Pressure & Pulse Monitor', 'Healthcare Equipment', 660, ' '),
('06', 'Kinetik Infrared Ear and Forehead Thermometer', 'Healthcare Equipment', 1869, 'Adult supervision when measuring temperature of children under 12.\r\nPlease do not use this product for these people who suffer from otitis external, tympanitis and other ear diseases.'),
('07', 'BioSURE HIV Self Test', 'Healthcare Equipment', 1120, 'BioSURE HIV Self Test may not detect HIV infections that have occurred within the last 3 months. BioSURE HIV Self Test is simple to perform and extremely accurate but only if you perform the test correctly. It is essential you carefully read and follow all of the instructions.'),
('08', 'GlucoRX Nexus Blood Glucose Monitoring System', 'Healthcare Equipment', 646, 'The system does not require any coding, only a 0.5?L blood volume.'),
('09', 'Full Face Shield Visor', 'PPE', 156, 'The comfortable fitting and lightweight Full Face Shield Visor will cover your face from external aggressors.'),
('10', 'Face Mask 10 pack', 'PPE', 400, 'For external use only. Wash hands frequently with antibacterial soap. Always wash hands after coughing, sneezing, cleaning the nose, going to the toilet, before touching the eyes, nose or mouth and before preparing food. Face coverings are not 100% effective.');

-- --------------------------------------------------------

--
-- 資料表結構 `recipe`
--

CREATE TABLE `recipe` (
  `RECIPE_NO` varchar(10) NOT NULL,
  `Product_NO` varchar(5) NOT NULL,
  `Product_NAME` char(50) NOT NULL,
  `UNIT_PRICE` int(30) NOT NULL,
  `PRODUCT_QTY` int(20) NOT NULL,
  `STAFF_ID` varchar(10) NOT NULL,
  `TOTAL` int(15) NOT NULL,
  `Date_time` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `recipe`
--

INSERT INTO `recipe` (`RECIPE_NO`, `Product_NO`, `Product_NAME`, `UNIT_PRICE`, `PRODUCT_QTY`, `STAFF_ID`, `TOTAL`, `Date_time`) VALUES
('1131928297', '06', 'Kinetik Infrared Ear and Forehead Thermometer', 1869, 2, 'FTZOF7UCN7', 3738, '2020-12-06'),
('1639167933', '03', 'Calcichew D3 Forte Chewable Tablets', 400, 5, 'BW7IZ1M4KN', 2000, '2020-12-03'),
('1702877697', '07', 'BioSURE HIV Self Test', 1120, 3, '1VZ1F73A0E', 3360, '2020-12-07'),
('2199781090', '04', 'Seven Seas Cod Liver Oil One-A-Day Capsules', 336, 7, 'UYM7J0VL5Q', 2352, '2020-12-04'),
('3882430001', '05', 'Suresign Automatic Blood Pressure & Pulse Monitor', 660, 4, '5YZMDO4V9Z', 2640, '2020-12-05'),
('5351201017', '10', 'Face Mask 10 pack', 400, 8, 'A0CBCJBFR7', 3200, '2020-12-10'),
('6167714837', '01', 'Sambucol Immuno Forte Black Elderberry Capsules', 343, 2, 'SKN79Q95WS', 686, '2020-12-01'),
('6259091362', '02', 'Adcal D3 Chewable Tablets', 227, 3, 'JAH1EA7QD6', 681, '2020-12-02'),
('8026334161', '09', 'Full Face Shield Visor', 156, 9, 'XYTBEAN9FS', 1404, '2020-12-09'),
('8809339086', '08', 'GlucoRX Nexus Blood Glucose Monitoring System', 646, 8, 'E88X2G5W8Q', 5168, '2020-12-08');

-- --------------------------------------------------------

--
-- 資料表結構 `staff`
--

CREATE TABLE `staff` (
  `STAFF_ID` varchar(10) NOT NULL,
  `STAFF_NAME` char(10) NOT NULL,
  `STAFF_CATEGORY` varchar(10) NOT NULL,
  `STAFF_GENDER` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `staff`
--

INSERT INTO `staff` (`STAFF_ID`, `STAFF_NAME`, `STAFF_CATEGORY`, `STAFF_GENDER`) VALUES
('1VZ1F73A0E', 'Inker', 'Intern', 'F'),
('5YZMDO4V9Z', 'McGoon', 'Drugist', 'M'),
('A0CBCJBFR7', 'Crummey', 'Intern', 'F'),
('BW7IZ1M4KN', 'Seager', 'Drugist', 'M'),
('E88X2G5W8Q', 'Godding', 'Drugist', 'M'),
('FTZOF7UCN7', 'Kerby', 'Intern', 'F'),
('JAH1EA7QD6', 'Todari', 'Intern', 'F'),
('SKN79Q95WS', 'Vaughan', 'Drugist', 'F'),
('UYM7J0VL5Q', 'Paggitt', 'Intern', 'F'),
('XYTBEAN9FS', 'Ericsson', 'Intern', 'F');

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `drug`
--
ALTER TABLE `drug`
  ADD PRIMARY KEY (`DRUG_NO`);

--
-- 資料表索引 `medication recipt`
--
ALTER TABLE `medication recipt`
  ADD PRIMARY KEY (`Prescription_NO`,`DRUG_NO`),
  ADD KEY `DRUG_NO` (`DRUG_NO`);

--
-- 資料表索引 `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`TEL_NUM`);

--
-- 資料表索引 `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`PATIENT_ID`);

--
-- 資料表索引 `prescription`
--
ALTER TABLE `prescription`
  ADD PRIMARY KEY (`Prescription_NO`,`DRUG_NO`),
  ADD KEY `PATIENT_ID` (`PATIENT_ID`),
  ADD KEY `DRUG_NO` (`DRUG_NO`);

--
-- 資料表索引 `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`Product_NO`);

--
-- 資料表索引 `recipe`
--
ALTER TABLE `recipe`
  ADD PRIMARY KEY (`RECIPE_NO`),
  ADD KEY `STAFF_ID` (`STAFF_ID`),
  ADD KEY `Product_NO` (`Product_NO`);

--
-- 資料表索引 `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`STAFF_ID`);

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `medication recipt`
--
ALTER TABLE `medication recipt`
  ADD CONSTRAINT `medication recipt_ibfk_1` FOREIGN KEY (`Prescription_NO`) REFERENCES `prescription` (`Prescription_NO`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `medication recipt_ibfk_2` FOREIGN KEY (`DRUG_NO`) REFERENCES `drug` (`DRUG_NO`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制式 `prescription`
--
ALTER TABLE `prescription`
  ADD CONSTRAINT `prescription_ibfk_1` FOREIGN KEY (`PATIENT_ID`) REFERENCES `patient` (`PATIENT_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `prescription_ibfk_2` FOREIGN KEY (`DRUG_NO`) REFERENCES `drug` (`DRUG_NO`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的限制式 `recipe`
--
ALTER TABLE `recipe`
  ADD CONSTRAINT `recipe_ibfk_1` FOREIGN KEY (`STAFF_ID`) REFERENCES `staff` (`STAFF_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `recipe_ibfk_2` FOREIGN KEY (`Product_NO`) REFERENCES `product` (`Product_NO`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
