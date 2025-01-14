﻿/**
 * 作者	: Hikaru
 * 日期	: 2011/10/2
 * 时间	: 3:14
 * QQ	: 39396682
 * Email: admin@kansea.com
 * 网站	: http://kansea.com  
 * 声明	: 未经作者许可，任何人不得发布出售该源码，请尊重别人的劳动成果，谢谢大家支持 
 */
using System;

namespace ilab.KanSea.Chat.Helper.model
{
	/// <summary>
	/// information model
	/// </summary>
    [Serializable]
    public class iMessage : IEquatable<iMessage>
	{
		#region 属性
        /// <summary>
        /// Message
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Translation
        /// </summary>
        public string Content_Trans { get; set; }
        /// <summary>
        /// Hot message
        /// </summary>
        public string HotMessage { get; set; }
        /// <summary>
        /// The Translation of hot massage
        /// </summary>
        public string HotMessage_Trans { get; set; }
        /// <summary>
        /// date
        /// </summary>
        public DateTime SendDate {get;set;}
        #endregion

        #region 方法
        public bool Equals(iMessage other)
        {
            //Check whether the compared object is null.
            if (Object.ReferenceEquals(other, null)) return false;

            //Check whether the compared object references the same data.
            if (Object.ReferenceEquals(this, other)) return true;

            //Check whether the products' properties are equal.
            return true;
        }
        #endregion
	}
}
