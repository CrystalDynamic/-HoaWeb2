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
	ID_NhaXuatBan int,
	NoiDung_Sach varchar(max),	
	NgayXuatBan_Sach date,
	Gia_Sach decimal(19,0),
	TrangBia_Sach varchar(max),
	ID_AvailableShippingDate int default 1,
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
	Gia_Series decimal(19,0),
	NoiDung_Series varchar(max),
	Banner_Series varchar(max),
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

create table NhaXuatBan
(
	ID_NhaXuatBan int identity(1,1),
	Ten_NhaXuatBan varchar(100),
	primary key (ID_NhaXuatBan)
)

create table TinhTrang
(
	ID_TinhTrang int identity(1,1),
	Ten_TinhTrang varchar(10),
	primary key (ID_TinhTrang)
)

create table AvailableShippingDate
(
	ID_AvailableShippingDate int identity(1,1),
	Ten_AvailableShippingDate varchar(10),
	primary key(ID_AvailableShippingDate)
)

create table BinhLuan
(
	ID_BinhLuan int identity(1,1),
	ID_Sach int,	
	Ten_KhachHang nvarchar(100),
	NoiDung_BinhLuan varchar(max),
	Ngay_BinhLuan date default getdate(),
	ID_TaiKhoan nvarchar(128),
	primary key (ID_BinhLuan, ID_Sach)
)

create table GioHang
(
	ID_GioHang int identity(1, 1),	
	ID_Sach int,
	SoLuong_GioHang int default 1,
	ID_TaiKhoan nvarchar(128),
	primary key (ID_GioHang)
)

create table DatHang
(
	ID_DatHang int identity(1,1),	
	NgayDat_DatHang date,
	DonGia_DatHang decimal(19, 4),
	ID_TinhTrang int,
	ID_TaiKhoan nvarchar(128),
	primary key (ID_DatHang)
)

create table DatHangChiTiet
(		
	ID_DatHang int,	
	ID_Sach int,
	SoLuong_DatHangChiTiet int,
	Gia_DatHangChiTiet decimal(19, 0),
	ThanhTien_DatHangChiTiet decimal(19, 0),
	ID_TaiKhoan nvarchar(128),
	primary key (ID_DatHang, ID_Sach)
)

create table TaiKhoan
(
	ID_TaiKhoan nvarchar(128),
	TenDangNhap_TaiKhoan varchar(100),
	MatKhau_TaiKhoan varchar(100),
	Ten_KhachHang nvarchar(100),
	DiaChi_KhachHang nvarchar(max),
	SDT_KhachHang varchar(50),	
	BiXoa_TaiKhoan int default 0,
	primary key(ID_TaiKhoan)
)


alter table Sach
add constraint FK_TacGiaSach foreign key (ID_TacGia) references TacGia(ID_TacGia),
	constraint FK_SeriesSach foreign key (ID_Series) references Series(ID_Series),
	constraint FK_NhaXuatBanSach foreign key (ID_NhaXuatBan) references NhaXuatBan(ID_NhaXuatBan),
	constraint FK_AvailableShippingDateSach foreign key (ID_AvailableShippingDate) references AvailableShippingDate(ID_AvailableShippingDate)

alter table TheLoai_Sach
add constraint FK_SeriesTheLoai_Sach foreign key (ID_Series) references Series(ID_Series),
	constraint FK_TheLoaiTheLoai_Sach foreign key (ID_TheLoai) references TheLoai(ID_TheLoai)

alter table BinhLuan
add constraint FK_SachBinhLuan foreign key (ID_Sach) references Sach(ID_Sach)	

alter table GioHang
add constraint FK_SachGioHang foreign key (ID_Sach) references Sach(ID_Sach)

alter table DatHang
add constraint FK_TinhTrangDatHang foreign key (ID_TinhTrang) references TinhTrang(ID_TinhTrang)

alter table DatHangChiTiet
add constraint FK_DatHangDatHangChiTiet foreign key (ID_DatHang) references DatHang(ID_DatHang),
	constraint FK_SachDatHangChiTiet foreign key (ID_Sach) references Sach(ID_Sach)


insert into TacGia(Ten_TacGia) values ('Okushou, WATANABE Shizumu')
insert into TacGia(Ten_TacGia) values ('NANAO Nanaki')
insert into TacGia(Ten_TacGia) values ('FUJIKO F. Fujio')
insert into TacGia(Ten_TacGia) values ('AOYAMA Gosho')
insert into TacGia(Ten_TacGia) values ('TEZUKA Osamu')
insert into TacGia(Ten_TacGia) values ('NAGATE Yuka')


insert into Series(Ten_Series, TrangBia_Series, Gia_Series, NoiDung_Series, Banner_Series) values ('Real Account', '/Content/Image/Book/Cover/c001.png', 463, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?', '/Content/Image/Book/Banner/b001.png')
insert into Series(Ten_Series, TrangBia_Series, Gia_Series, NoiDung_Series, Banner_Series) values ('Helck', '/Content/Image/Book/Cover/c002.png', 596, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?', '/Content/Image/Book/Banner/b002.png')
insert into Series(Ten_Series, TrangBia_Series, Gia_Series, NoiDung_Series, Banner_Series) values ('Doraemon', '/Content/Image/Book/Cover/c003.png', 463, 'Doraemon, a cat shaped robot which came from the 22nd century in the future, goes back in time in order to help Nobita, a below average lazy kid, to make his life less miserable and improve his descendent''s life. With many of Doreamon''s gadgets from the future, Nobita''s life will never be the same.

Doraemon was awarded the first Shogakukan Manga Award for children''s manga in 1982, and the first Osamu Tezuka Culture Award in 1997.', null)
insert into Series(Ten_Series, TrangBia_Series, Gia_Series, NoiDung_Series, Banner_Series) values ('Conan', '/Content/Image/Book/Cover/c004.png', 463, '16 year-old Kudo Shinichi, a famous High school detective, treats his friend, Mori Ran to a theme park named Tropical Land. After solving a murder case that occured on the same day, Shinichi notices and tails two people in black. However, one of them notices Shinichi and knocks him out. Instead of killing him, they gave him an untested poison that was supposed to kill him yet leave no traces. However, instead of killing him, it shrunk him into a 8 year old boy. Shinichi now goes under the name Edogawa Conan.', null)
insert into Series(Ten_Series, TrangBia_Series, Gia_Series, NoiDung_Series, Banner_Series) values ('Black Jack', '/Content/Image/Book/Cover/c005.png', 453, 'Black Jack is the doctor Tezuka wished he could be, one free of the constraints of the modern rules, who can heal and help on his rules. He travels the world helping those who pay him, sometime those he takes mercy on, and always those who move him. Despite not having a valid license, he is still the doctor of last resort, the only man who keeps the reaper at bay. Sometimes though, he''s the one who brings the reaper...

Won the 1st Kodansha Manga Award for shounen.', null)
insert into Series(Ten_Series, TrangBia_Series, Gia_Series, NoiDung_Series, Banner_Series) values ('Gift Å}', '/Content/Image/Book/Cover/c006.png', 637, 'My Manga love, It is about the girl who her name is Tamaki, save and respect human live', null)


insert into TheLoai(Ten_TheLoai) values ('4-Koma')--1
insert into TheLoai(Ten_TheLoai) values ('Action')--2
insert into TheLoai(Ten_TheLoai) values ('Adult')--3
insert into TheLoai(Ten_TheLoai) values ('Adventure')--4
insert into TheLoai(Ten_TheLoai) values ('Comedy')--5
insert into TheLoai(Ten_TheLoai) values ('Comic')--6
insert into TheLoai(Ten_TheLoai) values ('Cooking')--7
insert into TheLoai(Ten_TheLoai) values ('Doujinshi')--8
insert into TheLoai(Ten_TheLoai) values ('Drama')--9
insert into TheLoai(Ten_TheLoai) values ('Ecchi')--10
insert into TheLoai(Ten_TheLoai) values ('Fantasy')--11
insert into TheLoai(Ten_TheLoai) values ('Gender Bender')--12
insert into TheLoai(Ten_TheLoai) values ('Harem')--13
insert into TheLoai(Ten_TheLoai) values ('Historical')--14
insert into TheLoai(Ten_TheLoai) values ('Horror')--15
insert into TheLoai(Ten_TheLoai) values ('Josei')--16
insert into TheLoai(Ten_TheLoai) values ('Lolicon')--17
insert into TheLoai(Ten_TheLoai) values ('Manga')--18
insert into TheLoai(Ten_TheLoai) values ('Manhua')--19
insert into TheLoai(Ten_TheLoai) values ('Manhwa')--20
insert into TheLoai(Ten_TheLoai) values ('Martial Arts')--21
insert into TheLoai(Ten_TheLoai) values ('Mature')--22
insert into TheLoai(Ten_TheLoai) values ('Mecha')--23
insert into TheLoai(Ten_TheLoai) values ('Medical')--24
insert into TheLoai(Ten_TheLoai) values ('Music')--25
insert into TheLoai(Ten_TheLoai) values ('Mystery')--26
insert into TheLoai(Ten_TheLoai) values ('One shot')--27
insert into TheLoai(Ten_TheLoai) values ('Psychological')--28
insert into TheLoai(Ten_TheLoai) values ('Romance')--29
insert into TheLoai(Ten_TheLoai) values ('School Life')--30
insert into TheLoai(Ten_TheLoai) values ('Sci-fi')--31
insert into TheLoai(Ten_TheLoai) values ('Seinen')--32
insert into TheLoai(Ten_TheLoai) values ('Shotacon')--33
insert into TheLoai(Ten_TheLoai) values ('Shoujo')--34
insert into TheLoai(Ten_TheLoai) values ('Shoujo Ai')--35
insert into TheLoai(Ten_TheLoai) values ('Shounen')--36
insert into TheLoai(Ten_TheLoai) values ('Shounen Ai')--37
insert into TheLoai(Ten_TheLoai) values ('Slice of Life')--38
insert into TheLoai(Ten_TheLoai) values ('Smut')--39
insert into TheLoai(Ten_TheLoai) values ('Sports')--40
insert into TheLoai(Ten_TheLoai) values ('Supernatural')--41
insert into TheLoai(Ten_TheLoai) values ('Tragedy')--42
insert into TheLoai(Ten_TheLoai) values ('Webtoon')--43
insert into TheLoai(Ten_TheLoai) values ('Yaoi')--44
insert into TheLoai(Ten_TheLoai) values ('Yuri')--45


insert into NhaXuatBan(Ten_NhaXuatBan) values ('Kodansha')
insert into NhaXuatBan(Ten_NhaXuatBan) values ('Shogakukan')
insert into NhaXuatBan(Ten_NhaXuatBan) values ('Nihon Bungeisha')


insert into AvailableShippingDate(Ten_AvailableShippingDate) values ('24 hours')
insert into AvailableShippingDate(Ten_AvailableShippingDate) values ('1-3 days')
insert into AvailableShippingDate(Ten_AvailableShippingDate) values ('7-21 days')
insert into AvailableShippingDate(Ten_AvailableShippingDate) values ('out stock')


insert into TinhTrang(Ten_TinhTrang) values ('huy bo')
insert into TinhTrang(Ten_TinhTrang) values ('dang xu li')
insert into TinhTrang(Ten_TinhTrang) values ('hoan tat')


insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 1'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2014/05/09'
		, 463
		, '/Content/Image/Book/Cover/c001001.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 2'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2014/10/09'
		, 463
		, '/Content/Image/Book/Cover/c001002.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 3'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2015/03/17'
		, 463
		, '/Content/Image/Book/Cover/c001003.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 4'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2015/05/15'
		, 463
		, '/Content/Image/Book/Cover/c001004.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 5'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2015/07/17'
		, 463
		, '/Content/Image/Book/Cover/c001005.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 6'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2015/10/16'
		, 463
		, '/Content/Image/Book/Cover/c001006.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 7'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2016/01/15'
		, 463
		, '/Content/Image/Book/Cover/c001007.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 8'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2016/03/17'
		, 463
		, '/Content/Image/Book/Cover/c001008.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 9'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2016/05/17'
		, 463
		, '/Content/Image/Book/Cover/c001009.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 10'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2016/07/15'
		, 463
		, '/Content/Image/Book/Cover/c001010.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 11'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2016/09/16'
		, 463
		, '/Content/Image/Book/Cover/c001011.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 12'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2016/11/17'
		, 463
		, '/Content/Image/Book/Cover/c001012.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 13'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2017/02/17'
		, 463
		, '/Content/Image/Book/Cover/c001013.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Real Account 14'
		, 1
		, 1
		, 1
		, 'In a world driven by fictionalized friendship, courtesy of the program named "real account", the table suddenly turns, and the cybernetic world turns real! how will they survive?'		
		, '2017/04/17'
		, 463
		, '/Content/Image/Book/Cover/c001014.png')

insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 1'
		, 2
		, 2
		, 1
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, '2016/03/17'
		, 596
		, '/Content/Image/Book/Cover/c002001.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 2'
		, 2
		, 2
		, 1
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, '2014/12/12'
		, 596
		, '/Content/Image/Book/Cover/c002002.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 3'
		, 2
		, 2
		, 1
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, '2015/05/12'
		, 596
		, '/Content/Image/Book/Cover/c002003.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 4'
		, 2
		, 2
		, 1
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, '2015/08/12'
		, 596
		, '/Content/Image/Book/Cover/c002004.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 5'
		, 2
		, 2
		, 1
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, '2015/11/12'
		, 596
		, '/Content/Image/Book/Cover/c002005.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 6'
		, 2
		, 2
		, 1
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, '2016/03/11'
		, 596
		, '/Content/Image/Book/Cover/c002006.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 7'
		, 2
		, 2
		, 1
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, '2016/07/19'
		, 596
		, '/Content/Image/Book/Cover/c002007.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 8'
		, 2
		, 2
		, 1
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, '2016/11/18'
		, 596
		, '/Content/Image/Book/Cover/c002008.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Helck 9'
		, 2
		, 2
		, 1
		, 'After the last Demon King was defeated, a Demon Kingdom is running a contest to choose the next King. A muscular and high-level human named Helck joined and said that he wants to destroy all human. Is he serious?

Elf "Vamirio", one of the four Great Kings of the whole Demon Empire, cannot believe in this. She is monitoring the contest. The story starts in the Demon Kingdom. What''s the secret behind Helck and the human world?'
		, '2017/04/12'
		, 596
		, '/Content/Image/Book/Cover/c002009.png')

insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Doraemon 1'
		, 3
		, 3
		, 2
		, 'Doraemon, a cat shaped robot which came from the 22nd century in the future, goes back in time in order to help Nobita, a below average lazy kid, to make his life less miserable and improve his descendent''s life. With many of Doreamon''s gadgets from the future, Nobita''s life will never be the same.

Doraemon was awarded the first Shogakukan Manga Award for children''s manga in 1982, and the first Osamu Tezuka Culture Award in 1997.'
		, '1990/01/01'
		, 463
		, '/Content/Image/Book/Cover/c003001.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Doraemon 5'
		, 3
		, 3
		, 2
		, 'Doraemon, a cat shaped robot which came from the 22nd century in the future, goes back in time in order to help Nobita, a below average lazy kid, to make his life less miserable and improve his descendent''s life. With many of Doreamon''s gadgets from the future, Nobita''s life will never be the same.

Doraemon was awarded the first Shogakukan Manga Award for children''s manga in 1982, and the first Osamu Tezuka Culture Award in 1997.'
		, '1990/01/01'
		, 463
		, '/Content/Image/Book/Cover/c003005.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Doraemon 9'
		, 3
		, 3
		, 2
		, 'Doraemon, a cat shaped robot which came from the 22nd century in the future, goes back in time in order to help Nobita, a below average lazy kid, to make his life less miserable and improve his descendent''s life. With many of Doreamon''s gadgets from the future, Nobita''s life will never be the same.

Doraemon was awarded the first Shogakukan Manga Award for children''s manga in 1982, and the first Osamu Tezuka Culture Award in 1997.'
		, '1989/01/01'
		, 463
		, '/Content/Image/Book/Cover/c003009.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Doraemon 10'
		, 3
		, 3
		, 2
		, 'Doraemon, a cat shaped robot which came from the 22nd century in the future, goes back in time in order to help Nobita, a below average lazy kid, to make his life less miserable and improve his descendent''s life. With many of Doreamon''s gadgets from the future, Nobita''s life will never be the same.

Doraemon was awarded the first Shogakukan Manga Award for children''s manga in 1982, and the first Osamu Tezuka Culture Award in 1997.'
		, '1989/01/01'
		, 463
		, '/Content/Image/Book/Cover/c003010.png')

insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Conan 18'
		, 4
		, 4
		, 2
		, '16 year-old Kudo Shinichi, a famous High school detective, treats his friend, Mori Ran to a theme park named Tropical Land. After solving a murder case that occured on the same day, Shinichi notices and tails two people in black. However, one of them notices Shinichi and knocks him out. Instead of killing him, they gave him an untested poison that was supposed to kill him yet leave no traces. However, instead of killing him, it shrunk him into a 8 year old boy. Shinichi now goes under the name Edogawa Conan.'
		, '1998/01/17'
		, 463
		, '/Content/Image/Book/Cover/c004018.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Conan 92'
		, 4
		, 4
		, 2
		, '16 year-old Kudo Shinichi, a famous High school detective, treats his friend, Mori Ran to a theme park named Tropical Land. After solving a murder case that occured on the same day, Shinichi notices and tails two people in black. However, one of them notices Shinichi and knocks him out. Instead of killing him, they gave him an untested poison that was supposed to kill him yet leave no traces. However, instead of killing him, it shrunk him into a 8 year old boy. Shinichi now goes under the name Edogawa Conan.'
		, '2017/04/12'
		, 463
		, '/Content/Image/Book/Cover/c004092.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Conan 91'
		, 4
		, 4
		, 2
		, '16 year-old Kudo Shinichi, a famous High school detective, treats his friend, Mori Ran to a theme park named Tropical Land. After solving a murder case that occured on the same day, Shinichi notices and tails two people in black. However, one of them notices Shinichi and knocks him out. Instead of killing him, they gave him an untested poison that was supposed to kill him yet leave no traces. However, instead of killing him, it shrunk him into a 8 year old boy. Shinichi now goes under the name Edogawa Conan.'
		, '2016/12/16'
		, 463
		, '/Content/Image/Book/Cover/c004091.png')

insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Black Jack 1'
		, 5
		, 5
		, 1
		, 'Black Jack is the doctor Tezuka wished he could be, one free of the constraints of the modern rules, who can heal and help on his rules. He travels the world helping those who pay him, sometime those he takes mercy on, and always those who move him. Despite not having a valid license, he is still the doctor of last resort, the only man who keeps the reaper at bay. Sometimes though, he''s the one who brings the reaper...

Won the 1st Kodansha Manga Award for shounen.'
		, '1989/01/01'
		, 453
		, '/Content/Image/Book/Cover/c005001.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Black Jack 24'
		, 5
		, 5
		, 1
		, 'Black Jack is the doctor Tezuka wished he could be, one free of the constraints of the modern rules, who can heal and help on his rules. He travels the world helping those who pay him, sometime those he takes mercy on, and always those who move him. Despite not having a valid license, he is still the doctor of last resort, the only man who keeps the reaper at bay. Sometimes though, he''s the one who brings the reaper...

Won the 1st Kodansha Manga Award for shounen.'
		, '1989/01/01'
		, 453
		, '/Content/Image/Book/Cover/c005024.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Black Jack 22'
		, 5
		, 5
		, 1
		, 'Black Jack is the doctor Tezuka wished he could be, one free of the constraints of the modern rules, who can heal and help on his rules. He travels the world helping those who pay him, sometime those he takes mercy on, and always those who move him. Despite not having a valid license, he is still the doctor of last resort, the only man who keeps the reaper at bay. Sometimes though, he''s the one who brings the reaper...

Won the 1st Kodansha Manga Award for shounen.'
		, '1989/01/01'
		, 453
		, '/Content/Image/Book/Cover/c005022.png')

insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Gift Å} 1'
		, 6
		, 6
		, 3
		, 'My Manga love, It is about the girl who her name is Tamaki, save and respect human live'
		, '2015/07/18'
		, 637
		, '/Content/Image/Book/Cover/c006001.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Gift Å} 2'
		, 6
		, 6
		, 3
		, 'My Manga love, It is about the girl who her name is Tamaki, save and respect human live'
		, '2015/10/19'
		, 637
		, '/Content/Image/Book/Cover/c006002.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Gift Å} 3'
		, 6
		, 6
		, 3
		, 'My Manga love, It is about the girl who her name is Tamaki, save and respect human live'
		, '2016/01/18'
		, 637
		, '/Content/Image/Book/Cover/c006003.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Gift Å} 4'
		, 6
		, 6
		, 3
		, 'My Manga love, It is about the girl who her name is Tamaki, save and respect human live'
		, '2016/04/18'
		, 637
		, '/Content/Image/Book/Cover/c006004.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Gift Å} 5'
		, 6
		, 6
		, 3
		, 'My Manga love, It is about the girl who her name is Tamaki, save and respect human live'
		, '2016/07/19'
		, 637
		, '/Content/Image/Book/Cover/c006005.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Gift Å} 6'
		, 6
		, 6
		, 3
		, 'My Manga love, It is about the girl who her name is Tamaki, save and respect human live'
		, '2016/10/28'
		, 637
		, '/Content/Image/Book/Cover/c006006.png')
insert into Sach(Ten_Sach, ID_TacGia, ID_Series, ID_NhaXuatBan, NoiDung_Sach, NgayXuatBan_Sach, Gia_Sach, TrangBia_Sach)
	values ('Gift Å} 7'
		, 6
		, 6
		, 3
		, 'My Manga love, It is about the girl who her name is Tamaki, save and respect human live'
		, '2017/02/18'
		, 637
		, '/Content/Image/Book/Cover/c006007.png')


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

insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (3, 4)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (3, 5)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (3, 11)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (3, 31)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (3, 38)

insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (4, 5)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (4, 18)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (4, 26)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (4, 29)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (4, 36)

insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (5, 18)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (5, 32)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (5, 36)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (5, 41)

insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (6, 2)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (6, 15)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (6, 22)
insert into TheLoai_Sach(ID_Series, ID_TheLoai) values (6, 32)

