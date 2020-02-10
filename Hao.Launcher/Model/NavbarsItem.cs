using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Linq;

namespace Hao.Launcher.Model
{
	/// <summary>
	/// ��ǰ�ĵ����˵�
	/// </summary>
	public class NavbarsItem : ViewModelBase
	{
		public bool Carousel { get; set; } = true;

		/// <summary>
		/// ��ǰ��ͼƬ�б�
		/// </summary>
		public List<ImagesItem> Images
		{
			get;
			set;
		}
		/// <summary>
		/// ��ǰ�ĵ�������
		/// </summary>
		public string NavbarName
		{
			get;
			set;
		}
		/// <summary>
		/// ��ǰ��������
		/// </summary>
		public int NewCount
		{
			get
			{
				int num = this.Images.Count<ImagesItem>((ImagesItem item) => item.IsNew);
				return num;
			}
		}

		/// <summary>
		/// ��ǰ�Ĺ��캯��
		/// </summary>
		public NavbarsItem()
		{
			base.MessengerInstance.Register<ImagesItem>(this, "IsNew", (ImagesItem item) => this.RaisePropertyChanged("NewCount"), false);
		}
	}
}