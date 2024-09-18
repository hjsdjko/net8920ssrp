using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 用户
    /// </summary>
    [SugarTable("yonghu")]
	public class YonghuDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 用户账号
		/// </summary>
		[SugarColumn(ColumnName = "yonghuzhanghao")]
		public string Yonghuzhanghao { get; set; }

		/// <summary>
		/// Desc: 密码
		/// </summary>
		[SugarColumn(ColumnName = "mima")]
		public string Mima { get; set; }

		/// <summary>
		/// Desc: 用户姓名
		/// </summary>
		[SugarColumn(ColumnName = "yonghuxingming")]
		public string Yonghuxingming { get; set; }

		/// <summary>
		/// Desc: 头像
		/// </summary>
		[SugarColumn(ColumnName = "touxiang")]
		public string Touxiang { get; set; }

		/// <summary>
		/// Desc: 性别
		/// </summary>
		[SugarColumn(ColumnName = "xingbie")]
		public string Xingbie { get; set; }

		/// <summary>
		/// Desc: 联系方式
		/// </summary>
		[SugarColumn(ColumnName = "lianxifangshi")]
		public string Lianxifangshi { get; set; }

		/// <summary>
		/// Desc: 余额
		/// </summary>
        [SugarColumn(ColumnName = "money")]
		public double? Money { get; set; } = 0;

		/// <summary>
		/// Desc: 状态
		/// </summary>
        [SugarColumn(ColumnName = "status")]
		public int? Status { get; set; } = 0;

		/// <summary>
		/// Desc: 密码错误次数
		/// </summary>
        [SugarColumn(ColumnName = "passwordwrongnum")]
		public int? Passwordwrongnum { get; set; } = 0;

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
