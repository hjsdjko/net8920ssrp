using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 入库信息
    /// </summary>
    [SugarTable("rukuxinxi")]
	public class RukuxinxiDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 入库单号
		/// </summary>
		[SugarColumn(ColumnName = "rukudanhao")]
		public string Rukudanhao { get; set; }

		/// <summary>
		/// Desc: 商品名称
		/// </summary>
		[SugarColumn(ColumnName = "shangpinmingcheng")]
		public string Shangpinmingcheng { get; set; }

		/// <summary>
		/// Desc: 图片
		/// </summary>
		[SugarColumn(ColumnName = "tupian")]
		public string Tupian { get; set; }

		/// <summary>
		/// Desc: 相机类型
		/// </summary>
		[SugarColumn(ColumnName = "xiangjileixing")]
		public string Xiangjileixing { get; set; }

		/// <summary>
		/// Desc: 库存
		/// </summary>
        [SugarColumn(ColumnName = "alllimittimes")]
		public int? Alllimittimes { get; set; } = 0;

		/// <summary>
		/// Desc: 供应商名称
		/// </summary>
		[SugarColumn(ColumnName = "gongyingshangmingcheng")]
		public string Gongyingshangmingcheng { get; set; }

		/// <summary>
		/// Desc: 备注
		/// </summary>
		[SugarColumn(ColumnName = "beizhu")]
		public string Beizhu { get; set; }

		/// <summary>
		/// Desc: 入库时间
		/// </summary>
        [SugarColumn(ColumnName = "rukushijian")]
		public DateTime? Rukushijian { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
