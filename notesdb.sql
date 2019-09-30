-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 30, 2019 at 02:03 PM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `notesdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `notes`
--

CREATE TABLE `notes` (
  `title` varchar(200) NOT NULL,
  `body` varchar(500) NOT NULL,
  `mobno` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `notes`
--

INSERT INTO `notes` (`title`, `body`, `mobno`) VALUES
('0', '0', 1234567890),
('0', '0', 1234567890),
('ZXZXCXZCXZCXZ', 'ZXCXZcxzCXZCZXCZXCZXC', 1234567890),
('HJHGSJAGJA', 'SAD,SJAHDJKSHAKDJSAKDJLKASJDKSAJ', 1234567890),
('PRAFULL', 'Help Please!  Newbie to VB, I am using VS 2010 and I just cannot find my problem.  The code below carries out the query find but continues to add records to the table.  I am trying to find out what the record count is so that I can then perform another action.  When the query is executed the first pass the record count is 19.  This is valid and matches the DB.  The 2nd pass the record count is 49, but the DB only shows 30.  The 3rd pass the record count shows 115, but the DB shows 66.', 1234567890),
('Sample', 'Sample                     Notes', 1234567890),
('JSDKJSJK', 'nEW NOTE', 1234567890),
('HELLO THERE', 'GSJHGSAJKDHKASJJDKLASJLDJJDLASJDSA\r\nSADASDASDASDASDA', 1234567890),
('BJHHJSADHKJSKDJASK', 'HJASGJHASHDJKHSAKJDHKJASJDKJJSAKJDHKASJHDKASHKDJHAKSHDKASKJ', 1234567890),
('ashhdojoajso2374072', 'oufd0uw080', 1234567890),
('YTD6FY', '6576786', 1234567890),
('AniketGavali', 'Saurabh Bhalerao', 1234567890),
('23897458375983453', '2347329479375979345', 1234567890),
('gsghgsahgasgdassdnhsdj', 'sndhbsajdmsabdmsabdmnbsamndbmnsbdmnsabmdasmnb', 987654321),
('XZSAKJHSJMHASJKDHAS', 'USAUYDSUKSAUYDKASKUDKUASKUDS', 1234567890),
('213y19274372394', 'odhhaodfhosdfddsfds', 1234567890),
('qwoswhohasd', 'sakdhhasd', 1234567890),
('akjhsdhakhsdk', 'sakdhoahohdophsad', 1234567890),
('akjhsdhakhsdk', 'sakdhoahohdophsad', 1234567890),
('12345678', 'sakdhoahohdophsad', 1234567890),
('23747982394', 'dsihhdsohofds', 1234567890),
('assjhdhhask', 'oDOOHDSOHOAS', 1234567890),
('99999999999999999999999', '111111111111111111', 1234567890),
('11111111111111111', '11111111111111', 1234567890),
('22222222222222222222', 'daskhhoohdas', 1234567890),
('88888888888888', '98888888888888888888', 1234567890),
('PrafullChavan', 'Aniket', 1234567890),
('shadiihsidf', '23972934723423', 0),
('222222222222222222222222', 'asdfisidfibsd', 0),
('ahdohoashod', 'sahoashodha', 0),
('Aniket', 'aidha', 0),
('saurabh', 'saurabh', 0),
('AHGJHSGDHGASDHG', 'GDJHSAGDJASGDJASGJASGDJHAS', 1234567890);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `mobno` varchar(200) NOT NULL,
  `name` varchar(200) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`mobno`, `name`, `password`) VALUES
('097652455416', 'SAMPLE', 'SAMPLE'),
('0987654321', 'prafullchavan', 'sample'),
('1234567890', 'aniket', 'ANIKET'),
('Sample', '213121321', '1234567890');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`mobno`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
