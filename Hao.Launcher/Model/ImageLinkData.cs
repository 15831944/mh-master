using GalaSoft.MvvmLight;
using System.Collections.Generic;

namespace Hao.Launcher.Model
{
	/// <summary>
	/// ��ǰ����������
	/// </summary>
	public class ImageLinkData : ViewModelBase
	{
		public Model.FestivalImg FestivalImg
		{
			get;
			set;
		}

		/// <summary>
		/// ��ǰ�ĵ����˵�
		/// </summary>
		public List<NavbarsItem> Navbars
		{
			get;
			set;
		}

		public int Version
		{
			get;
			set;
		}

		public ImageLinkData()
		{
		}
	}
}