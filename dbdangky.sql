-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Apr 17, 2023 at 04:23 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbdangky`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbthongtin`
--

DROP TABLE IF EXISTS `tbthongtin`;
CREATE TABLE IF NOT EXISTS `tbthongtin` (
  `Username` text NOT NULL,
  `Password` text NOT NULL,
  `Hoten` text CHARACTER SET utf8 COLLATE utf8_vietnamese_ci NOT NULL,
  `Ngaysinh` text NOT NULL,
  `Gtinh` text NOT NULL,
  `Email` text CHARACTER SET utf8 COLLATE utf8_vietnamese_ci NOT NULL,
  `Thunhap` float NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbthongtin`
--

INSERT INTO `tbthongtin` (`Username`, `Password`, `Hoten`, `Ngaysinh`, `Gtinh`, `Email`, `Thunhap`) VALUES
('4451050001', '123456', 'Toi la Toi', '11/12/2000', 'nam', 'sdf@asdfafa', 12313),
('4451050002', '11111', 'hvlam', '11/12/2000', 'nam', 'sdf11111@asdfafa', 345353),
('4451050003', 'hoaitrung', 'Äáº·ng LÃª HoÃ i Trung', '06/09/2003', 'Nam', 'hoaitrung692003@gmail.com', 12334),
('4451050004', '12345', 'Đặng Lê Hoài Trung', '06/09/2003', 'Nam', 'hoaitrung692003@gmail.com', 123345);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
