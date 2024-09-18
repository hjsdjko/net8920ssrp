using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 留言反馈
    /// </summary>
    [SugarTable("messages")]
	public class MessagesDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 留言人id
		/// </summary>
        [SugarColumn(ColumnName = "userid")]
		public long? Userid { get; set; } = 0;

		/// <summary>
		/// Desc: 用户名
		/// </summary>
		[SugarColumn(ColumnName = "username")]
		public string Username { get; set; }

		/// <summary>
		/// Desc: 头像
		/// </summary>
		[SugarColumn(ColumnName = "avatarurl")]
		public string Avatarurl { get; set; }

		/// <summary>
		/// Desc: 留言内容
		/// </summary>
		[SugarColumn(ColumnName = "content")]
		public string Content { get; set; }

		/// <summary>
		/// Desc: 留言图片
		/// </summary>
		[SugarColumn(ColumnName = "cpicture")]
		public string Cpicture { get; set; }

		/// <summary>
		/// Desc: 回复内容
		/// </summary>
		[SugarColumn(ColumnName = "reply")]
		public string Reply { get; set; }

		/// <summary>
		/// Desc: 回复图片
		/// </summary>
		[SugarColumn(ColumnName = "rpicture")]
		public string Rpicture { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
