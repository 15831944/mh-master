using Hao.Launcher.Model;
using System.Collections.Generic;

namespace Hao.Launcher.Data
{
	public class AppConfig
	{
		public List<string> BeePCProductList { get; set; } = new List<string>();

		public bool IsFestivalImgReplay { get; set; } = false;

		public ImageLinkData LocalImageLinkData
		{
			get;
			set;
		}

		public bool NotifyIconIsShow { get; set; } = false;

		/// <summary>
		/// ��ǰ��QQ��·��
		/// </summary>
		public string QQUrl
		{
			get
			{
				return "tencent://groupwpa/?subcmd=all&param=7B2267726F757055696E223A3631343033313033342C2274696D655374616D70223A313536303333313634377D0A";
			}
		}

		/// <summary>
		/// ��ǰ��PC��ѡ��
		/// </summary>
		public string SelectBeePC
		{
			get;
			set;
		}

		/// <summary>
		/// ��ǰ��Revit�汾��ѡ��
		/// </summary>
		public string SelectRevit
		{
			get;
			set;
		}

		/// <summary>
		/// ��ȡ������·��
		/// </summary>
		public string WeatherUrl
		{
			get
			{
				return "https://tianqiapi.com/api.php?style=tv&skin=banana&align=center&paddingtop=25&fontsize=16&color=f8f8f8";
			}
		}

		/// <summary>
		/// �����ļ��Ĺ��캯��
		/// </summary>
		public AppConfig()
		{
		}
	}
}