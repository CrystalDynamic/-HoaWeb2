



















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `BanSachOnlineConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=YURIHONJO\HONTO;Initial Catalog=BanSachOnline;User ID=sa;Password=wendy`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace BanSachOnlineConnection
{

	public partial class BanSachOnlineConnectionDB : Database
	{
		public BanSachOnlineConnectionDB() 
			: base("BanSachOnlineConnection")
		{
			CommonConstruct();
		}

		public BanSachOnlineConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			BanSachOnlineConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static BanSachOnlineConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new BanSachOnlineConnectionDB();
        }

		[ThreadStatic] static BanSachOnlineConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static BanSachOnlineConnectionDB repo { get { return BanSachOnlineConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.BinhLuan")]



	[PrimaryKey("recID")]




	[ExplicitColumns]

    public partial class BinhLuan : BanSachOnlineConnectionDB.Record<BinhLuan>  
    {



		[Column] public int recID { get; set; }





		[Column] public int ID_Sach { get; set; }





		[Column] public int ID_KH { get; set; }





		[Column] public string NoiDung { get; set; }





		[Column] public DateTime? Ngay { get; set; }



	}

    

	[TableName("dbo.DatHang")]



	[PrimaryKey("recID")]




	[ExplicitColumns]

    public partial class DatHang : BanSachOnlineConnectionDB.Record<DatHang>  
    {



		[Column] public int recID { get; set; }





		[Column] public int ID_KH { get; set; }





		[Column] public DateTime? NgayDat { get; set; }





		[Column] public decimal? DonGia { get; set; }





		[Column] public int? TinhTrang { get; set; }



	}

    

	[TableName("dbo.DatHangChiTiet")]



	[PrimaryKey("ID_DatHang", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class DatHangChiTiet : BanSachOnlineConnectionDB.Record<DatHangChiTiet>  
    {



		[Column] public int ID_DatHang { get; set; }





		[Column] public int ID_Sach { get; set; }





		[Column] public int? SoLuong { get; set; }





		[Column] public decimal? Gia { get; set; }





		[Column] public decimal? ThanhTien { get; set; }



	}

    

	[TableName("dbo.GiaoHang")]



	[PrimaryKey("recID")]




	[ExplicitColumns]

    public partial class GiaoHang : BanSachOnlineConnectionDB.Record<GiaoHang>  
    {



		[Column] public int recID { get; set; }





		[Column] public string Ten { get; set; }



	}

    

	[TableName("dbo.GiaoHang_Sach")]



	[PrimaryKey("ID_Sach", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class GiaoHang_Sach : BanSachOnlineConnectionDB.Record<GiaoHang_Sach>  
    {



		[Column] public int ID_Sach { get; set; }





		[Column] public int ID_GiaoHang { get; set; }



	}

    

	[TableName("dbo.KhachHang")]



	[PrimaryKey("recID")]




	[ExplicitColumns]

    public partial class KhachHang : BanSachOnlineConnectionDB.Record<KhachHang>  
    {



		[Column] public int recID { get; set; }





		[Column] public string Ten { get; set; }





		[Column] public string DiaChi { get; set; }





		[Column] public string SDT { get; set; }





		[Column] public int? ID_TaiKhoan { get; set; }



	}

    

	[TableName("dbo.Sach")]



	[PrimaryKey("recID")]




	[ExplicitColumns]

    public partial class Sach : BanSachOnlineConnectionDB.Record<Sach>  
    {



		[Column] public int recID { get; set; }





		[Column] public string Ten { get; set; }





		[Column] public int? ID_TacGia { get; set; }





		[Column] public int? ID_Series { get; set; }





		[Column] public string NoiDung { get; set; }





		[Column] public string NhaXuatBan { get; set; }





		[Column] public DateTime? NgayXuatBan { get; set; }





		[Column] public decimal? Gia { get; set; }





		[Column] public string TrangBia { get; set; }





		[Column] public int? BinhLuan { get; set; }





		[Column] public int? DanhGia { get; set; }





		[Column] public int? BiXoa { get; set; }



	}

    

	[TableName("dbo.Series")]



	[PrimaryKey("recID")]




	[ExplicitColumns]

    public partial class Series : BanSachOnlineConnectionDB.Record<Series>  
    {



		[Column] public int recID { get; set; }





		[Column] public string Ten { get; set; }





		[Column] public string TrangBia { get; set; }



	}

    

	[TableName("dbo.TacGia")]



	[PrimaryKey("recID")]




	[ExplicitColumns]

    public partial class TacGium : BanSachOnlineConnectionDB.Record<TacGium>  
    {



		[Column] public int recID { get; set; }





		[Column] public string Ten { get; set; }



	}

    

	[TableName("dbo.TaiKhoan")]



	[PrimaryKey("recID")]




	[ExplicitColumns]

    public partial class TaiKhoan : BanSachOnlineConnectionDB.Record<TaiKhoan>  
    {



		[Column] public int recID { get; set; }





		[Column] public string TenDangNhap { get; set; }





		[Column] public string MatKhau { get; set; }





		[Column] public int? BiXoa { get; set; }



	}

    

	[TableName("dbo.TheLoai")]



	[PrimaryKey("recID")]




	[ExplicitColumns]

    public partial class TheLoai : BanSachOnlineConnectionDB.Record<TheLoai>  
    {



		[Column] public int recID { get; set; }





		[Column] public string Ten { get; set; }



	}

    

	[TableName("dbo.TheLoai_Sach")]



	[PrimaryKey("ID_Sach", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class TheLoai_Sach : BanSachOnlineConnectionDB.Record<TheLoai_Sach>  
    {



		[Column] public int ID_Sach { get; set; }





		[Column] public int ID_TheLoai { get; set; }



	}

    

	[TableName("dbo.TinhTrang")]



	[PrimaryKey("recID")]




	[ExplicitColumns]

    public partial class TinhTrang : BanSachOnlineConnectionDB.Record<TinhTrang>  
    {



		[Column] public int recID { get; set; }





		[Column] public string Ten { get; set; }



	}


}
