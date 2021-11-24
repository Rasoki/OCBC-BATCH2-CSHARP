-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 25 Nov 2021 pada 00.30
-- Versi server: 10.1.38-MariaDB
-- Versi PHP: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `staff`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `data_staff`
--

CREATE TABLE `data_staff` (
  `NIK` int(11) NOT NULL,
  `NAMA` varchar(50) DEFAULT NULL,
  `ALAMAT` varchar(50) DEFAULT NULL,
  `HANDPHONE` varchar(15) DEFAULT NULL,
  `joindate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `data_staff`
--

INSERT INTO `data_staff` (`NIK`, `NAMA`, `ALAMAT`, `HANDPHONE`, `joindate`) VALUES
(1001, 'EKA', 'BALI', '0888888', '2002-10-10'),
(1002, 'EK0', 'BANTUL', '0777777', '2003-10-10'),
(1003, 'EKI', 'BANDUNG', '0666666', '2000-10-10');

-- --------------------------------------------------------

--
-- Struktur dari tabel `staffoutsource`
--

CREATE TABLE `staffoutsource` (
  `NIK` int(11) NOT NULL,
  `NAMA` varchar(50) DEFAULT NULL,
  `ALAMAT` varchar(50) DEFAULT NULL,
  `HANDPHONE` varchar(15) DEFAULT NULL,
  `joindate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `staffoutsource`
--

INSERT INTO `staffoutsource` (`NIK`, `NAMA`, `ALAMAT`, `HANDPHONE`, `joindate`) VALUES
(1004, 'RARA', 'BOJONG', '0999999', '2005-10-10'),
(1005, 'RIRI', 'BATAM', '0111111', '2002-10-10'),
(1006, 'RURU', 'BANJAR', '0121212', '2003-10-10'),
(1007, 'RERE', 'BOGOR', '0131313', '2000-10-10'),
(1008, 'RORO', 'BENGKULU', '0666666', '2001-10-10'),
(1009, 'BABA', 'BANDUNG', '0777777', '2002-10-10'),
(1010, 'BIBI', 'BANTUL', '0888888', '2005-10-10'),
(1011, 'BUBU', 'BALI', '0141414', '2006-10-10'),
(1012, 'BEBE', 'BANDAR', '0151515', '2004-10-10'),
(1013, 'BOBO', 'BOGOR', '0161616', '2005-10-10');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `data_staff`
--
ALTER TABLE `data_staff`
  ADD PRIMARY KEY (`NIK`);

--
-- Indeks untuk tabel `staffoutsource`
--
ALTER TABLE `staffoutsource`
  ADD PRIMARY KEY (`NIK`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
