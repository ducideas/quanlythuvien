-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3308
-- Generation Time: Dec 01, 2020 at 09:49 AM
-- Server version: 8.0.18
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
-- Database: `quanlythuvien`
--

-- --------------------------------------------------------

--
-- Table structure for table `baocao_muonsach_theloai`
--

DROP TABLE IF EXISTS `baocao_muonsach_theloai`;
CREATE TABLE IF NOT EXISTS `baocao_muonsach_theloai` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_TheLoai` int(10) UNSIGNED NOT NULL,
  `Thang` int(2) NOT NULL,
  `SoLuotMuon` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id` (`id`),
  KEY `id_TheLoai` (`id_TheLoai`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `baocao_muonsach_theloai`
--

INSERT INTO `baocao_muonsach_theloai` (`id`, `id_TheLoai`, `Thang`, `SoLuotMuon`) VALUES
(1, 7, 12, 3),
(2, 1, 12, 4),
(3, 6, 12, 2),
(4, 2, 12, 2),
(5, 3, 11, 2),
(6, 5, 11, 1);

-- --------------------------------------------------------

--
-- Table structure for table `baocao_sach_tre`
--

DROP TABLE IF EXISTS `baocao_sach_tre`;
CREATE TABLE IF NOT EXISTS `baocao_sach_tre` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_TraSach` int(10) UNSIGNED NOT NULL,
  `Ngay` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id` (`id`),
  KEY `id_TraSach` (`id_TraSach`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `baocao_sach_tre`
--

INSERT INTO `baocao_sach_tre` (`id`, `id_TraSach`, `Ngay`) VALUES
(1, 1, '2020-12-03');

-- --------------------------------------------------------

--
-- Table structure for table `chitietmuonsach`
--

DROP TABLE IF EXISTS `chitietmuonsach`;
CREATE TABLE IF NOT EXISTS `chitietmuonsach` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_MuonSach` int(10) UNSIGNED NOT NULL,
  `id_Sach` int(10) UNSIGNED NOT NULL,
  `created_at` datetime NULL DEFAULT NULL,
  `updated_at` datetime NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_MuonSach` (`id_MuonSach`),
  KEY `id_Sach` (`id_Sach`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `chitietmuonsach`
--

INSERT INTO `chitietmuonsach` (`id`, `id_MuonSach`, `id_Sach`, `created_at`, `updated_at`) VALUES
(1, 1, 14, '2020-11-30 17:00:00', NULL),
#(2, 1, 14, '2020-11-30 17:00:00', NULL),
(3, 2, 1, '2020-11-30 17:00:00', NULL),
(4, 2, 6, '2020-11-30 17:00:00', NULL),
(5, 2, 9, '2020-11-30 17:00:00', NULL),
#(6, 2, 8, '2020-11-30 17:00:00', NULL),
(7, 3, 2, '2020-11-30 17:00:00', NULL),
(8, 3, 8, '2020-11-30 17:00:00', NULL),
(9, 3, 13, '2020-11-30 17:00:00', NULL),
(10, 4, 7, '2020-11-30 17:00:00', NULL),
(11, 4, 10, '2020-11-30 17:00:00', NULL),
#(12, 4, 5, '2020-11-30 17:00:00', NULL),
(13, 4, 3, '2020-11-30 17:00:00', NULL),
#(14, 5, 1, '2020-11-30 17:00:00', NULL),
(15, 5, 5, '2020-11-30 17:00:00', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `chitiettrasach`
--

DROP TABLE IF EXISTS `chitiettrasach`;
CREATE TABLE IF NOT EXISTS `chitiettrasach` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_TraSach` int(10) UNSIGNED NOT NULL,
  `id_Sach` int(10) UNSIGNED NOT NULL,
  `created_at` datetime NULL DEFAULT NULL,
  `updated_at` datetime NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_TraSach` (`id_TraSach`),
  KEY `id_Sach` (`id_Sach`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `chitiettrasach`
--

INSERT INTO `chitiettrasach` (`id`, `id_TraSach`, `id_Sach`) VALUES
(1, 1, 2),
(2, 1, 8),
(3, 1, 13),
(4, 2, 7),
(5, 2, 10),
(6, 2, 5),
(7, 2, 3);

-- --------------------------------------------------------

--
-- Table structure for table `docgia`
--

DROP TABLE IF EXISTS `docgia`;
CREATE TABLE IF NOT EXISTS `docgia` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `HoVaTen` varchar(255) NOT NULL,
  `GioiTinh` varchar(3) NOT NULL,
  `SoDT` varchar(15) NOT NULL,
  `LoaiDocGia` varchar(255) NOT NULL,
  `NgaySinh` date NOT NULL,
  `DiaChi` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `NgayLapThe` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `TongNo` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `infor_users`
--

INSERT INTO `docgia` (`id`, `HoVaTen`, `GioiTinh`, `SoDT`, `LoaiDocGia`, `NgaySinh`, `DiaChi`, `Email`, `TongNo`) VALUES
(1, 'Pham Thi Thu Thuy', 'Nu', '0354818906', 'Hoc Sinh', '1998-03-27', '18 Duong Pham Van Bach, Go Vap, TPHCM', 'thuthuy123@gmail.com', 0),
(2, 'Dinh Thi Huong', 'Nu', '0354152456', 'Hoc Sinh', '1999-05-12', 'ktx khu A- ?HQGTPHCM', 'dinhhuong123@gmail.com', 0),
(3, 'Nguyen Thanh Phat', 'Nam', '0362014567', 'Hoc Sinh', '2000-11-03', 'ktx khu A- ?HQGTPHCM', 'thanhphat345@gmail.com', 0),
(4, 'Nguyen Thi Hong Nhu', 'Nu', '0984567421', 'Sinh Vien', '1997-10-25', 'ktx khu B- ?HQGTPHCM', 'hongnhu234@gmail.com', 0),
(5, 'Phan Thanh Tra', 'Nu', '018546123', 'Sinh Vien', '1999-08-11', 'ktx khu B- ?HQGTPHCM', 'thanhtra@gmail.com', 0),
(6, 'Nguyen Quang Huy', 'Nam', '085612354', 'Khac', '1996-04-01', 'ktx khu A- ?HQGTPHCM', 'quanghuy@gmail.com', 0);



-- --------------------------------------------------------

--
-- Table structure for table `muonsach`
--

DROP TABLE IF EXISTS `muonsach`;
CREATE TABLE IF NOT EXISTS `muonsach` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_user` int(10) UNSIGNED NOT NULL,
  `NgayMuon` date NOT NULL,
  `NgayTra` date NOT NULL,
  `TongTien` int(10) DEFAULT NULL,
  `TrangThai` int(1) UNSIGNED NOT NULL,
  `created_at` datetime NULL DEFAULT NULL,
  `updated_at` datetime NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_user` (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `muonsach`
--

INSERT INTO `muonsach` (`id`, `id_user`, `NgayMuon`, `NgayTra`, `TongTien`, `TrangThai`, `created_at`, `updated_at`) VALUES
(1, 1, '2020-12-01', '2020-12-10', 6000, 0, '2020-11-30 17:00:00', NULL),
(2, 2, '2020-12-01', '2020-12-15', 12000, 0, '2020-11-30 17:00:00', NULL),
(3, 3, '2020-11-20', '2020-12-01', 9000, 0, '2020-11-30 17:00:00', NULL),
(4, 1, '2020-11-24', '2020-12-02', 12000, 0, '2020-11-30 17:00:00', NULL),
(5, 3, '2020-12-01', '2020-12-10', 6000, 0, '2020-11-30 17:00:00', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `nhap`
--

DROP TABLE IF EXISTS `nhap`;
CREATE TABLE IF NOT EXISTS `nhap` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_Sach` int(10) UNSIGNED NOT NULL,
  `SoLuongNhap` int(10) NOT NULL,
  `NgayNhap` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `id_Sach` (`id_Sach`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `nhap`
--

INSERT INTO `nhap` (`id`, `id_Sach`, `SoLuongNhap`) VALUES
(1, 4, 2),
(2, 8, 3),
(3, 10, 5),
(4, 13, 2);

-- --------------------------------------------------------

--
-- Table structure for table `phieuthutienphat`
--

DROP TABLE IF EXISTS `phieuthutienphat`;
CREATE TABLE IF NOT EXISTS `phieuthutienphat` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_user` int(10) UNSIGNED NOT NULL,
  `SoTienThu` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_user` (`id_user`),
  KEY `id_user_2` (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `phieuthutienphat`
--

INSERT INTO `phieuthutienphat` (`id`, `id_user`, `SoTienThu`) VALUES
(1, 3, 6000);

-- --------------------------------------------------------

--
-- Table structure for table `sach`
--

DROP TABLE IF EXISTS `sach`;
CREATE TABLE IF NOT EXISTS `sach` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `TenSach` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `TacGia` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `id_TheLoai` int(10) UNSIGNED NOT NULL,
  `NamXuatBan` int(4) NOT NULL,
  `NhaXuatBan` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `TriGia` int(7) NOT NULL,
  `TinhTrang` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `SoLuong` int(4) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_TheLoai` (`id_TheLoai`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sach`
--

INSERT INTO `sach` (`id`, `TenSach`, `TacGia`, `id_TheLoai`, `NamXuatBan`, `NhaXuatBan`, `TriGia`, `TinhTrang`, `SoLuong`, `created_at`, `updated_at`) VALUES
(1, 'Lac Giua Niem Dau ', 'Nguyen Ngoc Thach', 1, 2018, 'NXB Hoi Nha Van', 152000, 'Het Hang', 2, '2020-11-30 17:00:00', NULL),
(2, 'Thien Tai Ben Trai, Ke Dien Ben Phai', 'Cao Minh', 2, 2018, 'NXB The Gioi', 124000, 'Het Hang', 7, '2020-11-30 17:00:00', NULL),
(3, 'Cau Thang Gao Thet', 'Jonathan Stroud', 3, 2020, 'NXB Van Hoc', 210000, 'Het Hang', 4, '2020-11-30 17:00:00', NULL),
(4, 'Cong Pha Ly Thuyet Hoa', 'Tran Phuong Duy', 4, 2020, 'NXB DHQG HaNoi', 211000, 'Con Hang', 7, '2020-11-30 17:00:00', NULL),
(5, 'Tu Dien Han Viet', 'Truong Van Gioi', 5, 2019, 'NXB Khoa Hoc HaNoi', 70000, 'Het Hang', 5, '2020-11-30 17:00:00', NULL),
(6, 'Bien Nhuoc Diem Thanh Uu Diem', 'Vuong Chi Cuong', 6, 2019, 'NXB Thanh Hoa', 62000, 'Het Hang', 5, '2020-11-30 17:00:00', NULL),
(7, 'Dai Viet Su Ky Toan Thu ', 'Nhieu Tac Gia', 7, 2018, 'NXB Thoi Dai', 233000, 'Het Hang', 5, '2020-11-30 17:00:00', NULL),
(8, 'Co Tich Khong Phep Mau', 'Dao ', 1, 2019, 'NXB Thanh Nien', 126000, 'Het Hang', 7, '2020-11-30 17:00:00', NULL),
(9, 'Mat Biec', 'Nguyen Nhat Anh', 2, 2019, 'NXB Tre', 156000, 'Het Hang', 4, '2020-11-30 17:00:00', NULL),
(10, 'Thanh Pho Hon Rong', 'Ransom Riggs', 3, 2019, 'NXB Van Hoc', 79000, 'Het Hang', 10, '2020-11-30 17:00:00', NULL),
(11, 'Cong Pha Toan 2', 'Nhieu Tac Gia', 4, 2019, 'NXB DHQG HaNoi', 163000, 'Con Hang', 0, '2020-11-30 17:00:00', NULL),
(12, 'Tu Dien Tieng Anh Thuong Mai', 'Nguyen Quoc Hung M.A', 5, 2018, 'NXB Hong Duc', 92000, 'Con Hang', 3, '2020-11-30 17:00:00', NULL),
(13, 'Can Bang Cam Xuc, Ca Luc Bao Giong', 'Richard Nichollas', 6, 2017, 'NXB The Gioi', 127000, 'Het Hang', 5, '2020-11-30 17:00:00', NULL),
(14, 'Lich su Do Thai', 'Paul Johnson', 7, 2018, 'NXB Dan Tri', 100000, 'Het Hang', 4, '2020-11-30 17:00:00', NULL),
(15, 'Dam Bi Ghet', 'Koga Fimitake', 1, 2018, 'NXB Dan Tri', 65000, 'Con Hang', 4, '2020-11-30 17:00:00', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `setting`
--

DROP TABLE IF EXISTS `setting`;
CREATE TABLE IF NOT EXISTS `setting` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `nameSetting` varchar(255) NOT NULL,
  `valueSetting` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `setting`
--

INSERT INTO `setting` (`id`, `nameSetting`, `valueSetting`) VALUES
(1, 'Tien Phat', '1000'),
(2, 'Tien Muon Sach', '3000'),
(3, 'So Ngay Muon Toi Da', '6'),
(4, 'Tien Boi Thuong', '35000');

-- --------------------------------------------------------

--
-- Table structure for table `theloai`
--

DROP TABLE IF EXISTS `theloai`;
CREATE TABLE IF NOT EXISTS `theloai` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `Ten` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `theloai`
--

INSERT INTO `theloai` (`id`, `Ten`, `created_at`, `updated_at`) VALUES
(1, 'Truyen Ngan', '2020-11-30 17:00:00', NULL),
(2, 'Tan Van', '2020-11-30 17:00:00', NULL),
(3, 'Kinh Di', '2020-11-30 17:00:00', NULL),
(4, 'Tham Khao', '2020-11-30 17:00:00', NULL),
(5, 'Tu Dien', '2020-11-30 17:00:00', NULL),
(6, 'Ky Nang Song ', '2020-11-30 17:00:00', NULL),
(7, 'Lich Su', '2020-11-30 17:00:00', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `trasach`
--

DROP TABLE IF EXISTS `trasach`;
CREATE TABLE IF NOT EXISTS `trasach` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_user` int(10) UNSIGNED NOT NULL,
  `NgayTra` date NOT NULL,
  `SoNgayTre` int(10) NOT NULL,
  `TienTre` int(10) NOT NULL,
  `TienBoiThuong` int(10) NOT NULL,
  `TienThueSach` int(10) NOT NULL,
  `TongTien` int(10) NOT NULL,
  `created_at` datetime NULL DEFAULT NULL,
  `updated_at` datetime NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_user` (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `trasach`
--

INSERT INTO `trasach` (`id`, `id_user`, `NgayTra`, `SoNgayTre`, `TienTre`, `TienBoiThuong`, `TienThueSach`, `TongTien`, `created_at`, `updated_at`) VALUES
(1, 3, '2020-12-03', 2, 6000, 0, 9000, 15000, '2020-11-30 17:00:00', NULL),
(2, 1, '2020-12-01', 0, 0, 0, 12000, 12000, '2020-11-30 17:00:00', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `nhanvien`
--

DROP TABLE IF EXISTS `nhanvien`;
CREATE TABLE IF NOT EXISTS `nhanvien` (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `HoVaTen` varchar(255) NOT NULL,
  `GioiTinh` varchar(3) NOT NULL,
  `SoDT` varchar(15) NOT NULL,
  `NgaySinh` date NOT NULL,
  `DiaChi` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `NgayVaoLam` date NOT NULL,
  `ChucVu` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
--
-- Dumping data for table user
--

INSERT INTO `nhanvien` (`id`, `username` , `password` , `HoVaTen` , `GioiTinh` , `SoDT` , `NgaySinh` , `DiaChi`, `Email`,`NgayVaoLam`,`ChucVu`) VALUES
(1, 'duc', 'duc', 'Le Huynh Duc', 'Nam', '123456789', '2020-12-03', 'abc', 'duc@gmail.com','2020-11-11','Giam Doc'),
(2, 'loi', 'loi', 'Tran Nguyen Loi', 'Nam', '123456789', '2020-12-03', 'abc', 'loi@gmail.com','2020-11-11','Nhan Vien'),
(3, 'lan', 'lan', 'Nguyen Thi Ngoc Lan', 'Nu', '123456789', '2020-12-03', 'abc', 'loi@gmail.com','2020-11-11','Nhan Vien'),
(4, 'huy', 'huy', 'Huynh Gia Huy', 'Nam', '123456789', '2020-12-03', 'abc', 'huy@gmail.com','2020-11-11','Nhan Vien');

-- --------------------------------------------------------

--

--
-- Constraints for dumped tables
--

--
-- Constraints for table `baocao_muonsach_theloai`
--
ALTER TABLE `baocao_muonsach_theloai`
  ADD CONSTRAINT `baocao_muonsach_theloai_ibfk_1` FOREIGN KEY (`id_TheLoai`) REFERENCES `theloai` (`id`);

--
-- Constraints for table `baocao_sach_tre`
--
ALTER TABLE `baocao_sach_tre`
  ADD CONSTRAINT `baocao_sach_tre_ibfk_1` FOREIGN KEY (`id_TraSach`) REFERENCES `trasach` (`id`);

--
-- Constraints for table `chitietmuonsach`
--
ALTER TABLE `chitietmuonsach`
  ADD CONSTRAINT `chitietmuonsach_ibfk_2` FOREIGN KEY (`id_Sach`) REFERENCES `sach` (`id`),
  ADD CONSTRAINT `chitietmuonsach_ibfk_3` FOREIGN KEY (`id_MuonSach`) REFERENCES `muonsach` (`id`);

--
-- Constraints for table `chitiettrasach`
--
ALTER TABLE `chitiettrasach`
  ADD CONSTRAINT `chitiettrasach_ibfk_1` FOREIGN KEY (`id_TraSach`) REFERENCES `trasach` (`id`),
  ADD CONSTRAINT `chitiettrasach_ibfk_2` FOREIGN KEY (`id_Sach`) REFERENCES `sach` (`id`);

--
-- Constraints for table `infor_users`
--

--
-- Constraints for table `muonsach`
--
ALTER TABLE `muonsach`
  ADD CONSTRAINT `muonsach_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `docgia` (`id`);

--
-- Constraints for table `nhap`
--
ALTER TABLE `nhap`
  ADD CONSTRAINT `nhap_ibfk_1` FOREIGN KEY (`id_Sach`) REFERENCES `sach` (`id`);

--
-- Constraints for table `phieuthutienphat`
--
ALTER TABLE `phieuthutienphat`
  ADD CONSTRAINT `phieuthutienphat_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `docgia` (`id`);

--
-- Constraints for table `sach`
--
ALTER TABLE `sach`
  ADD CONSTRAINT `sach_ibfk_1` FOREIGN KEY (`id_TheLoai`) REFERENCES `theloai` (`id`);

--
-- Constraints for table `trasach`
--
ALTER TABLE `trasach`
  ADD CONSTRAINT `trasach_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `docgia` (`id`);


COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
