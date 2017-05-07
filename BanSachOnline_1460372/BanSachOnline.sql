use master
go

if DB_ID('BanSachOnline') is not null drop database BanSachOnline
go

create database BanSachOnline
go

use BanSachOnline
go

create table Sach
(
	ID_Sach int identity(1,1),	
	Ten_Sach varchar(100),
	ID_TacGia int,	
	ID_Series int,
	NoiDung_Sach varchar(max),
	NhaXuatBan_Sach varchar(100),
	NgayXuatBan_Sach date,
	Gia_Sach decimal(19,0),
	TrangBia_Sach varchar(max),
	SoLuongBinhLuan_Sach int default 0,
	SoLuongDanhGia_Sach int default 0,
	BiXoa_Sach int default 0,
	primary key (ID_Sach)
)

create table TacGia
(
	ID_TacGia int identity(1,1),
	Ten_TacGia varchar(100),
	primary key (ID_TacGia)
)

create table Series
(
	ID_Series int identity(1,1),
	Ten_Series varchar(100),
	TrangBia_Series varchar(max),
	primary key (ID_Series)
)

create table TheLoai
(
	ID_TheLoai int identity(1,1),
	Ten_TheLoai varchar(100),
	primary key (ID_TheLoai)
)

create table TheLoai_Sach
(
	ID_Series int,
	ID_TheLoai int,	
	primary key (ID_Series, ID_TheLoai)
)

create table BinhLuan
(
	ID_BinhLuan int identity(1,1),
	ID_Sach int,
	ID_KH int,
	NoiDung_BinhLuan varchar(max),
	Ngay_BinhLuan date,
	primary key (ID_BinhLuan, ID_Sach, ID_KH)
)

create table GiaoHang
(
	ID_GiaoHang int identity(1,1),
	Ten_GiaoHang varchar(10),
	primary key(ID_GiaoHang)
)

create table GiaoHang_Sach
(
	ID_Sach int,
	ID_GiaoHang int,
	primary key (ID_Sach, ID_GiaoHang)
)

create table DatHang
(
	ID_DatHang int identity(1,1),
	ID_KH int,	
	NgayDat_DatHang date,
	DonGia_DatHang decimal(19, 4),
	TinhTrang_DatHang int,
	primary key (ID_DatHang, ID_KH)
)

create table TinhTrang
(
	ID_TinhTrang int identity(1,1),
	Ten_TinhTrang varchar(10),
	primary key (ID_TinhTrang)
)

create table DatHangChiTiet
(	
	ID_DatHang int,
	ID_Sach int,
	SoLuong_DatHangChiTiet int,
	Gia_DatHangChiTiet decimal(19, 0),
	ThanhTien_DatHangChiTiet decimal(19, 0),
	primary key (ID_DatHang, ID_Sach)
)

create table KhachHang
(
	ID_KhachHang int identity(1,1),
	Ten_KhachHang nvarchar(100),
	DiaChi_KhachHang nvarchar(max),
	SDT_KhachHang varchar(50),
	ID_TaiKhoan int,
	primary key(ID_KhachHang)
)

create table TaiKhoan
(
	recID_TaiKhoan int identity(1,1),
	TenDangNhap_TaiKhoan varchar(100),
	MatKhau_TaiKhoan varchar(100),
	BiXoa_TaiKhoan int default 0,
	primary key(recID_TaiKhoan)
)

insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 1'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2014/05/09'
		, 463
		, '/Content/Image/Book/Cover/c001001.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 2'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2014/10/09'
		, 463
		, '/Content/Image/Book/Cover/c001002.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 3'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2015/03/17'
		, 463
		, '/Content/Image/Book/Cover/c001003.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 4'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2015/05/15'
		, 463
		, '/Content/Image/Book/Cover/c001004.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 5'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2015/07/17'
		, 463
		, '/Content/Image/Book/Cover/c001005.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 6'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2015/10/16'
		, 463
		, '/Content/Image/Book/Cover/c001006.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 7'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2016/01/15'
		, 463
		, '/Content/Image/Book/Cover/c001007.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 8'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2016/03/17'
		, 463
		, '/Content/Image/Book/Cover/c001008.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 9'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2016/05/17'
		, 463
		, '/Content/Image/Book/Cover/c001009.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 10'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2016/07/15'
		, 463
		, '/Content/Image/Book/Cover/c001010.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 11'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2016/09/16'
		, 463
		, '/Content/Image/Book/Cover/c001011.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 12'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2016/11/17'
		, 463
		, '/Content/Image/Book/Cover/c001012.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 13'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2017/02/17'
		, 463
		, '/Content/Image/Book/Cover/c001013.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 14'
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, 'Kodansha'
		, '2017/04/17'
		, 463
		, '/Content/Image/Book/Cover/c001014.png')

insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 1'
		, 2
		, 2
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, 'Kodansha'
		, '2016/03/17'
		, 596
		, '/Content/Image/Book/Cover/c002001.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 2'
		, 2
		, 2
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, 'Kodansha'
		, '2014/12/12'
		, 596
		, '/Content/Image/Book/Cover/c002002.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 3'
		, 2
		, 2
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, 'Kodansha'
		, '2015/05/12'
		, 596
		, '/Content/Image/Book/Cover/c002003.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 4'
		, 2
		, 2
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, 'Kodansha'
		, '2015/08/12'
		, 596
		, '/Content/Image/Book/Cover/c002004.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 5'
		, 2
		, 2
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, 'Kodansha'
		, '2015/11/12'
		, 596
		, '/Content/Image/Book/Cover/c002005.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 6'
		, 2
		, 2
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, 'Kodansha'
		, '2016/03/11'
		, 596
		, '/Content/Image/Book/Cover/c002006.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 7'
		, 2
		, 2
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, 'Kodansha'
		, '2016/07/19'
		, 596
		, '/Content/Image/Book/Cover/c002007.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 8'
		, 2
		, 2
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, 'Kodansha'
		, '2016/11/18'
		, 596
		, '/Content/Image/Book/Cover/c002008.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, NoiDung_Sach, NhaXuatBan_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 9'
		, 2
		, 2
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, 'Kodansha'
		, '2017/04/12'
		, 596
		, '/Content/Image/Book/Cover/c002009.png')

insert into TacGia(Ten_TacGia) values ('Okushou, WATANABE Shizumu')
insert into TacGia(Ten_TacGia) values ('NANAO Nanaki')

insert into Series(Ten_Series, TrangBia_Series) values ('Real Account', '/Content/Image/Book/Cover/c001.png')
insert into Series(Ten_Series, TrangBia_Series) values ('Helck', '/Content/Image/Book/Cover/c002.png')

insert into TheLoai(Ten_TheLoai) values ('4-Koma')
insert into TheLoai(Ten_TheLoai) values ('Action')
insert into TheLoai(Ten_TheLoai) values ('Adult')
insert into TheLoai(Ten_TheLoai) values ('Adventure')
insert into TheLoai(Ten_TheLoai) values ('Comedy')--5
insert into TheLoai(Ten_TheLoai) values ('Comic')
insert into TheLoai(Ten_TheLoai) values ('Cooking')
insert into TheLoai(Ten_TheLoai) values ('Doujinshi')
insert into TheLoai(Ten_TheLoai) values ('Drama')--9
insert into TheLoai(Ten_TheLoai) values ('Ecchi')
insert into TheLoai(Ten_TheLoai) values ('Fantasy')--11
insert into TheLoai(Ten_TheLoai) values ('Gender Bender')
insert into TheLoai(Ten_TheLoai) values ('Harem')
insert into TheLoai(Ten_TheLoai) values ('Historical')
insert into TheLoai(Ten_TheLoai) values ('Horror')--15
insert into TheLoai(Ten_TheLoai) values ('Josei')
insert into TheLoai(Ten_TheLoai) values ('Lolicon')
insert into TheLoai(Ten_TheLoai) values ('Manga')
insert into TheLoai(Ten_TheLoai) values ('Manhua')
insert into TheLoai(Ten_TheLoai) values ('Manhwa')--20
insert into TheLoai(Ten_TheLoai) values ('Martial Arts')
insert into TheLoai(Ten_TheLoai) values ('Mature')
insert into TheLoai(Ten_TheLoai) values ('Mecha')--23
insert into TheLoai(Ten_TheLoai) values ('Medical')
insert into TheLoai(Ten_TheLoai) values ('Music')
insert into TheLoai(Ten_TheLoai) values ('Mystery')
insert into TheLoai(Ten_TheLoai) values ('One shot')
insert into TheLoai(Ten_TheLoai) values ('Psychological')--28
insert into TheLoai(Ten_TheLoai) values ('Romance')
insert into TheLoai(Ten_TheLoai) values ('School Life')
insert into TheLoai(Ten_TheLoai) values ('Sci-fi')--31
insert into TheLoai(Ten_TheLoai) values ('Seinen')
insert into TheLoai(Ten_TheLoai) values ('Shotacon')
insert into TheLoai(Ten_TheLoai) values ('Shoujo')
insert into TheLoai(Ten_TheLoai) values ('Shoujo Ai')
insert into TheLoai(Ten_TheLoai) values ('Shounen')--36
insert into TheLoai(Ten_TheLoai) values ('Shounen Ai')
insert into TheLoai(Ten_TheLoai) values ('Slice of Life')
insert into TheLoai(Ten_TheLoai) values ('Smut')
insert into TheLoai(Ten_TheLoai) values ('Sports')
insert into TheLoai(Ten_TheLoai) values ('Supernatural')--41
insert into TheLoai(Ten_TheLoai) values ('Tragedy')--42
insert into TheLoai(Ten_TheLoai) values ('Webtoon')
insert into TheLoai(Ten_TheLoai) values ('Yaoi')
insert into TheLoai(Ten_TheLoai) values ('Yuri')

insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (1, 2)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (1, 4)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (1, 5)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (1, 9)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (1, 15)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (1, 28)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (1, 31)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (1, 36)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (2, 2)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (2, 4)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (2, 5)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (2, 11)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (2, 36)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (2, 42)

insert into GiaoHang(Ten_GiaoHang) values ('out stock')
insert into GiaoHang(Ten_GiaoHang) values ('7-21 days')
insert into GiaoHang(Ten_GiaoHang) values ('1-3 days')
insert into GiaoHang(Ten_GiaoHang) values ('24 hours')

insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (1, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (2, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (3, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (4, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (5, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (6, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (7, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (8, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (9, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (10, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (11, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (12, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (13, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (14, 4)

insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (15, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (16, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (17, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (18, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (19, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (20, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (21, 4)
insert into GiaoHang_Sach(ID_Sach, ID_GiaoHang) values (22, 4)

insert into TinhTrang(Ten_TinhTrang) values ('huy bo')
insert into TinhTrang(Ten_TinhTrang) values ('dang xu li')
insert into TinhTrang(Ten_TinhTrang) values ('hoan tat')

