-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 08, 2025 at 04:28 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pmkprojekat`
--

-- --------------------------------------------------------

--
-- Table structure for table `artikli`
--

CREATE TABLE `artikli` (
  `id` int(11) NOT NULL,
  `naziv_artikla` varchar(255) NOT NULL,
  `cena` decimal(10,2) NOT NULL,
  `jedinica_mere` varchar(50) NOT NULL,
  `kategorija_id` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `artikli`
--

INSERT INTO `artikli` (`id`, `naziv_artikla`, `cena`, `jedinica_mere`, `kategorija_id`) VALUES
(1, 'Jabuka', 150.00, 'kg', 82),
(2, 'Kruska', 200.00, 'kg', 82),
(3, 'Lubenica', 600.00, 'kg', 82),
(4, 'Trešnja', 200.00, 'kg', 82),
(5, 'Višnja', 195.00, 'kg', 82),
(8, 'Sargarepa', 25.00, 'kom', 84),
(9, 'Sljiva', 132.00, 'kg', 82),
(10, 'Karmin Crveni', 500.00, 'komad', 87),
(11, 'Banana', 400.00, 'kg', 82),
(12, 'Limun', 140.00, 'kg', 82),
(13, 'Mandarina', 200.00, 'kg', 82),
(14, 'Grozdje', 550.00, 'kg', 82),
(16, 'Deterdzent 300ml', 200.00, 'kom', 88),
(17, 'Lak za nokte crveni', 450.00, 'komad', 87),
(18, 'Pomorandza', 400.00, 'kg', 82),
(19, 'Avokado', 1000.00, 'kg', 82),
(20, 'Nar', 750.00, 'kg', 82),
(21, 'Kivi', 400.00, 'kg', 82),
(22, 'Mango', 420.00, 'kg', 82),
(23, 'Ananas', 300.00, 'kg', 82),
(24, 'Paradajz', 30.00, 'kom', 84),
(25, 'Kupus', 70.00, 'kom', 84),
(26, 'Maskara Essence', 380.00, 'komad', 87);

-- --------------------------------------------------------

--
-- Table structure for table `kategorije`
--

CREATE TABLE `kategorije` (
  `id` int(10) UNSIGNED NOT NULL,
  `naziv_kategorije` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `kategorije`
--

INSERT INTO `kategorije` (`id`, `naziv_kategorije`) VALUES
(86, 'Bela tehnika'),
(87, 'Kozmetika'),
(88, 'Kucna hemija'),
(85, 'Kucni alati'),
(84, 'Povrce'),
(82, 'Voce');

-- --------------------------------------------------------

--
-- Table structure for table `prodaja`
--

CREATE TABLE `prodaja` (
  `artikal_id` int(11) NOT NULL,
  `datum` date NOT NULL,
  `kolicina` decimal(11,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `prodaja`
--

INSERT INTO `prodaja` (`artikal_id`, `datum`, `kolicina`) VALUES
(1, '2025-05-08', 11),
(3, '2025-05-08', 1),
(4, '2025-05-08', 1),
(8, '2025-05-08', 4),
(11, '2025-05-08', 5),
(13, '2025-05-09', 9),
(14, '2025-05-08', 11),
(16, '2025-05-07', 8),
(20, '2025-05-08', 18),
(21, '2025-05-08', 12),
(24, '2025-05-08', 34),
(25, '2025-05-08', 4);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `artikli`
--
ALTER TABLE `artikli`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_artikli_kategorije` (`kategorija_id`);

--
-- Indexes for table `kategorije`
--
ALTER TABLE `kategorije`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `naziv_kategorije` (`naziv_kategorije`);

--
-- Indexes for table `prodaja`
--
ALTER TABLE `prodaja`
  ADD PRIMARY KEY (`artikal_id`,`datum`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `artikli`
--
ALTER TABLE `artikli`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `kategorije`
--
ALTER TABLE `kategorije`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=89;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `artikli`
--
ALTER TABLE `artikli`
  ADD CONSTRAINT `fk_artikli_kategorije` FOREIGN KEY (`kategorija_id`) REFERENCES `kategorije` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
