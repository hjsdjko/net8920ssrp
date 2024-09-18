using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 热卖相机
    /// </summary>
    [SugarTable("remaixiangji")]
	public class RemaixiangjiDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 商品编号
		/// </summary>
		[SugarColumn(ColumnName = "shangpinbianhao")]
		public string Shangpinbianhao { get; set; }

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
		/// Desc: 品牌
		/// </summary>
		[SugarColumn(ColumnName = "pinpai")]
		public string Pinpai { get; set; }

		/// <summary>
		/// Desc: 型号
		/// </summary>
		[SugarColumn(ColumnName = "xinghao")]
		public string Xinghao { get; set; }

		/// <summary>
		/// Desc: 像素
		/// </summary>
		[SugarColumn(ColumnName = "xiangsu")]
		public string Xiangsu { get; set; }

		/// <summary>
		/// Desc: 清晰度
		/// </summary>
		[SugarColumn(ColumnName = "qingxidu")]
		public string Qingxidu { get; set; }

		/// <summary>
		/// Desc: 商品详情
		/// </summary>
		[SugarColumn(ColumnName = "shangpinxiangqing")]
		public string Shangpinxiangqing { get; set; }

		/// <summary>
		/// Desc: 单限
		/// </summary>
        [SugarColumn(ColumnName = "onelimittimes")]
		public int? Onelimittimes { get; set; } = 0;

		/// <summary>
		/// Desc: 库存
		/// </summary>
        [SugarColumn(ColumnName = "alllimittimes")]
		public int? Alllimittimes { get; set; } = 0;

		/// <summary>
		/// Desc: 最近点击时间
		/// </summary>
        [SugarColumn(ColumnName = "clicktime")]
		public DateTime? Clicktime { get; set; }

		/// <summary>
		/// Desc: 点击次数
		/// </summary>
        [SugarColumn(ColumnName = "clicknum")]
		public int? Clicknum { get; set; } = 0;

		/// <summary>
		/// Desc: 评论数
		/// </summary>
        [SugarColumn(ColumnName = "discussnum")]
		public int? Discussnum { get; set; } = 0;

		/// <summary>
		/// Desc: 价格
		/// </summary>
        [SugarColumn(ColumnName = "price")]
		public double? Price { get; set; } = 0;

		/// <summary>
		/// Desc: 收藏数
		/// </summary>
        [SugarColumn(ColumnName = "storeupnum")]
		public int? Storeupnum { get; set; } = 0;

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
