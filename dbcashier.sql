-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 22, 2022 at 07:04 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbcashier`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `id_barang` int(6) UNSIGNED NOT NULL,
  `barcode` varchar(20) NOT NULL,
  `nm_barang` varchar(30) NOT NULL,
  `jml_barang` int(10) NOT NULL,
  `jml_terjual` int(10) UNSIGNED NOT NULL,
  `harga_beli` int(10) UNSIGNED NOT NULL,
  `harga_jual` int(10) UNSIGNED NOT NULL,
  `satuan` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`id_barang`, `barcode`, `nm_barang`, `jml_barang`, `jml_terjual`, `harga_beli`, `harga_jual`, `satuan`) VALUES
(1, '8995230704991', 'Tisu See-U 2 ply 200 sheets', 20, 0, 6500, 7500, 'box'),
(2, '8999908723802', 'My Baby baby powder telon plus', 30, 5, 2000, 2500, 'btl');

-- --------------------------------------------------------

--
-- Table structure for table `detail_transaksi`
--

CREATE TABLE `detail_transaksi` (
  `id_detail` int(11) UNSIGNED NOT NULL,
  `id_transaksi` varchar(30) NOT NULL,
  `id_barang` int(6) NOT NULL,
  `jum_jual` int(6) NOT NULL,
  `harga_jual` int(10) NOT NULL,
  `subtotal` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `detail_transaksi`
--

INSERT INTO `detail_transaksi` (`id_detail`, `id_transaksi`, `id_barang`, `jum_jual`, `harga_jual`, `subtotal`) VALUES
(7, '637861749172565704', 1, 3, 7500, 22500),
(8, '637861749172565704', 2, 1, 2500, 2500),
(9, '637861774714227521', 1, 1, 7500, 7500),
(10, '637861783889972791', 1, 1, 7500, 7500),
(11, '637861785578016472', 1, 1, 7500, 7500),
(12, '637861787100904102', 1, 1, 7500, 7500),
(13, '637861789418392440', 1, 1, 7500, 7500),
(14, '637861791747458526', 1, 1, 7500, 7500),
(15, '637861798875449403', 1, 1, 7500, 7500),
(16, '637862179039910715', 1, 1, 7500, 7500),
(17, '637862217477855750', 1, 1, 7500, 7500),
(18, '637862225254371286', 1, 1, 7500, 7500),
(19, '637862227687045773', 1, 1, 7500, 7500),
(20, '637862228469641684', 1, 1, 7500, 7500),
(21, '637862233673960930', 1, 1, 7500, 7500),
(22, '637862234544384662', 1, 1, 7500, 7500),
(23, '637862236502089728', 1, 1, 7500, 7500),
(24, '637862252651094107', 1, 3, 7500, 22500),
(25, '637862252651094107', 2, 1, 2500, 2500),
(26, '637862255450699573', 2, 4, 2500, 10000),
(27, '637862255450699573', 1, 1, 7500, 7500);

-- --------------------------------------------------------

--
-- Table structure for table `jabatan`
--

CREATE TABLE `jabatan` (
  `id_jabatan` int(2) UNSIGNED NOT NULL,
  `nm_jabatan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `jabatan`
--

INSERT INTO `jabatan` (`id_jabatan`, `nm_jabatan`) VALUES
(1, 'Direktur'),
(2, 'Staf kasir');

-- --------------------------------------------------------

--
-- Table structure for table `pegawai`
--

CREATE TABLE `pegawai` (
  `id_pegawai` int(6) UNSIGNED NOT NULL,
  `nm_pegawai` varchar(30) NOT NULL,
  `id_jabatan` int(6) DEFAULT NULL,
  `nip` varchar(20) NOT NULL,
  `alamat` varchar(255) DEFAULT NULL,
  `hp` varchar(14) DEFAULT NULL,
  `gambar` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pegawai`
--

INSERT INTO `pegawai` (`id_pegawai`, `nm_pegawai`, `id_jabatan`, `nip`, `alamat`, `hp`, `gambar`) VALUES
(1, 'Edi Saputra', 1, '2022010001', 'Pijoan', '08123333333', 'D:\\99 Latihan C#\\Cashier\\Cashier\\bin\\Debug\\gambar\\1.jpg'),
(14, 'Habibi', 2, '1234', 'ewrwr', '08123242', 'D:\\LocalGitHub\\Aplikasi_Kasir\\Cashier\\bin\\Debug\\gambar\\img_637858998781322120');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` varchar(30) NOT NULL,
  `waktu` datetime NOT NULL,
  `id_pegawai` int(6) NOT NULL,
  `total_penjualan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `waktu`, `id_pegawai`, `total_penjualan`) VALUES
('637861749172565704', '2022-04-21 21:55:52', 14, 25000),
('637861774714227521', '2022-04-21 22:38:16', 14, 7500),
('637861783889972791', '2022-04-21 22:53:49', 14, 7500),
('637861785578016472', '2022-04-21 22:56:03', 14, 7500),
('637861787100904102', '2022-04-21 22:58:36', 14, 7500),
('637861789418392440', '2022-04-21 23:02:27', 14, 7500),
('637861791747458526', '2022-04-21 23:06:27', 14, 7500),
('637861798875449403', '2022-04-21 23:18:21', 14, 7500),
('637862179039910715', '2022-04-22 09:52:06', 14, 7500),
('637862217477855750', '2022-04-22 10:56:18', 14, 7500),
('637862225254371286', '2022-04-22 11:09:02', 14, 7500),
('637862227687045773', '2022-04-22 11:13:04', 14, 7500),
('637862228469641684', '2022-04-22 11:14:10', 14, 7500),
('637862233673960930', '2022-04-22 11:22:55', 14, 7500),
('637862234544384662', '2022-04-22 11:24:19', 14, 7500),
('637862236502089728', '2022-04-22 11:27:45', 14, 7500),
('637862252651094107', '2022-04-22 11:55:10', 14, 25000),
('637862255450699573', '2022-04-22 11:59:45', 14, 17500);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id_user` int(6) UNSIGNED NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(255) NOT NULL,
  `id_pegawai` int(6) NOT NULL,
  `role` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id_user`, `username`, `password`, `id_pegawai`, `role`) VALUES
(1, 'admin', '21232f297a57a5a743894a0e4a801fc3', 1, 1),
(12, '1234 ', '81dc9bdb52d04dc20036dbd8313ed055', 14, 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`id_barang`),
  ADD UNIQUE KEY `barcode` (`barcode`);

--
-- Indexes for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD PRIMARY KEY (`id_detail`);

--
-- Indexes for table `jabatan`
--
ALTER TABLE `jabatan`
  ADD PRIMARY KEY (`id_jabatan`),
  ADD UNIQUE KEY `nm_jabatan` (`nm_jabatan`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `id_barang` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  MODIFY `id_detail` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `jabatan`
--
ALTER TABLE `jabatan`
  MODIFY `id_jabatan` int(2) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `pegawai`
--
ALTER TABLE `pegawai`
  MODIFY `id_pegawai` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(6) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
